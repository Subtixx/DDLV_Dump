using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000AE9")]
	public class AudioChestOpen : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C86")]
		public AK.Wwise.Event openChestEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003C87")]
		public AK.Wwise.Event openChestFailEvent;

		[Cpp2IlInjected.Token(Token = "0x6003227")]
		[Cpp2IlInjected.Address(RVA = "0xA4C980", Offset = "0xA4B380", VA = "0x180A4C980")]
		public void PlayAudio(GameObject audioEmitter)
		{
			//Discarded unreachable code: IL_000e
			uint num = openChestEvent.Post(audioEmitter);
		}

		[Cpp2IlInjected.Token(Token = "0x6003228")]
		[Cpp2IlInjected.Address(RVA = "0xA4C900", Offset = "0xA4B300", VA = "0x180A4C900")]
		public void ChestOpenFail(GameObject audioEmitter)
		{
			//Discarded unreachable code: IL_001a
			//IL_0009: Expected O, but got I4
			int num = 0;
			if (!(audioEmitter == (Object)num))
			{
				uint num2 = openChestFailEvent.Post(audioEmitter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003229")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AudioChestOpen()
		{
		}
	}
}
