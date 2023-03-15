using System;
using Cpp2IlInjected;
using Unity.Mathematics;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200052D")]
	public class WeatherKey3 : IKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002044")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002045")]
		[TimeField]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002046")]
		[TimeField]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002047")]
		public float4[] values;

		[Cpp2IlInjected.Token(Token = "0x170002F0")]
		public float endTime
		{
			[Cpp2IlInjected.Token(Token = "0x60016B1")]
			[Cpp2IlInjected.Address(RVA = "0x837A00", Offset = "0x836400", VA = "0x180837A00")]
			get
			{
				return duration;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F1")]
		float IKey.time
		{
			[Cpp2IlInjected.Token(Token = "0x60016B2")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330", Slot = "4")]
			get
			{
				return time;
			}
			[Cpp2IlInjected.Token(Token = "0x60016B3")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350", Slot = "5")]
			set
			{
				time = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F2")]
		float IKey.duration
		{
			[Cpp2IlInjected.Token(Token = "0x60016B4")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320", Slot = "6")]
			get
			{
				return duration;
			}
			[Cpp2IlInjected.Token(Token = "0x60016B5")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340", Slot = "7")]
			set
			{
				duration = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016B6")]
		[Cpp2IlInjected.Address(RVA = "0x837970", Offset = "0x836370", VA = "0x180837970")]
		public WeatherKey3()
		{
			int num = 0;
			float4[] array = (values = new float4[WeatherData.Count]);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60016B7")]
		[Cpp2IlInjected.Address(RVA = "0x837450", Offset = "0x835E50", VA = "0x180837450", Slot = "3")]
		public override string ToString()
		{
			//Discarded unreachable code: IL_0183
			string[] array2;
			while (true)
			{
				if (!string.IsNullOrEmpty(name))
				{
					string[] array = new string[6];
					string text = name;
					if (text != null && array == null)
					{
						continue;
					}
					array[0] = text;
					if (" (" != null && " (" == null)
					{
						continue;
					}
					array[1] = " (";
					float normalizedTime = time;
					string text2 = NormalizeTimeToHours(normalizedTime);
					if (text2 != null && text2 == null)
					{
						continue;
					}
					array[2] = text2;
					if (" - " != null && " - " == null)
					{
						continue;
					}
					array[3] = " - ";
					float normalizedTime2 = duration;
					string text3 = NormalizeTimeToHours(normalizedTime2);
					if (text3 != null && text3 == null)
					{
						continue;
					}
					array[4] = text3;
					if (")" != null && ")" == null)
					{
						continue;
					}
				}
				array2 = new string[5];
				if ("Key (" != null && "Key (" == null)
				{
					continue;
				}
				array2[0] = "Key (";
				float normalizedTime3 = time;
				string text4 = NormalizeTimeToHours(normalizedTime3);
				if (text4 != null && text4 == null)
				{
					continue;
				}
				array2[1] = text4;
				if (" - " != null && " - " == null)
				{
					continue;
				}
				array2[2] = " - ";
				float normalizedTime4 = duration;
				string text5 = NormalizeTimeToHours(normalizedTime4);
				if (text5 == null || text5 != null)
				{
					array2[3] = text5;
					if (")" == null || ")" != null)
					{
						break;
					}
				}
			}
			array2[4] = ")";
			return string.Concat(array2);
		}

		[Cpp2IlInjected.Token(Token = "0x60016B8")]
		[Cpp2IlInjected.Address(RVA = "0x837360", Offset = "0x835D60", VA = "0x180837360")]
		public string NormalizeTimeToHours(float normalizedTime)
		{
			//IL_0022: Expected I4, but got I8
			//IL_0029: Expected I8, but got I4
			//IL_002e: Expected I4, but got I8
			int num = Mathf.RoundToInt(normalizedTime * 24f * 60f);
			float f = default(float);
			int num2 = Mathf.FloorToInt(f);
			ulong num3 = num3 + num3;
			num2 = (int)((long)num2 - (long)num3);
			long num4 = num2 * 60;
			num = (int)(num - num4);
			string result = default(string);
			return result;
		}
	}
}
