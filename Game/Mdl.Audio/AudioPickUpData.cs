using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000B0C")]
	public class AudioPickUpData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D71")]
		public Switch pickupSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003D72")]
		public AK.Wwise.Event pickupEvent;

		[Cpp2IlInjected.Token(Token = "0x60032F2")]
		[Cpp2IlInjected.Address(RVA = "0x1505750", Offset = "0x1504150", VA = "0x181505750")]
		public void PlayPickupAudio(GameObject audioEmitter)
		{
			//Discarded unreachable code: IL_0026
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(audioEmitter == (Object)num))
			{
				pickupSwitch.SetValue(audioEmitter);
				uint num2 = pickupEvent.Post(audioEmitter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60032F3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AudioPickUpData()
		{
		}
	}
}
