using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	public abstract class CustomButtonModel
	{
		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void Init(CustomButton button);

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void UpdateDisplay();

		[Cpp2IlInjected.Token(Token = "0x60009DD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void Release();

		[Cpp2IlInjected.Token(Token = "0x60009DE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected CustomButtonModel()
		{
		}
	}
}
