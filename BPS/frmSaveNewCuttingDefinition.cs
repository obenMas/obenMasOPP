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
    public partial class frmSaveNewCuttingDefinition : Form
    {
        clsCuttingDefinition objCutt = new clsCuttingDefinition();
        List<clsBopp> filmList = new List<clsBopp>();

        public frmSaveNewCuttingDefinition()
        {
            InitializeComponent();
            populateCmbFilm();

            objCutt.film = "SC020";
            objCutt.quantity = 100000;
            objCutt.margin = 0.1;
            objCutt.fkPlant = 3;
            objCutt.date = DateTime.Now;
            objCutt.status = "Abierta";
            objCutt.save();
            objCutt.codsec = clsCuttingDefinition.getLastCodsec();
        }

        public void populateCmbFilm()
        {
            filmList= getBoppList();
            for(int i=0; i< filmList.Count ; i++)
            {
                cmbFilm.Items.Add(filmList[i].code);
            }
        }

        public List<clsBopp> getBoppList()
        {
            DataSet DS = new DataSet();
            List<clsBopp> boppList = new List<clsBopp>();
            DS = clsConnection.getDataSetResult("SELECT bopp_code AS Película FROM bps_prod_bopp ORDER BY Película ASC");

            boppList.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                boppList.Add(new clsBopp());
                boppList[i].code = DS.Tables[0].Rows[i]["Película"].ToString();
            }
            return boppList;
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsPlant objPLant = new clsPlant(cmbPlant.SelectedItem.ToString());
            objCutt.film = cmbFilm.SelectedItem.ToString();
            objCutt.quantity = Convert.ToDouble(txtQuantity.Text);
            objCutt.margin = Convert.ToDouble(txtMargin.Text);
            objCutt.date = Convert.ToDateTime(txtEstimatedStart.Text);
            objCutt.status = cmbStatus.SelectedItem.ToString();
            objCutt.fkPlant = objPLant.codsec;
            objCutt.save();

            MessageBox.Show("Los datos fueron guardados correctamente.", "Definición de corte.", MessageBoxButtons.OK);

            this.Close();


        }


        }
}
