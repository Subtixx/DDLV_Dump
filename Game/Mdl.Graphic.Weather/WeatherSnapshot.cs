using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004F6")]
	[ExecuteAlways]
	[RequireComponent(typeof(Volume))]
	public class WeatherSnapshot : MonoBehaviour, IWeatherController
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F36")]
		public WeatherTimeline timeline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001F37")]
		private List<(WeatherTimeline timeline, float weight)> timelines = (List<(WeatherTimeline timeline, float weight)>)(object)new List<T>(1);

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001F38")]
		public List<WeatherModifier> modifiers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001F39")]
		[SerializeField]
		public float windFrequency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4001F3A")]
		[SerializeField]
		[Range(0f, 1f)]
		public float windAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001F3B")]
		private Volume _volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001F3C")]
		[TimeField]
		public float _time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001F3D")]
		private RenderTexture blendedCubemap;

		[Cpp2IlInjected.Token(Token = "0x170002C6")]
		public List<(WeatherTimeline, float)> Timelines
		{
			[Cpp2IlInjected.Token(Token = "0x60015EE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "4")]
			get
			{
				return timelines;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C7")]
		public List<WeatherModifier> Modifiers
		{
			[Cpp2IlInjected.Token(Token = "0x60015EF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "5")]
			get
			{
				return modifiers;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C8")]
		public float WindFrequency
		{
			[Cpp2IlInjected.Token(Token = "0x60015F0")]
			[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0", Slot = "6")]
			get
			{
				return windFrequency;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C9")]
		public Vector3 WindAxis
		{
			[Cpp2IlInjected.Token(Token = "0x60015F1")]
			[Cpp2IlInjected.Address(RVA = "0x83A7A0", Offset = "0x8391A0", VA = "0x18083A7A0", Slot = "7")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CA")]
		public PostProcess PostProcess
		{
			[Cpp2IlInjected.Token(Token = "0x60015F2")]
			[Cpp2IlInjected.Address(RVA = "0x83A600", Offset = "0x839000", VA = "0x18083A600", Slot = "8")]
			get
			{
				return GraphicSettings.PostProcess;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CB")]
		public Volume Volume
		{
			[Cpp2IlInjected.Token(Token = "0x60015F3")]
			[Cpp2IlInjected.Address(RVA = "0x83A700", Offset = "0x839100", VA = "0x18083A700", Slot = "9")]
			get
			{
				//IL_0010: Expected O, but got I4
				Volume volume = _volume;
				int num = 0;
				if (volume == (Object)num)
				{
					Volume volume2 = (_volume = GetComponent<Volume>());
				}
				return _volume;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CC")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60015F4")]
			[Cpp2IlInjected.Address(RVA = "0x83A660", Offset = "0x839060", VA = "0x18083A660", Slot = "10")]
			get
			{
				//Discarded unreachable code: IL_0031
				//IL_0010: Expected O, but got I4
				WeatherTimeline weatherTimeline = timeline;
				int num = 0;
				if (weatherTimeline != (Object)num)
				{
					WeatherTimeline weatherTimeline2 = timeline;
					if (weatherTimeline2.isStatic)
					{
						return weatherTimeline2.staticTime;
					}
				}
				return _time;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CD")]
		public MonoBehaviour monoBehaviour
		{
			[Cpp2IlInjected.Token(Token = "0x60015F5")]
			[Cpp2IlInjected.Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0", Slot = "14")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CE")]
		public float updateFrequency
		{
			[Cpp2IlInjected.Token(Token = "0x60015F6")]
			[Cpp2IlInjected.Address(RVA = "0x83A800", Offset = "0x839200", VA = "0x18083A800", Slot = "11")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015F7")]
		[Cpp2IlInjected.Address(RVA = "0x83A310", Offset = "0x838D10", VA = "0x18083A310")]
		private void Update()
		{
			WeatherController.Evaluate(this, force: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60015F8")]
		[Cpp2IlInjected.Address(RVA = "0x83A310", Offset = "0x838D10", VA = "0x18083A310", Slot = "12")]
		public void Evaluate()
		{
			WeatherController.Evaluate(this, force: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60015F9")]
		[Cpp2IlInjected.Address(RVA = "0x83A370", Offset = "0x838D70", VA = "0x18083A370", Slot = "13")]
		public void LoadTimelines()
		{
			//Discarded unreachable code: IL_0037
			//IL_001d: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			((List<T>)(object)timelines).Clear();
			WeatherTimeline weatherTimeline = timeline;
			int num = 0;
			int num2 = 0;
			if (weatherTimeline != (Object)num2)
			{
				int num3 = 0;
				WeatherTimeline weatherTimeline2 = timeline;
				((List<T>)(object)timelines).Add((T)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60015FA")]
		[Cpp2IlInjected.Address(RVA = "0x83A4D0", Offset = "0x838ED0", VA = "0x18083A4D0")]
		private void OnEnable()
		{
			WeatherController.AddController(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60015FB")]
		[Cpp2IlInjected.Address(RVA = "0x83A470", Offset = "0x838E70", VA = "0x18083A470")]
		private void OnDisable()
		{
			WeatherController.RemoveController(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60015FC")]
		[Cpp2IlInjected.Address(RVA = "0x83A530", Offset = "0x838F30", VA = "0x18083A530")]
		public WeatherSnapshot()
		{
			List<WeatherModifier> list = default(List<WeatherModifier>);
			modifiers = list;
			windFrequency = 0.1f;
			base._002Ector();
		}
	}
}
