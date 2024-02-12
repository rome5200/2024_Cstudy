namespace F008_Calculator_3_
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
            txtResult = new TextBox();
            txtExp = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnMM = new Button();
            btnMP = new Button();
            btnMC = new Button();
            btnMS = new Button();
            btnMR = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDot = new Button();
            btn0 = new Button();
            btnPM = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            but4 = new Button();
            btnInverse = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDel = new Button();
            btnC = new Button();
            btnCE = new Button();
            btnIndex = new Button();
            btnSqrt = new Button();
            btnPercent = new Button();
            btnPlus = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            btnEqual = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(21, 57);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(310, 36);
            txtResult.TabIndex = 11;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // txtExp
            // 
            txtExp.BorderStyle = BorderStyle.None;
            txtExp.Font = new Font("맑은 고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtExp.ForeColor = SystemColors.ScrollBar;
            txtExp.Location = new Point(73, 18);
            txtExp.Name = "txtExp";
            txtExp.Size = new Size(258, 23);
            txtExp.TabIndex = 10;
            txtExp.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnMM, 3, 0);
            tableLayoutPanel2.Controls.Add(btnMP, 2, 0);
            tableLayoutPanel2.Controls.Add(btnMC, 0, 0);
            tableLayoutPanel2.Controls.Add(btnMS, 4, 0);
            tableLayoutPanel2.Controls.Add(btnMR, 1, 0);
            tableLayoutPanel2.Location = new Point(2, 110);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(332, 49);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // btnMM
            // 
            btnMM.FlatStyle = FlatStyle.Flat;
            btnMM.Location = new Point(201, 3);
            btnMM.Name = "btnMM";
            btnMM.Size = new Size(60, 43);
            btnMM.TabIndex = 3;
            btnMM.Text = "M-";
            btnMM.UseVisualStyleBackColor = true;
            btnMM.Click += btnMM_Click;
            // 
            // btnMP
            // 
            btnMP.FlatStyle = FlatStyle.Flat;
            btnMP.Location = new Point(135, 3);
            btnMP.Name = "btnMP";
            btnMP.Size = new Size(60, 43);
            btnMP.TabIndex = 2;
            btnMP.Text = "M+";
            btnMP.UseVisualStyleBackColor = true;
            btnMP.Click += btnMP_Click;
            // 
            // btnMC
            // 
            btnMC.FlatStyle = FlatStyle.Flat;
            btnMC.Location = new Point(3, 3);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(60, 43);
            btnMC.TabIndex = 0;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            btnMC.Click += btnMC_Click;
            // 
            // btnMS
            // 
            btnMS.FlatStyle = FlatStyle.Flat;
            btnMS.Location = new Point(267, 3);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(62, 43);
            btnMS.TabIndex = 4;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            btnMS.Click += btnMS_Click;
            // 
            // btnMR
            // 
            btnMR.FlatStyle = FlatStyle.Flat;
            btnMR.Location = new Point(69, 3);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(60, 43);
            btnMR.TabIndex = 1;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            btnMR.Click += btnMR_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnDot, 2, 5);
            tableLayoutPanel1.Controls.Add(btn0, 1, 5);
            tableLayoutPanel1.Controls.Add(btnPM, 0, 5);
            tableLayoutPanel1.Controls.Add(btn3, 2, 4);
            tableLayoutPanel1.Controls.Add(btn2, 1, 4);
            tableLayoutPanel1.Controls.Add(btn1, 0, 4);
            tableLayoutPanel1.Controls.Add(btn6, 2, 3);
            tableLayoutPanel1.Controls.Add(btn5, 1, 3);
            tableLayoutPanel1.Controls.Add(but4, 0, 3);
            tableLayoutPanel1.Controls.Add(btnInverse, 3, 0);
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(btnDel, 2, 1);
            tableLayoutPanel1.Controls.Add(btnC, 1, 1);
            tableLayoutPanel1.Controls.Add(btnCE, 0, 1);
            tableLayoutPanel1.Controls.Add(btnIndex, 2, 0);
            tableLayoutPanel1.Controls.Add(btnSqrt, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPercent, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPlus, 3, 4);
            tableLayoutPanel1.Controls.Add(btnSub, 3, 3);
            tableLayoutPanel1.Controls.Add(btnMul, 3, 2);
            tableLayoutPanel1.Controls.Add(btnDiv, 3, 1);
            tableLayoutPanel1.Controls.Add(btnEqual, 3, 5);
            tableLayoutPanel1.Location = new Point(2, 158);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(335, 310);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // btnDot
            // 
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(169, 258);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(77, 45);
            btnDot.TabIndex = 23;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(86, 258);
            btn0.Name = "btn0";
            btn0.Size = new Size(77, 45);
            btn0.TabIndex = 22;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNum_Click;
            // 
            // btnPM
            // 
            btnPM.FlatStyle = FlatStyle.Flat;
            btnPM.Font = new Font("맑은 고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnPM.Location = new Point(3, 258);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(77, 45);
            btnPM.TabIndex = 21;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btn3
            // 
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(169, 207);
            btn3.Name = "btn3";
            btn3.Size = new Size(77, 45);
            btn3.TabIndex = 20;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(86, 207);
            btn2.Name = "btn2";
            btn2.Size = new Size(77, 45);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNum_Click;
            // 
            // btn1
            // 
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(3, 207);
            btn1.Name = "btn1";
            btn1.Size = new Size(77, 45);
            btn1.TabIndex = 18;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(169, 156);
            btn6.Name = "btn6";
            btn6.Size = new Size(77, 45);
            btn6.TabIndex = 17;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(86, 156);
            btn5.Name = "btn5";
            btn5.Size = new Size(77, 45);
            btn5.TabIndex = 16;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNum_Click;
            // 
            // but4
            // 
            but4.FlatStyle = FlatStyle.Flat;
            but4.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            but4.Location = new Point(3, 156);
            but4.Name = "but4";
            but4.Size = new Size(77, 45);
            but4.TabIndex = 15;
            but4.Text = "4";
            but4.UseVisualStyleBackColor = true;
            but4.Click += btnNum_Click;
            // 
            // btnInverse
            // 
            btnInverse.BackColor = SystemColors.ActiveBorder;
            btnInverse.BackgroundImageLayout = ImageLayout.None;
            btnInverse.FlatStyle = FlatStyle.Flat;
            btnInverse.Location = new Point(252, 3);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(80, 45);
            btnInverse.TabIndex = 13;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = false;
            btnInverse.Click += btnInverse_Click;
            // 
            // btn9
            // 
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(169, 105);
            btn9.Name = "btn9";
            btn9.Size = new Size(77, 45);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(86, 105);
            btn8.Name = "btn8";
            btn8.Size = new Size(77, 45);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNum_Click;
            // 
            // btn7
            // 
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(3, 105);
            btn7.Name = "btn7";
            btn7.Size = new Size(77, 45);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNum_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ActiveBorder;
            btnDel.BackgroundImageLayout = ImageLayout.None;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Location = new Point(169, 54);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(77, 45);
            btnDel.TabIndex = 6;
            btnDel.Text = "←";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.ActiveBorder;
            btnC.BackgroundImageLayout = ImageLayout.None;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Location = new Point(86, 54);
            btnC.Name = "btnC";
            btnC.Size = new Size(77, 45);
            btnC.TabIndex = 5;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = SystemColors.ActiveBorder;
            btnCE.BackgroundImageLayout = ImageLayout.None;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Location = new Point(3, 54);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(77, 45);
            btnCE.TabIndex = 4;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnIndex
            // 
            btnIndex.BackColor = SystemColors.ActiveBorder;
            btnIndex.BackgroundImageLayout = ImageLayout.None;
            btnIndex.FlatStyle = FlatStyle.Flat;
            btnIndex.Location = new Point(169, 3);
            btnIndex.Name = "btnIndex";
            btnIndex.Size = new Size(77, 45);
            btnIndex.TabIndex = 2;
            btnIndex.Text = "x²";
            btnIndex.UseVisualStyleBackColor = false;
            btnIndex.Click += btnIndex_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = SystemColors.ActiveBorder;
            btnSqrt.BackgroundImageLayout = ImageLayout.None;
            btnSqrt.FlatStyle = FlatStyle.Flat;
            btnSqrt.Location = new Point(86, 3);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(77, 45);
            btnSqrt.TabIndex = 1;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = SystemColors.ActiveBorder;
            btnPercent.BackgroundImageLayout = ImageLayout.None;
            btnPercent.FlatStyle = FlatStyle.Flat;
            btnPercent.Location = new Point(3, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(77, 45);
            btnPercent.TabIndex = 0;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ActiveBorder;
            btnPlus.BackgroundImageLayout = ImageLayout.None;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Location = new Point(252, 207);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(80, 45);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += op_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.ActiveBorder;
            btnSub.BackgroundImageLayout = ImageLayout.None;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Location = new Point(252, 156);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(80, 45);
            btnSub.TabIndex = 11;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += op_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = SystemColors.ActiveBorder;
            btnMul.BackgroundImageLayout = ImageLayout.None;
            btnMul.FlatStyle = FlatStyle.Flat;
            btnMul.Location = new Point(252, 105);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(80, 45);
            btnMul.TabIndex = 7;
            btnMul.Text = "×";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += op_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ActiveBorder;
            btnDiv.BackgroundImageLayout = ImageLayout.None;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Location = new Point(252, 54);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(80, 45);
            btnDiv.TabIndex = 3;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += op_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ActiveBorder;
            btnEqual.BackgroundImageLayout = ImageLayout.None;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Location = new Point(252, 258);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(80, 45);
            btnEqual.TabIndex = 14;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(340, 465);
            Controls.Add(txtResult);
            Controls.Add(txtExp);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "나의 계산기";
            Click += btnNum_Click;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private TextBox txtExp;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnMM;
        private Button btnMP;
        private Button btnMC;
        private Button btnMS;
        private Button btnMR;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDot;
        private Button btn0;
        private Button btnPM;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button but4;
        private Button btnInverse;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDel;
        private Button btnC;
        private Button btnCE;
        private Button btnIndex;
        private Button btnSqrt;
        private Button btnPercent;
        private Button btnPlus;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Button btnEqual;
    }
}