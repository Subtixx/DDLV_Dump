using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.VFX;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x200050B")]
	public class WeatherParticles : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FC3")]
		private ParticleSystem[] particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001FC4")]
		private VisualEffect[] vfxGraphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001FC5")]
		private ParticleSystem.EmissionModule[] emissionModules;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001FC6")]
		private ParticleSystem.MainModule[] mainModules;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001FC7")]
		private float[] ratios;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001FC8")]
		private bool initialized;

		[Cpp2IlInjected.Token(Token = "0x4001FC9")]
		private static Dictionary<string, WeatherParticles> instances = (Dictionary<string, WeatherParticles>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x170002E8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4001FC1")]
		public float emission
		{
			[Cpp2IlInjected.Token(Token = "0x6001672")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001673")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4001FC2")]
		public float simulationSpeed
		{
			[Cpp2IlInjected.Token(Token = "0x6001674")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001675")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001676")]
		[Cpp2IlInjected.Address(RVA = "0x838270", Offset = "0x836C70", VA = "0x180838270")]
		public unsafe static WeatherParticles Get(string name)
		{
			int num = 0;
			bool flag = ((Dictionary<TKey, TValue>)(object)instances).TryGetValue((TKey)name, out *(TValue*)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001677")]
		[Cpp2IlInjected.Address(RVA = "0x837EB0", Offset = "0x8368B0", VA = "0x180837EB0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0157
			//IL_0156: Expected F4, but got I4
			int num = 0;
			ParticleSystem[] array = (particles = GetComponentsInChildren<ParticleSystem>());
			VisualEffect[] array2 = (vfxGraphs = GetComponentsInChildren<VisualEffect>());
			ParticleSystem.EmissionModule[] array3 = (emissionModules = new ParticleSystem.EmissionModule[particles.Length]);
			ParticleSystem.MainModule[] array4 = (mainModules = new ParticleSystem.MainModule[particles.Length]);
			float[] array5 = (ratios = new float[particles.Length]);
			ParticleSystem[] array6 = particles;
			int num2 = 0;
			if (num2 < array6.Length)
			{
				ParticleSystem.EmissionModule[] array7 = emissionModules;
				ParticleSystem.MainModule mainModule = (ParticleSystem.MainModule)(array7[0] = (ParticleSystem.EmissionModule)array6[num2].main);
				ParticleSystem.EmissionModule[] array8 = emissionModules;
				float[] array9 = ratios;
				ParticleSystem.MinMaxCurve minMaxCurve = default(ParticleSystem.MinMaxCurve);
				AnimationCurve curveMax = minMaxCurve.m_CurveMax;
				ParticleSystem[] array10 = particles;
				ParticleSystem.MainModule[] array11 = mainModules;
				ParticleSystem.MainModule mainModule2 = (array11[0] = array10[num2].main);
				ParticleSystem particleSystem = particles[num2];
				int stopBehavior = 0;
				particleSystem.Stop(withChildren: true, (ParticleSystemStopBehavior)stopBehavior);
				ParticleSystem[] array12 = particles;
				num2++;
			}
			VisualEffect[] array13 = vfxGraphs;
			int length = array13.Length;
			if (num2 < length)
			{
				VisualEffect visualEffect = array13[num2];
				int num3 = ((visualEffect.enabled = false) ? 1 : 0);
				num2++;
			}
			int num4 = 0;
			Set(num4, 1f);
		}

		[Cpp2IlInjected.Token(Token = "0x6001678")]
		[Cpp2IlInjected.Address(RVA = "0x838320", Offset = "0x836D20", VA = "0x180838320")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0016
			Dictionary<string, WeatherParticles> dictionary = instances;
			string key = base.name;
			((Dictionary<TKey, TValue>)(object)dictionary)[(TKey)key] = (TValue)this;
		}

		[Cpp2IlInjected.Token(Token = "0x6001679")]
		[Cpp2IlInjected.Address(RVA = "0x8383C0", Offset = "0x836DC0", VA = "0x1808383C0")]
		public unsafe void Set(float emission, float simulationSpeed)
		{
			//Discarded unreachable code: IL_01ca
			//IL_00c2: Invalid comparison between F4 and I4
			//IL_0156: Expected I4, but got I8
			float num = this.emission;
			int num2 = 0;
			VisualEffect visualEffect3 = default(VisualEffect);
			if ((initialized ? 1 : 0) == num2)
			{
				ParticleSystem.EmissionModule[] array = emissionModules;
				this.emission = emission;
				if (num2 < array.Length)
				{
					float[] array2 = ratios;
					AnimationCurve curveMax = ((ParticleSystem.MinMaxCurve)num).m_CurveMax;
					ParticleSystem.EmissionModule[] array3 = emissionModules;
					num2++;
				}
				float globalFloat = Shader.GetGlobalFloat("_Wind_Force");
				VisualEffect[] array4 = vfxGraphs;
				int length = array4.Length;
				if (num2 < length)
				{
					VisualEffect visualEffect = array4[num2];
					if (visualEffect.HasFloat("SpawnRateMultiplier"))
					{
						visualEffect.SetFloat("SpawnRateMultiplier", simulationSpeed);
					}
					if (visualEffect.HasFloat("WindStrength"))
					{
						visualEffect.SetFloat("WindStrength", simulationSpeed);
					}
					num2++;
				}
				ParticleSystem[] array5 = particles;
				int num3 = 0;
				int num4;
				if (!(emission > (float)num3))
				{
					if (num2 < array5.Length)
					{
						ParticleSystem particleSystem = array5[num2];
						ParticleSystem[] array6 = particles;
						num2++;
						while (array6 != null)
						{
						}
					}
					VisualEffect[] array7 = vfxGraphs;
					int length2 = array7.Length;
					if (num2 >= length2)
					{
						goto IL_015a;
					}
					VisualEffect visualEffect2 = array7[num2];
					num4 = ((visualEffect2.enabled = false) ? 1 : 0);
					num2++;
				}
				ParticleSystem[] array8 = particles;
				num2++;
				num4 = num2;
				while (array8 != null)
				{
				}
				VisualEffect[] array9 = vfxGraphs;
				int length3 = array9.Length;
				if (num2 < length3)
				{
					visualEffect3 = array9[num2];
					ulong num5 = default(ulong);
					visualEffect3.enabled = (byte)num5 != 0;
					num2++;
				}
			}
			goto IL_015a;
			IL_015a:
			if ((object)visualEffect3 != null || (initialized ? 1 : 0) == num2)
			{
				ParticleSystem.MainModule[] array10 = mainModules;
				this.simulationSpeed = simulationSpeed;
				if (num2 < array10.Length)
				{
					((ParticleSystem.MainModule*)array10)->simulationSpeed = emission;
					ParticleSystem.MainModule[] array11 = mainModules;
					num2++;
					while (array11 != null)
					{
					}
				}
				VisualEffect[] array12 = vfxGraphs;
				int length4 = array12.Length;
				if (num2 < length4)
				{
					array12[num2].playRate = emission;
					num2++;
				}
			}
			initialized = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600167A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public WeatherParticles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600167B")]
		[Cpp2IlInjected.Address(RVA = "0x838850", Offset = "0x837250", VA = "0x180838850")]
		static WeatherParticles()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
