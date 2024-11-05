internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = new int[10];
        int[] copyA = new int[10];

        //inserting values into my first array
        for(int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("Enter your value: ");
            a[i] = int.Parse(Console.ReadLine());

        }

        //object value = CopyArray(a, copyA);
        //calling method and using it 
        copyArray(a, copyA);
        //this loop copies every element and creates a copy
        //copy from a to copyA array
        //for(int i = 0; i < copyA.Length; i++)
        //{
        //    copyA[i] = a[i];
        //}

        //printing values from my first array
        Console.WriteLine("Elements in array a: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);

        }

        Console.WriteLine("Elements in array copy a array: ");
        for (int i = 0; i < copyA.Length; i++)
        {
            Console.WriteLine(copyA[i]);

        }


        


    }
    //method way, right outside main method
    public static void copyArray(int[] a, int[] copy)
    {

        for (int i = 0; i < copy.Length; i++)
        {
            copy[i] = a[i];
        }

    }




}