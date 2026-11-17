using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatch_Block
{
    class innertry
    {

        static void Main()
        {
            try
            {
                try
                {
                    throw new Exception("Original Error");
                }
                catch (Exception ex)
                {
                    throw new Exception("New Error", ex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}
