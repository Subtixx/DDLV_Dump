using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20005F1")]
	public class WeatherValues
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400241A")]
		public string overrideId = "weatherOverride";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400241B")]
		[Range(0f, 1f)]
		public float Clouds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400241C")]
		[Range(0f, 1f)]
		public float Rain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400241D")]
		[Range(0f, 1f)]
		public float Fog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400241E")]
		[Range(0f, 1f)]
		public float Wind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400241F")]
		[Range(0f, 1f)]
		public float Curse;

		[Cpp2IlInjected.Token(Token = "0x6001A60")]
		[Cpp2IlInjected.Address(RVA = "0x840210", Offset = "0x83EC10", VA = "0x180840210")]
		public WeatherValues()
		{
		}
	}
}
