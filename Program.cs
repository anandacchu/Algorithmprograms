namespace BinarySearchTree
{
    class program
    {
        public static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(45);
            binaryTree.Add(30);
            binaryTree.Add(46);
            binaryTree.Add(50);
            binaryTree.Add(60);
            binaryTree.Add(15);

            BinaryTree.TraversePreorder(binaryTree.Root);

            //BUBBLE SORT
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for(int j=0;j<arr.Length-2;j++)
            {
                for(int i=0; i <= arr.Length-2; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        temp = arr[i+1];
                        arr[i+1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("sorted Array");
            foreach(int ele in arr)
            {
                Console.WriteLine(ele+" ");
            }
        }   
    }
}
