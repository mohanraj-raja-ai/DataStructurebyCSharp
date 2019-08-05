#Recursive Binary Search
public static void main()
{
	int[] arr = {5,6,25,28,32,45,55,89,101};

	object t = BinarySearchRecursive(arr, 3, 0, arr.Length - 1);
}

public static object BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min >max)
            {
                return "null";
            }
            else
            {
                int mid = (min + max) / 2;
                if (inputArray[mid] == key)
                {
                    return inputArray[mid];
                }
                else if (key > inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }
                else
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
            }
        }