using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;


namespace ExamScoreAnalyser
{

       public class Arrays
    {

        
        static void Main(String[] args)
        {

            double median = 0; //this is the middle number.
            int max = 0; //this is the largest number.
            int min = 0; //the minimum number
            int sum = 0; //this will act as total.  
            int mean = 0; //this will act as the average.
            string[] data = File.ReadAllLines("C:\\Users\\Holden\\Desktop\\text files\\scores.txt");
            int[] grades = new int[data.Length];
           
            for (int i = 0; i < data.Length; i++)
            {
                grades[i] = int.Parse(data[i]);
                sum += grades[i];
                mean = sum / grades.Length;
            }
            Console.WriteLine($"the total is: {sum}");
            Console.WriteLine($"the average is: {mean}");

            //this is to grab min and max
            for(int i = 0 ; i < data.Length;i++) 
            {
                Array.Sort(grades); // this sorts the array from least to greatest.
                min = grades[0]; //with the array sorted we are able to grab index 0 as the lowest value.
                max = grades[49]; // we know how many indexes there are because we calculated the total. through this we can get the last index for max. 
            }
            // there is an automated way of getting min and max but this is simple and checked over.
            Console.WriteLine($"the minimum value in the array is: {min}");
            Console.WriteLine($"the maximum value in the array is: {max}");
            
            /* for (int i =0 ; i < data.Length; i++) //this is just to run to see the sorted values when needed.
            {
                Array.Sort(grades);
                Console.WriteLine(grades[i]);
            } */
            
            for(int i = 0 ;i < data.Length;i++)
            {
                Array.Sort(grades);
                int temp = grades.Length / 2;
                double temp2 = grades[temp];
                double temp3 = grades[temp - 1];
                median = (temp2 + temp3) / 2; 
            }

            Console.WriteLine($"the median is: {median}");

        }
        
    }
}