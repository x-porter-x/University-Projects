﻿
namespace Krosis_Media_Player
{
    partial class Edit_Album
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Album));
            this.Main_Control_Bar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.GPX = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_Add_Console = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.CBX_Platform = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BTN_Add_Album = new System.Windows.Forms.Button();
            this.BTN_Add_Image = new System.Windows.Forms.Button();
            this.TXT_FilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Album_Art = new System.Windows.Forms.PictureBox();
            this.TXT_Year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Composer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Album_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.Main_Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Album_Art)).BeginInit();
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
            this.Main_Control_Bar.Size = new System.Drawing.Size(564, 30);
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
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edit This Album";
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
            this.BTN_Close.Location = new System.Drawing.Point(516, 0);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(48, 30);
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "x";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // GPX
            // 
            this.GPX.Controls.Add(this.label8);
            this.GPX.Controls.Add(this.BTN_Add_Console);
            this.GPX.Controls.Add(this.BTN_Reset);
            this.GPX.Controls.Add(this.CBX_Platform);
            this.GPX.Controls.Add(this.label11);
            this.GPX.Controls.Add(this.label9);
            this.GPX.Controls.Add(this.BTN_Add_Album);
            this.GPX.Controls.Add(this.BTN_Add_Image);
            this.GPX.Controls.Add(this.TXT_FilePath);
            this.GPX.Controls.Add(this.label5);
            this.GPX.Controls.Add(this.Album_Art);
            this.GPX.Controls.Add(this.TXT_Year);
            this.GPX.Controls.Add(this.label4);
            this.GPX.Controls.Add(this.TXT_Composer);
            this.GPX.Controls.Add(this.label3);
            this.GPX.Controls.Add(this.TXT_Album_Name);
            this.GPX.Controls.Add(this.label1);
            this.GPX.Controls.Add(this.BTN_DELETE);
            this.GPX.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GPX.ForeColor = System.Drawing.SystemColors.Window;
            this.GPX.Location = new System.Drawing.Point(12, 36);
            this.GPX.Name = "GPX";
            this.GPX.Size = new System.Drawing.Size(540, 738);
            this.GPX.TabIndex = 8;
            this.GPX.TabStop = false;
            this.GPX.Text = "Edit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(162, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "(Album name can\'t be changed)";
            // 
            // BTN_Add_Console
            // 
            this.BTN_Add_Console.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Add_Console.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Add_Console.Location = new System.Drawing.Point(283, 245);
            this.BTN_Add_Console.Name = "BTN_Add_Console";
            this.BTN_Add_Console.Size = new System.Drawing.Size(48, 31);
            this.BTN_Add_Console.TabIndex = 25;
            this.BTN_Add_Console.Text = "Add";
            this.BTN_Add_Console.UseVisualStyleBackColor = true;
            this.BTN_Add_Console.Click += new System.EventHandler(this.BTN_Add_Console_Click);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Enabled = false;
            this.BTN_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reset.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Reset.Location = new System.Drawing.Point(229, 245);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(48, 31);
            this.BTN_Reset.TabIndex = 24;
            this.BTN_Reset.Text = "Reset";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // CBX_Platform
            // 
            this.CBX_Platform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CBX_Platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Platform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBX_Platform.ForeColor = System.Drawing.SystemColors.Window;
            this.CBX_Platform.FormattingEnabled = true;
            this.CBX_Platform.Location = new System.Drawing.Point(8, 245);
            this.CBX_Platform.MaxDropDownItems = 10;
            this.CBX_Platform.Name = "CBX_Platform";
            this.CBX_Platform.Size = new System.Drawing.Size(215, 31);
            this.CBX_Platform.TabIndex = 23;
            this.CBX_Platform.SelectedIndexChanged += new System.EventHandler(this.CBX_Platform_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(6, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Album Game System";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Recomended Image Size:  217 x 186";
            // 
            // BTN_Add_Album
            // 
            this.BTN_Add_Album.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Add_Album.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Add_Album.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Add_Album.Location = new System.Drawing.Point(3, 609);
            this.BTN_Add_Album.Name = "BTN_Add_Album";
            this.BTN_Add_Album.Size = new System.Drawing.Size(534, 71);
            this.BTN_Add_Album.TabIndex = 19;
            this.BTN_Add_Album.Text = "Modify this Album";
            this.BTN_Add_Album.UseVisualStyleBackColor = true;
            this.BTN_Add_Album.Click += new System.EventHandler(this.BTN_Add_Album_Click);
            // 
            // BTN_Add_Image
            // 
            this.BTN_Add_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Add_Image.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Add_Image.Location = new System.Drawing.Point(307, 493);
            this.BTN_Add_Image.Name = "BTN_Add_Image";
            this.BTN_Add_Image.Size = new System.Drawing.Size(224, 52);
            this.BTN_Add_Image.TabIndex = 18;
            this.BTN_Add_Image.Text = "Choose Album Art";
            this.BTN_Add_Image.UseVisualStyleBackColor = true;
            this.BTN_Add_Image.Click += new System.EventHandler(this.BTN_Add_Image_Click);
            // 
            // TXT_FilePath
            // 
            this.TXT_FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_FilePath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_FilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_FilePath.Location = new System.Drawing.Point(6, 551);
            this.TXT_FilePath.Name = "TXT_FilePath";
            this.TXT_FilePath.PlaceholderText = "Album Cover File Path";
            this.TXT_FilePath.ReadOnly = true;
            this.TXT_FilePath.Size = new System.Drawing.Size(525, 20);
            this.TXT_FilePath.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(3, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Album Cover Art";
            // 
            // Album_Art
            // 
            this.Album_Art.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Album_Art.Location = new System.Drawing.Point(8, 359);
            this.Album_Art.Name = "Album_Art";
            this.Album_Art.Size = new System.Drawing.Size(217, 186);
            this.Album_Art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Album_Art.TabIndex = 14;
            this.Album_Art.TabStop = false;
            // 
            // TXT_Year
            // 
            this.TXT_Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_Year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Year.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_Year.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_Year.Location = new System.Drawing.Point(24, 177);
            this.TXT_Year.Name = "TXT_Year";
            this.TXT_Year.PlaceholderText = "Year";
            this.TXT_Year.Size = new System.Drawing.Size(229, 20);
            this.TXT_Year.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year Released";
            // 
            // TXT_Composer
            // 
            this.TXT_Composer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_Composer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Composer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_Composer.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_Composer.Location = new System.Drawing.Point(24, 120);
            this.TXT_Composer.Name = "TXT_Composer";
            this.TXT_Composer.PlaceholderText = "Composer\'s Name";
            this.TXT_Composer.Size = new System.Drawing.Size(287, 20);
            this.TXT_Composer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name of the Composer";
            // 
            // TXT_Album_Name
            // 
            this.TXT_Album_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_Album_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Album_Name.Enabled = false;
            this.TXT_Album_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_Album_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_Album_Name.Location = new System.Drawing.Point(24, 61);
            this.TXT_Album_Name.Name = "TXT_Album_Name";
            this.TXT_Album_Name.PlaceholderText = "Album\'s Name";
            this.TXT_Album_Name.ReadOnly = true;
            this.TXT_Album_Name.Size = new System.Drawing.Size(287, 20);
            this.TXT_Album_Name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name of the Album";
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_DELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_DELETE.Location = new System.Drawing.Point(3, 680);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(534, 55);
            this.BTN_DELETE.TabIndex = 27;
            this.BTN_DELETE.Text = "Delete";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // Edit_Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(564, 786);
            this.Controls.Add(this.GPX);
            this.Controls.Add(this.Main_Control_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Album";
            this.Text = "Edit_Album";
            this.Load += new System.EventHandler(this.Edit_Album_Load);
            this.Main_Control_Bar.ResumeLayout(false);
            this.Main_Control_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GPX.ResumeLayout(false);
            this.GPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Album_Art)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Control_Bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.GroupBox GPX;
        private System.Windows.Forms.Button BTN_Add_Console;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.ComboBox CBX_Platform;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTN_Add_Album;
        private System.Windows.Forms.Button BTN_Add_Image;
        private System.Windows.Forms.TextBox TXT_FilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Album_Art;
        private System.Windows.Forms.TextBox TXT_Year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Composer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Album_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_DELETE;
    }
}