string folderPath = @"C:\Data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);

List<string> myShoppingList = new List<string>();
if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
   File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"file {fileName} has been greated.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}





static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine($"Add an item (add)/Exit(exit):");
        string userChoice = Console.ReadLine();
        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }

    }
    return userList ;
}

static void ShowItemsFromList(List<string> SomeList)
{
    Console.Clear();

    int listLength = SomeList.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");

    int i = 1;
    foreach (string item in SomeList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}

