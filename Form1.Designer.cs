
namespace Test1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.la1 = new System.Windows.Forms.Label();
            this.la2 = new System.Windows.Forms.Label();
            this.la3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(15, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 896);
            this.panel1.TabIndex = 0;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(1107, 14);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(114, 25);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(1107, 49);
            this.txtY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(114, 25);
            this.txtY.TabIndex = 2;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(1107, 84);
            this.txtZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(114, 25);
            this.txtZ.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1057, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "가로(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1057, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "세로(y)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1057, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "높이(z)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1042, 121);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 94);
            this.button1.TabIndex = 7;
            this.button1.Text = "만들기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1143, 121);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 92);
            this.button2.TabIndex = 8;
            this.button2.Text = "지우기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // la1
            // 
            this.la1.AutoSize = true;
            this.la1.Location = new System.Drawing.Point(1083, 262);
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(58, 15);
            this.la1.TabIndex = 4;
            this.la1.Text = "가로(x)";
            // 
            // la2
            // 
            this.la2.AutoSize = true;
            this.la2.Location = new System.Drawing.Point(1083, 298);
            this.la2.Name = "la2";
            this.la2.Size = new System.Drawing.Size(57, 15);
            this.la2.TabIndex = 5;
            this.la2.Text = "세로(y)";
            // 
            // la3
            // 
            this.la3.AutoSize = true;
            this.la3.Location = new System.Drawing.Point(1083, 332);
            this.la3.Name = "la3";
            this.la3.Size = new System.Drawing.Size(57, 15);
            this.la3.TabIndex = 6;
            this.la3.Text = "높이(z)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 929);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.la3);
            this.Controls.Add(this.la2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.la1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label la1;
        private System.Windows.Forms.Label la2;
        private System.Windows.Forms.Label la3;
    }
}

