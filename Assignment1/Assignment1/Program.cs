using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = {1,2,3,3,3,4,5};
            int[] temp = new int[myArray.Length];
            Array.Sort(myArray);
            int j = 0;
            for (int i = 0; i < myArray.Length-1; i++){
                if (myArray[i] != myArray[i+1])
                {
                    temp[j++]= myArray[i];
                }
            }
            temp[j] = myArray[myArray.Length - 1];
            for (int k = 0; k <= j; k++){
                Console.Write("{0}", temp[k]);
   
            }
            Console.ReadKey();
        }
    } 
}

