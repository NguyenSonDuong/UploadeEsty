using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uploadetsy.MyForm
{
    public partial class FormConfirm : Form
    {
        public String YesNo { get; set; }
        public static String YES { get; } = "Yes";

        public static String NO { get; } = "No";

        public FormConfirm(String Title , String Conten)
        {
            InitializeComponent();
            lblTitle.Text = Title;
            lblConten.Text = Conten;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            YesNo = FormConfirm.YES;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            YesNo = FormConfirm.NO;
            this.Close();
        }

        #region Show form ConFirm
        public static String Show(String Title, String Conten)
        {
            FormConfirm confirm = new FormConfirm(Title, Conten);
            confirm.ShowDialog();
            return confirm.YesNo;
        }
        #endregion
    }
}
