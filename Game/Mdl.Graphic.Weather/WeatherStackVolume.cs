using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000531")]
	[RequireComponent(typeof(BoxCollider))]
	public class WeatherStackVolume : WeatherInfluencer
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000532")]
		public struct Slice
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400204F")]
			public float height;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4002050")]
			public WeatherTimeline timeline;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400204C")]
		public List<Slice> slices = (List<Slice>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400204D")]
		public float sliceThickness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400204E")]
		private BoxCollider _box;

		[Cpp2IlInjected.Token(Token = "0x170002F3")]
		private BoxCollider box
		{
			[Cpp2IlInjected.Token(Token = "0x60016C2")]
			[Cpp2IlInjected.Address(RVA = "0x83AE20", Offset = "0x839820", VA = "0x18083AE20")]
			get
			{
				//IL_0010: Expected O, but got I4
				BoxCollider boxCollider = _box;
				int num = 0;
				if (boxCollider == (UnityEngine.Object)num)
				{
					BoxCollider boxCollider2 = (_box = GetComponent<BoxCollider>());
				}
				return _box;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016C3")]
		[Cpp2IlInjected.Address(RVA = "0x83A810", Offset = "0x839210", VA = "0x18083A810", Slot = "4")]
		public override void AddInfluences(Vector3 position, WeatherInfluences influences)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016C4")]
		[Cpp2IlInjected.Address(RVA = "0x83AC50", Offset = "0x839650", VA = "0x18083AC50", Slot = "5")]
		public override void AddTimelines(List<WeatherTimeline> timelines)
		{
			//Discarded unreachable code: IL_0031
			List<Slice> list = slices;
			int num = 0;
			int num2 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			bool flag = default(bool);
			if (flag)
			{
				List<Slice> list2 = slices;
				int num3 = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			List<Slice> list3 = slices;
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x60016C5")]
		[Cpp2IlInjected.Address(RVA = "0x83ADA0", Offset = "0x8397A0", VA = "0x18083ADA0")]
		public WeatherStackVolume()
		{
		}
	}
}
