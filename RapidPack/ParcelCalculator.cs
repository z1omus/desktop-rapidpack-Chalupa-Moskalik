namespace RapidPack;

    public class ParcelCalculator
    {
        private double _weight;
        private double _length;
        private double _height;
        private double _width;
        private bool _express;
        private string _type;

        public ParcelCalculator(double weight, double length, double height, double width, bool express, string type)
        {
            _weight = weight;
            _length = length;
            _height = height;
            _width = width;
            _express = express;
            _type = type;
        }

        public string? IsOverweight()
        {
            if (_weight > 30)
                return ("Za duża waga!!!!!!!");
            return null;
        }

        public double GetPrice()
        {
            double price = 10 + (_weight * 2);

            if ((_width + _length + _height) > 150)
                price *= 1.5;
            if (_express)
                price += 15;
            if (_type == "Fragile")
                price += 10;
            if (_type == "Pallet")
                price = 100;
            
            return price;
        }
    }
