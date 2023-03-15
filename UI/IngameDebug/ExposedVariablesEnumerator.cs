using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class ExposedVariablesEnumerator : IEnumerator<MemberInfo>, IEnumerator, IDisposable, IEnumerable<MemberInfo>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private readonly MemberInfo[] variables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private readonly List<VariableSet> hiddenVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private readonly List<VariableSet> exposedVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private readonly RuntimeInspector.VariableVisibility fieldVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private readonly RuntimeInspector.VariableVisibility propertyVisibility;

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public MemberInfo Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x15214A0", Offset = "0x151FEA0", VA = "0x1815214A0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_0016
				MemberInfo[] array = variables;
				int num = index;
				return array[num];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x15214A0", Offset = "0x151FEA0", VA = "0x1815214A0", Slot = "7")]
			get
			{
				MemberInfo[] array = variables;
				int num = index;
				MemberInfo memberInfo = array[num];
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x15214E0", Offset = "0x151FEE0", VA = "0x1815214E0")]
		public ExposedVariablesEnumerator(MemberInfo[] variables, List<VariableSet> hiddenVariables, List<VariableSet> exposedVariables, RuntimeInspector.VariableVisibility fieldVisibility, RuntimeInspector.VariableVisibility propertyVisibility)
		{
			Dispose();
			this.variables = variables;
			this.hiddenVariables = hiddenVariables;
			this.exposedVariables = exposedVariables;
			this.fieldVisibility = RuntimeInspector.VariableVisibility.None;
			this.propertyVisibility = RuntimeInspector.VariableVisibility.None;
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public void Dispose()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0", Slot = "9")]
		public IEnumerator<MemberInfo> GetEnumerator()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x15210F0", Offset = "0x151FAF0", VA = "0x1815210F0", Slot = "6")]
		public bool MoveNext()
		{
			while ((long)variables != 0)
			{
				int num = index;
				MemberInfo[] array = variables;
				int num2 = (index = num + 1);
				int length = array.Length;
				if (num2 >= length)
				{
					break;
				}
				num++;
				MemberInfo variable = array[num];
				if (ShouldExposeVariable(variable))
				{
					return true;
				}
			}
			int num3 = 0;
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1521160", Offset = "0x151FB60", VA = "0x181521160", Slot = "8")]
		public void Reset()
		{
			//IL_0010: Expected I4, but got I8
			index = -1;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1521170", Offset = "0x151FB70", VA = "0x181521170")]
		private bool ShouldExposeVariable(MemberInfo variable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
