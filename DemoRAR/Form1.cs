using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoRAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnRAR_Click(object sender, EventArgs e)
        {

            if (Exists())
            {
                RARHelper.UnRAR(txtFileFolder.Text, this.txtRARFolder.Text,txtRARName.Text);
            }
        }
        /// <summary>
        /// 是否安装了Winrar
        /// </summary>
        /// <returns></returns>
        static public bool Exists()
        {
            RegistryKey the_Reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe");//访问储存应用程序注册表信息键值
            string winRarPath = the_Reg.GetValue("").ToString();//查询WINRAR注册表储存路径
            return !string.IsNullOrEmpty(winRarPath);//如果存在则表示应用程序存在于本计算机中
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRAR_Click(object sender, EventArgs e)
        {
            RARHelper.RAR(txtFileFolder.Text, txtRARFolder.Text, txtRARName.Text);
        }
    }


}
