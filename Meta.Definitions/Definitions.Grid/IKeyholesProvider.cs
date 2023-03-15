using Cpp2IlInjected;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x200071B")]
	public interface IKeyholesProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6004EE6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string AddKeyhole(string keyholeConfigDataGUID);

		[Cpp2IlInjected.Token(Token = "0x6004EE7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RemoveKeyhole(string keyholeConfigDataGUID);
	}
}
