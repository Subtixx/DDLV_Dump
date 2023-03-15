using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Timeline;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x2000603")]
	public class TimelineVideoWithPlatformPlayableBehaviour : VideoPlayableBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6001A97")]
		[Cpp2IlInjected.Address(RVA = "0x13D1F30", Offset = "0x13D0930", VA = "0x1813D1F30", Slot = "22")]
		public override void PlayVideo()
		{
			//Discarded unreachable code: IL_001b
			base.PlayVideo();
			Camera playerCamera = SystemRoot.Instance._playerCamera;
			int num = ((playerCamera.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A98")]
		[Cpp2IlInjected.Address(RVA = "0x13D2000", Offset = "0x13D0A00", VA = "0x1813D2000", Slot = "23")]
		public override void StopVideo()
		{
			//Discarded unreachable code: IL_0017
			SystemRoot.Instance._playerCamera.enabled = true;
			base.StopVideo();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A99")]
		[Cpp2IlInjected.Address(RVA = "0x13D20D0", Offset = "0x13D0AD0", VA = "0x1813D20D0")]
		public TimelineVideoWithPlatformPlayableBehaviour()
		{
		}
	}
}
