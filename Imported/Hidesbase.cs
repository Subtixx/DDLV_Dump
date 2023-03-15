using System;
using System.Collections.Generic;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200002F")]
public class Hidesbase : ResponsivePropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public IDictionary<object, bool> hideList;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2F11D30", Offset = "0x2F10730", VA = "0x182F11D30")]
	public void hide(object prop, bool hided)
	{
		if (hideList == null)
		{
			Dictionary<object, bool> dictionary = (Dictionary<object, bool>)(hideList = (IDictionary<object, bool>)new Dictionary<TKey, TValue>());
			IDictionary<object, bool> dictionary2 = hideList;
		}
		IDictionary<object, bool> dictionary3 = hideList;
		if ((object)typeof(IDictionary<object, bool>).TypeHandle == null)
		{
			return;
		}
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2F11CA0", Offset = "0x2F106A0", VA = "0x182F11CA0")]
	public bool CheckHided(object parent)
	{
		if (parent != null && hideList != null && (object)typeof(IDictionary<object, bool>).TypeHandle != null)
		{
			IDictionary<object, bool> dictionary = hideList;
		}
		int num = 0;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x29267B0", Offset = "0x29251B0", VA = "0x1829267B0")]
	public Hidesbase()
	{
	}
}
