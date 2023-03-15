using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public class VariableSet
	{
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private const string INCLUDE_ALL_VARIABLES = "*";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		[SerializeField]
		private string m_type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		[SerializeField]
		private string[] m_variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public HashSet<string> variables;

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xCAC3E0", Offset = "0xCAADE0", VA = "0x180CAC3E0")]
		public bool Init()
		{
			//IL_0023: Expected O, but got I4
			Type type = (this.type = RuntimeInspectorUtils.GetType(m_type));
			Type type2 = this.type;
			int num = 0;
			if (!((object)type2).Equals((object)num))
			{
				HashSet<string> hashSet = (variables = (HashSet<string>)(object)new HashSet<T>());
				string[] array = m_variables;
				int num2 = 0;
				if (num2 < array.Length)
				{
					string text = default(string);
					if (text != "*")
					{
						string[] array2 = m_variables;
						string item = default(string);
						bool flag = ((HashSet<T>)(object)variables).Add((T)item);
						string[] array3 = m_variables;
						num2++;
					}
					AddAllVariablesToSet();
				}
				return true;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xCAC2F0", Offset = "0xCAACF0", VA = "0x180CAC2F0")]
		private void AddAllVariablesToSet()
		{
			//Discarded unreachable code: IL_0041
			MemberInfo[] allVariables = type.GetAllVariables();
			if (allVariables != null)
			{
				int num = 0;
				int length = allVariables.Length;
				if (num < length)
				{
					HashSet<string> hashSet = variables;
					string name = allVariables[num].Name;
					bool flag = ((HashSet<T>)(object)hashSet).Add((T)name);
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public VariableSet()
		{
		}
	}
}
