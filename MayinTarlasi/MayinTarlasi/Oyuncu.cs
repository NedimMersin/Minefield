using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinTarlasi
{
    class Oyuncu
    {
        public Oyuncu(int can)
        {
            Can = can;
        }
        public int Can { get; set; }
        public int Skor { get; set; }
        public string NickName { get; set; }
    }
}
