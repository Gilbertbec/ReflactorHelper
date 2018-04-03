﻿/// ReflactorHelper, and with Custom Attribute could remove the switch case in your code 2018-03-02
/// Gilbert Zhang xixi2010@gamil.com
namespace HelpLibrary
{
	using System;
	using System.Reflection;

	public static class ReflactorHelper
	{
		public static Assembly GetAssemblyByAssemblyName(string assemblyName)
		{
			Assembly assembly = Assembly.Load(assemblyName);
			return assembly;
		}

		public static dynamic GetInstenceByClassName(string className, Assembly assembly)
		{
			var instance = assembly.CreateInstance(className, true);
			return instance;
		}

		public static dynamic GetInstenceByClassName(string className, string assemblyName)
		{
			Assembly assembly = Assembly.Load(assemblyName);
			var instance = assembly.CreateInstance(className, true);
			return instance;
		}

		public static FieldInfo GetFieldInfoByFieldName(string fieldName, dynamic fieldValue, object instance)
		{
			Type type = instance.GetType();
			FieldInfo fieldInfo = type.GetField(fieldName);
			return fieldInfo;
		}

		public static FieldInfo GetFieldInfoByFieldName(string fieldName, dynamic fieldValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			FieldInfo fieldInfo = type.GetField(fieldName);
			return fieldInfo;
		}

		public static dynamic SetFieldValueByFieldName(string fieldName, dynamic fieldValue, object instance)
		{
			Type type = instance.GetType();
			FieldInfo fieldInfo = type.GetField(fieldName);
			fieldInfo.SetValue(instance, fieldValue);
			return instance;
		}

		public static dynamic SetFieldValueByFieldName(string fieldName, dynamic fieldValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			type.GetField(fieldName).SetValue(instance, fieldValue);
			return instance;
		}

		public static FieldInfo GetPrivateFieldInfoByFieldName(string fieldName, dynamic fieldValue, object instance)
		{
			Type type = instance.GetType();
			FieldInfo fieldInfo = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
			return fieldInfo;
		}

		public static FieldInfo GetPrivateFieldInfoByFieldName(string fieldName, dynamic fieldValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			FieldInfo fieldInfo = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
			return fieldInfo;
		}

		public static dynamic SetPrivateFieldValueByFieldName(string fieldName, dynamic fieldValue, object instance)
		{
			Type type = instance.GetType();
			type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(instance, fieldValue);
			return instance;
		}

		public static dynamic SetPrivateFieldValueByFieldName(string fieldName, dynamic fieldValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(instance, fieldValue);
			return instance;
		}

		public static PropertyInfo GetPropertyInfoByPropertyName(string propertyName, dynamic propertyValue, object instance)
		{
			Type type = instance.GetType();
			PropertyInfo propertyInfo = type.GetProperty(propertyName);
			return propertyInfo;
		}

		public static PropertyInfo GetPropertyInfoByPropertyName(string propertyName, dynamic propertyValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			PropertyInfo propertyInfo = type.GetProperty(propertyName);
			return propertyInfo;
		}

		public static dynamic SetPropertyValueByPropertyName(string propertyName, dynamic propertyValue, object instance)
		{
			Type type = instance.GetType();
			type.GetProperty(propertyName).SetValue(instance, propertyValue);
			return instance;
		}

		public static dynamic SetPropertyValueByPropertyName(string propertyName, dynamic propertyValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			type.GetProperty(propertyName).SetValue(instance, propertyValue);
			return instance;
		}

		public static PropertyInfo GetPrivatePropertyInfoByPropertyName(string propertyName, dynamic propertyValue, object instance)
		{
			Type type = instance.GetType();
			PropertyInfo propertyInfo = type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic);
			return propertyInfo;
		}

