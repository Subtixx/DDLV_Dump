using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Definitions.Util;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000A51")]
	public static class ScriptProcess
	{
		[Cpp2IlInjected.Token(Token = "0x40028F0")]
		private static readonly Regex Pattern;

		[Cpp2IlInjected.Token(Token = "0x60058ED")]
		[Cpp2IlInjected.Address(RVA = "0x176AF70", Offset = "0x1769970", VA = "0x18176AF70")]
		internal static bool ProcessCommands(string commands, in Player player, in World world, ITransactionContext context)
		{
			bool result = default(bool);
			if ((long)commands != 0 && player.IsValid && world.IsValid && (long)context != 0)
			{
				return result;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058EE")]
		[Cpp2IlInjected.Address(RVA = "0x176A9F0", Offset = "0x17693F0", VA = "0x18176A9F0")]
		private static bool ProcessCommandLine(string line, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00bc, IL_00c2, IL_00c8, IL_00ce, IL_00d4, IL_00da, IL_00e0, IL_00ec
			int num = 0;
			int num2 = 0;
			if (line != null && world.IsValid && context != null)
			{
				string text = line.Trim();
				if (!text.StartsWith("//") && !text.StartsWith("##"))
				{
					MatchCollection matchCollection = default(MatchCollection);
					IEnumerator enumerator = matchCollection.GetEnumerator();
					bool flag = default(bool);
					if (enumerator != null)
					{
						if (enumerator == null)
						{
						}
						int num3 = 0;
						if (enumerator == null)
						{
							throw new InvalidCastException();
						}
						List<string> list = (List<string>)(object)new List<T>();
						Group group = default(Group);
						if (group.Captures.GetEnumerator() != null)
						{
							string item = default(string);
							((List<T>)(object)list).Add((T)item);
						}
						num2++;
						if (num2 != 0)
						{
						}
						if (num2 != 0)
						{
						}
						Group group2 = default(Group);
						string value = group2.Value;
						while (flag)
						{
						}
						num2++;
					}
					num2++;
					if (num2 != 0)
					{
					}
					if (num2 != 0)
					{
						return flag;
					}
				}
				return true;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60058EF")]
		[Cpp2IlInjected.Address(RVA = "0x176B070", Offset = "0x1769A70", VA = "0x18176B070")]
		private static bool ProcessFunction(string function, List<string> args, in Player player, in World world, ITransactionContext context)
		{
			//Discarded unreachable code: IL_00bc
			bool flag = default(bool);
			uint num2 = default(uint);
			while (flag && !flag)
			{
				string[] array = new string[5];
				if ("[COMMAND FAILED] " != null && "[COMMAND FAILED] " == null)
				{
					continue;
				}
				array[0] = "[COMMAND FAILED] ";
				if (function != null && "[COMMAND FAILED] " == null)
				{
					continue;
				}
				array[1] = function;
				if ("(" != null && "(" == null)
				{
					continue;
				}
				array[2] = "(";
				string text = string.Join(",", (IEnumerable<>)args);
				if (text != null && text == null)
				{
					continue;
				}
				array[3] = text;
				if (")\n" == null || ")\n" != null)
				{
					array[4] = ")\n";
					string text2 = string.Concat(array);
					int num = 0;
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					break;
				}
			}
			return flag;
		}

		[Cpp2IlInjected.Token(Token = "0x60058F0")]
		[Cpp2IlInjected.Address(RVA = "0x176CF00", Offset = "0x176B900", VA = "0x18176CF00")]
		static ScriptProcess()
		{
			Regex regex = new Regex("\\s*(?<func>\\w+)\\s*\\(\\s*(\\s*(?<arg>[\\w!]+)\\s*,?)*\\)", RegexOptions.IgnoreCase);
			/*Error: Unexpected end of block*/;
		}
	}
}
