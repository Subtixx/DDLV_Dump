using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000BE")]
public class Coroutines : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private static Coroutines _;

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x10FEA70", Offset = "0x10FD470", VA = "0x1810FEA70")]
	private void Start()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x10FEAC0", Offset = "0x10FD4C0", VA = "0x1810FEAC0")]
	public static Coroutine Start(IEnumerator coroutine)
	{
		//Discarded unreachable code: IL_0006
		return (Coroutine)typeof(Coroutines).TypeHandle;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x10FEB20", Offset = "0x10FD520", VA = "0x1810FEB20")]
	public static void Stop(Coroutine coroutine)
	{
	}//Discarded unreachable code: IL_0001


	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x10FE600", Offset = "0x10FD000", VA = "0x1810FE600")]
	public static Coroutine Delay(Action action, float delay)
	{
		//Discarded unreachable code: IL_001d
		int _003C_003E1__state = default(int);
		_003CDelaying_003Ed__5 _003CDelaying_003Ed__ = new _003CDelaying_003Ed__5(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CDelaying_003Ed__.action = action;
		_003CDelaying_003Ed__.delay = delay;
		return (Coroutine)typeof(Coroutines).TypeHandle;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x10FE6F0", Offset = "0x10FD0F0", VA = "0x1810FE6F0")]
	[IteratorStateMachine(typeof(_003CDelaying_003Ed__5))]
	private IEnumerator Delaying(Action action, float delay)
	{
		int _003C_003E1__state = default(int);
		_003CDelaying_003Ed__5 _003CDelaying_003Ed__ = new _003CDelaying_003Ed__5(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CDelaying_003Ed__.action = action;
		_003CDelaying_003Ed__.delay = delay;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x10FE870", Offset = "0x10FD270", VA = "0x1810FE870")]
	public static void Do(Action<float> action, float duration)
	{
		//Discarded unreachable code: IL_0018
		int _003C_003E1__state = default(int);
		_003CDoing_003Ed__7 _003CDoing_003Ed__ = new _003CDoing_003Ed__7(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CDoing_003Ed__.action = action;
		_003CDoing_003Ed__.duration = duration;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x10FE9F0", Offset = "0x10FD3F0", VA = "0x1810FE9F0")]
	[IteratorStateMachine(typeof(_003CDoing_003Ed__7))]
	private IEnumerator Doing(Action<float> action, float duration)
	{
		int _003C_003E1__state = default(int);
		_003CDoing_003Ed__7 _003CDoing_003Ed__ = new _003CDoing_003Ed__7(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CDoing_003Ed__.action = action;
		_003CDoing_003Ed__.duration = duration;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x10FE770", Offset = "0x10FD170", VA = "0x1810FE770")]
	public static void DoWhile(Action<float> action, Func<bool> condition)
	{
		//Discarded unreachable code: IL_0018
		int _003C_003E1__state = default(int);
		_003CDoingWhile_003Ed__9 _003CDoingWhile_003Ed__ = new _003CDoingWhile_003Ed__9(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CDoingWhile_003Ed__.action = action;
		_003CDoingWhile_003Ed__.condition = condition;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x10FE960", Offset = "0x10FD360", VA = "0x1810FE960")]
	[IteratorStateMachine(typeof(_003CDoingWhile_003Ed__9))]
	private IEnumerator DoingWhile(Action<float> action, Func<bool> condition)
	{
		int _003C_003E1__state = default(int);
		_003CDoingWhile_003Ed__9 _003CDoingWhile_003Ed__ = new _003CDoingWhile_003Ed__9(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CDoingWhile_003Ed__.action = action;
		_003CDoingWhile_003Ed__.condition = condition;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public Coroutines()
	{
	}
}
