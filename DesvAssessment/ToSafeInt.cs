using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesvAssessment
{
    public class ToSafeIntClass
    {
        public string ErrorMessage { get; set; }
        public bool CheckConversion { get; set; }
        

        public int ToSafeInt(string _value)
        {
           // bool result = false;
            CheckConversion = false;

            int iReturnInteger = 0;
            try
            {
               
                CheckConversion = int.TryParse(_value, out iReturnInteger);
                return iReturnInteger;
            }catch(Exception e)
            {
                ErrorMessage = e.Message.ToString();
                return iReturnInteger;
            }      
        }
        public int ToSafeIntCaller(string _value)
        {
            

            int iReturnInteger = 0;
            try
            {
                Type type = typeof(ToSafeIntClass);
                MethodInfo method = type.GetMethod("ToSafeInt");
                ToSafeIntClass ts = new ToSafeIntClass();
            
                iReturnInteger =  (int)method.Invoke(ts, new object[] { _value });
               if(iReturnInteger==0 && int.TryParse(_value, out iReturnInteger) == false)
                {
                    CheckConversion = false;
                }
                else
                {
                    CheckConversion = true;
                }
                return iReturnInteger;
            }
            catch(Exception e)
            {
                ErrorMessage = e.Message.ToString();
                return iReturnInteger;

            }
        }
    }
}
