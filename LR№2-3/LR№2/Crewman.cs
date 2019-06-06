using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LR_2
{
    public class Crewman
    {
        [Required(ErrorMessage = "Требуется фамилия")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Требуется имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Требуется отчество")]
        public string SecondName { get; set; }
        public int Age { get; set; }
        [Required(ErrorMessage = "Требуется должность")]
        public string Work { get; set; }
        public int Experience { get; set; }

        public Crewman(string surname, string name, string secondName, int age, string work, int exp)
        {
            Surname = surname;
            Name = name;
            SecondName = secondName;
            Age = age;
            Work = work;
            Experience = exp;
        }

        public override string ToString()
        {
            return Surname + " " + Name + " " + SecondName + ", " + Age + ", " + Work + ", стаж: " + Experience;
        }
    }
}
