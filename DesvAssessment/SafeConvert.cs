using DesvAssessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevAssessment
{
    public class SafeConvert
    {
        private static bool _CheckConversion = false;
        static void Main(string[] args)
        {

          //  SafeConverToInteger("33");
            ToSafeIntCallMethod("44");
            Console.ReadLine();

        }

        public static void SafeConverToInteger(string  _val)
        {
            ToSafeIntClass safe = new ToSafeIntClass();
            int num = safe.ToSafeInt(_val);
            _CheckConversion = safe.CheckConversion;
            if(_CheckConversion == true)
            {
                Console.WriteLine("The entered [{0}] value converted to integer [{1}] successfully.", _val, num);
            }
            else
            {
                Console.WriteLine("Cannot convert [{0}] to integer, the default returned value is [{1}]." , _val,num);
            }
            
        }
        public static void ToSafeIntCallMethod(string _val)
        {
            ToSafeIntClass safe = new ToSafeIntClass();
            int num = safe.ToSafeIntCaller(_val);
            _CheckConversion = safe.CheckConversion;
            if (_CheckConversion == true)
            {
                Console.WriteLine("The entered [{0}] value converted to integer [{1}] successfully.", _val, num);
            }
            else
            {
                Console.WriteLine("Cannot convert [{0}] to integer, the default returned value is [{1}].", _val, num);
            }
        }
       

         
    }
}
