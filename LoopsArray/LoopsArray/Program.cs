
#region HomeWork

//int num = 0;

//if (num > 0)
//{
//    Console.WriteLine("Musbet");
//}
//else if (num == 0)
//{
//    Console.WriteLine("Neytral");
//}
//else
//{
//    Console.WriteLine("Menfi");
//}




//Task 2

//int num = 30;

//if (num % 21==0)
//{
//    Console.WriteLine("Her ikisine bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}

//if (num%3==0 && num % 7 == 0)
//{
//    Console.WriteLine("Her ikisine bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}


//Task 3

//int num = 24;
//int temp = num % 10; //5
//int dec = num / 10;  //4

//if (num%10 > num/10)
//{
//    Console.WriteLine(num%10);
//}
//else
//{
//    Console.WriteLine(num/10);
//}


//if (temp > dec)
//{
//    Console.WriteLine(temp);
//}
//else
//{
//    Console.WriteLine(dec);
//}

#endregion

//ctrl+k+s
#region SwitchCase
//Switch Case

//int num = 3;

//switch (num)
//{
//    case 1:
//        Console.WriteLine("Ana dili secildi");
//        break;
//    case 2:
//        Console.WriteLine("Rus dili secildi");
//        break;
//    case 3:
//        Console.WriteLine("English secildi");
//        break;
//    default:
//        Console.WriteLine("Yanlish input");
//        break;
//}

//string day = "monday";

//switch (day)
//{
//    case "monday" or "tesday" or "wednesday":

//        Console.WriteLine("Ish gunudur");
//        break;

//    case "saturday": 
//    case "sunday":
//        Console.WriteLine("qeyri ish gunu");
//        break;
//}

#endregion

#region Loops

//for (int i = 10; i < 11; i--)
//{
//    Console.WriteLine(i);
//    //if (i % 2 != 0)
//    //{
//    //    Console.WriteLine(i);
//    //}
//}





//While

//Console.WriteLine("Do you want close the program?(yes/no)");
//string answer=Console.ReadLine();

//while (answer != "yes")
//{
//    Console.WriteLine("Program work");
//    Console.WriteLine("Do you want close the program?(yes/no)");
//    answer=Console.ReadLine();
//}


//do while
//string answer = "";
//do
//{
//    Console.WriteLine("Do you want close the program?(yes/no)");
//    answer = Console.ReadLine();
//    Console.WriteLine("program worked");
//} while (answer!="yes");



//int i = 0;

//while (i <= 10)
//{
//    int a = 20;
//    Console.WriteLine(i);
//    i++;
//}


#endregion

#region ForClasswork
//int sum = 0;
//for (int i = 1; i < 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }

//}


//Console.WriteLine(sum);

#endregion

#region WhileClasswork

//55432

//int num = 5;
//int count = 0;

//while (num != 0)
//{
//    num /= 10;
//    count++;
//}

//Console.WriteLine(count); 
#endregion

#region Array

// 1       2       3         4       5     6
//string[] arr = { "Ali", "Elmar", "Tahir", "Aysun","Isa","Asif"};
// 0        1       2        3       4     5


//for (int i = 0; i< students.Length; i++)
//{

//    students[i] += " PB502";
//    Console.WriteLine(students[i]);
//}

//Console.WriteLine(students[students.Length-1]);

//students[0]="Senan";
//Console.WriteLine(students.Length);
//Console.WriteLine(students[0]);


//int[] nums = new int[4];
//int[] nums2= new int[4] {1,2,3,4 };

//nums[0] = 1;
//nums[1] = 2;
//nums[2] = 3;
//nums[3] = 4;


//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}


//01234
//string word = "Salam";
//string newWord = "";
//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i] != 'm')
//    {
//        newWord += word[i];
//    }

//}

//Console.WriteLine(newWord);

#endregion

#region ArrayClasswork
//int[] nums = { 10, 20, 11, 34, 55 };
//int sum = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 != 0)
//    {


//        //Console.WriteLine(nums[i]/2);
//        Console.WriteLine(nums[i]);
//        sum += nums[i];
//        //Console.WriteLine(nums[i]);
//    }
//}

////Console.WriteLine(sum); 
#endregion