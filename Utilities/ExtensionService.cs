using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Template.Utilities
{
	public static class ExtensionService
	{
		/// <summary>
		/// Maps values of the matching properties of an object. Ignores null on source. 
		/// </summary>
		/// <typeparam name="TSource">the type of source object</typeparam>
		/// <typeparam name="TOut">the type of mapped object</typeparam>
		/// <param name="obj">object with values</param>
		/// <param name="dest">object where values are mapped</param>
		public static void MapClass<TSource, TOut>(this TSource obj, TOut dest)
		{
			foreach (PropertyInfo piSource in obj.GetType().GetProperties())
			{
				if (piSource.CanRead && piSource.GetValue(obj, null) != null) //make sure the source value is readable & exist
				{
					//Get the property from destination as the same name as source
					PropertyInfo piOut = dest.GetType().GetProperty(piSource.Name);

					if (piOut != null) //If property exists in destination
					{
						if (piOut.CanRead && piOut.CanWrite) //if dest prop is read/write
						{
							//destProp value is NOT the same as sourceProp value
							if (!piSource.GetValue(obj, null).Equals(piOut.GetValue(dest, null))) //If matching property is found
							{
								piOut.SetValue(dest, piSource.GetValue(obj, null), null);
							}
						}
						else if (piOut.CanWrite) //for some reason it is only writable.. 
						{
							piOut.SetValue(dest, piSource.GetValue(obj, null), null);
						}
						//If dest prop is read only, update nothing
					}
				}
			}
		}

		/// <summary>
		/// Maps propert that are defined in CommonLanguageRuntimeLibrary 
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TOut"></typeparam>
		/// <param name="obj"></param>
		/// <param name="dest"></param>
		public static void MapOnlyMSCORL<TSource, TOut>(this TSource obj, TOut dest)
		{
			foreach (PropertyInfo piSource in obj.GetType().GetProperties())
			{
				bool isCLR = piSource.PropertyType.Module.Assembly.ManifestModule.ScopeName == "CommonLanguageRuntimeLibrary";

				if (isCLR)
				{
					if (piSource.CanRead && piSource.GetValue(obj, null) != null) //make sure the source value is readable & exist
					{
						//Get the property from destination as the same name as source
						PropertyInfo piOut = dest.GetType().GetProperty(piSource.Name);

						if (piOut != null) //If property exists in destination
						{
							if (piOut.CanRead && piOut.CanWrite) //if dest prop is read/write
							{
								//destProp value is NOT the same as sourceProp value
								if (!piSource.GetValue(obj, null).Equals(piOut.GetValue(dest, null))) //If matching property is found
								{
									piOut.SetValue(dest, piSource.GetValue(obj, null), null);
								}
							}
							else if (piOut.CanWrite) //for some reason it is only writable.. 
							{
								piOut.SetValue(dest, piSource.GetValue(obj, null), null);
							}
							//If dest prop is read only, update nothing
						}
					}
				}
			}
		}


		/// <summary>
		/// Maps Properties that are value type and string. Does not Map Null values
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TOut"></typeparam>
		/// <param name="obj"></param>
		/// <param name="dest"></param>
		public static void MapPrimitiveNullOnly<TSource, TOut>(this TSource obj, TOut dest)
		{
			foreach (PropertyInfo piSource in obj.GetType().GetProperties())
			{
				bool isPrim = ((piSource.PropertyType.IsPrimitive || piSource.PropertyType == typeof(string)) ||
					(!piSource.PropertyType.IsPrimitive && !piSource.PropertyType.IsClass && !piSource.PropertyType.IsInterface));

				if (isPrim)
				{
					if (piSource.CanRead && piSource.GetValue(obj, null) != null) //make sure the source value is readable & exist
					{
						//Get the property from destination as the same name as source
						PropertyInfo piOut = dest.GetType().GetProperty(piSource.Name);

						if (piOut != null) //If property exists in destination
						{
							if (piOut.CanRead && piOut.CanWrite) //if dest prop is read/write
							{
								//destProp value is NOT the same as sourceProp value
								if (!piSource.GetValue(obj, null).Equals(piOut.GetValue(dest, null))) //If matching property is found
								{
									piOut.SetValue(dest, piSource.GetValue(obj, null), null);
								}
							}
							else if (piOut.CanWrite) //for some reason it is only writable.. 
							{
								piOut.SetValue(dest, piSource.GetValue(obj, null), null);
							}
							//If dest prop is read only, update nothing
						}
					}
				}
			}
		}


		/// <summary>
		/// Maps Properties that are primitive type and string. Also maps null
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TOut"></typeparam>
		/// <param name="obj"></param>
		/// <param name="dest"></param>
		public static void MapPrimitiveAndNull<TSource, TOut>(this TSource obj, TOut dest)
		{
			foreach (PropertyInfo piSource in obj.GetType().GetProperties())
			{
				//Is Primitive or string 
				bool isPrim = ((piSource.PropertyType.IsPrimitive || piSource.PropertyType == typeof(string)) ||
					(!piSource.PropertyType.IsPrimitive && !piSource.PropertyType.IsClass && !piSource.PropertyType.IsInterface));

				if (isPrim)
				{
					if (piSource.CanRead) //value is readable 
					{
						if (piSource.GetValue(obj, null) != null)//make sure the source property has value
						{
							//Get the property from destination as the same name as source
							PropertyInfo piOut = dest.GetType().GetProperty(piSource.Name);

							if (piOut != null) //If property exists in destination
							{
								if (piOut.CanRead && piOut.CanWrite) //if dest prop is read/write
								{
									//destProp value is NOT the same as sourceProp value
									if (!piSource.GetValue(obj, null).Equals(piOut.GetValue(dest, null))) //If matching property is found
									{
										piOut.SetValue(dest, piSource.GetValue(obj, null), null);
									}
								}
								else if (piOut.CanWrite) //for some reason it is only writable.. 
								{
									piOut.SetValue(dest, piSource.GetValue(obj, null), null);
								}
								//If dest prop is read only, update nothing
							}
						}
						else //value is null
						{
							//Get the property from destination as the same name as source
							PropertyInfo piOut = dest.GetType().GetProperty(piSource.Name);
							if (piOut != null) //If property exists in destination
							{
								if (piOut.CanWrite) //if dest prop is writable
								{
									piOut.SetValue(dest, null, null);
								}
							}
						}
					}

				}
			}
		}

	}
}
