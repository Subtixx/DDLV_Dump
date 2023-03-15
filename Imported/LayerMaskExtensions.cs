using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LayerMaskExtensions
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2F163F0", Offset = "0x2F14DF0", VA = "0x182F163F0")]
	public static bool Contains(this LayerMask mask, int layer)
	{
		bool result = default(bool);
		return result;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2F16430", Offset = "0x2F14E30", VA = "0x182F16430")]
	public static bool IsInLayerMask(this LayerMask mask, GameObject obj)
	{
		//Discarded unreachable code: IL_0009
		int layer = obj.layer;
		bool result = default(bool);
		return result;
	}
}
