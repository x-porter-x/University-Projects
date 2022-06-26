
namespace Krosis_Media_Player
{
    partial class Add_Console
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Console));
            this.Main_Control_Bar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.GBX_New = new System.Windows.Forms.GroupBox();
            this.TXT_Platform_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Add_Platform = new System.Windows.Forms.Button();
            this.Main_Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBX_New.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Control_Bar
            // 
            this.Main_Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Main_Control_Bar.Controls.Add(this.pictureBox1);
            this.Main_Control_Bar.Controls.Add(this.label2);
            this.Main_Control_Bar.Controls.Add(this.BTN_Close);
            this.Main_Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Main_Control_Bar.Location = new System.Drawing.Point(0, 0);
            this.Main_Control_Bar.Name = "Main_Control_Bar";
            this.Main_Control_Bar.Size = new System.Drawing.Size(368, 30);
            this.Main_Control_Bar.TabIndex = 5;
            this.Main_Control_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Control_Bar_MouseDown);
            this.Main_Control_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_Control_Bar_MouseMove);
            this.Main_Control_Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_Control_Bar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(36, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add a New Platform";
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
            this.BTN_Close.Location = new System.Drawing.Point(320, 0);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(48, 30);
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "x";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // GBX_New
            // 
            this.GBX_New.Controls.Add(this.BTN_Add_Platform);
            this.GBX_New.Controls.Add(this.TXT_Platform_Name);
            this.GBX_New.Controls.Add(this.label1);
            this.GBX_New.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GBX_New.ForeColor = System.Drawing.SystemColors.Window;
            this.GBX_New.Location = new System.Drawing.Point(12, 36);
            this.GBX_New.Name = "GBX_New";
            this.GBX_New.Size = new System.Drawing.Size(344, 214);
            this.GBX_New.TabIndex = 8;
            this.GBX_New.TabStop = false;
            this.GBX_New.Text = "New Platform";
            // 
            // TXT_Platform_Name
            // 
            this.TXT_Platform_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_Platform_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Platform_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_Platform_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_Platform_Name.Location = new System.Drawing.Point(24, 61);
            this.TXT_Platform_Name.Name = "TXT_Platform_Name";
            this.TXT_Platform_Name.PlaceholderText = "Name of The Platform ";
            this.TXT_Platform_Name.Size = new System.Drawing.Size(287, 20);
            this.TXT_Platform_Name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name of The New Platform";
            // 
            // BTN_Add_Platform
            // 
            this.BTN_Add_Platform.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Add_Platform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Add_Platform.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Add_Platform.Location = new System.Drawing.Point(3, 157);
            this.BTN_Add_Platform.Name = "BTN_Add_Platform";
            this.BTN_Add_Platform.Size = new System.Drawing.Size(338, 54);
            this.BTN_Add_Platform.TabIndex = 20;
            this.BTN_Add_Platform.Text = "Add New Platform";
            this.BTN_Add_Platform.UseVisualStyleBackColor = true;
            this.BTN_Add_Platform.Click += new System.EventHandler(this.BTN_Add_Platform_Click);
            // 
            // Add_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(368, 262);
            this.Controls.Add(this.GBX_New);
            this.Controls.Add(this.Main_Control_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Console";
            this.Text = "Add_Console";
            this.Main_Control_Bar.ResumeLayout(false);
            this.Main_Control_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBX_New.ResumeLayout(false);
            this.GBX_New.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Control_Bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.GroupBox GBX_New;
        private System.Windows.Forms.TextBox TXT_Platform_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Add_Platform;
    }
}
