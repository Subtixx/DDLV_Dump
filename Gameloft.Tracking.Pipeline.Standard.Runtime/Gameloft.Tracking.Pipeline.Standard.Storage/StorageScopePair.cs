using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Storage;

namespace Gameloft.Tracking.Pipeline.Standard.Storage
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class StorageScopePair
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public IPersistentStorage Storage
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CStorage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CStorage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public EventScope Scope
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6D0", Offset = "0x8FC0D0", VA = "0x1808FD6D0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xDDA640", Offset = "0xDD9040", VA = "0x180DDA640")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xAE6160", Offset = "0xAE4B60", VA = "0x180AE6160")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x28C8470", Offset = "0x28C6E70", VA = "0x1828C8470")]
		public StorageScopePair(EventScope scope, IPersistentStorage storage)
		{
			Storage = storage;
			/*Error: Unexpected end of block*/;
		}
	}
}
