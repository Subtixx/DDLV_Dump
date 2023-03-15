using Cpp2IlInjected;
using Gameloft.FileSystem.Abstraction;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002A9")]
	public interface IPlayerPrefs
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Load(IFileSystem fs);

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Save();
	}
}
