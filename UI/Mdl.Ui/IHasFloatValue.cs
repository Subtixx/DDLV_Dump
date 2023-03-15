using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200084B")]
	public interface IHasFloatValue
	{
		[Cpp2IlInjected.Token(Token = "0x600349B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float GetValue(FloatValueType valueType);
	}
}
