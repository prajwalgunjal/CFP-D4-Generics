namespace GenericsProblems
{
    internal class Program
    {
        public static void Inte(int[] Number)
        {
            Console.WriteLine("give input to delete ");
            int input = int.Parse(Console.ReadLine());
            int[] temparray = new int[Number.Length - 1];
            int flag = 0;
            for (int i = 0; i < Number.Length; i++)
            {
                if (Number[i] != input)
                {
                    temparray[flag] = Number[i];
                    flag++;
                }
            }
            Console.WriteLine("Modified array:");
            string result = string.Join(", ", temparray.Take(flag));
            Console.WriteLine(result);
        }
        public static void Doub(string[] word)
        {
            Console.WriteLine("give input to delete ");
            string input = Console.ReadLine();
            string[] temparray = new string[word.Length - 1];
            int flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != input)
                {
                    temparray[flag] = word[i];
                    flag++;
                }
            }
            Console.WriteLine("Modified array:");
            string result = string.Join(", ", temparray.Take(flag));
            Console.WriteLine(result);
        }
        public static void Chara(char[] chars)
        {
            Console.WriteLine("give input to delete ");
            char input = Convert.ToChar(Console.Read());
            char[] temparray = new char[chars.Length - 1];
            int flag = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != input)
                {
                    temparray[flag] = chars[i];
                    flag++;
                }
            }
            Console.WriteLine("Modified array:");
            string result = string.Join(", ", temparray.Take(flag));
            Console.WriteLine(result);

        }

        static void Main(string[] args)
        {

            // problem 1 
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] word = { "abc", "def", "ghi" };
            char[] chars = { 'a', 'b', 'c' };
            //Inte(number);
            //Doub(word);
            //Chara(chars);

            // problem 2
            //problem2.usingGenerics(number,2);
            //problem2.usingGenerics(word,"abc");
            //problem2.usingGenerics(chars,'a');

            // problem 4 find max 
            //Problem4 p4 = new Problem4();
            //p4.FindMinNumber(10, 54, 6);
            
            // problem 5 find min float
            //Problem5 p5 = new Problem5();
            //p5.FindMinNumber(10.1f, 5.1f, 6.1f);

            // problem 6 find min string 
            //string str1 = "apple";
            //string str2 = "banana";
            //string str3 = "cherry";
            //Problem6 p6 = new Problem6();
            //p6.FindMinString(str1, str2, str3);

            // problem 7 using generics 
            //Problem7.P7("apple","banana","dog");


            //problem 8 
            Problem8<int> problem8 = new Problem8<int>(1,2,3);
            problem8.testMinimum();

            Problem8<double> problem8_1 = new Problem8<double>(1.1,1.2,1.3);
            problem8_1.testMinimum();

            Problem8<string> problem8_2 = new Problem8<string>("abc","def","xyz");
            problem8_2.testMinimum();

        }
    }
}