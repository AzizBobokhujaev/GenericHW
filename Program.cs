using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayString = { "a", "b", "c", "d", "e", "f" };
            int[] ArrayInt = { 2, 1, 5, 4, 8 };
            double[] ArrayDouble = { 2.1, 3.5, 8.4, 0.1, 5.7 }; 
            decimal[] ArrayDecimal = { 2.1m, 2.2m, 2.3m, 2.4m, 2.5m, 2.6m, 2.7m };
            float[] ArrayFloat = { 6.1f, 6.2f, 6.3f, 6.4f, 6.5f, 5.6f, 6.7f, 6.8f, 6.9f };
            Console.WriteLine(ArrayhHelper<string>.Pop(ref ArrayString));
            Console.WriteLine(ArrayhHelper<int>.Pop(ref ArrayInt));
            Console.WriteLine(ArrayhHelper<double>.Pop(ref ArrayDouble));
            Console.WriteLine(ArrayhHelper<decimal>.Pop(ref ArrayDecimal));
            Console.WriteLine(ArrayhHelper<float>.Pop(ref ArrayFloat)); 
            System.Console.WriteLine();
            Console.WriteLine(ArrayhHelper<string>.Push(ref ArrayString,"g"));
            Console.WriteLine(ArrayhHelper<int>.Push(ref ArrayInt,3));
            Console.WriteLine(ArrayhHelper<double>.Push(ref ArrayDouble,2.1));
            Console.WriteLine(ArrayhHelper<decimal>.Push(ref ArrayDecimal,2.8m));
            Console.WriteLine(ArrayhHelper<float>.Push(ref ArrayFloat,4.3f));
            System.Console.WriteLine();
            Console.WriteLine(ArrayhHelper<string>.Shift(ref ArrayString));
            Console.WriteLine(ArrayhHelper<int>.Shift(ref ArrayInt));
            Console.WriteLine(ArrayhHelper<double>.Shift(ref ArrayDouble));
            Console.WriteLine(ArrayhHelper<decimal>.Shift(ref ArrayDecimal));
            Console.WriteLine(ArrayhHelper<float>.Shift(ref ArrayFloat));
            System.Console.WriteLine();
            Console.WriteLine(ArrayhHelper<string>.UnShift(ref ArrayString,"O"));
            Console.WriteLine(ArrayhHelper<int>.UnShift(ref ArrayInt,0));
            Console.WriteLine(ArrayhHelper<double>.UnShift(ref ArrayDouble,0.1));
            Console.WriteLine(ArrayhHelper<decimal>.UnShift(ref ArrayDecimal,0.8m));
            Console.WriteLine(ArrayhHelper<float>.UnShift(ref ArrayFloat,0.3f));            
            Console.WriteLine(ArrayhHelper<int>.Slice(ArrayInt,-3));
            
        }
    }
    static class ArrayhHelper<T>
    {
        public static T Pop(ref T[] Array){
            T t;
            t = Array[(Array.Length)-1];
            return t;
        }
        public static int Push(ref T[] Array, T value){
            T[] newArray = new T[Array.Length + 1];
            for (int i = 0; i < Array.Length; ++i)
            {
                newArray[i] = Array[i];
            }
            newArray[Array.Length] = value;
            Console.Write("ArrayString Elements: ");
            for (int i = 0; i < Array.Length + 1; ++i)
            {
                System.Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Array Length: ");
            return newArray.Length;
        }
        public static T Shift(ref T[] Array)
        {
            T t;
            t = Array[0];
            return t;
        }
        public static int UnShift(ref T[] Array, T value)
        {
            T[] newArray = new T[Array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i + 1] = Array[i];
            }
            Console.Write("Array String Elements: ");
            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();
            Console.Write("Array Length: ");
            Array = newArray;
            return newArray.Length;
        }
        public static T[] Slice(T[] Arr, int BeginIndex, int EndIndex = 0)
        {
            int b=0, e=0;
            if (BeginIndex >= 0 && EndIndex >= 0)
            {
                b = BeginIndex;
                e = EndIndex;
            }
            else if (BeginIndex < 0 && EndIndex == 0)
            {
                b=Arr.Length+BeginIndex;
                e=Arr.Length;
            }
            else if (BeginIndex>Arr.Length)
            {
                b=0;
                e=0;
            }
            else if(BeginIndex>=0 && EndIndex<0)
            {
                b=BeginIndex;
                e=Arr.Length+EndIndex;
            }
            T[] Arr2 = new T[Math.Abs(e-b)];
            for (int i = 0; i < Arr2.Length; i++)
            {
                Arr2[i] = Arr[b];
                b++;
            }

            return Arr2;
        }
    }
}
