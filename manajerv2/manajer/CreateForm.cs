using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace manajer
{
    public partial class CreateForm : Form
    {
        public string path = "";
        public CreateForm()
        {
            InitializeComponent();
        }

     
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 frm = this.Owner as Form1;
            try
            {
                if (textBox1.Text != "")
                {
                    if (radioButton1.Checked)
                    {

                        using (FileStream fs = File.Create(path + "/" + textBox1.Text)) ;
                       
                        frm.IsFile = false;
                        frm.LoadAllFilesAndDirrs();
                        frm.IsFile = false;
                        Close();
                    }
                    else if (radioButton2.Checked)
                    {
                        Directory.CreateDirectory(path + "/" + textBox1.Text);
                        frm.IsFile = false;
                        frm.LoadAllFilesAndDirrs();
                        frm.IsFile = false;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(
                                   "Ошибка, Вы не выбрали тип создаваемого файла",
                                   "Ошибка",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error,
                                   MessageBoxDefaultButton.Button1,
                                   MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
                else
                {
                    MessageBox.Show(
                                               "Ошибка, имя файла не может быть пустым",
                                               "Ошибка",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error,
                                               MessageBoxDefaultButton.Button1,
                                               MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch(Exception ae)
            {

                MessageBox.Show(
                                             ae.ToString(),
                                             "Ошибка",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error,
                                             MessageBoxDefaultButton.Button1,
                                             MessageBoxOptions.DefaultDesktopOnly);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
