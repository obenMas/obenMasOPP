using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de clsPalletWS
/// </summary>
public class clsPalletWS
{
    private int plt_codsec;
    private int plt_fkProduct;
    private int plt_fkStatus;
    private string plt_code;
    private double plt_netWeight;
    private double plt_grossWeight;
    private DateTime plt_createdDate;
    private DateTime plt_modifiedDate;
    private int plt_createdBy;
    private int plt_modifiedBy;
    private string plt_position;
    private int plt_fkPalletCoilcellar;

    //Properties

    public int codsec { get { return plt_codsec; } set { plt_codsec = value; } }

    public int fkProduct { get { return plt_fkProduct; } set { plt_fkProduct = value; } }

    public int fkStatus { get { return plt_fkStatus; } set { plt_fkStatus = value; } }

    public string code { get { return plt_code; } set { plt_code = value; } }

    public double netWeight { get { return plt_netWeight; } set { plt_netWeight = value; } }

    public double grossWeight { get { return plt_grossWeight; } set { plt_grossWeight = value; } }

    public DateTime createdDate { get { return plt_createdDate; } set { plt_createdDate = value; } }

    public DateTime modifiedDate { get { return plt_modifiedDate; } set { plt_modifiedDate = value; } }

    public int createdBy { get { return plt_createdBy; } set { plt_createdBy = value; } }

    public int modifiedBy { get { return plt_modifiedBy; } set { plt_modifiedBy = value; } }

    public double coilnetweigth { get { return plt_netWeight; } set { plt_netWeight = value; } }

    public string position { get { return plt_position; } set { plt_position = value; } }

    public int fkPalletCoilcellar { get { return plt_fkPalletCoilcellar; } set { plt_fkPalletCoilcellar = value; } }



    //Constructor

    public clsPalletWS()
    {
        plt_codsec = 0;
        plt_fkProduct = 0;
        plt_fkStatus = 0;
        plt_code = "";
        plt_netWeight = 0;
        plt_grossWeight = 0;
        plt_createdDate = DateTime.Now;
        plt_modifiedDate = DateTime.Now;
        plt_createdBy = 0;
        plt_modifiedBy = 0;
        plt_position = string.Empty;
        plt_fkPalletCoilcellar = 11;
    }

    public clsPalletWS(string palletCode)
    {
        this.load(palletCode);
    }

    public void load(string palletCode)
    {
        DataSet dataTable = new DataSet();

        using (SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["connectionLocal"]
            .ConnectionString))
        {

            con.Open();

            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(
                "SELECT * FROM bps_prod_pallet WHERE plt_code='"+palletCode+"'", con))
            {
                sqlAdapter.Fill(dataTable);
            }
        }


        if (dataTable.Tables[0].Rows.Count > 0)
        {
            codsec = Convert.ToInt32(dataTable.Tables[0].Rows[0]["plt_codsec"]);
            fkProduct = Convert.ToInt32(dataTable.Tables[0].Rows[0]["plt_fkProduct"]);
            fkStatus = Convert.ToInt32(dataTable.Tables[0].Rows[0]["plt_fkStatus"]);
            code = dataTable.Tables[0].Rows[0]["plt_code"].ToString();
            netWeight = Convert.ToDouble(dataTable.Tables[0].Rows[0]["plt_netWeight"]);
            grossWeight = Convert.ToDouble(dataTable.Tables[0].Rows[0]["plt_grossWeight"]);
            createdDate = Convert.ToDateTime(dataTable.Tables[0].Rows[0]["plt_createdDate"]);
            modifiedDate = Convert.ToDateTime(dataTable.Tables[0].Rows[0]["plt_modifiedDate"]);
            createdBy = Convert.ToInt32(dataTable.Tables[0].Rows[0]["plt_createdBy"]);
            modifiedBy = Convert.ToInt32(dataTable.Tables[0].Rows[0]["plt_modifiedBy"]);
            position = dataTable.Tables[0].Rows[0]["plt_position"].ToString().ToUpper();
            fkPalletCoilcellar = Convert.ToInt32(dataTable.Tables[0].Rows[0]["plt_fkPalletCoilcellar"]);
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();
        dataTable.Dispose();
    }

    public DataSet getDS()
    {
        DataSet dataTable = new DataSet();

        using (SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["connectionLocal"]
            .ConnectionString))
        {

            con.Open();

            using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(
                "SELECT * FROM bps_prod_pallet WHERE plt_code='" + code + "'", con))
            {
                sqlAdapter.Fill(dataTable);
            }
        }

        return dataTable;
    }

}