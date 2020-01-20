using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmOperativeConditionsMetalized : Form
    {
        int baseCode = 0; string baseMetalCode = "";
        clsCoil maincoil = new clsCoil();
        clsProduct product = new clsProduct();
        clsMainCoilMetal maincoilmetal = new clsMainCoilMetal();
        clsBaseCoilProductionDetail productiondetail = new clsBaseCoilProductionDetail();
        public frmOperativeConditionsMetalized()
        {
            InitializeComponent();
        }
        public frmOperativeConditionsMetalized(string baseCode, string baseMetalCode)
        {
            this.baseCode = int.Parse(baseCode);
            this.baseMetalCode = baseMetalCode;
            //CargarBobinaMetalicaBase(baseMetalCode);
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        #region Cambio de colores
        private void cbC1_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC1);
        }

        public void colorChk(CheckBox chk)
        {
            if (chk.Checked == true)
                chk.BackColor = Color.Green;
            else
                chk.BackColor = Color.Red;
        }

        private void cbC11_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC11);
        }

        private void cbC2_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC2);
        }

        private void cbC12_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC12);
        }

        private void cbC3_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC3);
        }

        private void cbC13_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC13);
        }

        private void cbC4_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC4);
        }

        private void cbC14_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC14);
        }

        private void cbC5_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC5);
        }

        private void cbC19_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC19);
        }

        private void cbC21_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC21);
        }

        private void cbC22_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC22);
        }

        private void cbC23_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC23);
        }

        private void cbC24_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC24);
        }

        private void cbC25_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC25);
        }

        private void cbC15_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC15);
        }

        private void cbC6_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC6);
        }

        private void cbC16_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC16);
        }

        private void cbC26_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC26);
        }

        private void cbC27_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC27);
        }

        private void cbC17_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC17);
        }

        private void cbC7_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC7);
        }

        private void cbC8_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC8);
        }

        private void cbC18_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC18);
        }

        private void cbC28_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC28);
        }

        private void cbC29_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC29);
        }

        private void cbC9_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC9);

        }

        private void cbC10_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC10);
        }

        private void cbC20_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC20);
        }

        private void cbC30_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbC30);
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA5);
        }

        private void cbA29_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA29);
        }

        private void cbA11_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA11);
        }

        private void cbA21_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA21);
        }

        private void cbA22_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA22);
        }

        private void cbA12_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA12);
        }

        private void cbA2_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA2);
        }

        private void cbA3_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA3);
        }

        private void cbA13_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA13);
        }

        private void cbA23_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA23);
        }

        private void cbA24_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA24);
        }

        private void cbA14_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA14);
        }

        private void cbA4_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA4);
        }

        private void cbA15_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA15);
        }

        private void cbA25_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA25);
        }

        private void cbA26_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA26);
        }

        private void cbA16_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA16);
        }

        private void cbA6_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA6);
        }

        private void cbA7_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA7);
        }

        private void cbA17_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA17);
        }

        private void cbA27_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA27);
        }

        private void cbA28_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA28);
        }

        private void cbA18_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA18);
        }

        private void cbA8_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA8);
        }

        private void cbA9_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA9);
        }

        private void cbA19_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA19);
        }

        private void cbA10_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA10);
        }

        private void cbA20_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA20);
        }

        private void cbA30_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA30);
        }

        private void cbA1_CheckedChanged(object sender, EventArgs e)
        {
            colorChk(cbA1);
        }
        private void txtUnwind010_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtUnwind010);
        }

        private void txtRewind010_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtRewind010);
        }

        private void txtRewind1020_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtRewind1020);
        }

        private void txtUnwind1020_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtUnwind1020);
        }

        private void txtUnwind2030_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtUnwind2030);
        }

        private void txtRewind2030_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtRewind2030);
        }

        private void txtUnwind3040_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtUnwind3040);
        }

        private void txtRewind3040_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtRewind3040);
        }

        private void txtUnwind4050_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtUnwind4050);
        }

        private void txtRewind4050_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtRewind4050);
        }

        private void txtUnwind5060_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtUnwind5060);
        }

        private void txtRewind5060_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtRewind5060);
        }

        private void txtInicioAluminio_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtInicioAluminio);
        }

        private void txtInicioMaq_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtInicioMaq);
        }

        private void txtProceso_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtProceso);
        }

        private void txtFinal_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtFinal);
        }

        private void txtGapUnwind_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtGapUnwind);
        }

        private void txtGapRewind_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtGapRewind);
        }

        private void txtTaper_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtTaper);
        }

        private void txtTempDrum_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtTempDrum);
        }

        private void txtPosRodilloBanano_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtPosRodilloBanano);
        }

        private void txtTorque_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtTorque);

        }

        private void txtObs_MouseClick(object sender, MouseEventArgs e)
        {
            ColorTXT(txtObs);
        }
        #endregion
        #region Funciones
        public void CargarBobinaBase()
        {
            maincoil = new clsCoil(baseCode);
            product = new clsProduct(maincoil.fkProduct);
            txtCodigoBase.Text = maincoil.code;
            txtAnchoBase.Text = maincoil.width.ToString();
            txtPesoBase.Text = maincoil.netWeight.ToString();
            txtMetrajeBase.Text = maincoil.length.ToString();
            txtObsBase.Text = maincoil.notes;
            txtPeliculaBase.Text = product.boppFilmName;
            
        }
        public void CargarBobinaMetalizada()
        {
            maincoilmetal.load(baseMetalCode,false,false);
            txtCodigoMetalizada.Text = maincoilmetal.mcode;
            txtPesoMetalizada.Text = maincoilmetal.netWeigth.ToString();
            txtMetrajeMetalizada.Text = maincoilmetal.netlength.ToString();
            txtObsMetalizada.Text = maincoilmetal.notes;
        }
        public void CargarBCPD()
        {
            maincoil = new clsCoil(baseCode);
            productiondetail = new clsBaseCoilProductionDetail(maincoil.codsec);
            CargarTXT(productiondetail);
            CargarLosCHK(productiondetail);
        }
        public void CargarTXT(clsBaseCoilProductionDetail productiondetail)
        {
            txtUnwind010.Text = productiondetail.unwindTension010.ToString();
            txtUnwind1020.Text = productiondetail.unwindTension1020.ToString();
            txtUnwind2030.Text = productiondetail.unwindTension2030.ToString();
            txtUnwind3040.Text = productiondetail.unwindTension3040.ToString();
            txtUnwind4050.Text = productiondetail.unwindTension4050.ToString();
            txtUnwind5060.Text = productiondetail.unwindTension5060.ToString();
            txtRewind010.Text = productiondetail.rewindTension010.ToString();
            txtRewind1020.Text = productiondetail.rewindTension1020.ToString();
            txtRewind2030.Text = productiondetail.rewindTension2030.ToString();
            txtRewind3040.Text = productiondetail.rewindTension3040.ToString();
            txtRewind4050.Text = productiondetail.rewindTension4050.ToString();
            txtRewind5060.Text = productiondetail.rewindTension5060.ToString();
            txtGapUnwind.Text = productiondetail.gapUnwind.ToString();
            txtGapRewind.Text = productiondetail.gapRewind.ToString();
            txtTaper.Text = productiondetail.taperPercentage.ToString();
            txtTempDrum.Text = productiondetail.drumTemperature.ToString();
            txtTorque.Text = productiondetail.dtr1Torque.ToString();
            txtPosRodilloBanano.Text = productiondetail.rollerPosition.ToString();
            txtInicioAluminio.Text = productiondetail.aluminumSpeed.ToString();
            txtInicioMaq.Text = productiondetail.initSpeed.ToString();
            txtProceso.Text = productiondetail.processSpeed.ToString();
            txtFinal.Text = productiondetail.endSpeed.ToString();
            txtObs.Text = productiondetail.notes;
            for(int i=0;i<cmbModoTrabajado.Items.Count;i++)
            {
                if (cmbModoTrabajado.Items[i].ToString() == productiondetail.opticDensityMode)
                    cmbModoTrabajado.SelectedIndex = i;
            }
        }
        public void CargarLosCHK(clsBaseCoilProductionDetail productiondetail)
        {
            cbA1.Checked = productiondetail.aluminum1;
            cbA2.Checked = productiondetail.aluminum2;
            cbA3.Checked = productiondetail.aluminum3;
            cbA4.Checked = productiondetail.aluminum4;
            cbA5.Checked = productiondetail.aluminum5;
            cbA6.Checked = productiondetail.aluminum6;
            cbA7.Checked = productiondetail.aluminum7;
            cbA8.Checked = productiondetail.aluminum8;
            cbA9.Checked = productiondetail.aluminum9;
            cbA10.Checked = productiondetail.aluminum10;
            cbA11.Checked = productiondetail.aluminum11;
            cbA12.Checked = productiondetail.aluminum12;
            cbA13.Checked = productiondetail.aluminum13;
            cbA14.Checked = productiondetail.aluminum14;
            cbA15.Checked = productiondetail.aluminum15;
            cbA16.Checked = productiondetail.aluminum16;
            cbA17.Checked = productiondetail.aluminum17;
            cbA18.Checked = productiondetail.aluminum18;
            cbA19.Checked = productiondetail.aluminum19;
            cbA20.Checked = productiondetail.aluminum20;
            cbA21.Checked = productiondetail.aluminum21;
            cbA22.Checked = productiondetail.aluminum22;
            cbA23.Checked = productiondetail.aluminum23;
            cbA24.Checked = productiondetail.aluminum24;
            cbA25.Checked = productiondetail.aluminum25;
            cbA26.Checked = productiondetail.aluminum26;
            cbA27.Checked = productiondetail.aluminum27;
            cbA28.Checked = productiondetail.aluminum28;
            cbA29.Checked = productiondetail.aluminum29;
            cbA30.Checked = productiondetail.aluminum30;
            cbC1.Checked = productiondetail.ceramic1;
            cbC2.Checked = productiondetail.ceramic2;
            cbC3.Checked = productiondetail.ceramic3;
            cbC4.Checked = productiondetail.ceramic4;
            cbC5.Checked = productiondetail.ceramic5;
            cbC6.Checked = productiondetail.ceramic6;
            cbC7.Checked = productiondetail.ceramic7;
            cbC8.Checked = productiondetail.ceramic8;
            cbC9.Checked = productiondetail.ceramic9;
            cbC10.Checked = productiondetail.ceramic10;
            cbC11.Checked = productiondetail.ceramic11;
            cbC12.Checked = productiondetail.ceramic12;
            cbC13.Checked = productiondetail.ceramic13;
            cbC14.Checked = productiondetail.ceramic14;
            cbC15.Checked = productiondetail.ceramic15;
            cbC16.Checked = productiondetail.ceramic16;
            cbC17.Checked = productiondetail.ceramic17;
            cbC18.Checked = productiondetail.ceramic18;
            cbC19.Checked = productiondetail.ceramic19;
            cbC20.Checked = productiondetail.ceramic20;
            cbC21.Checked = productiondetail.ceramic21;
            cbC22.Checked = productiondetail.ceramic22;
            cbC23.Checked = productiondetail.ceramic23;
            cbC24.Checked = productiondetail.ceramic24;
            cbC25.Checked = productiondetail.ceramic25;
            cbC26.Checked = productiondetail.ceramic26;
            cbC27.Checked = productiondetail.ceramic27;
            cbC28.Checked = productiondetail.ceramic28;
            cbC29.Checked = productiondetail.ceramic29;
            cbC30.Checked = productiondetail.ceramic30;
        }
        public void CompletarObjeto()
        {
            productiondetail.fkBaseCoil = maincoil.codsec;
            productiondetail.unwindTension010 = Convert.ToInt32(txtUnwind010.Text);
            productiondetail.unwindTension1020 = Convert.ToInt32(txtUnwind1020.Text);
            productiondetail.unwindTension2030 = Convert.ToInt32(txtUnwind2030.Text);
            productiondetail.unwindTension3040 = Convert.ToInt32(txtUnwind3040.Text);
            productiondetail.unwindTension4050 = Convert.ToInt32(txtUnwind4050.Text);
            productiondetail.unwindTension5060 = Convert.ToInt32(txtUnwind5060.Text);
            productiondetail.rewindTension010 = Convert.ToInt32(txtRewind010.Text);
            productiondetail.rewindTension1020 = Convert.ToInt32(txtRewind1020.Text);
            productiondetail.rewindTension2030 = Convert.ToInt32(txtRewind2030.Text);
            productiondetail.rewindTension3040 = Convert.ToInt32(txtRewind3040.Text);
            productiondetail.rewindTension4050 = Convert.ToInt32(txtRewind4050.Text);
            productiondetail.rewindTension5060 = Convert.ToInt32(txtRewind5060.Text);
            productiondetail.gapUnwind = Convert.ToInt32(txtGapUnwind.Text);
            productiondetail.gapRewind = Convert.ToInt32(txtGapRewind.Text);
            productiondetail.taperPercentage = float.Parse(txtTaper.Text);
            productiondetail.drumTemperature = float.Parse(txtTempDrum.Text);
            productiondetail.dtr1Torque = Convert.ToInt32(txtTorque.Text);
            productiondetail.rollerPosition = Convert.ToInt32(txtPosRodilloBanano.Text);
            productiondetail.opticDensityMode = cmbModoTrabajado.Text;
            productiondetail.aluminumSpeed = Convert.ToInt32(txtInicioAluminio.Text);
            productiondetail.aluminum1 = cbA1.Checked;
            productiondetail.aluminum2 = cbA2.Checked;
            productiondetail.aluminum3 = cbA3.Checked;
            productiondetail.aluminum4 = cbA4.Checked;
            productiondetail.aluminum5 = cbA5.Checked;
            productiondetail.aluminum6 = cbA6.Checked;
            productiondetail.aluminum7 = cbA7.Checked;
            productiondetail.aluminum8 = cbA8.Checked;
            productiondetail.aluminum9 = cbA9.Checked;
            productiondetail.aluminum10 = cbA10.Checked;
            productiondetail.aluminum11 = cbA11.Checked;
            productiondetail.aluminum12 = cbA12.Checked;
            productiondetail.aluminum13 = cbA13.Checked;
            productiondetail.aluminum14 = cbA14.Checked;
            productiondetail.aluminum15 = cbA15.Checked;
            productiondetail.aluminum16 = cbA16.Checked;
            productiondetail.aluminum17 = cbA17.Checked;
            productiondetail.aluminum18 = cbA18.Checked;
            productiondetail.aluminum19 = cbA19.Checked;
            productiondetail.aluminum20 = cbA20.Checked;
            productiondetail.aluminum21 = cbA21.Checked;
            productiondetail.aluminum22 = cbA22.Checked;
            productiondetail.aluminum23 = cbA23.Checked;
            productiondetail.aluminum24 = cbA24.Checked;
            productiondetail.aluminum25 = cbA25.Checked;
            productiondetail.aluminum26 = cbA26.Checked;
            productiondetail.aluminum27 = cbA27.Checked;
            productiondetail.aluminum28 = cbA28.Checked;
            productiondetail.aluminum29 = cbA29.Checked;
            productiondetail.aluminum30 = cbA30.Checked;
            productiondetail.ceramic1 = cbC1.Checked;
            productiondetail.ceramic2 = cbC2.Checked;
            productiondetail.ceramic3 = cbC3.Checked;
            productiondetail.ceramic4 = cbC4.Checked;
            productiondetail.ceramic5 = cbC5.Checked;
            productiondetail.ceramic6 = cbC6.Checked;
            productiondetail.ceramic7 = cbC7.Checked;
            productiondetail.ceramic8 = cbC8.Checked;
            productiondetail.ceramic9 = cbC9.Checked;
            productiondetail.ceramic10 = cbC10.Checked;
            productiondetail.ceramic11 = cbC11.Checked;
            productiondetail.ceramic12 = cbC12.Checked;
            productiondetail.ceramic13 = cbC13.Checked;
            productiondetail.ceramic14 = cbC14.Checked;
            productiondetail.ceramic15 = cbC15.Checked;
            productiondetail.ceramic16 = cbC16.Checked;
            productiondetail.ceramic17 = cbC17.Checked;
            productiondetail.ceramic18 = cbC18.Checked;
            productiondetail.ceramic19 = cbC19.Checked;
            productiondetail.ceramic20 = cbC20.Checked;
            productiondetail.ceramic21 = cbC21.Checked;
            productiondetail.ceramic22 = cbC22.Checked;
            productiondetail.ceramic23 = cbC23.Checked;
            productiondetail.ceramic24 = cbC24.Checked;
            productiondetail.ceramic25 = cbC25.Checked;
            productiondetail.ceramic26 = cbC26.Checked;
            productiondetail.ceramic27 = cbC27.Checked;
            productiondetail.ceramic28 = cbC28.Checked;
            productiondetail.ceramic29 = cbC29.Checked;
            productiondetail.ceramic30 = cbC30.Checked;
            productiondetail.initSpeed = Convert.ToInt32(txtInicioAluminio.Text);
            productiondetail.processSpeed = Convert.ToInt32(txtProceso.Text);
            productiondetail.endSpeed = Convert.ToInt32(txtFinal.Text);
            productiondetail.linearLength = Convert.ToInt32(txtMetrajeBase.Text);
            productiondetail.metalWeigth = Convert.ToInt32(txtPesoMetalizada.Text);
            productiondetail.MainCoilMetal = txtCodigoMetalizada.Text;
            productiondetail.notes = txtObs.Text;
            maincoilmetal.netlength = double.Parse(txtMetrajeMetalizada.Text);
            maincoilmetal.notes = txtObsMetalizada.Text;
        }
        #endregion
        private void frmOperativeConditionsMetalized_Load(object sender, EventArgs e)
        {
            CargarBobinaBase();
            CargarBobinaMetalizada();
            CargarBCPD();
        }
        #region Validaciones
        public bool ValidarCampos()
        {
            bool bandera = true;
            if (txtUnwind010.Text == "")
            {
                txtUnwind010.BackColor = Color.Red;
                bandera = false;
            }
            if (txtUnwind1020.Text == "")
            {
                txtUnwind1020.BackColor = Color.Red;
                bandera = false;
            }
            if (txtUnwind2030.Text == "")
            {
                txtUnwind2030.BackColor = Color.Red;
                bandera = false;
            }
            if (txtUnwind3040.Text == "")
            {
                txtUnwind3040.BackColor = Color.Red;
                bandera = false;
            }
            if (txtUnwind4050.Text == "")
            {
                txtUnwind4050.BackColor = Color.Red;
                bandera = false;
            }
            if (txtUnwind5060.Text == "")
            {
                txtUnwind5060.BackColor = Color.Red;
                bandera = false;
            }
            if (txtRewind010.Text == "")
            {
                txtRewind010.BackColor = Color.Red;
                bandera = false;
            }
            if (txtRewind1020.Text == "")
            {
                txtRewind1020.BackColor = Color.Red;
                bandera = false;
            }
            if (txtRewind2030.Text == "")
            {
                txtRewind2030.BackColor = Color.Red;
                bandera = false;
            }
            if (txtRewind3040.Text == "")
            {
                txtRewind3040.BackColor = Color.Red;
                bandera = false;
            }
            if (txtRewind4050.Text == "")
            {
                txtRewind4050.BackColor = Color.Red;
                bandera = false;
            }
            if (txtRewind5060.Text == "")
            {
                txtRewind5060.BackColor = Color.Red;
                bandera = false;
            }
            if(txtInicioAluminio.Text == "")
            {
                txtInicioAluminio.BackColor = Color.Red;
                bandera = false;
            }
            if (txtInicioMaq.Text == "")
            {
                txtInicioMaq.BackColor = Color.Red;
                bandera = false;
            }
            if (txtProceso.Text == "")
            {
                txtProceso.BackColor = Color.Red;
                bandera = false;
            }
            if (txtFinal.Text == "")
            {
                txtFinal.BackColor = Color.Red;
                bandera = false;
            }
            if (txtGapRewind.Text == "")
            {
                txtGapRewind.BackColor = Color.Red;
                bandera = false;
            }
            if (txtGapUnwind.Text == "")
            {
                txtGapUnwind.BackColor = Color.Red;
                bandera = false;
            }
            if (txtTaper.Text == "")
            {
                txtTaper.BackColor = Color.Red;
                bandera = false;
            }
            if (txtTempDrum.Text == "")
            {
                txtTempDrum.BackColor = Color.Red;
                bandera = false;
            }
            if (txtPosRodilloBanano.Text == "")
            {
                txtPosRodilloBanano.BackColor = Color.Red;
                bandera = false;
            }
            if (txtTorque.Text == "")
            {
                txtTorque.BackColor = Color.Red;
                bandera = false;
            }
            if(cmbModoTrabajado.Text=="")
            {
                cmbModoTrabajado.BackColor = Color.Red;
                bandera = false;
            }
            return bandera;
        }
        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                CompletarObjeto();
                if (productiondetail.save() && maincoilmetal.UpdateLengthAndObs())
                    MessageBox.Show("Operacion guardada con exito!");
                else
                    MessageBox.Show("Error al guardar!");
                this.Close();
            }
        }
        public void ColorTXT(TextBox txt)
        {
            txt.BackColor = Color.White;
        }

        private void cmbModoTrabajado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModoTrabajado.BackColor = Color.White;
        }

        private void cmbModoTrabajado_MouseClick(object sender, MouseEventArgs e)
        {
            cmbModoTrabajado.BackColor = Color.White;
        }
        
    }
}
