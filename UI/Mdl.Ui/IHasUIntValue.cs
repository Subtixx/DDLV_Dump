using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200084C")]
	public interface IHasUIntValue
	{
		[Cpp2IlInjected.Token(Token = "0x600349C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GetValue(UIntValueType valueType);
	}
}
