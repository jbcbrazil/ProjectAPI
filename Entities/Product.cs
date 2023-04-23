using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFarfetch.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public string? definition {get; set;}
        public Category categorys {get; set;}


        public double taxCategory (Category categorys)
        {
            double tax = 0.0;

            if (categorys == Category.Drink)
            {
                tax = 0.05;
            }
            else if (categorys == Category.Food)
            {
                tax = 0.06;
            }
            else if (categorys == Category.Clothing)
            {
                tax = 0.07;
            }
            return tax;
        }

        
        
        public decimal FinalPrice
        {
            get 
            { 
                double tax = taxCategory(categorys);
                decimal finalPrice = (decimal)(price * stock + (price * tax));
                return Math.Round(finalPrice, 2);
            }
        }
    }

    public enum Category
    {
        Drink,
        Food,
        Clothing
    }
}