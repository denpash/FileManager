using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace manajer
{
    public partial class RenameForm : Form
    {
        public string Path = "";
        public string oldfilepath = "";
        public RenameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Form1 frm = this.Owner as Form1;
            if (frm.IsFile == true)
            {
                File.Move(oldfilepath, Path + "/" +textBox1.Text);
            
                frm.IsFile = false;
                frm.LoadAllFilesAndDirrs();
                frm.IsFile = false;
                frm.CurentlySelectItemName = "";
            }
            else {
                Directory.Move(oldfilepath, Path + textBox1.Text);
                frm.LoadAllFilesAndDirrs();
                frm.CurentlySelectItemName = "";

            }

             Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
