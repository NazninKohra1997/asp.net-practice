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

           

            PropertyInfo[] sourceProperties = sourceType.GetProperties();
            PropertyInfo[] destinationProperties = destinationType.GetProperties();


            //Here

            foreach (PropertyInfo sourceProperty in sourceProperties)
            {

                PropertyInfo destProp = Array.Find(destinationProperties, m => m.Name == sourceProperty.Name);

                if (destProp != null)
                {
                    PropertyInfo SProperty = sourceType.GetProperty(sourceProperty.Name);
                    PropertyInfo DProperty = destinationType.GetProperty(sourceProperty.Name);

                   if ((SProperty.PropertyType == typeof(string)) || (SProperty.PropertyType == typeof(int)) || (SProperty.PropertyType == typeof(bool))
                       || (SProperty.PropertyType == typeof(byte)) || (SProperty.PropertyType == typeof(short)) || (SProperty.PropertyType == typeof(long)) 
                       || (SProperty.PropertyType == typeof(float)) || (SProperty.PropertyType == typeof(double)) )
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
                                    Console.WriteLine($"Property Name: {SProperty.Name}");
                                    Console.WriteLine($"Source Value: {SProperty.GetValue(source)}");
                                    Console.WriteLine($"Destination Value: {DProperty.GetValue(destination)}");
                                   Console.WriteLine();


                                   
                                    //here
                               }
                           }
                        }

                    }

                    //here1
                   else if ( (SProperty.PropertyType.IsClass ) && (SProperty.PropertyType.GetInterfaces().Contains(typeof(IEnumerable))) && (SProperty.PropertyType != typeof(string)) && (SProperty.PropertyType != typeof(int)) )
                    {
                        //object destValue = Activator.CreateInstance(DProperty.PropertyType).ToString();
                       // Console.WriteLine("he");

                        var S = (IEnumerable)SProperty.GetValue(source);
                        var D = (IEnumerable)DProperty.GetValue(destination);

                       // Console.WriteLine(S);

                        if ((SProperty.PropertyType == DProperty.PropertyType) && (SProperty.Name == DProperty.Name) )
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


                                //hhh
                               // Type s2 = item.GetType();
                                //var values2 = s2.GetProperties(BindingFlags.Instance);
                                //foreach (var value in values2)
                                //{
                                  //  Console.WriteLine(value.GetValue(item));
                                //}
                                //hhh
                                //Console.WriteLine(item);
                            }

                            Console.WriteLine();

                            //Console.WriteLine(destinationList.Count);


                            if (sourceList.Count == destinationList.Count)
                            {

                                for (int i = 0; i < sourceList.Count; i++)
                                {
                                    
                                    Copy(sourceList[i], destinationList[i]);



                                    //here
                                    if ((sourceList[i].Equals(destinationList[i])) )
                                    {
                                      // if (SProperty.Name != 0)
                                        //{

                                           Console.WriteLine($"Property Name: {SProperty.Name}");

                                       

                                        Console.WriteLine($"Source Value: {sourceList[i]}");
                                        Console.WriteLine($"Destination Value: {destinationList[i]}");
                                        Console.WriteLine();


                                       
                                        
                                        //}

                                    }
                                    //here

                                }
                            }
                        }
                    }
                }
            }
        
                        //here1


                    

                


            
            //here

           

           

            



        }

    }
}