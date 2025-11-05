// Program.cs
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // // Задание 1
        // ArrayListEx list = new ArrayListEx();

        // list.PrintAll();
        // list.PrintCount();

        // list.DelItem();

        // list.PrintAll();
        // list.PrintCount();

        // list.SearchItem();


        // Задание 2
        // Первая коллекция floatsList
        FloatList floatsList = new FloatList();

        floatsList.PrintAll();
        floatsList.DeleteItems();
        floatsList.PrintAll();

        // Добавление элементов
        Console.WriteLine("Добавление элементов");
        floatsList.AddItems();
        floatsList.PrintAll();

        // Вторая коллекция FloatStack
        FloatStack floatstack = new FloatStack(floatsList);

        floatstack.PrintAll();
        floatstack.SearchItem();


        // Задание 3
        // Первая коллекция MobileDevicesList
        MobileDevicesList mobileDevicesList = new MobileDevicesList();

        mobileDevicesList.PrintAll();

        // Вторая коллекция MobileDevicesStack
        MobileDeviceStack mobileDevicesStack = new MobileDeviceStack(mobileDevicesList);

        mobileDevicesStack.PrintAll();

        // Проверка работоспособности интерфейсов IComparable и ICloneable  
        Console.WriteLine("\n\n=== Демонстрация IComparable и ICloneable ===");
        var devices = mobileDevicesList.GetOfMobileDevicesLists();
        
        devices.Sort();
        mobileDevicesList.PrintAll();

        Console.WriteLine("\n");
        
        MobileDevice original = devices[0];
        MobileDevice cloned = (MobileDevice)original.Clone();

        Console.WriteLine("\nОригинал:");
        original.Print();
        Console.WriteLine("\nКлон:");
        cloned.Print();

        cloned.ChangeModel("Cloned Device");
        cloned.ChangePrice(9999);

        Console.WriteLine("\nОригинал:");
        original.Print();
        Console.WriteLine("\nКлон:");
        cloned.Print();

        // Проверка работоспособности сравнения
        Console.WriteLine("\n\n=== Демонстрация сравнения ===");
        MobileDevice device1 = new MobileDevice("Phone A", 150, 10000);
        MobileDevice device2 = new MobileDevice("Phone B", 160, 12000);
        
        Console.WriteLine($"device1: {device1}");
        Console.WriteLine($"device2: {device2}");
        Console.WriteLine($"device1.CompareTo(device2): {device1.CompareTo(device2)}");
        Console.WriteLine($"Сравнение по весу: {new WeightComparer().Compare(device1, device2)}");

        // Демонстрация observableCollection
        Console.WriteLine("\n=== Демонстрация observableCollection ===");

        var observableCollection = new ObservableMobileDevicesCollection();
        
        // Демонстрация добавления элементов
        Console.WriteLine("\nДобавление элементов:");
        
        observableCollection.MobileDevices.Add(new MobileDevice("iPhone 15", 171, 99999));
        observableCollection.PrintCollection();
        
        observableCollection.MobileDevices.Add(new MobileDevice("Samsung Galaxy", 168, 89999));
        observableCollection.PrintCollection();
        
        observableCollection.MobileDevices.Add(new MobileDevice("Xiaomi Mi", 185, 49999));
        observableCollection.PrintCollection();
        
        // Демонстрация удаления элементов
        Console.WriteLine("\nУдаление элементов:");
        
        // Удаление объекта
        var deviceToRemove = observableCollection.MobileDevices[1];
        observableCollection.MobileDevices.Remove(deviceToRemove);
        observableCollection.PrintCollection();
    }
}