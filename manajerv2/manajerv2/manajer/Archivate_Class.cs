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
    class Archivate_Class
    {
        public void Archivating(Form1 frm)
        {
            if (frm.IsFile == false)
            {

                Directory.CreateDirectory(frm.FilePath + "/Новый архив/" + frm.CurentlySelectItemName + "/");
                foreach (string dirPath in Directory.GetDirectories(frm.FilePath + "/" + frm.CurentlySelectItemName + "/", "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(frm.FilePath + "/" + frm.CurentlySelectItemName + "/", frm.FilePath + "/Новый архив/" + frm.CurentlySelectItemName + "/"));
                foreach (string newPath in Directory.GetFiles(frm.FilePath + "/" + frm.CurentlySelectItemName + "/", "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(frm.FilePath + "/" + frm.CurentlySelectItemName + "/", frm.FilePath + "/Новый архив/" + frm.CurentlySelectItemName + "/"), true);



                string dpath = frm.FilePath + "/Новый архив/";
                ZipFile.CreateFromDirectory(dpath, frm.FilePath + "/Новый архив.zip");
                // Directory.Delete(FilePath + "/" + CurentlySelectItemName, true);
                Directory.Delete(dpath, true);
                frm.LoadAllFilesAndDirrs();

            }
            else
            {
               
                string dpath = frm.FilePath + "/Новый архив/";
                Directory.CreateDirectory(dpath);
                File.Copy(frm.FilePath + "/" + frm.CurentlySelectItemName, dpath + "/" + frm.CurentlySelectItemName);
                ZipFile.CreateFromDirectory(dpath, frm.FilePath + "/Новый архив.zip");
                Directory.Delete(dpath, true);
                frm.IsFile = false;
                frm.LoadAllFilesAndDirrs();
                frm.IsFile = false;
            }






        }
    }
}
