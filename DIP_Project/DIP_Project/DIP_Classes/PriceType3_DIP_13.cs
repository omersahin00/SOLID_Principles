﻿using System;

namespace SolidProject1_211229013.DIP_Classes
{
	public class PriceType3_DIP_13 : IPrice_DIP_13
    {
        public int Price { get; set; }

        public int CalculatePrice(int counter)
        {
            Price = counter * 20;
            Console.WriteLine("Each product is 20 TL");
            return Price;
        }
    }
}

