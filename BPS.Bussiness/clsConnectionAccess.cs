using System;
using System.Collections.Generic;

using System.Data;
using System.Data.OleDb;

using System.Linq;
using System.Text;

using System.Windows.Forms;

// RECORDAR, PARA QUE ESTO FUNCIONE BIEN, HAY QUE TENER INSTALADO EN LAS MAQUINAS ACCESSDATABASEENGINE PARA 32 Y/O 64 BITS.
// SI NO TIRA ERROR "El proveedor 'Microsoft.ACE.OLEDB.12.0' no está registrado en el equipo local"

namespace BPS.Bussiness
{
    public class clsConnectionAccess
    {
        public string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=T:\\Conexion.accdb";
        public OleDbDataAdapter dAdapter;
        public DataTable dTable;
        public OleDbCommandBuilder cBuilder;
        public DataView myDataView;

        public OleDbDataAdapter executeQuery(string query)
        {
            dAdapter = new OleDbDataAdapter(query, connString);
            dTable = new DataTable();
            cBuilder = new OleDbCommandBuilder(dAdapter);
            cBuilder.QuotePrefix = "[";
            cBuilder.QuoteSuffix = "]";
            return dAdapter;
        }

        public static DataTable getDepot()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDA = myCon.executeQuery("SELECT * FROM DepositoAymasConId");

            DataTable table = new DataTable();
            dbDA.Fill(table);

            return table;
        }

        public static DataTable getShippings()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDA = myCon.executeQuery("SELECT * FROM REMITOS_ENTRE_FECHAS");

            DataTable table = new DataTable();
            dbDA.Fill(table);

            return table;
        }

        public static DataTable getAymasOV()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDA = myCon.executeQuery("SELECT * FROM OrdenesDeVentaAymas");

            DataTable table = new DataTable();
            dbDA.Fill(table);

            return table;
        }

        public static DataTable getPLChile()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDA = myCon.executeQuery("SELECT * FROM PLCHILEPREPARADO");

            DataTable table = new DataTable();
            dbDA.Fill(table);

            return table;
        }

        public static DataTable getPLPERU()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDA = myCon.executeQuery("SELECT * FROM PLPERUPREPARADO");

            DataTable table = new DataTable();
            dbDA.Fill(table);

            return table;
        }

        public static DataTable getPLCOLOMBIA()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDA = myCon.executeQuery("SELECT * FROM PLCOLOMBIA");

            DataTable table = new DataTable();
            dbDA.Fill(table);

            return table;
        }

        public static DataTable getPL()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDA = myCon.executeQuery("SELECT * FROM PL");

            DataTable table = new DataTable();
            dbDA.Fill(table);

            return table;
        }

        public static DataTable getINGP0()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDa = myCon.executeQuery("SELECT * FROM INGRESOMP0");

            DataTable table = new DataTable();
            dbDa.Fill(table);

            return table;          
                      
        }

        public static DataTable getINGP1()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDa = myCon.executeQuery("SELECT * FROM INGRESOMP1");

            DataTable table = new DataTable();
            dbDa.Fill(table);

            return table;
        }

        public static DataTable getPEDIDOEXPO()
        {
            clsConnectionAccess myCon = new clsConnectionAccess();

            OleDbDataAdapter dbDA = myCon.executeQuery("SELECT * FROM PEDIDOEXPO");

            DataTable table = new DataTable();
            dbDA.Fill(table);

            return table;
        }
    }
}
