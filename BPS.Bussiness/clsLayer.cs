using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las capas para las formulaciones de las peliculas
    /// </summary>
    public class clsLayer
    {
        //Atributes

        private int layer_codsec;
        private int layer_fkMachine;
        private string layer_name;


        //Properties

        public int codsec{get{return layer_codsec;}set{layer_codsec = value;}}

        public int fkMachine{get{return layer_fkMachine;}set{layer_fkMachine = value;}}

        public string name{get{return layer_name;}set{layer_name = value;}}


        //Constructor

        public clsLayer()
        { 
        layer_codsec = 0;
        layer_name = "";
        layer_fkMachine = 0;
        
        }

        public clsLayer(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_layer where l_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["l_codsec"]);
            this.name = DS.Tables[0].Rows[0]["l_name"].ToString();
            this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["l_fkMachine"]);
        }

        public bool save()
        {
            try
            {

                string queryString = "";

                if (this.codsec == 0)
                {   
                    queryString += "INSERT INTO bps_prod_layer (l_name, l_fkMachine) ";
                    queryString += "VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += this.fkMachine;
                    queryString += ");";

                }
                else
                {
                    queryString += "UPDATE bps_prod_layer";
                    queryString += " SET ";
                    queryString += "l_name = '" + this.name + "',";
                    queryString += "l_description = " + this.fkMachine;
                    queryString += " WHERE l_codsec = " + this.codsec.ToString() + ";";
                    
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsLayer.save");
                return false;
            }

            
        }

        public static List<clsLayer> getList()
        {
            List<clsLayer> lstLayer = new List<clsLayer>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_layer ORDER BY l_name");

            lstLayer.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstLayer.Add(new clsLayer());
                lstLayer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["l_codsec"]);
                lstLayer[i].name = DS.Tables[0].Rows[i]["l_name"].ToString();
                lstLayer[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["l_fkMachine"]);
            }

            return lstLayer;
        }
        public static List<clsLayer> getListByMachine(int machinecodsec)
        {
            List<clsLayer> lstLayer = new List<clsLayer>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_layer WHERE l_fkMachine=" + machinecodsec.ToString() + " ORDER BY l_name");

            lstLayer.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstLayer.Add(new clsLayer());
                lstLayer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["l_codsec"]);
                lstLayer[i].name = DS.Tables[0].Rows[i]["l_name"].ToString();
                lstLayer[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["l_fkMachine"]);
            }

            return lstLayer;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
