using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace OOP
{
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();

            this.Paint += FrmLogo_Paint;
            this.Resize += FrmLogo_Resize;

            this.Color1 = Color.Black;
            this.Color2 = Color.Blue;
        }

        private void FrmLogo_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); //=>Paint Event
        }

        private void FrmLogo_Paint(object sender, PaintEventArgs e)
        {
            //GDI + 
            Graphics g = e.Graphics;

            //SolidBrush brush1 = new SolidBrush(Color.Blue);
            Point pt1 = new Point(0, 0);

            Point pt2 = new Point(0, this.ClientRectangle.Height);

            LinearGradientBrush brush1 = new LinearGradientBrush(pt1, pt2, this.Color1, this.Color2);

            g.FillRectangle(brush1, this.ClientRectangle);

        }

        protected string Title
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text  =  value;
            }
        }


        public Color Color1 { get; set; }

        private Color m_Color2;
        public Color Color2
        {
          
            get
            {
                return m_Color2;
             }
            set
            {
               this.m_Color2 =  value;

                this.Invalidate();
            }

        }


        private int m_P1;
        public int P1
        {
            set
            {
                //P1 =  value;  //StackOverflowException
                m_P1 = value;
            }
        }

        public void Test()
        {
            //Recursive
            Test();
        }
     
    }
}
