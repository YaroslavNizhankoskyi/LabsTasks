using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//•	клас Curiculum: назва освітньої програми (ОП), обсяг в годинах освітньої програми, кількість дисциплін ОП, .

//7.	Визначити в класах відкриті методи для роботи з об’єктами:
//•	запис у текстовий файл значень полів класу (назва освітньої програми (ОП), обсяг в годинах освітньої програми, кількість дисциплін ОП);
//•	Визначення якості освітньої програми за критеріями НАЗЯВО:  

namespace Console_Lab3
{
    internal class Curiculum
    {
        private string EducationalProgram { get; set; }
        private int HoursVolume { get; set; }
        private int NumDisciplines { get; set; }

        public Curiculum()
        {
            EducationalProgram = "";
            HoursVolume = 0;
            NumDisciplines = 0;
        }
        public Curiculum(string EducationalProgram, int HoursVolume, int NumDisciplines)
        {
            this.EducationalProgram = EducationalProgram;
            this.HoursVolume = HoursVolume;
            this.NumDisciplines = NumDisciplines;
        }
    }    
}
