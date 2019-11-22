using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe rantotthus = new Recipe(1111, "Rántotthús", new List<string>() { "Csirke", "Tojás", "Zsemlemorzsa" });
            Recipe rantotthusCopy = (Recipe)rantotthus.DeepCopy();
            rantotthusCopy.Ingredient.Add("Sajt");

            Recipe rizsesHal = new Recipe(1112, "Rizses Hal", new List<string>() { "Hal", "Rizs", });
            Recipe rizsesHalCopy = (Recipe)rizsesHal.DeepCopy();
            rizsesHalCopy.ID = 1110;

            Recipe lecso = new Recipe(1113, "Lecsó", new List<string>() { "Paprika", "Paradicsom","Tojás", "Kolbász" });
            Recipe lecsoCopy = (Recipe)lecso.DeepCopy();
            lecsoCopy.name = "Tojásos Lecsó";

            Recipe bundasKenyer = new Recipe(1114, "Bundáskenyér", new List<string>() { "Kenyér", "Tojás", });

            Recipe spaghetti = new Recipe(1115, "Spaghetti", new List<string>() { "Tészta", "Paradicsom","Sajt","Darálthús" });


            Console.WriteLine(rantotthus.ToString());
            Console.WriteLine(rantotthusCopy.ToString());
            Console.WriteLine();

            Console.WriteLine(rizsesHal.ToString());
            Console.WriteLine(rizsesHalCopy.ToString());
            Console.WriteLine();

            Console.WriteLine(lecso.ToString());
            Console.WriteLine(lecsoCopy.ToString());
            Console.WriteLine();

            Console.WriteLine(bundasKenyer.ToString());
            Console.WriteLine();
            Console.WriteLine(spaghetti.ToString());

            Console.ReadLine();
        }
    }
}
