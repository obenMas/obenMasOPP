using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmExportPalletShippingRar : Form
    {
        public frmExportPalletShippingRar()
        {
            InitializeComponent();
        }

        public frmExportPalletShippingRar(List<clsPalletbyCoilCellar> lstPalletByCoilCellar)
        {
            InitializeComponent();
            PopulateData(lstPalletByCoilCellar);
        }

        private void PopulateData(List<clsPalletbyCoilCellar> lstPalletByCoilCellar)
        {
            List<string> lstProduct = new List<string>();
            List<int> lstWidth = new List<int>();
            List<string> lstOrder = new List<string>();

            for (int i = 0; i < lstPalletByCoilCellar.Count; i++)
            {
                lstProduct.Add(lstPalletByCoilCellar[i].siigoCode);
                lstWidth.Add(Convert.ToInt32(lstPalletByCoilCellar[i].width));
                lstOrder.Add(lstPalletByCoilCellar[i].order);
            }

            lstProduct = lstProduct.Distinct().ToList();
            lstOrder = lstOrder.Distinct().ToList();
            

            //var result = (from pallet in lstPalletByCoilCellar
            //              group pallet by pallet.siigoCellar into 

            //var groupByProv = lstPalletByCoilCellar.GroupBy
            //    (g => g.siigoCellar,
            //    g => g.siigoCode,

            for (int i = 0; i < lstPalletByCoilCellar.Count; i++)
            {
                for (int j = 0; j < lstProduct.Count; j++)
                {
                    for (int k = 0; k < lstOrder.Count; k++)
                    {
                        
                    }
                }
            }
        }
    }
}
