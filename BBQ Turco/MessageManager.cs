using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBQ_Turco
{
    static class MessageManager
    {
        public static string CreateMessage(string main_command, string table_name, string[] column_names)
        {
            string str = main_command + " " + table_name + " ";
            for (int i = 0; i < column_names.Length; i++)
            {
                str += column_names[i] + ",";
            }
            return str.TrimEnd(',');
        }
        public static string CreateMessage(string main_command, string column_name, string value)
        {
            return main_command + " " + column_name + " " + value;
        }
        public static string CreateMessage(string main_command, string table_name, string column_name, string value)
        {
            return main_command + " " + table_name + " " + column_name + "," + value;
        }
        public static string CreateMessage(string main_command, string table_name, string column_name, object value, string[] column_names, object[] values)
        {
            string str = main_command + " " + table_name + " " + column_name + "," + value + ",";
            for (int i = 0; i < column_names.Length; i++)
            {
                str += column_names[i] + "," + values[i].ToString() + ",";
            }
            return str.TrimEnd(',');
        }
        public static string CreateMessage(string main_command, string table_name, string[] return_column_names, string[] column_names, object[] values)
        {
            string str = main_command + " " + table_name + " ";
            for (int i = 0; i < return_column_names.Length; i++)
            {
                str += return_column_names[i] + ",";
            }
            if (column_names != null)
            {
                str += "{ where },";
                for (int i = 0; i < column_names.Length; i++)
                {
                    str += column_names[i] + "," + values[i].ToString() + ",";
                }
            }
            return str.TrimEnd(',');
        }
        public static string CreateMessage(string main_command, string table_name, string[] column_names, object[] values)
        {
            string str = main_command + " " + table_name + " ";
            for(int i = 0; i < column_names.Length; i++)
            {
                str += column_names[i] + "," + values[i].ToString() + ",";
            }
            return str.TrimEnd(',');
        }
    }
}
