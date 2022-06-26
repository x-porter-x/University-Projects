
namespace Krosis_Media_Player
{
    partial class Edit_Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Playlist));
            this.Main_Control_Bar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.GPX = new System.Windows.Forms.GroupBox();
            this.LBL_Created_On = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BTN_Modify_Playlist = new System.Windows.Forms.Button();
            this.BTN_Add_Image = new System.Windows.Forms.Button();
            this.TXT_FilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Playlist_Image = new System.Windows.Forms.PictureBox();
            this.TXT_Playlist_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist_Image)).BeginInit();
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
            this.Main_Control_Bar.TabIndex = 6;
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
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edit This Playlist";
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
            this.GPX.Controls.Add(this.LBL_Created_On);
            this.GPX.Controls.Add(this.label9);
            this.GPX.Controls.Add(this.BTN_Modify_Playlist);
            this.GPX.Controls.Add(this.BTN_Add_Image);
            this.GPX.Controls.Add(this.TXT_FilePath);
            this.GPX.Controls.Add(this.label5);
            this.GPX.Controls.Add(this.Playlist_Image);
            this.GPX.Controls.Add(this.TXT_Playlist_Name);
            this.GPX.Controls.Add(this.label1);
            this.GPX.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GPX.ForeColor = System.Drawing.SystemColors.Window;
            this.GPX.Location = new System.Drawing.Point(12, 36);
            this.GPX.Name = "GPX";
            this.GPX.Size = new System.Drawing.Size(540, 511);
            this.GPX.TabIndex = 9;
            this.GPX.TabStop = false;
            this.GPX.Text = "Edit";
            // 
            // LBL_Created_On
            // 
            this.LBL_Created_On.AutoSize = true;
            this.LBL_Created_On.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LBL_Created_On.Location = new System.Drawing.Point(177, 41);
            this.LBL_Created_On.Name = "LBL_Created_On";
            this.LBL_Created_On.Size = new System.Drawing.Size(134, 16);
            this.LBL_Created_On.TabIndex = 21;
            this.LBL_Created_On.Text = "Playlist Created On:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Recomended Image Size:  217 x 186";
            // 
            // BTN_Modify_Playlist
            // 
            this.BTN_Modify_Playlist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Modify_Playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Modify_Playlist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Modify_Playlist.Location = new System.Drawing.Point(3, 437);
            this.BTN_Modify_Playlist.Name = "BTN_Modify_Playlist";
            this.BTN_Modify_Playlist.Size = new System.Drawing.Size(534, 71);
            this.BTN_Modify_Playlist.TabIndex = 19;
            this.BTN_Modify_Playlist.Text = "Modify This Playlist";
            this.BTN_Modify_Playlist.UseVisualStyleBackColor = true;
            this.BTN_Modify_Playlist.Click += new System.EventHandler(this.BTN_Modify_Playlist_Click);
            // 
            // BTN_Add_Image
            // 
            this.BTN_Add_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Add_Image.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Add_Image.Location = new System.Drawing.Point(310, 317);
            this.BTN_Add_Image.Name = "BTN_Add_Image";
            this.BTN_Add_Image.Size = new System.Drawing.Size(224, 52);
            this.BTN_Add_Image.TabIndex = 18;
            this.BTN_Add_Image.Text = "Choose Image...";
            this.BTN_Add_Image.UseVisualStyleBackColor = true;
            this.BTN_Add_Image.Click += new System.EventHandler(this.BTN_Add_Image_Click);
            // 
            // TXT_FilePath
            // 
            this.TXT_FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_FilePath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_FilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_FilePath.Location = new System.Drawing.Point(9, 375);
            this.TXT_FilePath.Name = "TXT_FilePath";
            this.TXT_FilePath.PlaceholderText = "Playlist Image File Path";
            this.TXT_FilePath.ReadOnly = true;
            this.TXT_FilePath.Size = new System.Drawing.Size(525, 20);
            this.TXT_FilePath.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Playlist Image";
            // 
            // Playlist_Image
            // 
            this.Playlist_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Playlist_Image.Location = new System.Drawing.Point(11, 183);
            this.Playlist_Image.Name = "Playlist_Image";
            this.Playlist_Image.Size = new System.Drawing.Size(217, 186);
            this.Playlist_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playlist_Image.TabIndex = 14;
            this.Playlist_Image.TabStop = false;
            // 
            // TXT_Playlist_Name
            // 
            this.TXT_Playlist_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_Playlist_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Playlist_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_Playlist_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_Playlist_Name.Location = new System.Drawing.Point(24, 61);
            this.TXT_Playlist_Name.Name = "TXT_Playlist_Name";
            this.TXT_Playlist_Name.PlaceholderText = "Name of the Playlist";
            this.TXT_Playlist_Name.Size = new System.Drawing.Size(287, 20);
            this.TXT_Playlist_Name.TabIndex = 6;
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
            // Edit_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(564, 559);
            this.Controls.Add(this.GPX);
            this.Controls.Add(this.Main_Control_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Playlist";
            this.Text = "Edit Playlist";
            this.Main_Control_Bar.ResumeLayout(false);
            this.Main_Control_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GPX.ResumeLayout(false);
            this.GPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Control_Bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.GroupBox GPX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTN_Modify_Playlist;
        private System.Windows.Forms.Button BTN_Add_Image;
        private System.Windows.Forms.TextBox TXT_FilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Playlist_Image;
        private System.Windows.Forms.TextBox TXT_Playlist_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Created_On;
    }
}
