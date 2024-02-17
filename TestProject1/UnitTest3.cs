namespace TestProject1
{
    public class UnitTest3
    {

        [Fact]
        public void Test0()
        {
            int[] A = { 6 };
            int[] B = { 4 };

            var actual = UnitTest3.solution(A, B);
            Assert.Equal(6, actual);

        }
        [Fact]
        public void Test1()
        {
            int[] A = { 3,4,6 };
            int[] B = { 6,5,4 };

            var actual = UnitTest3.solution(A, B);
            Assert.Equal(5, actual);

        }
        [Fact]
        public void Test2()
        {

            int[] A = { 1, 2, 1, 1, 1, 4 };
            int[] B = { 1, 1, 1, 3, 1, 1 };

            var actual = UnitTest3.solution(A, B);
            Assert.Equal(2, actual);
        }
        [Fact]
        public void Test3()
        {

            int[] A = { -5,-1,-3 };
            int[] B = { -5,5,-2 };

            var actual = UnitTest3.solution(A, B);
            Assert.Equal(-1, actual);
        }

        public class path { 
            public List<int> pathValue { get; set; }
            public int Weight { get; set; }
        }

        public static List<path> getPath(int[] A , int[] B , String CurrentStatge) {
            
            List<path> paths = new List<path>();
            path p = new path();
            List<int> list = new List<int>();
            if (CurrentStatge == "B" && B.Length == 1) {
                list.Add(B[0]);
                p.pathValue = list;
                p.Weight = B[0];
                paths.Add(p);
            }

            else if (CurrentStatge == "A" && A.Length == 1)
            {


                var rightPath = getPath(null, B, "B");

                foreach (var item in rightPath)
                {

                    item.Weight += A[0];
                    item.pathValue.Insert(0,A[0]);
                    paths.Add(item);
                }
            }

            else if (CurrentStatge == "B")
            {
                int[] newB = new int[B.Length - 1];

                for (int i = 1; i < B.Length; i++)
                {
                    newB[i - 1] = B[i];
                }
                var rightPath = getPath(null, newB, "B");

                foreach (var item in rightPath)
                {

                    item.Weight += B[0];
                    item.pathValue.Insert(0,B[0]);
                    paths.Add(item);
                }

            }

            
            else 
            {
                int[] newB = new int[B.Length - 1];
                int[] newA = new int[A.Length - 1];

                for (int i = 1; i < B.Length; i++)
                {
                    newB[i-1] = B[i];
                }

                for (int i = 1; i < A.Length; i++)
                {
                    newA[i - 1] = A[i];
                }



                var leftPath = getPath(newA, newB, "A");
                foreach (var item in leftPath)
                {
                    item.Weight  += A[0];
                    item.pathValue.Insert(0, A[0]);
                    paths.Add(item);
                }
                var rightPath = getPath(null, B, "B");

                foreach (var item in rightPath)
                {

                    item.Weight += A[0];
                    item.pathValue.Insert(0, A[0]);
                    paths.Add(item);
                }
            }


            return paths;
        }

        public static int solution(int[] A, int[] B)
        {
            int result = 0;
            var paths = getPath(A, B, "A");
            var x = paths.MinBy(p=>p.Weight);
            result = x.pathValue.Max();
            return result;
        }
    }
}