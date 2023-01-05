class Program
{
   



    public static void Add(ref int[] array, ref int[] array2)
    {
        int[] newArray= new int[array.Length+array2.Length];

        for (int i = 0; i < array.Length || i < array2.Length; i++)
        {
            newArray[i] = array[i];
            newArray[i + array.Length] = array2[i];
        }

        array = newArray;
    }



    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4 ,5,6};
        int[] myArray2 = { 1, 2, 3, 4 ,5,6};
        Add(ref myArray, ref myArray2);
        foreach (int i in myArray)
        {
            Console.WriteLine(myArray[i]);
        }
        
    }
}