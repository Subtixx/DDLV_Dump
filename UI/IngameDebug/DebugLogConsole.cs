using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Mdl.Platform;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public static class DebugLogConsole
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public delegate bool ParseFunction(string input, out object output);

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private static readonly Dictionary<string, ConsoleMethodInfo> methods;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static readonly Dictionary<Type, ParseFunction> parseFunctions;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static readonly Dictionary<Type, string> typeReadableNames;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static readonly List<string> commandArguments;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static readonly string[] inputDelimiters;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x112E330", Offset = "0x112CD30", VA = "0x18112E330")]
		static unsafe DebugLogConsole()
		{
			//Discarded unreachable code: IL_0034, IL_0058, IL_007c, IL_00a0, IL_00c4, IL_00e8, IL_010c, IL_0130, IL_0154, IL_0178, IL_019c, IL_01c0, IL_01e4, IL_0208, IL_022c, IL_0250, IL_0274, IL_0298, IL_02b7, IL_02c9, IL_02db, IL_02ed, IL_02ff, IL_0311, IL_0323, IL_0335, IL_0347, IL_0359, IL_036b, IL_037d, IL_038f, IL_03a1, IL_03b3, IL_03c5, IL_03d7, IL_03e9, IL_040c, IL_0417, IL_042c, IL_0437, IL_044c, IL_0457, IL_046c, IL_0477, IL_048c, IL_0497, IL_04ed, IL_04fe, IL_0506, IL_0516, IL_0528, IL_052f, IL_0576
			//IL_002a: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_00dd: Expected O, but got I4
			//IL_0101: Expected O, but got I4
			//IL_0125: Expected O, but got I4
			//IL_0149: Expected O, but got I4
			//IL_016d: Expected O, but got I4
			//IL_0191: Expected O, but got I4
			//IL_01b5: Expected O, but got I4
			//IL_01d9: Expected O, but got I4
			//IL_01fd: Expected O, but got I4
			//IL_0221: Expected O, but got I4
			//IL_0245: Expected O, but got I4
			//IL_0269: Expected O, but got I4
			//IL_028d: Expected O, but got I4
			//IL_0516: Expected O, but got I4
			//IL_0516: Expected O, but got I4
			//IL_0516: Expected O, but got I4
			//IL_0516: Expected O, but got I4
			//IL_053c: Expected O, but got I4
			//IL_055f: Expected O, but got I4
			int num = 0;
			methods = (Dictionary<string, ConsoleMethodInfo>)(object)new Dictionary<TKey, TValue>();
			Dictionary<Type, ParseFunction> dictionary = (Dictionary<Type, ParseFunction>)(object)new Dictionary<TKey, TValue>();
			Type typeFromHandle = typeof(string);
			int num2 = default(int);
			ParseFunction parseFunction = new ParseFunction(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<string, out object, bool>*/)(&ParseString));
			num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x112C9F0", Offset = "0x112B3F0", VA = "0x18112C9F0")]
		public static void LogAllCommands()
		{
			//Discarded unreachable code: IL_006d, IL_0073, IL_0079, IL_007f, IL_0085
			int num = 0;
			Dictionary<string, ConsoleMethodInfo> dictionary = methods;
			bool flag = default(bool);
			uint num2 = default(uint);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num2 += (flag2 ? 1u : 0u);
			}
			StringBuilder stringBuilder = new StringBuilder((int)num2);
			StringBuilder stringBuilder2 = stringBuilder.Append("Available commands:");
			Dictionary<string, ConsoleMethodInfo> dictionary2 = methods;
			bool flag3 = default(bool);
			if (flag3)
			{
				bool flag4 = default(bool);
				while (!flag4)
				{
				}
				StringBuilder stringBuilder3 = stringBuilder.Append("\n- ").Append("\n- ");
			}
			Debug.Log(stringBuilder.Append("\n").ToString());
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x112CD70", Offset = "0x112B770", VA = "0x18112CD70")]
		public static void LogSystemInfo()
		{
			//Discarded unreachable code: IL_0415
			StringBuilder stringBuilder = new StringBuilder(1024);
			StringBuilder stringBuilder2 = stringBuilder.Append("Rig: ");
			int num = 0;
			bool flag = default(bool);
			if (flag)
			{
				StringBuilder stringBuilder3 = stringBuilder2.Append(" ");
			}
			int num2 = 0;
			bool flag2 = default(bool);
			StringBuilder stringBuilder4 = default(StringBuilder);
			if (flag2)
			{
				stringBuilder4 = stringBuilder2.Append(" ");
			}
			int num3 = 0;
			if ((long)(IntPtr)stringBuilder4 > 0L)
			{
				if ("MB RAM" != null)
				{
					StringBuilder stringBuilder5 = stringBuilder2.Append("MB RAM");
				}
				StringBuilder stringBuilder6 = stringBuilder2.Append(" ");
			}
			int num4 = 0;
			StringBuilder stringBuilder7 = default(StringBuilder);
			StringBuilder stringBuilder8 = stringBuilder7.Append(" cores\n");
			StringBuilder stringBuilder9 = stringBuilder.Append("OS: ");
			int num5 = 0;
			StringBuilder stringBuilder10 = default(StringBuilder);
			StringBuilder stringBuilder11 = stringBuilder10.Append("\n");
			StringBuilder stringBuilder12 = stringBuilder.Append("GPU: ");
			int num6 = 0;
			string graphicsDeviceName = Mdl.Platform.SystemInfo.graphicsDeviceName;
			StringBuilder stringBuilder13 = stringBuilder12.Append(graphicsDeviceName).Append(" ");
			int num7 = 0;
			StringBuilder stringBuilder14 = default(StringBuilder);
			StringBuilder stringBuilder15 = stringBuilder14.Append("MB ");
			int num8 = 0;
			int num9 = 0;
			string value = "\n";
			StringBuilder stringBuilder16 = default(StringBuilder);
			if (stringBuilder16 != null)
			{
				value = " multi-threaded\n";
			}
			StringBuilder stringBuilder17 = stringBuilder16.Append(value);
			StringBuilder stringBuilder18 = stringBuilder.Append("Data Path: ");
			int num10 = 0;
			string dataPath = Application.dataPath;
			StringBuilder stringBuilder19 = stringBuilder18.Append(dataPath).Append("\n");
			StringBuilder stringBuilder20 = stringBuilder.Append("Persistent Data Path: ");
			IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
			StringBuilder stringBuilder21 = default(StringBuilder);
			StringBuilder stringBuilder22 = stringBuilder21.Append("\n");
			StringBuilder stringBuilder23 = stringBuilder.Append("StreamingAssets Path: ");
			int num11 = 0;
			string streamingAssetsPath = Application.streamingAssetsPath;
			StringBuilder stringBuilder24 = stringBuilder23.Append(streamingAssetsPath).Append("\n");
			StringBuilder stringBuilder25 = stringBuilder.Append("Temporary Cache Path: ");
			int num12 = 0;
			string temporaryCachePath = Application.temporaryCachePath;
			StringBuilder stringBuilder26 = stringBuilder25.Append(temporaryCachePath).Append("\n");
			StringBuilder stringBuilder27 = stringBuilder.Append("Device ID: ");
			int num13 = 0;
			StringBuilder stringBuilder28 = default(StringBuilder);
			StringBuilder stringBuilder29 = stringBuilder28.Append("\n");
			StringBuilder stringBuilder30 = stringBuilder.Append("Max Texture Size: ");
			int num14 = 0;
			StringBuilder stringBuilder31 = default(StringBuilder);
			StringBuilder stringBuilder32 = stringBuilder31.Append("\n");
			StringBuilder stringBuilder33 = stringBuilder.Append("Max Cubemap Size: ");
			int num15 = 0;
			StringBuilder stringBuilder34 = default(StringBuilder);
			StringBuilder stringBuilder35 = stringBuilder34.Append("\n");
			StringBuilder stringBuilder36 = stringBuilder.Append("Accelerometer: ");
			int num16 = 0;
			string value2 = "not supported\n";
			if (stringBuilder36 != null)
			{
				value2 = "supported\n";
			}
			StringBuilder stringBuilder37 = stringBuilder36.Append(value2);
			StringBuilder stringBuilder38 = stringBuilder.Append("Gyro: ");
			int num17 = 0;
			string value3 = "not supported\n";
			if (stringBuilder38 != null)
			{
				value3 = "supported\n";
			}
			StringBuilder stringBuilder39 = stringBuilder38.Append(value3);
			StringBuilder stringBuilder40 = stringBuilder.Append("Location Service: ");
			int num18 = 0;
			string value4 = "not supported\n";
			if (stringBuilder40 != null)
			{
				value4 = "supported\n";
			}
			StringBuilder stringBuilder41 = stringBuilder40.Append(value4);
			StringBuilder stringBuilder42 = stringBuilder.Append("Compute Shaders: ");
			int num19 = 0;
			string value5 = "not supported\n";
			if (stringBuilder42 != null)
			{
				value5 = "supported\n";
			}
			StringBuilder stringBuilder43 = stringBuilder42.Append(value5);
			StringBuilder stringBuilder44 = stringBuilder.Append("Shadows: ");
			int num20 = 0;
			string value6 = "not supported\n";
			if (stringBuilder44 != null)
			{
				value6 = "supported\n";
			}
			StringBuilder stringBuilder45 = stringBuilder44.Append(value6);
			StringBuilder stringBuilder46 = stringBuilder.Append("Instancing: ");
			int num21 = 0;
			string value7 = "not supported\n";
			if (stringBuilder46 != null)
			{
				value7 = "supported\n";
			}
			StringBuilder stringBuilder47 = stringBuilder46.Append(value7);
			StringBuilder stringBuilder48 = stringBuilder.Append("Motion Vectors: ");
			int num22 = 0;
			string value8 = "not supported\n";
			if (stringBuilder48 != null)
			{
				value8 = "supported\n";
			}
			StringBuilder stringBuilder49 = stringBuilder48.Append(value8);
			StringBuilder stringBuilder50 = stringBuilder.Append("3D Textures: ");
			int num23 = 0;
			string value9 = "not supported\n";
			if (stringBuilder50 != null)
			{
				value9 = "supported\n";
			}
			StringBuilder stringBuilder51 = stringBuilder50.Append(value9);
			StringBuilder stringBuilder52 = stringBuilder.Append("3D Render Textures: ");
			int num24 = 0;
			string value10 = "not supported\n";
			if (stringBuilder52 != null)
			{
				value10 = "supported\n";
			}
			StringBuilder stringBuilder53 = stringBuilder52.Append(value10);
			StringBuilder stringBuilder54 = stringBuilder.Append("2D Array Textures: ");
			int num25 = 0;
			string value11 = "not supported\n";
			if (stringBuilder54 != null)
			{
				value11 = "supported\n";
			}
			StringBuilder stringBuilder55 = stringBuilder54.Append(value11);
			StringBuilder stringBuilder56 = stringBuilder.Append("Cubemap Array Textures: ");
			int num26 = 0;
			string value12 = "not supported";
			if (stringBuilder56 != null)
			{
				value12 = "supported";
			}
			StringBuilder stringBuilder57 = stringBuilder56.Append(value12);
			Debug.Log(stringBuilder.Append("\n").ToString());
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x112B3E0", Offset = "0x1129DE0", VA = "0x18112B3E0")]
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, string info, [Optional] string postfix)
		{
			//Discarded unreachable code: IL_0030
			if (info != "n/a")
			{
				StringBuilder stringBuilder = sb.Append(info);
				if (postfix != null)
				{
					StringBuilder stringBuilder2 = sb.Append(postfix);
				}
				StringBuilder stringBuilder3 = sb.Append(" ");
			}
			return sb;
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x112B490", Offset = "0x1129E90", VA = "0x18112B490")]
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, int info, [Optional] string postfix)
		{
			//Discarded unreachable code: IL_0026
			if (info > 0)
			{
				StringBuilder stringBuilder = sb.Append(info);
				if (postfix != null)
				{
					StringBuilder stringBuilder2 = sb.Append(postfix);
				}
				StringBuilder stringBuilder3 = sb.Append(" ");
			}
			return sb;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x112A800", Offset = "0x1129200", VA = "0x18112A800")]
		public static void AddCommandInstance(string command, string description, string methodName, object instance)
		{
			if (instance != null)
			{
				Type type = instance.GetType();
				AddCommand(command, description, methodName, type, instance);
			}
			Debug.LogError("Instance can't be null!");
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x112A900", Offset = "0x1129300", VA = "0x18112A900")]
		public static void AddCommandStatic(string command, string description, string methodName, Type ownerType)
		{
			//IL_000c: Expected O, but got I4
			int num = 0;
			AddCommand(command, description, methodName, ownerType, num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x112B330", Offset = "0x1129D30", VA = "0x18112B330")]
		public static void AddCommand(string command, string description, Action method)
		{
			//Discarded unreachable code: IL_0018
			MethodInfo method2 = method.Method;
			object target = ((Delegate)method).m_target;
			AddCommand(command, description, method2, target);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x16D9F00", Offset = "0x16D8900", VA = "0x1816D9F00")]
		public static void AddCommand<T1>(string P_0, string P_1, Action<> P_2)
		{
			//Discarded unreachable code: IL_0011
			MethodInfo method = P_2.Method;
			AddCommand(P_0, P_1, method, P_2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x16D9FB0", Offset = "0x16D89B0", VA = "0x1816D9FB0")]
		public static void AddCommand<T1>(string command, string description, Func<T1> method)
		{
			//Discarded unreachable code: IL_0011
			MethodInfo method2 = method.Method;
			AddCommand(command, description, method2, method);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x16D9DA0", Offset = "0x16D87A0", VA = "0x1816D9DA0")]
		public static void AddCommand<T1, T2>(string command, string description, Action<T1, T2> method)
		{
			//Discarded unreachable code: IL_0011
			MethodInfo method2 = method.Method;
			AddCommand(command, description, method2, method);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x16D9E50", Offset = "0x16D8850", VA = "0x1816D9E50")]
		public static void AddCommand<T1, T2>(string command, string description, Func<T1, T2> method)
		{
			//Discarded unreachable code: IL_0011
			MethodInfo method2 = method.Method;
			AddCommand(command, description, method2, method);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x16D9CF0", Offset = "0x16D86F0", VA = "0x1816D9CF0")]
		public static void AddCommand<T1, T2, T3>(string command, string description, Action<T1, T2, T3> method)
		{
			//Discarded unreachable code: IL_0011
			MethodInfo method2 = method.Method;
			AddCommand(command, description, method2, method);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x16D9C40", Offset = "0x16D8640", VA = "0x1816D9C40")]
		public static void AddCommand<T1, T2, T3>(string command, string description, Func<T1, T2, T3> method)
		{
			//Discarded unreachable code: IL_0011
			MethodInfo method2 = method.Method;
			AddCommand(command, description, method2, method);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x16D9B90", Offset = "0x16D8590", VA = "0x1816D9B90")]
		public static void AddCommand<T1, T2, T3, T4>(string command, string description, Action<T1, T2, T3, T4> method)
		{
			//Discarded unreachable code: IL_0011
			MethodInfo method2 = method.Method;
			AddCommand(command, description, method2, method);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x16D9AE0", Offset = "0x16D84E0", VA = "0x1816D9AE0")]
		public static void AddCommand<T1, T2, T3, T4>(string command, string description, Func<T1, T2, T3, T4> method)
		{
			//Discarded unreachable code: IL_0011
			MethodInfo method2 = method.Method;
			AddCommand(command, description, method2, method);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x16D9A30", Offset = "0x16D8430", VA = "0x1816D9A30")]
		public static void AddCommand<T1, T2, T3, T4, T5>(string command, string description, Func<T1, T2, T3, T4, T5> method)
		{
			//Discarded unreachable code: IL_0011
			MethodInfo method2 = method.Method;
			AddCommand(command, description, method2, method);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x112A990", Offset = "0x1129390", VA = "0x18112A990")]
		public static void AddCommand(string command, string description, Delegate method)
		{
			//Discarded unreachable code: IL_0018
			MethodInfo method2 = method.Method;
			object target = method.m_target;
			AddCommand(command, description, method2, target);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x112E290", Offset = "0x112CC90", VA = "0x18112E290")]
		public static void RemoveCommand(string command)
		{
			//Discarded unreachable code: IL_0017
			if (!string.IsNullOrEmpty(command))
			{
				bool flag = ((Dictionary<TKey, TValue>)(object)methods).Remove((TKey)command);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x112C6F0", Offset = "0x112B0F0", VA = "0x18112C6F0")]
		public static string GetAutoCompleteCommand(string commandStart)
		{
			//Discarded unreachable code: IL_0023
			int num = 0;
			Dictionary<string, ConsoleMethodInfo> dictionary = methods;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				num++;
			}
			if (num + 1 != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x112AA40", Offset = "0x1129440", VA = "0x18112AA40")]
		private static void AddCommand(string command, string description, string methodName, Type ownerType, [Optional] object instance)
		{
			//IL_0014: Expected O, but got I4
			MethodInfo method = ownerType.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			int num = 0;
			if (!(method == (MethodInfo)num))
			{
				return;
			}
			string text = ownerType.ToString();
			Debug.LogError(methodName + " does not exist in " + text);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x112AB90", Offset = "0x1129590", VA = "0x18112AB90")]
		private unsafe static void AddCommand(string command, string description, MethodInfo method, [Optional] object instance)
		{
			//Discarded unreachable code: IL_005c, IL_0061, IL_007c, IL_0081, IL_0089, IL_008f, IL_01d5, IL_01d6
			int num = 0;
			if ("." == null)
			{
				string value = command.Trim();
				ParameterInfo[] parameters = method.GetParameters();
				if (parameters == null)
				{
					ParameterInfo[] array = new ParameterInfo[0];
				}
				Type[] array2 = new Type[parameters.Length];
				int length = parameters.Length;
				if (num < length)
				{
					Type parameterType = parameters[num].ParameterType;
					Dictionary<Type, ParseFunction> dictionary = parseFunctions;
					throw new NullReferenceException();
				}
				StringBuilder stringBuilder = new StringBuilder(256);
				if (stringBuilder.Append(value).Append(": ") == null)
				{
					StringBuilder stringBuilder2 = stringBuilder.Append(description).Append(" -> ");
				}
				string value2 = method.DeclaringType.ToString();
				StringBuilder stringBuilder3 = stringBuilder.Append(value2).Append(".");
				string name = method.Name;
				StringBuilder stringBuilder4 = stringBuilder3.Append(name).Append("(");
				int num2 = 0;
				int num3 = 0;
				int length2 = array2.Length;
				if (num2 < length2)
				{
					Type type = array2[num3];
					string name2 = default(string);
					if (!((Dictionary<TKey, TValue>)(object)typeReadableNames).TryGetValue((TKey)type, out *(TValue*)num))
					{
						name2 = type.Name;
					}
					StringBuilder stringBuilder5 = stringBuilder.Append(name2);
					int length3 = array2.Length;
					if (num3 < length3)
					{
						StringBuilder stringBuilder6 = stringBuilder.Append(", ");
					}
					num3++;
				}
				StringBuilder stringBuilder7 = stringBuilder.Append(")");
				Type returnType = method.ReturnType;
				if ((object)typeof(void) != null)
				{
					string name3 = default(string);
					if (!((Dictionary<TKey, TValue>)(object)typeReadableNames).TryGetValue((TKey)returnType, out *(TValue*)num))
					{
						name3 = returnType.Name;
					}
					StringBuilder stringBuilder8 = stringBuilder.Append(" : ").Append(name3);
				}
				Dictionary<string, ConsoleMethodInfo> dictionary2 = methods;
				string text = stringBuilder.ToString();
				throw new NullReferenceException();
			}
			Debug.LogError("Command name can't be empty!");
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x112BB30", Offset = "0x112A530", VA = "0x18112BB30")]
		public static void ExecuteCommand(string command)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x112C8F0", Offset = "0x112B2F0", VA = "0x18112C8F0")]
		private static int IndexOfDelimiter(char c)
		{
			//Discarded unreachable code: IL_0035
			int num = 0;
			string[] array = inputDelimiters;
			if (num < array.Length)
			{
				string text = inputDelimiters[num];
				int index = 0;
				char c2 = text[index];
				if (c != c2)
				{
					num++;
				}
				return num;
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x112C8C0", Offset = "0x112B2C0", VA = "0x18112C8C0")]
		private static int IndexOfChar(string command, char c, int startIndex)
		{
			//Discarded unreachable code: IL_0010
			int num = command.IndexOf(c, startIndex);
			return command.m_stringLength;
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x112DE90", Offset = "0x112C890", VA = "0x18112DE90")]
		private static bool ParseString(string input, out object output)
		{
			//Discarded unreachable code: IL_000a
			return input.m_stringLength > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x112D7E0", Offset = "0x112C1E0", VA = "0x18112D7E0")]
		private static bool ParseBool(string input, out object output)
		{
			//Discarded unreachable code: IL_0046
			if (!string.Equals(input, "1") && !string.Equals(input.ToLowerInvariant(), "true") && !string.Equals(input, "0") && !string.Equals(input.ToLowerInvariant(), "false"))
			{
				int num = 0;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x112DC90", Offset = "0x112C690", VA = "0x18112DC90")]
		private static bool ParseInt(string input, out object output)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x112DED0", Offset = "0x112C8D0", VA = "0x18112DED0")]
		private static bool ParseUInt(string input, out object output)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x112DD10", Offset = "0x112C710", VA = "0x18112DD10")]
		private static bool ParseLong(string input, out object output)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x112DF50", Offset = "0x112C950", VA = "0x18112DF50")]
		private unsafe static bool ParseULong(string input, out object output)
		{
			ulong num = default(ulong);
			return ulong.TryParse(input, out *(ulong*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x112D930", Offset = "0x112C330", VA = "0x18112D930")]
		private static bool ParseByte(string input, out object output)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x112DD90", Offset = "0x112C790", VA = "0x18112DD90")]
		private static bool ParseSByte(string input, out object output)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x112DE10", Offset = "0x112C810", VA = "0x18112DE10")]
		private unsafe static bool ParseShort(string input, out object output)
		{
			int num = 0;
			return short.TryParse(input, out *(short*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x112DFD0", Offset = "0x112C9D0", VA = "0x18112DFD0")]
		private unsafe static bool ParseUShort(string input, out object output)
		{
			int num = 0;
			return ushort.TryParse(input, out *(ushort*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x112D9B0", Offset = "0x112C3B0", VA = "0x18112D9B0")]
		private unsafe static bool ParseChar(string input, out object output)
		{
			int num = 0;
			return char.TryParse(input, out *(char*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x112DB90", Offset = "0x112C590", VA = "0x18112DB90")]
		private unsafe static bool ParseFloat(string input, out object output)
		{
			int num = 0;
			return float.TryParse(input, out *(float*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x112DAF0", Offset = "0x112C4F0", VA = "0x18112DAF0")]
		private static bool ParseDouble(string input, out object output)
		{
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x112DA50", Offset = "0x112C450", VA = "0x18112DA50")]
		private unsafe static bool ParseDecimal(string input, out object output)
		{
			int num = 0;
			return decimal.TryParse(input, out *(decimal*)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x112E050", Offset = "0x112CA50", VA = "0x18112E050")]
		private static bool ParseVector2(string input, out object output)
		{
			Type typeFromHandle = typeof(Vector2);
			return CreateVectorFromInput(input, typeFromHandle, out output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x112E110", Offset = "0x112CB10", VA = "0x18112E110")]
		private static bool ParseVector3(string input, out object output)
		{
			Type typeFromHandle = typeof(Vector3);
			return CreateVectorFromInput(input, typeFromHandle, out output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x112E1D0", Offset = "0x112CBD0", VA = "0x18112E1D0")]
		private static bool ParseVector4(string input, out object output)
		{
			Type typeFromHandle = typeof(Vector4);
			return CreateVectorFromInput(input, typeFromHandle, out output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x112DC20", Offset = "0x112C620", VA = "0x18112DC20")]
		private static bool ParseGameObject(string input, out object output)
		{
			if (string.Equals(input, "null"))
			{
			}
			GameObject gameObject = GameObject.Find(input);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x112B520", Offset = "0x1129F20", VA = "0x18112B520")]
		private static bool CreateVectorFromInput(string input, Type vectorType, out object output)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
