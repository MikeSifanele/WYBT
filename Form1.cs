using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WYBT
{
    public partial class Form1 : Form
    {
        #region private fields
        private string _equity;
        private string _maxEquityDrawdown;
        private string _balance;
        private string _maxBalanceDrawdown;
        #endregion

        #region Properties
        public string Equity
        {
            get { return _equity; }
            set { _equity = value; lblEquity.Text = value; }
        }
        public string MaxEquityDrawdown
        {
            get { return _maxEquityDrawdown; }
            set { _maxEquityDrawdown = value; lblMaxEquityDrawdown.Text = value; }
        }
        public string Balance
        {
            get { return _balance; }
            set { _balance = value; lblBalance.Text = value; }
        }
        public string MaxBalanceDrawdown
        {
            get { return _maxBalanceDrawdown; }
            set { _maxBalanceDrawdown = value; lblMaxBalanceDrawdown.Text = value; }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtractPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
