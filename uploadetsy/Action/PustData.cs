using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using uploadetsy.MyForm;
using uploadetsy.MyObj;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;

namespace uploadetsy.Action
{
    class PustData
    {


        #region khoi tao
        private String _Path = "Log";
        private String _Name1 = "ing1";
        private String _Name2 = "img2";
        private String _Name3 = "img3";
        private String _Name4 = "img4";
        private String _Name5 = "img5";

        private String _fileSkip = "Log" + @"\Skip.txt";
        private int SK = 1000;


        #endregion

        public delegate void RunDead();
        #region Pust Data
        public void PushData(List<ObjList> _list, FormMain main, ChromeDriver _chromeDriver, Thread thread)
        {
            try
            {
                main.WriteTitleAtion("DashBoard . . .", Color.Black);
                // Go to Dashboard
                _chromeDriver.Navigate().GoToUrl($@"https://www.etsy.com/your/listings");
                Thread.Sleep(5000);

                // main.WriteTitleAtion("Get Url . . .", Color.Black);
                // get base Url 
                String url = "";
                try
                {
                    url = _chromeDriver.Url;
                    //   main.WriteLog(url, Color.Red);
                }
                catch (Exception)
                {
                    //main.WriteLog( "url " + e.ToString(), Color.Red);
                }
                // Read File Skip 
                for (int i = 0; i < _list.Count; i++)
                {
                    main.WriteTitleAtion("Listing . . .", Color.Black);

                    CreatFoder();

                    // String strFile = File.ReadAllText(_fileSkip);
                    //  int indexSkip = strFile.IndexOf(_list[i].ID_Clone);

                    // - 1 thi lam khong bo qua
                    //  if (indexSkip != -1) continue;
                    // MOi Trang Web Cần thanh đôi
                    _chromeDriver.Navigate().GoToUrl($@"{url}/{_list[i].ID_Clone}/copy");


                    // Click Copy
                    //ClickCopy(_chromeDriver);

                    Thread.Sleep(SK);
                    DeleteImgs(main, _chromeDriver);

                    //Dowload Img Cần
                    Thread.Sleep(SK);
                    DowloadImgEndUpload(_list[i].Link1, _Name1, main, _chromeDriver);

                    Thread.Sleep(SK);
                    DowloadImgEndUpload(_list[i].Link2, _Name2, main, _chromeDriver);

                    Thread.Sleep(SK);
                    DowloadImgEndUpload(_list[i].Link3, _Name3, main, _chromeDriver);

                    Thread.Sleep(SK);
                    DowloadImgEndUpload(_list[i].Link4, _Name4, main, _chromeDriver);

                    Thread.Sleep(SK);
                    DowloadImgEndUpload(_list[i].Link5, _Name5, main, _chromeDriver);
                    // Xoa Title

                    // Nhap Title
                    main.WriteTitleAtion("Nhập Title", Color.Black);
                    main.WriteDataInput(_chromeDriver.FindElementById("title"), _list[i].Title);

                    main.WriteTitleAtion("Chọn Section", Color.Black);
                    Section(_list[i].Section, main, _chromeDriver);

                    main.WriteTitleAtion("Xóa Tags", Color.Black);
                    DeletTags(main, _chromeDriver);

                    main.WriteTitleAtion("Nhập Tag", Color.Black);
                    main.WriteDataInput(_chromeDriver.FindElementById("tags"), _list[i].Tag);

                    main.WriteTitleAtion("Click Thêm tag", Color.Black);
                    _chromeDriver.FindElementByClassName("btn-append").Click();

                    main.WriteTitleAtion("Nhập SKU", Color.Black);
                    main.WriteDataInput(_chromeDriver.FindElementById("SKU-input"), _list[i].SKU);

                    main.WriteTitleAtion("Publist . . .", Color.Black);
                    ClickPublic(_chromeDriver);

                    // Write Log
                    main.WriteLog($"Listing thành công: {_list[i].Title}", Color.Green);

                    // ghi la list da thanh cong
                    //  File.WriteAllText(@"Log\Skip.txt", strFile + "\n" + item.ID_Clone);
                    // File.AppendAllText(_fileSkip, "\n" + _list[i].ID_Clone);

                    // het san pham thi thoát
                    if (i >= _list.Count - 1)
                    {
                        break;
                    }
                    main.SleepNextList();
                }

                main.WriteTitleAtion("Hết", Color.Black);
            }
            catch (Exception e)
            {
                main.WriteTitleAtion("Stop", Color.Red);
                Console.WriteLine(e.ToString());
                //  FormMess.Show("Error", "Lỗi Nhập dữ liệu trên trang Web", false);
                thread.Abort();
            }

        }

        // cài thời gian chết cho app
        

