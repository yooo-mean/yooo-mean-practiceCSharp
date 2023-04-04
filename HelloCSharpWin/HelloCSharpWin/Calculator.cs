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

        //연산 담당 메소드, 매개변수는 실수형
        public int CalcResult(double opA, double opB, string oper)
        {
            //부호에 따른 연산, 정수형 반환
            switch (oper)
            {
                case "+": return (int)Math.Round(opA + opB);
                case "-": return (int)Math.Round(opA - opB);
                case "*": return (int)Math.Round(opA * opB);
                case "/": return (int)Math.Round(opA / opB);
                case "%": return (int)Math.Round(opA % opB);
            }
            return 0;
        }

        private void HelloLabel_MouseDown(object sender, MouseEventArgs e)
        {
            //클릭 시 안내문 제거
            HelloLabel.Visible = false;
            //보이지 않던 계산기 등장
            this.Text = "계산기";
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
            //연산 담당 메소드에 피연산자와 부호 전달, 결과 텍스트 박스에 결과값 출력
            int result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), "+");
            tbxResult.Text = result.ToString();
        }

        private void btnMinus_MouseDown(object sender, MouseEventArgs e)
        {
            int result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), "-");
            tbxResult.Text = result.ToString();
        }

        private void btnMultiply_MouseDown(object sender, MouseEventArgs e)
        {
            int result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), "*");
            tbxResult.Text = result.ToString();
        }

        private void btnDivide_MouseDown(object sender, MouseEventArgs e)
        {
            int result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), "/");
            tbxResult.Text = result.ToString();
        }

        private void btnRest_MouseDown(object sender, MouseEventArgs e)
        {
            int result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), "%");
            tbxResult.Text = result.ToString();
        }
    }
}

