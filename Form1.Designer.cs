namespace Calculator1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnPlus = new Button();
            btnMin = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            btnEql = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(15, 58);
            txtTotal.Margin = new Padding(4, 3, 4, 3);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(677, 67);
            txtTotal.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.GradientActiveCaption;
            btn1.Location = new Point(15, 173);
            btn1.Margin = new Padding(4, 3, 4, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(107, 65);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.GradientActiveCaption;
            btn2.Location = new Point(159, 173);
            btn2.Name = "btn2";
            btn2.Size = new Size(103, 65);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.GradientActiveCaption;
            btn3.Location = new Point(316, 173);
            btn3.Name = "btn3";
            btn3.Size = new Size(97, 65);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.GradientActiveCaption;
            btn4.Location = new Point(463, 173);
            btn4.Name = "btn4";
            btn4.Size = new Size(95, 65);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.GradientActiveCaption;
            btn5.Location = new Point(601, 173);
            btn5.Name = "btn5";
            btn5.Size = new Size(91, 65);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.GradientActiveCaption;
            btn6.Location = new Point(15, 280);
            btn6.Name = "btn6";
            btn6.Size = new Size(107, 60);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.GradientActiveCaption;
            btn7.Location = new Point(159, 280);
            btn7.Name = "btn7";
            btn7.Size = new Size(103, 60);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.GradientActiveCaption;
            btn8.Location = new Point(316, 280);
            btn8.Name = "btn8";
            btn8.Size = new Size(97, 60);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.GradientActiveCaption;
            btn9.Location = new Point(463, 280);
            btn9.Name = "btn9";
            btn9.Size = new Size(97, 60);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.GradientActiveCaption;
            btn0.Location = new Point(601, 280);
            btn0.Name = "btn0";
            btn0.Size = new Size(91, 60);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.GradientActiveCaption;
            btnPlus.Location = new Point(15, 387);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(107, 53);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click_1;
            // 
            // btnMin
            // 
            btnMin.BackColor = SystemColors.GradientActiveCaption;
            btnMin.Location = new Point(170, 387);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(92, 53);
            btnMin.TabIndex = 12;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = SystemColors.GradientActiveCaption;
            btnMul.Location = new Point(316, 387);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(97, 53);
            btnMul.TabIndex = 13;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.GradientActiveCaption;
            btnDiv.Location = new Point(461, 387);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(97, 53);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Location = new Point(601, 387);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(91, 53);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnEql
            // 
            btnEql.BackColor = SystemColors.GradientActiveCaption;
            btnEql.Location = new Point(30, 470);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(662, 79);
            btnEql.TabIndex = 16;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = false;
            btnEql.Click += btnEql_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 575);
            Controls.Add(btnEql);
            Controls.Add(btnClear);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnMin);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnPlus;
        private Button btnMin;
        private Button btnMul;
        private Button btnDiv;
        private Button btnClear;
        private Button btnEql;
    }
}
