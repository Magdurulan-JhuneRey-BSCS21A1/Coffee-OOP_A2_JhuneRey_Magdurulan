bool exit = true;
Dictionary<string, decimal> menus = new Dictionary<string, decimal>{};
Dictionary<string, decimal> order = new Dictionary<string, decimal> {};
while (exit != false)
{
    Console.WriteLine("Welcome to the Coffee Shop!\r\n" +
        "1. Add Menu Item\r\n" +
        "2. View Menu\r\n" +
        "3. Place Order\r\n" +
        "4. View Order\r\n" +
        "5. Calculate Total\r\n" +
        "6. Exit\r\n" +
        "Select an option: ");
    string Selected = Console.ReadLine();
    if (Selected == "1")
    {
        Console.WriteLine("Enter item name: ");
        string newmenu = Console.ReadLine();
        Console.WriteLine("Enter item price: ");
        decimal price = decimal.Parse(Console.ReadLine());
        if (price >= 0)
        {
            menus.Add(newmenu, price);
            Console.WriteLine("Item added successfully!");
        }
        else
        {
            Console.WriteLine("Invalid Price");
        }
    }
    else if (Selected == "2")
    {
        int i = 0;
        Console.WriteLine("Menu: ");
        foreach (var x in menus)
        {
            i++;
            Console.WriteLine(i + "." + x.Key + " - " + x.Value);
        }
    }
    else if (Selected == "3")
    {
        int i = 0;
        Console.WriteLine("Menu: ");
        foreach (var x in menus)
        {
            i++;
            Console.WriteLine(i + "." + x.Key + " - " + x.Value);
        }
        Console.WriteLine("Enter the item number to order: ");
        int order_no = int.Parse(Console.ReadLine());
        if (order_no >= 1 && order_no <= menus.Count)
        {
            int y = 0;
            foreach (var x in menus)
            {
                y++;
                if (y == order_no)
                {
                    order[x.Key] = x.Value;
                    Console.WriteLine("Item added to order!");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid Order");
        }
    }
    else if (Selected == "4")
    {
        Console.WriteLine("Your Order:");
        foreach (var a in order)
        {
            Console.WriteLine(a.Key + " - " + a.Value);
        }
    }
    else if (Selected == "5")
    {
        decimal total_amount = order.Values.Sum();
        Console.WriteLine("Total Amount Payable by admin: " + total_amount);
    }
    else if (Selected == "6")
    {
        exit = false;
    }
}

