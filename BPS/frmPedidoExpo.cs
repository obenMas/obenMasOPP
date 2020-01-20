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
    public partial class frmPedidoExpo : Form
    {
        public frmPedidoExpo()
        {
            InitializeComponent();
            llenarComboDiametro();
            llenarComboCore();
        }

        private void llenarComboDiametro()
        {
            List<clsDiameter> listaDiam = clsDiameter.getList();

            cmbDiametro.Items.Clear();

            for(int i=0;i<listaDiam.Count;i++)
            {
                cmbDiametro.Items.Add(listaDiam[i].name);
            }
        }

        private void llenarComboCore()
        {
            List<clsCore> listaCore = clsCore.getList();

            cmbCore.Items.Clear();

            for (int i = 0; i < listaCore.Count; i++)
            {
                cmbCore.Items.Add(listaCore[i].value);
            }
        }

        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFamilia.SelectedIndex!=-1)
            {
                cmbPelicula.Items.Clear();

                switch(cmbFamilia.Items[cmbFamilia.SelectedIndex].ToString())
                {
                    case "BOPP":
                        List<clsBopp> listaBopp = clsBopp.getList();
                        for (int i = 0; i < listaBopp.Count;i++)
                        {
                            cmbPelicula.Items.Add(listaBopp[i].code);
                        }
                        break;

                    case "CAST":
                        List<clsCast> listaCast = clsCast.getList();
                        for (int i = 0; i < listaCast.Count;i++)
                        {
                            cmbPelicula.Items.Add(listaCast[i].code);
                        }
                        break;

                    case "COATING":
                        List<clsCoating> listaCoat = clsCoating.getList();
                        for (int i = 0; i < listaCoat.Count;i++)
                        {
                            cmbPelicula.Items.Add(listaCoat[i].code);
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
