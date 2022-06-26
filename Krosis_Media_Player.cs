using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using NAudio.Wave;
using System.Threading;
using System.Configuration;
using System.Windows.Controls.Primitives;
using System.Threading.Tasks;
using Krosis_Media_Player.Classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Krosis_Media_Player
{

    public partial class Krosis_Media_Player : Form
    {
        DB Con;
        ML_Info LIB;
        int numOfFiles;
        int indx;
        int ID_Album;
        int ID_Song;
        int ID_Playlist;
        string Album_Name;
        string addedSongPath;
        string ML_Filepath;
        string[] Info;
        bool isPlayingPlaylist;
        bool updateTrackBar;
        bool isPlaying;
        bool isShuffling;
        bool estoyLooping;
        List<Playlist> playList;
        private AudioFileReader audioFile = null;
        private IWavePlayer player = new WaveOut();
        private ListViewColumnSorter lvwColumnSorter;

        bool isMaximized;
        bool mouseDown;
        int mouseX, mouseY;
         

        private struct CurrentSong
        {
            public string Title;
            public string Artist;
        }
        private CurrentSong currentSong = new CurrentSong();

        private bool abortThread = false;
        private bool pauseThread = false;
        private object threadLock = new object();
        delegate void IncrementValueCallback();
        UserActivityHook actHook;

        public Krosis_Media_Player()
        {
            this.Padding = new System.Windows.Forms.Padding(3);
            Con = new DB();
            Con.ConexionDB();
            LIB = new ML_Info();
            Info = Con.spSelect_Krosis_Info();
            InitializeComponent();
            LIB = Con.spSelect_ML_Info();
            if (LIB.isPathSet != 1)
            {
                firstTimeSettup();
            }
            else 
            {
                ML_Filepath = LIB.ML_Path;
            }
            actHook = new UserActivityHook();
            actHook.KeyDown += new KeyEventHandler(MyKeyDown);
            actHook.KeyPress += new KeyPressEventHandler(MyKeyPress);
            actHook.KeyUp += new KeyEventHandler(MyKeyUp);
            LBL_Albums.Text = "Number of Active Albums: " + Info[0]; 
            LBL_Songs.Text = "Number of Active Songs: " + Info[1];
            lvwColumnSorter = new ListViewColumnSorter();
            this.Song_List.ListViewItemSorter = lvwColumnSorter;
        }
        public void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "MediaNextTrack")
            {
                if (isShuffling)
                {
                    ShuffleNEXT();
                }
                else
                {
                    NEXT();
                }
            }
            if (e.KeyData.ToString() == "MediaPreviousTrack")
            {
                if (isShuffling)
                {
                    ShuffleNEXT();
                }
                else
                {
                    PREV();
                }
            }
            if (e.KeyData.ToString() == "MediaPlayPause")
            {
                try
                {
                    if (!isPlaying)
                    {
                        // Revert song to beginning if the end was reached and the user hit play
                        if (musicTrackBar.Value == musicTrackBar.Maximum)
                        {
                            audioFile.CurrentTime = TimeSpan.FromSeconds(0);
                            elapsedTime.Text = "0:00";
                            musicTrackBar.Value = 0;
                        }
                        if (audioFile != null)
                        {
                            player.Play();
                            ResumeThread();
                            isPlaying = true;
                            updateTrackBar = true;
                            BTN_Play.BackgroundImage = Properties.Resources.KRPause;
                        }
                    }
                    else
                    {
                        PauseThread();
                        player.Pause();
                        isPlaying = false;
                        updateTrackBar = false;
                        BTN_Play.BackgroundImage = Properties.Resources.KRPlay;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No song Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        public void MyKeyPress(object sender, KeyPressEventArgs e)
        {
        }

        public void MyKeyUp(object sender, KeyEventArgs e)
        {
        }

        public void firstTimeSettup()
        {
            MessageBox.Show("Please select a Path to create your Music Library" + "\n \n" + "WARNING THIS CANNOT BE CHANGED LATER ", "First Time Setup", MessageBoxButtons.OK, MessageBoxIcon.Question);
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            this.CenterToScreen();
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (!Directory.Exists(Path.Combine(dialog.FileName, "Krosis_ML")))
                {
                    Directory.CreateDirectory(Path.Combine(dialog.FileName, "Krosis_ML"));
                    ML_Filepath = Path.Combine(dialog.FileName, "Krosis_ML");
                    Con.Set_ML_Info(ML_Filepath);
                }
            }
            else
            {
                MessageBox.Show("You HAVE to set your Music Library at least once" + "\n \n" + "Dumbass...", "Retard Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



        #region UI stuff

        private int tolerance = 16;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            this.BringToFront();
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panel7.Region = region;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.BringToFront();
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        #endregion


        private void Krosis_Media_Player_Load(object sender, EventArgs e)
        {
            Con.List_Of_Albums(Album_List);
            User_Playlists.DataSource = Con.Select_Playlists();
            User_Playlists.ValueMember = "ID_Playlist";
            User_Playlists.DisplayMember = "Playlist_Name";
            Song_List.HideSelection = false;
        }

        private void BTN_Maximize_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
            else if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
        }

        private void BTN_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Control_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void Main_Control_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
                if (isMaximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.CenterToScreen();
                    isMaximized = false;
                }
            }
        }

        private void Main_Control_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Main_Control_Bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BTN_Play_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isPlaying)
                {
                    // Revert song to beginning if the end was reached and the user hit play
                    if (musicTrackBar.Value == musicTrackBar.Maximum)
                    {
                        audioFile.CurrentTime = TimeSpan.FromSeconds(0);
                        elapsedTime.Text = "0:00";
                        musicTrackBar.Value = 0;
                    }
                    if (audioFile != null)
                    {
                        player.Play();
                        ResumeThread();
                        isPlaying = true;
                        updateTrackBar = true;
                        BTN_Play.BackgroundImage = Properties.Resources.KRPause;
                    }
                }
                else
                {
                    PauseThread();
                    player.Pause();
                    isPlaying = false;
                    updateTrackBar = false;
                    BTN_Play.BackgroundImage = Properties.Resources.KRPlay;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No song Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void IncrementPlaybackValues()
        {
            try
            {
                if (audioFile != null)
                {
                    musicTrackBar.Value = (int)audioFile.CurrentTime.TotalSeconds;
                }
            }
            catch (System.NullReferenceException)
            {
                return;
            }

        }
        private void UpdateElapsedTime()
        {
            TimeSpan songPosition = audioFile.CurrentTime;

            string seconds = songPosition.Seconds.ToString();
            if (songPosition.Seconds < 10)
                seconds = "0" + seconds;

            elapsedTime.Text = songPosition.Minutes.ToString() + ":" + seconds;


            if (musicTrackBar.Value == musicTrackBar.Maximum)
            {
                audioFile.CurrentTime = TimeSpan.FromSeconds(0);
                elapsedTime.Text = "0:00";
                musicTrackBar.Value = 0;
                if (!estoyLooping)
                {
                    NEXT();
                }
                else if (estoyLooping)
                {
                    LOOP();
                }
                else if (!isShuffling)
                {
                    NEXT();
                }
                else if (isShuffling)
                {
                    ShuffleNEXT();
                }
            }

        }
        private void ThreadUpdatePlayback()
        {
            while (!abortThread)
            {
                if (pauseThread)
                {
                    lock (threadLock)
                    {
                        Monitor.Wait(threadLock);
                    }
                }

                Thread.Sleep(2000);

                try
                {
                    // Attempt to update playback controls
                    IncrementValueCallback d = new IncrementValueCallback(IncrementPlaybackValues);
                    Invoke(d, new object[] { });
                }
                catch (Exception)
                {
                    break;
                }

            }
        }
        private void PlaybackHandler(MouseEventArgs e)
        {
            // Jumps to arbitrary point on trackbar the user clicks
            if (e != null)
            {
                double dblValue = ((double)e.X / (double)musicTrackBar.Width) * (musicTrackBar.Maximum - musicTrackBar.Minimum);
                musicTrackBar.Value = Convert.ToInt32(dblValue);
            }

            audioFile.CurrentTime = TimeSpan.FromSeconds(musicTrackBar.Value);

            // Hacky fix for NAudio's IWavePlayer that would stop playback and dispose of the AudioFileReader
            if (musicTrackBar.Value == musicTrackBar.Maximum)
            {
                isPlaying = false;
                PauseThread();
                player.Pause();
            }

            if (isPlaying == true)
            {
                player.Play();
                ResumeThread();
            }

            UpdateElapsedTime();
        }

        private void StartThread()
        {
            abortThread = false;
            lock (threadLock)
            {
                Thread thread = new Thread(new ThreadStart(ThreadUpdatePlayback));
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void PauseThread()
        {
            pauseThread = true;
        }

        private void ResumeThread()
        {
            pauseThread = false;
            lock (threadLock)
            {
                Monitor.PulseAll(threadLock);
            }
        }

        private void AbortThread()
        {
            abortThread = true;
        }


        private void ChangeVisibility(bool playback_is_visible)
        {
            Current_Song_Name.Visible = playback_is_visible;
            Current_Album_Artist.Visible = playback_is_visible;
            Album_Art.Visible = playback_is_visible;
        }

        private void ResetPlaybackPanel()
        {
            TimeSpan songLength = audioFile.TotalTime;
            int songSeconds = songLength.Minutes * 60 + songLength.Seconds;

            musicTrackBar.Maximum = songSeconds;
            musicTrackBar.Value = 0;

            string seconds = songLength.Seconds.ToString();
            if (songLength.Seconds < 10)
                seconds = "0" + seconds;

            totalTime.Text = songLength.Minutes.ToString() + ":" + seconds;
            elapsedTime.Text = "0:00";
        }

        private void UpdateSongDisplayInfo(Songs_In_Album Song )
        {
            try
            {
                try
                {
                    Album_Art.BackgroundImage = Image.FromFile(Song.Image_File_Path);
                }
                catch (Exception)
                {
                    Album_Art.BackgroundImage = Properties.Resources.No_Art;
                }

                if (isPlayingPlaylist)
                {
                    Other_Album_Art.BackgroundImage = Image.FromFile(Con.Select_Playlist_ImagePath(ID_Playlist));
                }
                else
                {
                    Other_Album_Art.BackgroundImage = Image.FromFile(Song.Image_File_Path);
                }
                Album_Art.Left = (ClientSize.Width - Album_Art.Width) / 2;
            }
            catch (Exception)
            {
                Other_Album_Art.BackgroundImage = Properties.Resources.No_Art;
            }
            Current_Song_Name.Visible = true;
            Current_Album_Artist.Visible = true;
            Current_Album.Visible = true;
            Selected_Albumlbl.Visible = true;
            selected_Artistlbl.Visible = true;

            if (isPlayingPlaylist)
            {
                try
                {
                    Other_Album_Art.BackgroundImage = Image.FromFile(Con.Select_Playlist_ImagePath(ID_Playlist));
                }
                catch (Exception)
                {
                    Other_Album_Art.BackgroundImage = Properties.Resources.No_Art;
                }
                Selected_Albumlbl.Text = User_Playlists.GetItemText(User_Playlists.SelectedItem); 
                selected_Artistlbl.Text = "Playlist";

            }
            else
            {
                 try
                {
                    Other_Album_Art.BackgroundImage = Image.FromFile(Song.Image_File_Path);
                }
                catch (Exception)
                {
                    Other_Album_Art.BackgroundImage = Properties.Resources.No_Art;
                }
                Selected_Albumlbl.Text = Song.Album_Name;
                selected_Artistlbl.Text = Song.Composer;
            }
            Current_Song_Name.Text = Song.Song_Name;
            Current_Album.Text = Song.Album_Name;
            Current_Album_Artist.Text = Song.Composer;
        }

        private void musicTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            PlaybackHandler(e);
        }

        private void musicTrackBar_Scroll(object sender, EventArgs e)
        {
            PlaybackHandler(null);
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            if (isShuffling)
            {
                ShuffleNEXT();
            }
            else 
            {
                NEXT();
            }
        }

        private void showAlbumSongs()
        {
            if (Song_List.Visible == false)
            {
                BTN_DELETE_Playlist.Visible = false;
                LBL_Albums.Visible = false;
                LBL_Songs.Visible = false;
                isPlayingPlaylist = false;
                Song_List.Visible = true;
                Song_List.MultiSelect = true;
                BTN_Add_Song.Visible = true;
                BTN_Edit_Song.Visible = true;
                BTN_Modify_Album.Visible = false;
                BTN_Add_Song.BringToFront();
                BTN_Edit_Song.BringToFront();
                Other_Album_Art.SizeMode = PictureBoxSizeMode.CenterImage;
                Selected_Albumlbl.Visible = true;
                selected_Artistlbl.Visible = true;
                Album_List.Visible = false;
            }
            else{ return; }
        }

        private void showSS()
        {
            if (Song_List.Visible == false)
            {
                BTN_DELETE_Playlist.Visible = false;
                BTN_Mod_Playlist.Visible = false;
                isPlayingPlaylist = false;
                Song_List.Visible = true;
                Song_List.MultiSelect = false;
                BTN_Add_Song.Visible = false;
                BTN_Edit_Song.Visible = false;
                BTN_Modify_Album.Visible = false;
                BTN_Add_Song.BringToFront();
                BTN_Edit_Song.BringToFront();
                Other_Album_Art.SizeMode = PictureBoxSizeMode.CenterImage;
                Selected_Albumlbl.Visible = true;
                selected_Artistlbl.Visible = true;
                Album_List.Visible = false;
            }
            else { return; }
        }
        private void showAlPlaylistSongs()
        {
            if (Song_List.Visible == false)
            {
                isPlayingPlaylist = true;
                Song_List.Visible = true;
                LBL_Albums.Visible = false;
                LBL_Songs.Visible = false;
                Song_List.MultiSelect = true;
                BTN_Modify_Album.Visible = false;
                BTN_Add_Song.BringToFront();
                BTN_Edit_Song.BringToFront();
                Other_Album_Art.SizeMode = PictureBoxSizeMode.CenterImage;
                Selected_Albumlbl.Visible = true;
                selected_Artistlbl.Visible = true;
                Album_List.Visible = false;
                BTN_Add_Song.Visible = false;
                BTN_Edit_Song.Visible = false;
            }
            else { return; }
        }

        private void Homefunc()
        {
            if (Album_List.Visible == false)
            {
                BTN_DELETE_Playlist.Visible = false;
                BTN_Mod_Playlist.Visible = false;
                LBL_Albums.Visible = false;
                LBL_Songs.Visible = false;
                Song_List.Visible = false;
                BTN_Add_Song.Visible = false;
                BTN_Edit_Song.Visible = false;
                BTN_Modify_Album.Visible = true;
                BTN_Modify_Album.BringToFront();
                BTN_Add_Song.BringToFront();
                BTN_Edit_Song.BringToFront();
                Album_List.Visible = true;
            }
            else { return; }
        }



        private void CleanUp()
        {
            AbortThread();
            player.Stop();

            try { audioFile.Dispose(); }
            catch (Exception e) { Console.WriteLine("Exception whiling disposing AudioFileReader: " + e.Message); }

            player.Dispose();
        }

        private Songs_In_Album Get_Song_Info()
        {
            Songs_In_Album song = new Songs_In_Album();
            try
            {
                song.Album_Name = Song_List.SelectedItems[0].SubItems[3].Text;
                song.ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                song.Song_Name = Song_List.SelectedItems[0].SubItems[0].Text;
                song.File_Path = Song_List.SelectedItems[0].SubItems[2].Text;
                song.Times_Listened = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[6].Text);
                song.Song_Duration = Song_List.SelectedItems[0].SubItems[5].Text;
                song.Active = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[6].Text);
                song.Composer = Song_List.SelectedItems[0].SubItems[4].Text;
                song.Image_File_Path = Song_List.SelectedItems[0].SubItems[8].Text;
                return song;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "File path read error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return song;
            }
        }

        private void Main_Content_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Album_List_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Song_List_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            try
            {
                this.Song_List.ListViewItemSorter = null;
                showSS();
                LBL_Albums.Visible = true;
                LBL_Songs.Visible = true;
                BTN_Add_Song.Visible = false;
                BTN_Edit_Song.Visible = false;
                BTN_Mod_Playlist.Visible = false;
                BTN_DELETE_Playlist.Visible = false;
                isPlayingPlaylist = false;
                Con.Select_Super_Shuffle_Songs(Song_List);
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void BTN_Add_New_Album_Click(object sender, EventArgs e)
        {
            Add_New_Album NEW_Album = new Add_New_Album();
            NEW_Album.FormClosed += new FormClosedEventHandler(NEW_AlbumFormClosed);
            NEW_Album.ShowDialog();
        }

        private void NEW_AlbumFormClosed(object sender, FormClosedEventArgs e) 
        {
            Con.List_Of_Albums(Album_List);
        }

        private void BTN_Add_Song_Click(object sender, EventArgs e)
        {
            numOfFiles = 0;
            try
            { 
                using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "Music Files(*.MP3;*.WAV)|*.MP3;*.WAV|All files (*.*)|*.*" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {

                            Adding_Songs_Panel.Visible = true;
                            Adding_Songs_Panel.BringToFront();
                            BGWorker_Add_Songs.RunWorkerAsync(ofd.FileNames);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error parsing file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Album_Art_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Home_Click(object sender, EventArgs e)
        {
            Song_List.MultiSelect = false;
            Homefunc();
        }

        private void Song_List_DrawColumnHeader_1(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            
        }

        private void Song_List_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void BTN_Previous_Click(object sender, EventArgs e)
        {
            if (isShuffling)
            {
                ShuffleNEXT();
            }
            else
            {
                PREV();
            }
        }
        private void NEXT() 
        {
            if (audioFile != null)
            {
                CleanUp();
            }
            try
            {
                Song_List.SelectedItems.Clear();
                indx++;
                this.Song_List.Focus();
                Song_List.FocusedItem = Song_List.Items[indx];
                Song_List.Items[indx].Selected = true;
                Song_List.Select();
                ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                Play(Get_Song_Info());
            }
            catch (Exception)
            {
                try
                {
                    indx = 0;
                    this.Song_List.Focus();
                    this.Song_List.Items[0].Selected = true;
                    ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                    Play(Get_Song_Info());
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    return;
                }
            }

        }

        private void PREV()
        {
            if (audioFile != null)
            {
                CleanUp();
            }
            try
            {
                Song_List.SelectedItems.Clear();
                indx--;
                this.Song_List.Focus();
                Song_List.FocusedItem = Song_List.Items[indx];
                Song_List.Items[indx].Selected = true;
                Song_List.Select();
                ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                Play(Get_Song_Info());
            }
            catch (Exception)
            {
                try
                {
                    indx = 0;
                    this.Song_List.Focus();
                    this.Song_List.Items[0].Selected = true;
                    ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                    Play(Get_Song_Info());
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }
        private void LOOP()
        {
            if (audioFile != null)
            {
                CleanUp();
            }
            try
            {
                this.Song_List.Focus();
                Song_List.FocusedItem = Song_List.Items[indx];
                Song_List.Items[indx].Selected = true;
                Song_List.Select();
                ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                Play(Get_Song_Info());
            }
            catch (Exception)
            {
                try
                {
                    indx = 0;
                    this.Song_List.Focus();
                    this.Song_List.Items[0].Selected = true;
                    ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                    Play(Get_Song_Info());
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }
        static Random random = new Random();
        private void ShuffleNEXT()
        {
            if (audioFile != null)
            {
                CleanUp();
            }
            try
            {
                Song_List.SelectedItems.Clear();
                indx = checkRando(indx);
                this.Song_List.Focus();
                Song_List.FocusedItem = Song_List.Items[indx];
                Song_List.Items[indx].Selected = true;
                Song_List.Select();
                ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                Play(Get_Song_Info());
            }
            catch (Exception)
            {
                try
                {
                    indx = 0;
                    this.Song_List.Focus();
                    this.Song_List.Items[0].Selected = true;
                    ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                    Play(Get_Song_Info());
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }
        private int checkRando(int index) 
        {
            int idx = random.Next(0, Song_List.Items.Count - 1);
            if (index == idx)
            {
                return index + 2;
            }
            else return idx;

        }
        

        private void Album_List_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Song_List.ListViewItemSorter = lvwColumnSorter;
            showAlbumSongs();
            if (Album_List.SelectedItems.Count == 0)
                return;
            try
            {
                ID_Album = Convert.ToInt32(Album_List.SelectedItems[0].SubItems[1].Text);
                Album_Name = Album_List.SelectedItems[0].SubItems[0].Text;
                Con.List_Album_Songs(ID_Album, Song_List);
                BTN_Add_Song.Enabled = true;
                BTN_Edit_Song.Enabled = true;
            }
            catch (Exception ex)
            {
                BTN_Add_Song.Enabled = false;
                BTN_Edit_Song.Enabled = false;
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }

        private void Song_List_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (isPlayingPlaylist)
                {
                    var fcusedItem = Song_List.FocusedItem;
                    if (fcusedItem != null && fcusedItem.Bounds.Contains(e.Location))
                    {
                        CTXMS_Playlist.Show(Cursor.Position);
                    }
                }
                else
                {
                    var focusedItem = Song_List.FocusedItem;
                    if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                    {
                        CTXMS_Sog_List.Show(Cursor.Position);
                    }
                }

            }
            if (!ModifierKeys.HasFlag(Keys.Control))
            {
                if (e.Button == MouseButtons.Left)
                {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    if (Song_List.FocusedItem.Index != null)
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    {
                        indx = Song_List.FocusedItem.Index;
                    }

                    if (audioFile != null)
                    {
                        CleanUp();
                    }
                    if (Get_Song_Info() != null)
                    {
                        isPlaying = false;
                        updateTrackBar = true;
                        ID_Song = Convert.ToInt32(Song_List.SelectedItems[0].SubItems[1].Text);
                        BTN_Play.BackgroundImage = Properties.Resources.KRPlay;
                        player.Stop();

                        try
                        {
                            audioFile = new AudioFileReader(Get_Song_Info().File_Path);
                            audioFile.Volume = KR_Volume_Slider.Volume;
                        }

                        catch (Exception ex)
                        {
                            string caption = "Error";
                            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        UpdateSongDisplayInfo(Get_Song_Info());
                        ResetPlaybackPanel();
                        AbortThread();
                        StartThread();

                        // Update player with new song and start playing
                        currentSong.Title = Get_Song_Info().Song_Name;
                        isPlaying = true;
                        BTN_Play.BackgroundImage = Properties.Resources.KRPause;
                        player.Init(audioFile);
                        player.Play();
                        Con.Add_Times_Listened(Get_Song_Info().ID_Song);
                    }
                }
            }
        }

        private void BTN_Looping_Click(object sender, EventArgs e)
        {
            if (estoyLooping)
            {
                estoyLooping = false;
                BTN_Looping.BackgroundImage = Properties.Resources.KRloopOff;
            }
            else 
            {
                estoyLooping = true;
                BTN_Looping.BackgroundImage = Properties.Resources.KRloop;
            }
        }

        private void Song_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Shuffle_Click(object sender, EventArgs e)
        {
            if (!isShuffling)
            {
                isShuffling = true;
                BTN_Shuffle.BackgroundImage = Properties.Resources.KRShuffle;
            }
            else 
            {
                isShuffling = false;
                BTN_Shuffle.BackgroundImage = Properties.Resources.KRShuffleOff;
            }
        }

        private void ZA_WARDO_Tick(object sender, EventArgs e)
        {

            try
            {
                if (updateTrackBar == true && audioFile != null)
                {
                    TimeSpan songPosition = audioFile.CurrentTime;

                    string seconds = songPosition.Seconds.ToString();
                    if (songPosition.Seconds < 10)
                        seconds = "0" + seconds;

                    elapsedTime.Text = songPosition.Minutes.ToString() + ":" + seconds;


                    if (musicTrackBar.Value == musicTrackBar.Maximum || elapsedTime.Text == totalTime.Text)
                    {
                        audioFile.CurrentTime = TimeSpan.FromSeconds(0);
                        elapsedTime.Text = "0:00";
                        musicTrackBar.Value = 0;
                        if (!estoyLooping)
                        {
                            if (!isShuffling)
                            {
                                NEXT();
                            }
                            else if (isShuffling)
                            {
                                ShuffleNEXT();
                            }
                        }
                        else if (estoyLooping)
                        {
                            LOOP();
                        }
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Album_List_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ID_Album = Convert.ToInt32(Album_List.SelectedItems[0].SubItems[1].Text);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BTN_Edit_Song_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID_Song.ToString()))
            {
                Edit_Song EDIT_Song = new Edit_Song();
                EDIT_Song.Get_ID(ID_Song);
                EDIT_Song.FormClosed += new FormClosedEventHandler(EDIT_SongFormClosed);
                EDIT_Song.ShowDialog();
            }
            else { return; }
        }

        private void EDIT_SongFormClosed(object sender, FormClosedEventArgs e) 
        {
            Con.List_Album_Songs(ID_Album, Song_List);
        }

        private void BTN_Create_Playlist_Click(object sender, EventArgs e)
        {
            Add_New_Playlist ADD_Playlist = new Add_New_Playlist();
            ADD_Playlist.FormClosed += new FormClosedEventHandler(ADD_PlaylistFormClosed);
            ADD_Playlist.ShowDialog();
        }
        private void ADD_PlaylistFormClosed(object sender, FormClosedEventArgs e)
        {
            User_Playlists.DataSource = Con.Select_Playlists();
            User_Playlists.ValueMember = "ID_Playlist";
            User_Playlists.DisplayMember = "Playlist_Name";
        }

        private void BTN_Modify_Album_Click(object sender, EventArgs e)
        {
            Edit_Album EDIT_Album = new Edit_Album();
            EDIT_Album.Get_ID(ID_Album);
            EDIT_Album.FormClosed += new FormClosedEventHandler(EDIT_AlbumFormClosed);
            EDIT_Album.ShowDialog();
        }
        private void EDIT_AlbumFormClosed(object sender, FormClosedEventArgs e)
        {
            Con.List_Of_Albums(Album_List);
        }

        private void User_Playlists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_Playlists_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Song_List.ListViewItemSorter = lvwColumnSorter;
            showAlPlaylistSongs();
            LBL_Albums.Visible = false;
            LBL_Songs.Visible = false;
            BTN_Add_Song.Visible = false;
            BTN_Edit_Song.Visible = false;
            BTN_Mod_Playlist.Visible = true;
            BTN_DELETE_Playlist.Visible = true;
            isPlayingPlaylist = true;
            ID_Playlist = Convert.ToInt32(User_Playlists.SelectedValue);
            Con.Select_Songs_In_Playlist(Convert.ToInt32(User_Playlists.SelectedValue), Song_List);
        }

        private void TSQuick_DELETE_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're about to DELETE this Song(s)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (ListViewItem songid in Song_List.SelectedItems)
                {
                    Con.DELETE_Selected_Song(Convert.ToInt32(songid.SubItems[1].Text));
                }
                if (Song_List.SelectedItems.Count == 1)
                {
                    MessageBox.Show(Song_List.SelectedItems[0].SubItems[0].Text + " Succesfully deleted", "Song Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.List_Album_Songs(ID_Album, Song_List);
                }
                else 
                {
                    MessageBox.Show("Multiple Songs Succesfully deleted", "Songs Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.List_Album_Songs(ID_Album, Song_List);
                }
            }
            else
            {
                return;
            }
        }

        private void addToPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToPlaylistToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }


        private void addToPlaylistToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            addToPlaylistToolStripMenuItem.DropDownItems.Clear();
            playList = new List<Playlist>();
            playList = Con.Select_Playlists();

            foreach (var Playlist in playList)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(Playlist.Playlist_Name);
                item.Tag = Playlist.ID_Playlist;
                addToPlaylistToolStripMenuItem.DropDownItems.Add(item);
                item.Click += new EventHandler(PlaylistClicked);
            }
            ToolStripMenuItem Plist = new ToolStripMenuItem();
        }

        private void PlaylistClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            foreach (ListViewItem songid in Song_List.SelectedItems)
            {
                Con.Insert_Song_In_Playlist(Convert.ToInt32(songid.SubItems[1].Text), Convert.ToInt32(item.Tag));
            }
            MessageBox.Show( "Songs added to " + item.Text, "Songs Succesfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void User_Playlists_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void removeFromThisPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem songid in Song_List.SelectedItems)
                {
                    Con.DELETE_Song_From_Playlist(Convert.ToInt32(songid.SubItems[1].Text), ID_Playlist);
                }
                Con.Select_Songs_In_Playlist(ID_Playlist,Song_List);
            }
            catch (Exception)
            {
                return;
            }

        }

        private void BTN_DELETE_Playlist_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're about to PERMANENTLY DELETE this Playlist" + "\n" + "\n" + "Are you sure?", "DELETE this Playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Con.DELETE_Playlist(ID_Playlist);
                User_Playlists.DataSource = Con.Select_Playlists();
                User_Playlists.ValueMember = "ID_Playlist";
                User_Playlists.DisplayMember = "Playlist_Name";
                Homefunc();
            }
            else
            {
                return;
            }
        }

        private void Other_Album_Art_Click(object sender, EventArgs e)
        {

        }

        private void Main_Control_Bar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!isMaximized)
            {
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
            else if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
        }
        
        private void BGWorker_Add_Songs_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] ofd = (string[])e.Argument;
            foreach (String files in ofd) 
            {
                audioFile = new AudioFileReader(files);
                TimeSpan songLength = audioFile.TotalTime;

                string seconds = songLength.Seconds.ToString();
                if (songLength.Seconds < 10)
                    seconds = "0" + seconds;

                string songSeconds = songLength.Minutes.ToString() + ":" + seconds.ToString();

                if (!File.Exists(ML_Filepath + @"\" + Album_Name + @"\" + Path.GetFileName(files)))
                {
                    File.Copy(files, ML_Filepath + @"\" + Album_Name + @"\" + Path.GetFileName(files), true);
                }
                addedSongPath = ML_Filepath + @"\" + Album_Name + @"\" + Path.GetFileName(files);

                Con.Insert_New_Song(ID_Album.ToString(), Path.GetFileName(files).Substring(0, Path.GetFileName(files).Length - 4), Path.GetFileName(files), addedSongPath, songSeconds);
                numOfFiles++;
                double percentage = (double)(numOfFiles / Convert.ToInt32(ofd.Length));
                percentage = percentage * 100;
                BGWorker_Add_Songs.ReportProgress((int)percentage);
            }
        }

        private void BGWorker_Add_Songs_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LBL_Load.Text = $"Adding Songs To Album {e.ProgressPercentage}%";
            PB_AddingSongs.Value = e.ProgressPercentage;
            PB_AddingSongs.Update();
        }

        private void BGWorker_Add_Songs_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Adding_Songs_Panel.Visible = false;
            PB_AddingSongs.Update();
            DialogResult DONE = MessageBox.Show("Songs succesfully added to " + Album_Name, "Successfully Added Songs to the album", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (DONE == DialogResult.OK)
            {
                Con.List_Album_Songs(ID_Album, Song_List);
            }
        }

        private void BGWorker_Super_Shufle_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void BTN_Tools_Click(object sender, EventArgs e)
        {
            CTXMS_Available_Tools.Show(Cursor.Position);
        }

        private void fileRenamingToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File_Name_Editing_Tool File_Renamer = new File_Name_Editing_Tool();
            File_Renamer.ShowDialog();
        }

        private void BTN_Mod_Playlist_Click(object sender, EventArgs e)
        {
            Edit_Playlist Edit_Playlist = new Edit_Playlist();
            Edit_Playlist.Get_ID(ID_Playlist);
            Edit_Playlist.FormClosed += new FormClosedEventHandler(Edit_PlaylistFormClosed);
            Edit_Playlist.ShowDialog();
        }

        private void Edit_PlaylistFormClosed(object sender, FormClosedEventArgs e)
        {
            User_Playlists.DataSource = Con.Select_Playlists();
            User_Playlists.ValueMember = "ID_Playlist";
            User_Playlists.DisplayMember = "Playlist_Name";
            Song_List.MultiSelect = false;
            Homefunc();
        }

        private void Get_Album_From_Song_Click(object sender, EventArgs e)
        {

        }

        private void KR_Volume_Slider_VolumeChanged(object sender, EventArgs e)
        {
            //LBL_Volume.Text = ((KR_Volume_Slider.Volume / 1) * 100).ToString() + "%";
            LBL_Volume.Text = ((KR_Volume_Slider.Volume / 1) * 100).ToString() + "%";
            if (audioFile != null)
            {
                audioFile.Volume = KR_Volume_Slider.Volume;
            }
        }

        private void Song_List_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.Song_List.Sort();
        }

        private void Play(Songs_In_Album Song) 
        {
            if (Song != null)
            {
                isPlaying = false;
                BTN_Play.BackgroundImage = Properties.Resources.KRPause;
                player.Stop();

                try
                {
                    audioFile = new AudioFileReader(Song.File_Path);
                    audioFile.Volume = KR_Volume_Slider.Volume;
                    Con.Add_Times_Listened(Song.ID_Song);
                }
                catch (Exception)
                {
                    updateTrackBar = false;
                    string message = "MP3 could not be played. Check file path:\n\n" + Song.File_Path;
                    string caption = "Error";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Update the song's display information

                UpdateSongDisplayInfo(Song);

                //Reset playback controls
                ResetPlaybackPanel();
                //ChangeVisibility(true);
                //CenterContent();

                AbortThread();
                StartThread();
                currentSong.Title = Song.Song_Name;
                isPlaying = true;
                updateTrackBar = true;
                BTN_Play.BackgroundImage = Properties.Resources.KRPause;
                player.Init(audioFile);
                player.Play();
            }
        }
    }
}
