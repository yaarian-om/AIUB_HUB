using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK
{
    class Contact
    {
        #region Properties
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender; //M of F
        #endregion Properties

        #region Constructor
        public Contact() { /*Empty Constructor*/}
        public Contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }
        #endregion Constructor

        #region Setter_Getter
        public string PersonName {
            get { return personName; }
            set {
                personName = value;
            }
        }

        public string PersonId
        {
            get { return personId; }
            set
            {
                personId = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
            }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set
            {
                mobileNumber = value;
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }
        #endregion Setter_Getter

        #region My_Methods
        public void showPersonInfo() {
            Console.WriteLine("Person Name = " + PersonName);
            Console.WriteLine("Person  ID = " + personId);
            Console.WriteLine("Person Age = " + age);
            Console.WriteLine("Person Phone Number= " + mobileNumber);
            Console.WriteLine("Person Gender= " + gender);
        }

        public void detectMobileOperator() {
            if (mobileNumber[0] == 0 && mobileNumber[1] == 1 && mobileNumber[2] == 7) {
                Console.WriteLine("GP Number");
            }
            else if (mobileNumber[0] == 0 && mobileNumber[1] == 1 && mobileNumber[2] == 8){
                Console.WriteLine("Robi Number");
            }
            else if (mobileNumber[0] == 0 && mobileNumber[1] == 1 && mobileNumber[2] == 9){
                Console.WriteLine("Banglalink Number");
            }
        }
        #endregion My_Methods


    }
}
