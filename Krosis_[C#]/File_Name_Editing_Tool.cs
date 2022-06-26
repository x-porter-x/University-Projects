using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Krosis_Media_Player.Classes;
using System.Windows.Forms;
using System.Diagnostics;

namespace Krosis_Media_Player
{
    public partial class File_Name_Editing_Tool : Form
    {
        List<Mp3File> SelectedFiles;
        List<Mp3File> FilesToEdit;
        Mp3File mp3File;
        bool mouseDown;
        int mouseX, mouseY;
        int CBXoption;
        string parentDirectory;
        public File_Name_Editing_Tool()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void File_Name_Editing_Tool_Load(object sender, EventArgs e)
        {
            CBX_Numbering_Scheme.SelectedIndex = 0;
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Choose_Files_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "Music Files(*.MP3;*.WAV)|*.MP3;*.WAV|All files (*.*)|*.*" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        SelectedFiles = new List<Mp3File>();
                        FilesToEdit = new List<Mp3File>();
                        foreach (String files in ofd.FileNames)
                        {
                            mp3File = new Mp3File();
                            mp3File.FileName = Path.GetFileName(files);
                            mp3File.FilePath = Path.GetFullPath(files);
                            mp3File.ParentDirectory = Path.GetDirectoryName(files);
                            SelectedFiles.Add(mp3File);
                            FilesToEdit.Add(mp3File);
                        }
                        Selected_Files.Clear();
                        Preview_Changes.Clear();
                        foreach (Mp3File G in SelectedFiles)
                        {
                            Selected_Files.AppendText(G.FileName + "\n");
                            parentDirectory = G.ParentDirectory;
                        }
                        foreach (Mp3File X in FilesToEdit) 
                        {
                            Preview_Changes.AppendText(X.FileName + "\n");
                        }
                    }
                    else
                    {
                        Selected_Files.Clear();
                        Preview_Changes.Clear();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error parsing files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BTN_Preview_Changes_Click(object sender, EventArgs e)
        {
            //if (Preview_Changes.Text.Contains(".mp3"))
            //{
            //    MessageBox.Show("MAE QUE RETRASADO QUE ES, PUSISTE UN MP3 EN LO QUE VAS A QUITAR, QUE PUTAS DICE A SU DERECHA NEGRO LEAAAAAAA ", "QUE MALDITO MONO QUE ES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Preview_Changes.Text = "";
            //    Selected_Files.Text = "";
            //}
            try
            {
                if (!string.IsNullOrEmpty(Preview_Changes.Text) || !string.IsNullOrEmpty(Selected_Files.Text))
                {
                    CBXoption = CBX_Numbering_Scheme.SelectedIndex;
                    int index = 1;
                    foreach (Mp3File G in FilesToEdit)
                    {
                        switch (CBXoption)
                        {
                            case 0:
                                G.FileName = G.FileName;
                                break;

                            case 1:
                                G.FileName = G.FileName.Insert(0, index + " ");
                                index++;
                                break;

                            case 2:
                                G.FileName = G.FileName.Insert(0, index + " - ");
                                index++;
                                break;

                            case 3:
                                if (index < 10)
                                {
                                    G.FileName = G.FileName.Insert(0, "0" + index + " ");
                                    index++;
                                }
                                else
                                {
                                    G.FileName = G.FileName.Insert(0, index + " ");
                                    index++;
                                }
                                break;

                            case 4:
                                if (index < 10)
                                {
                                    G.FileName = G.FileName.Insert(0, "0" + index + " - ");
                                    index++;
                                }
                                else
                                {
                                    G.FileName = G.FileName.Insert(0, index + " - ");
                                    index++;
                                }
                                break;
                            default:
                                break;
                        }
                        if (!string.IsNullOrEmpty(TXT_Delete_This.Text))
                        {
                            G.FileName = G.FileName.Replace(TXT_Delete_This.Text, "");
                        }
                    }
                    Preview_Changes.Clear();
                    foreach (Mp3File X in FilesToEdit)
                    {
                        Preview_Changes.AppendText(X.FileName + "\n");
                    }
                }
                else 
                {
                    MessageBox.Show("Please select at least 1 file", "No Files Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Renaming Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

        private void BTN_Commit_Changes_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You're about to rename multiple files " + "\n \n"  + "THIS CANNOT BE UNDONE", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {

                    if (!string.IsNullOrEmpty(Preview_Changes.Text) || !string.IsNullOrEmpty(Selected_Files.Text))
                    {

                        foreach (Mp3File A in FilesToEdit)
                        {
                            File.Move(A.FilePath, A.ParentDirectory + @"\" + A.FileName);
                        }

                        DialogResult OpenFolder = MessageBox.Show("File(s) were successfully renamed" + "\n \n" + "Open Containing Folder?", "File(s) Succesfully Renamed ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                        if (OpenFolder == DialogResult.OK)
                        {
                            Process.Start("explorer.exe", parentDirectory);
                        }
                        if (OpenFolder == DialogResult.Cancel)
                        {
                            return;
                        }


                    }
                    else 
                    {
                        MessageBox.Show("Please select at least 1 file", "No Files Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Renaming Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                return;
            }

        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            TXT_Delete_This.Text = "";
        }

        private void BTN_Help_Im_Retarded_Click(object sender, EventArgs e)
        {
            string Help =
                "This tool is to edit filenames in bulk, first you choose the file(s)" + "\n \n" +
                "Then you choose to remove a specific string of characters present in the file names even empty spaces" + "\n" +
                "(CASE AND SPACE SENSITIVE) " + "\n \n" +
                "To delete multiple but different strings of characters present in the filename you can type each string followed by pressing the preview changes, if you're doing this be sure to leave the numbering scheme to 'Don't Number the Files' " + "\n \n" +
                "Then you have the option to add a numbering scheme" + "\n \n" +
                "If you made a mistake and need to reset, choose the files again" + "\n \n" +
                "NOTE No.1: Whatever you see in the preview window is what the filenames will be renamed to" + "\n \n" +
                "NOTE No.2: Don't rename files that were already added to Krosis Media Player, if you do, then you'll have to delete the album and add it again.";
            MessageBox.Show(Help, "Help me I'm Retarded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTN_Delete_Beg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Selected_Files.Text))
            {
                int currentLenght;
                foreach (Mp3File G in FilesToEdit)
                {
                    currentLenght = G.FileName.Length - 5;
                    if (currentLenght - 1 != -1)
                    {
                        G.FileName = G.FileName.Remove(0, 1);
                    }
                }
                Preview_Changes.Clear();
                foreach (Mp3File X in FilesToEdit)
                {
                    Preview_Changes.AppendText(X.FileName + "\n");
                }
            }
        }

        private void BTN_Delete_End_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Selected_Files.Text))
            {
                int currentLenght;
                foreach (Mp3File G in FilesToEdit)
                {
                    currentLenght = G.FileName.Length - 5;
                    if (currentLenght - 1 > 1)
                    {
                        G.FileName = G.FileName.Remove(currentLenght, 1);
                    }
                }
                Preview_Changes.Clear();
                foreach (Mp3File X in FilesToEdit)
                {
                    Preview_Changes.AppendText(X.FileName + "\n");
                }
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
    }
}
