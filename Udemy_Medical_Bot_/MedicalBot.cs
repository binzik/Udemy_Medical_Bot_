using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Medical_Bot_
{
    internal class MedicalBot
    {
        static string BotName = "Bob";


        static string GetBotName()
        {
            return BotName;
        }

        //Powinien zwrócić leki jakie potrzebuje pacejnt
        void PrescribeMedication(Patient patient)
        {
            //TODO
            //If the patient's symptoms are a headache, prescribe ibuprofen.

            //If the patient's symptoms are skin rashes, prescribe diphenhydramine.

            //If the patient's symptoms are dizziness, check if the patient has a medical history of diabetes. If they do, prescribe metformin. Otherwise, prescribe dimenhydrinate.


            GetDosage("", patient);
        }

        string GetDosage(string medicineName, Patient patient)
        {
            if (medicineName == "ibuprofen")
            {
                if(patient.)
            }


            return "";
        }

    }
}
