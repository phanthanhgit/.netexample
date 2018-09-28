using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2.Model.DAO
{
    class DungChung
    {
        public static SqlConnection cn;
        public void KetNoi(string sv, string db, string id, string pass)
        {

            string chuoikn = "Data Source=" + sv + ";Initial Catalog="+db+";User ID="+id+";Password="+pass;//Chua chuoi ket noi vao csdl
            chuoikn = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", sv, db, id, pass);
            cn = new SqlConnection(chuoikn);//Tao ra duong ket noi
            cn.Open();//Mo ket noi
        }
    }
}
