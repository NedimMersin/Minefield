using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinTarlasi
{
    class Degerler
    {
        bool[,] _deger;
        public Degerler(bool[,] deger)
        {
            _deger = deger;
            RandomDeger();
        }
        Random Random = new Random();
        void RandomDeger()
        {
            for (int i = 0; i < 5; i++)
            {
                int satir = Random.Next(_deger.GetLength(0));
                int sutun = Random.Next(_deger.GetLength(0));
                if (_deger[satir, sutun])
                {
                    i--;
                    continue;
                }
                _deger[satir, sutun] = true;
            }

        }
        public bool Kontrol(int satir,int sutun)
        {
            return _deger[satir - 1, sutun - 1];
        }
    }
}
