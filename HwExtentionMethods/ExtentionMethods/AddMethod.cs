using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HwExtentionMethods.GameActors;

namespace HwExtentionMethods.ExtentionMethods
{
    public static class AddMethod
    {
        public static T AddParameter<T, P>(this T parameter, P feature, string criteria, AddDelegate<T> dlg)
            where T : IActor, new() where P : IActor
        {
            if (dlg(parameter))
            {
                Type parameterType = parameter.GetType();
                Type featureType = feature.GetType();

                var property = parameterType.GetProperty(criteria).GetValue(parameter);

                Type propertyType = parameterType.GetProperty(criteria).PropertyType;


                MethodInfo methodCompare = propertyType.GetMethod("Add",
                    BindingFlags.Instance | BindingFlags.Public,
                    null,
                    new Type[] { featureType },
                    null);

                methodCompare.Invoke(property, new object[] { feature });
            }

            return parameter;
        }
    }
    public delegate bool AddDelegate<T>(T p);
}
