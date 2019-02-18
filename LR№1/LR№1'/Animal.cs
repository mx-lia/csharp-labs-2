using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LR_1_
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        string[] names = { "Бэмби", "Ирма", "Келли", "Зевс", "Карл", "Лука", "Морти", "Олаф", "Риччи" };
        int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] colors = { "шиншилла", "колорпоинт", "калико", "биколор", "арлекин", "тэбби", "агути" };

        public Cat()
        {
            Random rand = new Random();
            Thread.Sleep(20);
            int j = rand.Next(names.Length);
            int k = rand.Next(ages.Length);
            int m = rand.Next(colors.Length);
            Name = names[j]; Age = ages[k]; Color = colors[m];
        }

        public static int OrderByAscending(Cat x, Cat y)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (y == null)
                    return 1;
                else
                {
                    if (x.Age < y.Age)
                        return -1;
                    if (x.Age > y.Age)
                        return 1;
                    else
                        return 0;
                }
            }
        }

        public static int OrderByDescending(Cat x, Cat y)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else
                    return 1;
            }
            else
            {
                if (y == null)
                    return -1;
                else
                {
                    if (x.Age < y.Age)
                        return 1;
                    if (x.Age > y.Age)
                        return -1;
                    else
                        return 0;
                }
            }
        }

        public override string ToString()
        {
            return Name + " " + Age + " " + Color + "\n";
        }
    }
}
