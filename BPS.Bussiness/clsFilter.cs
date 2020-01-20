using System;
using System.Collections.Generic;
using System.Text;

namespace BPS.Bussiness
{
    public class clsFilter
    {
        //Atributes
        private string Field;
        private string Value;
        private string Value2;
        private string Operation;
        private string DataType;

        //Properties
        public string field { get { return Field; } set { Field = value; } }

        public string value { get { return Value; } set { Value = value; } }

        public string value2 { get { return Value2; } set { Value2 = value; } }
        
        public string operation { get { return Operation; } set { Operation = value; } }

        public string dataType { get { return DataType; } set { DataType = value; } }


        public clsFilter()
        {
            field = "";
            value = "";
            value2 = "";
            operation = "";
            dataType = "";
        }

        public string getSingleSql()
        {
            string sql = "";
            string val = "";
            string val2 = "";
            
            switch (operation)
            {
                case "startsWith":
                    sql = " " + field + " LIKE '" + value + "%' ";
                    break;
                case "contains":
                    sql = " " + field + " LIKE '%" + value + "%' ";
                    break;
                case "moreIqualThan":
                    switch (dataType)
                    {
                        case "int":
                            val = value;
                            val2 = value2;
                            break;
                        case "double":
                            val = value;
                            val2 = value2;
                            break;
                        case "float":
                            val = value;
                            val2 = value2;
                            break;
                        case "dateTime":
                            val = "'" + value + "'";
                            break;
                    }
                    sql = " " + field + " >= " + val + " ";
                    break;
                case "equal":
                    switch (dataType)
                    {
                        case "boolean":
                            val = value;
                            val2 = value2;
                            break;
                        case "int":
                            val = value;
                            val2 = value2;
                            break;
                        case "double":
                            val = value;
                            val2 = value2;
                            break;
                        case "float":
                            val = value;
                            val2 = value2;
                            break;
                        case "varchar":
                            val = "'" + value + "'";
                            val2 = "'" + value2 + "'";
                            break;
                        case "text":
                            val = "'" + value + "'";
                            val2 = "'" + value2 + "'";
                            break;
                        case "dateTime":
                            val = "'" + value + "'";
                            val2 = "'" + value2 + "'";
                            break;
                    }
                    sql = " " + field + " = " + val + " ";
                    break;
                case "diferent":
                    switch (dataType)
                    {
                        case "boolean":
                            val = value;
                            val2 = value2;
                            break;
                        case "int":
                            val = value;
                            val2 = value2;
                            break;
                        case "double":
                            val = value;
                            val2 = value2;
                            break;
                        case "float":
                            val = value;
                            val2 = value2;
                            break;
                        case "varchar":
                            val = "'" + value + "'";
                            val2 = "'" + value2 + "'";
                            break;
                        case "text":
                            val = "'" + value + "'";
                            val2 = "'" + value2 + "'";
                            break;
                        case "dateTime":
                            val = "'" + value + "'";
                            val2 = "'" + value2 + "'";
                            break;
                    }
                    sql = " " + field + " = " + val + " ";
                    break;
                case "between":
                    switch (dataType)
                    {
                        case "boolean":
                            val = value;
                            val2 = value2;
                            break;
                        case "int":
                            val = value;
                            val2 = value2;
                            break;
                        case "double":
                            val = value;
                            val2 = value2;
                            break;
                        case "float":
                            val = value;
                            val2 = value2;
                            break;
                        case "varchar":
                            val = "'" + value + "'";
                            val2 = "'" + value2 + "'";
                            break;
                        case "text":
                            val = "'" + value + "'";
                            val2 = "'" + value2 + "'";
                            break;
                        case "dateTime":
                            val = "'" + value + "'";
                            val2 = "'" + value2 + "'";
                            break;
                    }
                    sql = " " + field + " between " + val + " AND " + val2 + " ";
                    break;

            }
            return sql;
        }
        public static string getSql(List<clsFilter> lstFilter)
        {
            string sql = "";

            for (int i = 0; i < lstFilter.Count; i++)
            {
                sql += lstFilter[i].getSingleSql();
                if (i < lstFilter.Count - 1)
                {
                    sql += "AND";
                }
            }
            return sql;
        }

    }
}
