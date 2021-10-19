using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_proxy
{
    public class Clinic
    {
        private Doctor doctor;
        private Receptionist receptionist;

        public Clinic()
        {
            doctor = new Doctor("Hoang");
            receptionist = new Receptionist(doctor);
        }

        public void Examine(Patient patient)
        {
            if (patient is SpecialPatient)
            {
                doctor.Examine(patient);
            }
            else
            {
                receptionist.Examine(patient);
            }
        }
    }
}