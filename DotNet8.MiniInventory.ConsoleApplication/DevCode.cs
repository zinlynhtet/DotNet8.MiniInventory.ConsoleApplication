namespace DotNet8.MiniInventory.ConsoleApplication;

public static class DevCode
{
    public static int ToInt(this object item)
    {
        return Convert.ToInt32(item);
    }

    public static decimal ToDecimal(this object item)
    {
        return Convert.ToDecimal(item);
    }
}