using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOP.Models
{
    public class Silah
    {
        public string Nov;
        private int _tutum;
        public int Tutum
        {
            get
            {
                return _tutum;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Tutum menfi ola bilmez...");
                }
                _tutum = value;
            }
        }
        private int _cariGulleSayi;
        public int CariGulleSayi
        {
            get {
                return _cariGulleSayi;
            }
            set
            {
                if(value < 0) {
                    Console.WriteLine("Cari gulle sayi menfi ola bilmez");
                }
                _cariGulleSayi = value;
            }
        }
        private int _saniyedeGulleSayi;
        public int SaniyedeGulleSayi
        {
            get
            {
                return _saniyedeGulleSayi;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Saniyede atilan gulle sayi menfi ola bilmez");
                }
                _saniyedeGulleSayi = value;
            }
        }

        public void TekAtis(int gulleSayi)
        {
            for (int i = 0; i < gulleSayi; i++)
            {
                if (_cariGulleSayi > 0)
                {
                    CariGulleSayi--;
                    Console.WriteLine("Gulle atildi ve maqazinde " + _cariGulleSayi + " sayda gulle qaldi...");
                }
                else
                {
                    Console.WriteLine("Hal hazirda maqazinde gulle yoxdur, doldurmaq üçün R duymesine klikleyin...");
                    string btn = Console.ReadLine().ToLower();
                    if (btn == "r")
                    {
                        _cariGulleSayi = Tutum;
                        Console.WriteLine("Gulle dolduruldu ve hazirda maqazinde " + CariGulleSayi + " sayda gulle var...");
                    }
                    break;
                }
            }
        }
       
        public void AvtomatAtis(int time)
        {
            int gulleSayi = time * SaniyedeGulleSayi;
            TekAtis(gulleSayi);
        }
    }
}
