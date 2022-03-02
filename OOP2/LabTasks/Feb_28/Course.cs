using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK
{
    class Course
    {
        #region Properties
        private string courseName;
        private string courseCode;
        private int courseCredit;
        #endregion Properties

         #region Constructor
        public Course() { /*Empty Constructor*/}
        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
           
        }
        #endregion Constructor

        #region Setter_Getter_Methods
        public string CourseName
        {
            get { return courseName; }
            set
            {
                courseName = value;
            }
        }

        public string CourseCode
        {
            get { return courseCode; }
            set
            {
                courseCode = value;
            }
        }

        public int CourseCredit
        {
            get { return courseCredit; }
            set
            {
                courseCredit = value;
            }
        }
        #endregion Setter_Getter_Methods

        #region My_Methods
        public void sgowCourseInfo() {
            Console.WriteLine("Course Name = " + courseName);
            Console.WriteLine("Course Credit = " + courseCredit);
            Console.WriteLine("Course ID = " + courseCode);
           
        }
        #endregion My_Methods

    }
}
