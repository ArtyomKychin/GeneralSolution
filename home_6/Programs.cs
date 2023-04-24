using System;

namespace home_6 // Note: actual namespace depends on the project name.
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("John", IlnessType.Eyes, true);
            Patient patient2 = new Patient("Robert", IlnessType.Teeth, true);
            Patient patient3 = new Patient("Mary", IlnessType.Other, true);

            Clinic clinic = new Clinic();
            Console.WriteLine(" Welcome to the rural clinic!!!");
            Console.WriteLine("You are sick by default, but we will definitely cure you=)");
            Console.WriteLine(new String('=', 50));

            Doctor doctor1 = clinic.AppointmentDoctor(patient1);
            Console.WriteLine($"Patient: {patient1.Name}, Ilness Type: {patient1.IlnessType }, Doctor Appointed: {doctor1.Specialization}");
            doctor1.Treat(patient1);
            Console.WriteLine(new String ('=', 50));

            Doctor doctor2 = clinic.AppointmentDoctor(patient2);
            Console.WriteLine($"Patient: {patient2.Name}, Ilness Type: {patient2.IlnessType }, Doctor Appointed: {doctor2.Specialization}");
            doctor2.Treat(patient2);
            Console.WriteLine(new String('=', 50));

            Doctor doctor3 = clinic.AppointmentDoctor(patient3);
            Console.WriteLine($"Patient: {patient3.Name}, Ilness Type: {patient3.IlnessType }, Doctor Appointed: {doctor3.Specialization}");
            doctor3.Treat(patient3);
            Console.WriteLine(new String('=', 50));
        }
    }
}