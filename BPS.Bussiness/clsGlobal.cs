using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;


namespace BPS.Bussiness
{
    static public class clsGlobal
    {

        private static clsUser loggedUser = new clsUser();
        private static clsCompany company = new clsCompany();
        private static string dataBaseEngine = "";
        private static string Server = "";
        private static string DatabaseUser = "";
        private static string Password = "";
        private static string Database = "";

        public static clsUser LoggedUser { get { return loggedUser; } set { loggedUser = value; } }
        public static clsCompany Company { get { return company; } set { company = value; } }
        public static string DataBaseEngine { get { return dataBaseEngine; } set { dataBaseEngine = value; } }

        public static string server { get { return Server; } set { Server = value; } }
        public static string databaseUser { get { return DatabaseUser; } set { DatabaseUser = value; } }
        public static string password { get { return Password; } set { Password = value; } }
        public static string database { get { return Database; } set { Database = value; } }

        public static string getMd5(string pass)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            byte[] dataMd5 = md5.ComputeHash(Encoding.Default.GetBytes(pass));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataMd5.Length; i++)
                sb.AppendFormat("{0:x2}", dataMd5[i]);
            return sb.ToString();
        }

        public static string FillWithZeros(string str, int length)
        {
            int initLength = 0;

            initLength = str.Length;

            for (int i = initLength; i < length; i++)
            {
                str = "0" + str;
            }

            return str;
        }

        public static string FillWithSpaces(string str, int length)
        {
            int initLength = 0;

            initLength = str.Length;

            for (int i = initLength; i < length; i++)
            {
                str = str + " ";
            }

            return str;
        }

        public static bool isNumeric(string value)
        {
            try
            {
                
                double d = System.Double.Parse(value.Replace(".","").Replace(",",""), System.Globalization.NumberStyles.Any);
                return true;
            }
            catch (System.FormatException)
            {
                return false;
            }
        }

        public static List<bool> getBooleanListFromString(string listInString)
        {
            List<bool> lstBooleanValues = new List<bool>();

            for (int i = 0; i < listInString.Split(new string[] { ";" } , StringSplitOptions.None).Length; i++)
            {
                string value = listInString.Split(new string[] { ";" }, StringSplitOptions.None)[i];

                if (value != "0" && value != "1")
                    lstBooleanValues.Add(Convert.ToBoolean(value));
                else if (value == "0")
                    lstBooleanValues.Add(false);
                else if (value == "1")
                    lstBooleanValues.Add(true);
            }

            return lstBooleanValues;
        }

        public static List<double> getDoubleListFromString(string listInString)
        {
            List<double> lstDoubleValues = new List<double>();
            if (listInString != "")
            {
                for (int i = 0; i < listInString.Split(new string[] { ";" }, StringSplitOptions.None).Length; i++)
                {
                    lstDoubleValues.Add(Math.Round(Convert.ToDouble(listInString.Split(new string[] { ";" }, StringSplitOptions.None)[i]),2));
                }
            }
            return lstDoubleValues;
        }

        public static List<int> getIntListFromString(string listInString)
        {
            List<int> lstIntValues = new List<int>();
            if (listInString != "")
            {
                for (int i = 0; i < listInString.Split(new string[] { ";" }, StringSplitOptions.None).Length; i++)
                {
                    lstIntValues.Add(Convert.ToInt32(listInString.Split(new string[] { ";" }, StringSplitOptions.None)[i]));
                }
            }
            return lstIntValues;
        }

        public static List<string> getStringListFromString(string listInString)
        {
            List<string> lstStringValues = new List<string>();
            if (listInString != "")
            {
                for (int i = 0; i < listInString.Split(new string[] { ";" }, StringSplitOptions.None).Length; i++)
                {
                    lstStringValues.Add((listInString.Split(new string[] { ";" }, StringSplitOptions.None)[i]).ToString());
                }
            }
            return lstStringValues;
        }

        public static Color getRandomColor()
        {
            Thread.Sleep(7);
            List<Color> lstColors = new List<Color>();
            Random rndseed = new Random(DateTime.Now.Millisecond);
            Random rnd = new Random(rndseed.Next(0,DateTime.Now.Millisecond*10));

            lstColors.Add(Color.Azure);
            lstColors.Add(Color.LightGoldenrodYellow);
            lstColors.Add(Color.Coral);
            lstColors.Add(Color.PeachPuff);
            lstColors.Add(Color.Orange);
            lstColors.Add(Color.GreenYellow);
            lstColors.Add(Color.LimeGreen);
            lstColors.Add(Color.Aquamarine);
            lstColors.Add(Color.SkyBlue);
            lstColors.Add(Color.CornflowerBlue);
            lstColors.Add(Color.Violet);
            lstColors.Add(Color.Lavender);
            lstColors.Add(Color.SteelBlue);
            lstColors.Add(Color.Plum);
            lstColors.Add(Color.Gold);
            lstColors.Add(Color.Salmon);
            lstColors.Add(Color.Bisque);
            lstColors.Add(Color.Wheat);
            lstColors.Add(Color.Yellow);
            lstColors.Add(Color.Orange);
            lstColors.Add(Color.Tomato);
            lstColors.Add(Color.Orchid);
            lstColors.Add(Color.Turquoise);


            return lstColors[rnd.Next(0,lstColors.Count)];
        }

        public static Color getColorByPosition(int position, int totalColorsNeeded)
        {
            List<Color> lstColors = new List<Color>();

            //lstColors.Add(Color.FromArgb(255, 255, 128));
            //lstColors.Add(Color.Yellow);
            //lstColors.Add(Color.FromArgb(255, 192, 64));
            //lstColors.Add(Color.FromArgb(255, 128, 0));
            //lstColors.Add(Color.Tomato);
            //lstColors.Add(Color.FromArgb(255, 64, 0));
            //lstColors.Add(Color.FromArgb(255, 45, 45));
            //lstColors.Add(Color.FromArgb(255, 64, 128));
            //lstColors.Add(Color.FromArgb(255, 128, 255));
            //lstColors.Add(Color.FromArgb(192, 192, 255));
            //lstColors.Add(Color.FromArgb(128, 128, 255));
            //lstColors.Add(Color.FromArgb(15, 75, 255));
            //lstColors.Add(Color.FromArgb(0, 192, 192));
            //lstColors.Add(Color.FromArgb(192, 255, 192));
            //lstColors.Add(Color.FromArgb(192, 255, 128));
            //lstColors.Add(Color.FromArgb(128, 255, 128));
            //lstColors.Add(Color.FromArgb(64, 255, 64));
            //lstColors.Add(Color.Lime);

            //return lstColors[Convert.ToInt32(position * Math.Floor(Convert.ToDecimal(Convert.ToDouble(lstColors.Count)/totalColorsNeeded)))];
            
            
            //Color clrInit = Color.Red;
            //Color clrEnd = Color.Blue ;
            //Color stepper = Color.FromArgb((byte)((clrEnd.A - clrInit.A) / (totalColorsNeeded - 1)),
            //                               (byte)((clrEnd.R - clrInit.R) / (totalColorsNeeded - 1)),
            //                               (byte)((clrEnd.G - clrInit.G) / (totalColorsNeeded - 1)),
            //                               (byte)((clrEnd.B - clrInit.B) / (totalColorsNeeded - 1)));

            //for (int i = 0; i < totalColorsNeeded; i++)
            //{
            //    lstColors.Add(Color.FromArgb(clrInit.A + (stepper.A * i),
            //                                clrInit.R + (stepper.R * i),
            //                                clrInit.G + (stepper.G * i),
            //                                clrInit.B + (stepper.B * i)));
            //}
            for (double i = 0; i <= 1; i += (1.0 / totalColorsNeeded))
            {
                lstColors.Add(clsGlobal.HSL2RGB(i, 0.75, 0.75));
            }

            return lstColors[position];
        }

        public static Color HSL2RGB(double h, double sl, double l)
        {
            double v;
            double r, g, b;
            r = l;   // default to gray
            g = l;
            b = l;

            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);
            if (v > 0)
            {
                double m;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;

                m = l + l - v;
                sv = (v - m) / v;
                h *= 6.0;
                sextant = (int)h;
                fract = h - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;

                switch (sextant)
                {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;

                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;

                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;

                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;

                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;

                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }

            Color rgb;
            rgb = Color.FromArgb(255,Convert.ToByte(r * 255.0f), Convert.ToByte(g * 255.0f), Convert.ToByte(b * 255.0f));

            return rgb;
        }

        public static void ClearForm(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    if (ctrControl.Tag != null)
                    {
                        switch (ctrControl.Tag.ToString())
                        {
                            case "clearOnReload":
                                ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                                break;
                            case "numericClearOnReload":
                                ((System.Windows.Forms.TextBox)ctrControl).Text = "0";
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                    }
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.Label)))
                {
                    if (ctrControl.Tag != null)
                    {
                        switch (ctrControl.Tag.ToString())
                        {
                            case "clearOnReload":
                                ((System.Windows.Forms.Label)ctrControl).Text = string.Empty;
                                break;
                            case "numericClearOnReload":
                                ((System.Windows.Forms.Label)ctrControl).Text = "0";
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.NumericUpDown)))
                {
                    ((System.Windows.Forms.NumericUpDown)ctrControl).Value = 0;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.DataGridView)))
                {
                    ((System.Windows.Forms.DataGridView)ctrControl).Rows.Clear();
                }
                if (ctrControl.Controls.Count > 0)
                {
                    ClearForm(ctrControl);
                }
            }
        }

        public static string ToHexadecimal(int n)
        {
            if (n == 0)
                return "0";
            else
            {
                string hexNumber = "";
                int r = n % 16;
                n = n / 16;
                if (n>0)
                    hexNumber += ToHexadecimal(n);
                switch (r)
                {
                    case 10:
                        hexNumber += "A"; 
                        break;
                    case 11:
                        hexNumber += "B";
                        break;
                    case 12:
                        hexNumber += "C";
                        break;
                    case 13:
                        hexNumber += "D";
                        break;
                    case 14:
                        hexNumber += "E";
                        break;
                    case 15:
                        hexNumber += "F";
                        break;
                    default:
                        hexNumber += r.ToString();
                        break;
                }
                return hexNumber;
            }
        }
        
        public static double Round(double d, int decimals)
        {
            if ((decimals < -28) || (decimals > 28)) 
                throw new ArgumentOutOfRangeException("decimals", "Rounding decimals must be between -28 and 28, inclusive.");
            if (decimals >= 0) 
                return Math.Round(d, decimals);

            double n = (double)Math.Pow(10, -decimals);
            return Math.Round(d / n, 0) * n;
        }

        public static bool convertToBoolean(object objValue, string strValueDataType)
        {
            if (strValueDataType == "System.Byte[]")
                return Convert.ToBoolean(((System.Array)objValue).GetValue(0));
            else
                return Convert.ToBoolean(objValue);
        }
    }
}
