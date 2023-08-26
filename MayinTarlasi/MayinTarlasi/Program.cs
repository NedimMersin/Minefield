using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinTarlasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Degerler degerler = new Degerler(new bool[10,10]);
            OyunTahtasi oyunTahtasi = new OyunTahtasi(new string[10,11]);
            Oyuncu oyuncu = new Oyuncu(3);
            Console.Write("NickName: ");
            oyuncu.NickName = Console.ReadLine();
            Oyun oyun = new Oyun(oyuncu, degerler, oyunTahtasi);
            oyun.Baslat();
            Console.ReadKey();
        }
    }
}
