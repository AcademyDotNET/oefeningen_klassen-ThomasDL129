using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    enum Klassen { EA1, EA2, EA3, EA4 }

    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }

        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }


        public Student()
        {
            Naam = "";
            Leeftijd = 0;
            Klas = Klassen.EA1;
            PuntenCommunicatie = 0;
            PuntenProgrammingPrinciples = 0;
            PuntenWebTech = 0;
        }

        public double BerekenTotaalCijfer()
        {
            return (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
        }

        public override string ToString()
        {
            return $"\n{Naam}, {Leeftijd} jaar\nKlas: {Klas}\n\nCijferrapport\n*************\nCommunicatie:\t\t{PuntenCommunicatie}\nProgramming Principles:\t{PuntenProgrammingPrinciples}\nWeb Technology:\t\t{PuntenWebTech}\nGemiddelde:\t\t{BerekenTotaalCijfer():0.0}\n\n";
        }
    }
}
