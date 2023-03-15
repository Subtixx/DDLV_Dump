using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004F4")]
	public abstract class WeatherInfluencer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60015E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void AddInfluences(Vector3 position, WeatherInfluences influences);

		[Cpp2IlInjected.Token(Token = "0x60015E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AddTimelines(List<WeatherTimeline> timelines);

		[Cpp2IlInjected.Token(Token = "0x60015EA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected WeatherInfluencer()
		{
		}
	}
}
