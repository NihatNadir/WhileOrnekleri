using System;
namespace WhileOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            Console.WriteLine("1->Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");
            int print = 1;

            while (print <= 10) // print değişkenine 1 değerini verip döngüyü 10'a eşit olana kadar 1 arttırarak çalıştırıyoruz.
            {
                Console.WriteLine($"{print}-Kendime inanıyorum, ben bu yazılım işini hallederim!");
                print++;
            }
            Console.WriteLine();

            //2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            Console.WriteLine("2->1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");
            int number = 1;

            while( number <= 20) // number değişkenine 1 değerini verip döngüyü 20'ye eşit olana kadar 1 arttırarak çalıştırıyoruz.
            {
                Console.Write(number + " ");
                number++;
            }
            Console.WriteLine("\n");
            
            //3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            Console.WriteLine("3->1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");
            number = 1;

            while (number <= 20) // number değişkenine 1 değerini verip döngüyü 20'ye eşit olana kadar 1 arttırarak çalıştırıyoruz.
            {
                if (number % 2 == 0) // Eğer number değişkeni 0'a kalansız bölünürse çift olanları alırız ve bunları konsolda yazdırırız.
                Console.Write(number + " ");
                number++;
            }
            Console.WriteLine("\n");


            //4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            Console.WriteLine("4->50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");
            number = 50;
            int total = 0;

            while (number <= 150) // number değişkenine 50 değerini atıyoruz 150'ye kadar 1'er artacak şekilde döngüye sokuyoruz.
            {
                total += number; // total değişkenini number değişkeni ile topluyoruz.
                number++;
            }
            Console.WriteLine($"İşlemin sonucu = {total}\n");

            //5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            Console.WriteLine("5->1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");
            number = 1;
            int oddSum = 0;
            int evenSum = 0;

            while(number <= 120) // number değişkenine 1 değerini atıyoruz 120'ye kadar 1'er artacak şekilde döngüye sokuyoruz.
            {
                if(number % 2 == 0) // Eğer number değişkeni kalansız bölünürse sayı çifttir ve evenSum değişkeni ile number değişkenini toplanır.
                    evenSum += number;

                else oddSum+=number; // Eğer number değişkeni kalanlı bölünürse sayı tektir ve oddSum değişkeni ile number değişkenini toplanır.

                number++;
            }
            Console.WriteLine($"Çift sayıların toplamı = {evenSum}"); // evenSum konsol ekranına yazdırılır.
            Console.WriteLine($"Tek sayıların toplamı = {oddSum}"); // oddSum konsol ekranına yazdırılır.

        }
    }
}