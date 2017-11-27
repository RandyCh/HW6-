using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking;
using OOP;

namespace WindowsFormsApp1
{
    public partial class Form1 :  FrmLogo
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            global::Banking.ClsBanking a = new Banking.ClsBanking();
            MessageBox.Show("a balance = " + a.Deposit(1000));


            ClsSpecialBanking b = new ClsSpecialBanking();
            MessageBox.Show("b balance =" + b.Deposit(1000));



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Title = "1111";

            this.Color2 = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.northwindDataSet1.Products);
            this.dataGridView1.DataSource = this.northwindDataSet1.Products;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            global::ClassLibrary2.ClsProduct x = new ClassLibrary2.ClsProduct();
            this.dataGridView1.DataSource = x.GetProducts();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            global::ClassLibrary2.ClsCategories x = new ClassLibrary2.ClsCategories();
            this.dataGridView1.DataSource = x.GetCategoryList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            global::ClassLibrary2.ClsCategories x = new ClassLibrary2.ClsCategories();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            global::ClassLibrary2.ClsProduct x = new ClassLibrary2.ClsProduct();
            this.dataGridView1.DataSource = x.GetProductsByCategoryID(comboBox1.SelectedIndex+1);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
