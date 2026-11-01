using System.Collections.Specialized;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            //int cin = 0;
            //cin = Convert.ToInt32(Console.ReadLine());
            //if(cin >= 1 && cin <= 100)
            //{
            //    if (cin % 15 == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    else if (cin % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else if (cin % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(cin);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
            #endregion

            #region 2
            //double a = 0;
            //a = Convert.ToDouble(Console.ReadLine());
            //double b = 0;
            //b = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(a / 100 * b);

            #endregion

            #region 3

            //int a = 0;
            //a = Convert.ToInt32(Console.ReadLine());
            //int b = 0;
            //b = Convert.ToInt32(Console.ReadLine());
            //int c = 0;
            //c = Convert.ToInt32(Console.ReadLine());
            //int d = 0;
            //d = Convert.ToInt32(Console.ReadLine());

            //int num = a * 1000 + b * 100 + c * 10 + d;
            //Console.WriteLine(num);
            #endregion

            #region 4
            //int num = 0;
            //num = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //int temp = num;
            //while (temp > 0)
            //{
            //    temp /= 10;
            //    count++;
            //}
            //if(count != 6)
            //{
            //    return;
            //}
            //int a = 0;
            //a = Convert.ToInt32(Console.ReadLine());
            //int b = 0;
            //b = Convert.ToInt32(Console.ReadLine());
            //if (a > 6 || a < 1 || b > 6 || b  < 1)
            //{
            //    return;
            //}
            //int[] nums = new int[6];

            //int temp2 = num;
            //for(int i = 5; i >= 0; i--)
            //{
            //    nums[i] = temp2 % 10;
            //    temp2 /= 10;
            //}
            //int temp3 = nums[a - 1];
            //nums[a - 1] = b;
            //nums[b-1] = temp3;
            //int final = nums[0] * 100000 + nums[1] * 10000 + nums[2]*1000 + nums[3]*100 + nums[4]*10 + nums[5];
            //Console.WriteLine(final);
            #endregion

            #region 5
            //string date = " ";
            //date = Console.ReadLine();
            //string[] datearr = date.Split('.');
            //if (datearr.Length != 3)
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}
            //int day = int.Parse(datearr[0]);
            //int month = int.Parse(datearr[1]);
            //int year = int.Parse(datearr[2]);

            //DateOnly dat = new DateOnly(year, month, day);

            //DayOfWeek finalDay = dat.DayOfWeek;
            //string finalSeason = " ";
            //if (month == 12 || month == 1 || month == 2)
            //{
            //    finalSeason = "Winter";
            //}
            //else if (month == 3 || month == 4 || month == 5)
            //{
            //    finalSeason = "Spring";
            //}
            //else if (month == 6 || month == 7 || month == 8)
            //{
            //    finalSeason = "Summer";
            //}
            //else if (month == 9 || month == 10 || month == 11)
            //{
            //    finalSeason = "Autumn";
            //}
            //else
            //{
            //    finalSeason = "Error";
            //}
            //Console.WriteLine($"{finalSeason} {finalDay}");

            #endregion

            #region 6

            //double temerature = 0;
            //temerature = Convert.ToDouble(Console.ReadLine());
            //double out_temp = 0;
            //Console.WriteLine("C -> F: 1\nF -> C: 2");
            //int choice = 0;
            //choice = Convert.ToInt32(Console.ReadLine());
            //if(choice != 1 && choice != 2)
            //{
            //    return;
            //}

            //if(choice == 1)
            //{
            //    out_temp = temerature * 9/5 + 32;
            //}
            //else if (choice == 2)
            //{
            //    out_temp = (temerature - 32) * 5 / 9;
            //}

            //Console.WriteLine(out_temp);
            #endregion

            #region 7

            //int a = 0;
            //int b = 0;
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());

            //if( a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}
            //for(int i = a; i <=b; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 8

            //int a = 0;
            //a = Convert.ToInt32(Console.ReadLine());

            //int temp = a;
            //int count = 0;
            //while (temp != 0)
            //{
            //    temp /= 10;
            //    count++;
            //}

            //int temp2 = a;
            //int[] arr = new int[count];
            //for(int i = 0; i < count; i++)
            //{
            //    arr[i] = temp2 % 10;
            //    temp2 /= 10;
            //}
            //int Arm = 0;
            //for(int i = 0; i < count; i++)
            //{
            //    Arm += (int)Math.Pow(arr[i], count);
            //}
            //if(Arm == a)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            #endregion

            #region 9


            int a = 0;
            a = Convert.ToInt32(Console.ReadLine());

            int final = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    final += i;
                }
            }
            if (a == final)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            #endregion
        }
    }
}
