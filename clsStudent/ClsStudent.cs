using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsStudent
{
    class ClsStudent
    {
        private string fio;
        private DateTime birthday;

        private double scholarship;

        public string FIO
        {
            get { return fio; }
            set { fio = value; } 
        }

        public double Scholarship
        {
            get { return scholarship; }
            set { scholarship = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public ClsStudent()
        {
            fio = "";
            birthday = new DateTime(2001, 01, 01);
            scholarship = 0.00;
        }

        public ClsStudent(string f, DateTime d, double s)
        {
            fio = f;
            birthday = d;
            scholarship = s;
        }
        public string PrintToScreen()
        {
            string line = $"Студент {fio} дата рождения {birthday}" + "\n";
            line += $"Получает стипендию в размере {scholarship} рублей" + "\n";

            return line;
        }
        public void SaveToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
            streamWriter.WriteLine("Личные данные студента");
            streamWriter.WriteLine($"ФИО: {fio}");
            streamWriter.WriteLine($"Дата рождения: {birthday.ToString()}");
            streamWriter.WriteLine($"Стипендия: {scholarship.ToString()}");
            streamWriter.Close();
        }
    }
}
