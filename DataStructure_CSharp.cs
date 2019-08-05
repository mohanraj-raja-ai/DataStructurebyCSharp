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


#Stack
class Program
    {
	static int[] stack = new int[100];
        static int top = -1;


        static void Main(string[] args)
	{
		 Stack();
	}

 	public static void Stack()
        {
            int n = 0;
            Console.WriteLine("Do you want to continue if Yes, Press any number, else press -1");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != -1)
            {
                Console.WriteLine("Enter the choice: (1)PUSH (2)POP");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the element to Push");
                    int element = Convert.ToInt32(Console.ReadLine());
                    Push(element);
                }

                else
                {
                    Console.WriteLine("Enter the element to POP");
                    int element = Convert.ToInt32(Console.ReadLine());
                    Pop();
                }
                Console.WriteLine("Do you want to continue if Yes, Press any number, else press -1");
                n = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static object Push(int element)
        {
            if (top == 99)
                return "stack is full";
            else
            {
                top++;
                stack[top] = element;
                return "Pushed to stack";
            }

        }

        public static object Pop()
        {
            if (top == -1)
                return "stack is empty";
            else
            {
                return stack[top--];
            }
        }
}
