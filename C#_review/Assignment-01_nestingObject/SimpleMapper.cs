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


namespace Assignment_01_nestingObject
{
    public class SimpleMapper
    {
        public void Copy(object source, object destination)
        {
            if (source == null || destination == null)
            {
                throw new ArgumentNullException("Objects are can't be null.");
            }

            Type sourceType = source.GetType();
            Type destinationType = destination.GetType();

            // Console.WriteLine(sourceType);
            //Console.WriteLine(destinationType);

            //if (sourceType != destinationType)
            //{
            //throw new ArgumentException("Source and destination objects should be same type.");
            //}

            PropertyInfo[] sourceProperties = sourceType.GetProperties();
            PropertyInfo[] destinationProperties = destinationType.GetProperties();

            foreach (PropertyInfo sourceProperty in sourceProperties)
            {
               
                    PropertyInfo destProp = Array.Find(destinationProperties, m => m.Name == sourceProperty.Name);

                if (destProp != null)
                {
                    PropertyInfo SProperty = sourceType.GetProperty(sourceProperty.Name);
                    PropertyInfo DProperty = destinationType.GetProperty(sourceProperty.Name);

                    if (SProperty.PropertyType == DProperty.PropertyType)
                    {
                        //object value = SProperty.GetProperty(source);
                        //DProperty.SetValue(destination, value);
                        Console.WriteLine(SProperty.Name);
                        Console.WriteLine(DProperty.Name);
                        



                    }

                }


                }
               

 
            Console.WriteLine();

            foreach (PropertyInfo sourceProperty in sourceProperties)
            {
                PropertyInfo destProp = Array.Find(destinationProperties, m => m.Name == sourceProperty.Name);
                if (destProp != null)
                {
                    PropertyInfo SProperty = sourceType.GetProperty(sourceProperty.Name);
                    PropertyInfo DProperty = destinationType.GetProperty(sourceProperty.Name);

                    if (SProperty.PropertyType == DProperty.PropertyType)
                    {
                        Console.WriteLine(DProperty.Name);
                        Console.WriteLine(SProperty.Name);
                       // object sourceValue = SProperty.GetValue(source);
                        //object destValue = DProperty.GetValue(destination);

                        //if (sourceValue!= null && destValue!= null)
                        //{
                          //  Copy(sourceValue, destValue);
                        //}

                      // Copy(sourceValue, destValue);
                    }
    

                }
                

            }


           

        }

    }
    }

    
