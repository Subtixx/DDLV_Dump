using System;
using AK.Wwise;
using Cpp2IlInjected;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000B12")]
	public class AudioSpecialEvent
	{
		[Cpp2IlInjected.Token(Token = "0x2000B13")]
		public enum EventMonth
		{
			[Cpp2IlInjected.Token(Token = "0x4003D9B")]
			January = 1,
			[Cpp2IlInjected.Token(Token = "0x4003D9C")]
			February,
			[Cpp2IlInjected.Token(Token = "0x4003D9D")]
			March,
			[Cpp2IlInjected.Token(Token = "0x4003D9E")]
			April,
			[Cpp2IlInjected.Token(Token = "0x4003D9F")]
			May,
			[Cpp2IlInjected.Token(Token = "0x4003DA0")]
			June,
			[Cpp2IlInjected.Token(Token = "0x4003DA1")]
			July,
			[Cpp2IlInjected.Token(Token = "0x4003DA2")]
			August,
			[Cpp2IlInjected.Token(Token = "0x4003DA3")]
			September,
			[Cpp2IlInjected.Token(Token = "0x4003DA4")]
			October,
			[Cpp2IlInjected.Token(Token = "0x4003DA5")]
			November,
			[Cpp2IlInjected.Token(Token = "0x4003DA6")]
			December
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003D95")]
		public EventMonth eventMonthStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003D96")]
		public int eventDayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003D97")]
		public EventMonth eventMonthEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4003D98")]
		public int eventDayEnd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003D99")]
		public State audioState;

		[Cpp2IlInjected.Token(Token = "0x6003312")]
		[Cpp2IlInjected.Address(RVA = "0x15095E0", Offset = "0x1507FE0", VA = "0x1815095E0")]
		public void Play()
		{
			audioState?.SetValue();
		}

		[Cpp2IlInjected.Token(Token = "0x6003313")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AudioSpecialEvent()
		{
		}
	}
}
