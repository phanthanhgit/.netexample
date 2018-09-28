using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2.Model;

namespace WindowsFormsApplication2.BO
{
    class sachBO
    {
        sachDAO n = new sachDAO();
        public List<sachBean> lst;
        public List<sachBean> getSach()
        {
            lst = n.getSach();
            return lst;
        }

        public void luuFile(List<sachBean> ds)
        {
            n.luuFile(ds);
        }

        public int findID(String masach)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].Masach.Trim().ToLower().Equals(masach.Trim().ToLower()))
                    return i;
            }
            return -1;
        }

        public bool Add(String masach, String tensach, long gia, long soluong)
        {
            if (findID(masach) != -1)
            {
                return false;
            }
            else
            {
                sachBean x = new sachBean(masach, tensach, gia, soluong);
                lst.Add(x);
                n.Add(x);
                return true;
            }

        }
        public bool Edit(String masach, String tensach, long gia, long soluong)
        {
            int index = findID(masach);
            if (index != -1)
            {
                lst[index].Tensach = tensach;
                lst[index].Gia = gia;
                lst[index].Soluong = soluong;
                n.luuFile(lst);
                return true;
            }
            else
                return false;
        }
        public bool Xoa(String masach)
        {
            int index = findID(masach);
            if (index != -1)
            {
                lst.RemoveAt(index);
                luuFile(lst);
                return true;
            }
            else
                return false;
        }
        public List<sachBean> Search(string key)
        {
            List<sachBean> tam = new List<sachBean>();
            foreach (sachBean s in lst)
            {
                if (s.Tensach.Trim().ToLower().Contains(key.Trim().ToLower()))
                    tam.Add(s);
            }
            return tam;
        }
    }
}
