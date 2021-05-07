using System;
using System.Collections.Generic;

namespace Student_Organizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentenlijst = new List<Student>();

            for (int i = 0; i < 5; i++)
            {
                studentenlijst.Add(new Student());
            }


            int keuze;

            do
            {
                PrintMenu();

                keuze = CheckIntInput();

                switch (keuze)
                {
                    case 1:
                        StudentenGegevens(studentenlijst);
                        break;
                    case 2:
                        GegevensTonen(studentenlijst);
                        break;
                    case 3:
                        ZoekenStudent(studentenlijst);
                        break;
                    case 4:
                        VerwijderStudent(studentenlijst);
                        break;
                    default:
                        break;
                }

            } while (keuze != 0);
        }

        private static void VerwijderStudent(List<Student> studentenlijst)
        {
            Console.Clear();
            Console.WriteLine("Welke student wil je verwijderen?");

            int invoer;

            do
            {
                invoer = CheckIntInput();
            } while (invoer > studentenlijst.Count || invoer < 0);

            if (invoer != 0)
            {
                studentenlijst[invoer - 1] = new Student();
            }
        }

        private static void ZoekenStudent(List<Student> studentenlijst)
        {
            Console.Clear();
            Console.WriteLine("Op welke gegevens will je zoeken?");
            Console.WriteLine("1. Naam");
            Console.WriteLine("2. Klas");
            Console.WriteLine("3. Gemiddelde punten groter dan");
            Console.WriteLine("4. Gemiddelde punten kleiner dan");

            int keuze;
            do
            {
                keuze = CheckIntInput();
            } while (keuze < 0 || keuze > 4);

            if (keuze != 0)
            {
                Console.Clear();
                var aantalResultaten = 0;

                if (keuze == 1)
                {
                    Console.WriteLine("Zoek op naam:");
                    var search = Console.ReadLine();

                    foreach (var item in studentenlijst)
                    {
                        if (item.Naam == search && item.Naam != "")
                        {
                            aantalResultaten++;
                            item.GeefOverzicht();
                        }
                    }
                }
                else if (keuze == 2)
                {
                    Console.WriteLine("Zoek op klas:");
                    var search = CheckIntInput();

                    foreach (var item in studentenlijst)
                    {
                        if (item.Klas == (Klassen)(search - 1) && item.Naam != "")
                        {
                            item.GeefOverzicht();
                            aantalResultaten++;
                        }
                    }
                }
                else if (keuze == 3)
                {
                    Console.WriteLine("Zoek op punten groter dan:");
                    var search = CheckIntInput();

                    foreach (var item in studentenlijst)
                    {
                        if (item.BerekenTotaalCijfer() > search && item.Naam != "")
                        {
                            item.GeefOverzicht();
                            aantalResultaten++;
                        }
                    }
                }
                else if (keuze == 4)
                {
                    Console.WriteLine("Zoek op punten groter dan:");
                    var search = CheckIntInput();

                    foreach (var item in studentenlijst)
                    {
                        if (item.BerekenTotaalCijfer() < search && item.Naam != "")
                        {
                            item.GeefOverzicht();
                            aantalResultaten++;
                        }
                    }
                }

                Console.WriteLine($"\nEr zijn {aantalResultaten} resultaten.");
                Console.ReadLine();
            }
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Student gegevens invoeren");
            Console.WriteLine("2. Studenten gegevens tonen");
            Console.WriteLine("3. Zoekfunctie");
            Console.WriteLine("4. Student Verwijderen");
        }

        private static void GegevensTonen(List<Student> studentenlijst)
        {
            Console.Clear();

            foreach (var item in studentenlijst)
            {
                if (item.Naam != "")
                {
                    item.GeefOverzicht();
                }
            }

            Console.ReadLine();
        }

        private static void StudentenGegevens(List<Student> studentenlijst)
        {
            Console.Clear();
            Console.WriteLine("Welke student info wil je invoeren:");

            int index = CheckIntInput();

            if (index > 0)
            {
                if (studentenlijst[index - 1].Naam == "")
                {
                    GegevensInvoeren(studentenlijst[index]);
                }
                else
                {
                    Console.WriteLine("Wil je deze gegevens overschrijven? (J/N)");

                    if (Console.ReadLine().ToUpper() == "J")
                    {
                        GegevensInvoeren(studentenlijst[index - 1]);
                    }
                }
            }            
        }

        private static void GegevensInvoeren(Student student)
        {
            Console.WriteLine("Naam:");
            student.Naam = Console.ReadLine();
            Console.WriteLine("Leeftijd:");
            student.Leeftijd = CheckIntInput();
            Console.WriteLine("Klas: (EA1 = 1 etc.)");
            student.Klas = (Klassen)CheckIntInput();
            Console.WriteLine("Punten Communicatie:");
            student.PuntenCommunicatie = CheckIntInput();
            Console.WriteLine("Punten Programming Principles:");
            student.PuntenProgrammingPrinciples = CheckIntInput();
            Console.WriteLine("Punten Web Technology:");
            student.PuntenWebTech = CheckIntInput();
        }

        private static int CheckIntInput()
        {
            //bool validinput;
            int waarde = 0;

            //do
            //{
            //    validinput = int.TryParse(Console.ReadLine(), out waarde);
            //} while (!validinput);

            try
            {
                waarde = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            return waarde;
        }
    }
}
