using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004E8")]
	public interface IWeatherController
	{
		[Cpp2IlInjected.Token(Token = "0x170002B1")]
		List<(WeatherTimeline, float)> Timelines
		{
			[Cpp2IlInjected.Token(Token = "0x600159A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B2")]
		List<WeatherModifier> Modifiers
		{
			[Cpp2IlInjected.Token(Token = "0x600159B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B3")]
		float WindFrequency
		{
			[Cpp2IlInjected.Token(Token = "0x600159C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B4")]
		Vector3 WindAxis
		{
			[Cpp2IlInjected.Token(Token = "0x600159D")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B5")]
		PostProcess PostProcess
		{
			[Cpp2IlInjected.Token(Token = "0x600159E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B6")]
		Volume Volume
		{
			[Cpp2IlInjected.Token(Token = "0x600159F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B7")]
		float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60015A0")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B8")]
		float updateFrequency
		{
			[Cpp2IlInjected.Token(Token = "0x60015A1")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002B9")]
		MonoBehaviour monoBehaviour
		{
			[Cpp2IlInjected.Token(Token = "0x60015A4")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60015A2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Evaluate();

		[Cpp2IlInjected.Token(Token = "0x60015A3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LoadTimelines();
	}
}
