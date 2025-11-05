// ObservableMobileDevicesCollection.cs
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

public class ObservableMobileDevicesCollection
{
    private ObservableCollection<MobileDevice> mobileDevices;

    public ObservableCollection<MobileDevice> MobileDevices
    {
        get { return mobileDevices; }
    }

    public ObservableMobileDevicesCollection()
    {
        mobileDevices = new ObservableCollection<MobileDevice>();
        mobileDevices.CollectionChanged += OnCollectionChanged;
    }

    private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        Console.WriteLine("\n=== События изменения коллекции ===");
        Console.WriteLine($"Действие: {e.Action}");

        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                Console.WriteLine($"Добавлен элемент: {((MobileDevice)e.NewItems[0]).Model}");
                Console.WriteLine($"Новый индекс: {e.NewStartingIndex}");
                Console.WriteLine($"Всего элементов в коллекции: {mobileDevices.Count}");
                break;

            case NotifyCollectionChangedAction.Remove:
                Console.WriteLine($"Удален элемент: {((MobileDevice)e.OldItems[0]).Model}");
                Console.WriteLine($"Старый индекс: {e.OldStartingIndex}");
                Console.WriteLine($"Всего элементов в коллекции: {mobileDevices.Count}");
                break;
        }
    }

    public void PrintCollection()
    {
        Console.WriteLine("\n=== Текущая коллекция ===");
        if (mobileDevices.Count == 0)
        {
            Console.WriteLine("Коллекция пуста");
            return;
        }

        for (int i = 0; i < mobileDevices.Count; i++)
        {
            Console.WriteLine($"{i} {mobileDevices[i].Model} - {mobileDevices[i].Price} руб.");
        }
        Console.WriteLine("=== Конец списка ===\n");
    }
}
