


public class Program
{
   

    public static void Main()
    {


        Program.StringManipulation(); //funcion call

        //ShowFullName(); //funcion call

        //CalculateLenghtOfString();

        //CalculateVowels();
    }



    //stringManipulationOfAnything  camelCase
    //StringManipulationOfAnything  PascalCase
    


    //function declaration / defination
  private static void StringManipulation()
    {
        Console.WriteLine("Please enter any string");
        var str = Console.ReadLine();   //Welcome in the bright classes

        //Calculate no of spaces
        int spaceCounter = 0;
        int consonentCounter = 0;
        foreach (char ch in str)
        {
            if(ch ==' ')
            {
                spaceCounter++;
            }


           if(     !(  ch=='a'|| ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                       ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' ||
                       ch ==' ')  
                     )
            {
                consonentCounter++;
            }




        }

        Console.WriteLine("Number of spaces =" + spaceCounter);
        Console.WriteLine("Number of words =" + (spaceCounter+1));
        Console.WriteLine("Number of consonent =" + consonentCounter );


    }
   private static void ShowFullName()
    {
        string FirstName, MiddleName, LastName, FullName;

        Console.WriteLine("Please enter First Name");
        FirstName = Console.ReadLine();

        Console.WriteLine("Please enter Middle Name");
        MiddleName = Console.ReadLine();


        Console.WriteLine("Please enter Last Name");
        LastName = Console.ReadLine();


        FullName = FirstName + " " + MiddleName + " " + LastName;

        Console.WriteLine(FullName);

    }
    static void CalculateLenghtOfString()
    {
        //Calculate lenght of the string

        Console.WriteLine("Please enter any string");
        var str = Console.ReadLine(); //Welcome

        int counter = 0;

        foreach (var item in str)
        {
            counter++;
        }


        Console.WriteLine("Lengh of the string = " + counter);
    }
    static void CalculateVowels()
    {
        //caluculate the vowels from the string

        Console.WriteLine("Please enter any string");
        var str = Console.ReadLine();   //Welcome

        int VowelsCounter = 0;
        foreach (var item in str)
        {

            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ||
                item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
            {
                VowelsCounter++;
            }
            
        }

        Console.WriteLine("Number of vowels in the string = " + VowelsCounter);
    }
}
