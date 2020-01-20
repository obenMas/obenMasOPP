using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
     public class clsCoilChanges
    {
         // Atributes
         private int cc_codsec;
         private int cc_fkCoil;
         private int cc_fkMainCoil;
         private int cc_oldState;
         private int cc_newState;
         private int cc_lastCellar;
         private int cc_newCellar;
         private double cc_lastWeight;
         private double cc_newWeight;
         private int cc_fkUser;
         private DateTime cc_date;
         // Properties
         public int codsec { get { return cc_codsec; } set { cc_codsec = value; } }
         public int fkCoil { get { return cc_fkCoil; } set { cc_fkCoil = value; } }
         public int fkMainCoil { get { return cc_fkMainCoil; } set { cc_fkMainCoil = value; } }
         public int oldState { get { return cc_oldState; } set { cc_oldState = value; } }
         public int newState { get { return cc_newState; } set { cc_newState = value; } }
         public int lastCellar { get { return cc_lastCellar; } set { cc_lastCellar = value; } }
         public int newCellar { get { return cc_newCellar; } set { cc_newCellar = value; } }
         public double lastWeight { get { return cc_lastWeight; } set { cc_lastWeight = value; } }
         public double newWeight { get { return cc_newWeight; } set { cc_newWeight = value; } }
         public int fkUser { get { return cc_fkUser; } set { cc_fkUser = value; } }
         public DateTime date { get { return cc_date; } set { cc_date = value; } }
      
         // Constructor
         public clsCoilChanges()
         {
             codsec = 0;
             fkCoil = 0;
             fkMainCoil = 0;
             oldState = 0;
             newState = 0;
             lastCellar = 0;
             newCellar = 0;
             lastWeight = 0;
             newWeight = 0;
             fkUser = 0;
             date = DateTime.Now;
         }

         public clsCoilChanges(int fkCoil)
         {
             this.load(fkCoil);
         }
         // Metodos

         public void load(int fkCoil)
         {
             DataSet DS = new DataSet();
             string query = "";

             query = "SELECT * FROM bps_prod_coilchanges WHERE bps_prod_coilchanges.cc_fkCoil =" + fkCoil.ToString() + "";
             DS = clsConnection.getDataSetResult(query);

             if (DS.Tables.Count > 0)
             {
                 codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cc_codsec"]);
                 fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["cc_fkCoil"]);
                 fkMainCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["cc_fkMainCoil"]);
                 oldState = Convert.ToInt32(DS.Tables[0].Rows[0]["cc_oldState"]);
                 newState = Convert.ToInt32(DS.Tables[0].Rows[0]["cc_newState"]);
                 lastCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cc_lastCellar"]);
                 newCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cc_newCellar"]);
                 lastWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["cc_lastWeight"]);
                 newWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["cc_newWeight"]);
                 fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["cc_fkUser"]);
                 date = Convert.ToDateTime(DS.Tables[0].Rows[0]["cc_date"]);
             }
         }

         public bool save()
         {
             DataSet DS = new DataSet();
             string query = "";

             try
             {
                 if (this.codsec == 0)
                 {
                     query += "INSERT INTO bps_prod_coilchanges(cc_fkCoil,cc_fkMainCoil,cc_oldState,cc_newState,cc_lastCellar,cc_newCellar,cc_lastWeight,cc_newWeight,cc_fkUser,cc_date)";
                     query += " VALUES( ";
                     query += "" + this.fkCoil.ToString() + ",";
                     query += "" + this.fkMainCoil.ToString() + ",";
                     query += "" + this.oldState.ToString() + ",";
                     query += "" + this.newState.ToString() + ",";
                     query += "" + this.lastCellar.ToString() + ",";
                     query += "" + this.newCellar.ToString() + ",";
                     query += "" + this.lastWeight.ToString() + ",";
                     query += "" + this.newWeight.ToString() + ",";
                     query += "" + this.fkUser.ToString() + ",";
                     query += "'" + this.date.ToString() + "')";
                 }
                 /*else
                 {
                     query += "UPDATE bps_prod_coilchanges";
                     query += " SET ";
                     query += "cc_oldState =" + this.oldState.ToString();
                     query += "cc_newState =" + this.newState.ToString();
                     query += "cc_lastCellar =" + this.lastCellar.ToString();
                     query += "cc_newState =" + this.newCellar.ToString();
                     query += "cc_fkUser = " + this.fkUser.ToString();
                     query += "cc_date = " + this.date.ToString();
                 } Es al pedo updatear un movimiento. Se realizo y punto, a lo sumo se duplica.
                */
                 return clsConnection.executeQuery(query);
                 
             }
             catch (Exception ex)
             {
                 clsLog.addLog(ex,3,"coilchanges.save");
                 return false;
             }
         }
    }
}
