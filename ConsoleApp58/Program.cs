class Programm
{
    static void StringBeauty(string str)
    {
        char maxSymb = str[0];
        int maxSymbCount = str.Count(s => s == maxSymb);

        char minSymb = str[1];
        int minSymbCount = str.Count(s => s == minSymb);
        
        int k = 1;
        char glass = str[k];
        int glassCount = 0;

        
        for(int i = 1; k < str.Length; i++)
        {
            if (glass == maxSymb && k != 1)
            {
                k++;
                glass = str[k];
            }

            glassCount=str.Count(s => s == glass);

            if (i >= str.Length - 1)
            {
                i = 0;
                k++;
                if (maxSymbCount < glassCount)
                {
                    maxSymb = glass;
                    maxSymbCount = glassCount;
                    glass = str[k];
                    i = 0;
                }
            }
        }

        k = 1; 
        glass = str[k];
        for(int i = 0; k < str.Length; i++)
        {
            if (glass == minSymb && k != 1)
            {
                k++;
                glass = str[k];
            }

            glassCount = str.Count(s => s == glass);

            if (i >= str.Length - 1)
            {
                i = 0;
                k++;
                if (minSymbCount > glassCount)
                {
                    minSymb = glass;
                    minSymbCount = glassCount;
                    glass = str[k];
                    i = 0;
                }
            }
        }

        Console.WriteLine(maxSymbCount - minSymbCount);
    }

    static void Main(string[] args)
    {
        string str = "aabcb";
        StringBeauty(str);
    }
}
