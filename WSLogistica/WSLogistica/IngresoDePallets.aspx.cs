using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Ingreso_de_pallets : System.Web.UI.Page
{
    List<clsPalletWS> lista = new List<clsPalletWS>();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        clsPalletWS pallet = new clsPalletWS(txtCode.Text);

        lista.Add(pallet);

        populateGrid();
    }

    protected void populateGrid()
    {
        DataSet DS = new DataSet();

        for(int i=0;i<lista.Count;i++)
        {
            if(i==0)
            {
                DS = lista[i].getDS();
            }
            else
            {
                DS.Tables[0].Rows.Add(lista[i].getDS().Tables[0].Rows[0]);
            }
            
        }
        GridView1.DataSource = DS;
        GridView1.DataBind();
    }

}