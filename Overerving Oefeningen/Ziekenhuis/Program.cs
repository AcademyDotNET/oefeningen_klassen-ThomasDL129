using System;

namespace Ziekenhuis
{
    class Program
    {
        static void Main(string[] args)
        {
            var patient = new Patient("Jos", 5);
            var vpatient = new VerzekerdePatient("Alexandre", 5);

            patient.ToonInfo();
            vpatient.ToonInfo();
        }
    }
}
