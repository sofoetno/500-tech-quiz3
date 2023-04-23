namespace Problem3
{
    public class Triangle : IShape
    {
        private float _heightToSideOne;
        private float _sideOne;
        private float _sideTwo;
        private float _sideThree;
        
        public float CalculateArea()
        {
            return (_sideOne * _heightToSideOne) / 2;
        }

        public float CalculatePerimeter()
        {
            return _sideOne + _sideTwo + _sideThree;
        }
    }
}