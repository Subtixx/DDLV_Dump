using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AB6")]
	public class DisposableList : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002AD5")]
		private Stack<Action> disposeActions = (Stack<Action>)(object)new Stack<T>();

		[Cpp2IlInjected.Token(Token = "0x6005D06")]
		[Cpp2IlInjected.Address(RVA = "0x1739A90", Offset = "0x1738490", VA = "0x181739A90")]
		public void Add(Action a)
		{
			//Discarded unreachable code: IL_000d
			((Stack<T>)(object)disposeActions).Push((T)a);
		}

		[Cpp2IlInjected.Token(Token = "0x6005D07")]
		[Cpp2IlInjected.Address(RVA = "0x164FDC0", Offset = "0x164E7C0", VA = "0x18164FDC0")]
		public static void DisposeObject<T>(ref T obj) where T : class, IDisposable
		{
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D08")]
		[Cpp2IlInjected.Address(RVA = "0x1739AF0", Offset = "0x17384F0", VA = "0x181739AF0", Slot = "4")]
		public void Dispose()
		{
			//IL_0020: Expected O, but got I8
			((Stack<T>)(object)disposeActions).Pop()();
			Stack<Action> stack = disposeActions;
			disposeActions = (Stack<Action>)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005D09")]
		[Cpp2IlInjected.Address(RVA = "0x1739B90", Offset = "0x1738590", VA = "0x181739B90")]
		public DisposableList()
		{
		}
	}
}
