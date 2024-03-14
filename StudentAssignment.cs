using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade10Assignments
{
    public class StudentAssignment
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string AssignmentTopic {  get; set; }
        public int Grade { get; set; }

        public StudentAssignment(string studentName, string assignmentTopic, int grade)
        {
            StudentName = studentName;
            AssignmentTopic = assignmentTopic;
            Grade = grade;
        }
    }
}
