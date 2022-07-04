using System;

namespace cccc
{
    class Program
    {
        static void Main(string[] args)
        {
            try  
                {  
                    int i = 555;   
                    int r = i / 0;  
                }  
                    catch (DivideByZeroException ex)  
                {  
                    Console.WriteLine("Se ha intentado dividir entre 0. {0}", ex.Message);  
        }
    }
    }
	    }