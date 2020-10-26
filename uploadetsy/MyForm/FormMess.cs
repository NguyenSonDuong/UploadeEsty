using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uploadetsy.MyForm
{
    public partial class FormMess : Form
    {
       
        public FormMess(String Title, String Conten, bool check)
        {
            InitializeComponent();
            // check true thi dung
            if (check == true)
            {
                panelAleft.BackColor = Color.FromArgb(63, 197, 157);
                pcbError.Visible = false;
                pcbSuccess.Visible = true;
            }
            else
            {
                panelAleft.BackColor = Color.FromArgb(227, 76, 94);
                pcbError.Visible = true;
                pcbSuccess.Visible = false;
            }
            lblTitle.Text = Title;
            lblConten.Text = Conten;
          
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }


        }

        #region Show form Mess
        public static void Show(String Title, String Conten, bool Check)
        {
            try
            {
                FormMess formMess = new FormMess(Title, Conten, Check);
                formMess.ShowDialog();

            }
            catch (Exception) { }
        }
        #endregion
    }
}

