using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Graphic.Lighting
{
	[Cpp2IlInjected.Token(Token = "0x2000538")]
	public class SceneLightsManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4002063")]
		public static readonly Item LightToggleCondition = (Item)Convert.ToInt64(2130000672u);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002064")]
		private int? _numberOfLights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002065")]
		private readonly List<LightToggle> lights = (List<LightToggle>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170002F5")]
		private int numberOfLights
		{
			[Cpp2IlInjected.Token(Token = "0x60016DE")]
			[Cpp2IlInjected.Address(RVA = "0xCC9EC0", Offset = "0xCC88C0", VA = "0x180CC9EC0")]
			get
			{
				//Discarded unreachable code: IL_0010, IL_0013
				//IL_000d: Expected O, but got I8
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				ulong num4 = default(ulong);
				_numberOfLights = (int?)(object)num4;
				int result = default(int);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60016DF")]
		[Cpp2IlInjected.Address(RVA = "0xCC9A30", Offset = "0xCC8430", VA = "0x180CC9A30")]
		internal void NotifyLightChanged(LightToggle lightToggle, bool on)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60016E0")]
		[Cpp2IlInjected.Address(RVA = "0xCC9E40", Offset = "0xCC8840", VA = "0x180CC9E40")]
		public SceneLightsManager()
		{
		}
	}
}
