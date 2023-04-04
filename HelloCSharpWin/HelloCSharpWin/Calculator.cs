using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "계산기";
            HelloLabel.Visible = false;
            lblOperendA.Visible = true;
            lblOperendB.Visible = true;
            lblResult.Visible = true;
            btnDivide.Visible = true;
            btnMultiply.Visible = true;
            btnPlus.Visible = true;
            btnMinus.Visible = true;
            btnRest.Visible = true;
            tbxOperendA.Visible = true;
            tbxOperendB.Visible = true;
            tbxResult.Visible = true;
        }

        private void btnPlus_MouseDown(object sender, MouseEventArgs e)
        {
            float result = float.Parse(tbxOperendA.Text) + float.Parse(tbxOperendB.Text);
            int trimRes = Math.Round()
        }

        private void btnMinus_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnMultiply_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnDivide_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnRest_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
