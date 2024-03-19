using System.IO;
using System.Text;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;

namespace CazamioNewProject.GuiHelpers
{
    public class ForceCloseDriver
    {
        [Test]
        public static void ForceClose()
        {
            ForceCloseDriver.ForeseClose();
        }

        public static string CreateBatFile()
        {
            string path = Browser.RootPathReport() + "_!CloseOpenWith.bat";
            string forceCloseAppList = string.Format("echo off" +
                "TASKKILL /F /IM \"OpenWith.exe\"\r\n" +
                "TASKKILL /F /IM \"chromedriver.exe\"\r\n" +
                "TASKKILL /F /IM \"java.exe\"\r\n" +
                "TASKKILL /F /IM \"node.exe\"\r\n" +
                "TASKKILL /F /IM \"AppleMobileDeviceService.exe\"\r\n" +
                "TASKKILL /F /IM \"APSDaemon.exe\"\r\n" +
                "TASKKILL /F /IM \"ICloudServices.exe\"\r\n" +
                "TASKKILL /F /IM \"mDNSResponder.exe\"\r\n" +
                "TASKKILL /F /IM \"altserver.exe\"\r\n" +
                "TASKKILL /F /IM \"Screencast-O-Matic.exe\"" +
                "pause"
                );
            FileInfo fileInf = new(path);
            if (fileInf.Exists == true)
            {
                fileInf.Delete();
            }
            using StreamWriter writer = new(path, false, Encoding.UTF8);
            writer.Write(forceCloseAppList);

            return path;
        }

        public static void RemoveBatFile(string path)
        {
            FileInfo fileInf = new(path);
            if (fileInf.Exists == true)
            {
                fileInf.Delete();
            }
        }

        public static void ForeseClose()
        {
            string path = CreateBatFile();
            Process process = new();
            process.StartInfo.FileName = path;
            process.Start();
            process.Close();
            Thread.Sleep(1000);
            RemoveBatFile(path);
        }
    }
}
