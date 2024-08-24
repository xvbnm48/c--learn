namespace MyNamespace.for_loop;

public class DSA
{
   public static void BubbleShort(int[] arr)
   {
      int n = arr.Length;
      for (int i = 0; i < n; i++)
      {
         for (int j = 0; j < n - i - 1; j++)
         {
            if (arr[j] > arr[j + i])
            {
               (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
         }
      }
   }
}