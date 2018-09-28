using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Model
{
    class sachDAO
    {
        public void luuFile(List<sachBean> ds)
        {
            StreamWriter f = new StreamWriter("data.txt", false);
            foreach (sachBean s in ds)
            {
                f.WriteLine(s.Masach + ";" + s.Tensach + ";" + s.Gia.ToString() + ";" + s.Soluong.ToString());
            }
            f.Close();
        }

        public void Add(sachBean s)
        {
            StreamWriter f = new StreamWriter("data.txt", true);
            f.WriteLine(s.Masach + ";" + s.Tensach + ";" + s.Gia.ToString() + ";" + s.Soluong.ToString());
            f.Close();
        }

        public List<sachBean> getSach()
        {
            List<sachBean> ds = new List<sachBean>();
            StreamReader f = new StreamReader("data.txt");
            while (true)
            {
                string l = f.ReadLine();
                if (l == null || l == "") break;
                string[] info = l.Split(';');
                sachBean x = new sachBean(info[0], info[1], long.Parse(info[2]), long.Parse(info[3]));
                ds.Add(x);
            }
            f.Close();
            return ds;
        }
    }
}
