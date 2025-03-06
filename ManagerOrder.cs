using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO_Lanchonete
{
    public class ManagerOrder
    {
        public Dictionary<long, Product> products;
        private static long currentId = 0;

        public ManagerOrder()
        {
            this.products = new Dictionary<long, Product>();
        }

        //ADD no main
        public void AddOrder(int id, Product product)
        {
            long idOrder = currentId++;

        }

        public void RemoveOrder(int id)
        {
            products.Remove(id);
        }



    }
}
