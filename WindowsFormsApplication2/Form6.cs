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

    public partial class Form6 : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;                    //關閉X按鈕作用
                return myCp;
            }
        }

        int NowNum = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Global.WAnswer;
            comboBox1.SelectedIndex = 0;
            changeQ();

            if (Global.UAnswer[NowNum] == 0)
            {
                label2.Text = "無";
            }
            else
            {
                label2.Text = Convert.ToString(Global.UAnswer[NowNum]);
            }

            if (label4.Text != label2.Text)
            {
                label2.ForeColor = Color.Red;
                label5.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NowNum -= 1;

            if (NowNum == -1)
            {
                NowNum = Global.count - 1;
            }

            changeQ();

            if (Global.UAnswer[NowNum] == 0)
            {
                label2.Text = "無";
            }
            else
            {
                label2.Text = Convert.ToString(Global.UAnswer[NowNum]);
            }

            label2.ForeColor = Control.DefaultForeColor;

            if (label4.Text != label2.Text)
            {
                label2.ForeColor = Color.Red;
                label5.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NowNum += 1;

            if (NowNum == Global.count)
            {
                NowNum = 0;
            }

            changeQ();
            
            if (Global.UAnswer[NowNum] == 0)
            {
                label2.Text = "無";
            }
            else
            {
                label2.Text = Convert.ToString(Global.UAnswer[NowNum]);
            }

            label2.ForeColor = Control.DefaultForeColor;

            if (label4.Text != label2.Text)
            {
                label2.ForeColor = Color.Red;
                label5.Visible = true;
            }
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            NowNum = Convert.ToInt16(comboBox1.SelectedIndex);
            changeQ();
            if (label4.Text != label2.Text)
            {
                label2.ForeColor = Color.Red;
                label5.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            Close();
        }

        public void changeQ()
        {
            textBox3.Text = Convert.ToString(Global.Question[Global.QuestionR[NowNum]]);
            label4.Text = Convert.ToString(Global.Answer[NowNum]);
            label12.Text = Convert.ToString(Global.C1[Global.QuestionR[NowNum]]);
            label13.Text = Convert.ToString(Global.C2[Global.QuestionR[NowNum]]);
            label14.Text = Convert.ToString(Global.C3[Global.QuestionR[NowNum]]);
            label15.Text = Convert.ToString(Global.C4[Global.QuestionR[NowNum]]);
            label17.Text = Convert.ToString(NowNum + 1);
            label19.Text = Convert.ToString(Global.count);
            label5.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
