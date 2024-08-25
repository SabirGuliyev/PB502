

//int num = 100000;


//if (num % 2 == 0)
//{
//    Console.WriteLine(num);
//}
//else
//{
//    Console.WriteLine("Deyil");
//}

//for (int i = 0; i < num; i++)
//{
//    Console.WriteLine(i);
//}


//int[] nums = { 20, 30, 55, 67, 78,90,99,100};




//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine(nums[i]);


//for (int i = 0; i < 11; i++)
//{
//    Console.WriteLine(nums[i]);
//}


//int num = 49;

//bool result = false;

//int count = 0;


//for (int i = 2; i * i <= num; i++)
//{

//    count++;

//    if (num % i == 0)
//    {
//        result = true;
//        break;
//    }

//}


//if (result)
//{
//    Console.WriteLine("Murekkib");
//}
//else
//{
//    Console.WriteLine("Sade");
//}

//Console.WriteLine(count);





//int num = 100;

//int step = 0;

//for (int i = 0; i < num; i++)
//{
//    Console.WriteLine("1ci dovr  -----------------------------------");
//    for (int j = 0; j < num; j++)
//    {
//        Console.WriteLine("2ci dovr");

//        step++;
//    }
//}
//Console.WriteLine(step);



//int search = 5;
//int[] nums = { 4, 2, 12, 5, 17 };


//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == search)
//    {
//        Console.WriteLine(nums[i]);
//        break;
//    }
//}

//0  1  2  3   4   5   6
//int[] nums = { 1, 5, 6, 12, 20, 74,90 ,100,150,200,210,250,600,700};

//int search =700;

//int low = 0;
//int high = nums.Length - 1;
//int mid = (low + high) / 2;


//int step = 0;
//while (nums[mid] != search)
//{
//    step++;
//    if (nums[mid] > search)
//    {
//        high = mid - 1;
//    }
//    else
//    {
//        low = mid + 1;
//    }

//    mid = (low + high) / 2;
//}

//Console.WriteLine(step);

//for (int i = 0; i < nums.Length; i++)
//{
//    step++;
//    if (nums[i] == search)
//    {
//        Console.WriteLine(nums[i]);
//        break;
//    }
//}
//Console.WriteLine(step);



//nLogn
int[] nums = { 14,5, 2, 6, 1,0,13,-1,-20,-10,4 };

int step = 0;
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length-1-i; j++)
    {
        step++;

        if (nums[j] > nums[j + 1])
        {


            int temp = nums[j];
            nums[j] = nums[j + 1];
            nums[j + 1] = temp;

            //a=5    b=2     b+=a    b=7   a=b-a  a=2   b=b-a  b=5

            //nums[j] += nums[j + 1];
            //nums[j + 1] = nums[j] - nums[j + 1];
            //nums[j] = nums[j] - nums[j + 1];

        }

    }
}


for (int i = 0;i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}


Console.WriteLine("Addimlarin "+step);