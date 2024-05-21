﻿public class InventoryManager
{
    private List<InventoryItem> _items;
    private int _nextId;

    public InventoryManager()
    {
        _items = new List<InventoryItem>();
        _nextId = 1;
    }

    public void AddItem(string name, int quantity, decimal price)
    {
        var item = new InventoryItem
        {
            Id = _nextId++,
            Name = name,
            Quantity = quantity,
            Price = price
        };
        _items.Add(item);
        Console.WriteLine("Item added successfully.");
    }

    public void ListItems()
    {
        Console.WriteLine("Inventory Items:");
        foreach (var item in _items)
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price}");
        }
    }

    public void UpdateItem(int id, string name, int quantity, decimal price)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        if (item == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }

        item.Name = name;
        item.Quantity = quantity;
        item.Price = price;
        Console.WriteLine("Item updated successfully.");
    }

    public void DeleteItem(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        if (item == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }

        _items.Remove(item);
        Console.WriteLine("Item deleted successfully.");
    }
}
