using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000530")]
	public class WeatherSmoothVolume : WeatherInfluencer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002049")]
		[Tooltip("The size of the transition. The transition is inside the volume.")]
		public float transitionRange = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400204A")]
		public WeatherTimeline timeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400204B")]
		private Collider[] colliders;

		[Cpp2IlInjected.Token(Token = "0x60016BD")]
		[Cpp2IlInjected.Address(RVA = "0x839DF0", Offset = "0x8387F0", VA = "0x180839DF0")]
		private void Awake()
		{
			Collider[] array = (colliders = GetComponents<Collider>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016BE")]
		[Cpp2IlInjected.Address(RVA = "0x839E40", Offset = "0x838840", VA = "0x180839E40")]
		public unsafe float GetInfluence(Vector3 p)
		{
			//IL_0070: Expected O, but got I4
			//IL_007e: Expected F4, but got I4
			//IL_00a1: Expected F4, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Collider[] array = colliders;
			if (num < array.Length)
			{
				Collider collider = array[num];
				Collider collider2 = colliders[num];
				Vector3 vector = default(Vector3);
				float z = vector.z;
				int num5 = 0;
				int num6 = 0;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				if ((object)collider2 != null)
				{
					float num7 = z2;
					if (colliders[num].Raycast((Ray)num6, out *(RaycastHit*)num5, 2000f))
					{
						int num8 = 0;
						float num9 = default(float);
						float num10 = Mathf.Max(num4, num9);
						if (num9 >= 1f)
						{
							goto IL_009b;
						}
					}
					Collider[] array2 = colliders;
					num++;
				}
				return 1f;
			}
			goto IL_009b;
			IL_009b:
			float num11 = Mathf.Clamp01(num4);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016BF")]
		[Cpp2IlInjected.Address(RVA = "0x839C90", Offset = "0x838690", VA = "0x180839C90", Slot = "4")]
		public override void AddInfluences(Vector3 position, WeatherInfluences influences)
		{
			//Discarded unreachable code: IL_002c
			//IL_0010: Expected O, but got I4
			WeatherTimeline weatherTimeline = timeline;
			int num = 0;
			if (!(weatherTimeline == (UnityEngine.Object)num))
			{
				float z = position.z;
				WeatherTimeline weatherTimeline2 = timeline;
				float weight = default(float);
				influences.Add(weatherTimeline2, weight);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016C0")]
		[Cpp2IlInjected.Address(RVA = "0x839D50", Offset = "0x838750", VA = "0x180839D50", Slot = "5")]
		public override void AddTimelines(List<WeatherTimeline> timelines)
		{
			//Discarded unreachable code: IL_0022
			//IL_0010: Expected O, but got I4
			WeatherTimeline weatherTimeline = timeline;
			int num = 0;
			if (weatherTimeline != (UnityEngine.Object)num)
			{
				WeatherTimeline item = timeline;
				((List<T>)(object)timelines).Add((T)item);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016C1")]
		[Cpp2IlInjected.Address(RVA = "0x83A300", Offset = "0x838D00", VA = "0x18083A300")]
		public WeatherSmoothVolume()
		{
		}
	}
}
