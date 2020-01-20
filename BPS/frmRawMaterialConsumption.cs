using System;
using System.Windows.Forms;

namespace BPS
{
    public partial class frmRawMaterialConsumption : Form
    {
        public frmRawMaterialConsumption()
        {
            InitializeComponent();
        }

        public int selectedCellar = 0;

       /* private string loadNumber()
        {



            string initial = "TMP-";
            string separator = "-";
            int newSecuencial = 0;
            int a = 0;


            batch = objTransfer.getLastBatch();

            if (batch == "")
            {
                secuencial = "0001";
                year = DateTime.Now.ToString("yy");
                month = DateTime.Now.ToString("MM");
                day = DateTime.Now.ToString("dd");
                switch (month)
                {
                    case "10":
                        month = "A";
                        break;

                    case "11":
                        month = "B";
                        break;

                    case "12":
                        month = "C";
                        break;
                    default:
                        month = month.Substring(1, 1);
                        break;

                }
                batch = initial + year + month + day + separator + secuencial;

            }
            else
            {
                year = DateTime.Now.ToString("yy");
                month = DateTime.Now.ToString("MM");
                day = DateTime.Now.ToString("dd");
                switch (month)
                {
                    case "10":
                        month = "A";
                        break;

                    case "11":
                        month = "B";
                        break;

                    case "12":
                        month = "C";
                        break;
                    default:
                        month = month.Substring(1, 1);
                        break;

                }

                secuencial = batch.Substring(10, 4);
                newSecuencial = int.Parse(secuencial);
                newSecuencial = newSecuencial + 1;
                secuencial = newSecuencial.ToString();

                a = secuencial.Length;

                switch (a)
                {
                    case 1:
                        secuencial = "000" + secuencial;
                        break;

                    case 2:
                        secuencial = "00" + secuencial;

                        break;

                    case 3:
                        secuencial = "0" + secuencial;
                        break;

                    case 4:
                        secuencial = secuencial;
                        break;

                    default:
                        break;


                }

                batch = initial + year + month + day + separator + secuencial;
            }

            return batch;


        }*/
        private void frmRawMaterialConsumption_Load(object sender, EventArgs e)
        {
            
      //      txtNumber.Text = loadNumber();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
