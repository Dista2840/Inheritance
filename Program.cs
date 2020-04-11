using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Dista", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Paimin", 35, "11111111", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("dista", 19, "19112840", "teuku.dista@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
