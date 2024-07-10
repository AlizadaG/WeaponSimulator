using PracticeOOP.Models;

namespace PracticeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Silah silah = new Silah();
            silah.Nov = "ShotGun";
            silah.Tutum = 40;
            silah.CariGulleSayi = 40;
            silah.SaniyedeGulleSayi = 5;


            while (true) {
                Console.WriteLine($"Oyuna xos geldiniz. \n Tek-tek atis etmek ucun A, \n Avtomatik atislar ucun D ,\n Cixis etmek ucun ise W duymesine klikleyin...");
                string btn = Console.ReadLine().ToLower();
                if (btn == "a")
                {
                    Console.Write("Atis miqdarini daxil edin:");
                    try
                    {
                        int count = Convert.ToInt32(Console.ReadLine());
                        silah.TekAtis(count);
                    }
                    catch (Exception message)
                    {
                        Console.WriteLine("Sayı doğru formatda dahil edin. Xeta mesajı:" + message);
                    }
                }
                else if (btn == "d")
                {
                    Console.Write("Nece saniye atis olacagini daxil edin:");
                    try
                    {
                        int count = Convert.ToInt32(Console.ReadLine());
                        silah.AvtomatAtis(count);
                    }
                    catch (Exception message)
                    {
                        Console.WriteLine("Sayı doğru formatda dahil edin. Xeta mesajı:" + message);
                    }
                }
                else if (btn == "w") {
                    break;
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz degerler oyun ucun kecerli deyil...");
                }
            }

        }
    }
}
