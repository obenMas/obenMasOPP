using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BPS.Bussiness
{
    public class clsXproMainCoil
    {
        //Attirbutes

        private double xpmc_orden;
        private string xpmc_turno;
        private DateTime xpmc_fec_in;
        private DateTime xpmc_fec_fn;
        private string xpmc_nombre_sup;
        private string xpmc_tipo;
        private string xpmc_lote_estru;
        private string xpmc_identific;
        private double xpmc_metraje;
        private double xpmc_kilos;
        private DateTime xpmc_fecha;
        private string xpmc_MAQ;
        private double xpmc_ancho;
        private string xpmc_OBS;
        private string xpmc_ESTADO;
        private string xpmc_trata;
        private string xpmc_x1;
        private string xpmc_x2;
        private double xpmc_x3;
        private double xpmc_x4;

        //Properties

        public double orden { get { return xpmc_orden; } set { xpmc_orden = value; } }

        public string turno { get { return xpmc_turno; } set { xpmc_turno = value; } }

        public DateTime fec_in { get { return xpmc_fec_in; } set { xpmc_fec_in = value; } }

        public DateTime fec_fn { get { return xpmc_fec_fn; } set { xpmc_fec_fn = value; } }

        public string nombre_sup { get { return xpmc_nombre_sup; } set { xpmc_nombre_sup = value; } }

        public string tipo { get { return xpmc_tipo; } set { xpmc_tipo = value; } }

        public string lote_estru { get { return xpmc_lote_estru; } set { xpmc_lote_estru = value; } }

        public string identific { get { return xpmc_identific; } set { xpmc_identific = value; } }

        public double metraje { get { return xpmc_metraje; } set { xpmc_metraje = value; } }

        public double kilos { get { return xpmc_kilos; } set { xpmc_kilos = value; } }

        public DateTime fecha { get { return xpmc_fecha; } set { xpmc_fecha = value; } }

        public string MAQ { get { return xpmc_MAQ; } set { xpmc_MAQ = value; } }

        public double ancho { get { return xpmc_ancho; } set { xpmc_ancho = value; } }

        public string OBS { get { return xpmc_OBS; } set { xpmc_OBS = value; } }

        public string ESTADO { get { return xpmc_ESTADO; } set { xpmc_ESTADO = value; } }

        public string trata { get { return xpmc_trata; } set { xpmc_trata = value; } }

        public string x1 { get { return xpmc_x1; } set { xpmc_x1 = value; } }

        public string x2 { get { return xpmc_x2; } set { xpmc_x2 = value; } }

        public double x3 { get { return xpmc_x3; } set { xpmc_x3 = value; } }

        public double x4 { get { return xpmc_x4; } set { xpmc_x4 = value; } }


        //Constructor
        public clsXproMainCoil()
        { 
          xpmc_orden = 0;
          xpmc_turno = "";
          xpmc_fec_in = DateTime.Today;
          xpmc_fec_fn = DateTime.Today;
          xpmc_nombre_sup = "";
          xpmc_tipo = "";
          xpmc_lote_estru = "";
          xpmc_identific = "";
          xpmc_metraje = 0;
          xpmc_kilos = 0;
          xpmc_fecha = DateTime.Today;
          xpmc_MAQ = "";
          xpmc_ancho = 0;
          xpmc_OBS = "";
          xpmc_ESTADO = "";
          xpmc_trata = "";
          xpmc_x1 = "";
          xpmc_x2 = "";
          xpmc_x3 = 0;
          xpmc_x4 = 0;
        }

        public static Boolean saveToDatabase(List<clsXproMainCoil> lstXproMainCoil)
        {
            string sqlConnectionString = @"Data Source=192.168.0.54\sqlexpress;Initial Catalog=XPROwareTest;User ID=sa;Password=";
            string queryString = "";

            SqlConnection Conn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();

            try
            {

                Conn.ConnectionString = sqlConnectionString;
                Conn.Open();
                for (int i = 0; i < lstXproMainCoil.Count; i++)
                {

                    queryString = "INSERT INTO ST_CTEST2011 (orden, turno, fec_in, fec_fn, nombre_sup, tipo, lote_estru, identific, metraje, kilos, fecha, MAQ, ancho, OBS, ESTADO, trata, x1, x2, x3, x4)";
                    queryString += " VALUES (";
                    queryString += "'" + lstXproMainCoil[i].orden.ToString() + "',";
                    queryString += "'" + lstXproMainCoil[i].turno + "',";
                    queryString += "'" + lstXproMainCoil[i].fec_in.ToString() + "',";
                    queryString += "'" + lstXproMainCoil[i].fec_fn.ToString() +"',";
                    queryString += "'" + lstXproMainCoil[i].nombre_sup + "',";
                    queryString += "'" + lstXproMainCoil[i].tipo + "',";
                    queryString += "'" + lstXproMainCoil[i].lote_estru + "',";
                    queryString += "'" + lstXproMainCoil[i].identific + "',";
                    queryString += "" + lstXproMainCoil[i].metraje.ToString() + ",";
                    queryString += "" + lstXproMainCoil[i].kilos.ToString() + ",";
                    queryString += "'" + lstXproMainCoil[i].fecha.ToString() + "',";
                    queryString += "'" + lstXproMainCoil[i].MAQ + "',";
                    queryString += "" + lstXproMainCoil[i].ancho.ToString() + ",";
                    queryString += "'" + lstXproMainCoil[i].OBS + "',";
                    queryString += "'" + lstXproMainCoil[i].ESTADO + "',";
                    queryString += "'" + lstXproMainCoil[i].trata + "',";
                    queryString += "'" + lstXproMainCoil[i].x1 + "',";
                    queryString += "'" + lstXproMainCoil[i].x2 + "',";
                    queryString += "" + lstXproMainCoil[i].x3.ToString() + ",";
                    queryString += "" + lstXproMainCoil[i].x4.ToString() + ");";

                    Cmd.CommandText = queryString;
                    Cmd.Connection = Conn;
                    Cmd.ExecuteNonQuery();

                }

                Conn.Close();
                return true;
            }
            catch (Exception)
            {
                Conn.Close();
                return false;
            }

        }

    }
}
