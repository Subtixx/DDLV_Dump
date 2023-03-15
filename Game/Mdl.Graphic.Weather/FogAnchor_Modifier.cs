using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Graphic.Weather
{
	[Cpp2IlInjected.Token(Token = "0x20004D7")]
	public class FogAnchor_Modifier : WeatherModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001E5B")]
		public Vector3 center;

		[Cpp2IlInjected.Token(Token = "0x170002A8")]
		public override string menuName
		{
			[Cpp2IlInjected.Token(Token = "0x6001555")]
			[Cpp2IlInjected.Address(RVA = "0x145DA90", Offset = "0x145C490", VA = "0x18145DA90", Slot = "4")]
			get
			{
				return "Fog Modifier";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001556")]
		[Cpp2IlInjected.Address(RVA = "0x145D9D0", Offset = "0x145C3D0", VA = "0x18145D9D0", Slot = "6")]
		public override void Disable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001557")]
		[Cpp2IlInjected.Address(RVA = "0x145DA30", Offset = "0x145C430", VA = "0x18145DA30", Slot = "5")]
		public override void Enable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001558")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public override void BeforeEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001559")]
		[Cpp2IlInjected.Address(RVA = "0x145D950", Offset = "0x145C350", VA = "0x18145D950", Slot = "8")]
		public override void AfterEvaluation(float time, WeatherTimeline mainTimeline, float weight)
		{
			float z = center.z;
		}

		[Cpp2IlInjected.Token(Token = "0x600155A")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public FogAnchor_Modifier()
		{
		}
	}
}
