using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.forms.Utility.Errors
{
    public static class DomainSpecErrors
    {
        public static bool IsInteger(string input,string fieldname,bool isempty = true)
        {
            int temp;
            input = input.Trim();
            if (isempty)
                if (input == "")
                    return true;
            if (!Int32.TryParse(input,out temp))
            {
                PopUp.ShowError(String.Format("لطفا یک عدد صحیح به عنوان  {0}  وارد کنید.",  fieldname));
                return false;
            
            }
            return true;
        }
        public static bool IsDouble(string input, string fieldname, bool isempty = true)
        {
            double temp;
            input = input.Trim();
            if (isempty)
                if (input == "")
                    return true;
            if (!Double.TryParse(input, out temp))
            {
                PopUp.ShowError(String.Format("لطفا یک عدد  به عنوان  {0}  وارد کنید.", fieldname));
                return false;

            }
            return true;
        }
    }
}
