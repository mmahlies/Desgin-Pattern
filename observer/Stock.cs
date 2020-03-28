using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    /// <summary>
    /// subjects calss
    /// </summary>
    abstract class  Stock
    {
        private double _price;

        public double Price
        {
            get { return _price; }
            set {
                
                _price = value;
                Notify();
            }
        }

        private string _symbol;

        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }
        
        List<IObserver> subscriper = new List<IObserver>();
        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }
        public void Rigister(IObserver observer)
        {
            subscriper.Add(observer);
        }

        public void UnRigister(IObserver observer)
        {
            subscriper.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in subscriper)
            {
                item.Update(this);
            }
        }
    }
}
