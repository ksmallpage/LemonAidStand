using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Recipe
    {
        // member variables ( HAS A )

       private Recipe recipe = new Recipe();
       public Pitcher pitcher = new Pitcher();
       public CupPrice cupprice = new CupPrice();


        // Contstructor ( SPAWNER )
        public Recipe()
        {

        }

        // Methods ( CAN DO )

        public void CreateRecipe()
        {
           //  Create a Recipe 
        }

        public void StoreRecipe()
        {
            // Store the Recipe
        }

        public void UpdateRecipe()
        {
            // update the recipe
        }

        public void DisplayRecipe()
        {

        }

    }
}
