using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DebugUtility : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AB80", Offset = "0x2F09580", VA = "0x182F0AB80")]
	public static void PrintDatabase(object obj, int depth = 1, bool dumpReferencedClassObjects = false)
	{
		//Discarded unreachable code: IL_00c6
		string[] array;
		string text2 = default(string);
		while (true)
		{
			array = new string[5];
			if ("<color=red>OBJECT DUMPING</color> OF <color=green>" != null && "<color=red>OBJECT DUMPING</color> OF <color=green>" == null)
			{
				continue;
			}
			array[0] = "<color=red>OBJECT DUMPING</color> OF <color=green>";
			string text = obj.GetType().ToString();
			if (text != null && text == null)
			{
				continue;
			}
			array[1] = text;
			if ("</color> <color=blue>Id: " != null && "</color> <color=blue>Id: " == null)
			{
				continue;
			}
			array[2] = "</color> <color=blue>Id: ";
			int hashCode = obj.GetHashCode();
			if (text2 == null || text2 != null)
			{
				array[3] = text2;
				if ("</color>" == null || "</color>" != null)
				{
					break;
				}
			}
		}
		array[4] = "</color>";
		string text3 = string.Concat(array);
		int identLevel = 0;
		string databaseString = GetDatabaseString(obj, identLevel, "", depth, dumpReferencedClassObjects);
		Debug.Log(string.Concat(text3 + databaseString, "\n\n\n\n"));
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AA90", Offset = "0x2F09490", VA = "0x182F0AA90")]
	public static string GetObjectDump(object obj, int depth = 5, bool dumpReferencedClassObjects = true)
	{
		//Discarded unreachable code: IL_0043
		//IL_002e: Expected I4, but got I8
		string text = obj.GetType().ToShortString();
		string text2 = "DATABASE OF <color=green>" + text + "</color>";
		int identLevel = 0;
		ulong num = default(ulong);
		string databaseString = GetDatabaseString(obj, identLevel, "", depth, (byte)num != 0);
		return string.Concat(text2 + databaseString, "\n\n\n\n");
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2F09840", Offset = "0x2F08240", VA = "0x182F09840")]
	public static string GetDatabaseString(object obj, int identLevel, string name = "", int maxLevel = 6, bool dumpReferencedClassObjects = true)
	{
		//Discarded unreachable code: IL_0204, IL_0211, IL_0219, IL_022b, IL_0236, IL_024b, IL_0256, IL_027a, IL_0288, IL_0296, IL_02bb, IL_02c6
		FieldInfo fieldInfo = default(FieldInfo);
		string text2 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		string result = default(string);
		string text8 = default(string);
		string text9 = default(string);
		string text10 = default(string);
		string text13 = default(string);
		string text12 = default(string);
		string text14 = default(string);
		while (true)
		{
			int num = 0;
			if (obj == null)
			{
				break;
			}
			if (!obj.GetType().IsArray && !obj.GetType().IsList())
			{
				if (!obj.GetType().IsGenericType && obj.GetType().IsClass)
				{
					FieldInfo[] fields = obj.GetType().GetFields();
					int length = fields.Length;
					if (num < length)
					{
						fieldInfo = fields[num];
						object value = fieldInfo.GetValue(obj);
						if (value != null)
						{
							if (!fieldInfo.FieldType.IsValueType)
							{
								Type fieldType = fieldInfo.FieldType;
								Type typeFromHandle = typeof(string);
								if (!((object)fieldType).Equals((object)typeFromHandle))
								{
									string[] array = new string[5];
									if ("<color=green>" != null && "<color=green>" == null)
									{
										continue;
									}
									array[0] = "<color=green>";
									string text = fieldInfo.FieldType.ToShortString();
									if (text != null && text == null)
									{
										continue;
									}
									array[1] = text;
									if ("</color> Id: <color=blue>" != null && "</color> Id: <color=blue>" == null)
									{
										continue;
									}
									array[2] = "</color> Id: <color=blue>";
									int hashCode = value.GetHashCode();
									if (text2 != null && text2 == null)
									{
										continue;
									}
									array[3] = text2;
									if ("</color>" != null && "</color>" == null)
									{
										continue;
									}
									array[4] = "</color>";
									string text3 = string.Concat(array);
								}
							}
							string text4 = value.ToString();
							string text5 = "<color=magenta>" + text4 + "</color>";
						}
						string[] array2 = new string[7];
						if ("" != null && array2 == null)
						{
							continue;
						}
						array2[0] = "";
						if ("\n" != null && "\n" == null)
						{
							continue;
						}
						array2[1] = "\n";
						if (text6 == null || text6 != null)
						{
							array2[2] = text6;
							bool isClass = fieldInfo.FieldType.IsClass;
							if ("" == null || isClass)
							{
								throw new IndexOutOfRangeException();
							}
						}
						continue;
					}
				}
				else
				{
					Type type = obj.GetType();
					if ((object)type != null)
					{
						text7 = type.ToString();
					}
					Debug.Log("Fail: " + text7);
				}
				return result;
			}
			object[] array3 = ArrayUtility.ConvertToObjectArray(obj);
			while ((long)(IntPtr)text7 >= (long)array3.Length)
			{
			}
			string[] array4 = new string[8];
			if (array4 == null || ("\n" != null && "\n" == null))
			{
				continue;
			}
			array4[1] = "\n";
			if ((long)(IntPtr)fieldInfo > 0L)
			{
				text8 = "" + "          ";
				while ((object)fieldInfo != null)
				{
				}
			}
			if (text8 != null)
			{
				text7 = text8;
				if (text8 == null)
				{
					continue;
				}
			}
			array4[2] = text8;
			if ("Element: " != null && "Element: " == null)
			{
				continue;
			}
			array4[3] = "Element: ";
			if (text9 != null)
			{
				text7 = text9;
				if (text9 == null)
				{
					continue;
				}
			}
			array4[4] = text9;
			if (" id: <color=blue>" != null && " id: <color=blue>" == null)
			{
				continue;
			}
			array4[5] = " id: <color=blue>";
			int hashCode2 = array3[(object)text7].GetHashCode();
			if (text10 != null)
			{
				text7 = text10;
				if (text10 == null)
				{
					continue;
				}
			}
			array4[6] = text10;
			if ("</color>" != null && "</color>" == null)
			{
				continue;
			}
			array4[7] = "</color>";
			string text11 = string.Concat(array4);
			if (!array3[(object)text7].GetType().IsValueType)
			{
				Type type2 = array3[(object)text7].GetType();
				if ((object)typeof(string) != null)
				{
					object obj2 = array3[(object)text7];
					text7 = text11;
					text13 = text11 + text12;
				}
			}
			string[] array5 = new string[5];
			if (text13 != null && array5 == null)
			{
				continue;
			}
			array5[0] = text13;
			if ("\n<color=magenta>" != null && "\n<color=magenta>" == null)
			{
				continue;
			}
			array5[1] = "\n<color=magenta>";
			if ((long)(IntPtr)"" > 0L)
			{
				text14 = "" + "          ";
				while ("" != null)
				{
				}
			}
			if (text14 != null && text14 == null)
			{
				continue;
			}
			array5[2] = text14;
			string text15 = array3[(object)text7].ToString();
			if (text15 == null || text15 != null)
			{
				array5[3] = text15;
				if ("</color>" == null || "</color>" != null)
				{
					array5[4] = "</color>";
					string text16 = string.Concat(array5);
					break;
				}
			}
		}
		return "";
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AA30", Offset = "0x2F09430", VA = "0x182F0AA30")]
	private static string GetIdentSpaces(int identLevel)
	{
		if (identLevel > 0)
		{
			string text = "" + "          ";
			while (identLevel != 0)
			{
			}
		}
		return "";
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public DebugUtility()
	{
	}
}
