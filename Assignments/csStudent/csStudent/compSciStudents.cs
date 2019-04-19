using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStudent
{
    class compSciStudents : Student
    {
        // Constants
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_HOURS = 60;

        // Fields
        private string _academicTrack;

        // Constructor
        public compSciStudents(string name, string id, string track)
            : base(name, id)
        {
            _academicTrack = track;
        }

        // AcademicTrack property
        public string AcademicTrack
        {
            get { return _academicTrack; }
            set { _academicTrack = value; }
        }

        // RequiredHours property
        public override double RequiredHours
        {
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
        }
    }
    {

    }
}
