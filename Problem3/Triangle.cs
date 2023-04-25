namespace Problem3
{
    public class Triangle : IShape
    {
        private float _sideOne;
        private float _sideTwo;
        private float _sideThree;
        private float _heightToSideOne;

        public Triangle(float sideOne, float sideTwo, float sideThree, float heightToSideOne)
        {
            this._sideOne = sideOne;
            this._sideTwo = sideTwo;
            this._sideThree = sideThree;
            this._heightToSideOne = heightToSideOne;
        }
        
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