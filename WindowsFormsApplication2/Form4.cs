using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;                   //關閉X按鈕作用
                return myCp;
            }
        }

        int[] QuestionR = new int[800];
        int[] QuestionID = new int[800];
        int NowNum = 0;
        int timer;
        string[] Question = new string[800];
        string[] Answer = new string[800];
        string[] C1 = new string[800];
        string[] C2 = new string[800];
        string[] C3 = new string[800];
        string[] C4 = new string[800];                      //區域變數

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            switch(Global.item)
            {
                case 11800:
                    this.question11800TableAdapter.Fill(this.sT1DataSet.Question11800);
                    break;
                case 11900:
                    this.question11900TableAdapter.Fill(this.sT1DataSet.Question11900);
                    break;
                case 12000:
                    this.question12000TableAdapter.Fill(this.sT1DataSet.Question12000);
                    break;
                case 17200:
                    this.question17200TableAdapter.Fill(this.sT1DataSet.Question17200);
                    break;
                case 17300:
                    this.question17300TableAdapter.Fill(this.sT1DataSet.Question17300);
                    break;                                                                                  //選擇題庫
            }
                
            for(int i = 0;i < 1000;i++)
            {
                if(string.IsNullOrEmpty(Convert.ToString(dataGridView1[0,i].Value)))
                {
                    break;
                }
                QuestionID[i] = Convert.ToInt16(dataGridView1[0,i].Value);
                Question[i] = Convert.ToString(dataGridView1[1,i].Value);
                Answer[i] = Convert.ToString(dataGridView1[2, i].Value);
                C1[i] = Convert.ToString(dataGridView1[3, i].Value);
                C2[i] = Convert.ToString(dataGridView1[4, i].Value);
                C3[i] = Convert.ToString(dataGridView1[5, i].Value);
                C4[i] = Convert.ToString(dataGridView1[6, i].Value);
                Global.Question[i] = Convert.ToString(dataGridView1[1, i].Value);
                Global.C1[i] = Convert.ToString(dataGridView1[3, i].Value);
                Global.C2[i] = Convert.ToString(dataGridView1[4, i].Value);
                Global.C3[i] = Convert.ToString(dataGridView1[5, i].Value);
                Global.C4[i] = Convert.ToString(dataGridView1[6, i].Value);                                    //匯入資料
            }

            if(Global.count == 20)
            {
                comboBox1.DataSource = Global.Q20;
            }
            else if(Global.count == 80)
            {
                comboBox1.DataSource = Global.Q80;
            }

            dataGridView1.Visible = false;
            timer = Global.time * 60;
            textBox1.Text = Convert.ToString(Global.time);

            Random ran = new Random();
            int n;
            for (int i = 0; i< Global.count;i++)
            {
                n = ran.Next(Global.open, Global.end);
                QuestionR[i] = n;
                Global.QuestionR[i] = n;
                for (int j = 0;j<Global.count;j++)
                {
                    if(QuestionR[j] == n)
                    {
                        if(i != j)
                        {
                            do
                            {
                                n = ran.Next(Global.open, Global.end);
                            }
                            while (QuestionR[j] == n);
                            QuestionR[i] = n;
                            Global.QuestionR[i] = n;
                        }
                    }
                }
            }

            for (int i = 0; i < Global.count; i++)
            {
                Global.Answer[i] = Convert.ToInt16(Answer[QuestionR[i]]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeQ();

            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            comboBox1.Enabled = true;
            button1.Enabled = false;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer -= 1;
            textBox1.Text = Convert.ToString(timer / 60);
            textBox2.Text = Convert.ToString(timer % 60);
            if(timer == 0)
            {
                MessageBox.Show("時間到！");
                timer1.Enabled = false;
                Form5 f5 = new Form5();
                f5.Visible = true;
                Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("確定要提早交卷嗎?", "確認視窗", MessageBoxButtons.OKCancel);

            if (Result == DialogResult.OK)
            {
                Form5 f5 = new Form5();
                f5.Visible = true;
                Close();
            }
            else if (Result == DialogResult.Cancel)
            {
                MessageBox.Show("請繼續填寫", "已取消");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string unans = "";
            for (int i = 0; i < Global.count; i++)
            {
                if (Global.UAnswer[i] == 0)
                {
                    unans += (i + 1) + "  ";
                }
            }
            MessageBox.Show("尚未填寫：" + unans);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NowNum -= 1;
            if (NowNum == -1)
            {
                NowNum = Global.count-1;
            }
            changeQ();
            DeColor();
            switch(Global.UAnswer[NowNum])
            {
                case 1:
                    button4.BackColor = Color.Green;
                    break;
                case 2:
                    button5.BackColor = Color.Green;
                    break;
                case 3:
                    button6.BackColor = Color.Green;
                    break;
                case 4:
                    button7.BackColor = Color.Green;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NowNum += 1;
            if (NowNum == Global.count)
            {
                NowNum = 0;
            }
            changeQ();
            DeColor();
            switch (Global.UAnswer[NowNum])
            {
                case 1:
                    button4.BackColor = Color.Green;
                    break;
                case 2:
                    button5.BackColor = Color.Green;
                    break;
                case 3:
                    button6.BackColor = Color.Green;
                    break;
                case 4:
                    button7.BackColor = Color.Green;
                    break;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            NowNum = Convert.ToInt16(comboBox1.Text) - 1;
            changeQ();
            DeColor();
            switch (Global.UAnswer[NowNum])
            {
                case 1:
                    button4.BackColor = Color.Green;
                    break;
                case 2:
                    button5.BackColor = Color.Green;
                    break;
                case 3:
                    button6.BackColor = Color.Green;
                    break;
                case 4:
                    button7.BackColor = Color.Green;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Global.UAnswer[NowNum] = 1;
            DeColor();
            button4.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Global.UAnswer[NowNum] = 2;
            DeColor();
            button5.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Global.UAnswer[NowNum] = 3;
            DeColor();
            button6.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Global.UAnswer[NowNum] = 4;
            DeColor();
            button7.BackColor = Color.Green;
        }

        public void changeQ()
        {
            textBox3.Text = Convert.ToString(Question[QuestionR[NowNum]]);
            label5.Text = Convert.ToString(QuestionID[QuestionR[NowNum]]);
            label12.Text = Convert.ToString(C1[QuestionR[NowNum]]);
            label13.Text = Convert.ToString(C2[QuestionR[NowNum]]);
            label14.Text = Convert.ToString(C3[QuestionR[NowNum]]);
            label15.Text = Convert.ToString(C4[QuestionR[NowNum]]);
            label17.Text = Convert.ToString(NowNum + 1);
            label19.Text = Convert.ToString(Global.count);
        }

        public void DeColor()
        {
            button4.BackColor = Control.DefaultBackColor;
            button5.BackColor = Control.DefaultBackColor;
            button6.BackColor = Control.DefaultBackColor;
            button7.BackColor = Control.DefaultBackColor;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void question11800BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
