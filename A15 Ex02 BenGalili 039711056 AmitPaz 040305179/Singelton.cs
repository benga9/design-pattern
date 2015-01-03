using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179
{
    public static class Singleton<T>
    where T : class
    {
        /// <summary>
        /// The single instance of the target class.
        /// </summary>
        /// <remarks>
        /// The volatile keyword makes sure to remove any compiler optimization that could make concurrent 
        /// threads reach a race condition with the double-checked lock pattern used in the Instance property.
        /// See http://www.bluebytesoftware.com/blog/PermaLink,guid,543d89ad-8d57-4a51-b7c9-a821e3992bf6.aspx
        /// </remarks>
        private static volatile T s_Instance;

        /// <summary>
        /// The dummy object used for locking.
        /// </summary>
        private static object s_LockObj = new object();

        /// <summary>
        /// Type-initializer to prevent type to be marked with beforefieldinit.
        /// </summary>
        /// <remarks>
        /// This simply makes sure that static fields initialization occurs 
        /// when Instance is called the first time and not before.
        /// </remarks>
        static Singleton()
        {
        }

        /// <summary>
        /// Gets the single instance of the class.
        /// </summary>
        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            ConstructorInfo constructor = null;

                            try
                            {
                                /// Binding flags exclude public and static constructors.
                                constructor = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
                            }
                            catch (Exception exception)
                            {
                                throw new Exception(null, exception);
                            }
                            if (constructor == null || constructor.IsAssembly) /// Also exclude internal constructors.
                            {
                                throw new Exception(string.Format("A private or protected constructor is missing for '{0}'.", typeof(T).Name));
                            }

                            s_Instance = constructor.Invoke(null) as T;
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}
