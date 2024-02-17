using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program {



    public static int solution(int[] A)
    {
        var x1 = A.Distinct().Where(x => x > 0).OrderBy(x => x);
        int i = 1;
        int index = 0;
        foreach (var item in x1)
        {
            if (item != i)
            {
                return i;
            }
            i++;
        }
        return i;
    }
    public static void Main()
    {
        //int[] x = new int[] { 7,8,9,1, 2, 3 };

        //Console.WriteLine(solution(x));

        string a = "ahmed";
        Console.WriteLine(a.Count());

    }
}