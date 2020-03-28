using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.States;
namespace StatePattern
{
    class Machine 
    {
        public int StockCount { get; private set; }
        ICommand state;
        public Machine(int stockCount)
        {
            this.StockCount = stockCount;
            if (stockCount > 0)
            {
                this.state = new Idle();
            }
            else
            {
                this.state = new OutOfStock();
            }
            
        }

        private void OrderTheProduct()
        {
            this.StockCount--;
        }

        public void ChangeState(ICommand newState)
        {
            this.state = newState;
        }
        public void InsertDollar()
        {
            this.state.InsertDollar(this);
        }
        public void ReturnMonet()
        {
            this.state.ReturnMoney(this);
        }
        public void Dispense()
        {
            if (this.state.Dispense(this))
            {
                StockCount--;
            }  
        }
    }
}
