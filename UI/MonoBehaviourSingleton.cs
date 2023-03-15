using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000070")]
public class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private static T instance;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public static T Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x28B2570", Offset = "0x28B0F70", VA = "0x1828B2570")]
		get
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x28B2420", Offset = "0x28B0E20", VA = "0x1828B2420", Slot = "4")]
	protected virtual void Awake()
	{
		T val = MonoBehaviourSingleton<>.instance;
		bool flag = default(bool);
		if (!flag)
		{
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		MonoBehaviourSingleton<>.instance = (T)((Component)this).GetComponent<T>();
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x28B2550", Offset = "0x28B0F50", VA = "0x1828B2550")]
	public MonoBehaviourSingleton()
	{
	}//Discarded unreachable code: IL_0007

}
