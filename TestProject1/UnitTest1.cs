namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] x = new int[] { 1, 3, 6, 4, 1, 2 };
            Assert.Equal(5, solution(x));
        }
        [Fact]
        public void Test2()
        {
            int[] x = new int[] { 1, 2, 3 };
            Assert.Equal(4, solution(x));
        }
        [Fact]
        public void Test3()
        {
            int[] x = new int[] { -1, -3 };
            Assert.Equal(1, solution(x));
        }


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
    }
}