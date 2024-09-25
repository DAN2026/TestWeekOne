using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using WeekOneWorksheet;


#region gloabl vars
float numberSum = 0;
float AdvSum = 0;
#endregion

#region TestingFunctions:
//sum();
//ageCalc();
//outputFourTimes();
//nameAndAgeCollecttion();
//sumAdvanced();
//playerStats();
//userValidation();
#endregion

#region FunctionContainer
void userValidation()
{
    bool validInput = false;
    while (validInput !=true)
    {
        try
        {
            Console.WriteLine("Enter a whole number below: ");
            int number = Convert.ToInt32(Console.ReadLine());
            validInput = true;

        }
        catch(Exception e)
        {
            Console.WriteLine("Enter a number only please: ");
            Console.WriteLine("---------Try again--------");
        }

        Console.WriteLine("Weldone you have entered a whole number!!");
    }
}
void playerStats()
{

    Player user1 = new Player();
    ArrayList playerDetails = new ArrayList();
    bool nameInput = false;
    while (nameInput != true)
    {
        Console.WriteLine("Enter your player name below: ");
        string inputHolder = Console.ReadLine();
        string[] nameCheck = inputHolder.Split(' '); // splits string into indexed chars.


        for (int i = 0; i <= nameCheck.Length; i++)
        {
            Console.WriteLine("TEST");
            Console.WriteLine(nameCheck[i]);
        }
    }

} //messing around with arrayLists
void sum()
{
    for (int i = 0; i <= 1; i++)
    {
        Console.WriteLine($"Enter number {i + 1} below to add: ");
        string input = Console.ReadLine(); numberSum += Convert.ToSingle(input);
        if (i==1)
        {
            Console.WriteLine($"Your final sum of the two number's is: {numberSum}");
        }
    }
}
void ageCalc()
{
    Console.WriteLine("Enter your year of birth: ");
    string input = Console.ReadLine(); int YOB = Convert.ToInt32(input);
    int DOB = DateTime.Today.Year - YOB;
    Console.WriteLine(DOB);

}
void outputFourTimes()
{
    Console.WriteLine("Enter your name: "); string name = Console.ReadLine(); Console.WriteLine($"{name}{name}{name}{name}");

}
void nameAndAgeCollecttion()
{
    Person user1 = new Person(); Person user2 = new Person();
    for (int i = 0; i <=1; i++)
    {
        var userDetails = new ArrayList();
        Console.WriteLine($"Enter user {1} details, Name: Age .");
        string tempHolder = Console.ReadLine();
       
        

    }


}
void sumAdvanced()
{
    
    for (int i = 0; i <= 1; i++)
    {

        Console.WriteLine($"Enter number {i+1} below to add onto the sum: ");
        
        float n1 = Convert.ToSingle(Console.ReadLine());

        AdvSum += n1;

        if (i==1)
        {
            Console.WriteLine($"Your total sum for this calculation is: {AdvSum}");
            Console.WriteLine("Would you like to do another calculation: ");
            string input = Console.ReadLine();
            string confirmation = input.ToUpper();
            if (confirmation=="YES")
            {
                i = -1;
                n1 = 0;
                AdvSum = 0;
                Console.WriteLine("---------------New Calculation------------------");
            }
            else
            {
                Console.WriteLine("Thankyou for using our sum.");
                break;
            }
            
        }
        



    }
}
void check()
{
    string input = "ABCDEFGH";
    input.ToCharArray(); // changes string data into an array of chars 
    foreach (char s in input) //(datatype yourlooking for and the local var name; in (array name)
    {
        Console.WriteLine(s);
    }

}
#endregion



void enterDetailsCheck()
{
    #region enterDetailsCheckVars
    bool nameValid = false;
    bool uniqCharDetected = false;
    #endregion
    #region arrayListForDetails
    ArrayList dataHolder = new ArrayList();
    #endregion 
    Console.WriteLine("Enter your name: ");
    string input = Console.ReadLine();
    while (nameValid != true)
    {
        char[] inputChecker = input.ToCharArray();
        char[] uniqueCharacters = {'+', '=', '-','_','(', ')','*','&','^', '%','$','£','"','!','`','¬',',','<','.','>','/','?',
            ';',':','@','#','~','[','{',']','}','|','0','1','2','3','4','5','6','7','8','9',' '};


        for (int i = 0; i !=uniqueCharacters.Length; i++)
        {
            
            foreach (char check in inputChecker)  // should have done != array w/ alphabet instead of checking each individual unique character
            {                                     // char[] alphabet = {'a'b'c'd'e'f'g'h'j'k'l'} etc.. also need to convert each index to capital via ToUpper();
                if (check == uniqueCharacters[i] & uniqCharDetected == false)
                {
                    Console.WriteLine("Symbol's/Numbers along with Blank space's are not permitted in your character name.");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    uniqCharDetected = true;
                    
                }
            }
        }
        
        if (uniqCharDetected==true )
        {
            uniqCharDetected=false;
            Console.WriteLine("Re-Enter your name: ");
            string Tempinput = Console.ReadLine();
            input = Tempinput;
        }
        else
        {
            char capitalize = char.ToUpper(inputChecker[0]);
            inputChecker[0] = capitalize;
            input = String.Concat(inputChecker);







            bool nameCorrect = false;
            while (nameCorrect == false)
            {
                Console.WriteLine($"Is {input} your name?");

                string answer = Console.ReadLine();
                answer = answer.ToLower();
                string[] possibleAnswers = { "yes", "ye", "y", "yeah", "no", "n", "nah" };

                if (answer == possibleAnswers[0] || answer == possibleAnswers[1] || answer == possibleAnswers[2] || answer == possibleAnswers[3])
                {
                    
                    Console.WriteLine($"Your confirmed name is: {input} ,this will be saved.\nRecorded at {DateTime.Now}");
                    nameCorrect = true;
                    nameValid = true;
                }
                else if (answer == possibleAnswers[4] || answer == possibleAnswers[5] || answer == possibleAnswers[6])
                {
                    Console.WriteLine("Re-Directing back.");
                    Console.WriteLine("------------------");
                    uniqCharDetected = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a correctly spelt confirm word such as: \n - Yeah \n - Ye \n - Y \n - Yes \n - No \n - N \n - Nah \n ------------------------------" );
                }
            }



            
        }
    }  //string check only letters.
    



}

enterDetailsCheck();