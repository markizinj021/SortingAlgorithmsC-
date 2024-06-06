// See https://aka.ms/new-console-template for more information
using System;
namespace SortingAlgorithms
{
class Program
{
    static void BubbleSort(int[]a)
    {
        Console.WriteLine("Original array:");
        foreach(var x in a)
        {
            Console.Write(x+" ");
        }
        for(int i=0;i<a.Length-1;i++)
        {
            for(int j=0;j<a.Length-1-i;j++)
            {
                if(a[j]>a[j+1])
                {
                    int tmp=a[j+1];
                    a[j+1]=a[j];
                    a[j]=tmp;
                }
            }
        }
            Console.WriteLine("\nSorted array:");
        foreach(var x in a)
        {
            Console.Write(x+" ");
        }
        //time complexity is O(n^2)
    }
    static void Main(string[]args)
    {
        Random r=new Random();
        int[]array={r.Next(0,100),r.Next(0,100),r.Next(0,100),r.Next(0,100),r.Next(0,100)};
        BubbleSort(array);
    }
}
}
