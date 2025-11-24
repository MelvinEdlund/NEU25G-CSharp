


//int[] myArray = new int[10];
//for (int i = 0; i < myArray.Length; i++)
//{

//        myArray[i] = (i + 1) * 5;
//    Console.WriteLine(myArray[i]);
    
//}


// OverFlowException: 'Arithmetic operation resulted in an overflow'

//checked // utan checked blocket får vi ingen exception.
//{
//    byte myByte = 200;
//    Console.WriteLine(myByte);
//    myByte += 100;
//    Console.WriteLine(myByte);
//}


//// Format Exception 'The input string 'hej' was not a correct format.'
//Byte.Parse("hej");


// IndexOutOfRangeException: 'Index was outside the bounds of the array.'
//int[] myArray = new int[10];
//myArray[15] = 3;


// DivideByZeroException: 'Attempted to divide by zero.'
//int x = 0;
//int y = 1 / x;


try
{
    int userAge = -9;
    Console.WriteLine($"IsLegalAge(userAge) = {IsLegalAge(userAge)}");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Index out of range exception");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("nothing else catched this exception" +ex.Message);
}


Console.WriteLine("The end");


static bool IsLegalAge (int age)
{
    if (age < 0)
    {
        throw new ArgumentOutOfRangeException("Du är inte tillräckligt gammal.");
    }
    return age >= 18;
}




