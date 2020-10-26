using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using uploadetsy.Action;
using uploadetsy.MyObj;

namespace uploadetsy.MyForm
{
    public partial class FormMain : Form
    {
        #region Khoi tao
        private ChromeDriver _chromeDriver = null;

        private Thread _threadStart = null;
        private List<ObjList> _list = null;
        private int _SleepKeyChar = 100;
        private int _SleepNextInput = 5000;
        private String[] arrCache = new String[3];

        #endregion

        public FormMain()
        {
            InitializeComponent();

            // Doc file ra
            try
            {
                arrCache = File.ReadLines(@"Log\cache.txt").ToArray();
            }
            catch (Exception) { }


            txtLinkExcel.Text = arrCache[0];
            txtProfile.Text = arrCache[1];
            txtPathChromeExe.Text = arrCache[2];

        }

        #region btn Minimize form
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region btn Close form
        private void btnClose_Click(object sender, EventArgs e)
        {
            if ("Yes" == FormConfirm.Show("Close", "Do you want to close"))
            {
                this.Close();
            }
        }
        #endregion

        #region KeyPress TimeStart
        private void txtTimeStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region KeyPress Time End
        private void txtTimeEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Btn Start 
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_threadStart == null || _threadStart.IsAlive == false)
            {
                _threadStart = new Thread(DoWork);
                _threadStart.Start();
                //Nho vao Cache
                arrCache[0] = txtLinkExcel.Text;
                arrCache[1] = txtProfile.Text;
                arrCache[2] = txtPathChromeExe.Text;
                Directory.CreateDirectory(@"Log");

                File.WriteAllLines(@"Log\cache.txt", arrCache);
            }
            else FormMess.Show("Warning", "Thread is running.", false);
        }
        #endregion

        #region btn Stop
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_threadStart != null && _threadStart.IsAlive == true)
            {
                if (_chromeDriver != null)
                {
                    _chromeDriver.Quit();
                }
                _chromeDriver = null;

                _threadStart.Abort();
                _threadStart = null;

                WriteTitleAtion("Stop", Color.Red);
            }
            else FormMess.Show("Warning", "Thread is not running.", false);
        }
        #endregion

        #region Fun DoWork Run thread start
        private void DoWork()
        {

            WriteTitleAtion("Đọc dữ trên excel", Color.Black);

            _list = new MyExcel().ReadExcle(txtLinkExcel.Text.Trim(), _threadStart, this);

            WriteTitleAtion("Đóng Hết Chrome", Color.Black);

            // new MyChrome().CloseAllChrome();

            WriteTitleAtion("Mở Chrome", Color.Black);
            // creat Chorme
            _chromeDriver = new MyChrome().CreatChrome(txtPathChromeExe.Text.Trim(), txtProfile.Text.Trim(), _threadStart, this);

            if (_chromeDriver == null)
            {
                WriteTitleAtion("Stop - Không mở được Chrome", Color.Black);
                return;
            }
            WriteTitleAtion("Nhập dữ liệu", Color.Black);
            // Pust Data
            PustData pust = new PustData();

            pust.PushData(_list, this, _chromeDriver, _threadStart);
        }
        #endregion


        #region Sleep Next list
        public void SleepNextList()
        {
            try
            {
                int time = 0;
                time = new Random().Next(int.Parse(txtTimeStart.Text), int.Parse(txtTimeEnd.Text));

                while (time >= 0)
                {
                    WriteTitleAtion($"Dừng chờ: {time}", Color.Black);
                    Thread.Sleep(1000);
                    time--;
                }
            }
            catch (Exception e)
            {
            }

        }
        #endregion

        #region Write data input html
        public void WriteDataInput(IWebElement element, String text)
        {
            try
            {
                element.Clear();
                int length = text.Length;
                for (int i = 0; i < length; i++)
                {
                    element.SendKeys(text[i].ToString());
                    Thread.Sleep(_SleepKeyChar);
                }
                Thread.Sleep(_SleepNextInput);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
               // WriteLog(e.ToString(), Color.Red);
            }

        }
        #endregion

        #region Write Title Ation
        public void WriteTitleAtion(String Text, Color color)
        {
            try
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    lblAction.ForeColor = color;
                    lblAction.Text = Text;
                }));
            }
            catch (Exception) { }
        }
        #endregion

        #region Write log
        public void WriteLog(String text, Color color)
        {
            try
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    txtLog.Select(0, 0);
                    txtLog.SelectionColor = color;
                    txtLog.SelectedText = DateTime.Now.ToString("HH:mm:ss") + " : " + text + "\r\n";
                }));
            }
            catch (Exception e) { }

        }
        #endregion

        #region Btn Open File 
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileExcel.ShowDialog() == DialogResult.OK)
            {
                String x = openFileExcel.FileName;
                txtLinkExcel.Text = x;
            }
        }
        #endregion

        #region Check All text box
        public void CheckAllTextBox()
        {

            CheckNullText.Check(txtLinkExcel.Text.Trim(), "Nhập link Excel", _threadStart);

            CheckNullText.Check(txtPathChromeExe.Text.Trim(), "Nhập link đường dẫn chrome", _threadStart);

            CheckNullText.Check(txtProfile.Text.Trim(), "Nhập Profile", _threadStart);

            CheckNullText.Check(txtTimeStart.Text.Trim(), "Nhập thời gian bắt đầu", _threadStart);

            CheckNullText.Check(txtTimeEnd.Text.Trim(), "Nhập Thời gian kết thúc", _threadStart);

            if (int.Parse(txtTimeEnd.Text.Trim()) < int.Parse(txtTimeStart.Text.Trim()))
            {
                FormMess.Show("Lỗi", "Thời Gian bắt đầu nhỏ hơn hoặc bằng thời gian kết thúc", false);
                _threadStart.Abort();
                return;
            }
        }

        private void btnOpenChrome_Click(object sender, EventArgs e)
        {
            if (openFileChrome.ShowDialog() == DialogResult.OK)
            {
                String x = openFileChrome.FileName;
                txtPathChromeExe.Text = x;
            }
        }
    }
    #endregion
}
