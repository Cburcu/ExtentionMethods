using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HwExtentionMethods.GameActors;

namespace HwExtentionMethods.ExtentionMethods
{
    public static class FindMethod
    {
        public static List<T> Find<T>(this T[] parameters, Predicate<T> dlg)
            where T : IActor
        {
            List<T> parameterList = new List<T>();

            foreach (var p in parameters)
            {
                if (dlg(p))
                {
                    parameterList.Add(p);
                }
            }
            return parameterList;
        }
    }

    public delegate bool Predicate<in T>(T p);

    //public delegate bool FindDelegate<T>(T p);
}
