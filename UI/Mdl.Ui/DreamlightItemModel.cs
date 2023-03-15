using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000435")]
	internal abstract class DreamlightItemModel
	{
		[Cpp2IlInjected.Token(Token = "0x6001B2A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		internal abstract void UpdateDisplay(DreamlightItem dreamlightItem);

		[Cpp2IlInjected.Token(Token = "0x6001B2B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool IsClaimable();

		[Cpp2IlInjected.Token(Token = "0x6001B2C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract bool IsMilestoneEnded();

		[Cpp2IlInjected.Token(Token = "0x6001B2D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected DreamlightItemModel()
		{
		}
	}
}
