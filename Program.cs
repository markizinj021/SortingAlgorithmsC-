using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Program
    {
    static void Merge(int[]a,int i,int m, int[]b,int j,int n, int[]c,int k)
        {
            while(i<=m&&j<=n)
            {
                //comparing and sorting elements
                if (a[i] <= b[j])
                {
                    c[k] = a[i];
                    k++;
                    i++;

                }
                else
                {
                    c[k] = b[j];
                    k++;
                    j++;
                }
      
            }
            // merging any leftovers (most probably one will have it, the other one won't)
            while (i <= m)
            {
                c[k] = a[i];
                k++;
                i++;
            }
            while (j <= n)
            {
                c[k] = b[j];
                k++;
                j++;
            }
        }
        static void MergeSort(int[]main,int l,int r, int[]tmp)
        {
        if(l<r)
            {
                //calculate the middle point
                int m = (l + (r - l) / 2);
                // split the first half with recursion
                MergeSort(main,l,m,tmp);
                //s split the second half with recursion
                MergeSort(main,m+1,r,tmp);
                //merge them together
                Merge(main, l, m, main, m + 1, r, tmp, l);
                //copy the array 
                for (int i = l; i <=r; i++)
                {
                    main[i] = tmp[i];
                }
            }
        }
        
        static void Main(string[] args)
        {
            //n=> size of the array
            int n = int.Parse(Console.ReadLine());
            int[] main = new int[n];
            for (int i = 0; i < n; i++)
            {
                //input line by line
                main[i] = int.Parse(Console.ReadLine());

            }
            int[] tmp = new int[n];
            MergeSort(main, 0, n - 1,tmp);
            foreach (var item in main)
            {
                Console.Write(item+" ");
            }
        }
    }
}
