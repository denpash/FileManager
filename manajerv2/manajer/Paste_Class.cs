using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace manajer
{
    class Paste_Class
    {
        public void Pasting(Form1 frm, string patchcopy, string FilePath, string copyringfname)
        {
            if(frm.copyring == true)
            {
                if (frm.copiedisfile == true)
                {
                    try
                    {
                        File.Copy(patchcopy, FilePath + "/" + copyringfname);
                        frm.LoadAllFilesAndDirrs();
                    }
                    catch (Exception ae)
                    {


                        MessageBox.Show(
                            "Ошибка, данный файл или папка уже существуют в данной дериктории",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);

                    }
                  
                }
                else if (frm.copiedisfile == false && frm.IsFile == false)
                {
                    try
                    {
                        //Создать идентичное дерево каталогов
                        foreach (string dirPath in Directory.GetDirectories(patchcopy + "/", "*", SearchOption.AllDirectories))
                            Directory.CreateDirectory(dirPath.Replace(patchcopy, FilePath + "/" + copyringfname));
                        foreach (string newPath in Directory.GetFiles(patchcopy + "/", "*.*", SearchOption.AllDirectories))
                            File.Copy(newPath, newPath.Replace(patchcopy + "/", FilePath + "/" + copyringfname + "/"), true);
                        frm.LoadAllFilesAndDirrs();
                    }
                    //}

                    catch (Exception ee)
                    {
                        MessageBox.Show(
                                               ee.ToString(),
                                               "Ошибка",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error,
                                               MessageBoxDefaultButton.Button1,
                                               MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
            }
            else
            {
                if (frm.copiedisfile == true)
                {
                    try
                    {
                        File.Move(frm.patchcopy, frm.FilePath + "/" + frm.copyringfname);
                        frm.LoadAllFilesAndDirrs();
                        frm.patchcopy = "";
                        frm.copyringfname = "";
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(
                                               ee.ToString(),
                                               "Ошибка",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error,
                                               MessageBoxDefaultButton.Button1,
                                               MessageBoxOptions.DefaultDesktopOnly);
                    }


                }

                else if (frm.copiedisfile == false && frm.IsFile == false)
                {
                    try
                    {
                        Directory.Move(frm.patchcopy, frm.FilePath + "/" + frm.copyringfname);
                        frm.LoadAllFilesAndDirrs();
                        frm.patchcopy = "";
                        frm.copyringfname = "";
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(
                                               ee.ToString(),
                                               "Ошибка",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error,
                                               MessageBoxDefaultButton.Button1,
                                               MessageBoxOptions.DefaultDesktopOnly);
                    }
                }

            }
        }
       



    }
}
