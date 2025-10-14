using System;

class Program
{
    static void Main(string[] args)
    {
        //    Console.WriteLine("Hello Learning03 World!"); 

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());





        
        //fraction2.SetTop(1);
        //fraction2.SetBottom(1);
        //fraction2.GetFractionString();
        //fraction2.GetDecimalValue();

//        fraction2.SetTop(5);
  //      fraction2.SetBottom(1);
    //    fraction2.GetFractionString();
      //  fraction2.GetDecimalValue();

//
  //      fraction2.SetTop(3);
    //    fraction2.SetBottom(4);
      //  fraction2.GetFractionString();
        //fraction2.GetDecimalValue();

//
  //      fraction2.SetTop(1);
    //    fraction2.SetBottom(3);
      //  fraction2.GetFractionString();
        //fraction2.GetDecimalValue();

        



    }


}