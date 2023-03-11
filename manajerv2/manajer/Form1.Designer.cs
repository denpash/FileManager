
namespace manajer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.FileNameBlanck = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.FilePatchTextBox = new System.Windows.Forms.TextBox();
            this.FileType = new System.Windows.Forms.Label();
            this.FileTypeBlank = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CosoleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(736, 13);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(61, 23);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(4, 423);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(58, 15);
            this.FileName.TabIndex = 2;
            this.FileName.Text = "File name";
            // 
            // FileNameBlanck
            // 
            this.FileNameBlanck.AutoSize = true;
            this.FileNameBlanck.Location = new System.Drawing.Point(68, 423);
            this.FileNameBlanck.Name = "FileNameBlanck";
            this.FileNameBlanck.Size = new System.Drawing.Size(17, 15);
            this.FileNameBlanck.TabIndex = 3;
            this.FileNameBlanck.Text = "--";
            this.FileNameBlanck.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.IconList;
            this.listView1.Location = new System.Drawing.Point(12, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 369);
            this.listView1.SmallImageList = this.IconList;
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // IconList
            // 
            this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "icons8-папка-40.png");
            this.IconList.Images.SetKeyName(1, "icons8-txt-file-64.png");
            this.IconList.Images.SetKeyName(2, "icons8-файл-47.png");
            this.IconList.Images.SetKeyName(3, "icons8-exe-file-format-64.png");
            this.IconList.Images.SetKeyName(4, "icons8-png-48.png");
            this.IconList.Images.SetKeyName(5, "icons8-jpg-48.png");
            this.IconList.Images.SetKeyName(6, "icons8-gif-48.png");
            this.IconList.Images.SetKeyName(7, "icons8-музыка-в-mp3-40.png");
            this.IconList.Images.SetKeyName(8, "icons8-mp4-64.png");
            this.IconList.Images.SetKeyName(9, "icons8-pdf-40.png");
            this.IconList.Images.SetKeyName(10, "icons8-zip-48.png");
            this.IconList.Images.SetKeyName(11, "document.png");
            // 
            // FilePatchTextBox
            // 
            this.FilePatchTextBox.Location = new System.Drawing.Point(93, 13);
            this.FilePatchTextBox.Name = "FilePatchTextBox";
            this.FilePatchTextBox.Size = new System.Drawing.Size(613, 23);
            this.FilePatchTextBox.TabIndex = 5;
            this.FilePatchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FileType
            // 
            this.FileType.AutoSize = true;
            this.FileType.Location = new System.Drawing.Point(655, 423);
            this.FileType.Name = "FileType";
            this.FileType.Size = new System.Drawing.Size(51, 15);
            this.FileType.TabIndex = 7;
            this.FileType.Text = "File type";
            this.FileType.Click += new System.EventHandler(this.label3_Click);
            // 
            // FileTypeBlank
            // 
            this.FileTypeBlank.AutoSize = true;
            this.FileTypeBlank.Location = new System.Drawing.Point(712, 423);
            this.FileTypeBlank.Name = "FileTypeBlank";
            this.FileTypeBlank.Size = new System.Drawing.Size(17, 15);
            this.FileTypeBlank.TabIndex = 6;
            this.FileTypeBlank.Text = "--";
            this.FileTypeBlank.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(627, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CosoleButton
            // 
            this.CosoleButton.Location = new System.Drawing.Point(345, 423);
            this.CosoleButton.Name = "CosoleButton";
            this.CosoleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CosoleButton.Size = new System.Drawing.Size(120, 23);
            this.CosoleButton.TabIndex = 9;
            this.CosoleButton.Text = "Вызвать Консоль";
            this.CosoleButton.UseVisualStyleBackColor = true;
            this.CosoleButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CosoleButton);
            this.Controls.Add(this.FileType);
            this.Controls.Add(this.FileTypeBlank);
            this.Controls.Add(this.FilePatchTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.FileNameBlanck);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label FileType;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox FilePatchTextBox;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button GoButton;
        public System.Windows.Forms.Label FileNameBlanck;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label FileTypeBlank;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CosoleButton;
    }
}

