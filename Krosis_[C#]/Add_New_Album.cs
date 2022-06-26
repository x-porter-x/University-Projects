using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Threading.Tasks;
using Krosis_Media_Player.Classes;
using System.Windows.Forms;

namespace Krosis_Media_Player
{
    public partial class Add_New_Album : Form
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
        string ML_Filepath;

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

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Control_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void Add_New_Album_Load(object sender, EventArgs e)
        {
            Con.Select_Platforms(CBX_Platform);
            this.CenterToScreen();
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
                ID_Platform = "1";
            }
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            Con.Select_Platforms(CBX_Platform);
            BTN_Reset.Enabled = false;
            ID_Platform = "";
        }

        private void TXT_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TXT_Year_TextChanged(object sender, EventArgs e)
        {
            if (TXT_Year.TextLength > 4)
            {
                string nag = "Mae que putas, dios osea, sea tan imbecil es un año, piense un toque animal dios mio osea supe que en algún momento usted iba a poner una fecha mal e iba a ponerle un numerito más, wow mae que inteligente" + "\n" + "\n" + "Gracias por respetar mi tiempo haciendome perder 20 segundos escribiendo esta picha PEDAZO DE MIERDAAAAA" + "\n" + "\n" + "Escríbalo otra vez por imbécil";
                MessageBox.Show(nag, "Gracias Gregory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXT_Year.Text = "";
            }
        }

        private void BTN_Add_Album_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXT_Album_Name.Text))
            {
                Album_Name = TXT_Album_Name.Text.Trim();

                if (string.IsNullOrEmpty(TXT_FilePath.Text))
                { 
                    Image_Path = "Not Set";
                    File_Name = "Not Set";
                }

                if (CBX_Platform.SelectedIndex == 0)
                {
                    ID_Platform = "1";
                }

                if (string.IsNullOrEmpty(TXT_Year.Text))
                { Year = "Uknown"; }
                else { Year = TXT_Year.Text; }

                if (string.IsNullOrEmpty(TXT_Composer.Text))
                { Composer = "Uknown"; }
                else{ Composer = TXT_Composer.Text; }

                Add_Album();
            }
            else {return;}
        }

        private void Add_Album() 
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("You're about to add a new Album" + "\n" + "\n" + "Add this Album to Your Colection?", "Add This Album to Music Library", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (!Directory.Exists(Path.Combine(ML_Filepath, @"\" + TXT_Album_Name.Text)))
                    {
                        Directory.CreateDirectory(ML_Filepath + @"\" + TXT_Album_Name.Text);
                    }
                    if (!string.IsNullOrEmpty(TXT_FilePath.Text))
                    {
                        File.Copy(Image_Path, ML_Filepath + @"\" + TXT_Album_Name.Text.Trim() + @"\" + File_Name, true);
                        Image_Path = ML_Filepath + @"\" + TXT_Album_Name.Text.Trim() + @"\" + File_Name;
                    }
                    Con.Insert_New_Album(ID_Platform, Album_Name, Image_Path, File_Name, Composer, Year);
                    MessageBox.Show("Album Successfully Created!", "Album Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error ocurred while creating a new album", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                        Album_Art.BackgroundImage = Image.FromFile(fi.FullName);
                        Album_Art.Invalidate();
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
        public void Reset() 
        {
            Image_Path = "";
            File_Name = "";
            TXT_FilePath.Text = "";
            Album_Art.BackgroundImage = Properties.Resources.No_Art;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        public Add_New_Album()
        {
            Con = new DB();
            InitializeComponent();
            ML = new ML_Info();
            ML = Con.spSelect_ML_Info();
            ML_Filepath = ML.ML_Path;
        }
    }
}
