using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customers
    {
        private int demand = 0;
        private int palate;
        public int Demand { get { return demand; } set { demand = value; } }
        public Customers()
        {
        }
        public void SetDemand()
        {
            int tasteTasteValue;
            int tasteTempValue;
            int palateValue;
            int price;
        }
        private int SetTasteTasteValue(TasteOfTheDay tasteOfDay, Random random)
        {
            string taste = tasteOfDay.DayTaste;
            if(taste >=)
        }
        private string GetSourTaste(Recipe recipe)
        {
            string tartness;
            if(recipe.Lemons >= 7 && recipe.Lemons < 10)
            {
                tartness = "sour";
            }else if(recipe.Lemons >= 5 && recipe.Lemons < 7)
            {
                tartness = "standard";
            }else if(recipe.Lemons >= 10)
            {
                tartness = "too sour";
            }
            else
            {
                tartness = "bad";
            }
            return tartness;
        }
        private string GetSweetTaste(Recipe recipe)
        {
            string sweetness;
            if (recipe.Sugar >= 20 && recipe.Sugar < 26)
            {
                sweetness = "sweet";
            }
            else if (recipe.Sugar >= 16 && recipe.Sugar < 20)
            {
                sweetness = "standard";
            }
            else if (recipe.Sugar >= 26)
            {
                sweetness = "too sweet";
            }
            else
            {
                sweetness = "bad";
            }
            return sweetness;
        }
        private string GetTasteTemp(Recipe recipe)
        {
            string temperature;
            if (recipe.Ice >= 35)
            {
                temperature = "ice-cold";
            }
            else if (recipe.Ice >= 25 && recipe.Ice < 35)
            {
                temperature = "cool";
            }
            else
            {
                temperature = "warm";
            }
            return temperature;
        }
    }
}
