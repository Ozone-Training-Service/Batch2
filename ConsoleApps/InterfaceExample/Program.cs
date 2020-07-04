using System;

namespace InterfaceExample
{
    interface ISample
    {
        public void Hello();
         public   void Hai();
        public void GoodMorning();
        

    }

    class Sample : ISample
    {
        public void GoodMorning()
        {
            Console.WriteLine("Good morning");
        }

        public void Hai()
        {
            Console.WriteLine("Hai");
        }

        public void Hello()
        {
            Console.WriteLine("hello");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            ISample sample = new Sample();
            sample.Hello();
            sample.GoodMorning();


        }
    }
}
