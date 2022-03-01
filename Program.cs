using System;

namespace HazirMetotlarDatetimeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);// günün tarihini getirir
            Console.WriteLine(DateTime.Now.Date);//
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format 
            
            Console.WriteLine(DateTime.Now.ToString("dd"));//24
            Console.WriteLine(DateTime.Now.ToString("ddd"));//saturday yerine sat getirir
            Console.WriteLine(DateTime.Now.ToString("dddd"));// saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));// April

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

            //Math Kütüphanesi 

            Console.WriteLine(Math.Abs(-25));// mutlak demek ABS 
            Console.WriteLine(Math.Sin(10));

            Console.WriteLine(Math.Ceiling(15.3));//15.3 den buyuk tam sayıyı getiriyor
            Console.WriteLine(Math.Round(10.2));//hangisine daha yakınsa onu getirir
            Console.WriteLine(Math.Floor(10.11));// 10.11 den kucuk tam sayıyı getirir

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));


            Console.WriteLine(Math.Pow(3,4));// üs alma islemini yapar 
            Console.WriteLine(Math.Sqrt(9));// karekök alır.
            Console.WriteLine(Math.Log(9)); //9 un e tabanındaki logoritmik karsılıgı 
            Console.WriteLine(Math.Exp(10));//e uzeri 3 verir.
            



        }
    }
}
