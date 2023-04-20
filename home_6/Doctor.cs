using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
    internal class Doctor
    {
        public Specialization Specialization { get; set; }
        public virtual void Treat(Patient patient)
        {
           patient.IsIll = true;
        }
    }

    class Ophthalmologist : Doctor
    {

        public Ophthalmologist()
        {
            Specialization = Specialization.Ophthalmologist;
        }

        public override void Treat(Patient patient)
        {
            base.Treat(patient);
            //Console.WriteLine($"Eye treatment prescribed by an ophthalmologist");
            Console.WriteLine("Treatment has been carried out. Patient status:");
            if (patient.IsIll)
            {
                Console.WriteLine("Healthy");
            }
            else
            {
                Console.WriteLine("Is ill");
            }
        }
    }

    class Dentist : Doctor
    {

        public Dentist()
        {
            Specialization = Specialization.Dentist;
        }

        public override void Treat(Patient patient)
        {
            base.Treat(patient);
            
            Console.WriteLine("Treatment has been carried out. Patient status:");
            if (patient.IsIll)
            {
                Console.WriteLine("Healthy");
            }
            else
            {
                Console.WriteLine("Is ill");
            }
        }

    }


    class Therapist : Doctor
    {

        public Therapist()
        {
            Specialization = Specialization.Therapist;
        }

        public override void Treat(Patient patient)
        {
            base.Treat(patient);
            
            Console.WriteLine("Treatment has been carried out. Patient status:");
            if (patient.IsIll)
            {
                Console.WriteLine("Healthy");
            }
            else
            {
                Console.WriteLine("Is ill");
            }
        }

    }

}
