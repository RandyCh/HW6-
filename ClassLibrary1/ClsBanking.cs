using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//
//using System.Windows.Forms;

namespace Banking
{
   public  class ClsBanking : Object
    {

        public ClsBanking()
        {
            //Initialize...
            this.m_Balance = 0;
        }

        public ClsBanking(decimal money)
        {
            this.m_Balance += money;
        }

        ~ClsBanking()
        {
            //......finalize..
            //MessageBox.Show("Destructor Finalize");
            Debug.WriteLine("Destructor Finalize");
        }

        public void Dispose()
        {
            //...
            Debug.WriteLine("Dispose Finalize");

        }
        //Field - Class Var.
        //internal decimal Balance = 0;


        //Property 
        protected decimal m_Balance;
        public decimal Balance
        {
            get
            {
                //.............
                return m_Balance;
            }
            set

            {
                //..........
                if (value >=0)
                {
                    m_Balance =  value;
                }
              
            }
        }

        public void Test()
        {
            A();
            B();
            C();
        }

        public void Test(int  i)
        {

        }

        public void Test (int i, int j)
        {

        }
        public void Test(string s)
        {

        }

        private void A()
        {
            
        }
        private void B()
        {

        }
        private void C()
        {

        }

        //ReadOnly Property


        public int P1
        {
            get
            {
                //.....
                return 999;
            }
        }

        int m_P2;
        /// <summary>
        /// 
        /// </summary>
        public int P2
        {
            set
            {
                //.....
                m_P2 =  value;
            }
        }

        private int[] nums = { 101, 44,  2, 3 };

        /// <summary>
        /// Indexer.....
        /// </summary>
        /// <param name="i">i ......</param>
        /// <returns>return ......</returns>
        /// <exception cref="IndexOutOfRangeException"> Index out of range ....  </exception>
        public int this[int i]
        {
            get
            {
                if (i < 0 || i > nums.Length - 1)

                    throw new IndexOutOfRangeException("index out of range.......");

                return nums[i];
            }

        }

        public int this[string s]
        {
            get
            {
                int i = int.Parse(s);
                if (i < 0 || i > nums.Length - 1)

                    throw new IndexOutOfRangeException("index out of range.......");

                return nums[i];
            }

        }

       internal int P3 { get; set; }

        public int P4
        {
           get
            {
                return 999;
            }
             private set
            {
                //....
               // value
            }
          
        }


        public static double InterestRate
        {
            get
            {
                //.......codes....
                return 3.5;
            }
        }
        public virtual decimal Deposit (decimal money)
        {
            this.m_Balance += money;
            return this.m_Balance;

        }
        public virtual decimal Withdraw(decimal money)
        {
             if (this.m_Balance- money<0)
            {
                throw new Exception("餘額不足....");
            }
            this.m_Balance -= money;
            return this.m_Balance;

        }

        public override string ToString()
        {
            return ".........ClsBanking..." + this.Balance;
        }


    }


}
