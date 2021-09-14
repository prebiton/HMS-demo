using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMgmtSystem
{
    class Person
    {
        public string title;
        public string firstName;
        public string lastName;
        public string date;
        public string gender;
        public string address;
        public string phone;
        public string email;
    }

    class Staff: Person
    {
        public string staffId;
        public string joined;
        public string[] education;
        public string[] certification;
        public string[] languagesKnown;
    }

    class Doctor: Staff
    {
        public string[] speciality;
        void prescribeMedication() { }
        void diagnose() { }
        void reccomendProcedure() { }
    }

    class Nurse: Staff
    {
        void testVitals() { }
    }

    class Admin: Staff
    {
        void listUsers() { }
        void disableUser() { }
    }

    class Patient: Person
    {
        public string patientId;
        public string race;
        public string ethinicity;
        public string[] languagesKnown;
        public string[] nomineeIds;
        public string[] prescriptions;
        public struct allergies
        {
            public string[] type;
            public bool[] isFatal;
        }

        void editDetails() { }
        void scheduleAppointment() { }
        void checkVisits() { }
    }

    class Nominee: Person
    {
        public string nomineeId;
        public string patientId;
        public string relationship;
    }

    class Visit
    {
        public string visitId;
        public string appoinmentId;
        public string height;
        public string weight;
        public string[] bloodPressure;
        public string bodyTemp;
        public string respirationRate;
        public struct descript
        {
            public string[] main;
            public string[] description;
        }
        public descript diagnosis;
        public descript procedure;
        public descript medication;
    }

    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
