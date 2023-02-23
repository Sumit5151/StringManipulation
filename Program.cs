


public class Program
{
   

    public static void Main()
    {
        // string FirstName, MiddleName, LastName, FullName;

        // Console.WriteLine("Please enter First Name");
        // FirstName = Console.ReadLine();

        // Console.WriteLine("Please enter Middle Name");
        // MiddleName = Console.ReadLine();


        // Console.WriteLine("Please enter Last Name");
        // LastName = Console.ReadLine();


        // FullName = FirstName +" "+ MiddleName +" "+ LastName;

        //Console.WriteLine(FullName);






        //Calculate lenght of the string

        //Console.WriteLine("Please enter any string");
        //  var str= Console.ReadLine(); //Welcome

        //int counter = 0;

        //foreach (var item in str)
        //{
        //    counter++;
        //}


        //Console.WriteLine("Lengh of the string = "+counter);


        //caluculate the vowels from the string

        Console.WriteLine("Please enter any string");
        var str = Console.ReadLine();   //Welcome

        int VowelsCounter = 0;
        foreach (var item in str)
        {

            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u'||
                item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
            {
                VowelsCounter++;
            }
        }

        Console.WriteLine("Number of vowels in the string = "+ VowelsCounter);
    }

}
