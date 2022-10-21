using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ASSIGNMENT_7_1_
{
    public static class Validator
    {
        public static bool FieldIsEmpty(string Value)
        {
            if (String.IsNullOrEmpty(Value))
                return true;
            return false;
        }

        public static bool EmployeeIDIsValid(string EmployeeID)
        {
            if (EmployeeID.Length == 7)
                return true;
            return false;
        }

        public static bool DOB(string DOB)
        {
            if (Regex.IsMatch(DOB, "yyyy - MM - ddTHH:mm: ss.ffffffK"))
                return true;
            return false;
        }
    }
}
