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
    }
