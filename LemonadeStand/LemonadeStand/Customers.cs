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
        public int Demand { get { return demand; } set { demand = value; } }
        public Customers()
        {
        }
        public int SetDemand(TasteOfTheDay tasteOfDay, Recipe recipe, double cupPrice, Random random)
        {
            int tasteValue = SetTasteValue(tasteOfDay, recipe, random);
            int priceValue = SetPriceValue(cupPrice, random);

            Demand = tasteValue + priceValue + random.Next(0, 26);
            return Demand;
        }
        private int SetTasteValue(TasteOfTheDay tasteOfDay, Recipe recipe, Random random)
        {
            string taste = tasteOfDay.DayTaste;
            string temperature = tasteOfDay.DayTemp;
            string tasteTemp = GetTasteTemp(recipe);
            string sweet = GetSweetTaste(recipe);
            string sour = GetSourTaste(recipe);
            int tasteValue = 0;
            if(taste == sweet || taste == sour)
            {
                tasteValue += random.Next(0, 26);
            }else
            {
                tasteValue += random.Next(0, 13);
            }

            if(temperature == tasteTemp)
            {
                tasteValue += random.Next(0, 26);
            }else
            {
                tasteValue += random.Next(0, 13);
            }
            return tasteValue;
        }
        private string GetSourTaste(Recipe recipe)
        {
            string sour;
            if (recipe.Lemons > 5)
            {
                sour = "sour";
            }else
            {
                sour = "not sour";
            }
            return sour;
        }
        private string GetSweetTaste(Recipe recipe)
        {
            string sweet;
            if (recipe.Sugar > 16)
            {
                sweet = "sweet";
            }else
            {
                sweet = "not sweet";
            }
            return sweet;
        }
        private string GetTasteTemp(Recipe recipe)
        {
            string temperature;
            if (recipe.Ice > 30)
            {
                temperature = "ice-cold";
            }
            else if (recipe.Ice >= 20 && recipe.Ice <= 30)
            {
                temperature = "cool";
            }
            else
            {
                temperature = "warm";
            }
            return temperature;
        }
        private int SetPriceValue(double cupPrice, Random random)
        {
            int priceValue = 0;
            if(cupPrice <= 1.50)
            {
                priceValue = random.Next(0, 26);
            }else
            {
                priceValue = random.Next(0, 13);
            }
            return priceValue;
        }
    }
}