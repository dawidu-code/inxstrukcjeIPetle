using System;

namespace instrukcjeipetle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            Console.WriteLine("Zad 1 Utworzo tablice");
            int[] numbers = { 10, 29, 37, 47, 57, 56, 74, 93, 9, 7, 18, 16, 28, 30, 6 };

            //Zadanie 2
            /*
             * Rodzaje tablic:
            - jednowymiarowe => tablica która jest ciągiem elementów
            - wielowymiarowe(matrix) => tablice z wieloma wymiarami zadeklarowanymi tak samo dla każdego wymiaru
            - tablice zagnieżdżone(jagged arrays) => tablica w której znajdują się tablice i maja różną długiść

            tablice zagnieżdżone są nieregularne ich podtablice maja różna długość, przykłady:
            - tablica która zawiera listy osób w klasach, każda klasa ma inną liczbe uczniów
            - kalendarz, kolejne miesiące mają inną liczbę dni
            - lista miast w województwach, każde województwo ma inną liczbe miast

             */


            //Zadanie 3
            Console.WriteLine("\nZad 3 Od 1 elementu do 10");
            for (int i = 0; i < 10; i++)
            {
                    Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine("");

            //Zadanie 4
            Console.WriteLine("\nZad 4 Od 10 elementu do 1");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(numbers[i] + ", ");
            }

            //Zadanie 5

            /*otrzymujemy błąd IndexOutOfRangeException*/

            Console.WriteLine("\n\nZad 5 foreach:");

            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }
            int length = numbers.Length;
            Console.WriteLine($"\nDługość tablicy to: {length}\n");

            //Zadanie 6

            /*
                1.Zmienne można przypisać podczas deklaracji lub później:
                int[] numbers = { 1, 2, 3 }; deklaracja i przypisanie
                numbers[0] = 10; do przypisania potem, a do tego czasu wynoszą 0

                2.Można przypisać w momencie deklaracji:
                int[] numbers = { 1, 2, 3 };

                3.Jeśli tablica jest zainicjalizowana w deklaracji, wartości są umieszczane w pamięci podczas uruchomienia programu.

                4.Dodatkowa inicjalizacja nie jest potrzebna, bo tablica ma wartości domyślne(0 dla int, null dla referencji).
            */

            //Zadanie 7
            Console.WriteLine("Zadanie 7: sortowanie bąbelkowe");

            /*
            Odp:
            
            złożoność czasowa - jak długo działa algorytm w zależności od rozmiaru danych wejściowych w najgorszym przypadku
            złożoność pamiąciowa - tablica którą badamy oraz zmienna temp

            Czy algorytm sortowania bąbelkowego jest wydajnym algorytmem sortowania? Nie, ponieważ występuje n"^2 porówniań
            Czy wyświetlą się dwie takie same liczby? Tak

           */

            int[] unsorted = { 5, 6, 7, 8, 12, 14, 15, 44, 3, 0 };

            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i; j < unsorted.Length; j++)
                {
                    if (unsorted[i] > unsorted[j])
                    {
                        int temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;

                    }
                }
            }

            Console.WriteLine($"\nNajwiększy element zbioru: {unsorted[^1]}");

            foreach (int number in unsorted)
            {
                Console.Write(number + ", ");
            }
        }
    }
}
