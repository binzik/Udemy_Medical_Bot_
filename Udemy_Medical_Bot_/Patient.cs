using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Medical_Bot_
{
    class Patient
    {
        string Name { get; set; }
        int Age { get; set; }
        string Gender { get; set; }
        string MedicalHistory { get; set; }
        string SymptomCode { get; set; }
        string Prescription { get; set; }


        #region Name
        string GetName()
        {
            return Name;
        }

        bool SetName(string name, out string errorMessage)
        {
            //Null statement
            if(string.IsNullOrEmpty(name))
            {
                errorMessage = "Name cannot be null or empty!";
                return false;
            }

            //Shorter than 2 letters
            if(name.Length < 2)
            {
                errorMessage = "Name is to short!";
                return false;
            }

            Name = name;
            errorMessage = string.Empty;

            return true;
        }
        #endregion Name

        #region AGE
        int GetAge()
        {
            return Age;
        }

        bool SetAge(int age, out string errorMessage)
        {
            //
            if(age<0)
            {
                errorMessage = "Age cant be lower than 0";
                return false;
            }

            if (age > 100)
            {
                errorMessage = "Age can't be more than 100";
                return false;
            }



            Age = age;
            errorMessage = string.Empty;

            return true;
        }

        #endregion AGE

        #region Gender

        string GetGender()
        {
            return Gender;
        }

        bool SetGender(string gender, out string errorMessage)
        {
            if(gender.ToLower() != "male" || gender.ToLower() != "female" || gender.ToLower() != "other")
            {
                errorMessage = "Wrond gender written!";
                return false;
            }

            Gender = gender;
            errorMessage = string.Empty;
            return true;
        }
        #endregion
    }
}
