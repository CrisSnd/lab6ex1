using lab6ex1;
using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o metoda care va calcula volumul acestuia.
              Folositi o clasa care va modela un dulap.
              Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
              Cele trei campuri vor fi initializate cu ajutorul constructorului.
              Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
              Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si afisati rezultatul.*/



               CabinetDesign cabinet = new CabinetDesign(300,150,250);

               Console.WriteLine($"The volum of the cabinet is {cabinet.VolumCalc()} cm3");
       
        }

     }
 }

