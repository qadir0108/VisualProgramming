using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Interfaces.Example1
{
    public interface ITransaction
    {
        // interface members
        void showTransaction();
        double getAmount();
    }
}
