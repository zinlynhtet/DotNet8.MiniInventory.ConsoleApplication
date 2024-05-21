        var manager = new InventoryManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. List Items");
            Console.WriteLine("3. Update Item");
            Console.WriteLine("4. Delete Item");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddItem(manager);
                    break;
                case "2":
                    manager.ListItems();
                    break;
                case "3":
                    UpdateItem(manager);
                    break;
                case "4":
                    DeleteItem(manager);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

    static void AddItem(InventoryManager manager)
    {
        Console.Write("Enter item name: ");
        string name = Console.ReadLine();
        Console.Write("Enter quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity))
        {
            Console.WriteLine("Invalid quantity. Please enter a valid number.");
            return;
        }
        Console.Write("Enter price: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Console.WriteLine("Invalid price. Please enter a valid number.");
            return;
        }

        manager.AddItem(name, quantity, price);
    }

    static void UpdateItem(InventoryManager manager)
    {
        Console.Write("Enter item ID to update: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID. Please enter a valid number.");
            return;
        }
        Console.Write("Enter new name: ");
        string name = Console.ReadLine();
        Console.Write("Enter new quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity))
        {
            Console.WriteLine("Invalid quantity. Please enter a valid number.");
            return;
        }
        Console.Write("Enter new price: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Console.WriteLine("Invalid price. Please enter a valid number.");
            return;
        }

        manager.UpdateItem(id, name, quantity, price);
    }

    static void DeleteItem(InventoryManager manager)
    {
        Console.Write("Enter item ID to delete: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID. Please enter a valid number.");
            return;
        }
        manager.DeleteItem(id);
    }
