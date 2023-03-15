using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Graphic.Weather;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005F5")]
	public class TimelineWeatherTimelineOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002426")]
		public List<WeatherTimelineOverride> timelineOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002427")]
		private bool needsCleanup;

		[Cpp2IlInjected.Token(Token = "0x6001A69")]
		[Cpp2IlInjected.Address(RVA = "0x13D2970", Offset = "0x13D1370", VA = "0x1813D2970")]
		public void OverrideWeather(string overrideId)
		{
			//Discarded unreachable code: IL_0044
			List<WeatherTimelineOverride> list = timelineOverrides;
			if (list != null)
			{
				Func<WeatherTimelineOverride, bool> func = (Func<WeatherTimelineOverride, bool>)(object)(Func<T, TResult>)delegate(WeatherTimelineOverride x)
				{
					//Discarded unreachable code: IL_0014
					string b = overrideId;
					return string.Equals(x.overrideId, b);
				};
				WeatherTimelineOverride weatherTimelineOverride = Enumerable.FirstOrDefault<WeatherTimelineOverride>((IEnumerable<>)list, (Func<, >)(object)func);
				if (weatherTimelineOverride != null)
				{
					WeatherController.SetTimelinesOverride(weatherTimelineOverride.timelineOverride);
					needsCleanup = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A6A")]
		[Cpp2IlInjected.Address(RVA = "0x13D2910", Offset = "0x13D1310", VA = "0x1813D2910")]
		private void OnDisable()
		{
			if (needsCleanup)
			{
				int num = 0;
				WeatherController.DisableTimelineOverride();
				needsCleanup = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A6B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineWeatherTimelineOverride()
		{
		}
	}
}
