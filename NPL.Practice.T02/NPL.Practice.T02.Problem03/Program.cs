using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.Practice.T02.Problem03
{
    enum GraduateLevel
    {
        Excellent, VeryGood, Good, Average, Failed
    }
    interface IGraduate
    {
        void Graduate();
    }
    class Student: IGraduate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public decimal SqlMark { get; set; }

        public decimal CsharpMark { get; set; }
        public decimal DsaMark { get; set; }
        public decimal GPA { get; set; }
        public GraduateLevel GraduateLevel { get; set; }

        public void Graduate()
        {
            GPA = Math.Round((SqlMark + CsharpMark + DsaMark) / 3, 2);
            if (GPA >= 9) { GraduateLevel = GraduateLevel.Excellent; }
            else if (GPA >= 8) { GraduateLevel = GraduateLevel.VeryGood; }
            else if (GPA >= 7) { GraduateLevel = GraduateLevel.Good; }
            else if (GPA >= 5) { GraduateLevel = GraduateLevel.Average; }
            else { GraduateLevel = GraduateLevel.Failed; }
        }
        public string GetCertificate()
        {
            Graduate();
            return "Name: "+ Name +" SqlMarK: "+ SqlMark +  " CsharpMark: "+ CsharpMark + " DsaMark: "+ DsaMark + " GPA: "+ GPA + " GraduateLevel: "+ GraduateLevel;
        }
        public Student(int id, string name, DateTime startDate, decimal sqlMark, decimal csharpMark, decimal dsaMark)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            SqlMark = sqlMark;
            CsharpMark = csharpMark;
            DsaMark = dsaMark;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1, "Peter", new DateTime(1888), 10, (decimal)9.5, 10);
            Console.WriteLine(student.GetCertificate());
        }
    }
}
