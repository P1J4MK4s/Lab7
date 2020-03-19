using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rational
    {
        public double chislit;
        public double znamenat;
        public static readonly int Zero;
        public static readonly int One;
        public Rational(int newChislit,int newZnamenat)
        {
            chislit = newChislit;
            znamenat = newZnamenat;
        }
        public static double Method(double znamenat1, double znamenat2)
        {
            double i = 0;
            double j = 0;
            double maxdel = 1;
            if (znamenat1 > znamenat2) { j = znamenat1;i = znamenat2; }
            else { j = znamenat2; i = znamenat1; }
            for(double k = i;maxdel==1;k++)
            {
                double del1 = k / i;
                double del2 = k / j;
                if (((del1) % 1 == 0) && ((del2) % 1==0)&&(del1 >= 1) && (del2 >= 1)) { maxdel = k; }
            }
            return maxdel;
        }
        public void PrintRational()
        {
            Console.WriteLine("This is class Rational , chislit = {0}, znamenat = {1} ",this.chislit,this.znamenat);
        }
        public Rational Plus(Rational second)
        {
            Rational result = new Rational(0, 0);
            double chislo = Rational.Method(this.znamenat, second.znamenat);
            result.chislit = (this.chislit*(chislo/this.znamenat)) + (second.chislit*(chislo/second.znamenat));
            result.znamenat = chislo;
            return result;
        }
        public static Rational operator +(Rational first,Rational second)
        {
            return first.Plus(second);
        }
        public Rational Minus(Rational second)
        {
            Rational result = new Rational(0, 0);
            double chislo = Rational.Method(this.znamenat, second.znamenat);
            result.chislit = (this.chislit * (chislo / this.znamenat)) - (second.chislit * (chislo / second.znamenat));
            result.znamenat = chislo;
            return result;
        }
        public static Rational operator -(Rational first, Rational second)
        {
            return first.Minus(second);
        }
        public Rational Mult(Rational second)
        {
            Rational result = new Rational(0, 0);
            result.chislit = this.chislit * second.chislit;
            result.znamenat = this.znamenat * second.znamenat;
            return result;
        }
        public static Rational operator *(Rational first, Rational second)
        {
            return first.Mult(second);
        }
        public Rational Divide(Rational second)
        {
            Rational result = new Rational(0, 0);
            result.chislit = this.chislit * second.znamenat;
            result.znamenat = this.znamenat * second.chislit;
            return result;
        }
        public static Rational operator /(Rational first, Rational second)
        {
            return first.Divide(second);
        }

        private Rational(double a, double b, string t)
        {
            chislit = a;
            znamenat = b; 
        }
        static Rational()
        {
            Zero = 0;
            One = 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rational rational = new Rational(5, 8);
            Rational rational1 = new Rational(3, 5);
            //Rational rational2 = rational.Plus(rational1);
            Rational rational2 = rational + rational1;
            rational2.PrintRational();
            Rational rational3 = rational - rational1;
            //Rational rational3 = rational.Minus(rational2);
            rational3.PrintRational();
            Rational rational4 = rational * rational1;
            //Rational rational4 = rational.Mult(rational2);
            rational4.PrintRational();
            Rational rational5 = rational / rational1;
            //Rational rational5 = rational.Divide(rational2);
            rational5.PrintRational();
        }
    }
}
