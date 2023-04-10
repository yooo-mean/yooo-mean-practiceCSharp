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

        public bool ChkValidation()
        {
            //validation 체크용
            int numCheck; double dNumChk;
            //유효값 검사 validation
            if (String.IsNullOrWhiteSpace(tbxOperendA.Text))
            {
                MessageBox.Show("피연산자 A 항에 숫자를 입력해주세요.");
                tbxOperendA.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbxOperendB.Text))
            {
                MessageBox.Show("피연산자 B 항에 숫자를 입력해주세요.");
                tbxOperendB.Focus();
                return false;
            }
            if (int.TryParse(tbxOperendA.Text, out numCheck) == false && double.TryParse(tbxOperendA.Text, out dNumChk) == false)
            {
                MessageBox.Show("피연산자 A 항에 문자열이 입력됐어요. 숫자를 입력해주세요.");
                tbxOperendA.Focus(); tbxOperendA.SelectAll();
                return false;
            }
            if (int.TryParse(tbxOperendB.Text, out numCheck) == false && double.TryParse(tbxOperendB.Text, out dNumChk) == false)
            {
                MessageBox.Show("피연산자 B 항에 문자열이 입력됐어요. 숫자를 입력해주세요.");
                tbxOperendB.Focus(); tbxOperendB.SelectAll();
                return false;
            }
            return true;
        }

        //연산 담당 메소드, 매개변수는 정수형
        public int CalcResult(int opA, int opB, string oper)
        {
            //부호에 따른 연산, 정수형 반환
            //나눗셈은 정수/정수의 경우에도 실수가 반환될 수 있으므로 double형으로 통일.
            switch (oper)
            {
                case "+": return opA + opB;
                case "-": return opA - opB;
                case "*": return opA - opB;
                case "%": return opA % opB;
            }
            return 0;
        }

        //메소드 오버로딩 : 실수형 연산
        public double CalcResult(double opA, double opB, string oper)
        {
            //부호에 따른 연산, 실수형 반환
            switch (oper)
            {
                case "+": return Math.Round((opA + opB), 2);
                case "-": return Math.Round((opA - opB), 2);
                case "*": return Math.Round((opA * opB), 2);
                case "/": return Math.Round((opA / opB), 2);
                case "%": return Math.Round((opA % opB), 2);
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
            //유효성 검사 호출
            while (true)
            {
                //유효성 검사 통과 시 아래 if문으로 이동
                if (ChkValidation()) break;
                //유효성 검사 실패 시 아예 이벤트 문 밖으로 이동. 아래 if문에 걸리지 않음.
                else return;
            }
            //피연산자에 . 포함 시 실수 연산 메소드 호출
            if (tbxOperendA.Text.Contains(".") || tbxOperendB.Text.Contains("."))
            {
                double result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), (sender as Button).Text);
                tbxResult.Text = result.ToString();
            }
            //피연산자에 . 포함되지 않을 시 정수 연산 메소드 호출
            else
            {
                int result = CalcResult(Int32.Parse(tbxOperendA.Text), Int32.Parse(tbxOperendB.Text), (sender as Button).Text);
                tbxResult.Text = result.ToString();
            }
        }

        private void btnMinus_MouseDown(object sender, MouseEventArgs e)
        {
            while (true)
            {
                if (ChkValidation()) break;
                else return;
            }
            if (tbxOperendA.Text.Contains(".") || tbxOperendB.Text.Contains("."))
            {
                double result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), (sender as Button).Text);
                tbxResult.Text = result.ToString();
            }
            else
            {
                int result = CalcResult(Int32.Parse(tbxOperendA.Text), Int32.Parse(tbxOperendB.Text), (sender as Button).Text);
                tbxResult.Text = result.ToString();
            }
        }

        private void btnMultiply_MouseDown(object sender, MouseEventArgs e)
        {
            while (true)
            {
                if (ChkValidation()) break;
                else return;
            }
            if (tbxOperendA.Text.Contains(".") || tbxOperendB.Text.Contains("."))
            {
                double result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), (sender as Button).Text);
                tbxResult.Text = result.ToString();
            }
            else
            {
                int result = CalcResult(Int32.Parse(tbxOperendA.Text), Int32.Parse(tbxOperendB.Text), (sender as Button).Text);
                tbxResult.Text = result.ToString();
            }
        }

        private void btnDivide_MouseDown(object sender, MouseEventArgs e)
        {
            while (true)
            {
                if (ChkValidation()) break;
                else return;
            }
            //나눗셈은 정수형끼리 나누어도 소수가 나올 수 있으므로 실수형으로만 처리
            double result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), (sender as Button).Text);
            tbxResult.Text = result.ToString();
        }

        private void btnRest_MouseDown(object sender, MouseEventArgs e)
        {
            while (true)
            {
                if (ChkValidation()) break;
                else return;
            }
            if (tbxOperendA.Text.Contains(".") || tbxOperendB.Text.Contains("."))
            {
                double result = CalcResult(Double.Parse(tbxOperendA.Text), Double.Parse(tbxOperendB.Text), (sender as Button).Text);
                tbxResult.Text = result.ToString();
            }
            else
            {
                int result = CalcResult(Int32.Parse(tbxOperendA.Text), Int32.Parse(tbxOperendB.Text), (sender as Button).Text);
                tbxResult.Text = result.ToString();
            }
        }
    }
}
