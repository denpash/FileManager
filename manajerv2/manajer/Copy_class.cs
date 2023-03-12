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
    class Copy_class
    {
        public void Copyring(FileAttributes fileAtrr,string FilePath,string CurentlySelectItemName, Form1 frm)
        {
            string a = "";
            if ((fileAtrr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                frm.copiedisfile = false;
                frm.patchcopy = frm.FilePatchTextBox.Text;
                frm.copyringfname = CurentlySelectItemName;
                frm.copyring = true;


            }
            else {
                frm.copiedisfile = true;
                frm.patchcopy = FilePath + "/" + CurentlySelectItemName;
                frm.copyringfname = CurentlySelectItemName;
                frm.copyring = true;

            }
            
           // frm.LoadAllFilesAndDirrs();
           // a = "11";
        }
    }
}
