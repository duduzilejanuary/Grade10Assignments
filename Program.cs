
//Duduzile January's Take on Microsoft Guided Project 1
using Grade10Assignments;

Console.Title = "Grade 10 Student Assignments";
Console.WriteLine("Grade 10 Mathematics Assignments\n");
Console.WriteLine("Student Name\t\t\t\tAssignment Topic\t\t\tGrade\n=======================================================================================");

StudentAssignment[] studentAssignments = new StudentAssignment[]
{
    new StudentAssignment("Amahle Heleni", "Algebra",90),
    new StudentAssignment("Ndalo January", "Algebra",96),
    new StudentAssignment("Sino Langa", "Algebra",98),
    new StudentAssignment("Mbali Mnguni", "Algebra",90),
};
for (int i = 0; i < studentAssignments.Length; i++)
{
    var assignment = studentAssignments[i];
    Console.WriteLine($"{assignment.StudentName}\t\t\t\t{assignment.AssignmentTopic}\t\t\t\t\t{assignment.Grade}");
}
Console.WriteLine("\n\nTotal Number of Students: {0}", studentAssignments.Length);


Console.ReadLine();