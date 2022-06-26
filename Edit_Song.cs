using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using NAudio.Wave;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krosis_Media_Player.Classes;
using System.Windows.Forms;

namespace Krosis_Media_Player
{
    public partial class Edit_Song : Form
    {
        DB Con;
        bool mouseDown;
        SongToEdit sSong;
        int mouseX, mouseY;
        int songID;
        string songDuration;
        private AudioFileReader audioFile = null;
        public Edit_Song()
        {
            Con = new DB();
            InitializeComponent();
            this.CenterToScreen();
        }
        public void Get_ID(int ID) 
        {
            songID = ID;
            sSong = new SongToEdit();
            sSong = Con.Select_Song_To_Edit(songID);
            TXT_Song_Name.Text = sSong.Song_Name;
            TXT_File_Name.Text = sSong.File_name;
            TXT_FilePath.Text = sSong.File_Path;
        }

        private void BTN_Save_Changes_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're about to Modify this song", "Modify this song?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Con.Update_Song(songID,TXT_Song_Name.Text,TXT_File_Name.Text,TXT_FilePath.Text, songDuration);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Main_Control_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Main_Control_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're about to DELETE this song: " + sSong.File_name, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Con.DELETE_Selected_Song(songID);
                MessageBox.Show(sSong.File_name + " Succesfully deleted", "Song Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void BTN_Set_File_Path_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Music Files(*.MP3;*.WAV)|*.MP3;*.WAV|All files (*.*)|*.*" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(ofd.FileName);
                        TXT_FilePath.Text = fi.FullName;
                        TXT_File_Name.Text = fi.Name;
                        audioFile = new AudioFileReader(fi.FullName);
                        TimeSpan songLength = audioFile.TotalTime;

                        string seconds = songLength.Seconds.ToString();
                        if (songLength.Seconds < 10)
                            seconds = "0" + seconds;

                        songDuration = songLength.Minutes.ToString() + ":" + seconds.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                songDuration = "";
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Control_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
    }
}
