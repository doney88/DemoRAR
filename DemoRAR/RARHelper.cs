using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DemoRAR
{
    public class RARHelper
    {
        static string WinRARRegeditPath= @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe";
        #region 私有方法
        /// <summary>
        /// 获取WinRAR应用程序路径，如果注册表中没有则返回当前目录下\res\WinRAR.exe
        /// </summary>
        /// <returns>返回注册表中指定的RAR应用程序路径，没有则返回当前目录下\res\WinRAR.exe</returns>
        private string GetExePath()
        {
            RegistryKey the_Reg = Registry.LocalMachine.OpenSubKey(WinRARRegeditPath);//访问储存应用程序注册表信息键值
            string exePath = the_Reg.GetValue("").ToString();//查询WINRAR注册表储存路径
            the_Reg.Close();
            if (string.IsNullOrEmpty(exePath))    //如果存在则表示应用程序存在于本计算机中
                exePath = Application.StartupPath + "\\res\\WinRAR.exe";
            return exePath;
        }
        /// <summary>
        /// 创建控制WinRAR的Process类，并设置好ProcessStartInfo属性
        /// </summary>
        /// <param name="workDirectory">压缩包的路径</param>
        /// <param name="rarCmd">命令符</param>
        /// <param name="exePath"></param>
        /// <returns></returns>
        private Process CreateRARProcess(string workDirectory, string rarCmd, string exePath,bool useShellExecute = false)
        {
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = exePath; //应用程序路径
            startinfo.Arguments = rarCmd; //设置命令参数  
            startinfo.WindowStyle = ProcessWindowStyle.Hidden; //隐藏 WinRAR 窗口  
            startinfo.WorkingDirectory = workDirectory;
            startinfo.UseShellExecute = useShellExecute;
            Process process = new Process();
            process.StartInfo = startinfo;
            return process;
        }

        #endregion

        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="sourceFolder">压缩文件的文件夹目录</param>
        /// <param name="rarFolder">压缩文件目录</param>
        /// <param name="rarName">压缩文件名</param>
        /// <returns></returns>
        public bool RAR(string sourceFolder, string rarFolder, string rarName)
        {
            string rarCmd;     //WinRAR 命令参数  
            bool flag = false ;
            Process process;
            try
            {
                string exePath = GetExePath();
                Directory.CreateDirectory(rarFolder);
                //压缩命令，相当于在要压缩的文件夹(path)上点右键 ->WinRAR->添加到压缩文件->输入压缩文件名(rarName)  
                rarCmd = string.Format("a {0} {1} -r -ep1", rarName, sourceFolder); //a 表示压缩 -r 表示囊括子文件夹 -ep1表示不要囊括父文件夹
                process = CreateRARProcess(rarFolder, rarCmd, exePath);
                process.Start();
                process.WaitForExit(); //无限期等待进程 winrar.exe 退出  
                if (process.HasExited)
                {
                    flag = true;
                }
                process.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return flag;
        }
        /// <summary>
        /// 解压缩
        /// </summary>
        /// <param name="fileFolder">解压后文件存放路径</param>
        /// <param name="rarFolder">RAR压缩包存放路径</param>
        /// <param name="rarName">RAR压缩包名字</param>
        /// <returns></returns>
        public bool UnRAR(string fileFolder, string rarFolder,string rarName)
        {
            bool flag = false;
            string rarCmd;
            Process process;
            try
            {
                string exePath = GetExePath();
                Directory.CreateDirectory(fileFolder);
                //解压缩命令，相当于在要压缩文件(rarName)上点右键 ->WinRAR->解压到当前文件夹  -y表示如果存在相同文件则覆盖
                rarCmd = string.Format("x {0} {1} -y", rarFolder + "\\" + rarName, fileFolder);
                process = CreateRARProcess(rarFolder, rarCmd, exePath);
                process.Start();
                process.WaitForExit();
                if (process.HasExited)
                {
                    flag = true;
                }
                process.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return flag;
        }
        /// <summary>
        /// 异步解压缩
        /// </summary>
        /// <param name="fileFolder">解压后文件存放路径</param>
        /// <param name="rarFolder">RAR压缩包存放路径</param>
        /// <param name="rarName">RAR压缩包名字</param>
        /// <returns></returns>
        public Process UnRARAsync(string fileFolder, string rarFolder, string rarName)
        {
            string rarCmd;
            Process process;
            try
            {
                string exePath = GetExePath();
                Directory.CreateDirectory(fileFolder);
                //解压缩命令，相当于在要压缩文件(rarName)上点右键 ->WinRAR->解压到当前文件夹  
                rarCmd = string.Format(" x {0} {1} -y", rarFolder + "\\" + rarName, fileFolder);
                process = CreateRARProcess(rarFolder, rarCmd, exePath,true);
                process.Start();
                return process;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
