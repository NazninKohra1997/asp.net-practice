using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security.AccessControl;


namespace Assign_test { 
    public class SimpleMapper
    {
        public  void Copy(object source, object destination)
        {

            Type t = source.GetType();
            var sourceProperties = t.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            Type t1 = destination.GetType();
            var destinationProperties = t1.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            if (sourceProperties == null || destinationProperties == null)
            {
                throw new ArgumentNullException("Source and destination objects cannot be null.");
            }

            else
            {



                //hereeeeee

                foreach (var sourceProperty in sourceProperties)
                {

                    if (sourceProperty == null)
                    {
                        throw new ArgumentNullException("Source and destination objects cannot be null.");
                    }

                    else
                    {
                        var destProp = Array.Find(destinationProperties, m => m.Name == sourceProperty.Name);

                        if (sourceProperty.Name == "Length")
                        {
                            continue;
                        }

                        if (destProp != null)
                        {
                            PropertyInfo SProperty = t.GetProperty(sourceProperty.Name);
                            PropertyInfo DProperty = t1.GetProperty(sourceProperty.Name);

                            //Console.WriteLine(SProperty.Name);

                            if ((SProperty.PropertyType == typeof(string)) || (SProperty.PropertyType == typeof(int)) || (SProperty.PropertyType == typeof(bool))
                                || (SProperty.PropertyType == typeof(byte)) || (SProperty.PropertyType == typeof(short)) || (SProperty.PropertyType == typeof(long))
                                || (SProperty.PropertyType == typeof(float)) || (SProperty.PropertyType == typeof(double)))
                            {

                                if (SProperty.PropertyType == DProperty.PropertyType)
                                {
                                    if ((SProperty.Name).Equals(DProperty.Name))
                                    {
                                        if ((SProperty.GetValue(source)).Equals(DProperty.GetValue(destination)))
                                        {


                                            //  Console.WriteLine(SProperty.Name);
                                            //Console.WriteLine(DProperty.Name);

                                            //Console.WriteLine(value.ToString());


                                            //here
                                            //  Console.WriteLine($"The Copy value beteween {SProperty.DeclaringType.FullName} and {DProperty.DeclaringType.FullName} are:");
                                            //  Console.WriteLine($"Property Name: {SProperty.Name}");
                                            //Console.WriteLine($"Source Value: {SProperty.GetValue(source)}");


                                            //Console.WriteLine($"Destination Value: {DProperty.GetValue(destination)}");
                                            Console.WriteLine(SProperty.GetValue(source));
                                            // Console.WriteLine();



                                            //here
                                        }
                                    }
                                }

                            }

                            //here1
                            else if ((SProperty.PropertyType.IsClass) && (SProperty.PropertyType.GetInterfaces().Contains(typeof(IEnumerable))) && (SProperty.PropertyType != typeof(string)))
                            {
                                //object destValue = Activator.CreateInstance(DProperty.PropertyType).ToString();
                                // Console.WriteLine("he");

                                var S = (IEnumerable)SProperty.GetValue(source);
                                var D = (IEnumerable)DProperty.GetValue(destination);

                                // Console.WriteLine(S);

                                if ((SProperty.PropertyType == DProperty.PropertyType) && (SProperty.Name == DProperty.Name))
                                {
                                    var sourceList = new List<object>();
                                    var destinationList = new List<object>();

                                    foreach (var item in S)
                                    {
                                        //hh
                                        // Type s1 = item.GetType();
                                        //var values1 = s1.GetProperties(BindingFlags.Instance);
                                        //foreach (var value in values1)
                                        //{
                                        //  Console.WriteLine(value.GetValue(item));
                                        //}
                                        //hh

                                        // Console.WriteLine(item);
                                        sourceList.Add(item);
                                        // Console.WriteLine();

                                    }



                                    foreach (var item in D)
                                    {
                                        destinationList.Add(item);



                                    }

                                    // Console.WriteLine();

                                    //Console.WriteLine(destinationList.Count);


                                    if (sourceList.Count == destinationList.Count)
                                    {

                                        for (int i = 0; i < sourceList.Count; i++)
                                        {

                                            Copy(sourceList[i], destinationList[i]);



                                            //here
                                            if ((sourceList[i].Equals(destinationList[i])))
                                            {


                                                Console.WriteLine(sourceList[i]);
                                                //Console.WriteLine();




                                                //}

                                            }
                                            //here

                                        }
                                    }
                                }
                            }
                        }
                    }
                }


                //hereeeeeee
            }










        }

    }
}