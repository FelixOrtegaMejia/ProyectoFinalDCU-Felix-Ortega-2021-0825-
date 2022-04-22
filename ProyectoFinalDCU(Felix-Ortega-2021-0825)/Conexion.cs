using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFinalDCU_Felix_Ortega_2021_0825_
{
    class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-K8OMFAN;DATABASE=dcufinal;" +
                "INTEGRATED SECURITY=true");
            cn.Open();
            return cn;
        }
        public static SqlConnection close()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-K8OMFAN;DATABASE=dcufinal;" +
                "INTEGRATED SECURITY=true");
            cn.Close();
            return cn;
        }
    }
}
