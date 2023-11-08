﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3ps2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Convert a string to an integer using TryParse.
            //Console.Write("Enter an integer as a string: ");
            //string intString = Console.ReadLine();
            //if (int.TryParse(intString, out int parsedInt))
            //{
            //    int multipliedInt = parsedInt * 5;
            //    Console.WriteLine($"Parsed integer multiplied by 5: {multipliedInt}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Conversion to integer failed.");
            //}
            //Console.ReadKey();
            // Task 2: Convert a string to a DateTime object using the Convert method.
            //Console.Write("Enter a date as a string: ");
            //string dateString = Console.ReadLine();
            //try
            //{
            //    DateTime parsedDate = Convert.ToDateTime(dateString);
            //    DateTime oneMonthAgo = parsedDate.AddMonths(-1);
            //    Console.WriteLine($"One month ago: {oneMonthAgo:yyyy-MM-dd}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //Console.ReadKey();
            //// Task 3: Convert a string to a TimeSpan object using the Parse method.
            Console.Write("Enter a time span as a string (e.g., '02:30:00'): ");
            string timeSpanString = Console.ReadLine();
            try
            {
                TimeSpan parsedTimeSpan = TimeSpan.Parse(timeSpanString);
                TimeSpan twoHoursLater = parsedTimeSpan.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Two hours later: {twoHoursLater}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid time span format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Time span value is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadKey();

        }
    }
}
