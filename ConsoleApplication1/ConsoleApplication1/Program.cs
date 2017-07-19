using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static public string testS()
        {
            string result = "good____";
            //null parameters
            if (Convert.ToDouble(getS(0,0,0))!=0 ) result = result + "error with null____";
            //right answer
            if (Convert.ToDouble(getS(3, 4, 5)) != 6) result = result + "error with calculation____" + getS(3, 4, 5) + "______";
                //sort
                else if ((Convert.ToDouble(getS(5, 4, 3)) != 6) || (Convert.ToDouble(getS(4, 5, 3)) != 6)) result = result + "error with sort____";
            //not triangle
            if (getS(4, 2, 2) != "NoRectTriangle") result = result + "error with checkRectTriangle____"; ;
            return result;
        }

        static public string getS(double a, double b, double c)
        {
            string result = "not value";
            double t;
            if (a>b) {t=a; a=b; b=t;}
            if (b>c) {t=c; c=b; b=t;}
            if (a * a + b * b == c * c) result = (0.5 * a * b).ToString();
            else result = "NoRectTriangle";
            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("hello world");
            Console.WriteLine(testS());
            Console.ReadLine();

        }

        /*SELECT DISTINCT Name
         * FROM Customers C, Products P
         * WHERE C.CustomerId=P.Customer.ID
         * AND ProductName='MILK'
         * EXCEPT
         *SELECT DISTINCT Name
         * FROM Customers C, Products P
         * WHERE C.CustomerId=P.Customer.ID
         * AND ProductName='Sour cream' AND PurchaiseDatetime > LAST_DAY(DATE_SUB(CURDATE(), INTERVAL 1 MONTH))
         */
    }
}
