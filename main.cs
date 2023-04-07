/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.


Alex Olhovskiy
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    //The number of even numbers in the array  
    Console.WriteLine("Enter array size");
    int size=int.Parse(Console.ReadLine());
    int[]arr=MakeArr(size,100,1000);
    Print(arr,size);
    Console.WriteLine("Even numbers: "+EvenNumber(arr,size));
    
    
    //Sum of odd elements
    Console.WriteLine("Enter array size");
    size=int.Parse(Console.ReadLine());
    arr=MakeArr(size,-100,100);
    Print(arr,size);
    Console.WriteLine("Odd numbers sum: "+OddSum(arr,size));
    
    
    //Difference between the maximum and minimum
    Console.WriteLine("Enter array size");
    size=int.Parse(Console.ReadLine());
    double[]d_arr=MakeDoubleArr(size,-100,101);
    Print(d_arr,size);
    Console.WriteLine("Difference between max & min: "+MaxMinDiff(d_arr,size));
  }
  
  
  public static double MaxMinDiff(double [] arr,int size)
  {
      double max=arr[0];
      double min=arr[0];
      for(int i=0;i<size;i++)
      {
          if(arr[i]>max)
          {
              max=arr[i];
          }
          if(arr[i]<min)
          {
              min=arr[i];
          }
      }
      return max-min;
  }
  
  
  public static int OddSum(int [] arr,int size)
  {
      int sum=0;
      for(int i=0;i<size;i++)
      {
          if(i%2!=0)
          {
              sum+=arr[i];
          }
      }
      return sum;
  }
  
  public static int EvenNumber(int [] arr,int size)
  {
      int num=0;
      for(int i=0;i<size;i++)
      {
          if(arr[i]%2==0)
          {
              num++;
          }
      }
      return num;
  }
  
  
  
  public static void Print(int [] arr,int size)
  {
      string str;
      Console.WriteLine();
      for(int i=0;i<size;i++)
      {
          str= i<(size-1)?$"{arr[i]},":$"{arr[i]}";
          Console.Write(str);
      }
      Console.WriteLine();
  }
  
  
  public static int[] MakeArr(int size,int min,int max)
  {
      Random rand=new Random();
      int [] arr=new int [size];
      for(int i=0;i<size;i++)
      {
          arr[i]=rand.Next(min,max);
      }
      return arr;
  }
  
  public static void Print(double [] arr,int size)
  {
      string str;
      Console.WriteLine();
      for(int i=0;i<size;i++)
      {
          str= i<(size-1)?$"{arr[i]},":$"{arr[i]}";
          Console.Write(str);
      }
      Console.WriteLine();
  }
  
  
  public static double[] MakeDoubleArr(int size,int min,int max)
  {
      Random rand=new Random();
      double [] arr=new double [size];
      for(int i=0;i<size;i++)
      {
          arr[i]=Math.Round((min+rand.NextDouble()*(max-min)),2);
      }
      return arr;
  }
  
}


