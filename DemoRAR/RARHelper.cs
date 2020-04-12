﻿using Microsoft.Win32;
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
        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="sourceFolder">压缩文件的文件夹目录</param>
        /// <param name="rarFolder">压缩文件目录</param>
        /// <param name="rarName">压缩文件名</param>
        /// <returns></returns>
        public static bool RAR(string sourceFolder, string rarFolder, string rarName)
        {
            bool flag = false;
            string winRARexePath;    //WinRAR.exe 的完整路径  
            RegistryKey regKey; //注册表键  
            Object regValue;   //键值  
            string cmd;     //WinRAR 命令参数  
            ProcessStartInfo startinfo;
            Process process;
            try
            {
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe");
                regValue = regKey.GetValue(""); // 键值为 "d:\Program Files\WinRAR\WinRAR.exe" "%1"  
                winRARexePath = regValue.ToString();
                regKey.Close();
                //rarexe = rarexe.Substring(1, rarexe.Length - 7); // d:\Program Files\WinRAR\WinRAR.exe  
                Directory.CreateDirectory(rarFolder);
                //压缩命令，相当于在要压缩的文件夹(path)上点右键 ->WinRAR->添加到压缩文件->输入压缩文件名(rarName)  
                cmd = string.Format("a {0} {1} -r -ep1",  rarName, sourceFolder);
                startinfo = new ProcessStartInfo();
                if (!File.Exists(winRARexePath)) winRARexePath = Application.StartupPath + "\\res\\WinRAR.exe";
                startinfo.FileName = winRARexePath;
                startinfo.Arguments = cmd; //设置命令参数  
                startinfo.WindowStyle = ProcessWindowStyle.Hidden; //隐藏 WinRAR 窗口  
                startinfo.WorkingDirectory = rarFolder;
                process = new Process();
                process.StartInfo = startinfo;
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
        /// 利用 WinRAR 进行解压缩  
        /// </summary>  
        /// <param name="fileFolder">文件解压路径（绝对）</param>  
        /// <param name="rarFolder">将要解压缩的 .rar 文件的存放目录（绝对路径）</param>
        /// <returns>true 或 false。解压缩成功返回 true，反之，false。</returns>
        public static bool UnRAR(string fileFolder, string rarFolder,string rarName)
        {
            bool flag = false;
            string rarexePath;
            RegistryKey regKey;
            Object regValue;
            string rarCmd;
            ProcessStartInfo startinfo;
            Process process;
            try
            {
                regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe");
                regValue = regKey.GetValue("");
                rarexePath = regValue.ToString();
                regKey.Close();
                Directory.CreateDirectory(fileFolder);
                //解压缩命令，相当于在要压缩文件(rarName)上点右键 ->WinRAR->解压到当前文件夹  -y表示如果存在相同文件则覆盖
                rarCmd = string.Format("x {0} {1} -y", rarFolder + "\\" +rarName, fileFolder);
                startinfo = new ProcessStartInfo();
                if (!File.Exists(rarexePath)) rarexePath = Application.StartupPath + "\\res\\WinRAR.exe";
                startinfo.FileName = rarexePath;
                startinfo.Arguments = rarCmd;
                startinfo.WindowStyle = ProcessWindowStyle.Hidden;
                startinfo.WorkingDirectory = rarFolder;
                process = new Process();
                process.StartInfo = startinfo;
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
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="rarPath"></param>
        /// <param name="rarName"></param>
        /// <returns></returns>
        public static Process UnRARAsync(string path, string rarPath, string rarName)
        {
            string rarexe;
            RegistryKey regkey;
            Object regvalue;
            string cmd;
            ProcessStartInfo startinfo;
            Process process;
            try
            {
                regkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe");
                regvalue = regkey.GetValue("");
                rarexe = regvalue.ToString();
                regkey.Close();
            }
            catch
            {
                //throw e;
                rarexe = Application.StartupPath + "\\WinRAR.exe";
            }
            Directory.CreateDirectory(path);
            //解压缩命令，相当于在要压缩文件(rarName)上点右键 ->WinRAR->解压到当前文件夹  
            cmd = string.Format(" x {0} {1} -y", rarName, '"' + path + '"');
            startinfo = new ProcessStartInfo();
            if (!File.Exists(rarexe)) rarexe = Application.StartupPath + "\\res\\WinRAR.exe";
            startinfo.FileName = rarexe;
            startinfo.Arguments = cmd;
            startinfo.WindowStyle = ProcessWindowStyle.Hidden;
            startinfo.WorkingDirectory = rarPath;
            startinfo.UseShellExecute = true;
            process = new Process();
            process.StartInfo = startinfo;
            process.Start();
            return process;
        }
    }
}
