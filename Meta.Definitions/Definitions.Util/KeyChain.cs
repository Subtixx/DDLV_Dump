using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.FileSystem.Abstraction;

namespace Definitions.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	public class KeyChain
	{
		[Cpp2IlInjected.Token(Token = "0x1700034D")]
		public static IKeyChain Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000DAD")]
			[Cpp2IlInjected.Address(RVA = "0x2738D00", Offset = "0x2737700", VA = "0x182738D00")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000DAE")]
			[Cpp2IlInjected.Address(RVA = "0x2738D60", Offset = "0x2737760", VA = "0x182738D60")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public KeyChain()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB0")]
		[Cpp2IlInjected.Address(RVA = "0x2738C00", Offset = "0x2737600", VA = "0x182738C00")]
		static KeyChain()
		{
			IFileSystem _003CSave_003Ek__BackingField = FileSystem.Save;
			string fileName = JsonKeyChain.FileName;
			JsonKeyChain jsonKeyChain = default(JsonKeyChain);
			jsonKeyChain.FileSystem = _003CSave_003Ek__BackingField;
			jsonKeyChain.Path = fileName;
			jsonKeyChain.Create();
			/*Error: Unexpected end of block*/;
		}
	}
}
