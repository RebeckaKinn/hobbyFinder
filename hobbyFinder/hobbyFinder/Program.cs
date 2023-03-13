namespace hobbyFinder
{
    internal class Program
    {
        static string[] hobbies { set; get; } = new string[3];

        static void makeHobbies()
        {
            hobbies[0] = "Strikking. Er aldri for sent å bli den gamle damen du alltid har hatt lyst til å være.";
            hobbies[1] = "Fugletitting, fordi det er en klassiker på TV så hvorfor skal det ikke funke for deg?";
            hobbies[2] = "CS. Fordi det å bli kalt for en bitch av små barn i byen var ikke nok.";
        }

        static int getNumber()
        {
            Random numb = new Random();
            int randomNumber = numb.Next(0, 3);
            return randomNumber;

        }
        static void CheckName()
        {
            var chosenName = Console.ReadLine();

            Console.WriteLine(chosenName + ", din nye hobby er: " + hobbies[getNumber()]);
            Console.WriteLine("Hvem ønsker en ny hobby?");

            CheckName();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Skriv navnet ditt for å få tildelt en hobby.");
            makeHobbies();
            CheckName();

        }


    }
}
