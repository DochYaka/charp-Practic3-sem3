// MobileDevicesList.cs
using System;
using System.Collections.Generic;

public class MobileDevicesList
{
    private List<MobileDevice> mobileDevicesList = new List<MobileDevice>();

    public MobileDevicesList()
    {
        MobileDevice Smartphone = new MobileDevice {Model = "Smartphone", Weight = 1, Price = 10000};
        MobileDevice Ebook = new MobileDevice {Model = "Ebook", Weight = 1, Price = 8000};;
        MobileDevice Tablet = new MobileDevice {Model = "Tablet", Weight = 2, Price = 16000};;

        mobileDevicesList.Add(Smartphone);
        mobileDevicesList.Add(Ebook);
        mobileDevicesList.Add(Tablet);
    }

    public List<MobileDevice> GetOfMobileDevicesLists()
    {
        return mobileDevicesList;
    }

    public void PrintAll()
    {
        Console.WriteLine("\nТекущий список девайсов:");
        foreach (var item in mobileDevicesList)
            item.Print();
    }

    public List<MobileDevice> CloneAllDevices()
    {
        var clonedList = new List<MobileDevice>();
        foreach (var device in mobileDevicesList)
        {
            clonedList.Add((MobileDevice)device.Clone());
        }
        return clonedList;
    }
    
}