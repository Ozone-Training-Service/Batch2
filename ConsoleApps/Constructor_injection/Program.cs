using System;

namespace Constructor_injection
{
    interface Shape
    {
       public  void draw();

    }
    class Triangle: Shape
    {
       public void draw()
        {
            Console.WriteLine("Draw Triangle");
        }

       
    }

    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }


    class HomeController
    {
        private readonly Shape _shape;
        public HomeController(Shape _shape)
        {
            this._shape = _shape;// shape  s=new shape();
        }




        public void Display()
        {
            _shape.draw();
        }


     
    }


    class Program
    {
        static void Main(string[] args)
        {


            HomeController obj = new HomeController(new Triangle());//
           
            obj.Display();
            Console.ReadKey();
        }
    }
}
