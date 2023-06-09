namespace Problem3
{
    public class Regtangle : IShape
    {
        private float _width;
        private float _length;

        public Regtangle(float width, float length)
        {
            this._width = width;
            this._length = length;
        }
        
        public float CalculateArea()
        {
            return _width * _length;
        }

        public float CalculatePerimeter()
        {
            return (_width + _length) * 2;
        }
    }
}