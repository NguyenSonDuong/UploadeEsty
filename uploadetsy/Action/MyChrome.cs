using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using uploadetsy.MyForm;

namespace uploadetsy.Action
{
    class MyChrome
    {
        private ChromeDriver _chromeDriver = null;
        private ChromeOptions _options = null;
        private ChromeDriverService _driverService = null;

        #region Close All Chorme
        public void CloseAllChrome()
        {
            try
            {
                var xx = Process.GetProcesses();
                //chromedriver
                var x = Process.GetProcessesByName("GoogleChromePortable");
                foreach (var item in x)
                {
                    item.Kill();
                }

                x = Process.GetProcessesByName("chromedriver");
                foreach (var item in x)
                {
                    item.Kill();
                }

                x = Process.GetProcessesByName("chrome");
                foreach (var item in x)
                {
                    item.Kill();
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region Creat Chrome
        public ChromeDriver CreatChrome(String pathChromeExe, String pathProfile, Thread thread, FormMain main)
        {
            try
            {
                if (_driverService == null)
                {
                    // Creat
                    _driverService = ChromeDriverService.CreateDefaultService();
                    // Hiden Comamd
                    _driverService.HideCommandPromptWindow = true;
                    _driverService.SuppressInitialDiagnosticInformation = true;
                }
                try
                {
                    if (_options == null)
                    {

                        int port = new Random().Next(1000, 9999);
                        // Creat Options
                        _options = new ChromeOptions();
                        _options.BinaryLocation = pathChromeExe;

                        // tach Link profile va set Profile
                        String path = pathProfile;
                        int index = path.LastIndexOf(@"\");
                        string prifile = path.Remove(0, index + 1);
                        // path = path.Remove(index);

                        // Add Data
                        _options.AddArgument($"user-data-dir={path}");
                        _options.AddArgument($"--profile-directory=Default");
                        // Hiden head info
                        _options.AddArgument("disable-infobars");
                        _options.AddArgument("--silent");

                        //  _options.AddArgument("--no-sandbox");
                        // _options.AddArgument("--disable-dev-shm-usage");
                        // _options.AddArgument("--disable-setuid-sandbox");

                        _options.AddArgument($"--remote-debugging-port={port}");

                       // _options.AddArgument("--disable-dev-shm-using");
                       // _options.AddArgument("--disable-extensions");
                       // _options.AddArgument("--disable-gpu");
                      //  _options.AddArgument("start-maximized");

                    }
                }
                catch (Exception)
                {
                    _options = new ChromeOptions();
                    _options.AddArgument("disable-infobars");
                    _options.AddArgument("--silent");
                }

                if (_chromeDriver == null)
                {
                    _chromeDriver = new ChromeDriver(_driverService, _options);
                }
                return _chromeDriver;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //  FormMess.Show("Error", "Lỗi mở Chrome", false);
                main.WriteTitleAtion("Stop", Color.Red);
                thread.Abort();
                return null;
            }

        }
        #endregion
    }
}
