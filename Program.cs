/*int x = 0;
x++; //1
//x = x 
//x = x + 1;
System.Console.WriteLine(x); //1
x += 5; // 6
System.Console.WriteLine(x); //6
x--; //5
int y = --x; //y? 4 x? 4
System.Console.WriteLine($"y={y}");
System.Console.WriteLine($"x={x}");

System.Console.WriteLine(x);
x--;
System.Console.WriteLine(x);
*/
//char choice;
/*
do
{
    System.Console.Write("Give me a number between 1 - 10! ");
    //user input
    int x = int.Parse(Console.ReadLine());
    int wrongTimes = 0;
    while(x > 10 || x < 1)
    {
        wrongTimes++;
        if(wrongTimes > 5)
        {
            System.Console.WriteLine("ARE YOU STUPID!!!");
            Thread.Sleep(10000);
        }
        
        System.Console.WriteLine("Invalid Entry!");
        System.Console.Write("Give me a number between 1 - 10! ");
        //user input
        x = int.Parse(Console.ReadLine());
    }


    while(x > 0)
    {
        System.Console.WriteLine(x--);
        //x = x - 1;
        
        /*
        if(x == 3)
        {
            x = -1;
        }
        *//*
        Thread.Sleep(1000);
    }

    System.Console.WriteLine("Happy New Year!");

    System.Console.Write("Do you wish to continue? (Y or N) ");
    choice = Console.ReadLine()[0];

} while(choice == 'Y');

*/

//int[] myNumbers = {1, 2, 3, 4, 5};



/*for( int count = 0, value = 10; count <= value; count++, value--)
{
    System.Console.WriteLine(count);
    System.Console.WriteLine(value);
} */ 


//5

/*
System.Console.Write("How many tests do you want to average? ");
int numTest = int.Parse(Console.ReadLine());

double[] tests = new double[numTest];

for (int i = 0; i < numTest; i++)
{
    if(i + 1 == 1)
    {
        Console.Write($"Enter your 1st test. ");
    }
    else if(i + 1 == 2)
    {
        Console.Write($"Enter your 2nd test. ");
    }
    else if(i + 1 == 3)
    {
        Console.Write($"Enter your 3rd test. ");
    }
    else
    {
        Console.Write($"Enter your {i + 1}th test. ");
    }
    
    tests[i] = double.Parse(Console.ReadLine());
}

double accumulator = 0;

for (int i = 0; i < tests.Length; i++)
{
    accumulator += tests[i];
    //accumulator = accumulator + tests[i];
}

double average = accumulator / tests.Length;
//double average = accumulator /numTest;

System.Console.WriteLine(average);

*/

double testSum = 0;
double userInput = 0;
int counter = 0;
double average = 0;

System.Console.Write("Enter your tests grades to average them together. -1 to exit! ");
userInput = Convert.ToDouble(Console.ReadLine());

while(userInput > -1 && counter < 10)
{
    counter++;
    testSum += userInput;
    System.Console.Write("Enter your tests grades to average them together. -1 to exit! ");
    userInput = Convert.ToDouble(Console.ReadLine());
}

if(counter != 0)
{
    while(true)
    {

    }
    average = testSum / counter;
}
    
System.Console.WriteLine(average);


string name = "Mathew";

name.ToUpper();
name.ToLower();
Console.WriteLine(name[0]);
Console.WriteLine(name[name.Length - 1]);




