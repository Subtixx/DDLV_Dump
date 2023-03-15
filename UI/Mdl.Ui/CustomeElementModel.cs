using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	public abstract class CustomeElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void UpdateDisplay(CustomElement element);

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public virtual void Release()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected CustomeElementModel()
		{
			Release();
		}
	}
}
