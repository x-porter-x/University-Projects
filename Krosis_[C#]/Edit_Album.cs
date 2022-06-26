using System;
using System.Collections.Generic;
using Krosis_Media_Player.Classes;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krosis_Media_Player
{
    public partial class Edit_Album : Form
    {
        DB Con;
        ML_Info ML;
        bool mouseDown;
        int mouseX, mouseY;
        string ID_Platform;
        string Album_Name;
        string Image_Path;
        string File_Name;
        string Composer;
        string Year;
        int AlbumID;
        AlbumToEdit sAlbum;
        string ML_Filepath;
        public Edit_Album()
        {
            Con = new DB();
            InitializeComponent();
            this.CenterToScreen();
            ML = new ML_Info();
            ML = Con.spSelect_ML_Info();
            ML_Filepath = ML.ML_Path;
        }
        private void Edit_Album_Load(object sender, EventArgs e)
        {

        }

        public void Get_ID(int ID)
        {
            AlbumID = ID;
            sAlbum = new AlbumToEdit();
            sAlbum = Con.Select_Album_To_Edit(ID);
            Con.Select_Platforms(CBX_Platform);
            CBX_Platform.SelectedValue = Convert.ToInt32(sAlbum.ID_Platform);
            TXT_Album_Name.Text = sAlbum.Album_Name;
            TXT_Composer.Text = sAlbum.Composer;
            TXT_Year.Text = sAlbum.Year;
            TXT_FilePath.Text = sAlbum.Image_Path;
            Image_Path = TXT_FilePath.Text;
            File_Name = sAlbum.File_name;
            GPX.Text = "Edit " + sAlbum.Album_Name;
            BTN_DELETE.Text = "DELETE " + sAlbum.Album_Name;
            try
            {
                Album_Art.BackgroundImage = Image.FromFile(sAlbum.Image_Path);
            }
            catch (Exception)
            {
                Album_Art.BackgroundImage = Properties.Resources.No_Art;
                return;
            }
        }

        private void BTN_Add_Console_Click(object sender, EventArgs e)
        {
            Add_Console NEW_Console = new Add_Console();
            NEW_Console.FormClosed += new FormClosedEventHandler(NEW_ConsoleFormClosed);
            NEW_Console.ShowDialog();
        }

        private void NEW_ConsoleFormClosed(object sender, FormClosedEventArgs e)
        {
            Con.Select_Platforms(CBX_Platform);
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
                        Album_Art.Size = new Size(217, 186);
                        Album_Art.BackgroundImage = Image.FromFile(fi.FullName);
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

        private void CBX_Platform_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CBX_Platform.Text))
                {
                    BTN_Reset.Enabled = true;
                    ID_Platform = CBX_Platform.SelectedValue.ToString();
                }
            }
            catch (Exception)
            {
                BTN_Reset.Enabled = false;
                CBX_Platform.SelectedIndex = 0;
            }
        }

        private void BTN_Add_Album_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're about to Modify this Album", "Modify this Album?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(TXT_FilePath.Text))
                {
                    Image_Path = "Not Set";
                    File_Name = "Not Set";
                }
                if (Image_Path != sAlbum.Image_Path && Image_Path != "Not Set")
                {
                    try
                    {
                        File.Copy(Image_Path, ML_Filepath + @"\" + TXT_Album_Name.Text + @"\" + File_Name, true);
                        Image_Path = ML_Filepath + @"\" + TXT_Album_Name.Text + @"\" + File_Name;
                    }
                    catch (Exception)
                    {
                        Image_Path = "Not Set";
                        File_Name = "Not Set";
                        this.Close();
                    }
                }
                if (CBX_Platform.SelectedIndex == 0)
                {
                    ID_Platform = "1";
                }

                if (!string.IsNullOrEmpty(TXT_Album_Name.Text))
                {
                    Album_Name = TXT_Album_Name.Text;

                    if (string.IsNullOrEmpty(CBX_Platform.Text))
                    { ID_Platform = "1"; }


                    if (string.IsNullOrEmpty(TXT_Year.Text))
                    { Year = "Not Set"; }
                    else { Year = TXT_Year.Text; }

                    if (string.IsNullOrEmpty(TXT_Composer.Text))
                    { Composer = "Unknown"; }
                    else { Composer = TXT_Composer.Text; }
                    Con.Update_Album(AlbumID, ID_Platform, Album_Name, Image_Path, File_Name, Composer, Year);
                }
                else { return; }
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            Con.Select_Platforms(CBX_Platform);
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're about to DELETE this Album: " + sAlbum.Album_Name + "\n \n" + "All music files associated with this album will be preserved, however " + "THIS CANNOT BE UNDONE", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Con.DELETE_Selected_Album(AlbumID);
                MessageBox.Show(sAlbum.Album_Name + " Succesfully deleted", "Album Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else 
            {
                return;
            }
        }

        public void Reset()
        {
            Image_Path = "";
            File_Name = "";
            TXT_FilePath.Text = "";
            Album_Art.BackgroundImage = Properties.Resources.No_Art;
        }
    }
}
