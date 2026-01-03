
bool isExistsSelect = false;
List<string> todos = [];
while (!isExistsSelect)
{
    Console.WriteLine();
    Console.WriteLine("[S]ee All to do, Plese Eneter S or s");
    Console.WriteLine("[A]dd to do, Plese Eneter A or a");
    Console.WriteLine("[R]emove from to do, Plese Eneter R or r");
    Console.WriteLine("[E]xist to to , Plese Eneter E or e");
    string UserInput = Console.ReadLine();

    switch (UserInput)
    {
        case "S":
        case "s":
            SeeAllToDo();
            break;

        case "A":
        case "a":
            AddToDo();
            break;

        case "R":
        case "r":
            RemoveToDo();
            break;

        case "E":
        case "e":
            isExistsSelect = true;
            Console.WriteLine("Exist from list"); break;

        default:
            Console.WriteLine("Please enter again");
            break;


    }
}

void RemoveToDo()
{
    if (!AllowContinue())
    {
        return;
    }
    bool isExistsSelect = false;
    while (!isExistsSelect)
    {

        Console.WriteLine("please select a to fo number for remove!");
        SeeAllToDo();

        var inputIndex = Console.ReadLine();

        if (inputIndex == "")
        {
            Console.WriteLine("Invalid index: You don't have to Enter empty index!");
            continue;
        }

        if (int.TryParse(inputIndex, out int index))
        {
            if (index > 0 || index <= todos.Count)
            {
                string indexDeleted = todos[index - 1];
                todos.RemoveAt(index - 1);
                Console.WriteLine($"Remove to do: {indexDeleted}");
                isExistsSelect = true;
            }
            else
            {
                Console.WriteLine("Invalid index: You don't have to Enter out of range index!");
            }
        }
        else
        {
            Console.WriteLine("Invalid index: You don't have to Enter invalid format!");
        }
    }

}

void SeeAllToDo()
{
    if (!AllowContinue())
        return;

    WriteLineWithSpace("Todo items are:");
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1} : {todos[i]}");
    }

}

void AddToDo()
{
    var inputMassage = string.Empty;
    do
    {
        Console.Write("Please Enter Your massage: ");
        inputMassage = Console.ReadLine();
    }
    while (ValidationMassage(inputMassage));
    todos.Add(inputMassage);

}

void WriteLineWithSpace(string text)
{
        Console.WriteLine();
        Console.WriteLine(text);
    
}
bool ValidationMassage(string inputMassage)
{
    bool isValid = true;
    if (inputMassage == "")
    {
        Console.WriteLine("Invalid Massage: You don't have to Enter empty Massage!");
        isValid = false;
    }
    else if (todos.Contains(inputMassage))
    {
        Console.WriteLine("Invalid Massage: You don't have to dublicate Massage!");
        isValid = false;
    }
    return isValid;
}

bool AllowContinue()
{
    if (todos.Count == 0)
    {
        WriteLineWithSpace("There is no todo.");
        return false;
    }
    return true;
}