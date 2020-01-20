using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsBaseToMetalEquivalence
    {
        private int btme_codsec;
        private int btme_baseInit;
        private int btme_metalfinal;


        public int codsec
        {
            get { return btme_codsec; }
            set { btme_codsec = value; }
        }

        public int baseInit
        {
            get { return btme_baseInit; }
            set { btme_baseInit = value; }
        }

        public int metalfinal
        {
            get { return btme_metalfinal; }
            set { btme_metalfinal = value; }
        }
    }
}
