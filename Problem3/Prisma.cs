namespace Problem3
{
    public class Prisma : IShape
    {
        private float _length;
        private float _width;
        private float _heigh;
        
        public float CalculateArea()
        {
            return _length * _width * _heigh;
        }

        public float CalculatePerimeter()
        {
            // temporary
            return 0;
        }
    }
}