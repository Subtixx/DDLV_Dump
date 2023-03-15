using Cpp2IlInjected;
using Mdl.Systems;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A4B")]
	public class AvatarCustomizationSystemData : ISystemData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003910")]
		public bool SkipLoadAvatarAppearance;

		[Cpp2IlInjected.Token(Token = "0x6003006")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AvatarCustomizationSystemData()
		{
		}
	}
}
