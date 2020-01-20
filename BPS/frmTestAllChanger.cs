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
	public partial class frmTestAllChanger : Form
	{
		public frmTestAllChanger()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
		    ExitBackloadPallet();
			//ChangeCellarPallet();
			//ReDeliveryPallet();
            //ReDeliveryCoil();
		}

        private void ReDeliveryCoil()
        {
            List<string> lstCoilCode = new List<string>();
            lstCoilCode.Add("13124211139429");
            lstCoilCode.Add("13131110156183");
            for (int i = 0; i < lstCoilCode.Count; i++)
            {
                clsCoil ObjCoil = new clsCoil();
                ObjCoil = clsCoil.getDetailByCode(lstCoilCode[i].ToString());
                clsCoil.cancelTransferTo(ObjCoil.codsec, 2);
                clsCoil.setCoilAsReDelivered(ObjCoil);
                clsCoil.dropCoilBySalesOrderForReDelivery(ObjCoil.codsec);
            }
            MessageBox.Show("OK");
        }

		private void ReDeliveryPallet()
		{
			List<string> lstPalletCode = new List<string>();
            lstPalletCode.Add("12C29010320931");

            //lstPalletCode.Add("12C27020420815");

            //lstPalletCode.Add("12C27010420813");
            //lstPalletCode.Add("12C2702410815");
            //lstPalletCode.Add("12C27030420816");
            //lstPalletCode.Add("12C27040420817");
            //lstPalletCode.Add("12A22020116164");
            //lstPalletCode.Add("1321001011998");
            //lstPalletCode.Add("1321102042040");
            //lstPalletCode.Add("12C24020220068");
            //lstPalletCode.Add("1310801090291");
            //lstPalletCode.Add("12C24020220068");
            //lstPalletCode.Add("12C26020120083");
            //lstPalletCode.Add("12C23010620032");
            //lstPalletCode.Add("12C21040219908");
            //lstPalletCode.Add("12C24010620060");
            //lstPalletCode.Add("12C24020620061");
            //lstPalletCode.Add("12C24030620062");
            //lstPalletCode.Add("12C24040620066");
            //lstPalletCode.Add("12C25050620070");
            //lstPalletCode.Add("12C25060620072");
            //lstPalletCode.Add("12C25070620074");
            //lstPalletCode.Add("12C25080620075");
            //lstPalletCode.Add("12C25090620076");
            //lstPalletCode.Add("12C26100420089");
            //lstPalletCode.Add("12C20080619870");
            //lstPalletCode.Add("12C20090619874");
            //lstPalletCode.Add("12C20100419875");
            //lstPalletCode.Add("12C21110119953");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("");

			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			clsPallet.setUpdateStatusWhenNotDeliveryPallet(lstPalletCode);
            MessageBox.Show("OK");
		}

		private void ChangeCellarPallet()
		{
			int stocklocal = 4;
			int productoterminado = 3;

			//para STOCK LOCAL
			List<string> lstPalletCode = new List<string>();
			lstPalletCode.Add("12801010411415");
			lstPalletCode.Add("12822080412682");
			lstPalletCode.Add("1270500059890");
			lstPalletCode.Add("12807000511767");
			lstPalletCode.Add("12807000511769");
			lstPalletCode.Add("1222303022552");
			lstPalletCode.Add("1270500059890");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			
			for (int i = 0; i < lstPalletCode.Count; i++)
			{
				clsPallet ObjPallet = new clsPallet();
				ObjPallet = clsPallet.getDetailByCode(lstPalletCode[i]);
				for (int j = 0; j < ObjPallet.lstCoil.Count; j++)
				{
					clsCoilByCoilCellar ObjCoilCellar = new clsCoilByCoilCellar();
					ObjCoilCellar.load(ObjPallet.lstCoil[j].codsec);
					ObjCoilCellar.fkCoilCellar = stocklocal;
					ObjCoilCellar.save();
				}
			}

			////para STOCK PERU
			//List<string> lstPalletCode = new List<string>();
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");

			//for (int i = 0; i < lstPalletCode.Count; i++)
			//{
			//    clsPallet ObjPallet = new clsPallet();
			//    ObjPallet = clsPallet.getDetailByCode(lstPalletCode[i]);
			//    for (int j = 0; j < ObjPallet.lstCoil.Count; j++)
			//    {
			//        clsCoilByCoilCellar ObjCoilCellar = new clsCoilByCoilCellar();
			//        ObjCoilCellar.load(ObjPallet.lstCoil[j].codsec);
			//        ObjCoilCellar.fkCoilCellar = stocklocal;
			//        ObjCoilCellar.save();
			//    }
			//}

			//para PRODUCTO TERMINADO
			List<string> lstPalletCodePT = new List<string>();
			lstPalletCodePT.Add("12807040111774");
			lstPalletCodePT.Add("12807030411773");
			lstPalletCodePT.Add("12826010812939");
			lstPalletCodePT.Add("12826020812949");
			lstPalletCodePT.Add("12915020313891");
			lstPalletCodePT.Add("12801010411415");
			lstPalletCodePT.Add("12822080412682");
			lstPalletCodePT.Add("1270201109721");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");

			for (int i = 0; i < lstPalletCodePT.Count; i++)
			{
				clsPallet ObjPallet = new clsPallet();
				ObjPallet = clsPallet.getDetailByCode(lstPalletCodePT[i]);
				for (int j = 0; j < ObjPallet.lstCoil.Count; j++)
				{
					clsCoilByCoilCellar ObjCoilCellar = new clsCoilByCoilCellar();
					ObjCoilCellar.load(ObjPallet.lstCoil[j].codsec);
					ObjCoilCellar.fkCoilCellar = productoterminado;
					ObjCoilCellar.save();
				}
			}
			
		}

		private void ExitBackloadPallet()
		{
			List<string> lstPalletCode = new List<string>();

            lstPalletCode.Add("SCOO25111500023900004");
            lstPalletCode.Add("SCOO25111500023900006");
            lstPalletCode.Add("SCOO25111500023900007");
            lstPalletCode.Add("SCOO25111500023900008");
            lstPalletCode.Add("SCOO25111500023900009");
            lstPalletCode.Add("SCOO25111500023900010");
            lstPalletCode.Add("SCOO25111500023900011");
            lstPalletCode.Add("SCOO25111500023900012");
            lstPalletCode.Add("SCOO25111500023900013");
            lstPalletCode.Add("SCOO25111500023900014");
            lstPalletCode.Add("SCOO25111500023900017");
            lstPalletCode.Add("SCOO25111500023900019");
            lstPalletCode.Add("SCOO20115000023900001");
            lstPalletCode.Add("SCOO20115000023900002");
            lstPalletCode.Add("SCOO20115000023900003");
            lstPalletCode.Add("SCOO20115000023900004");
            lstPalletCode.Add("SCOO20115000023900005");
            lstPalletCode.Add("SCOO20115000023900006");
            lstPalletCode.Add("SCOO20115000023900007");
            lstPalletCode.Add("SCOO20115000023900008");
            lstPalletCode.Add("SCOO20115000023900009");
            lstPalletCode.Add("SCOO20115000023900010");
            lstPalletCode.Add("SCOO20115000023900011");
            lstPalletCode.Add("SCOO20115000023900012");
            lstPalletCode.Add("SCOO20115000023900013");
            lstPalletCode.Add("SCOO20115000023900014");
            lstPalletCode.Add("SCOO20115000023900015");
            lstPalletCode.Add("SCOO25091500023900002");
            lstPalletCode.Add("SCOO25091500023900003");
            lstPalletCode.Add("SCOO25091500023900001");
            lstPalletCode.Add("SCOO20115000023900017");
            lstPalletCode.Add("SCOO20115000023900018");
            lstPalletCode.Add("SCOO20115000023900019");
            lstPalletCode.Add("SCOO20115000023900020");
            lstPalletCode.Add("SCOO20115000023900021");
            lstPalletCode.Add("SCOO20115000023900022");
            lstPalletCode.Add("SCOO20115000023900023");
            lstPalletCode.Add("SCOO20115000023900024");
            lstPalletCode.Add("SCOO20115000023900025");
            lstPalletCode.Add("SCOO20115000023900026");
            lstPalletCode.Add("SCOO20115000023900016");
            lstPalletCode.Add("SCOO20115000023900028");
            lstPalletCode.Add("SCOO20115000023900029");
            lstPalletCode.Add("SCOO25111500023900026");
            lstPalletCode.Add("SCOO25111500023900001");
            lstPalletCode.Add("SCOO25111500023900003");
            lstPalletCode.Add("SCOO25111500023900005");
            lstPalletCode.Add("SCOO25111500023900018");
            lstPalletCode.Add("SCOO25111500023900020");
            lstPalletCode.Add("SCOO25111500023900021");
            lstPalletCode.Add("SCOO25111500023900023");
            lstPalletCode.Add("SCOO25111500023900024");
            lstPalletCode.Add("SCOO25111500023900025");
            lstPalletCode.Add("SCOO25111500023900015");
            lstPalletCode.Add("SCOO25111500023900016");
            lstPalletCode.Add("SCOO25111500023900022");

            //lstPalletCode.Add("1241400015388");
            //lstPalletCode.Add("1211400010590");
            //lstPalletCode.Add("1261300018604");
            //lstPalletCode.Add("12929000414757");
            //lstPalletCode.Add("1220300011514");
            //lstPalletCode.Add("1232200024124");
            //lstPalletCode.Add("12828000113018");
            //lstPalletCode.Add("1262800019463");
            //lstPalletCode.Add("12913000113834");
            //lstPalletCode.Add("12816000112281");
            //lstPalletCode.Add("12919020314070");
            //lstPalletCode.Add("12921291814225");
            //lstPalletCode.Add("12921211814201");
            //lstPalletCode.Add("12802000411503");
            //lstPalletCode.Add("12803000411515");
            //lstPalletCode.Add("12910010413665");          
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");
			//lstPalletCode.Add("");

			clsPallet.setUpdateStatusWhenDeliveryPallet(lstPalletCode);
            MessageBox.Show("OK");
		}
	}
}
