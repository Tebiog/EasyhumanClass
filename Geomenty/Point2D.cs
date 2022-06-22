using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    class Point2D
    {
        private int _x;
        private int _y;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public Point2D()
        {
            X = default;
            Y = default;
        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X: {X}; Y: {Y}";
        }
        public static Point2D operator ++(Point2D point)
        {
            point.X++;
            point.Y++;
            return point;
        }
        public static Point2D operator --(Point2D point)
        {
            point.X--;
            point.Y--;
            return point;
        }

        public static Point2D operator -(Point2D point)
        {
            return new Point2D() { X = point.X * -1, Y = point.Y * -1 };
        }
        public static Point2D operator +(Point2D p1, Point2D p2)
        {
            return new Point2D() { X = p1.X + p2.X, Y = p1.Y + p2.Y };
        }
        public static Point2D operator -(Point2D p1, Point2D p2)
        {
            return new Point2D() { X = p1.X - p2.X, Y = p1.Y - p2.Y };
        }
        public static Point2D operator *(Point2D p1, Point2D p2)
        {
            return new Point2D() { X = p1.X * p2.X, Y = p1.Y * p2.Y };
        }
        public static Point2D operator /(Point2D p1, Point2D p2)
        {
            return new Point2D() { X = p1.X / p2.X, Y = p1.Y / p2.Y };
        }
        public static Point2D operator %(Point2D p1, Point2D p2)
        {
            return new Point2D() { X = p1.X % p2.X, Y = p1.Y % p2.Y };
        }
        public static Point2D operator +(int val, Point2D point)
        {
            return new Point2D() { X = point.X + val, Y = point.Y + val };
        }
        public static Point2D operator +(Point2D point, int val)
        {
            return new Point2D() { X = point.X + val, Y = point.Y + val };
        }
        public static Point2D operator +(Point2D point, float val)
        {
            //int tmp = (int)val;                 
            //return new Point2D() { X = point.X + tmp, Y = point.Y + tmp };                    //00:00:00.2754185
            return new Point2D() { X = (int)(point.X + val), Y = (int)(point.Y + val) };    //00:00:00.2620917
        }
        public static Point2D operator +(float val, Point2D point)
        {
            return new Point2D() { X = (int)(point.X + val), Y = (int)(point.Y + val) };
        }
        public override bool Equals(object obj)
        {
            /*Point2D tmp = (Point2D)obj;
            if (tmp.X == X && tmp.Y == Y)
            {
                return true;
            }
            else
            {
                return false;
            } */

            return this.ToString() == obj.ToString();
        }

        public static bool operator ==(Point2D p1, Point2D p2)
        {
            //return p1.ToString() == p2.ToString();
            return p1.Equals(p2);
        }
        public static bool operator !=(Point2D p1, Point2D p2)
        {
            return !(p1 == p2);
        }

        public static bool operator true(Point2D point) 
        {
            return point.X != 0 && point.Y != 0 ? true : false;
        }

        public static bool operator false(Point2D point)
        {
            return point.X == 0 && point.Y == 0 ? true: false;
        }

        
        /*public Point2D this[int index]
        {
            get
            {
                return new Point2D(X, Y); 
            }
            set
            {

            }
        }

        public int this[Point2D point]
        {
            get
            {
                if (true)
                {
                    return 3;
                }
                else
                {
                    return -1;
                }
            }
            private set
            {

            }
        }*/




    }
}
