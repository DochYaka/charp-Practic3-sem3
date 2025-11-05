// MobileDeviceStack.cs
using System.Collections.Generic;

public class MobileDeviceStack
{
    private Stack<MobileDevice> mobileDevicesStack = new Stack<MobileDevice>();

    public MobileDeviceStack(MobileDevicesList mobileDevicesList)
    {
        var allDevices = mobileDevicesList.GetOfMobileDevicesLists();

        foreach (var item in allDevices)
        {
            mobileDevicesStack.Push(item);
        }
    }

    public void SearchItem()
    {

    }

    public void PrintAll()
    {
        Console.WriteLine("\n\nТекущий стак девайсов:");
        foreach (var item in mobileDevicesStack)
            item.Print();
    }

}

