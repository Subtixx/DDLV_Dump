using System;
using Cpp2IlInjected;
using Definitions.Scene;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AudioSurfaceAreas : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public VillageAreaType villageAreType;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1509C80", Offset = "0x1508680", VA = "0x181509C80")]
	private void Start()
	{
		DisableAudioRaycast();
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1509800", Offset = "0x1508200", VA = "0x181509800")]
	public void DisableAudioRaycast()
	{
		//Discarded unreachable code: IL_004a, IL_0050, IL_0062
		int num = 0;
		int layer = LayerMask.NameToLayer("Ignore Raycast");
		GameObject gameObject = default(GameObject);
		if (base.transform.GetEnumerator() != null)
		{
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			num += 328;
			int num3 = 0;
			if (num == 0)
			{
				throw new InvalidCastException();
			}
			int num4 = 0;
			if (num == 0)
			{
				throw new InvalidCastException();
			}
			gameObject.layer = layer;
		}
		if ((object)gameObject == null)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1509A40", Offset = "0x1508440", VA = "0x181509A40")]
	public void EnableAudioRaycast()
	{
		//Discarded unreachable code: IL_004a, IL_0050, IL_0062
		int num = 0;
		int layer = LayerMask.NameToLayer("Audio");
		GameObject gameObject = default(GameObject);
		if (base.transform.GetEnumerator() != null)
		{
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			num += 328;
			int num3 = 0;
			if (num == 0)
			{
				throw new InvalidCastException();
			}
			int num4 = 0;
			if (num == 0)
			{
				throw new InvalidCastException();
			}
			gameObject.layer = layer;
		}
		if ((object)gameObject == null)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AudioSurfaceAreas()
	{
	}
}
