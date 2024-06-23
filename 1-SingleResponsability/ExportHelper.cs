using System.IO;
using System.Text;

namespace SingleResponsability
{
    public class ExportHelper
    {
        public void ExportStudent(IEnumerable<Student> students)
        {
            StringBuilder sb = new StringBuilder();
            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());

            sb.AppendLine("Id;Fullname;Grades");

            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }

            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
        }
    }
}