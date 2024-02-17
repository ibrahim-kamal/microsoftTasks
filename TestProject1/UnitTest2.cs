namespace TestProject1
{
    /*
     
    
    

        public String sol1(Tree T) {

            String number = T.x.ToString();
            if (T.l is null && T.r is null)
            {
                return number;
            }
            else if(T.l is null) { 
                return number +  sol1(T.r);
            }
            else if (T.r is null)
            {
                return number + sol1(T.l);
            }

            return number;



        } 
    


     
    */
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            var node1 = new Tree(2, null, null);
            var node2 = new Tree(9, null, null);
            var node3 = new Tree(9, node2,node1);
            var t  = new Tree(9, null , node3);
            var actual = Solution2(t);
            Assert.Equal(2, actual);

        }
        [Fact]
        public void Test2()
        {


            var t = new Tree(
                1, 
                new Tree(
                    2 , 
                    new Tree(5, 
                        new Tree(3 ,null , null) ,
                        null
                        ),
                        new Tree(9 , null , null)
                    ) ,new (7 , new Tree(4 , null , null),null));
            var actual = Solution2(t);
            Assert.Equal(4, actual);
        }
        [Fact]
        public void Test3()
        {

            var t = new Tree(
                9,
                new Tree(
                    9,
                    new Tree(2,null,null),
                    new Tree(9, null, null)
                    ), 
                new(
                    5, 
                    new Tree(
                        9, 
                        new Tree(
                                5 , 
                                null ,
                                new Tree(9 , null , null)
                            ),
                        new Tree(9 , null , null)
                    ), 
                    new Tree(9 , null  , null)
                    ));
            var actual = Solution2(t);
            Assert.Equal(5, actual);
        }





        public static List<string> myleft(Tree T)
        {
            List<string> result = new List<string>();
            if (T.l is null && T.r is null)
            {
                result.Add(T.x.ToString());
            }
            else
            {
                if (T.l is not null)
                {

                    var left = myleft(T.l);
                    foreach (var l in left)
                    {
                        result.Add(T.x.ToString() + l);
                    }
                    
                }

                if (T.r is not null)
                {

                    var right = myleft(T.r);
                    foreach (var r in right)
                    {                
                        result.Add(T.x.ToString()+r);
                    }
                }



            }



            return result;

        }


        public static int Solution2(Tree T)
        {
            IList<string> result = new List<string>();  
            var right = myleft(T);

            foreach (var item in right)
            {
                for (int i = 0; i < item.Length; i++) {
                    string newString = "";
                    for (int l = i; l <  i + 3; l++) {
                        if(l < item.Count())
                            newString += item[l];
                    }
                    if (!result.Contains(newString) && newString.Length == 3) { 
                        result.Add(newString);
                    }
                }
                
            }
            
            return result.Count;
        }


        public class Tree
        {
            public Tree(int _x, Tree _l , Tree _r)
            {
                x = _x;
                l = _l;
                r = _r;
            }
            public int x;
            public Tree l;
            public Tree r;
        };
    }
}