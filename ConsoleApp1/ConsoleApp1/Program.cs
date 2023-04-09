/*
 *  1. დაწერეთ პროგრამა რომელიც კლავიატურიდან შემოიტანს n-ს და მასივს შეავსებს n-ცალი რიცხვით. დაითვალეთ:
 *      a) კენტი რიცხვების ჯამი
 *      b) ლუწი რიცხვების ნამრავლი
 *      c) დაითვლის მასივში თითოეული ელემენტი რამდენჯერ გვხვდება  (3)
 */


using System;

int n, sumOddnums = 0, multipliedEvenNums = 1;
bool isNum = int.TryParse(Console.ReadLine(), out n);
int[] array = new int[n];


// მასივის შევსება n ცალი რიცხვით:

if (isNum)
{
	for (int i = 0; i < n; i++)
	{
        Random r = new Random();
        array[i] = r.Next(0, 100);
        Console.WriteLine(array[i]);
    }
}

for(int i = 0; i < array.Length; i++)
{
    if (array[i]%2 != 0)
    {
        //კენტი რიცხვების ჯამი
        sumOddnums += array[i];
    }
    else
    {
        //ლუწი რიცხვების ნამრავლი
        multipliedEvenNums *= array[i];
    }

    //დაითვლის მასივში თითოეული ელემენტი რამდენჯერ გვხვდება
    Console.WriteLine($"{array[i]}: {array.Count(num => num == array[i])}");
}
Console.WriteLine($"sumOddnums: {sumOddnums}");
Console.WriteLine($"multipliedEvenNums: {multipliedEvenNums}");


/*
 * 2.   დაწერეთ პროგრამა რომელიც შეადარებს ორ მასივს და იტყვის არის თუ არა ეს ორი მასივი ტოლი. 
 *      Ორი მასივი ტოლია თუ მასში ყველა ელემენტის რაოდენობა ერთმანეთს უდის.   (2)
 */

bool arrayComparison(int[] firstArray, int[] secondArray)
{
    if( firstArray.Length != secondArray.Length)
    {
        return false;
    }
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i] != secondArray[i])
        {
            return false;
        }
    }
    return true;
}

int[] first = { 1, 2, 4 };
int[] second = { 1, 2, 3 };

bool isEcual = arrayComparison(first, second);

Console.WriteLine(isEcual);

/*
 * 3.   დაწერეთ პროგრამა რომელიც მასივში დაბეჭდავს ერთმანეთის მეზობლად მდგარი ტოლი ელემენტების მაქსიმალურ რაოდენობას და ამ ელემენტს. 
 *      Მაგ 1 1 2 2 2 3 4 2 2  - უნდა დაბეჭდოს 3  და 2.  (3)
 */
