//namespace AnagramProblem
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            string str1 = "heart";
//            string str2 = "earth";

//            char[] chr1 = str1.ToLower().ToCharArray();
//            char[] chr2 = str2.ToLower().ToCharArray();

//            Array.Sort(chr1);
//            Array.Sort(chr2);

//            string val1 = new string(chr1);
//            string val2 = new string(chr2);

//            Console.WriteLine(val1);
//            Console.WriteLine(val2);
//        }
//    }
//}
namespace BubbleSort
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 68, 50, 41, 88, 9 };
            int temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted");

            foreach (int p in arr)
            {
                Console.Write(p + " ");
                Console.Read();
            }
        }
    }
}