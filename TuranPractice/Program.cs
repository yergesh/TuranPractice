int night1 = 7;
int night2 = 8;
int night3 = 6;
int night4 = 7;
int night5 = 8;

// type[] array_name = new type[size];
// type[] array_name = {value1, value2, value3, value4, value5};
int[] nights = {7, 8, 6, 7, 8};
             // 0  1  2  3  4
int[] nights_second = new int[5];
nights_second[0] = 7;
nights_second[1] = 8;
nights_second[2] = 6;
nights_second[3] = 7;
nights_second[4] = 8;
//nights_second[5] = 9; // Error
//nights[5] = 10;

//List
//List<type> list_name = new List<type>();

char[] letters = {'h', 'e', 'l', 'l', 'o'};
string hello = "";
for (int i = 0; i < letters.Length; i++)
{
   hello += letters[i];
}

Console.WriteLine(hello);

//Console.WriteLine(string.Join(',', nights));