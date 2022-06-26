using System;
using System.Collections.Generic;
using Krosis_Media_Player.Classes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krosis_Media_Player
{
    public partial class Add_Console : Form
    {
        DB Con = new DB();
        bool mouseDown;
        int mouseX, mouseY;
        string NAME;
        public Add_Console()
        {
            InitializeComponent();
            this.CenterToScreen();
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
            }
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Add_Platform_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TXT_Platform_Name.Text))
            {
                try
                {
                    NAME = TXT_Platform_Name.Text;
                    Con.Insert_New_Platform(NAME);
                    MessageBox.Show("Platform Successfully Added!", "Platform Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty string as a Platform name", "Emtpy Name String", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Control_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
