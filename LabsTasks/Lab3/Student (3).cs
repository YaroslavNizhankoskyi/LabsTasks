using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//•	клас Student: FirstName, LastName, рік навчання(курс), група, рейтинг, стипендія; 

//7.	Визначити в класах відкриті методи для роботи з об’єктами:
//•	Визначення рейтингу студента як середній бал в сесії за 10 дисциплінами. Оцінки студента генерувати псевдовипадкоми цілими числами в діапазоні від 40 до 100. 
//•	Розрахунок розміру стипендії, якщо рейтинг студента більше 80 балів. Розмір стипендії підвищується для відмінників. 

//8.    Додати до класу Student вбудований (вкладений) клас WorkInCompany(Робота в компанії) з полями: 
//•	Назва компанії
//•	Кількість проектів, які виконує студент на роботі;
//•	Обсяг освітньої програми, яка корелюється (збігається за змістом) з профілем роботи студента.та методами:
//•	Розрахунок обсягу ОП, який можна зарахувати студенту як результат його ироботи в компанії в процесі виконання виробничих проектів;
//•	Формування рекомендацій щодо удосконалення індивідуального навчального плану класу Curiculum для наближення його до профіля роботи студента.  


namespace Console_Lab3
{
    internal class Student
    {
        //small 
        private string firstName;
        private string lastName;
        private int yearOfStudy;
        private int group;
        private int rating;
        private int stipend; //english words

        //getters setters in C#, properties\fields
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get; set; }
        public int YearOfStudy { get => yearOfStudy; set => yearOfStudy = value; }
        public int Rating { get => rating; set => rating = value; }

        public Student()
        {
            firstName = "";
            lastName = "";
            yearOfStudy = 0;
            group = 0;
            rating = 0;
            stipend = 0;
        }

        public Student(string firstName, string lastName, int yearOfStudy, int group, int rating, int stipend)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfStudy = yearOfStudy;
            this.group = group;
            this.rating = rating;
            this.stipend = stipend;
        }

        public void ReadStudentData()
        {
            Console.WriteLine("Enter First Name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter number of year of study:");
            yearOfStudy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of group:");
            group = Convert.ToInt32(Console.ReadLine());
        }

        public int GenerateStudentRating()
        {
            List<int> marks = new List<int>();
            Random random = new Random();
            int subjectsCount = 10;

            for (var i = 0; i < subjectsCount; i++)
            {
                marks.Add(random.Next(40, 100));
            }

            var sumMarks = marks.Sum();
            int mean = sumMarks / subjectsCount; //mean - average
            this.rating = mean;

            return mean;
        }

        public int CalculateScholaship()
        {            
            int stipend = 1000;

            if (rating >= 80)
            {
                stipend *= 2;
                Console.WriteLine("Your stipend has been increased: " + stipend);
            }
            else
            {
                Console.WriteLine("Your stipend: " + stipend);
            }

            return stipend;
        }
    }
}
