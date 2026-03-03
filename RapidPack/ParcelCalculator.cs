using System;
using Avalonia.Controls;

namespace RapidPack;

    public class ParcelCalculator
    {

        public string? IsOverweight(double weight)
        {
            if (weight > 30)
                return ("Za duża waga!!!!!!!");
            return null;
        }

        public double GetPrice(int weight,int length,int height, int width, string express, string type)
        {
            double price = 10;
            /*double price = 10 + (weight * 2);

            if ((width + length + height) > 150)
                price *= 1.5;*/
            if (express=="ekspresowa")
                price += 15;
            if (type == "Fragile")
                price += 10;
            if (type == "Pallet")
                price = 100;
            
            return price;
        }
    }
