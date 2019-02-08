using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HwExtentionMethods.GameActors;

namespace HwExtentionMethods.ExtentionMethods
{
    public static class ApplyMethod
    {
        public static T Apply<T, P>(this T parameter, P feature, string property, ApplyDelegate<T> dlg)
            where T : IActor, new() where P : IActor
        {
            if (dlg(parameter))
            {
                var t = feature;
                parameter.GetType().GetProperty(property).SetValue(parameter, t);
            }

            return parameter;
        }

    }

    public delegate bool ApplyDelegate<T>(T p);
}
