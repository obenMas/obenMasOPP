using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BPS.Bussiness
{
    public class clsRawMaterialBySiloCellar
    {
        //Properties
        private int rwmbsc_codsec;
        private int rwmbsc_fkSiloCellar;
        private int rwmbsc_fkRawMaterial;
        private int rwmbsc_fkRawType;
        private string rwmbsc_lote;
        private double rwmbsc_weigth;
        private double SilototalWeight;

        //Attributes
        public int codsec { get { return rwmbsc_codsec; } set { rwmbsc_codsec = value; } }
        public int fkSiloCellar { get { return rwmbsc_fkSiloCellar; } set { rwmbsc_fkSiloCellar = value; } }
        public int fkRawMaterial { get { return rwmbsc_fkRawMaterial; } set { rwmbsc_fkRawMaterial = value; } }
        public int fkRawType { get { return rwmbsc_fkRawType; } set { rwmbsc_fkRawType = value; } }
        public string lote { get { return rwmbsc_lote; } set { rwmbsc_lote = value; } }
        public double weigth { get { return rwmbsc_weigth; } set { rwmbsc_weigth = value; } }
        public double totalWeigth { get { return SilototalWeight; } set { SilototalWeight = value; } }
        
        //Constructor
        public clsRawMaterialBySiloCellar()
        {
            codsec = 0;
            fkSiloCellar = 0;
            fkRawMaterial = 0;
            fkRawType = 0;
            lote = "";
            weigth = 0;
            totalWeigth = 0;
        }
        public clsRawMaterialBySiloCellar(int codsec)
        {
            if (this.codsec == 0)
            {
                this.loadByfkSilo(codsec);
            }
            else
            {
                this.load(codsec);
            }
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialbysilocellar WHERE rwmbsc_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_codsec"]);
                this.fkSiloCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_fkSiloCellar"]);
                this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_fkRawMaterial"]);
                this.fkRawType = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_RawType"]);
                this.lote = Convert.ToString(DS.Tables[0].Rows[0]["rwmbsc_lote"]);
                this.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmbsc_weigth"]);
            }
        }

        public void loadByfkSilo(int fkSilo)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialbysilocellar WHERE rwmbsc_fkSiloCellar = " + fkSilo.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_codsec"]);
                this.fkSiloCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_fkSiloCellar"]);
                this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_fkRawMaterial"]);
                this.fkRawType = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_fkRawType"]);
                this.lote = Convert.ToString(DS.Tables[0].Rows[0]["rwmbsc_lote"]);
                this.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmbsc_weigth"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {   // En teoria aca no deberia caer nunca, de los jamases.

                    queryString += "INSERT INTO bps_prod_rawmaterialbysilocellar(rwmbsc_fkSiloCellar, rwmbsc_fkRawMaterial,rwmbsc_fkRawType,rwmbsc_lote,rwmbsc_weigth)";
                    queryString += "VALUES ( ";
                    queryString += this.fkSiloCellar.ToString() + ", ";
                    queryString += this.fkRawMaterial.ToString() + ", ";
                    queryString += this.fkRawType.ToString() + ", ";
                    queryString += "'" + this.lote.ToString() + "', ";
                    queryString += this.weigth.ToString() + ") ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_rawmaterialbysilocellar";
                    queryString += " SET ";
                    queryString += " rwmbsc_fkSiloCellar = " + this.fkSiloCellar.ToString() + ", ";
                    queryString += " rwmbsc_fkRawMaterial = " + this.fkRawMaterial.ToString() + ",";
                    queryString += " rwmbsc_fkRawType = " + this.fkRawType.ToString() + ",";
                    queryString += " rwmbsc_lote = '" + this.lote.ToString() + "',";
                    queryString += " rwmbsc_weigth = " + this.weigth.ToString() + "";
                    queryString += " WHERE rwmbsc_codsec = " + this.codsec.ToString() + ";";

                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialBySiloCellar.save");
                return false;
            }
        }
        
        // Recordar que este procedimiento es una negrada, y esta mal hecho. Reveer la forma de hacerlo.
        public bool checkSiloItsGood(int fkSilo, int fkRawMat, int fkRawType, string lote , double weigth) // no se lo seteo por el objeto instanciado, se lo paso como parametro al save
        {
            string queryString = "";
            DataSet DS = new DataSet();
            double acuWeigth = 0;

            try
            {   
                // En teoria esto traeria una tabla donde buscaria el silo que ingreso y a su vez que el polimero que no se puede mezclar lo tenga ese silo.

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialbysilocellar WHERE rwmbsc_fkSiloCellar = " + fkSilo.ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++) //Empiezo a recorrer el silo.
                    {
                        if (Convert.ToDouble(DS.Tables[0].Rows[i]["rwmbsc_weigth"]) > 0) //El silo tiene algun material
                        {
                            if (Convert.ToInt32(DS.Tables[0].Rows[i]["rwmbsc_fkRawType"]) == fkRawType) //El silo  tiene material y se puede mezclar.
                            {
                                if (Convert.ToString(DS.Tables[0].Rows[i]["rwmbsc_lote"]) == lote.ToString())
                                {
                                    acuWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmbsc_weigth"]) + weigth;
                                    queryString += "UPDATE bps_prod_rawmaterialbysilocellar";
                                    queryString += " SET ";
                                    queryString += " rwmbsc_fkRawMaterial = " + fkRawMat.ToString() + ", ";
                                    queryString += " rwmbsc_lote = '" + lote.ToString() + "', ";
                                    queryString += " rwmbsc_weigth = " + acuWeigth.ToString() + "";
                                    queryString += " WHERE rwmbsc_fkSiloCellar = " + fkSilo.ToString() + "AND rwmbsc_fkRawType = " + fkRawType.ToString();
                                }
                                else if(i+1 == DS.Tables[0].Rows.Count)
                                {
                                    queryString += "INSERT INTO bps_prod_rawmaterialbysilocellar(rwmbsc_fkSiloCellar,rwmbsc_fkRawMaterial,rwmbsc_fkRawType,rwmbsc_lote,rwmbsc_weigth)";
                                    queryString += "VALUES (";
                                    queryString += fkSilo.ToString() + ", ";
                                    queryString += fkRawMat.ToString() + ", ";
                                    queryString += fkRawType.ToString() + ", ";
                                    queryString += "'" + lote.ToString() + "', ";
                                    queryString += weigth.ToString() + ");";
                                    break;
                                }
                            }
                            else
                            {// else, el silo tiene material pero no  se puede mezclar.
                                if (fkSilo == 4028 || fkSilo == 4029)
                                {
                                    if (Convert.ToDouble(DS.Tables[0].Rows[i]["rwmbsc_weigth"]) <= 500) // Esta seria la tolerancia de los 500kg en cuanto al ingreso al silo. 
                                    {
                                        queryString += "INSERT INTO bps_prod_rawmaterialbysilocellar(rwmbsc_fkSiloCellar,rwmbsc_fkRawMaterial,rmbsc_fkRawType,rwmbsc_lote,rwmbsc_weigth)";
                                        queryString += "VALUES (";
                                        queryString += fkSilo.ToString() + ", ";
                                        queryString += fkRawMat.ToString() + ", ";
                                        queryString += fkRawType.ToString() + ", ";
                                        queryString += "'" + lote.ToString() + "', ";
                                        queryString += weigth.ToString() + ");";
                                        break;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                            }
                                
                        }
                    }
                }
                else
                {
                    // Quiere decir que el silo esta vacío del todo, nunca le ingresó nada o se consumio todo.
                    queryString += "INSERT INTO bps_prod_rawmaterialbysilocellar(rwmbsc_fkSiloCellar,rwmbsc_fkRawMaterial,rwmbsc_fkRawType,rwmbsc_lote,rwmbsc_weigth)";
                    queryString += "VALUES (";
                    queryString += fkSilo.ToString() + ", ";
                    queryString += fkRawMat.ToString() + ", ";
                    queryString += fkRawType.ToString() + ", ";
                    queryString += "'" + lote.ToString() + "', ";
                    queryString += weigth.ToString() + ");";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialBySiloCellar.save");
                return false;
            }
        }

        public static clsRawMaterialBySiloCellar getLastRegByFkSilo(int fkSilo)
        {
            DataSet DS = new DataSet();
            clsRawMaterialBySiloCellar silo = new clsRawMaterialBySiloCellar();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialbysilocellar WHERE (rwmbsc_codsec = (SELECT MAX(rwmbsc_codsec) FROM bps_prod_rawmaterialbysilocellar WHERE rwmbsc_fkSiloCellar = " + fkSilo.ToString() + "))");

            if (DS.Tables[0].Rows.Count > 0) // Esto se da si la tabla posee un registro el molino.
            {
                silo.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_codsec"]);
                silo.fkSiloCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_fkSiloCellar"]);
                silo.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_fkRawMaterial"]);
                silo.fkRawType = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmbsc_fkRawType"]);
                silo.lote = Convert.ToString(DS.Tables[0].Rows[0]["rwmbsc_lote"]);
                silo.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmbsc_weigth"]);

                return silo;
            }
            else // Si no, sabemos que el molino no tuvo ningun ingreso.
            {
                silo.codsec = 0;
                return silo;
            }
        }

        public static clsRawMaterialBySiloCellar getAllDataFromSilo(int fkSilo)
        {
            DataSet DS = new DataSet();
            clsRawMaterialBySiloCellar silo = new clsRawMaterialBySiloCellar();

            DS = clsConnection.getDataSetResult("CALL spGetTotalDataAndWeightBySiloCellar(" + fkSilo.ToString() +");");

            if (DS.Tables[0].Rows.Count > 0) // Esto se da si la tabla posee un registro el molino.
            {
                silo.fkSiloCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["fkSiloCellar"]);
                silo.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["fkRawMat"]);
                silo.fkRawType = Convert.ToInt32(DS.Tables[0].Rows[0]["fkRawType"]);
                silo.lote = Convert.ToString(DS.Tables[0].Rows[0]["loteSilo"]);
                silo.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["PesoSilo"]);
                silo.totalWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["TotalPeso"]);

                return silo;

                /* PLAN B en el caso que lo planteado inicialmente falle. 
                 * SELECT 
                   MAX(bps_prod_rawmaterialbysilocellar.rwmbsc_codsec) AS codsec,
                   bps_prod_rawmaterialbysilocellar.rwmbsc_lote AS lote, 
                   bps_prod_rawmaterialbysilocellar.rwmbsc_fkSiloCellar AS fkSilo,
                   SUM(bps_prod_rawmaterialbysilocellar.rwmbsc_weigth) AS TotPeso
                   FROM
                   bps_prod_rawmaterialbysilocellar
                   WHERE 
                   bps_prod_rawmaterialbysilocellar.rwmbsc_fkSiloCellar  = 4028
                   GROUP BY
                   rwmbsc_fkRawType,
                   rwmbsc_fkSiloCellar,
                   rwmbsc_lote
                   ORDER BY 
                   codsec ASC */ 
            }
            else // Si no, sabemos que el molino no tuvo ningun ingreso.
            {
                silo.fkSiloCellar = 0;
                return silo;
            }
        }

        public bool consumeWhatYouWant(int fkSilo, double weigth)
        {
            DataSet DS = new DataSet();
            double result = 0;
            

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialbysilocellar WHERE ((rwmbsc_fkSiloCellar =" + fkSilo.ToString() + ") AND " + "(rwmbsc_weigth > 0))");
            string sqlUpdate = "";

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    sqlUpdate = "";
                    result = Convert.ToDouble(DS.Tables[0].Rows[i]["rwmbsc_weigth"]) - Math.Abs(weigth);

                    if (result >= 0)
                    {
                        sqlUpdate += "UPDATE bps_prod_rawmaterialbysilocellar";
                        sqlUpdate += " SET rwmbsc_weigth =" + result.ToString();
                        sqlUpdate += " WHERE rwmbsc_codsec = " + Convert.ToString(DS.Tables[0].Rows[i]["rwmbsc_codsec"]);

                        break;
                    }
                    else
                    {
                        sqlUpdate += "UPDATE bps_prod_rawmaterialbysilocellar";
                        sqlUpdate += " SET rwmbsc_weigth = 0";
                        sqlUpdate += " WHERE rwmbsc_codsec = " + Convert.ToString(DS.Tables[0].Rows[i]["rwmbsc_codsec"]);

                        clsConnection.executeQuery(sqlUpdate);

                        weigth = result;
                    } 
                }
            }
            if (clsConnection.executeQuery(sqlUpdate))
            {
                return true;
            }
            else
            {
                return false;
            }             
        }

        public static List<clsRawMaterialBySiloCellar> getStockInSiloCellar()
        {
            List<clsRawMaterialBySiloCellar> listaMPSilo = new List<clsRawMaterialBySiloCellar>();
            DataSet DS = new DataSet();
            clsRawMaterialBySiloCellar silostock;

            DS = clsConnection.getDataSetResult("CALL spRawMaterialStockBySiloCellar()");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    silostock = new clsRawMaterialBySiloCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]));
                    listaMPSilo.Add(silostock);
                }
            }
            return listaMPSilo;

        }

        public bool newLoteGiveitByPallet(int fkSilo,int fkRawMaterial,int fkRawType, string lotePallet ,double palletWeigth)
        {
            try
            {
                DataSet DS = new DataSet();
                string queryString = "";

                queryString = "INSERT INTO bps_prod_rawmaterialbysilocellar(rwmbsc_fkSiloCellar,rwmbsc_fkRawMaterial,rwmbsc_fkRawType,rwmbsc_lote,rwmbsc_weigth)";
                queryString += "VALUES ( ";
                queryString += fkSilo.ToString() + ", ";
                queryString += fkRawMaterial.ToString() + ", ";
                queryString += fkRawType.ToString() + ", ";
                queryString += "'" + lotePallet.ToString() + "', ";
                queryString += palletWeigth.ToString() + "); ";

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialBySiloCellar.save");
                return false;
            }
            
        } 
    }
}
