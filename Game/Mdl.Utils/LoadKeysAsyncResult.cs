using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000780")]
	public class LoadKeysAsyncResult<T>
	{
		[Cpp2IlInjected.Token(Token = "0x170004A6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x4002B0A")]
		public AsyncAssetLoadingStatus Status
		{
			[Cpp2IlInjected.Token(Token = "0x6002151")]
			[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002152")]
			[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004A7")]
		public List<T> LoadedAssets
		{
			[Cpp2IlInjected.Token(Token = "0x6002153")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6002154")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002155")]
		[Cpp2IlInjected.Address(RVA = "0x29F9340", Offset = "0x29F7D40", VA = "0x1829F9340")]
		public LoadKeysAsyncResult()
		{
			List<> list = (List<>)(object)new List<T>();
			base._002Ector();
		}
	}
}
