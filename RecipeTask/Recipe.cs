using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTask
{
    class Recipe
    {
        public int ID { get; set; }
        public string name { get; set; }
        public List<string> Ingredient { get; set; }

        public Recipe(int ID, string name, List<string> Ingredient)
        {
            this.ID = ID;
            this.name = name;
            this.Ingredient = Ingredient;

        }

        public override string ToString()
        {
            string Ingredient = String.Join(",", this.Ingredient);
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.ID}, {this.name}, {Ingredient}");
            return sb.ToString();
            
        }

        public Recipe DeepCopy()
        {
            List<string> CopiedIngredients = new List<string>();

            foreach (var element in this.Ingredient)
            {
                CopiedIngredients.Add(element);
            }

            Recipe DeepCopyRecipe = new Recipe(this.ID, this.name, CopiedIngredients);

            return DeepCopyRecipe;


                       
        }

    }
}
