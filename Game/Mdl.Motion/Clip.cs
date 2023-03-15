using Cpp2IlInjected;

namespace Mdl.Motion
{
	[Cpp2IlInjected.Token(Token = "0x20003A7")]
	public interface Clip
	{
		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000F95")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F96")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Play(float elapsed, bool reverse = false);

		[Cpp2IlInjected.Token(Token = "0x6000F97")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Seek(float progress);
	}
}
