using System;
using System.Threading;

namespace Full_GRASP_And_SOLID
{
    public class TimerRecipe : TimerClient
    {
            public Recipe recipe;

            public TimerRecipe(Recipe recipe)
            {
                this.recipe = recipe;
            }
            public void TimeOut()
            {
                this.recipe.Finish();
            }
    }
}