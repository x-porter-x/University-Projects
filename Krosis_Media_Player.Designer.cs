
namespace Krosis_Media_Player
{
    partial class Krosis_Media_Player
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Krosis_Media_Player));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.BTN_Close = new System.Windows.Forms.Button();
            this.Main_Control_Bar = new System.Windows.Forms.Panel();
            this.LBL_Songs = new System.Windows.Forms.Label();
            this.BTN_Tools = new System.Windows.Forms.Button();
            this.LBL_Albums = new System.Windows.Forms.Label();
            this.BTN_Minimize = new System.Windows.Forms.Button();
            this.BTN_Maximize = new System.Windows.Forms.Button();
            this.Main_Menu = new System.Windows.Forms.Panel();
            this.BTN_Create_Playlist = new System.Windows.Forms.Button();
            this.BTN_Add_New_Album = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.BTN_Home = new System.Windows.Forms.Button();
            this.User_Playlists = new System.Windows.Forms.ListBox();
            this.KR_Banner = new System.Windows.Forms.PictureBox();
            this.Album_Art = new System.Windows.Forms.PictureBox();
            this.Current_Album_Artist = new System.Windows.Forms.Label();
            this.Current_Song_Name = new System.Windows.Forms.Label();
            this.Media_Dashboard = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LBL_Volume = new System.Windows.Forms.Label();
            this.KR_Volume_Slider = new NAudio.Gui.VolumeSlider();
            this.BTN_Modify_Album = new System.Windows.Forms.Button();
            this.BTN_Looping = new System.Windows.Forms.Button();
            this.Current_Album = new System.Windows.Forms.Label();
            this.BTN_Shuffle = new System.Windows.Forms.Button();
            this.totalTime = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.BTN_Play = new System.Windows.Forms.Button();
            this.BTN_Next = new System.Windows.Forms.Button();
            this.BTN_Previous = new System.Windows.Forms.Button();
            this.musicTrackBar = new System.Windows.Forms.TrackBar();
            this.BTN_Add_Song = new System.Windows.Forms.Button();
            this.Main_Content_Panel = new System.Windows.Forms.Panel();
            this.BTN_Mod_Playlist = new System.Windows.Forms.Button();
            this.BTN_DELETE_Playlist = new System.Windows.Forms.Button();
            this.Song_List = new System.Windows.Forms.ListView();
            this.Playlist_Song_List = new System.Windows.Forms.ListView();
            this.BTN_Edit_Song = new System.Windows.Forms.Button();
            this.Album_List = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selected_Artistlbl = new System.Windows.Forms.Label();
            this.Selected_Albumlbl = new System.Windows.Forms.Label();
            this.Other_Album_Art = new System.Windows.Forms.PictureBox();
            this.Adding_Songs_Panel = new System.Windows.Forms.Panel();
            this.PB_AddingSongs = new System.Windows.Forms.ProgressBar();
            this.LBL_Load = new System.Windows.Forms.Label();
            this.ZA_WARDO = new System.Windows.Forms.Timer(this.components);
            this.CTXMS_Sog_List = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSQuick_DELETE = new System.Windows.Forms.ToolStripMenuItem();
            this.CTXMS_Playlist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromThisPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BGWorker_Add_Songs = new System.ComponentModel.BackgroundWorker();
            this.BGWorker_Super_Shufle = new System.ComponentModel.BackgroundWorker();
            this.CTXMS_Available_Tools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileRenamingToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_Control_Bar.SuspendLayout();
            this.Main_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KR_Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Album_Art)).BeginInit();
            this.Media_Dashboard.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).BeginInit();
            this.Main_Content_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Other_Album_Art)).BeginInit();
            this.Adding_Songs_Panel.SuspendLayout();
            this.CTXMS_Sog_List.SuspendLayout();
            this.CTXMS_Playlist.SuspendLayout();
            this.CTXMS_Available_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Close.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BTN_Close.Location = new System.Drawing.Point(1233, 0);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(48, 30);
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "x";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // Main_Control_Bar
            // 
            this.Main_Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Main_Control_Bar.Controls.Add(this.LBL_Songs);
            this.Main_Control_Bar.Controls.Add(this.BTN_Tools);
            this.Main_Control_Bar.Controls.Add(this.LBL_Albums);
            this.Main_Control_Bar.Controls.Add(this.BTN_Minimize);
            this.Main_Control_Bar.Controls.Add(this.BTN_Maximize);
            this.Main_Control_Bar.Controls.Add(this.BTN_Close);
            this.Main_Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Main_Control_Bar.Location = new System.Drawing.Point(0, 0);
            this.Main_Control_Bar.Name = "Main_Control_Bar";
            this.Main_Control_Bar.Size = new System.Drawing.Size(1281, 30);
            this.Main_Control_Bar.TabIndex = 2;
            this.Main_Control_Bar.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Control_Bar_Paint);
            this.Main_Control_Bar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Main_Control_Bar_MouseDoubleClick);
            this.Main_Control_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Control_Bar_MouseDown);
            this.Main_Control_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_Control_Bar_MouseMove);
            this.Main_Control_Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_Control_Bar_MouseUp);
            // 
            // LBL_Songs
            // 
            this.LBL_Songs.AutoSize = true;
            this.LBL_Songs.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Songs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_Songs.Location = new System.Drawing.Point(54, 18);
            this.LBL_Songs.Name = "LBL_Songs";
            this.LBL_Songs.Size = new System.Drawing.Size(110, 12);
            this.LBL_Songs.TabIndex = 12;
            this.LBL_Songs.Text = "Number of Active Songs:";
            this.LBL_Songs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Songs.Visible = false;
            // 
            // BTN_Tools
            // 
            this.BTN_Tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Tools.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_Tools.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Tools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BTN_Tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Tools.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BTN_Tools.Location = new System.Drawing.Point(0, 0);
            this.BTN_Tools.Name = "BTN_Tools";
            this.BTN_Tools.Size = new System.Drawing.Size(48, 30);
            this.BTN_Tools.TabIndex = 4;
            this.BTN_Tools.TabStop = false;
            this.BTN_Tools.Text = "•••";
            this.BTN_Tools.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Tools.UseVisualStyleBackColor = false;
            this.BTN_Tools.Click += new System.EventHandler(this.BTN_Tools_Click);
            // 
            // LBL_Albums
            // 
            this.LBL_Albums.AutoSize = true;
            this.LBL_Albums.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Albums.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_Albums.Location = new System.Drawing.Point(54, 0);
            this.LBL_Albums.Name = "LBL_Albums";
            this.LBL_Albums.Size = new System.Drawing.Size(116, 12);
            this.LBL_Albums.TabIndex = 11;
            this.LBL_Albums.Text = "Number of Active Albums:";
            this.LBL_Albums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Albums.Visible = false;
            // 
            // BTN_Minimize
            // 
            this.BTN_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BTN_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Minimize.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BTN_Minimize.Location = new System.Drawing.Point(1137, 0);
            this.BTN_Minimize.Name = "BTN_Minimize";
            this.BTN_Minimize.Size = new System.Drawing.Size(48, 30);
            this.BTN_Minimize.TabIndex = 3;
            this.BTN_Minimize.Text = "-";
            this.BTN_Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Minimize.UseVisualStyleBackColor = false;
            this.BTN_Minimize.Click += new System.EventHandler(this.BTN_Minimize_Click);
            // 
            // BTN_Maximize
            // 
            this.BTN_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Maximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BTN_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Maximize.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BTN_Maximize.Location = new System.Drawing.Point(1185, 0);
            this.BTN_Maximize.Name = "BTN_Maximize";
            this.BTN_Maximize.Size = new System.Drawing.Size(48, 30);
            this.BTN_Maximize.TabIndex = 2;
            this.BTN_Maximize.Text = "□";
            this.BTN_Maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Maximize.UseVisualStyleBackColor = false;
            this.BTN_Maximize.Click += new System.EventHandler(this.BTN_Maximize_Click);
            // 
            // Main_Menu
            // 
            this.Main_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Main_Menu.Controls.Add(this.BTN_Create_Playlist);
            this.Main_Menu.Controls.Add(this.BTN_Add_New_Album);
            this.Main_Menu.Controls.Add(this.BTN_Search);
            this.Main_Menu.Controls.Add(this.BTN_Home);
            this.Main_Menu.Controls.Add(this.User_Playlists);
            this.Main_Menu.Controls.Add(this.KR_Banner);
            this.Main_Menu.Controls.Add(this.Album_Art);
            this.Main_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Main_Menu.Location = new System.Drawing.Point(0, 30);
            this.Main_Menu.Name = "Main_Menu";
            this.Main_Menu.Size = new System.Drawing.Size(217, 656);
            this.Main_Menu.TabIndex = 7;
            // 
            // BTN_Create_Playlist
            // 
            this.BTN_Create_Playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Create_Playlist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Create_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Create_Playlist.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Create_Playlist.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Create_Playlist.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Create_Playlist.Image")));
            this.BTN_Create_Playlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Create_Playlist.Location = new System.Drawing.Point(0, 235);
            this.BTN_Create_Playlist.Name = "BTN_Create_Playlist";
            this.BTN_Create_Playlist.Size = new System.Drawing.Size(217, 47);
            this.BTN_Create_Playlist.TabIndex = 22;
            this.BTN_Create_Playlist.Text = "           Create Playlist";
            this.BTN_Create_Playlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Create_Playlist.UseVisualStyleBackColor = true;
            this.BTN_Create_Playlist.Click += new System.EventHandler(this.BTN_Create_Playlist_Click);
            // 
            // BTN_Add_New_Album
            // 
            this.BTN_Add_New_Album.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Add_New_Album.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Add_New_Album.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Add_New_Album.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Add_New_Album.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Add_New_Album.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Add_New_Album.Image")));
            this.BTN_Add_New_Album.Location = new System.Drawing.Point(0, 188);
            this.BTN_Add_New_Album.Name = "BTN_Add_New_Album";
            this.BTN_Add_New_Album.Size = new System.Drawing.Size(217, 47);
            this.BTN_Add_New_Album.TabIndex = 19;
            this.BTN_Add_New_Album.Text = "           Add New Album";
            this.BTN_Add_New_Album.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Add_New_Album.UseVisualStyleBackColor = true;
            this.BTN_Add_New_Album.Click += new System.EventHandler(this.BTN_Add_New_Album_Click);
            // 
            // BTN_Search
            // 
            this.BTN_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Search.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Search.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Search.Image = global::Krosis_Media_Player.Properties.Resources.Search;
            this.BTN_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Search.Location = new System.Drawing.Point(0, 141);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(217, 47);
            this.BTN_Search.TabIndex = 20;
            this.BTN_Search.Text = "       Super Shuffle";
            this.BTN_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // BTN_Home
            // 
            this.BTN_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.BTN_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Home.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Home.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Home.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Home.Image")));
            this.BTN_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Home.Location = new System.Drawing.Point(0, 94);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.Size = new System.Drawing.Size(217, 47);
            this.BTN_Home.TabIndex = 19;
            this.BTN_Home.Text = "       Home";
            this.BTN_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Home.UseVisualStyleBackColor = true;
            this.BTN_Home.Click += new System.EventHandler(this.BTN_Home_Click);
            // 
            // User_Playlists
            // 
            this.User_Playlists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.User_Playlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.User_Playlists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_Playlists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.User_Playlists.ForeColor = System.Drawing.SystemColors.Window;
            this.User_Playlists.FormattingEnabled = true;
            this.User_Playlists.ItemHeight = 21;
            this.User_Playlists.Location = new System.Drawing.Point(0, 282);
            this.User_Playlists.Name = "User_Playlists";
            this.User_Playlists.Size = new System.Drawing.Size(217, 168);
            this.User_Playlists.TabIndex = 21;
            this.User_Playlists.MouseClick += new System.Windows.Forms.MouseEventHandler(this.User_Playlists_MouseClick);
            this.User_Playlists.SelectedIndexChanged += new System.EventHandler(this.User_Playlists_SelectedIndexChanged);
            this.User_Playlists.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.User_Playlists_MouseDoubleClick);
            // 
            // KR_Banner
            // 
            this.KR_Banner.BackgroundImage = global::Krosis_Media_Player.Properties.Resources.KRGradient;
            this.KR_Banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.KR_Banner.Image = ((System.Drawing.Image)(resources.GetObject("KR_Banner.Image")));
            this.KR_Banner.Location = new System.Drawing.Point(0, 0);
            this.KR_Banner.Name = "KR_Banner";
            this.KR_Banner.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.KR_Banner.Size = new System.Drawing.Size(217, 94);
            this.KR_Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KR_Banner.TabIndex = 0;
            this.KR_Banner.TabStop = false;
            // 
            // Album_Art
            // 
            this.Album_Art.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Album_Art.InitialImage = null;
            this.Album_Art.Location = new System.Drawing.Point(0, 470);
            this.Album_Art.Name = "Album_Art";
            this.Album_Art.Size = new System.Drawing.Size(217, 186);
            this.Album_Art.TabIndex = 1;
            this.Album_Art.TabStop = false;
            this.Album_Art.Click += new System.EventHandler(this.Album_Art_Click);
            // 
            // Current_Album_Artist
            // 
            this.Current_Album_Artist.AutoSize = true;
            this.Current_Album_Artist.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Current_Album_Artist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Current_Album_Artist.Location = new System.Drawing.Point(12, 68);
            this.Current_Album_Artist.Name = "Current_Album_Artist";
            this.Current_Album_Artist.Size = new System.Drawing.Size(38, 13);
            this.Current_Album_Artist.TabIndex = 3;
            this.Current_Album_Artist.Text = "Name";
            this.Current_Album_Artist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Current_Album_Artist.Visible = false;
            // 
            // Current_Song_Name
            // 
            this.Current_Song_Name.AutoSize = true;
            this.Current_Song_Name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Current_Song_Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Current_Song_Name.Location = new System.Drawing.Point(12, 13);
            this.Current_Song_Name.Name = "Current_Song_Name";
            this.Current_Song_Name.Size = new System.Drawing.Size(51, 20);
            this.Current_Song_Name.TabIndex = 2;
            this.Current_Song_Name.Text = "Name";
            this.Current_Song_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Current_Song_Name.Visible = false;
            // 
            // Media_Dashboard
            // 
            this.Media_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Media_Dashboard.Controls.Add(this.panel7);
            this.Media_Dashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Media_Dashboard.Location = new System.Drawing.Point(0, 686);
            this.Media_Dashboard.Name = "Media_Dashboard";
            this.Media_Dashboard.Size = new System.Drawing.Size(1281, 105);
            this.Media_Dashboard.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LBL_Volume);
            this.panel7.Controls.Add(this.KR_Volume_Slider);
            this.panel7.Controls.Add(this.BTN_Modify_Album);
            this.panel7.Controls.Add(this.BTN_Looping);
            this.panel7.Controls.Add(this.Current_Album);
            this.panel7.Controls.Add(this.BTN_Shuffle);
            this.panel7.Controls.Add(this.Current_Album_Artist);
            this.panel7.Controls.Add(this.totalTime);
            this.panel7.Controls.Add(this.Current_Song_Name);
            this.panel7.Controls.Add(this.elapsedTime);
            this.panel7.Controls.Add(this.BTN_Play);
            this.panel7.Controls.Add(this.BTN_Next);
            this.panel7.Controls.Add(this.BTN_Previous);
            this.panel7.Controls.Add(this.musicTrackBar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1281, 105);
            this.panel7.TabIndex = 8;
            // 
            // LBL_Volume
            // 
            this.LBL_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Volume.AutoSize = true;
            this.LBL_Volume.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Volume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_Volume.Location = new System.Drawing.Point(1231, 80);
            this.LBL_Volume.Name = "LBL_Volume";
            this.LBL_Volume.Size = new System.Drawing.Size(35, 13);
            this.LBL_Volume.TabIndex = 24;
            this.LBL_Volume.Text = "100%";
            this.LBL_Volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KR_Volume_Slider
            // 
            this.KR_Volume_Slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KR_Volume_Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.KR_Volume_Slider.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KR_Volume_Slider.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.KR_Volume_Slider.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KR_Volume_Slider.Location = new System.Drawing.Point(1043, 79);
            this.KR_Volume_Slider.Name = "KR_Volume_Slider";
            this.KR_Volume_Slider.Size = new System.Drawing.Size(181, 15);
            this.KR_Volume_Slider.TabIndex = 23;
            this.KR_Volume_Slider.VolumeChanged += new System.EventHandler(this.KR_Volume_Slider_VolumeChanged);
            // 
            // BTN_Modify_Album
            // 
            this.BTN_Modify_Album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Modify_Album.BackgroundImage = global::Krosis_Media_Player.Properties.Resources.KREdit;
            this.BTN_Modify_Album.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Modify_Album.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BTN_Modify_Album.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Modify_Album.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Modify_Album.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Modify_Album.Location = new System.Drawing.Point(1214, 13);
            this.BTN_Modify_Album.Name = "BTN_Modify_Album";
            this.BTN_Modify_Album.Size = new System.Drawing.Size(46, 46);
            this.BTN_Modify_Album.TabIndex = 22;
            this.BTN_Modify_Album.UseVisualStyleBackColor = true;
            this.BTN_Modify_Album.Click += new System.EventHandler(this.BTN_Modify_Album_Click);
            // 
            // BTN_Looping
            // 
            this.BTN_Looping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BTN_Looping.BackgroundImage = global::Krosis_Media_Player.Properties.Resources.KRloopOff;
            this.BTN_Looping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Looping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Looping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Looping.Location = new System.Drawing.Point(761, 32);
            this.BTN_Looping.Name = "BTN_Looping";
            this.BTN_Looping.Size = new System.Drawing.Size(22, 22);
            this.BTN_Looping.TabIndex = 7;
            this.BTN_Looping.TabStop = false;
            this.BTN_Looping.UseVisualStyleBackColor = true;
            this.BTN_Looping.Click += new System.EventHandler(this.BTN_Looping_Click);
            // 
            // Current_Album
            // 
            this.Current_Album.AutoSize = true;
            this.Current_Album.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Current_Album.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Current_Album.Location = new System.Drawing.Point(12, 44);
            this.Current_Album.Name = "Current_Album";
            this.Current_Album.Size = new System.Drawing.Size(38, 13);
            this.Current_Album.TabIndex = 4;
            this.Current_Album.Text = "Name";
            this.Current_Album.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Current_Album.Visible = false;
            // 
            // BTN_Shuffle
            // 
            this.BTN_Shuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BTN_Shuffle.BackgroundImage = global::Krosis_Media_Player.Properties.Resources.KRShuffleOff;
            this.BTN_Shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Shuffle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Shuffle.Location = new System.Drawing.Point(591, 32);
            this.BTN_Shuffle.Name = "BTN_Shuffle";
            this.BTN_Shuffle.Size = new System.Drawing.Size(22, 22);
            this.BTN_Shuffle.TabIndex = 6;
            this.BTN_Shuffle.TabStop = false;
            this.BTN_Shuffle.UseVisualStyleBackColor = true;
            this.BTN_Shuffle.Click += new System.EventHandler(this.BTN_Shuffle_Click);
            // 
            // totalTime
            // 
            this.totalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTime.AutoSize = true;
            this.totalTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalTime.Location = new System.Drawing.Point(975, 79);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(28, 15);
            this.totalTime.TabIndex = 5;
            this.totalTime.Text = "0:00";
            // 
            // elapsedTime
            // 
            this.elapsedTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elapsedTime.Location = new System.Drawing.Point(364, 79);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(28, 15);
            this.elapsedTime.TabIndex = 4;
            this.elapsedTime.Text = "0:00";
            // 
            // BTN_Play
            // 
            this.BTN_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BTN_Play.BackgroundImage = global::Krosis_Media_Player.Properties.Resources.KRPlay;
            this.BTN_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Play.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Play.Location = new System.Drawing.Point(666, 22);
            this.BTN_Play.Name = "BTN_Play";
            this.BTN_Play.Size = new System.Drawing.Size(42, 42);
            this.BTN_Play.TabIndex = 1;
            this.BTN_Play.TabStop = false;
            this.BTN_Play.UseVisualStyleBackColor = true;
            this.BTN_Play.Click += new System.EventHandler(this.BTN_Play_Click);
            // 
            // BTN_Next
            // 
            this.BTN_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BTN_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Next.BackgroundImage")));
            this.BTN_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Next.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Next.Location = new System.Drawing.Point(723, 27);
            this.BTN_Next.Name = "BTN_Next";
            this.BTN_Next.Size = new System.Drawing.Size(32, 32);
            this.BTN_Next.TabIndex = 3;
            this.BTN_Next.TabStop = false;
            this.BTN_Next.UseVisualStyleBackColor = true;
            this.BTN_Next.Click += new System.EventHandler(this.BTN_Next_Click);
            // 
            // BTN_Previous
            // 
            this.BTN_Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BTN_Previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Previous.BackgroundImage")));
            this.BTN_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Previous.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Previous.Location = new System.Drawing.Point(619, 27);
            this.BTN_Previous.Name = "BTN_Previous";
            this.BTN_Previous.Size = new System.Drawing.Size(32, 32);
            this.BTN_Previous.TabIndex = 2;
            this.BTN_Previous.TabStop = false;
            this.BTN_Previous.UseVisualStyleBackColor = true;
            this.BTN_Previous.Click += new System.EventHandler(this.BTN_Previous_Click);
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.musicTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicTrackBar.Location = new System.Drawing.Point(393, 75);
            this.musicTrackBar.Maximum = 100000;
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(581, 45);
            this.musicTrackBar.TabIndex = 0;
            this.musicTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.musicTrackBar.Scroll += new System.EventHandler(this.musicTrackBar_Scroll);
            this.musicTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.musicTrackBar_MouseDown);
            // 
            // BTN_Add_Song
            // 
            this.BTN_Add_Song.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Add_Song.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Add_Song.BackgroundImage")));
            this.BTN_Add_Song.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Add_Song.Enabled = false;
            this.BTN_Add_Song.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BTN_Add_Song.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Add_Song.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Add_Song.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Add_Song.Location = new System.Drawing.Point(997, 604);
            this.BTN_Add_Song.Name = "BTN_Add_Song";
            this.BTN_Add_Song.Size = new System.Drawing.Size(46, 46);
            this.BTN_Add_Song.TabIndex = 20;
            this.BTN_Add_Song.UseVisualStyleBackColor = true;
            this.BTN_Add_Song.Visible = false;
            this.BTN_Add_Song.Click += new System.EventHandler(this.BTN_Add_Song_Click);
            // 
            // Main_Content_Panel
            // 
            this.Main_Content_Panel.Controls.Add(this.BTN_Mod_Playlist);
            this.Main_Content_Panel.Controls.Add(this.BTN_DELETE_Playlist);
            this.Main_Content_Panel.Controls.Add(this.Song_List);
            this.Main_Content_Panel.Controls.Add(this.Playlist_Song_List);
            this.Main_Content_Panel.Controls.Add(this.BTN_Edit_Song);
            this.Main_Content_Panel.Controls.Add(this.BTN_Add_Song);
            this.Main_Content_Panel.Controls.Add(this.Album_List);
            this.Main_Content_Panel.Controls.Add(this.panel2);
            this.Main_Content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Content_Panel.Location = new System.Drawing.Point(217, 30);
            this.Main_Content_Panel.Name = "Main_Content_Panel";
            this.Main_Content_Panel.Size = new System.Drawing.Size(1064, 656);
            this.Main_Content_Panel.TabIndex = 8;
            this.Main_Content_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Content_Panel_Paint);
            // 
            // BTN_Mod_Playlist
            // 
            this.BTN_Mod_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Mod_Playlist.BackgroundImage = global::Krosis_Media_Player.Properties.Resources.KREdit;
            this.BTN_Mod_Playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Mod_Playlist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BTN_Mod_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Mod_Playlist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Mod_Playlist.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Mod_Playlist.Location = new System.Drawing.Point(1003, 558);
            this.BTN_Mod_Playlist.Name = "BTN_Mod_Playlist";
            this.BTN_Mod_Playlist.Size = new System.Drawing.Size(40, 40);
            this.BTN_Mod_Playlist.TabIndex = 23;
            this.BTN_Mod_Playlist.UseVisualStyleBackColor = true;
            this.BTN_Mod_Playlist.Click += new System.EventHandler(this.BTN_Mod_Playlist_Click);
            // 
            // BTN_DELETE_Playlist
            // 
            this.BTN_DELETE_Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_DELETE_Playlist.BackgroundImage = global::Krosis_Media_Player.Properties.Resources.KRDELETE;
            this.BTN_DELETE_Playlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_DELETE_Playlist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BTN_DELETE_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE_Playlist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_DELETE_Playlist.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_DELETE_Playlist.Location = new System.Drawing.Point(1003, 604);
            this.BTN_DELETE_Playlist.Name = "BTN_DELETE_Playlist";
            this.BTN_DELETE_Playlist.Size = new System.Drawing.Size(40, 40);
            this.BTN_DELETE_Playlist.TabIndex = 23;
            this.BTN_DELETE_Playlist.UseVisualStyleBackColor = true;
            this.BTN_DELETE_Playlist.Click += new System.EventHandler(this.BTN_DELETE_Playlist_Click);
            // 
            // Song_List
            // 
            this.Song_List.AllowDrop = true;
            this.Song_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Song_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Song_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Song_List.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Song_List.ForeColor = System.Drawing.SystemColors.Window;
            this.Song_List.FullRowSelect = true;
            this.Song_List.HideSelection = false;
            this.Song_List.Location = new System.Drawing.Point(0, 186);
            this.Song_List.Margin = new System.Windows.Forms.Padding(0);
            this.Song_List.MultiSelect = false;
            this.Song_List.Name = "Song_List";
            this.Song_List.Size = new System.Drawing.Size(1064, 470);
            this.Song_List.TabIndex = 5;
            this.Song_List.UseCompatibleStateImageBehavior = false;
            this.Song_List.View = System.Windows.Forms.View.Details;
            this.Song_List.Visible = false;
            this.Song_List.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Song_List_ColumnClick);
            this.Song_List.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.Song_List_DrawColumnHeader_1);
            this.Song_List.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Song_List_ItemSelectionChanged);
            this.Song_List.SelectedIndexChanged += new System.EventHandler(this.Song_List_SelectedIndexChanged);
            this.Song_List.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Song_List_MouseClick);
            this.Song_List.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Song_List_MouseDoubleClick_1);
            // 
            // Playlist_Song_List
            // 
            this.Playlist_Song_List.AllowDrop = true;
            this.Playlist_Song_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Playlist_Song_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playlist_Song_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Playlist_Song_List.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Playlist_Song_List.ForeColor = System.Drawing.SystemColors.Window;
            this.Playlist_Song_List.FullRowSelect = true;
            this.Playlist_Song_List.HideSelection = false;
            this.Playlist_Song_List.Location = new System.Drawing.Point(0, 186);
            this.Playlist_Song_List.Margin = new System.Windows.Forms.Padding(0);
            this.Playlist_Song_List.MultiSelect = false;
            this.Playlist_Song_List.Name = "Playlist_Song_List";
            this.Playlist_Song_List.Size = new System.Drawing.Size(1064, 470);
            this.Playlist_Song_List.TabIndex = 23;
            this.Playlist_Song_List.UseCompatibleStateImageBehavior = false;
            this.Playlist_Song_List.View = System.Windows.Forms.View.Details;
            this.Playlist_Song_List.Visible = false;
            // 
            // BTN_Edit_Song
            // 
            this.BTN_Edit_Song.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Edit_Song.BackgroundImage = global::Krosis_Media_Player.Properties.Resources.KREdit;
            this.BTN_Edit_Song.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Edit_Song.Enabled = false;
            this.BTN_Edit_Song.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BTN_Edit_Song.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Edit_Song.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Edit_Song.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_Edit_Song.Location = new System.Drawing.Point(997, 552);
            this.BTN_Edit_Song.Name = "BTN_Edit_Song";
            this.BTN_Edit_Song.Size = new System.Drawing.Size(46, 46);
            this.BTN_Edit_Song.TabIndex = 21;
            this.BTN_Edit_Song.UseVisualStyleBackColor = true;
            this.BTN_Edit_Song.Visible = false;
            this.BTN_Edit_Song.Click += new System.EventHandler(this.BTN_Edit_Song_Click);
            // 
            // Album_List
            // 
            this.Album_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Album_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Album_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Album_List.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Album_List.ForeColor = System.Drawing.SystemColors.Window;
            this.Album_List.FullRowSelect = true;
            this.Album_List.GridLines = true;
            this.Album_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Album_List.HideSelection = false;
            this.Album_List.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Album_List.Location = new System.Drawing.Point(0, 186);
            this.Album_List.MultiSelect = false;
            this.Album_List.Name = "Album_List";
            this.Album_List.RightToLeftLayout = true;
            this.Album_List.Size = new System.Drawing.Size(1064, 470);
            this.Album_List.TabIndex = 4;
            this.Album_List.TileSize = new System.Drawing.Size(150, 150);
            this.Album_List.UseCompatibleStateImageBehavior = false;
            this.Album_List.SelectedIndexChanged += new System.EventHandler(this.Album_List_SelectedIndexChanged);
            this.Album_List.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Album_List_MouseClick);
            this.Album_List.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Album_List_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Krosis_Media_Player.Properties.Resources.KRGradient;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 186);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.selected_Artistlbl);
            this.panel3.Controls.Add(this.Selected_Albumlbl);
            this.panel3.Controls.Add(this.Other_Album_Art);
            this.panel3.Controls.Add(this.Adding_Songs_Panel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 186);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // selected_Artistlbl
            // 
            this.selected_Artistlbl.AutoSize = true;
            this.selected_Artistlbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selected_Artistlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selected_Artistlbl.Location = new System.Drawing.Point(224, 60);
            this.selected_Artistlbl.Name = "selected_Artistlbl";
            this.selected_Artistlbl.Size = new System.Drawing.Size(0, 25);
            this.selected_Artistlbl.TabIndex = 9;
            this.selected_Artistlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selected_Artistlbl.Visible = false;
            // 
            // Selected_Albumlbl
            // 
            this.Selected_Albumlbl.AutoSize = true;
            this.Selected_Albumlbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Selected_Albumlbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Selected_Albumlbl.Location = new System.Drawing.Point(224, 9);
            this.Selected_Albumlbl.Name = "Selected_Albumlbl";
            this.Selected_Albumlbl.Size = new System.Drawing.Size(0, 32);
            this.Selected_Albumlbl.TabIndex = 8;
            this.Selected_Albumlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Selected_Albumlbl.Visible = false;
            // 
            // Other_Album_Art
            // 
            this.Other_Album_Art.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Other_Album_Art.BackColor = System.Drawing.Color.Transparent;
            this.Other_Album_Art.Location = new System.Drawing.Point(0, 0);
            this.Other_Album_Art.Name = "Other_Album_Art";
            this.Other_Album_Art.Size = new System.Drawing.Size(217, 186);
            this.Other_Album_Art.TabIndex = 7;
            this.Other_Album_Art.TabStop = false;
            this.Other_Album_Art.Click += new System.EventHandler(this.Other_Album_Art_Click);
            // 
            // Adding_Songs_Panel
            // 
            this.Adding_Songs_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Adding_Songs_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Adding_Songs_Panel.Controls.Add(this.PB_AddingSongs);
            this.Adding_Songs_Panel.Controls.Add(this.LBL_Load);
            this.Adding_Songs_Panel.Location = new System.Drawing.Point(725, 0);
            this.Adding_Songs_Panel.Name = "Adding_Songs_Panel";
            this.Adding_Songs_Panel.Size = new System.Drawing.Size(339, 93);
            this.Adding_Songs_Panel.TabIndex = 10;
            this.Adding_Songs_Panel.Visible = false;
            // 
            // PB_AddingSongs
            // 
            this.PB_AddingSongs.Location = new System.Drawing.Point(3, 53);
            this.PB_AddingSongs.Name = "PB_AddingSongs";
            this.PB_AddingSongs.Size = new System.Drawing.Size(333, 23);
            this.PB_AddingSongs.TabIndex = 6;
            // 
            // LBL_Load
            // 
            this.LBL_Load.AutoSize = true;
            this.LBL_Load.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_Load.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_Load.Location = new System.Drawing.Point(3, 0);
            this.LBL_Load.Name = "LBL_Load";
            this.LBL_Load.Size = new System.Drawing.Size(170, 17);
            this.LBL_Load.TabIndex = 5;
            this.LBL_Load.Text = "Adding Songs To Album...";
            this.LBL_Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZA_WARDO
            // 
            this.ZA_WARDO.Enabled = true;
            this.ZA_WARDO.Interval = 200;
            this.ZA_WARDO.Tick += new System.EventHandler(this.ZA_WARDO_Tick);
            // 
            // CTXMS_Sog_List
            // 
            this.CTXMS_Sog_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToPlaylistToolStripMenuItem,
            this.TSQuick_DELETE});
            this.CTXMS_Sog_List.Name = "CTXMS_Sog_List";
            this.CTXMS_Sog_List.ShowImageMargin = false;
            this.CTXMS_Sog_List.Size = new System.Drawing.Size(137, 48);
            // 
            // addToPlaylistToolStripMenuItem
            // 
            this.addToPlaylistToolStripMenuItem.Name = "addToPlaylistToolStripMenuItem";
            this.addToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addToPlaylistToolStripMenuItem.Text = "Add to Playlist...";
            this.addToPlaylistToolStripMenuItem.Click += new System.EventHandler(this.addToPlaylistToolStripMenuItem_Click);
            this.addToPlaylistToolStripMenuItem.MouseEnter += new System.EventHandler(this.addToPlaylistToolStripMenuItem_MouseEnter);
            this.addToPlaylistToolStripMenuItem.MouseHover += new System.EventHandler(this.addToPlaylistToolStripMenuItem_MouseHover);
            // 
            // TSQuick_DELETE
            // 
            this.TSQuick_DELETE.Name = "TSQuick_DELETE";
            this.TSQuick_DELETE.Size = new System.Drawing.Size(136, 22);
            this.TSQuick_DELETE.Text = "Delete This Song";
            this.TSQuick_DELETE.Click += new System.EventHandler(this.TSQuick_DELETE_Click);
            // 
            // CTXMS_Playlist
            // 
            this.CTXMS_Playlist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromThisPlaylistToolStripMenuItem});
            this.CTXMS_Playlist.Name = "CTXMS_Playlist";
            this.CTXMS_Playlist.ShowImageMargin = false;
            this.CTXMS_Playlist.Size = new System.Drawing.Size(184, 26);
            // 
            // removeFromThisPlaylistToolStripMenuItem
            // 
            this.removeFromThisPlaylistToolStripMenuItem.Name = "removeFromThisPlaylistToolStripMenuItem";
            this.removeFromThisPlaylistToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.removeFromThisPlaylistToolStripMenuItem.Text = "Remove from this playlist";
            this.removeFromThisPlaylistToolStripMenuItem.Click += new System.EventHandler(this.removeFromThisPlaylistToolStripMenuItem_Click);
            // 
            // BGWorker_Add_Songs
            // 
            this.BGWorker_Add_Songs.WorkerReportsProgress = true;
            this.BGWorker_Add_Songs.WorkerSupportsCancellation = true;
            this.BGWorker_Add_Songs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_Add_Songs_DoWork);
            this.BGWorker_Add_Songs.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_Add_Songs_ProgressChanged);
            this.BGWorker_Add_Songs.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_Add_Songs_RunWorkerCompleted);
            // 
            // BGWorker_Super_Shufle
            // 
            this.BGWorker_Super_Shufle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_Super_Shufle_DoWork);
            // 
            // CTXMS_Available_Tools
            // 
            this.CTXMS_Available_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.CTXMS_Available_Tools.Name = "CTXMS_Available_Tools";
            this.CTXMS_Available_Tools.ShowImageMargin = false;
            this.CTXMS_Available_Tools.Size = new System.Drawing.Size(86, 26);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileRenamingToolToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.toolsToolStripMenuItem.Text = "Tools...";
            // 
            // fileRenamingToolToolStripMenuItem
            // 
            this.fileRenamingToolToolStripMenuItem.Name = "fileRenamingToolToolStripMenuItem";
            this.fileRenamingToolToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.fileRenamingToolToolStripMenuItem.Text = "File Renaming Tool";
            this.fileRenamingToolToolStripMenuItem.Click += new System.EventHandler(this.fileRenamingToolToolStripMenuItem_Click);
            // 
            // Krosis_Media_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1281, 791);
            this.Controls.Add(this.Main_Content_Panel);
            this.Controls.Add(this.Main_Menu);
            this.Controls.Add(this.Main_Control_Bar);
            this.Controls.Add(this.Media_Dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Krosis_Media_Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krosis Media Player";
            this.Load += new System.EventHandler(this.Krosis_Media_Player_Load);
            this.Main_Control_Bar.ResumeLayout(false);
            this.Main_Control_Bar.PerformLayout();
            this.Main_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KR_Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Album_Art)).EndInit();
            this.Media_Dashboard.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).EndInit();
            this.Main_Content_Panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Other_Album_Art)).EndInit();
            this.Adding_Songs_Panel.ResumeLayout(false);
            this.Adding_Songs_Panel.PerformLayout();
            this.CTXMS_Sog_List.ResumeLayout(false);
            this.CTXMS_Playlist.ResumeLayout(false);
            this.CTXMS_Available_Tools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Panel Main_Control_Bar;
        private System.Windows.Forms.Button BTN_Minimize;
        private System.Windows.Forms.Button BTN_Maximize;
        private System.Windows.Forms.Panel Main_Menu;
        private System.Windows.Forms.PictureBox KR_Banner;
        private System.Windows.Forms.Panel Media_Dashboard;
        private System.Windows.Forms.TrackBar musicTrackBar;
        private System.Windows.Forms.Label Current_Song_Name;
        private System.Windows.Forms.PictureBox Album_Art;
        private System.Windows.Forms.Button BTN_Next;
        private System.Windows.Forms.Button BTN_Previous;
        private System.Windows.Forms.Button BTN_Play;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label elapsedTime;
        private System.Windows.Forms.Label Current_Album_Artist;
        private System.Windows.Forms.Panel Main_Content_Panel;
        private System.Windows.Forms.ListView Song_List;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_Home;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.ListBox User_Playlists;
        private System.Windows.Forms.Button BTN_Create_Playlist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTN_Add_Song;
        private System.Windows.Forms.Button BTN_Add_New_Album;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label selected_Artistlbl;
        private System.Windows.Forms.Label Selected_Albumlbl;
        private System.Windows.Forms.PictureBox Other_Album_Art;
        private System.Windows.Forms.Label Current_Album;
        private System.Windows.Forms.Button BTN_Looping;
        private System.Windows.Forms.Button BTN_Shuffle;
        private System.Windows.Forms.ListView Album_List;
        private System.Windows.Forms.Timer ZA_WARDO;
        private System.Windows.Forms.Button BTN_Edit_Song;
        private System.Windows.Forms.Button BTN_Modify_Album;
        private System.Windows.Forms.ListView Playlist_Song_List;
        private System.Windows.Forms.ContextMenuStrip CTXMS_Sog_List;
        private System.Windows.Forms.ToolStripMenuItem addToPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSQuick_DELETE;
        private System.Windows.Forms.ContextMenuStrip CTXMS_Playlist;
        private System.Windows.Forms.ToolStripMenuItem removeFromThisPlaylistToolStripMenuItem;
        private System.Windows.Forms.Button BTN_DELETE_Playlist;
        private System.Windows.Forms.Panel Adding_Songs_Panel;
        private System.Windows.Forms.ProgressBar PB_AddingSongs;
        private System.Windows.Forms.Label LBL_Load;
        private System.ComponentModel.BackgroundWorker BGWorker_Add_Songs;
        private System.ComponentModel.BackgroundWorker BGWorker_Super_Shufle;
        private System.Windows.Forms.Button BTN_Tools;
        private System.Windows.Forms.ContextMenuStrip CTXMS_Available_Tools;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileRenamingToolToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Mod_Playlist;
        private System.Windows.Forms.Label LBL_Songs;
        private System.Windows.Forms.Label LBL_Albums;
        private NAudio.Gui.VolumeSlider KR_Volume_Slider;
        private System.Windows.Forms.Label LBL_Volume;
    }
}

