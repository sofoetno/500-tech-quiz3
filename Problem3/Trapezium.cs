namespace Problem3
{
    public class Trapezium : IShape
    {
        private float _baseOne;
        private float _baseTwo;
        private float _heigh;
        private float _legOne;
        private float _legTwo;
        
        
        public float CalculateArea()
        {
            return (_baseOne * _heigh + _baseTwo * _heigh) / 2;
        }

        public float CalculatePerimeter()
        {
            return _baseOne + _baseTwo + _legOne + _legTwo;
        }
    }
}