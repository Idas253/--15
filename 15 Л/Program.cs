using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Л
{
    internal class Program
    {
        interface ManCloth
        {
            public void ManToCloth();
        }
        interface GirlCloth
        {
            public void GirlToCloth();
        }

        abstract class Cloth
        {
            public int sizeCloth { get; set; }
            public int cost { get; set; }
            public string color { get; set; }
        }

        class Tshirt : Cloth, GirlCloth, ManCloth
        {
            public void ManToCloth()
            {
                Console.WriteLine($"Мужчина надивает футболку: Размер{sizeCloth}, Стоимость {cost}, Цвет {color}");
            }
            public void GirlToCloth()
            {
                Console.WriteLine($"Девушка надивает футболку: Размер{sizeCloth}, Стоимость {cost}, Цвет {color}");
            }
        }
        class Pants : Cloth, GirlCloth, ManCloth
        {
            public void ManToCloth()
            {
                Console.WriteLine($"Мужчина надивает штаны: Размер{sizeCloth}, Стоимость {cost}, Цвет {color}");
            }
            public void GirlToCloth()
            {
                Console.WriteLine($"Девушка надивает штаны: Размер{sizeCloth}, Стоимость {cost}, Цвет {color}");
            }
        }
        class Skirt : Cloth, GirlCloth
        {
            public void GirlToCloth()
            {
                Console.WriteLine($"Девушка надивает юбку : Размер{sizeCloth}, Стоимость {cost}, Цвет {color}");
            }
        }
        class Tie : Cloth, ManCloth
        {
            public void ManToCloth()
            {
                Console.WriteLine($"Мужчина надивает галстук: Размер{sizeCloth}, Стоимость {cost}, Цвет {color}");
            }
        }

        class Atelier
        {
            public void ОдетьМужчину(Cloth[] cloth)
            {
                Console.WriteLine("Одежда мужчины");
                for (int i = 0; i < cloth.Length; i++)
                {
                    Cloth clothes = cloth[i];


                    if (clothes is ManCloth itemForMen)
                    {
                        itemForMen.ManToCloth();
                    }
                }
            }
            public void ОдетьЖенщину(Cloth[] cloth)
            {
                Console.WriteLine("Одежда Женщины");
                for (int i = 0; i < cloth.Length; i++)
                {
                    Cloth clothes = cloth[i];


                    if (clothes is GirlCloth itemForGirl)
                    {
                        itemForMen.GirlToCloth();
                    }
                }
            }
            
        }

        static void Main(string[] args)
        {
            Cloth[] cloth = new Cloth[] 
            { 
                new Tshirt{sizeCloth = 45, color = "Зеленый", cost = 35000},
                new Pants{sizeCloth = 42, color = "Красный", cost = 450200},
                new Skirt{sizeCloth = 46, color = "Белый", cost = 4500},
                new Tie{sizeCloth = 36, color = "Синий", cost = 5500},
            };
            Atelier atelie = new Atelier ();

            atelie.ОдетьМужчину (cloth);
            atelie.ОдетьЖенщину (cloth);
            
        }
    }
}

