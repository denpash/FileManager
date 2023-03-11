
namespace manajer
{
    partial class RenameForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.renamebutton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // renamebutton
            // 
            this.renamebutton.Location = new System.Drawing.Point(12, 64);
            this.renamebutton.Name = "renamebutton";
            this.renamebutton.Size = new System.Drawing.Size(75, 23);
            this.renamebutton.TabIndex = 1;
            this.renamebutton.Text = "Ок";
            this.renamebutton.UseVisualStyleBackColor = true;
            this.renamebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(242, 64);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 99);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.renamebutton);
            this.Controls.Add(this.textBox1);
            this.Name = "RenameForm";
            this.Text = "RenameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button renamebutton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox textBox1;
    }
}