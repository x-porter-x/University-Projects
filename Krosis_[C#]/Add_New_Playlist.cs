using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Krosis_Media_Player.Classes;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krosis_Media_Player
{
    public partial class Add_New_Playlist : Form
    {
        DB Con;
        ML_Info ML;
        string Playlist_Name;
        string Image_Path;
        string File_Name;
        bool mouseDown;
        int mouseX, mouseY;
        string ML_Filepath;
        public Add_New_Playlist()
        {
            Con = new DB();
            InitializeComponent();
            this.CenterToScreen();
            ML = new ML_Info();
            ML = Con.spSelect_ML_Info();
            ML_Filepath = ML.ML_Path;
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTN_Add_Playlist_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXT_Playlist_Name.Text))
            {
                Playlist_Name = TXT_Playlist_Name.Text;
                if (!string.IsNullOrEmpty(TXT_FilePath.Text))
                {
                    File.Copy(Image_Path, ML_Filepath + @"\" + File_Name, true);
                    Image_Path = ML_Filepath + @"\" + File_Name;
                }
                else 
                {
                    Image_Path = "";
                    File_Name = "";
                }
                try
                {
                    Con.Insert_New_Playlist(Playlist_Name, Image_Path, File_Name);
                    MessageBox.Show("Playlist " + Playlist_Name + " Has been created Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception)
                {
                    return;
                }
            }
            else 
            {
                MessageBox.Show("You have to name your playlist", "Playlist Has No Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        struct image
        {
            public string FileName { get; set; }
            public string FullName { get; set; }
        }

        image _Imagepath;
        private void BTN_Add_Playlist_Image_Click(object sender, EventArgs e)
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
                        Album_Art.Size = new Size(217, 186);
                        Album_Art.BackgroundImage = Image.FromFile(fi.FullName);
                    }
                    else
                    {
                        Image_Path = "";
                        TXT_FilePath.Text = "";
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void Main_Control_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
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
    }
}
