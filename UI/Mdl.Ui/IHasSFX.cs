using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200082D")]
	public interface IHasSFX
	{
		[Cpp2IlInjected.Token(Token = "0x1700074B")]
		bool IsMuted
		{
			[Cpp2IlInjected.Token(Token = "0x600340E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600340F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6003410")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PostSfx(int index);
	}
}
