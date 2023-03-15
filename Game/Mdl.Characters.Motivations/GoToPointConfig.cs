using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008D7")]
	[CreateAssetMenu]
	public class GoToPointConfig : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003161")]
		[SerializeField]
		[GUIDName("CustomLocationList")]
		private string _customLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003162")]
		public AnimationClip idleOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003163")]
		public string destinationTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003164")]
		public float slowDownDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003165")]
		public AnimationClip _defaultIdle;

		[Cpp2IlInjected.Token(Token = "0x170005F1")]
		public string CustomLocationGUID
		{
			[Cpp2IlInjected.Token(Token = "0x60028C8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _customLocation;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028C9")]
		[Cpp2IlInjected.Address(RVA = "0xCE0F10", Offset = "0xCDF910", VA = "0x180CE0F10", Slot = "4")]
		public override IMotivation Instantiate()
		{
			GoToPoint goToPoint = new GoToPoint(this);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60028CA")]
		[Cpp2IlInjected.Address(RVA = "0x842E50", Offset = "0x841850", VA = "0x180842E50")]
		public GoToPointConfig()
		{
		}
	}
}
