using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200050A")]
	public abstract class WeatherModifier : ScriptableObject
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FC0")]
		public float weight;

		[Cpp2IlInjected.Token(Token = "0x170002E7")]
		public abstract string menuName
		{
			[Cpp2IlInjected.Token(Token = "0x600166C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600166D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Enable();

		[Cpp2IlInjected.Token(Token = "0x600166E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Disable();

		[Cpp2IlInjected.Token(Token = "0x600166F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BeforeEvaluation(float time, WeatherTimeline mainTimeline, float weight);

		[Cpp2IlInjected.Token(Token = "0x6001670")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void AfterEvaluation(float time, WeatherTimeline mainTimeline, float weight);

		[Cpp2IlInjected.Token(Token = "0x6001671")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		protected WeatherModifier()
		{
		}
	}
}
