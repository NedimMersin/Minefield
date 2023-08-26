using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinTarlasi
{
    class OyunTahtasi
    {
        string[,] _tahta;
        public OyunTahtasi(string[,] tahta)
        {
            _tahta = tahta;
            Basla();
        }
        void Basla()
        {
            for (int i = 0; i < _tahta.GetLength(0); i++)
            {
                for (int j = 0; j < _tahta.GetLength(1)-1; j++)
                {
                    _tahta[i, j] = "0 ";
                }
                _tahta[i, _tahta.GetLength(1)-1] = "\n";
            }
        }
        public void Yazdir()
        {
            foreach (var item in _tahta)
            {
                Console.Write(item);
            }
        }
        public void Kontrol(int satir,int sutun,bool mayin)
        {
            if (mayin)
            {
                _tahta[satir-1, sutun-1] = "x ";
            }
            else
            {
                _tahta[satir-1, sutun-1] = "+ ";
            }
        }
        public bool Tekrar(int satir,int sutun)
        {
            return _tahta[satir-1, sutun-1] == "+ ";
        }
    }
}
