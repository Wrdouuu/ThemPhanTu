using System;

namespace THEMPHANTU
{
  class Program
{
    static void Main(string[] args)
    {
        int i;
        int n;
        int x;
        int j;


        int[] numbers=new int[10];
        
        Console.WriteLine("Nhap kich co mang: ");
        n = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Nhap {0} phan tu trong mang: ",n);
        for(i=0;i<n;i++)
        {
            numbers[i]=Convert.ToInt32(Console.ReadLine()) ;
        }

        Console.WriteLine("Nhap vi tri phan tu can duoc chen: ");
        j = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nhap gia tri can chen: ");
        x = Int32.Parse(Console.ReadLine());

        for (i = n; i >= j; i--)
        {
            numbers[i]=numbers[i-1];
           

        }
        numbers[j-1]=x;
 
        Console.WriteLine("Mang moi: ");
        for (i = 0; i <= n; i++)
        Console.WriteLine(numbers[i]);
        Console.ReadKey();








    }
}
  
}

