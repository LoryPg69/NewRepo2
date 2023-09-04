using System;
using System.Collections.Generic;

namespace Esempio_0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = TestClass.Return1();
            int b = TestClass.Return2(10);
            int c = TestClass.Return3<string>("ssjshs");
            int d = TestClass.Return4<double>(5.0000,9.000);



        }
    }
}





















//            //Console.WriteLine("Hello World!");
//            //SpecificClassInt si = new SpecificClassInt(0);
//            //int sum = si.Add(100);
//            //Console.WriteLine(sum);
//            //SpecificClassDouble sd = new SpecificClassDouble(0);
//            //double sumd = sd.Add(100);
//            //Console.WriteLine(sumd);
//            GenericClass<int> si = new GenericClass<int>(10);
//            int sum = 10 + si.Prop;
//            Console.WriteLine(sum);
//            GenericClass<double> sd = new GenericClass<double>(10);
//            double sumd = 10 + sd.Prop;
//            Console.WriteLine(sum);

//            List<int> Lista1 = new List<int>()
//            {
//                1,2, 3, 4, 5
//            };



//        }

        
//        class GenericClass<T>
//        {   //parametro delle classi generiche (T)--> tipo

//            private T _prop;

//            public GenericClass(T param)
//            {
//                _prop = param; //assegnazione--> assegni il valore alla variabile
//            }
//            public T Prop { get { return _prop; } }
           


         
//        }

//    }
//}
    
    
                    
        

////        class SpecificClassInt
////        {
////            private int _prop;

////            public SpecificClassInt(int param)
////            {
////                _prop = param;
////            }
            
////            public int Prop { get { return _prop; } }

////            public int Add(int b)
////            {

////                return _prop + b;
////            }

////            }
////        class SpecificClassDouble
////        {
////            private double _prop;

////            public SpecificClassDouble(double param)
////            {
////                _prop = param;
////            }

////            public double Prop { get { return _prop; } }

////            public double Add(double b)
////            {

////                return _prop + b;
////            }

////        }
////    }
////}

