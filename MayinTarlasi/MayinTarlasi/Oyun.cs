using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinTarlasi
{
    class Oyun
    {
        Oyuncu _oyuncu;
        Degerler _degerler;
        OyunTahtasi _oyunTahtasi;
        bool devam = true;
        public Oyun(Oyuncu oyuncu, Degerler degerler, OyunTahtasi oyuntahtasi)
        {
            _oyuncu = oyuncu;
            _degerler = degerler;
            _oyunTahtasi = oyuntahtasi;
        }
        public void Baslat()
        {
            Ekran();
            Console.ReadKey();
        }
        void Ekran()
        {
            Console.Clear();
            Console.WriteLine($"Oyuncu: {_oyuncu.NickName}");
            Console.WriteLine($"Can: {_oyuncu.Can}");
            Console.WriteLine($"Skor: {_oyuncu.Skor}\n");
            _oyunTahtasi.Yazdir();
            if (devam)
            {
                Akis();
            }
        }
        void Akis()
        {

            Console.Write("Satır: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sutun: ");
            int sutun = Convert.ToInt32(Console.ReadLine());
            if (_oyunTahtasi.Tekrar(satir,sutun))
            {
                _oyuncu.Can--;
                if (_oyuncu.Can <= 0)
                {
                    Console.WriteLine("Oyun Bitti.");
                    Console.ReadKey();
                    devam = false;
                    return;
                }
                Ekran();
            }
            if (_degerler.Kontrol(satir, sutun))
            {
                _oyuncu.Can--;
                if (_oyuncu.Can <= 0)
                {
                    Console.WriteLine("Oyun Bitti.");
                    devam = false;
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                _oyuncu.Skor += 10;
                if (_oyuncu.Skor == 950)
                {
                    Console.WriteLine("Oyunu Kazandın.");
                    devam = false;
                    Console.ReadKey();
                    return;
                }
            }
            _oyunTahtasi.Kontrol(satir, sutun, _degerler.Kontrol(satir, sutun));
            Ekran();

        }
    }
}
