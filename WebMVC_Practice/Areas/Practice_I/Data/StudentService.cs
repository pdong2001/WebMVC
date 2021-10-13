using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC_Practice.Areas.Practice_I.Models;

namespace WebMVC_Practice.Areas.Practice_I.Data
{
    public class StudentService:IStudentService
    {
        public List<Student> students = new List<Student>();

        public StudentService()
        {
            students.AddRange(new Student[]
            {
                new Student{ID = 1, Name = "Phạm Văn A", Birth = DateTime.Now.AddDays(-10000), Chemistry=6, Math=10, Domicile=""},
                new Student{ID = 2, Name = "Phạm Văn B", Birth = DateTime.Now.AddDays(-10000), Chemistry=6, Math=10, Domicile=""},
                new Student{ID = 3, Name = "Phạm Văn C", Birth = DateTime.Now.AddDays(-10000), Chemistry=6, Math=10, Domicile=""},
                new Student{ID = 4, Name = "Phạm Văn D", Birth = DateTime.Now.AddDays(-10000), Chemistry=6, Math=10, Domicile=""},
                new Student{ID = 6, Name = "Phạm Văn E", Birth = DateTime.Now.AddDays(-10000), Chemistry=6, Math=10, Domicile=""},
                new Student{ID = 5, Name = "Phạm Văn F", Birth = DateTime.Now.AddDays(-10000), Chemistry=6, Math=10, Domicile=""},
            });
        }

        public void Add(Student request)
        {
            students.Add(request);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public void Sort(int ColNumber)
        {
            switch (ColNumber)
            {
                case 1:
                    students = students.OrderBy(s => s.ID).ToList();
                    break;
                case 2:
                    students = students.OrderBy(s => s.Name).ToList();
                    break;
                case 3:
                    students = students.OrderBy(s => s.Birth).ToList();
                    break;
                case 4:
                    students = students.OrderBy(s => s.Domicile).ToList();
                    break;
                case 5:
                    students = students.OrderBy(s => s.Math).ToList();
                    break;
                case 6:
                    students = students.OrderBy(s => s.Chemistry).ToList();
                    break;
                case 7:
                    students = students.OrderBy(s => s.TotalMark).ToList();
                    break;
                default:
                    break;
            }
        }
    }
    public interface IStudentService
    {
        List<Student> GetAll();
        void Add(Student request);
        void Sort(int ColNumber);
    }
}
