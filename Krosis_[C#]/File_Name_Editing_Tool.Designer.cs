
namespace Krosis_Media_Player
{
    partial class File_Name_Editing_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File_Name_Editing_Tool));
            this.Main_Control_Bar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.GBEdit = new System.Windows.Forms.GroupBox();
            this.BTN_Delete_End = new System.Windows.Forms.Button();
            this.BTN_Delete_Beg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Help_Im_Retarded = new System.Windows.Forms.Button();
            this.Preview_Changes = new System.Windows.Forms.RichTextBox();
            this.Selected_Files = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBX_Numbering_Scheme = new System.Windows.Forms.ComboBox();
            this.BTN_Choose_Files = new System.Windows.Forms.Button();
            this.BTN_Preview_Changes = new System.Windows.Forms.Button();
            this.BTN_Commit_Changes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.TXT_Delete_This = new System.Windows.Forms.TextBox();
            this.Main_Control_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBEdit.SuspendLayout();
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
            this.Main_Control_Bar.Size = new System.Drawing.Size(1105, 30);
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
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Name Editing Tool";
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
            this.BTN_Close.Location = new System.Drawing.Point(1057, 0);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(48, 30);
            this.BTN_Close.TabIndex = 1;
            this.BTN_Close.Text = "x";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // GBEdit
            // 
            this.GBEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBEdit.Controls.Add(this.BTN_Delete_End);
            this.GBEdit.Controls.Add(this.BTN_Delete_Beg);
            this.GBEdit.Controls.Add(this.label6);
            this.GBEdit.Controls.Add(this.BTN_Help_Im_Retarded);
            this.GBEdit.Controls.Add(this.Preview_Changes);
            this.GBEdit.Controls.Add(this.Selected_Files);
            this.GBEdit.Controls.Add(this.label5);
            this.GBEdit.Controls.Add(this.CBX_Numbering_Scheme);
            this.GBEdit.Controls.Add(this.BTN_Choose_Files);
            this.GBEdit.Controls.Add(this.BTN_Preview_Changes);
            this.GBEdit.Controls.Add(this.BTN_Commit_Changes);
            this.GBEdit.Controls.Add(this.label3);
            this.GBEdit.Controls.Add(this.label1);
            this.GBEdit.Controls.Add(this.label4);
            this.GBEdit.Controls.Add(this.BTN_Reset);
            this.GBEdit.Controls.Add(this.TXT_Delete_This);
            this.GBEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GBEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.GBEdit.Location = new System.Drawing.Point(13, 35);
            this.GBEdit.Name = "GBEdit";
            this.GBEdit.Size = new System.Drawing.Size(1081, 651);
            this.GBEdit.TabIndex = 6;
            this.GBEdit.TabStop = false;
            this.GBEdit.Text = "Bulk Filename Edit";
            // 
            // BTN_Delete_End
            // 
            this.BTN_Delete_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Delete_End.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Delete_End.Location = new System.Drawing.Point(833, 473);
            this.BTN_Delete_End.Name = "BTN_Delete_End";
            this.BTN_Delete_End.Size = new System.Drawing.Size(242, 52);
            this.BTN_Delete_End.TabIndex = 40;
            this.BTN_Delete_End.Text = "Delete 1 Char at The End↑";
            this.BTN_Delete_End.UseVisualStyleBackColor = true;
            this.BTN_Delete_End.Click += new System.EventHandler(this.BTN_Delete_End_Click);
            // 
            // BTN_Delete_Beg
            // 
            this.BTN_Delete_Beg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Delete_Beg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Delete_Beg.Location = new System.Drawing.Point(571, 473);
            this.BTN_Delete_Beg.Name = "BTN_Delete_Beg";
            this.BTN_Delete_Beg.Size = new System.Drawing.Size(242, 52);
            this.BTN_Delete_Beg.TabIndex = 39;
            this.BTN_Delete_Beg.Text = "Delete 1 Char at The Beginning↑";
            this.BTN_Delete_Beg.UseVisualStyleBackColor = true;
            this.BTN_Delete_Beg.Click += new System.EventHandler(this.BTN_Delete_Beg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(571, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(475, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "DO NOT DELETE \".MP3\" From the File, The Program does this automatically";
            // 
            // BTN_Help_Im_Retarded
            // 
            this.BTN_Help_Im_Retarded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Help_Im_Retarded.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Help_Im_Retarded.Location = new System.Drawing.Point(996, 15);
            this.BTN_Help_Im_Retarded.Name = "BTN_Help_Im_Retarded";
            this.BTN_Help_Im_Retarded.Size = new System.Drawing.Size(84, 27);
            this.BTN_Help_Im_Retarded.TabIndex = 37;
            this.BTN_Help_Im_Retarded.Text = "Help";
            this.BTN_Help_Im_Retarded.UseVisualStyleBackColor = true;
            this.BTN_Help_Im_Retarded.Click += new System.EventHandler(this.BTN_Help_Im_Retarded_Click);
            // 
            // Preview_Changes
            // 
            this.Preview_Changes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Preview_Changes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Preview_Changes.ForeColor = System.Drawing.SystemColors.Window;
            this.Preview_Changes.Location = new System.Drawing.Point(571, 94);
            this.Preview_Changes.Name = "Preview_Changes";
            this.Preview_Changes.ReadOnly = true;
            this.Preview_Changes.Size = new System.Drawing.Size(504, 294);
            this.Preview_Changes.TabIndex = 36;
            this.Preview_Changes.Text = "";
            this.Preview_Changes.WordWrap = false;
            // 
            // Selected_Files
            // 
            this.Selected_Files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Selected_Files.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Selected_Files.ForeColor = System.Drawing.SystemColors.Window;
            this.Selected_Files.Location = new System.Drawing.Point(23, 94);
            this.Selected_Files.Name = "Selected_Files";
            this.Selected_Files.ReadOnly = true;
            this.Selected_Files.Size = new System.Drawing.Size(504, 294);
            this.Selected_Files.TabIndex = 35;
            this.Selected_Files.Text = "";
            this.Selected_Files.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(24, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Add Numbering Scheme";
            // 
            // CBX_Numbering_Scheme
            // 
            this.CBX_Numbering_Scheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CBX_Numbering_Scheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Numbering_Scheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBX_Numbering_Scheme.ForeColor = System.Drawing.SystemColors.Window;
            this.CBX_Numbering_Scheme.FormattingEnabled = true;
            this.CBX_Numbering_Scheme.Items.AddRange(new object[] {
            "Don\'t Number the Files",
            "Option 1: e.g. 1 SongName, 2 SongName, etc.",
            "Option 2: e.g. 1 - SongName, 2 - SongName, etc.",
            "Option 3: e.g. 01 SongName, 02 SongName, etc.",
            "Option 4: e.g. 01 - SongName, 02 - SongName, etc."});
            this.CBX_Numbering_Scheme.Location = new System.Drawing.Point(24, 592);
            this.CBX_Numbering_Scheme.MaxDropDownItems = 10;
            this.CBX_Numbering_Scheme.Name = "CBX_Numbering_Scheme";
            this.CBX_Numbering_Scheme.Size = new System.Drawing.Size(504, 31);
            this.CBX_Numbering_Scheme.TabIndex = 33;
            // 
            // BTN_Choose_Files
            // 
            this.BTN_Choose_Files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Choose_Files.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Choose_Files.Location = new System.Drawing.Point(23, 412);
            this.BTN_Choose_Files.Name = "BTN_Choose_Files";
            this.BTN_Choose_Files.Size = new System.Drawing.Size(504, 52);
            this.BTN_Choose_Files.TabIndex = 32;
            this.BTN_Choose_Files.Text = "Choose Files to Edit ↑";
            this.BTN_Choose_Files.UseVisualStyleBackColor = true;
            this.BTN_Choose_Files.Click += new System.EventHandler(this.BTN_Choose_Files_Click);
            // 
            // BTN_Preview_Changes
            // 
            this.BTN_Preview_Changes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Preview_Changes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Preview_Changes.Location = new System.Drawing.Point(571, 412);
            this.BTN_Preview_Changes.Name = "BTN_Preview_Changes";
            this.BTN_Preview_Changes.Size = new System.Drawing.Size(504, 52);
            this.BTN_Preview_Changes.TabIndex = 31;
            this.BTN_Preview_Changes.Text = "Preview Changes ↑";
            this.BTN_Preview_Changes.UseVisualStyleBackColor = true;
            this.BTN_Preview_Changes.Click += new System.EventHandler(this.BTN_Preview_Changes_Click);
            // 
            // BTN_Commit_Changes
            // 
            this.BTN_Commit_Changes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.BTN_Commit_Changes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Commit_Changes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Commit_Changes.Location = new System.Drawing.Point(571, 592);
            this.BTN_Commit_Changes.Name = "BTN_Commit_Changes";
            this.BTN_Commit_Changes.Size = new System.Drawing.Size(504, 52);
            this.BTN_Commit_Changes.TabIndex = 30;
            this.BTN_Commit_Changes.Text = "Commit Changes (NO Undo)";
            this.BTN_Commit_Changes.UseVisualStyleBackColor = true;
            this.BTN_Commit_Changes.Click += new System.EventHandler(this.BTN_Commit_Changes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(571, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Preview Changes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Files selected:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(24, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "String to be deleted:";
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reset.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTN_Reset.Location = new System.Drawing.Point(480, 512);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(47, 27);
            this.BTN_Reset.TabIndex = 26;
            this.BTN_Reset.Text = "Reset";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // TXT_Delete_This
            // 
            this.TXT_Delete_This.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TXT_Delete_This.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Delete_This.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TXT_Delete_This.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_Delete_This.Location = new System.Drawing.Point(24, 514);
            this.TXT_Delete_This.Name = "TXT_Delete_This";
            this.TXT_Delete_This.PlaceholderText = "String to be removed from the file name";
            this.TXT_Delete_This.Size = new System.Drawing.Size(449, 20);
            this.TXT_Delete_This.TabIndex = 25;
            // 
            // File_Name_Editing_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1105, 699);
            this.Controls.Add(this.GBEdit);
            this.Controls.Add(this.Main_Control_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "File_Name_Editing_Tool";
            this.Text = "File Name Editing Tool";
            this.Load += new System.EventHandler(this.File_Name_Editing_Tool_Load);
            this.Main_Control_Bar.ResumeLayout(false);
            this.Main_Control_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBEdit.ResumeLayout(false);
            this.GBEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Control_Bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.GroupBox GBEdit;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.TextBox TXT_Delete_This;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Choose_Files;
        private System.Windows.Forms.Button BTN_Preview_Changes;
        private System.Windows.Forms.Button BTN_Commit_Changes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBX_Numbering_Scheme;
        private System.Windows.Forms.RichTextBox Selected_Files;
        private System.Windows.Forms.RichTextBox Preview_Changes;
        private System.Windows.Forms.Button BTN_Help_Im_Retarded;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Delete_End;
        private System.Windows.Forms.Button BTN_Delete_Beg;
    }
}
