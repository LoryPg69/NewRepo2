using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Shape
    {
        public decimal Side { get; private set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }
    public class Square : Shape
    {
        private int Side;

        public Square(int Side)
        {
            this.Side = Side;
        }

        public override void Draw()
        {
            Console.WriteLine("Square");
            base.Draw();
             
        }
        public int area()
        {
            decimal area;
            Console.WriteLine("area triangolo");
            area = Side*2;
            return (int)area;


        }
        public void stampa()
        {
            Console.WriteLine("L'area del quadrato è di " + area());

        }

    }
    public class Triangle : Shape
    {
        public Triangle(decimal Height, decimal Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public override void Draw()
        {

            Console.WriteLine("Triangle");
            base.Draw();


        }

        public int area()
        {
            decimal area;
            Console.WriteLine("area triangolo");
            area = (Height * Width) / 2;
            return (int)area;


        }

        public virtual void stampa()
        {
            Console.WriteLine("L'area del triangolo è di " + area());

        }
        public class Rettangolo : Shape
        {
            private int Side;

            public Rettangolo(int Side)
            {
                this.Side = Side;
            }

            public override void Draw()
            {
                Console.WriteLine("Square");
                base.Draw();

            }
            public int area()
            {
                decimal area;
                Console.WriteLine("area Rettangolo");
                area = Height * Width;
                return (int)area;


            }
            public virtual void stampa(Interface1 writer)
            {
                object value = Interface1.WriteLine("L'area del Rettangolo è di " + area());

            }


        }
    }
    }
