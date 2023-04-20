using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_6
{
    internal class Clinic
    {
        public virtual Doctor AppointmentDoctor(Patient patient)

        {
            Doctor doctor = new Doctor();

            switch (patient.IlnessType)
            {
                case IlnessType.Eyes:
                    doctor = new Ophthalmologist();
                    break;
                case IlnessType.Teeth:
                    doctor = new Dentist();
                    break;
                case IlnessType.Other:
                    doctor = new Therapist();
                    break;
            }
            return doctor;
        }
    }
}
