namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] birthday = new int[4] {10,26,13,26}; 
         Console.WriteLine("[{0}]", string.Join(", ", birthday));

             string[] names = {"Ali", "Sara", "Safa" };
         Console.WriteLine("[{0}]" , string.Join(", ",names));

             int[,] matryxarr = new int[2, 2];
             matryxarr[0,0] = 12;
             matryxarr[0,1] = 13;
             matryxarr[1,0] = 14;
             matryxarr[1,1]  = 15;
         Console.WriteLine(matryxarr[]);

             int[] slice = birthday[1..3]; //array slicing
         Console.WriteLine("[{0}]", string.Join(", ", birthday));
             Console.WriteLine(slice);

            //chapeau
            int chapeau = birthday[2..^2];
            Console.WriteLine(chapeau); //the slicing will start from the end and the index start from 1

            int x = 5;
            int y = 10;
            String ov=((x / 2) == 0) ? "is even" : "is odd";
            Console.WriteLine(ov);
            Console.WriteLine((x % 2 == 0) ? "is even" : "is odd"); 

            //int z = null;
            String s = null;
            s = " Hajer";
            Console.WriteLine(s);
           
            string str = null;
            str = str ?? "youssif";
            String s1 = null;
            Console.WriteLine(s1?.ToUpper()); //here error beacouse cann't do change when value is null

            { //block statment
                int a = 13;
                Console.WriteLine(a);
            }
            //prefix & postfix
            int b = 1;
           Console.WriteLine(b++);
            Console.WriteLine(++b);

        

        }
    }
}