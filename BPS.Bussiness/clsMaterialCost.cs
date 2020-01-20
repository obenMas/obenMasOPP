using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsMaterialCost
    {
        private int mc_fkMachine;
        private int mc_fkBopp;
        private double mc_subtotal;

        public int fkBopp { get { return mc_fkBopp; } set { mc_fkBopp = value; } }
        public double subtotal { get { return mc_subtotal; } set { mc_subtotal = value; } }
        public int fkMachine { get { return mc_fkMachine; } set { mc_fkMachine = value; } }

        public clsMaterialCost()
        {
            fkBopp = 0;
            subtotal = 0;
            fkMachine = 0;
        }
    }
}
