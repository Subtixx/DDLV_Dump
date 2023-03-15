using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Graphic.Sky;
using Mdl.Graphic.Wind;
using Unity.Mathematics;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x2000504")]
	[CreateAssetMenu]
	public class WeatherTimeline : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000505")]
		public struct property
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4001FB3")]
			public bool active;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4001FB4")]
			public string name;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000506")]
		public class OverrideInfos
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001FB5")]
			public WeatherTimeline timeline;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001FB6")]
			public string label;

			[Cpp2IlInjected.Token(Token = "0x6001667")]
			[Cpp2IlInjected.Address(RVA = "0xF87760", Offset = "0xF86160", VA = "0x180F87760")]
			public OverrideInfos(string label, WeatherTimeline timeline)
			{
				this.timeline = timeline;
				this.label = label;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000507")]
		public enum Type
		{
			[Cpp2IlInjected.Token(Token = "0x4001FB8")]
			Classic,
			[Cpp2IlInjected.Token(Token = "0x4001FB9")]
			Fallback,
			[Cpp2IlInjected.Token(Token = "0x4001FBA")]
			Variant
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000508")]
		public class Variant
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001FBB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001FBC")]
			public bool isReference = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4001FBD")]
			public WeatherTimeline local;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4001FBE")]
			public WeatherTimeline reference;

			[Cpp2IlInjected.Token(Token = "0x170002E6")]
			public WeatherTimeline timeline
			{
				[Cpp2IlInjected.Token(Token = "0x6001668")]
				[Cpp2IlInjected.Address(RVA = "0xF9AAB0", Offset = "0xF994B0", VA = "0x180F9AAB0")]
				get
				{
					if (!isReference)
					{
						return local;
					}
					return reference;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001669")]
			[Cpp2IlInjected.Address(RVA = "0xF9AAA0", Offset = "0xF994A0", VA = "0x180F9AAA0")]
			public Variant()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FA0")]
		public Type type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FA1")]
		public WeatherTimeline parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001FA2")]
		public bool isStatic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4001FA3")]
		[TimeField]
		public float staticTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001FA4")]
		[SerializeField]
		public TimeSettings time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001FA5")]
		[SerializeField]
		public WeatherMap map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001FA6")]
		[SerializeField]
		public CloudLibrary clouds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001FA7")]
		[SerializeField]
		public ConstellationLibrary constellations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001FA8")]
		[SerializeField]
		public WindAtlas wind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001FA9")]
		[SerializeField]
		public ProbeData lighting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001FAA")]
		[SerializeField]
		public Texture2D skyColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001FAB")]
		public List<Variant> variants = (List<Variant>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001FAC")]
		public List<WeatherModifier> modifiers = (List<WeatherModifier>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4001FAD")]
		[SerializeField]
		public KeyGroup<WeatherKey3> keys = (KeyGroup<WeatherKey3>)(object)new KeyGroup<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4001FAE")]
		private int propertiesID = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001FAF")]
		[SerializeField]
		public property[] props;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001FB0")]
		private Hash128 timeHash;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001FB1")]
		[HideInInspector]
		public float4[] _propValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001FB2")]
		private bool updated;

		[Cpp2IlInjected.Token(Token = "0x170002E5")]
		public float4[] propValues
		{
			[Cpp2IlInjected.Token(Token = "0x6001650")]
			[Cpp2IlInjected.Address(RVA = "0x83FE50", Offset = "0x83E850", VA = "0x18083FE50")]
			get
			{
				//Discarded unreachable code: IL_003c
				//IL_0035: Expected O, but got I4
				do
				{
					int num = propertiesID;
					if (num != -1)
					{
						return ((WeatherKey3)((KeyGroup<T>)(object)keys)[num]).values;
					}
				}
				while (_propValues != null);
				int num2 = 0;
				Evaluate((Hash128)num2, 0.5f, forceCopy: true);
				return _propValues;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001651")]
		[Cpp2IlInjected.Address(RVA = "0x83F200", Offset = "0x83DC00", VA = "0x18083F200")]
		public unsafe void MatchWeatherDataLayout(bool force = false)
		{
			//Discarded unreachable code: IL_0210
			//IL_0079: Expected O, but got I4
			//IL_0112: Expected O, but got I4
			//IL_0112: Expected O, but got I4
			//IL_0159: Expected F4, but got I4
			//IL_0154: Expected native int or pointer, but got O
			//IL_01fe: Expected native int or pointer, but got O
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (Application.isPlaying && updated)
			{
				return;
			}
			int num4 = 0;
			if (!force)
			{
				property[] array = props;
				if (array != null)
				{
					int num5 = 0;
					int count = WeatherData.Count;
					if (array.Length == count)
					{
						int num6 = 0;
						int count2 = WeatherData.Count;
						if (num4 >= count2)
						{
							return;
						}
						property[] array2 = props;
						num4 += num4;
						int num7 = 0;
						string text = WeatherData.IDToName[num4];
						if (!((string)num7 != text))
						{
							num4++;
						}
					}
				}
			}
			int count3 = ((KeyGroup<T>)(object)keys).Count;
			if (num4 < count3)
			{
				Dictionary<string, float4> dictionary = (Dictionary<string, float4>)(object)new Dictionary<TKey, TValue>();
				if ((IntPtr)((WeatherKey3)((KeyGroup<T>)(object)keys)[num4]).values != (IntPtr)num4)
				{
					property[] array3 = props;
					if (array3 != null)
					{
						int length = ((WeatherKey3)((KeyGroup<T>)(object)keys)[num4]).values.Length;
						if (array3.Length == length)
						{
							property[] array4 = props;
							if (num4 < array4.Length)
							{
								num4 += num4;
								float4[] values = ((WeatherKey3)((KeyGroup<T>)(object)keys)[num4]).values;
								((Dictionary<TKey, TValue>)(object)dictionary).Add((TKey)num4, (TValue)num);
								num4++;
							}
						}
					}
				}
				int num8 = 0;
				float4[] array5 = new float4[WeatherData.Count];
				int num9 = 0;
				int count4 = WeatherData.Count;
				if (num4 < count4)
				{
					int num10 = 0;
					string key = WeatherData.IDToName[num4];
					if (((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)key, out *(TValue*)num))
					{
						((float4*)(IntPtr)array5)->x = num;
					}
					num4++;
				}
				((WeatherKey3)((KeyGroup<T>)(object)keys)[num4]).values = array5;
				KeyGroup<WeatherKey3> keyGroup = keys;
				num4++;
			}
			int num11 = 0;
			property[] array6 = new property[WeatherData.Count];
			int num12 = 0;
			int count5 = WeatherData.Count;
			if (num4 < count5)
			{
				int num13 = 0;
				string name = WeatherData.IDToName[num4];
				int active = 0;
				property[] array7 = props;
				Predicate<property> predicate = (Predicate<property>)(object)(Predicate<T>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
				int num14 = default(int);
				if (num14 != -1)
				{
					property[] array8 = props;
					num14 += 2;
					num14 += num14;
				}
				int num15 = 0;
				string text2 = name;
				((property*)(IntPtr)array6)->active = (byte)active != 0;
				num4++;
			}
			props = array6;
		}

		[Cpp2IlInjected.Token(Token = "0x6001652")]
		[Cpp2IlInjected.Address(RVA = "0x83E730", Offset = "0x83D130", VA = "0x18083E730")]
		public Color GetColor(string fieldName)
		{
			int num = num + 2;
			num += num;
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001653")]
		[Cpp2IlInjected.Address(RVA = "0x83E810", Offset = "0x83D210", VA = "0x18083E810")]
		public Color GetColor(int id)
		{
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001654")]
		[Cpp2IlInjected.Address(RVA = "0x83EC50", Offset = "0x83D650", VA = "0x18083EC50")]
		public Vector4 GetVector4(string fieldName)
		{
			int num = num + 2;
			num += num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001655")]
		[Cpp2IlInjected.Address(RVA = "0x83EBE0", Offset = "0x83D5E0", VA = "0x18083EBE0")]
		public Vector4 GetVector4(int id)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001656")]
		[Cpp2IlInjected.Address(RVA = "0x83EB20", Offset = "0x83D520", VA = "0x18083EB20")]
		public Vector3 GetVector3(string fieldName)
		{
			int num = num + 2;
			num += num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001657")]
		[Cpp2IlInjected.Address(RVA = "0x83EAC0", Offset = "0x83D4C0", VA = "0x18083EAC0")]
		public Vector3 GetVector3(int id)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001658")]
		[Cpp2IlInjected.Address(RVA = "0x83E9F0", Offset = "0x83D3F0", VA = "0x18083E9F0")]
		public Vector3 GetVector2(string fieldName)
		{
			int num = num + 2;
			int num2 = 0;
			num += num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001659")]
		[Cpp2IlInjected.Address(RVA = "0x83E980", Offset = "0x83D380", VA = "0x18083E980")]
		public Vector3 GetVector2(int id)
		{
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600165A")]
		[Cpp2IlInjected.Address(RVA = "0x83E8E0", Offset = "0x83D2E0", VA = "0x18083E8E0")]
		public float GetFloat(string fieldName)
		{
			float4[] array = _propValues;
			int id = WeatherData.GetId(fieldName);
			id += 2;
			id += id;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600165B")]
		[Cpp2IlInjected.Address(RVA = "0x83E890", Offset = "0x83D290", VA = "0x18083E890")]
		public float GetFloat(int id)
		{
			float4[] array = _propValues;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600165C")]
		[Cpp2IlInjected.Address(RVA = "0x83FA00", Offset = "0x83E400", VA = "0x18083FA00")]
		public void SetColor(string fieldName, Color color)
		{
			//Discarded unreachable code: IL_0017
			float4[] array = _propValues;
			int id = WeatherData.GetId(fieldName);
			id += 2;
			id += id;
		}

		[Cpp2IlInjected.Token(Token = "0x600165D")]
		[Cpp2IlInjected.Address(RVA = "0x83FC70", Offset = "0x83E670", VA = "0x18083FC70")]
		public void SetVector4(string fieldName, Vector4 vector)
		{
			//Discarded unreachable code: IL_0017
			float4[] array = _propValues;
			int id = WeatherData.GetId(fieldName);
			id += 2;
			id += id;
		}

		[Cpp2IlInjected.Token(Token = "0x600165E")]
		[Cpp2IlInjected.Address(RVA = "0x83FAF0", Offset = "0x83E4F0", VA = "0x18083FAF0")]
		public unsafe void SetFloat(string fieldName, float value)
		{
			//Discarded unreachable code: IL_001e
			//IL_0018: Expected native int or pointer, but got O
			float4[] array = _propValues;
			int id = WeatherData.GetId(fieldName);
			id += 2;
			id += id;
			((float4*)(IntPtr)array)->x = value;
		}

		[Cpp2IlInjected.Token(Token = "0x600165F")]
		[Cpp2IlInjected.Address(RVA = "0x83F980", Offset = "0x83E380", VA = "0x18083F980")]
		public unsafe void SetColor(int id, Color color)
		{
			//Discarded unreachable code: IL_000d
			//IL_000c: Expected F4, but got I4
			//IL_0007: Expected native int or pointer, but got O
			((float4*)(IntPtr)_propValues)->x = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6001660")]
		[Cpp2IlInjected.Address(RVA = "0x83FBF0", Offset = "0x83E5F0", VA = "0x18083FBF0")]
		public void SetVector4(int id, Vector4 vector)
		{
			//Discarded unreachable code: IL_000c
			float4[] array = _propValues;
			float4 @float = @float + @float;
		}

		[Cpp2IlInjected.Token(Token = "0x6001661")]
		[Cpp2IlInjected.Address(RVA = "0x83FBA0", Offset = "0x83E5A0", VA = "0x18083FBA0")]
		public unsafe void SetFloat(int id, float value)
		{
			//Discarded unreachable code: IL_000d
			//IL_0007: Expected native int or pointer, but got O
			((float4*)(IntPtr)_propValues)->x = value;
		}

		[Cpp2IlInjected.Token(Token = "0x6001662")]
		[Cpp2IlInjected.Address(RVA = "0x83E120", Offset = "0x83CB20", VA = "0x18083E120")]
		public unsafe void Evaluate(Hash128 timeHash, float time, bool forceCopy = false)
		{
			//Discarded unreachable code: IL_00d8
			//IL_0087: Expected I4, but got I8
			//IL_00ca: Expected native int or pointer, but got O
			int num = 0;
			int force = 0;
			int num2 = 0;
			MatchWeatherDataLayout((byte)force != 0);
			if (!forceCopy)
			{
				Hash128 hash = this.timeHash;
				bool flag = default(bool);
				if (flag)
				{
					return;
				}
			}
			if (!forceCopy)
			{
				if (num2 < num)
				{
					propertiesID = num;
				}
				propertiesID = num;
			}
			float4[] array = _propValues;
			if (array != null)
			{
				int num3 = 0;
				int count = WeatherData.Count;
				if (array.Length == count)
				{
					goto IL_006f;
				}
			}
			int num4 = 0;
			float4[] array2 = (_propValues = new float4[WeatherData.Count]);
			goto IL_006f;
			IL_006f:
			float4[] array3 = _propValues;
			propertiesID = -1;
			if (num < array3.Length)
			{
				float4[] values = ((WeatherKey3)((KeyGroup<T>)(object)keys)[num]).values;
				KeyGroup<WeatherKey3> keyGroup = keys;
				num += 2;
				num += num;
				float4[] values2 = ((WeatherKey3)((KeyGroup<T>)(object)keyGroup)[num]).values;
				num++;
				((float4*)(IntPtr)array3)->x = time;
				float4[] array4 = _propValues;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001663")]
		[Cpp2IlInjected.Address(RVA = "0x83ED10", Offset = "0x83D710", VA = "0x18083ED10")]
		public void Inherit()
		{
			//Discarded unreachable code: IL_0044
			property[] array = props;
			int num = 0;
			if (num < array.Length)
			{
				num += 2;
				num += num;
				if ((long)"{il2cpp array field local1->}" == 0)
				{
					float4[] array2 = propValues;
					float4[] array3 = parent.propValues;
				}
				property[] array4 = props;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001664")]
		[Cpp2IlInjected.Address(RVA = "0x83EE00", Offset = "0x83D800", VA = "0x18083EE00")]
		public unsafe void Lerp(WeatherTimeline target, float weight, bool enableOnly)
		{
			//IL_0029: Expected I4, but got I8
			//IL_0029: Expected O, but got I4
			//IL_0078: Expected I4, but got I8
			//IL_0078: Expected O, but got I4
			//IL_0088: Expected native int or pointer, but got O
			//IL_00c0: Expected native int or pointer, but got O
			property[] array = target.props;
			int num = 0;
			int length = array.Length;
			if ((IntPtr)_propValues == (IntPtr)num)
			{
				int num2 = 0;
				ulong num3 = default(ulong);
				Evaluate((Hash128)num2, 0.5f, (byte)num3 != 0);
			}
			if (!enableOnly)
			{
				if (length > 0)
				{
					float4[] array2 = _propValues;
					num += 2;
					num += num;
					int num4 = target.propertiesID;
					int num5 = 0;
					if (num4 != -1)
					{
						WeatherKey3 weatherKey = (WeatherKey3)((KeyGroup<T>)(object)target.keys)[num4];
					}
					if (target._propValues == null)
					{
						ulong num6 = default(ulong);
						target.Evaluate((Hash128)num5, 0.5f, (byte)num6 != 0);
						float4[] array3 = target._propValues;
					}
					num++;
					float x = default(float);
					((float4*)(IntPtr)array2)->x = x;
				}
				return;
			}
			while (length <= 0)
			{
			}
			property[] array4 = target.props;
			num += 2;
			num += num;
			if ((long)"{il2cpp array field local19->}" != 0)
			{
				float4[] array5 = _propValues;
				float4[] array6 = target.propValues;
				float x2 = default(float);
				((float4*)(IntPtr)array5)->x = x2;
			}
			num++;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001665")]
		[Cpp2IlInjected.Address(RVA = "0x83E4F0", Offset = "0x83CEF0", VA = "0x18083E4F0")]
		public void Evaluate(float time, out int previous, out int next, out float t)
		{
			//Discarded unreachable code: IL_009f
			int num = (next.m_value = (previous.m_value = 0));
			int count = ((KeyGroup<T>)(object)keys).Count;
			if (num < count)
			{
				WeatherKey3 weatherKey = (WeatherKey3)((KeyGroup<T>)(object)keys)[num];
				KeyGroup<WeatherKey3> keyGroup = keys;
				float num2 = weatherKey.time;
				float duration = ((WeatherKey3)((KeyGroup<T>)(object)keyGroup)[num]).duration;
				if (!(time <= num2))
				{
				}
				if (!(time <= time))
				{
					previous.m_value = num;
				}
				if (!(duration <= time))
				{
				}
				if (!(num2 <= duration) && !(duration <= time))
				{
					next.m_value = num;
				}
				KeyGroup<WeatherKey3> keyGroup2 = keys;
				num++;
			}
			KeyGroup<WeatherKey3> keyGroup3 = keys;
			WeatherKey3 weatherKey2 = default(WeatherKey3);
			float duration2 = weatherKey2.duration;
			if (!(duration2 <= time))
			{
			}
			float num3 = Mathf.InverseLerp(duration2, time, time);
		}

		[Cpp2IlInjected.Token(Token = "0x6001666")]
		[Cpp2IlInjected.Address(RVA = "0x83FD40", Offset = "0x83E740", VA = "0x18083FD40")]
		public WeatherTimeline()
		{
		}//IL_0037: Expected I4, but got I8

	}
}
