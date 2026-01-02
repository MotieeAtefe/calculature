
bool isExistsSelect = true;
List<string> list = new List<string>();
while (isExistsSelect)
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
            Console.WriteLine("See All to do");
            break;

        case "A":
        case "a":
            Console.WriteLine("Add to do");
            AddNumber();
            break;

        case "R":
        case "r":
            Console.WriteLine("Remove from list");
            break;

        case "E":
        case "e":
            isExistsSelect = false;
            Console.WriteLine("Exist from list"); break;

        default:
            Console.WriteLine("Please enter again");
            break;


    }
}



void AddNumber()
{
    Console.Write("Please Enter Your massage: ");
    var inp = Console.ReadLine();
    bool isExistsSelect = true;
    while (isExistsSelect)
    {
        SeeAll();
        if (inp == "")
        {
            Console.WriteLine("Invalid Massage: You don't have to Enter empty Massage!");
        }
        else if (list.Contains(inp))
        {
            Console.WriteLine("Invalid Massage: You don't have to dublicate Massage!");
        }
        else
        {
            list.Add(inp);
            isExistsSelect = false;
            break;
        }
    }
}