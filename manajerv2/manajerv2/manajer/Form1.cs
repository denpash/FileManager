using System;
using System.Runtime.InteropServices;
//using System.Threading.Tasks;
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
    public partial class Form1 : Form
    {
        public string FilePath = "D:/";
        public bool IsFile = false;
        public string CurentlySelectItemName = "";
        public bool copyring = false;
        public string patchcopy = "";
        public string copyringfname = "";
        public bool copiedisfile = false;
        public Form1()
        {
            InitializeComponent();
            FilePatchTextBox.Text = FilePath;
            LoadAllFilesAndDirrs();
          


            ToolStripMenuItem delete = new ToolStripMenuItem("Удалить");
            ToolStripMenuItem fileinfo = new ToolStripMenuItem("информация");
            ToolStripMenuItem copy = new ToolStripMenuItem("Копировать");
            ToolStripMenuItem cut = new ToolStripMenuItem("Вырезать");
            ToolStripMenuItem archivate = new ToolStripMenuItem("Архивировать");
            ToolStripMenuItem rename = new ToolStripMenuItem("Переименовать");
            ToolStripMenuItem paste = new ToolStripMenuItem("Вставить");
            ToolStripMenuItem create = new ToolStripMenuItem("Создать");

            contextMenuStrip1.Items.AddRange(new[] { delete, fileinfo, copy, cut, archivate, rename, paste,create });
            listView1.ContextMenuStrip = contextMenuStrip1;


            delete.Click += Delete_click;
            copy.Click += Copy_click;
            fileinfo.Click += FileInfo_Click;
            paste.Click += Paste_click;
            rename.Click += Rename_Click;
            cut.Click += Cut_Click;
            archivate.Click += Archivate_Click;
            create.Click += Create_Click;
           
        }
        private void FileInfo_Click(object sender, EventArgs e)
        {
           string TempFilePath = FilePath + "/" + CurentlySelectItemName;
            InfoForm frm213 = new InfoForm();
            if (IsFile == true)
            {
                FileInfo FileDetails = new FileInfo(TempFilePath);
            long sz = FileDetails.Length;
            
            frm213.label5.Text = CurentlySelectItemName;
            frm213.label6.Text = sz.ToString();
            frm213.label7.Text = File.GetCreationTime(TempFilePath).ToString();
            frm213.label8.Text = File.GetLastWriteTime(TempFilePath).ToString();
           
            }
            else {
                // float foldsz = 0.0f;
                float catsz = 0.0f;
                DirectoryInfo dr = new DirectoryInfo(TempFilePath);
                DirectoryInfo[] da = dr.GetDirectories();
                FileInfo[] fi = dr.GetFiles();
                foreach (FileInfo f in fi)
                catsz = catsz + f.Length;
                frm213.label5.Text = CurentlySelectItemName;
                frm213.label6.Text = catsz.ToString();
                frm213.label7.Text = Directory.GetCreationTime(TempFilePath).ToString();
                frm213.label8.Text = Directory.GetLastWriteTime(TempFilePath).ToString();
              
            }
        frm213.ShowDialog();
        }
        private void Console()
        {
           
            AllocConsole();
            System.Console.Clear();
            System.Console.WriteLine("cписок команд:");
            System.Console.WriteLine("Del:путь");
            System.Console.WriteLine("Create:путь");
            System.Console.WriteLine("Open:путь");
            System.Console.WriteLine("Copy:путь");
            System.Console.WriteLine("Cut:путь");
            System.Console.WriteLine("Paste:путь");
            System.Console.WriteLine("Archivate:путь");
            System.Console.WriteLine("Rename:путь");
            System.Console.WriteLine("");
            System.Console.WriteLine("Пожалуйста, Введите вашу команду:");

            string a = System.Console.ReadLine();
            /*
            cписок команд:
            Del:путь
            Create:путь
            Open:путь
            Copy:путь
            Cut:путь
            Paste:путь
            Archivate:путь
            Rename:путь
             */
            try
            {
                string substr1 = a.Substring(0, a.IndexOf(":"));
                string substr2 = a.Substring(a.IndexOf(":") + 1);
         
                // System.Console.WriteLine(substr1);
                //System.Console.WriteLine(substr2);
                switch (substr1)
                {
                    
                    case "Del":
                        FileAttributes fileAtrr = File.GetAttributes(substr2);
                        if ((fileAtrr & FileAttributes.Directory) == FileAttributes.Directory)
                        {

                            IsFile = false;
                            FilePatchTextBox.Text = FilePath + "/" + CurentlySelectItemName;
                        }
                        else
                        {
                            IsFile = true;
                        }
                       // FreeConsole();
                        CurentlySelectItemName = substr2.Substring(substr2.LastIndexOf("/"));
                        Delete_Class obj = new Delete_Class();
                        obj.Deleting(substr2, IsFile, FilePatchTextBox.Text, this);

                        IsFile = false;
                        LoadAllFilesAndDirrs();
                        IsFile = false;

                        break;
                    case "Create":
                        /* System.Console.WriteLine("Хорошо, теперь Выберите тип создаваемого файла (fold - папка, file - файл):");
                         string b = System.Console.ReadLine();

                         if (b == "fold")
                         {
                             Directory.CreateDirectory(substr2);
                         }
                         else if (b == "file")
                         {
                             File.Create(substr2);
                         }
                         FreeConsole();
                         IsFile = false;
                         LoadAllFilesAndDirrs();
                         IsFile = false;

                         */
                        FilePath = substr2.Substring(0, substr2.LastIndexOf("/"));
                        CreateForm frm = new CreateForm();
                        frm.Owner = this;
                        frm.path = FilePath;
                        frm.ShowDialog();

                        break;
                    case "Open":
                        FilePath = substr2.Substring(0, substr2.LastIndexOf("/"));
                        CurentlySelectItemName = substr2.Substring(substr2.LastIndexOf("/"));
                        FileAttributes fileAtrr2 = File.GetAttributes(substr2);
                        if ((fileAtrr2 & FileAttributes.Directory) == FileAttributes.Directory)
                        {

                            IsFile = false;
                            FilePatchTextBox.Text = FilePath + "/" + CurentlySelectItemName;
                        }
                        else
                        {
                            IsFile = true;
                        }
                        LoadAllFilesAndDirs_Class obj1 = new LoadAllFilesAndDirs_Class();
                        obj1.LoadThemALL(this);
                        break;
                    case "Copy":

                        FilePath = substr2.Substring(0, substr2.LastIndexOf("/"));
                        CurentlySelectItemName = substr2.Substring(substr2.LastIndexOf("/"));
                        FileAttributes fileAtrr3 = File.GetAttributes(substr2);
                        if ((fileAtrr3 & FileAttributes.Directory) == FileAttributes.Directory)
                        {

                            IsFile = false;
                            FilePatchTextBox.Text = FilePath + "/" + CurentlySelectItemName;
                        }
                        else
                        {
                            IsFile = true;
                        }
                        Copy_class obj2 = new Copy_class();
                        obj2.Copyring(fileAtrr3, FilePath, CurentlySelectItemName, this);
                        break;

                    case "Cut":
                        FilePath = substr2.Substring(0, substr2.LastIndexOf("/"));
                        CurentlySelectItemName = substr2.Substring(substr2.LastIndexOf("/"));
                        FileAttributes fileAtrr4 = File.GetAttributes(substr2);
                        if ((fileAtrr4 & FileAttributes.Directory) == FileAttributes.Directory)
                        {

                            IsFile = false;
                            FilePatchTextBox.Text = FilePath + "/" + CurentlySelectItemName;
                        }
                        else
                        {
                            IsFile = true;
                        }

                        Cut_Class obj3 = new Cut_Class();
                        obj3.Cuttyng(this);
                        break;
                    case "Paste":

                        FilePath = substr2.Substring(0, substr2.LastIndexOf("/"));
                        CurentlySelectItemName = substr2.Substring(substr2.LastIndexOf("/"));
                        FileAttributes fileAtrr5 = File.GetAttributes(substr2);
                        if ((fileAtrr5 & FileAttributes.Directory) == FileAttributes.Directory)
                        {

                            IsFile = false;
                            FilePatchTextBox.Text = FilePath + "/" + CurentlySelectItemName;
                        }
                        else
                        {
                            IsFile = true;
                        }



                        Paste_Class obj4 = new Paste_Class();
                        obj4.Pasting(this, patchcopy, FilePath, copyringfname);
                        break;
                    case "Archivate":
                        FilePath = substr2.Substring(0, substr2.LastIndexOf("/"));
                        CurentlySelectItemName = substr2.Substring(substr2.LastIndexOf("/"));
                        FileAttributes fileAtrr6 = File.GetAttributes(substr2);
                        if ((fileAtrr6 & FileAttributes.Directory) == FileAttributes.Directory)
                        {

                            IsFile = false;
                            FilePatchTextBox.Text = FilePath + "/" + CurentlySelectItemName;
                        }
                        else
                        {
                            IsFile = true;

                        }

                        Archivate_Class obj5 = new Archivate_Class();
                        obj5.Archivating(this);


                        break;
                    case "Rename":

                        FilePath = substr2.Substring(0, substr2.LastIndexOf("/"));
                        CurentlySelectItemName = substr2.Substring(substr2.LastIndexOf("/") + 1);
                        FileAttributes fileAtrr7 = File.GetAttributes(substr2);
                        if ((fileAtrr7 & FileAttributes.Directory) == FileAttributes.Directory)
                        {

                            IsFile = false;
                            FilePatchTextBox.Text = FilePath + "/" + CurentlySelectItemName;
                        }
                        else
                        {
                            IsFile = true;

                        }
                        if (CurentlySelectItemName != "")
                        {
                            RenameForm frm213 = new RenameForm();
                            frm213.textBox1.Text = CurentlySelectItemName;
                            frm213.Owner = this;
                            frm213.Path = FilePath;
                            frm213.oldfilepath = FilePath + "/" + CurentlySelectItemName;
                            frm213.ShowDialog();
                        }

                        break;
                }
                System.Console.WriteLine("Конец Команды");
              //  FreeConsole();
            }
            catch (Exception ae) {
                // System.Console.WriteLine("Конец Команды");
                //  FreeConsole();
                MessageBox.Show(

                    //ae.ToString(),           
                    "Неизвестная команда либо команда введена не верно",
                    "Ошибка",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error,
                                               MessageBoxDefaultButton.Button1,
                                               MessageBoxOptions.DefaultDesktopOnly);


            }
        }




        private void LoadButtonAction()
        
        {

            FilePath = FilePatchTextBox.Text;
            //IsFile = false;
            // CurentlySelectItemName = "";
            LoadAllFilesAndDirrs();
            IsFile = false;





        }
        void Create_Click(object sender, EventArgs e)
        {

            CreateForm frm = new CreateForm();
           //   frm.textBox1.Text = CurentlySelectItemName;
            frm.Owner = this;
            frm.path = FilePath;
            //frm.Path = FilePath;
            // frm.oldfilepath = FilePath + "/" + CurentlySelectItemName;
            frm.ShowDialog();

        }


       void Archivate_Click(object sender, EventArgs e)
        {

            Archivate_Class obj = new Archivate_Class();
            obj.Archivating(this);
           

        }
        void Rename_Click(object sender, EventArgs e) {
            if (CurentlySelectItemName != "")
            {
                RenameForm frm = new RenameForm();
                frm.textBox1.Text = CurentlySelectItemName;
                frm.Owner = this;
                frm.Path = FilePath;
                frm.oldfilepath = FilePath + "/" + CurentlySelectItemName;
                frm.ShowDialog();
            }

        }
        void Delete_click(object sender, EventArgs e) {
            Delete_Class obj = new Delete_Class();
            obj.Deleting(FilePath +"/"+CurentlySelectItemName,IsFile, FilePatchTextBox.Text,this);
        }

        void Copy_click(object sender, EventArgs e) {
            try
            {
                FileAttributes fileAtrr = File.GetAttributes(FilePath + "/" + CurentlySelectItemName);
                Copy_class obj = new Copy_class();
                obj.Copyring(fileAtrr, FilePath, CurentlySelectItemName, this);
            }

            catch (Exception ae) {


                MessageBox.Show(
                                               ae.ToString(),
                                               "Ошибка",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error,
                                               MessageBoxDefaultButton.Button1,
                                               MessageBoxOptions.DefaultDesktopOnly);


            }
           
                
           
        }

        void Cut_Click(object sender, EventArgs e)
        {

            Cut_Class obj = new Cut_Class();
            obj.Cuttyng(this);
          

        }

            void Paste_click(object sender, EventArgs e)
        {

             

            
            Paste_Class obj = new Paste_Class();
            obj.Pasting(this, patchcopy,FilePath,copyringfname);
            
        }
        
        public void LoadAllFilesAndDirrs()
        {
            LoadAllFilesAndDirs_Class obj = new LoadAllFilesAndDirs_Class();
            obj.LoadThemALL(this);
        }
        private void Goback()
        {

            string patch = FilePatchTextBox.Text;
            // if (patch.LastIndexOf("/") == patch.Length -1)
            //  {
            try
            {
                FilePatchTextBox.Text = patch.Substring(0, patch.LastIndexOf('/'));
            }
            catch(Exception e) { }

          //  }

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Goback();
            IsFile = false;
            LoadButtonAction();
            IsFile = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            LoadButtonAction();
            
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            CurentlySelectItemName = e.Item.Text;
            FileAttributes fileAtrr = File.GetAttributes(FilePath + "/" + CurentlySelectItemName);
            if ((fileAtrr & FileAttributes.Directory) == FileAttributes.Directory)
            {

                IsFile = false;
                FilePatchTextBox.Text = FilePath + "/" + CurentlySelectItemName;
            }
            else
            {
                IsFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadButtonAction();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                FilePath = comboBox1.SelectedItem.ToString();
            FilePatchTextBox.Text = FilePath;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            for (int i = 0; i < allDrives.Length; i++)
            {
                comboBox1.Items.Add(allDrives[i].Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console();
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

    }



}
