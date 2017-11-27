using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class ClsSpecialBanking : ClsBanking
    {

        public void M1()
        {

        }

        public override decimal Deposit(decimal money)
        {
            this.m_Balance = this.m_Balance + money - 100;

            return this.m_Balance;
        }

        public override decimal Withdraw(decimal money)
        {
            if (this.m_Balance - money - 100 < 0)
            {
                throw new Exception("餘額不足....");
            }
            this.m_Balance = this.m_Balance-  money - 100;
            return this.m_Balance;

        }
        public override string ToString()
        {
            return ".........ClsSpecialBanking..." + this.Balance;
        }


    }
}