        private void Section(String section, FormMain main, ChromeDriver _chromeDriver)
        {
            if (section == null || section == "")
            {
                try
                {
                
                    var element = _chromeDriver.FindElementByXPath($"//select[@id='sections']");
                    SelectElement select = new SelectElement(element);
                    select.SelectByText("None");
                }
                catch (Exception) { }
                return;
            }

            try
            {
                var element = _chromeDriver.FindElementsByXPath($"//select[@id='sections']/optgroup[1]/option");

                foreach (var item in element)
                {
                    if (item.Text.Trim() == section)
                    {

                        item.Click();
                        break;
                    }
                }
                Thread.Sleep(SK);
            }
            catch (Exception e)
            {
                // main.WriteLog(e.ToString(), Color.Red);
            }
        }

        private void ClickCopy(ChromeDriver _chromeDriver)
        {
            try
            {
                _chromeDriver.FindElementByClassName("btn-icon-with-text").Click();
                Thread.Sleep(SK);
                _chromeDriver.FindElementByXPath("//li[@data-action='copy']").Click();
                Thread.Sleep(SK);
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region Click btn Public And Confirm
        private void ClickPublic(ChromeDriver _chromeDriver)
        {
            try
            {
                var btnsubmit = _chromeDriver.FindElementByXPath("//button[@data-publish]");

                btnsubmit.Click();

                Thread.Sleep(5000);

                var btnConfirm = _chromeDriver.FindElementByXPath("//button[@data-ui='confirm']");

                btnConfirm.Click();
                Thread.Sleep(5000);
            }
            catch (Exception) { }
        }
        #endregion  

        #region Delete and Upload Img
        private void DowloadImgEndUpload(String link, String Name, FormMain main, ChromeDriver _chromeDriver)
        {
            if (link == null || link == "") return;
            try
            {
                main.WriteTitleAtion("Đang tải ảnh xuống. . .", Color.Black);
                WebClient web = new WebClient();
                Name += link.Substring(link.LastIndexOf('.'));

                String linkImg = _Path + @"\" + Name;
                web.DownloadFile(link, linkImg);

                main.WriteTitleAtion("Đang tải ảnh Ảnh lên", Color.Black);

                FileInfo fileInfo = new FileInfo(linkImg);

                _chromeDriver.FindElementById("listing-edit-image-upload").SendKeys(fileInfo.FullName);

                bool wb = true;
                while (wb)
                {
                    Thread.Sleep(1000);
                    try
                    {
                        var tem = _chromeDriver.FindElementByClassName("sr-only");
                    }
                    catch (Exception)
                    {
                        //  main.WriteLog($"=>>>>{e.ToString()}", Color.Red);
                        wb = false;
                    }
                }
                Thread.Sleep(SK);
                DeleteFile(linkImg);
            }
            catch (Exception e)
            {
                // main.WriteLog($@"Lỗi Tải anh ==>:{link}", Color.Red);
                // main.WriteLog($@"Lỗi Tải anh ==>:{e.ToString()}", Color.Red);

            }

        }

        private void DeleteImgs(FormMain main, ChromeDriver _chromeDriver)
        {
            try
            {
                main.WriteTitleAtion("Xóa Ảnh", Color.Black);
                int count = 0;
                try
                {
                    count = _chromeDriver.FindElementsByXPath("//button[@title='Delete photo']").Count;
                }
                catch(Exception)
                {
                    return;
                }
                
                while (count > 0)
                {
                    var btnsubmit = _chromeDriver.FindElementsByXPath("//button[@title='Delete photo']");
                    btnsubmit[0].Click();
                    Thread.Sleep(SK);
                    count = _chromeDriver.FindElementsByXPath("//button[@title='Delete photo']").Count;
                }
            }
            catch (Exception e)
            {
                // main.WriteLog(e.ToString(), Color.Red);
            }

        }
        #endregion

        #region Delete All Tag
        private void DeletTags(FormMain main, ChromeDriver _chromeDriver)
        {
            try
            {
                var limit = _chromeDriver.FindElementById("tags-limit");
                // main.WriteLog("=>> limit = " + limit.ToString(), Color.Red);
                limit.Text.Trim();
                if ("All 13 used" == limit.Text.Trim())
                {
                    IJavaScriptExecutor js = (IJavaScriptExecutor)_chromeDriver;
                    js.ExecuteScript($"for(var i =0 ; i <= 12 ; i++ ) document.getElementsByClassName('btn-prepend')[0].click();");
                }
                else
                {
                    String rs = limit.Text.Trim().Replace("left", "").Replace("to go!", "").Trim();
                    int kq = 13 - int.Parse(rs);
                    IJavaScriptExecutor js = (IJavaScriptExecutor)_chromeDriver;

                    js.ExecuteScript($"for(var i =0 ; i < {kq} ; i++ ) document.getElementsByClassName('btn-prepend')[0].click();");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                // main.WriteLog(e.ToString(), Color.Red);
            }

        }
        #endregion

        private void CreatFoder()
        {
            Directory.CreateDirectory(_Path);
            File.AppendAllText(_fileSkip, "");
        }

        private void DeleteFile(String path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception) { }
        }
    }
}
