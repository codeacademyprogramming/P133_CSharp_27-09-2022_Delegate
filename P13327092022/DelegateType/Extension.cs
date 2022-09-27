using DelegateType.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateType
{
    static class Extension
    {
        public static Student CustomFind(this List<Student> students, Predicate<Student> predicate)
        {
            foreach (Student item in students)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
