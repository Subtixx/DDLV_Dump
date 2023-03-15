using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Graphic.Weather;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005F2")]
	public class TimelineWeatherOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002420")]
		public bool restoreWeatherAfterCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002421")]
		public List<WeatherValues> overrideWeatherValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002422")]
		private WeatherValues backupValues;

		[Cpp2IlInjected.Token(Token = "0x6001A61")]
		[Cpp2IlInjected.Address(RVA = "0x13D2590", Offset = "0x13D0F90", VA = "0x1813D2590")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00a5
			if (restoreWeatherAfterCutscene)
			{
				WeatherValues weatherValues = (backupValues = new WeatherValues());
				WeatherValues weatherValues2 = backupValues;
				float num = (weatherValues2.Clouds = WeatherController.GetTag("Clouds"));
				WeatherValues weatherValues3 = backupValues;
				float num2 = (weatherValues3.Curse = WeatherController.GetTag("Curse"));
				WeatherValues weatherValues4 = backupValues;
				float num3 = (weatherValues4.Rain = WeatherController.GetTag("Rain"));
				WeatherValues weatherValues5 = backupValues;
				float num4 = (weatherValues5.Wind = WeatherController.GetTag("Wind"));
				WeatherValues weatherValues6 = backupValues;
				float num5 = (weatherValues6.Fog = WeatherController.GetTag("Fog"));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A62")]
		[Cpp2IlInjected.Address(RVA = "0x13D2700", Offset = "0x13D1100", VA = "0x1813D2700")]
		public void OverrideWeather(string overrideId)
		{
			//Discarded unreachable code: IL_0035
			List<WeatherValues> list = overrideWeatherValues;
			Func<WeatherValues, bool> func = (Func<WeatherValues, bool>)(object)(Func<T, TResult>)delegate(WeatherValues x)
			{
				//Discarded unreachable code: IL_0014
				string b = overrideId;
				return string.Equals(x.overrideId, b);
			};
			WeatherValues weatherValues = Enumerable.FirstOrDefault<WeatherValues>((IEnumerable<>)list, (Func<, >)(object)func);
			if (weatherValues != null)
			{
				SetWeather(weatherValues);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A63")]
		[Cpp2IlInjected.Address(RVA = "0x13D2540", Offset = "0x13D0F40", VA = "0x1813D2540")]
		private void OnDisable()
		{
			if (restoreWeatherAfterCutscene)
			{
				WeatherValues weatherValues = backupValues;
				if (weatherValues != null)
				{
					SetWeather(weatherValues);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A64")]
		[Cpp2IlInjected.Address(RVA = "0x13D2800", Offset = "0x13D1200", VA = "0x1813D2800")]
		private void SetWeather(WeatherValues values)
		{
			//Discarded unreachable code: IL_005d
			float clouds = values.Clouds;
			WeatherController.SetTag("Clouds", clouds);
			float curse = values.Curse;
			WeatherController.SetTag("Curse", curse);
			float rain = values.Rain;
			WeatherController.SetTag("Rain", rain);
			float wind = values.Wind;
			WeatherController.SetTag("Wind", wind);
			float fog = values.Fog;
			WeatherController.SetTag("Fog", fog);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A65")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TimelineWeatherOverride()
		{
		}
	}
}
