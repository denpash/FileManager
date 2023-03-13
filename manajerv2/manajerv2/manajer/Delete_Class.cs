using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace manajer
{
    class Delete_Class
    {

        public void Deleting(string TempFilePath,bool IsFile, string patch, Form1 frm)
        {
           // string TempFilePath = "";

            //TempFilePath = FilePath + "/" + CurentlySelectItemName;

            try
            {
                if (IsFile == true)
                {
                    File.Delete(TempFilePath);
                    frm.CurentlySelectItemName = "";
                    frm.IsFile = false;
                    frm.LoadAllFilesAndDirrs();
                    frm.IsFile = false;
                }
                else
                {
                  //  string patch = FilePatchTextBox.Text;
                    // if (patch.LastIndexOf("/") == patch.Length -1)
                    //  {
                    try
                    {

                        Directory.Delete(TempFilePath, true);
                        frm.LoadAllFilesAndDirrs();
                        frm.FilePatchTextBox.Text = patch.Substring(0, patch.LastIndexOf('/'));
                    }
                    catch (Exception ae) { }

                }
            }
            catch (Exception ae) { }



        }
    }
}
