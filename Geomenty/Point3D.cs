
namespace SimpleOOP.Geomenty
{
    class Point3D<T>: IFigure<T>
    {
        public T X { get; set; } = default;

        public T Y { get; set; } = default;

        public T Z { get; set; } = default;

        public Point3D(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D()
        {
            X = default;
            Y = default;
            Z = default;
        }

        public override string ToString()
        {
            return $"Point3D: X {X}; Y {Y}; Z {Z};";
        }

        public void Draw()
        {
            throw new System.NotImplementedException();
        }

        public T GetPerimeter()
        {
            throw new System.NotImplementedException();
        }

        public T GetArea()
        {
            throw new System.NotImplementedException();
        }
    }
}
