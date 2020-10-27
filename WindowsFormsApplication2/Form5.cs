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
    public partial class Form5 : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;                     //關閉X按鈕作用
                return myCp;
            }
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int score = 0;
            for (int i = 0;i<Global.count;i++)
            {
                if (Global.Answer[i] == Global.UAnswer[i])
                {
                    score += 5;
                }
            }
            label2.Text = Convert.ToString(score);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Global.count; i++)
            {
                if (Global.Answer[i] != Global.UAnswer[i])
                {
                    Global.WAnswer[i] = Convert.ToString(i+1);
                }
                else
                {
                    Global.WAnswer[i] = "正確";
                }
            }
            Form6 f6 = new Form6();
            f6.Visible = true;
            Close();
        }
    }
}
