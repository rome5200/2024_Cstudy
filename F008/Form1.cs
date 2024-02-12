using System;

namespace F008_Calculator_3_
{
    public partial class Form1 : Form
    {
        private double FirstValue;
        private double SecondValue;
        private string op = "\0";
        private bool opFlag = false;
        private bool memoryFlag = false;
        private double memory;

        public Form1()
        {
            InitializeComponent();
        }

        // 숫자 클릭 메소드
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (txtResult.Text == "\0" || opFlag == true)
            {
                txtResult.Text = btn.Text;
                opFlag = false;
            }
            else
                txtResult.Text = txtResult.Text + btn.Text;
        }

        //연산자 클릭 메소드
        private void op_Click(object sender, EventArgs e)
        {
            opFlag = true;
            FirstValue = Double.Parse(txtResult.Text);
            Button btn = sender as Button;
            op = btn.Text;
            txtExp.Text = FirstValue + op;
        }

        // . 클릭 메소드
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains('.'))
                return;
            else
                txtResult.Text += ".";
        }

        // ± 클릭 메소드
        private void btnPM_Click(object sender, EventArgs e)
        {
            double v = Double.Parse(txtResult.Text);
            txtResult.Text = (-v).ToString();
        }

        // % 클릭 메소드
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (txtExp.Text.EndsWith('×') || txtExp.Text.EndsWith('÷'))
            {
                double result_num = Double.Parse(txtResult.Text) * 0.01;
                txtExp.Text += result_num.ToString();
                txtResult.Text = result_num.ToString();
            }
            else if (txtExp.Text.EndsWith('÷'))
            {
                double result_num = Double.Parse(txtResult.Text) * 0.01;
                txtExp.Text += result_num.ToString();
                txtResult.Text = result_num.ToString();
            }
            else
            {
                txtExp.Text = "0";
                txtResult.Text = "0";
            }
        }

        // 제곱근
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtExp.Text = "√(" + txtResult.Text + ") ";
            txtResult.Text = Math.Sqrt(Double.Parse(txtResult.Text)).ToString();
        }

        // 제곱
        private void btnIndex_Click(object sender, EventArgs e)
        {
            txtExp.Text = "sqr(" + txtResult.Text + ") ";
            txtResult.Text = (Double.Parse(txtResult.Text) * Double.Parse(txtResult.Text)).ToString();
        }

        // 역수
        private void btnInverse_Click(object sender, EventArgs e)
        {
            txtExp.Text = "1/(" + txtResult.Text + ") ";
            txtResult.Text = (1 / Double.Parse(txtResult.Text)).ToString();
        }

        // = 클릭 메소드
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double result;
            double SecondValue = Double.Parse(txtResult.Text);
            switch (op)
            {
                case "+":
                    txtExp.Text = FirstValue.ToString() + "+" + SecondValue.ToString();
                    result = FirstValue + SecondValue;
                    txtResult.Text = result.ToString();
                    break;
                case "-":
                    txtExp.Text = FirstValue.ToString() + "-" + SecondValue.ToString();
                    result = FirstValue - SecondValue;
                    SecondValue = result;
                    txtResult.Text = result.ToString();
                    break;
                case "×":
                    txtExp.Text = FirstValue.ToString() + "×" + SecondValue.ToString();
                    result = FirstValue * SecondValue;
                    txtResult.Text = result.ToString();
                    break;
                case "÷":
                    if (SecondValue == 0)
                        txtResult.Text = "0으로 나눌 수 없습니다.";
                    else
                    {
                        txtExp.Text = FirstValue.ToString() + "÷" + SecondValue.ToString();
                        result = FirstValue / SecondValue;
                        txtResult.Text = result.ToString();

                    }
                    break;
            }
        }

        // 초기화 메소드
        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "\0";
            txtExp.Text = "\0";
            FirstValue = 0;
            SecondValue = 0;
            op = "\0";
            opFlag = false;
        }

        // txtResult 초기화 메소드
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "\0";
        }

        // backspace 메소드
        private void btnDel_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "\0";
        }

        //Memory Clear
        private void btnMC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "\0";
            memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }

        //Memory Read
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtResult.Text = memory.ToString();
            memoryFlag = true;
        }

        //Memory Plus
        private void btnMP_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(txtResult.Text);
        }

        //Memory Minus
        private void btnMM_Click(object sender, EventArgs e)
        {
            memory -= Double.Parse(txtResult.Text);
        }

        //Memory Save
        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(txtResult.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            memoryFlag = true;
        }
    }
}