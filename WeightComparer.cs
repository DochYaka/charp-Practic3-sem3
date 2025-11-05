// WeightComparer.cs

// Компаратор для сравнения по весу
public class WeightComparer : IComparer<MobileDevice>
{
    public int Compare(MobileDevice x, MobileDevice y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;

        return x.Weight.CompareTo(y.Weight);
    }
}