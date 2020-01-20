using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BPS.Bussiness
{
    public class clsXproRawMaterialConsumption
    {
        //Attributes
        private string xprmc_tipmov;
        private int xprmc_commov;
        private double xprmc_nromov;
        private double xprmc_secmov;
        private double xprmc_productomo;
        private double xprmc_cantidad;
        private int xprmc_bodegamov;
        private string xprmc_lote;
        private string xprmc_cargas;
        private double xprmc_orden;
        private DateTime xprmc_fecha;
        private string xprmc_turno;
        private string xprmc_identifica;
        private string xprmc_MAQ;
        private string xprmc_REFFCA;
        private string xprmc_LOTE1;
        private string xprmc_LOTE2;

        //Properties
        public string tipmov { get { return xprmc_tipmov; } set { xprmc_tipmov = value; } }
        public int commov { get { return xprmc_commov; } set { xprmc_commov = value; } }
        public double nromov { get { return xprmc_nromov; } set { xprmc_nromov = value; } }
        public double secmov { get { return xprmc_secmov; } set { xprmc_secmov = value; } }
        public double productomo { get { return xprmc_productomo; } set { xprmc_productomo = value; } }
        public double cantidad { get { return xprmc_cantidad; } set { xprmc_cantidad = value; } }
        public int bodegamov { get { return xprmc_bodegamov; } set { xprmc_bodegamov = value; } }
        public string lote { get { return xprmc_lote; } set { xprmc_lote = value; } }
        public string cargas { get { return xprmc_cargas; } set { xprmc_cargas = value; } }
        public double orden { get { return xprmc_orden; } set { xprmc_orden = value; } }
        public DateTime fecha { get { return xprmc_fecha; } set { xprmc_fecha = value; } }
        public string turno { get { return xprmc_turno; } set { xprmc_turno = value; } }
        public string identifica { get { return xprmc_identifica; } set { xprmc_identifica = value; } }
        public string MAQ { get { return xprmc_MAQ; } set { xprmc_MAQ = value; } }
        public string REFFCA { get { return xprmc_REFFCA; } set { xprmc_REFFCA = value; } }
        public string LOTE1 { get { return xprmc_LOTE1; } set { xprmc_LOTE1 = value; } }
        public string LOTE2 { get { return xprmc_LOTE2; } set { xprmc_LOTE2 = value; } }

        //Constructor
        public clsXproRawMaterialConsumption()
        {
            tipmov = "";
            commov = 0;
            nromov = 0;
            secmov = 0;
            productomo = 0;
            cantidad = 0;
            bodegamov = 0;
            lote = "";
            cargas = "";
            orden = 0;
            fecha = DateTime.Today;
            turno = "";
            identifica = "";
            MAQ = "";
            REFFCA = "";
            LOTE1 = "";
            LOTE2 = "";
        }

        //Method
        public static Boolean saveToDatabase(List<clsXproRawMaterialConsumption> lstXproRawMaterialConsumption)
        {
            string sqlConnectionString = @"Data Source=192.168.0.54\sqlexpress;Initial Catalog=XPROwareTest;User ID=sa;Password=";
            string queryString = "";

            SqlConnection Conn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();

            try
            {

                Conn.ConnectionString = sqlConnectionString;
                Conn.Open();
                for (int i = 0; i < lstXproRawMaterialConsumption.Count; i++)
                {

                    queryString = "INSERT INTO dbo.ST_MAT2011 ( tipmov, commov, nromov, secmov, productomo, cantidad, bodegamov, lote, cargas, orden, fecha, turno, identifica, MAQ, REFFCA, LOTE1, LOTE2)";
                    queryString += " VALUES (";
                    queryString += "'" + lstXproRawMaterialConsumption[i].tipmov + "',";
                    queryString += "" + lstXproRawMaterialConsumption[i].commov + ",";
                    queryString += "" + lstXproRawMaterialConsumption[i].nromov + ",";
                    queryString += "" + lstXproRawMaterialConsumption[i].secmov + ",";
                    queryString += "" + lstXproRawMaterialConsumption[i].productomo + ",";
                    queryString += "" + lstXproRawMaterialConsumption[i].cantidad + ",";
                    queryString += "" + lstXproRawMaterialConsumption[i].bodegamov + ",";
                    queryString += "'" + lstXproRawMaterialConsumption[i].lote + "',";
                    queryString += "'" + lstXproRawMaterialConsumption[i].cargas + "',";
                    queryString += "" + lstXproRawMaterialConsumption[i].orden + ",";
                    queryString += "'" + lstXproRawMaterialConsumption[i].fecha + "',";
                    queryString += "'" + lstXproRawMaterialConsumption[i].turno + "',";
                    queryString += "'" + lstXproRawMaterialConsumption[i].identifica + "',";
                    queryString += "'" + lstXproRawMaterialConsumption[i].MAQ + "',";
                    queryString += "'" + lstXproRawMaterialConsumption[i].REFFCA + "',";
                    queryString += "'" + lstXproRawMaterialConsumption[i].LOTE1 + "',";
                    queryString += "'" + lstXproRawMaterialConsumption[i].LOTE2 + "');";

                    Cmd.CommandText = queryString;
                    Cmd.Connection = Conn;
                    Cmd.ExecuteNonQuery();

                }

                Conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex.Message, 3, "clsXproRawMaterialConsumption.saveToDatabase");
                Conn.Close();
                return false;
            }

        }

    }
}
