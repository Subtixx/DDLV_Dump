using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000537")]
	public class WeatherVolumeTimeTransition : WeatherInfluencer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400205F")]
		public WeatherTimeline timeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002060")]
		private WeatherTimeline newTimeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002061")]
		private float curTransitionTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002062")]
		private float totalTransitionDuration;

		[Cpp2IlInjected.Token(Token = "0x60016DA")]
		[Cpp2IlInjected.Address(RVA = "0x840260", Offset = "0x83EC60", VA = "0x180840260", Slot = "4")]
		public override void AddInfluences(Vector3 position, WeatherInfluences influences)
		{
			//IL_0010: Expected O, but got I4
			//IL_006f: Expected O, but got I8
			WeatherTimeline weatherTimeline = newTimeline;
			int num = 0;
			if (weatherTimeline != (UnityEngine.Object)num)
			{
				int num2 = 0;
				float deltaTime = Time.deltaTime;
				float num3 = totalTransitionDuration;
				curTransitionTime = deltaTime;
				if (!(deltaTime >= num3))
				{
					WeatherTimeline weatherTimeline2 = timeline;
					influences.Add(weatherTimeline2, 1f);
					WeatherTimeline weatherTimeline3 = newTimeline;
					influences.Add(weatherTimeline3, deltaTime);
					return;
				}
				WeatherTimeline weatherTimeline4 = (timeline = newTimeline);
				newTimeline = (WeatherTimeline)0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60016DB")]
		[Cpp2IlInjected.Address(RVA = "0x840390", Offset = "0x83ED90", VA = "0x180840390", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x60016DC")]
		[Cpp2IlInjected.Address(RVA = "0x840430", Offset = "0x83EE30", VA = "0x180840430")]
		public void TransitionToNewWeatherTimeline(WeatherTimeline newWT, float transitionDuration)
		{
			newTimeline = newWT;
			totalTransitionDuration = transitionDuration;
			curTransitionTime = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x60016DD")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WeatherVolumeTimeTransition()
		{
		}
	}
}
