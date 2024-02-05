// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.Intrinsics.Arm;

int  s = 0;

void Task1()
{
    double s0,s1;
    Console.WriteLine("Input 2 numbers ");
    string? str0;
    do
    {
        Console.Write(" Input first number = ");
        str0 = Console.ReadLine();
        s0 = double.Parse(str0);
    } while (str0.Equals(""));
    string? str1;
    do
    {
        Console.Write(" Input second number = ");
        str1 = Console.ReadLine();
        s1 = double.Parse(str1);
    } while (str1.Equals(""));


    double a = Math.Sqrt(Math.Abs(s0) * Math.Abs(s1));
    Console.WriteLine("Geometric mead = " + a);

}

void Task2()
{
    long  s3;
    Console.WriteLine("Input integer numbers ");
    string? str3;
    bool b1 = false;   
    do
    {
        Console.Write(" Number = ");
        str3 = Console.ReadLine();
        if (long.TryParse(str3, out s3))b1=true;
       
    } while ((str3 == null) || !b1);

    Console.WriteLine("Yours number "+ s3 + " ends with 7 - ");
    while (s3 >= 10)
    {
        if (s3 > 100010) s3 -= 100000;
        s3-=10;
    }
    if (s3==7)
    {
        Console.WriteLine("YES");
    }else {
        Console.WriteLine("NO!");
            }
};
void Task3()
{
    long s4,s5;
    Console.WriteLine("WElCOME to TASK3 (2 integers)");
    string? str4;
    bool b2 = false;
    do
    {
        Console.Write(" COORD X = ");
        str4 = Console.ReadLine();
        if (long.TryParse(str4, out s4)) b2 = true;

    } while ((str4 == null) || !b2);
    string? str5;
    bool b3 = false;
    do
    {
        Console.Write(" COORD Y = ");
        str5 = Console.ReadLine();
        if (long.TryParse(str5, out s5)) b3 = true;

    } while ((str5 == null) || !b3);


    int firstCircle(long x, long y)
    {
        double res = 0;
        res = Math.Pow(x, 2) + Math.Pow(y, 2);

        if (res < Math.Pow(3,2)) return -1;
        else if (res > Math.Pow(3,2)) return 1;
        else return 0;
    }
    int secondCircle(long x, long y)
    {
        double res = 0;
        res = Math.Pow(x, 2) + Math.Pow(y, 2);

        if (res < Math.Pow(7, 2)) return -1;
        else if (res > Math.Pow(7, 2)) return 1;
        else return 0;
    }
    int A, B;
    A = firstCircle(s4, s5);
    B = secondCircle(s4, s5);

    if (A == 0 || B == 0)
    {
        if (A == 0) Console.WriteLine("On border of DOWN circle");
        else Console.WriteLine("On border of TOP circle");
    }
    else if (A == 1 && B == -1) Console.WriteLine("Point is in sharped area");
    else Console.WriteLine("Point is out of the area");

   
    

};
void Task4()
{
    long s6, s7;
    Console.WriteLine("WElCOME to TASK4 (first integer (1_4)  &  second integer (6_14))");
    string? str6;
    bool b2 = false;
    do
    {
        Console.Write(" M Card Suit = ");
        str6 = Console.ReadLine();
        if (long.TryParse(str6, out s6) && (1 <= s6 && s6 <= 4) ) b2 = true;

    } while ((str6 == null) || !b2);
    string? str7;
    bool b3 = false;
    do
    {
        Console.Write(" N Card Runk = ");
        str7 = Console.ReadLine();
        if (long.TryParse(str7, out s7) && (6 <= s7 && s7 <= 14)) b3 = true;

    } while ((str7 == null) || !b3);
    string? A;
    string? B;

    switch (s6)
    {
        case 1: A = "Diamonds";
            break;
        case 2:
            A = "Hearts";
            break;
        case 3:
            A = "Clubs";
            break;
        case 4:
            A = "Spades";
            break;
        default:
            A = " ERROR TYPE";
            break;
    }
    switch (s7)
    {
        case 6:
            B = "6";
            break;
        case 7:
            B = "7";
            break;
        case 8:
            B = "8";
            break;
        case 9:
            B = "9";
            break;
        case 10:
            B = "10";
            break;
        case 11:
            B = "Jack";
            break;
        case 12:
            B = "Queen";    
            break;
        case 13:
            B = "King";
            break;
        case 14:   
            B = "Ace";
            break;
       default: B = " ERROR TYPE";   
            break;
    }
   

    Console.WriteLine("YOU card is = " + A + " " + B );

};
void Task5()
{
    double sum(double a, double b)
    {
        return a + b;
    }
    double s8, s9;
    Console.WriteLine("WElCOME to TASK5 (two Real Numbers)");
    string? str7;
    bool b2 = false;
    do
    {
        Console.Write(" first Real = ");
        str7 = Console.ReadLine();
        if (double.TryParse(str7, out s8)) b2 = true;

    } while ((str7 == null) || !b2);
    string? str8;
    bool b3 = false;
    do
    {
        Console.Write(" second Real = ");
        str8 = Console.ReadLine();
        if (double.TryParse(str8, out s9)) b3 = true;

    } while ((str8 == null) || !b3);

    Console.WriteLine("Sum is = " + sum(s8,s9));


};
void Task6()
{
    long s10, s11;
    Console.WriteLine("WElCOME to TASK6 (two Integers for equation)");
    string? str9;
    bool b2 = false;
    do
    {
        Console.Write(" n Integer = ");
        str9 = Console.ReadLine();
        if (long.TryParse(str9, out s10) ) b2 = true;

    } while ((str9 == null) || !b2);
    string? str10;
    bool b3 = false;
    do
    {
        Console.Write(" m Integer = ");
        str10 = Console.ReadLine();
        if (long.TryParse(str10, out s11) && (s11 != 0  && (s11+1) != 0)) b3 = true;

    } while ((str10 == null) || !b3);
    double res3;
    res3 = (s10 + s11)*(((double)s10 +1/(double)s11+1)+(5/ (double)s11));
    Console.WriteLine("Result of equation is : " + res3);
};
void taskSelect()
{
    int variant = 5;
    while (variant < 6)
    {
        Console.WriteLine("Task #?!  (type '0' to STOP)");
        Console.Write(" N# = ");

        string? str ;
        bool b0 = false;
        do
        {
            Console.Write(" (1_6) ");
            str = Console.ReadLine();
            if (int.TryParse(str, out s)) b0 = true;
        } while ((str == null) || !b0);
       
        switch (s)
        {
            case 0:
                variant = 7;
                break;
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
            case 4:
                Task4();
                break;
            case 5:
                Task5();
                break;
            case 6:
                Task6();
                break;
            default:
                Console.WriteLine("!!!wrong(1_6)answer!!!");
                break;
        }
        Console.ReadLine();
    }
   
}
Console.WriteLine("Lab 1 !");
taskSelect();
// continue ...
