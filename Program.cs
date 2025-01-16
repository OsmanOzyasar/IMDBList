using System;

namespace IMDBList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movies> movies = new List<Movies>();
            
            char userInput3;
            do //do while döngüsüyle kullanıcıdan girmek istediği filmler ve onların puanları alınır
            {
                Movies movie = new Movies();
                Console.WriteLine("Eklemek istediğiniz filmin bilgilerini giriniz: ");
                Console.Write("Filmin adı: ");
                string userInput1 = Console.ReadLine();
                movie.Name = userInput1;

                Console.Write("Filmin IMDB puanı: ");
                double userInput2 = Convert.ToDouble(Console.ReadLine());
                movie.ImdbScore = userInput2;

                movies.Add(movie);
                Console.WriteLine("Başka bir film eklemek ister misiniz? (y/n)");
                userInput3 = Convert.ToChar(Console.ReadLine().ToLower());
                if(userInput3 == 'n')
                    break;

            } while (userInput3 == 'y');

            foreach( Movies film in movies ) // foreach döngüsüyle listeye eklenen filmler puanlarıyla birlikte ekrana yazdırılır
            {
                Console.WriteLine("Filmin adı: " + film.Name + " Aldığı skor: " + film.ImdbScore);
            }

            Console.WriteLine("\n4 ile 9 puan arsı filmler: ");
            foreach (Movies film in movies)
            {
                if(film.ImdbScore >= 4 &&  film.ImdbScore <= 9)
                {
                    Console.WriteLine("Filmin adı: " + film.Name + " Aldığı skor: " + film.ImdbScore);
                }
            }

            Console.WriteLine("\n'A' ile başlayan filmler: ");

            foreach( Movies film in movies)
            {
                if (film.Name[0] == 'A')
                {
                    Console.WriteLine("Filmin adı: " + film.Name + " Aldığı skor: " + film.ImdbScore);
                }
            }
        }
    }
}