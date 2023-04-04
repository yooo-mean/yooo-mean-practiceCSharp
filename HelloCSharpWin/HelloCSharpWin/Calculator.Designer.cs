namespace HelloCSharpWin
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloLabel = new System.Windows.Forms.Label();
            this.lblOperendA = new System.Windows.Forms.Label();
            this.lblOperendB = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxOperendA = new System.Windows.Forms.TextBox();
            this.tbxOperendB = new System.Windows.Forms.TextBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloLabel.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HelloLabel.Location = new System.Drawing.Point(58, 119);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(256, 28);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "계산기 사용하려면 클릭";
            this.HelloLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelloLabel_MouseDown);
            // 
            // lblOperendA
            // 
            this.lblOperendA.AutoSize = true;
            this.lblOperendA.Location = new System.Drawing.Point(53, 31);
            this.lblOperendA.Name = "lblOperendA";
            this.lblOperendA.Size = new System.Drawing.Size(76, 15);
            this.lblOperendA.TabIndex = 1;
            this.lblOperendA.Text = "피연산자A";
            this.lblOperendA.Visible = false;
            // 
            // lblOperendB
            // 
            this.lblOperendB.AutoSize = true;
            this.lblOperendB.Location = new System.Drawing.Point(53, 94);
            this.lblOperendB.Name = "lblOperendB";
            this.lblOperendB.Size = new System.Drawing.Size(77, 15);
            this.lblOperendB.TabIndex = 2;
            this.lblOperendB.Text = "피연산자B";
            this.lblOperendB.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(53, 235);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(42, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "결 과";
            this.lblResult.Visible = false;
            // 
            // tbxOperendA
            // 
            this.tbxOperendA.Location = new System.Drawing.Point(142, 28);
            this.tbxOperendA.Name = "tbxOperendA";
            this.tbxOperendA.Size = new System.Drawing.Size(172, 25);
            this.tbxOperendA.TabIndex = 4;
            this.tbxOperendA.Visible = false;
            // 
            // tbxOperendB
            // 
            this.tbxOperendB.Location = new System.Drawing.Point(142, 91);
            this.tbxOperendB.Name = "tbxOperendB";
            this.tbxOperendB.Size = new System.Drawing.Size(172, 25);
            this.tbxOperendB.TabIndex = 5;
            this.tbxOperendB.Visible = false;
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(142, 232);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(172, 25);
            this.tbxResult.TabIndex = 6;
            this.tbxResult.Visible = false;
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Location = new System.Drawing.Point(63, 169);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(23, 23);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Visible = false;
            this.btnPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPlus_MouseDown);
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Location = new System.Drawing.Point(120, 169);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(23, 23);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Visible = false;
            this.btnMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMinus_MouseDown);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiply.Location = new System.Drawing.Point(177, 169);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(23, 23);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Visible = false;
            this.btnMultiply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMultiply_MouseDown);
            // 
            // btnDivide
            // 
            this.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivide.Location = new System.Drawing.Point(234, 169);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(23, 23);
            this.btnDivide.TabIndex = 10;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Visible = false;
            this.btnDivide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDivide_MouseDown);
            // 
            // btnRest
            // 
            this.btnRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRest.Location = new System.Drawing.Point(291, 169);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(23, 23);
            this.btnRest.TabIndex = 11;
            this.btnRest.Text = "%";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Visible = false;
            this.btnRest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRest_MouseDown);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 293);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.tbxOperendB);
            this.Controls.Add(this.tbxOperendA);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOperendB);
            this.Controls.Add(this.lblOperendA);
            this.Controls.Add(this.HelloLabel);
            this.Name = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Label lblOperendA;
        private System.Windows.Forms.Label lblOperendB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxOperendA;
        private System.Windows.Forms.TextBox tbxOperendB;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnRest;
    }
}

