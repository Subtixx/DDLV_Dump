using Cpp2IlInjected;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public interface IEquationKeyProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string GetKeyValue(string fieldName);

		[Cpp2IlInjected.Token(Token = "0x6000CF9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HasFieldName(string fieldName);
	}
}
