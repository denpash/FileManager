using System;
using System.Collections.Generic;
using System.Text;

namespace manajer
{
    class Cut_Class
    {

        public void Cuttyng(Form1 frm)
        {

            frm.patchcopy = frm.FilePath + "/" + frm.CurentlySelectItemName;
            frm.copyringfname = frm.CurentlySelectItemName;
            frm.copyring = false;

        }
    }
}
