using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000533")]
	[RequireComponent(typeof(BoxCollider))]
	public class WeatherTransitionVolume : WeatherInfluencer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002051")]
		public WeatherTimeline botTimeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002052")]
		public WeatherTimeline topTimeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002053")]
		[SerializeField]
		private BoxCollider box;

		[Cpp2IlInjected.Token(Token = "0x60016C6")]
		[Cpp2IlInjected.Address(RVA = "0x8401C0", Offset = "0x83EBC0", VA = "0x1808401C0")]
		private void OnValidate()
		{
			BoxCollider boxCollider = (box = GetComponent<BoxCollider>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016C7")]
		[Cpp2IlInjected.Address(RVA = "0x83FEF0", Offset = "0x83E8F0", VA = "0x18083FEF0", Slot = "4")]
		public override void AddInfluences(Vector3 position, WeatherInfluences influences)
		{
			//Discarded unreachable code: IL_0064
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			WeatherTimeline weatherTimeline = topTimeline;
			int num = 0;
			if (!(weatherTimeline == (Object)num))
			{
				WeatherTimeline weatherTimeline2 = botTimeline;
				int num2 = 0;
				if (!(weatherTimeline2 == (Object)num2))
				{
					Transform transform = base.transform;
					float z = position.z;
					BoxCollider boxCollider = box;
					BoxCollider boxCollider2 = box;
					BoxCollider boxCollider3 = box;
					WeatherTimeline timeline = botTimeline;
					influences.Add(timeline, 1f);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016C8")]
		[Cpp2IlInjected.Address(RVA = "0x8400D0", Offset = "0x83EAD0", VA = "0x1808400D0", Slot = "5")]
		public override void AddTimelines(List<WeatherTimeline> timelines)
		{
			//Discarded unreachable code: IL_0047
			//IL_0010: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			WeatherTimeline weatherTimeline = botTimeline;
			int num = 0;
			if (weatherTimeline != (Object)num)
			{
				WeatherTimeline item = botTimeline;
				((List<T>)(object)timelines).Add((T)item);
			}
			WeatherTimeline weatherTimeline2 = topTimeline;
			int num2 = 0;
			if (weatherTimeline2 != (Object)num2)
			{
				WeatherTimeline item2 = topTimeline;
				((List<T>)(object)timelines).Add((T)item2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016C9")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WeatherTransitionVolume()
		{
		}
	}
}
