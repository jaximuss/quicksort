//quicksort
public class Program
{
    public static void Main(string[]args)
    {
        int[] ints = { 8,5,9,2,4 };
        int low = 0;
        int high = ints.Length - 1;
        quicksort(ints,ints.Length-1,0);
        foreach(int i in ints)
        {
            Console.WriteLine(i);
        }
    }

    public static void quicksort(int[] arr, int hi, int lo)
    {
        //need to explain this part a little bit bette
         if (lo < hi)
            {
            int pivot = Partition(arr,hi,lo);
            quicksort(arr, pivot-1 , lo);
            quicksort(arr, hi, pivot + 1);
            }
    }

    public static int Partition(int[] arr,int hi, int lo)
    {
        //set the pivot to the last element in the array
        int pivot = arr[hi];
        // set the index to the lowest element in the array
        int index = lo - 1 ;

        for(int i = lo; i < hi; i++)
        {
            if (arr[i] <= pivot)
            {
                index++;
                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
        }
        index++;
        arr[hi] = arr[index];
        arr[index] = pivot;
        return index;
    }
}