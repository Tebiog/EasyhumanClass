namespace SimpleOOP.Geomenty
{
    public interface IFigure<T>
    {
        //to do..........
        public void Draw();

        public T GetPerimeter();

        public T GetArea();
    }
}