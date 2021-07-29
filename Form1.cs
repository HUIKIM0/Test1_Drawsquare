using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {

        //x 4개 y 2개 z 2개
        int x1 = 80, y1 = 90;
        int x2 = 180, y2 = 120, x3 = 120, x4 = 220;


        int z1 = 190, z2 = 220;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int x = int.Parse(txtX.Text);
                int y = int.Parse(txtY.Text);
                int z = int.Parse(txtZ.Text);


                //la1.Text = x.ToString();
                la1.Text = string.Format("가로(x) : " + x.ToString());
                la2.Text = string.Format("세로(y) : " + y.ToString());
                la3.Text = string.Format("높이(z) : " + z.ToString());


                //Panel1에 그려주기
                Graphics g = panel1.CreateGraphics();
                Pen pen1 = new Pen(Color.Red);


                x2 = x1 + x;
               // x4 = x3 + x;

                z1 = z1 + z;
                z2 = z2 + z;

                x3 = x1 + y;
                x4 = x2 + y;



                //뒤쪽 도형
                g.DrawLine(pen1, x1, y1, x2, y1);  //첫째점x,첫째점y,둘째점x,둘째점y (선 긋기)
                g.DrawLine(pen1, x1, y1, x1, z1);
                g.DrawLine(pen1, x1, z1, x2, z1);
                g.DrawLine(pen1, x2, y1, x2, z1);


                //앞쪽 도형
                g.DrawLine(pen1, x3, y2, x4, y2);
                g.DrawLine(pen1, x3, y2, x3, z2);
                g.DrawLine(pen1, x3, z2, x4, z2);
                g.DrawLine(pen1, x4, y2, x4, z2);


                //도형 이어주는 선
                g.DrawLine(pen1, x1, y1, x3, y2);
                g.DrawLine(pen1, x1, z1, x3, z2);
                g.DrawLine(pen1, x2, z1, x4, z2);
                g.DrawLine(pen1, x2, y1, x4, y2);


                pen1.Dispose();


                txtX.Clear();
                txtY.Clear();
                txtZ.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("가로,세로,높이 값을 입력해주세요");
                //throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fClearPanel();
        }

        private void fClearPanel()
        {
            panel1.Invalidate();
            Refresh();
        }

    }
}