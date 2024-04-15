using System;
using System.Linq;
using System.Net.WebSockets;
namespace bludBlud
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public double Tuition { get; set; }
    }
    public class StudentClubs
    {
        public int StudentID { get; set; }
        public string ClubName { get; set; }
    }
    public class StudentGPA
    {
        public int StudentID { get; set; }
        public double GPA { get; set; }
    }
    static void Main(string[] args)
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Frank Furter", Age = 55, Major="Hospitality", Tuition=3500.00} ,
                new Student() { StudentID = 2, StudentName = "Gina Host", Age = 21, Major="Hospitality", Tuition=4500.00 } ,
                new Student() { StudentID = 3, StudentName = "Cookie Crumb",  Age = 21, Major="CIT", Tuition=2500.00 } ,
                new Student() { StudentID = 4, StudentName = "Ima Script",  Age = 48, Major="CIT", Tuition=5500.00 } ,
                new Student() { StudentID = 5, StudentName = "Cora Coder",  Age = 35, Major="CIT", Tuition=1500.00 } ,
                new Student() { StudentID = 6, StudentName = "Ura Goodchild" , Age = 40, Major="Marketing", Tuition=500.00} ,
                new Student() { StudentID = 7, StudentName = "Take Mewith" , Age = 29, Major="Aerospace Engineering", Tuition=5500.00 }
        };
        // Student GPA Collection
        IList<StudentGPA> studentGPAList = new List<StudentGPA>() {
                new StudentGPA() { StudentID = 1,  GPA=4.0} ,
                new StudentGPA() { StudentID = 2,  GPA=3.5} ,
                new StudentGPA() { StudentID = 3,  GPA=2.0 } ,
                new StudentGPA() { StudentID = 4,  GPA=1.5 } ,
                new StudentGPA() { StudentID = 5,  GPA=4.0 } ,
                new StudentGPA() { StudentID = 6,  GPA=2.5} ,
                new StudentGPA() { StudentID = 7,  GPA=1.0 }
            };
        // Club collection
        IList<StudentClubs> studentClubList = new List<StudentClubs>() {
            new StudentClubs() {StudentID=1, ClubName="Photography" },
            new StudentClubs() {StudentID=1, ClubName="Game" },
            new StudentClubs() {StudentID=2, ClubName="Game" },
            new StudentClubs() {StudentID=5, ClubName="Photography" },
            new StudentClubs() {StudentID=6, ClubName="Game" },
            new StudentClubs() {StudentID=7, ClubName="Photography" },
            new StudentClubs() {StudentID=3, ClubName="PTK" },
        };
        //a)
        var studentBruh = studentGPAList.Where(s => s.GPA < 1.0 && s.GPA > 4.0)
            .OrderByDescending(s => s.StudentID);
        //b)
        var studentBruh2 = studentClubList.Where(s => s.ClubName == "Photography" && s.ClubName == "Game" && s.ClubName == "PTK")
            .OrderByDescending(s => s.ClubName);
        //c)
        var studentBruh3 = studentGPAList.Count(s => s.GPA <2.5 && s.GPA >4.0);
        //d)
        var studentBruh4 = studentList.Average(s => s.Tuition);
        //e
        var studentBruh5 = studentList.Max(s => s.Tuition);
        foreach (var s in studentBruh) 
            
        {
            //This doesn't look like the right track
        }
    }
}
