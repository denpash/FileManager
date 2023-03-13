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
    class LoadAllFilesAndDirs_Class
    {
        public void LoadThemALL(Form1 frm)
        {

            DirectoryInfo FileList;
            string TempFilePath = "";
            FileAttributes FileAttr;
            // Process.Start(new ProcessStartInfo("D:/1.txt") { UseShellExecute = true });
            try
            {

                if (frm.IsFile == true)
                {
                    TempFilePath = frm.FilePath + "/" + frm.CurentlySelectItemName;

                    FileInfo FileDetails = new FileInfo(TempFilePath);
                    frm.FileNameBlanck.Text = FileDetails.Name;
                    frm.FileTypeBlank.Text = FileDetails.Extension;
                    FileAttr = File.GetAttributes(TempFilePath);
                    Process.Start(new ProcessStartInfo(TempFilePath) { UseShellExecute = true });
                    //CurentlySelectItemName = "";
                }
                else
                {

                    FileAttr = File.GetAttributes(frm.FilePath);
                }
                if ((FileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    FileList = new DirectoryInfo(frm.FilePath);

                    FileInfo[] files = FileList.GetFiles();
                    DirectoryInfo[] dirs = FileList.GetDirectories();
                    frm.listView1.Items.Clear();
                    String FileExtension = "";
                    int IconIndex = 0;
                    for (int i = 0; i < files.Length; i++)
                    {
                        FileExtension = files[i].Extension.ToUpper();
                        switch (FileExtension)
                        {
                            case ".TXT":
                                IconIndex = 1;
                                break;
                            case ".INI":
                                IconIndex = 2;
                                break;
                            case ".EXE":
                                IconIndex = 3;
                                break;
                            case ".PNG":
                                IconIndex = 4;
                                break;
                            case ".JPG":
                                IconIndex = 5;
                                break;
                            case ".GIF":
                                IconIndex = 6;
                                break;
                            case ".MP3":
                                IconIndex = 7;
                                break;
                            case ".MP4":
                                IconIndex = 8;
                                break;
                            case ".PDF":
                                IconIndex = 9;
                                break;
                            case ".ZIP":
                                IconIndex = 10;
                                break;
                            default:
                                IconIndex = 11;
                                break;

                        }
                        frm.listView1.Items.Add(files[i].Name, IconIndex);

                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {


                        frm.listView1.Items.Add(dirs[i].Name, 0);

                    }
                }
                else
                {
                    frm.FileNameBlanck.Text = frm.CurentlySelectItemName;

                }
            }

            catch (Exception e)
            {


            }


        }
    }
}
