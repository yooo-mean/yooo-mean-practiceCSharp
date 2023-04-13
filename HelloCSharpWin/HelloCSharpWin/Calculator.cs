using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * To Do 
 * 진짜 계산기처럼 만들기
 * 
 * 첫번째 숫자 입력 - 기호 버튼 클릭 - 두번째 숫자 입력 - 기호 버튼 클릭 - 두 수의 합을 첫번째 숫자에 연산 - 세번째 숫자 입력 - 두번째 숫자에 입력
 * 무한 반복의 로직
 * */

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
            if (String.IsNullOrWhiteSpace(tbxOperend.Text))
            {
                MessageBox.Show("피연산자 A 항에 숫자를 입력해주세요.");
                tbxOperend.Focus();
                return false;
            }
            if (int.TryParse(tbxOperend.Text, out numCheck) == false && double.TryParse(tbxOperend.Text, out dNumChk) == false)
            {
                MessageBox.Show("피연산자 A 항에 문자열이 입력됐어요. 숫자를 입력해주세요.");
                tbxOperend.Focus(); tbxOperend.SelectAll();
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
            btnDivide.Visible = true;
            btnMultiply.Visible = true;
            btnPlus.Visible = true;
            btnMinus.Visible = true;
            btnRest.Visible = true;
            tbxOperend.Visible = true;
            btnResult.Visible = true;
        }

        private void btnPlus_MouseDown(object sender, MouseEventArgs e)
        {

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

        private void btnResult_Click(object sender, EventArgs e)
        {

        }
    }
}
