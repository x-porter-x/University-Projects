using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Krosis_Media_Player.Classes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krosis_Media_Player
{
    public partial class Edit_Playlist : Form
    {
        DB Con;
        ML_Info ML;
        PlaylistToEdit playlist;
        bool mouseDown;
        int mouseX, mouseY;
        int Playlist_ID;
        string Playlist_Name;
        string Image_Path;
        string File_Name;
        string ML_Filepath;

        public Edit_Playlist()
        {
            Con = new DB();
            InitializeComponent();
            this.CenterToScreen();
            ML = new ML_Info();
            ML = Con.spSelect_ML_Info();
            ML_Filepath = ML.ML_Path;
        }

        private void Main_Control_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public void Get_ID(int ID)
        {
            Playlist_ID = ID;
            playlist = new PlaylistToEdit();
            playlist = Con.Select_Playlist_To_Edit(ID);
            LBL_Created_On.Text = "Playlist Created On: " + playlist.Created_On; 
            TXT_Playlist_Name.Text = playlist.Playlist_Name;
            TXT_FilePath.Text = playlist.Playlist_Image_Path;
            Image_Path = TXT_FilePath.Text;
            File_Name = playlist.File_name;
            GPX.Text = "Edit " + playlist.Playlist_Name;
            try
            {
                Playlist_Image.BackgroundImage = Image.FromFile(playlist.Playlist_Image_Path);
            }
            catch (Exception)
            {
                Playlist_Image.BackgroundImage = Properties.Resources.No_Art;
                return;
            }
        }

        private void Main_Control_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }
        public void Reset()
        {

            Image_Path = "";
            File_Name = "";
            TXT_FilePath.Text = "";
            Playlist_Image.BackgroundImage = Properties.Resources.No_Art;
        }

        struct image
        {
            public string FileName { get; set; }
            public string FullName { get; set; }
        }

        image _Imagepath;
        private void BTN_Add_Image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|All files (*.*)|*.*" })
            {
                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(ofd.FileName);
                        _Imagepath.FileName = fi.Name;
                        _Imagepath.FullName = fi.FullName;
                        TXT_FilePath.Text = fi.FullName;
                        Image_Path = fi.FullName;
                        File_Name = fi.Name;
                        Playlist_Image.Size = new Size(217, 186);
                        Playlist_Image.BackgroundImage = Image.FromFile(fi.FullName);
                    }
                    else
                    {
                        Reset();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                    return;
                }
            }
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Modify_Playlist_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're about to Modify this playlist: " + playlist.Playlist_Name, "Modify " + playlist.Playlist_Name + "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(TXT_FilePath.Text))
                {
                    Image_Path = "Not Set";
                    File_Name = "Not Set";
                }
                if (Image_Path != playlist.Playlist_Image_Path && Image_Path != "Not Set")
                {
                    try
                    {
                        File.Copy(Image_Path, ML_Filepath + @"\" + File_Name, true);
                        Image_Path = ML_Filepath + @"\" + File_Name;
                    }
                    catch (Exception)
                    {
                        Image_Path = "Not Set";
                        File_Name = "Not Set";
                        this.Close();
                    }
                }

                if (!string.IsNullOrEmpty(TXT_Playlist_Name.Text))
                {
                    Playlist_Name = TXT_Playlist_Name.Text;

                    Con.Update_Playlist(Playlist_ID,Playlist_Name,Image_Path,File_Name);
                }
                else { return; }
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Main_Control_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
    }
}
