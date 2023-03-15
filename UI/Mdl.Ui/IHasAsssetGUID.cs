using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000863")]
	public interface IHasAsssetGUID
	{
		[Cpp2IlInjected.Token(Token = "0x17000781")]
		string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6003511")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003512")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
