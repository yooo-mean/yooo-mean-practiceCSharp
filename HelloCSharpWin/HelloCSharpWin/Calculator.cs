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

        /* 
         * To-Do List 
         * 
         * 1. 메소드 오버로딩으로 정수형이 올 경우와 실수형이 올 경우 모두 처리 가능하게 만들기
            2. Validatation 만들기
            String.IsNullOrWhiteSpace()

            int.TryParse("문자열", out 정수형)
            T일 시 out에 정수로 parsing 되어 들어감, T처리
            F일 시 out 변화 없음, F처리

            MessageBox.Show("문자열");

            lblOperendA.Focus(); lblOperendA.SelectAll();

         */


        //연산 담당 메소드, 매개변수는 실수형
        public int CalcResult(int opA, int opB, string oper)
        {
            //부호에 따른 연산, 정수형 반환
            switch (oper)
            {
                case "+": return opA + opB;
                case "-": return opA - opB;
                case "*": return opA * opB;
                case "/": return opA / opB;
                case "%": return opA % opB;
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
            int result = CalcResult(Int32.Parse(tbxOperendA.Text), Int32.Parse(tbxOperendB.Text), btnPlus.Text);
            tbxResult.Text = result.ToString();
        }

        private void btnMinus_MouseDown(object sender, MouseEventArgs e)
        {
            int result = CalcResult(Int32.Parse(tbxOperendA.Text), Int32.Parse(tbxOperendB.Text), btnMinus.Text);
            tbxResult.Text = result.ToString();
        }

        private void btnMultiply_MouseDown(object sender, MouseEventArgs e)
        {
            int result = CalcResult(Int32.Parse(tbxOperendA.Text), Int32.Parse(tbxOperendB.Text), btnMultiply.Text);
            tbxResult.Text = result.ToString();
        }

        private void btnDivide_MouseDown(object sender, MouseEventArgs e)
        {
            float result = CalcResult(Int32.Parse(tbxOperendA.Text), Int32.Parse(tbxOperendB.Text), btnDivide.Text);
            tbxResult.Text = result.ToString();
        }

        private void btnRest_MouseDown(object sender, MouseEventArgs e)
        {
            int result = CalcResult(Int32.Parse(tbxOperendA.Text), Int32.Parse(tbxOperendB.Text), btnRest.Text);
            tbxResult.Text = result.ToString();
        }
    }
}

