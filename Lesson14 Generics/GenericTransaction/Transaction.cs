using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTransaction
{

   public class Transaction<T> where T : IAccount
    {        
        public void Transact(T donor, T acceptor, double value)
        {
            donor.Account -= value;
            acceptor.Account += value;
        }
    }
}
