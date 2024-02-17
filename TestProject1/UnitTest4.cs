namespace TestProject1
{
    public class UnitTest4
    {
        [Fact]
        public void Test1()
        {

            int[] A = { 0,4,-1,0,3 };
            int[] B = { 0,-2,5,0,3 };

            var actual = UnitTest4.solution(A, B);
            Assert.Equal(2, actual);
        }
        [Fact]
        public void Test2()
        {

            int[] A = { 2,-2,-3,3 };
            int[] B = { 0,0,4,-4 };

            var actual = UnitTest4.solution(A, B);
            Assert.Equal(1, actual);
        }
        [Fact]
        public void Test3()
        {

            int[] A = { 1,4,2,-2,5 };
            int[] B = { 7,-2,-2,2,5 };

            var actual = UnitTest4.solution(A, B);
            Assert.Equal(2, actual);
        }






        public static int solution(int[] A, int[] B)
        {
            int result = 0; 
            for (int i = 0; i < A.Length - 1; i++)
            {

                
                var SumA = 0;
                var SumB = 0;
                var SumC = 0;
                var SumD = 0;
                for (int l = i+1; l < A.Length; l++)
                {
                    SumA += A[l];
                    SumB += B[l];
                }

                
                for (int n = 0; n < i + 1; n++)
                {

                    SumC += A[n];
                    SumD += B[n];
                }

                if ((SumA == SumB) && (SumB == SumC) && (SumC == SumD)) {
                    result += 1;
                }

            }




            return result;
        }
    }
}