using System;
using System.Collections.Generic;

namespace demo_proxy
{
    public class Receptionist : Examinor
    {
        private Doctor doctor;
        private Queue<Patient> patients;    

        public Receptionist(Doctor doctor)
        {
            this.doctor = doctor;
            patients = new Queue<Patient>();
        }

        public override void Examine(Patient patient)
        {
            System.Console.WriteLine("Patient " + patient.Name + ": Please wait in the queue.");
            patients.Enqueue(patient);
        }

        public void Call()
        {
            System.Console.WriteLine("Doctor is ready. Next patient please!");
            if (patients.Count != 0) 
            {
                Patient p = patients.Dequeue();
                doctor.Examine(p);
            }
            else
            {
                System.Console.WriteLine("Empty patient queue!");
            }
        }
    }
}