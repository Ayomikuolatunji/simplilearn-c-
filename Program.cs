using System;


namespace Variables
{
    public class UserName
    {
        string FirstName = "Name";
        string LastName = "Age";
        public void getFullName()
        {
            Console.WriteLine("Your first name is {0} {1}", FirstName, LastName);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var getName = new UserName();
            //  getName.FirstName="Ayomiku";
            //  getName.LastName="Olatunji";
            getName.getFullName();
            ConstantTimeComplexities();
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12 };
            int x = 12;
            int res = binarySearch(arr, x);
            if (res == -1)
            {
                System.Console.WriteLine("Number not found");
            }
            else
            {
                System.Console.WriteLine("index found at index of {0}", res);
            }
            LinearTimeComplexities();
            int[] nums = { 10, 2, 42, 43, 64, 25, 46, 27, 18, 29, 101, 12 };
            // int quick = quickSort(nums, left, right);
            System.Console.WriteLine("\nSorted Array");
            QuadracticTimeComplexities(40, 20);
            DataTypes();
        }
        static public void DataTypes()
        {
            sbyte s = -120;
            short h = 30000;
            uint uni = 1000;
            System.Console.WriteLine(s);
            System.Console.WriteLine(h);
            System.Console.WriteLine(uni);
        }
        static public void QuadracticTimeComplexities(int first, int second)
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    System.Console.WriteLine("Loop value {0} {1}", i, j);
                }
            }
        }
        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = pertition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                else if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
        static public int pertition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = (int)arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                }
                else
                {
                    return right;
                }
            }
        }
        static void ConstantTimeComplexities()
        {
            int a = 10;
            int b = 40;
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }
        static int binarySearch(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int medium = low + high - 1 / 2;
                if (arr[medium] == x)
                    return medium;
                else if (arr[medium] < x)
                    low = medium + 1;
                else
                    high = medium - 1;
            }
            return 0;
        }
        static void LinearTimeComplexities()
        {
            string[] personNames = { "Ayo", "miku", "olatunji", "john", "Ibukun" };
            foreach (string person in personNames)
            {
                System.Console.WriteLine(person);
            }
        }
    }
}
