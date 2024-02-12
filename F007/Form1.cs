namespace F007_AverageScore
{
    public partial class Form1 : Form
    {
        private Subject[] subjects;
        private TextBox[] txtTitles;
        private TextBox[] txtCredits;
        private ComboBox[] grades;

        public Form1()
        {
            InitializeComponent();
            subjects = new Subject[10] {
                new Subject { Title = "자료구조", Credit = 3 },
                new Subject("설계및프로젝트기본I", 2),
                new Subject("기업가정신과리더십", 1),
                new Subject("영어I", 1),
                new Subject("컴퓨터구조", 3),
                new Subject("일반수학", 3),
                new Subject("인체의구조와기능I", 2),
                new Subject("비주얼프로그래밍",3),
                new Subject("데이터사이언스", 2),
                new Subject("중점교양", 2)
            };
            txtTitles = new TextBox[10]
            {
                textBox1, textBox2, textBox3, textBox4,
                textBox5, textBox6, textBox7, textBox8,
                textBox9, textBox10
            };
            txtCredits = new TextBox[10]
            {
                tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9, tb10
            };
            grades = new ComboBox[10]
            {
                comboBox1, comboBox2, comboBox3, comboBox4, comboBox5,
                comboBox6, comboBox7, comboBox8, comboBox9, comboBox10
            };

            for (int i = 0; i < subjects.Length; i++)
            {
                txtTitles[i].Text = subjects[i].Title;
                txtCredits[i].Text = subjects[i].Credit.ToString();
            }

            foreach (var combo in grades)
            {
                combo.Items.Add("A+");
                combo.Items.Add("A0");
                combo.Items.Add("B+");
                combo.Items.Add("B0");
                combo.Items.Add("C+");
                combo.Items.Add("C0");
                combo.Items.Add("D+");
                combo.Items.Add("D0");
                combo.Items.Add("F");
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb7_TextChanged(object sender, EventArgs e)
        {

        }

        private double GetGrade(string v)
        {
            double grade = 0;
            if (v == "A+") grade = 4.5;
            else if (v == "A0") grade = 4.0;
            else if (v == "A0") grade = 4.0;
            else if (v == "B+") grade = 3.5;
            else if (v == "B0") grade = 3.0;
            else if (v == "C+") grade = 2.5;
            else if (v == "C0") grade = 2.0;
            else if (v == "D+") grade = 1.5;
            else if (v == "D0") grade = 1.0;
            else if (v == "F") grade = 0;

            return grade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredits = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i].SelectedItem != null)
                {
                    int crd = int.Parse(txtCredits[i].Text);
                    totalCredits += crd;
                    totalScore += crd * GetGrade(grades[i].SelectedItem.ToString());
                }
            }
            txtResult.Text = (totalScore / totalCredits).ToString("0.00");
        }
    }
}