		public static PropertyInfo GetPrivatePropertyInfoByPropertyName(string propertyName, dynamic propertyValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			PropertyInfo propertyInfo = type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic);
			return propertyInfo;
		}

		public static dynamic SetPrivatePropertyValueByPropertyName(string propertyName, dynamic propertyValue, object instance)
		{
			Type type = instance.GetType();
			type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(instance, propertyValue);
			return instance;
		}

		public static dynamic SetPrivatePropertyValueByPropertyName(string propertyName, dynamic propertyValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(instance, propertyValue);
			return instance;
		}

		public static MethodInfo GetMethodInfoByMethodName(string methodName, dynamic methodValue, object instance)
		{
			Type type = instance.GetType();
			MethodInfo methodInfo = type.GetMethod(methodName);
			return methodInfo;
		}

		public static MethodInfo GetMethodInfoByMethodName(string methodName, dynamic methodValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			MethodInfo methodInfo = type.GetMethod(methodName);
			return methodInfo;
		}

		public static void InvokeMethodValueByMethodName(string methodName, dynamic instance)
		{
			Type type = instance.GetType();
			type.GetMethod(methodName).Invoke(instance, null);
		}

		public static void InvokeMethodValueByMethodName(string methodName, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			type.GetMethod(methodName).Invoke(instance, null);
		}

		public static MethodInfo GetPrivateMethodInfoByMethodName(string methodName, dynamic methodValue, object instance)
		{
			Type type = instance.GetType();
			MethodInfo methodInfo = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
			return methodInfo;
		}

		public static MethodInfo GetPrivateMethodInfoByMethodName(string methodName, dynamic methodValue, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			MethodInfo methodInfo = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
			return methodInfo;
		}

		public static void InvokePrivateMethodValueByMethodName(string methodName, object instance)
		{
			Type type = instance.GetType();
			type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic).Invoke(instance, null);
		}

		public static void InvokePrivateMethodValueByMethodName(string methodName, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic).Invoke(instance, null);
		}

		public static Func<object, object[], object> GetDelegateMethodValueByMethodName(string methodName, object instance)
		{
			Type type = instance.GetType();
			Func<object, object[], object> func = type.GetMethod(methodName).Invoke;
			return func;
		}

		public static Func<object, object[], object> GetDelegateMethodValueByMethodName(string methodName, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			Func<object, object[], object> func = type.GetMethod(methodName).Invoke;
			return func;
		}

		public static Func<object, object[], object> GetDelegatePrivateMethodValueByMethodName(string methodName, object instance)
		{
			Type type = instance.GetType();
			Func<object, object[], object> func = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic).Invoke;
			return func;
		}

		public static Func<object, object[], object> GetDelegatePrivateMethodValueByMethodName(string methodName, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			MethodInfo methodInfo = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
			Func<object, object[], object> func = methodInfo.Invoke;

			return func;
		}

		public static void InvokeMethodValueByAttributeName(string functionName, string conditionString, object instance)
		{
			Type type = instance.GetType();
			MethodInfo[] methodInfo = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			foreach (var method in methodInfo)
			{
				object[] attributes = method.GetCustomAttributes(typeof(ConditionAttribute), true);
				foreach (var item in attributes)
				{
					ConditionAttribute attr = item as ConditionAttribute;
					if (null != attr)
					{
						if (attr.FunctionName == functionName && attr.ConditionString == conditionString)
						{
							type.GetMethod(method.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Invoke(instance, null);
						}
					}
				}
			}
		}

		public static void InvokeMethodValueByAttributeName(string functionName, string conditionString, string className, string assemblyName)
		{
			Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
			var instance = GetInstenceByClassName(className, assembly);
			Type type = instance.GetType();
			MethodInfo[] methodInfo = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
			foreach (var method in methodInfo)
			{
				object[] attributes = method.GetCustomAttributes(typeof(ConditionAttribute), true);
				foreach (var item in attributes)
				{
					ConditionAttribute attr = item as ConditionAttribute;
					if (null != attr)
					{
						if (attr.FunctionName == functionName && attr.ConditionString == conditionString)
						{
							type.GetMethod(method.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Invoke(instance, null);
						}
					}
				}
			}
		}
	}
}
