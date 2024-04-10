public static class Program
{
    public static void Main()
    {
        GetMin(2, 4);
        GetMin(2f, 6f);
    }
    static int GetMin(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        return b;
    }

    static float GetMin(float a, float b)
    {
        if (a < b)
        {
            return a;
        }
        return b;
    }

}