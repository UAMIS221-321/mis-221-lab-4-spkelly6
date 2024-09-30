//start main
DisplayMenu();
string userChoice = GetMenuChoice();
while (userChoice != "4"){
    DirectUser(userChoice);
    DisplayMenu();
    userChoice = GetMenuChoice();
}
SayBye();
//end main

static void DisplayMenu(){
    Console.Clear();
    Console.WriteLine("Welcome to Crimson Crust! Which pizza can we serve you today? \n1. Topping-less Pizza \n2. Cheese Pizza \n3. Pepperoni Pizza \n4. Exit");
}

static string GetMenuChoice(){
    Console.WriteLine("Please select one option! You can select more later!");
    return (Console.ReadLine());
}

static void DirectUser(string userChoice){
    switch (userChoice)
    {
        case "1":
            PlainPizza();
            break;
        case "2":
            CheesePizza();
            break;
        case "3":
            PepPizza();
            break;
        default:
            Console.WriteLine("Invalid Menu Choice.");
            Pause();
            break;
    }
}

static void PlainPizza()
{
    Random rnd = new Random();
    int numRows = rnd.Next(8,13);

    for (int i = numRows; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    Pause();
}

static void CheesePizza()
{
    Random rnd = new Random();
    int chzRows = rnd.Next(8, 13); 

    for (int i = chzRows; i >= 0; i--) 
    {
        for (int j = 0; j <= i; j++) 
        {
            if (j == 0 || j == i || i == chzRows) 
            {
                Console.Write("*"); 
            }
            else
            {
                Console.Write("#"); 
            }
        }
        Console.WriteLine(); 
    }
    Pause();
}


static void PepPizza()
{
    Random rnd = new Random();
    int pepRows = rnd.Next(8, 13); 
    for (int i = pepRows; i >= 0; i--) 
    {
        for (int j = 0; j <= i; j++) 
        {
            if (j == 0 || j == i || i == pepRows || j == pepRows) 
            {
                Console.Write("*"); 
            }
            else
            {
                
                if (rnd.Next(0, 3) == 0) 
                {
                    Console.Write("[]"); 
                    j++;
                }
                else
                {
                    Console.Write("#"); 
                }
            }
        }
        Console.WriteLine(); 
    }
    Pause(); 
}



static void Pause(){
    Console.WriteLine("Press any key to continue!");
    Console.ReadKey();
}

static void SayBye(){
    Console.WriteLine("Hope you enjoyed our pizzas!");
}