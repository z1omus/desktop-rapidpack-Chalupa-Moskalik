using System;
using Avalonia.Controls;

namespace RapidPack;

public class ParcelCalculator
{

    public bool IsOverweight(double parsedWeight, string type)
    {
        if (parsedWeight > 30 && type !="Paleta")
            return true;
        return false;
    }

    public (double, string) GetPrice(double weight,double length,double height, double width, string express, string type)
    {
        if(!IsOverweight(weight, type)){
            string summary = "";
            double price = 10 + (weight * 2);

            if(type!="Paleta"){
                if ((width + length + height) > 150)
                {
                    price *= 1.5;
                    summary += "paczka gabarytowa +50% ceny\n";
                }
                if (express == "ekspresowa")
                {
                    price += 15;
                    summary += "ekspresowa wysyłka +15zł\n";
                }
                if (type == "standard")
                    summary += "przesyłka standardowa\n";
                if (type == "Ostrożnie")
                {
                    price += 10;
                    summary += "ostrożna przesyłka +10zł";
                }
            }
            else
            {
                price = 100;
                summary += "paleta - cena 100zł";
            }

            return (price, summary);
        }

        return (0, "Podano za wysoką wagę. Maksymalna waga wynosi 30 kg, chyba, że zamawia się paletę");
    }
}
