namespace Problem3
{
    public class Prisma : IShape
    {
        private float _legth;
        private float _width;
        private float _heigh;
        
            
        public float CalculateArea()
        {
            return _legth * _width * _heigh;
        }

        public float CalculatePerimeter()
        {
            // temporary
            return 0;
        }
    }
}