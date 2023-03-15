using Cpp2IlInjected;
using Mdl.Graphic.Weather;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005F0")]
	internal class TimelineWeatherAnchorOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6001A5D")]
		[Cpp2IlInjected.Address(RVA = "0x13D2420", Offset = "0x13D0E20", VA = "0x1813D2420")]
		public void UsePlayerCamera()
		{
			//Discarded unreachable code: IL_001a
			//IL_0019: Expected O, but got I4
			Transform anchor = SystemRoot.Instance._playerCamera.transform;
			int num = 0;
			WeatherController.SetAnchor(anchor, (Vector3)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5E")]
		[Cpp2IlInjected.Address(RVA = "0x13D23D0", Offset = "0x13D0DD0", VA = "0x1813D23D0")]
		public void UseAvatarPosition()
		{
			int num = 0;
			WeatherController.ResetAnchor();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A5F")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineWeatherAnchorOverride()
		{
		}
	}
}
