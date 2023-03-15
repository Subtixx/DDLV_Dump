using System;
using Cpp2IlInjected;
using Mdl.Systems;
using Meta.Online;
using Meta.Util;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20004D9")]
	[CreateAssetMenu]
	public class Particles_Modifier : WeatherModifier
	{
		[Cpp2IlInjected.Token(Token = "0x20004DA")]
		private class SystemInfos
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001E6E")]
			public float emission;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4001E6F")]
			public float simulationSpeed;

			[Cpp2IlInjected.Token(Token = "0x6001567")]
			[Cpp2IlInjected.Address(RVA = "0x1205500", Offset = "0x1203F00", VA = "0x181205500")]
			public void Add(float emission, float simulationSpeed)
			{
				this.emission = emission;
				this.simulationSpeed = simulationSpeed;
			}

			[Cpp2IlInjected.Token(Token = "0x6001568")]
			[Cpp2IlInjected.Address(RVA = "0x1205520", Offset = "0x1203F20", VA = "0x181205520")]
			public void Reset()
			{
				//IL_0009: Expected F4, but got I4
				int num = 0;
				emission = num;
			}

			[Cpp2IlInjected.Token(Token = "0x6001569")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SystemInfos()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20004DB")]
		public enum EmissionMode
		{
			[Cpp2IlInjected.Token(Token = "0x4001E71")]
			Constant,
			[Cpp2IlInjected.Token(Token = "0x4001E72")]
			Hours,
			[Cpp2IlInjected.Token(Token = "0x4001E73")]
			Curve
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E63")]
		public string particleSystemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E64")]
		[ReadOnly]
		public bool systemFound;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001E65")]
		public float simulationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E66")]
		[Range(0f, 1f)]
		public float weightThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001E67")]
		[Range(0f, 1f)]
		public float emission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001E68")]
		public EmissionMode emissionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4001E69")]
		[TimeField]
		[HideInInspector]
		public float emissionStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001E6A")]
		[TimeField]
		[HideInInspector]
		public float emissionEndTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001E6B")]
		[HideInInspector]
		public AnimationCurve emissionCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001E6C")]
		public bool useDisableFlashesSetting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001E6D")]
		private WeatherParticles system;

		[Cpp2IlInjected.Token(Token = "0x170002AA")]
		public override string menuName
		{
			[Cpp2IlInjected.Token(Token = "0x6001561")]
			[Cpp2IlInjected.Address(RVA = "0xF0C1A0", Offset = "0xF0ABA0", VA = "0x180F0C1A0", Slot = "4")]
			get
			{
				string text = base.name;
				return "Particles/" + text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001562")]
		[Cpp2IlInjected.Address(RVA = "0xF0C130", Offset = "0xF0AB30", VA = "0x180F0C130", Slot = "5")]
		public override void Enable()
		{
			WeatherParticles weatherParticles = (system = WeatherParticles.Get(particleSystemName));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001563")]
		[Cpp2IlInjected.Address(RVA = "0xF0C100", Offset = "0xF0AB00", VA = "0x180F0C100", Slot = "6")]
		public override void Disable()
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected F4, but got I4
			WeatherParticles weatherParticles = system;
			float _003CsimulationSpeed_003Ek__BackingField = weatherParticles.simulationSpeed;
			int num = 0;
			weatherParticles.Set(num, _003CsimulationSpeed_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x6001564")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE80", Offset = "0xF0A880", VA = "0x180F0BE80", Slot = "7")]
		public override void BeforeEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			//Discarded unreachable code: IL_00d2
			//IL_003e: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			//IL_00d1: Expected F4, but got I4
			if (!useDisableFlashesSetting || ((GameSettingsData)((BaseStorage<DataType>)(object)SystemRoot.Instance.MetaClient.GameSettings).Data).disableFlashes_)
			{
			}
			if (!(weightThreshold <= weight))
			{
			}
			WeatherParticles weatherParticles = system;
			int num = 0;
			if (weatherParticles == (UnityEngine.Object)num)
			{
				WeatherParticles weatherParticles2 = (system = WeatherParticles.Get(particleSystemName));
			}
			WeatherParticles weatherParticles3 = system;
			int num2 = 0;
			if (weatherParticles3 == (UnityEngine.Object)num2)
			{
				return;
			}
			EmissionMode emissionMode = this.emissionMode;
			int num6 = default(int);
			if (emissionMode != 0)
			{
				if (emissionMode != 0)
				{
					if (emissionMode != EmissionMode.Hours)
					{
						goto IL_00b6;
					}
					float num3 = emissionCurve.Evaluate(time);
				}
				float num4 = emissionStartTime;
				float num5 = emissionEndTime;
				if ((!(num4 > num5) && num4 > time) || (!(time <= num5) && !(num4 <= time)))
				{
					num6 = 0;
				}
			}
			goto IL_00b6;
			IL_00b6:
			WeatherParticles weatherParticles4 = system;
			float num7 = simulationSpeed;
			weatherParticles4.Set(num6, num7);
		}

		[Cpp2IlInjected.Token(Token = "0x6001565")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public override void AfterEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001566")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public Particles_Modifier()
		{
		}
	}
}
