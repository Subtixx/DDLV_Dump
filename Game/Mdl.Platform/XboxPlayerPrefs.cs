using Cpp2IlInjected;
using Gameloft.FileSystem.Abstraction;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002B5")]
	public class XboxPlayerPrefs : IPlayerPrefs
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public XboxPlayerPrefs()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			Load((IFileSystem)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public void Load(IFileSystem fs)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		public void Save()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
