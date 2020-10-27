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
    public partial class Form3 : Form
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

        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "第一題組：電腦概論":
                    Global.open = 1;
                    Global.end = 305;
                    Global.time = 20;
                    Global.count = 20;
                    Form4 f4 = new Form4();
                    f4.Visible = true;
                    Close();
                    break;

                default:
                    MessageBox.Show("未添加題庫！");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                default:
                    MessageBox.Show("未添加題庫！");
                    break;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
