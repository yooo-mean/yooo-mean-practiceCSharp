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
            this.tbxOperend = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HelloLabel.Location = new System.Drawing.Point(77, 119);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(237, 29);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "계산기 사용하려면 클릭";
            this.HelloLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HelloLabel_MouseDown);
            // 
            // tbxOperend
            // 
            this.tbxOperend.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxOperend.Location = new System.Drawing.Point(38, 28);
            this.tbxOperend.Name = "tbxOperend";
            this.tbxOperend.Size = new System.Drawing.Size(300, 43);
            this.tbxOperend.TabIndex = 4;
            this.tbxOperend.Visible = false;
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(38, 113);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlus.Size = new System.Drawing.Size(35, 35);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Visible = false;
            this.btnPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPlus_MouseDown);
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(104, 113);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(35, 35);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Visible = false;
            this.btnMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMinus_MouseDown);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiply.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.Location = new System.Drawing.Point(170, 113);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(35, 35);
            this.btnMultiply.TabIndex = 9;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Visible = false;
            this.btnMultiply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMultiply_MouseDown);
            // 
            // btnDivide
            // 
            this.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivide.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnDivide.Location = new System.Drawing.Point(236, 113);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(35, 35);
            this.btnDivide.TabIndex = 10;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Visible = false;
            this.btnDivide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDivide_MouseDown);
            // 
            // btnRest
            // 
            this.btnRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRest.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnRest.Location = new System.Drawing.Point(302, 113);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(35, 35);
            this.btnRest.TabIndex = 11;
            this.btnRest.Text = "%";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Visible = false;
            this.btnRest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRest_MouseDown);
            // 
            // btnResult
            // 
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnResult.Location = new System.Drawing.Point(38, 189);
            this.btnResult.Name = "btnResult";
            this.btnResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResult.Size = new System.Drawing.Size(300, 35);
            this.btnResult.TabIndex = 12;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Visible = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 272);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tbxOperend);
            this.Controls.Add(this.HelloLabel);
            this.Name = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.TextBox tbxOperend;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnResult;
    }
}

