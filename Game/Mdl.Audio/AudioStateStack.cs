using System.Collections.Generic;
using AK.Wwise;
using Cpp2IlInjected;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000B14")]
	public class AudioStateStack
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003DA7")]
		private Stack<State> _stateStack = (Stack<State>)(object)new Stack<T>();

		[Cpp2IlInjected.Token(Token = "0x6003314")]
		[Cpp2IlInjected.Address(RVA = "0x1509700", Offset = "0x1508100", VA = "0x181509700")]
		public void Push(State state, bool skipSetValue = false)
		{
			//Discarded unreachable code: IL_0017
			((Stack<T>)(object)_stateStack).Push((T)state);
			if (!skipSetValue)
			{
				state.SetValue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003315")]
		[Cpp2IlInjected.Address(RVA = "0x1509660", Offset = "0x1508060", VA = "0x181509660")]
		public void Pop()
		{
			//Discarded unreachable code: IL_001d, IL_001e
			State state = (State)((Stack<T>)(object)_stateStack).Pop();
			((State)((Stack<T>)(object)_stateStack).Peek()).SetValue();
		}

		[Cpp2IlInjected.Token(Token = "0x6003316")]
		[Cpp2IlInjected.Address(RVA = "0x1509600", Offset = "0x1508000", VA = "0x181509600")]
		public bool Exists(State state)
		{
			//Discarded unreachable code: IL_000d
			return ((Stack<T>)(object)_stateStack).Contains((T)state);
		}

		[Cpp2IlInjected.Token(Token = "0x6003317")]
		[Cpp2IlInjected.Address(RVA = "0x1509780", Offset = "0x1508180", VA = "0x181509780")]
		public AudioStateStack()
		{
		}
	}
}
