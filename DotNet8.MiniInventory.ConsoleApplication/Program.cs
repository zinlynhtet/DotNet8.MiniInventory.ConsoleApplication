using DotNet8.MiniInventory.ConsoleApplication;

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
    var name = Console.ReadLine()!;

    Console.Write("Enter quantity: ");
    var quantity = Console.ReadLine().ToInt();

    Console.Write("Enter price: ");
    var price = Console.ReadLine().ToDecimal();

    manager.AddItem(name, quantity, price);
}

static void UpdateItem(InventoryManager manager)
{
    Console.Write("Enter item ID to update: ");
    var id = Console.ReadLine().ToInt();

    Console.Write("Enter new name: ");
    var name = Console.ReadLine()!;

    Console.Write("Enter new quantity: ");
    var quantity = Console.ReadLine().ToInt();

    Console.Write("Enter new price: ");
    var price = Console.ReadLine().ToDecimal();

    manager.UpdateItem(id, name, quantity, price);
}

static void DeleteItem(InventoryManager manager)
{
    Console.Write("Enter item ID to delete: ");
    var id = Console.ReadLine().ToInt();

    manager.DeleteItem(id);
}