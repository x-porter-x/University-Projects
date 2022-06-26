
namespace Krosis_Media_Player
{
    partial class Edit_Song
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Song));
            this.Main_Control_Bar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Save_Changes = new System.Windows.Forms.Button();
            this.BTN_Set_File_Path = new System.Windows.Forms.Button();
            this.TXT_FilePath = new System.Windows.Forms.TextBox();
            this.TXT_File_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Song_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.Main_Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.Main_Control_Bar.Size = new System.Drawing.Size(501, 30);
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
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edit this Song";
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
            this.BTN_Close.Location = new System.Drawing.Point(453, 0);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(48, 30);
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "x";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BTN_Save_Changes);
            this.groupBox1.Controls.Add(this.BTN_Set_File_Path);
            this.groupBox1.Controls.Add(this.TXT_FilePath);
            this.groupBox1.Controls.Add(this.TXT_File_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_Song_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTN_DELETE);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 558);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Song";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(6, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "File Path";
            // 
            // BTN_Save_Changes
            // 
            this.BTN_Save_Changes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Save_Changes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save_Changes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Save_Changes.Location = new System.Drawing.Point(3, 429);
            this.BTN_Save_Changes.Name = "BTN_Save_Changes";
            this.BTN_Save_Changes.Size = new System.Drawing.Size(471, 71);
            this.BTN_Save_Changes.TabIndex = 20;
            this.BTN_Save_Changes.Text = "Save Changes";
            this.BTN_Save_Changes.UseVisualStyleBackColor = true;
            this.BTN_Save_Changes.Click += new System.EventHandler(this.BTN_Save_Changes_Click);
            // 
            // BTN_Set_File_Path
            // 
            this.BTN_Set_File_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Set_File_Path.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Set_File_Path.Location = new System.Drawing.Point(230, 273);
            this.BTN_Set_File_Path.Name = "BTN_Set_File_Path";
            this.BTN_Set_File_Path.Size = new System.Drawing.Size(241, 66);
            this.BTN_Set_File_Path.TabIndex = 18;
            this.BTN_Set_File_Path.Text = "Change the Music File";
            this.BTN_Set_File_Path.UseVisualStyleBackColor = true;
            this.BTN_Set_File_Path.Click += new System.EventHandler(this.BTN_Set_File_Path_Click);
            // 
            // TXT_FilePath
            // 
            this.TXT_FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_FilePath.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_FilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_FilePath.Location = new System.Drawing.Point(6, 247);
            this.TXT_FilePath.Name = "TXT_FilePath";
            this.TXT_FilePath.PlaceholderText = "Song File Path";
            this.TXT_FilePath.ReadOnly = true;
            this.TXT_FilePath.Size = new System.Drawing.Size(454, 20);
            this.TXT_FilePath.TabIndex = 17;
            // 
            // TXT_File_Name
            // 
            this.TXT_File_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_File_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_File_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_File_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_File_Name.Location = new System.Drawing.Point(6, 183);
            this.TXT_File_Name.Name = "TXT_File_Name";
            this.TXT_File_Name.PlaceholderText = "File name";
            this.TXT_File_Name.ReadOnly = true;
            this.TXT_File_Name.Size = new System.Drawing.Size(287, 20);
            this.TXT_File_Name.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Name";
            // 
            // TXT_Song_Name
            // 
            this.TXT_Song_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TXT_Song_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Song_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_Song_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_Song_Name.Location = new System.Drawing.Point(6, 61);
            this.TXT_Song_Name.Name = "TXT_Song_Name";
            this.TXT_Song_Name.PlaceholderText = "Name of the Song";
            this.TXT_Song_Name.Size = new System.Drawing.Size(287, 20);
            this.TXT_Song_Name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name of the Song";
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_DELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_DELETE.Location = new System.Drawing.Point(3, 500);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(471, 55);
            this.BTN_DELETE.TabIndex = 21;
            this.BTN_DELETE.Text = "Delete this Song";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // Edit_Song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(501, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Main_Control_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Song";
            this.Text = "Edit_Song";
            this.Main_Control_Bar.ResumeLayout(false);
            this.Main_Control_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Control_Bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Set_File_Path;
        private System.Windows.Forms.TextBox TXT_FilePath;
        private System.Windows.Forms.TextBox TXT_File_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Song_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Save_Changes;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Label label4;
    }
}
