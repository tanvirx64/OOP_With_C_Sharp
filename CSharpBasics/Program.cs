using System;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, m, n, o=4, p, row = 5, col = 5;

            //  * * * * *
            //   *     *
            //    *   *
            //     * *
            //      *
            //for (i=0; i<row; i++)
            //{
            //    for(j=0; j<i; j++) Console.Write(" ");

            //    for (k=0; k<col; k++)
            //    {
            //        var pattern = (i > 0 && i < row - 2 && k > 0 && k < col - 1) ? "  " : "* ";
            //        Console.Write(pattern);
            //    }
            //    col--;
            //    Console.WriteLine();
            //}


            //      *
            //     * *
            //    * * * 
            //   * * * *
            //  * * * * *
            //   * * * *
            //    * * *  
            //     * *
            //      *
            //for (i=0; i<row; i++)
            //{
            //    for (j=0; j<col-1; j++) Console.Write(" ");

            //    for (k=0; k<=i; k++) Console.Write("* ");

            //    Console.WriteLine();
            //    col--;

            //    if (i == 4)
            //    {
            //        for(m=0; m<i; m++)
            //        {
            //            for(n=0; n<=m; n++) Console.Write(" ");

            //            for (l=o; l>0; l--)  Console.Write("* ");

            //            Console.WriteLine();
            //            o--;
            //        }
            //    }  
            //}




            //      *
            //     * *
            //    *   * 
            //   *     *
            //  *       *
            //   *     *
            //    *   *  
            //     * *
            //      *

            for (i=0; i<row; i++) //row
            {
                for (j = 0; j < col-1; j++)
                {
                    Console.Write(" ");
                }
                for(k=0; k<=i; k++)
                {
                    var pattern = (i>1 && i<row && k>0 && k<i) ? "  " : "* ";
                    Console.Write(pattern);
                }
                col--;
                Console.WriteLine();
                if (i == 4)
                {
                    for(m=0; m<i; m++)
                    {
                        for (n=0; n<=m; n++)
                        {
                            Console.Write(" ");
                        }
                        for(l=o; l>0; l--)
                        {
                            var pattern = (m>-1 && m<i-2 ) ? "  " : "* ";
                            Console.Write(pattern);
                        }
                        o--;
                        Console.WriteLine();
                    }
                }
                
            }



        }
    }
}
