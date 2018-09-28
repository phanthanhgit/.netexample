using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Model
{
    class sachBean
    {
        private string masach;
        private string tensach;
        private long gia;
        private long soluong;

        public sachBean(string masach, string tensach, long gia, long soluong)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.gia = gia;
            this.soluong = soluong;
        }


        //phat sinh cac thuoc tinh

        public long thanhtien
        {
            get
            {
                return soluong * gia;
            }
        }

        public string Masach
        {
            get
            {
                return masach;
            }

            set
            {
                masach = value;
            }
        }

        public string Tensach
        {
            get
            {
                return tensach;
            }

            set
            {
                tensach = value;
            }
        }

        public long Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public long Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }
    }
}
