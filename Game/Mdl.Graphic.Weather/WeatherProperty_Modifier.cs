using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20004E3")]
	[CreateAssetMenu]
	public class WeatherProperty_Modifier : WeatherModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E93")]
		[Tooltip("The identifier that allows to make the link between the modification and the components in the scene.")]
		public string identifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001E94")]
		[Tooltip("Allows you to change the intensity of the effect depending on the activation of the modifier. You might want to activate the effect only when the modifier is used at 25% for example. In this case, this curve should have a peak at 25%, the rest at 0.")]
		public AnimationCurve modifierWeightRemap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001E95")]
		[Tooltip("The hours at which the effect is enable.")]
		public AnimationCurve enableTime;

		[Cpp2IlInjected.Token(Token = "0x170002AE")]
		public override string menuName
		{
			[Cpp2IlInjected.Token(Token = "0x6001583")]
			[Cpp2IlInjected.Address(RVA = "0x838F40", Offset = "0x837940", VA = "0x180838F40", Slot = "4")]
			get
			{
				string text = base.name;
				return "Weather Property/" + text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001584")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public override void AfterEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001585")]
		[Cpp2IlInjected.Address(RVA = "0x838E20", Offset = "0x837820", VA = "0x180838E20", Slot = "7")]
		public override void BeforeEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			//Discarded unreachable code: IL_0027
			float num = modifierWeightRemap.Evaluate(time);
			float num2 = enableTime.Evaluate(time);
			WeatherProperty.SetWeight(identifier, time);
		}

		[Cpp2IlInjected.Token(Token = "0x6001586")]
		[Cpp2IlInjected.Address(RVA = "0x838EE0", Offset = "0x8378E0", VA = "0x180838EE0", Slot = "6")]
		public override void Disable()
		{
			//IL_0010: Expected F4, but got I4
			string text = identifier;
			int num = 0;
			WeatherProperty.SetWeight(text, num);
		}

		[Cpp2IlInjected.Token(Token = "0x6001587")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public override void Enable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001588")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public WeatherProperty_Modifier()
		{
		}
	}
}
