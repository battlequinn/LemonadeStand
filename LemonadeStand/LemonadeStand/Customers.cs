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
        public void SetDemand(TasteOfTheDay tasteOfDay, PitcherOfLemonade pitcher,double cupPrice, Random random)
        {
            int tasteValue = SetTasteValue(tasteOfDay, pitcher, random);
            int priceValue = SetPriceValue(cupPrice, random);

            Demand = tasteValue + priceValue + random.Next(0, 26);
        }
        private int SetTasteValue(TasteOfTheDay tasteOfDay, PitcherOfLemonade pitcher, Random random)
        {
            string taste = tasteOfDay.DayTaste;
            string temperature = tasteOfDay.DayTemp;
            string tasteTemp = GetTasteTemp(pitcher);
            string sweet = GetSweetTaste(pitcher);
            string sour = GetSourTaste(pitcher);
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
        private string GetSourTaste(PitcherOfLemonade pitcher)
        {
            string sour;
            if (pitcher.Lemons > 5)
            {
                sour = "sour";
            }else
            {
                sour = "not sour";
            }
            return sour;
        }
        private string GetSweetTaste(PitcherOfLemonade pitcher)
        {
            string sweet;
            if (pitcher.Sugar > 16)
            {
                sweet = "sweet";
            }else
            {
                sweet = "not sweet";
            }
            return sweet;
        }
        private string GetTasteTemp(PitcherOfLemonade pitcher)
        {
            string temperature;
            if (pitcher.Ice > 30)
            {
                temperature = "ice-cold";
            }
            else if (pitcher.Ice >= 20 && pitcher.Ice <= 30)
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
            if(cupPrice < 1)
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