using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;

namespace Gameloft.Tracking.Pipeline.Standard.Storage
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal struct StorageDepotDescriptor
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly StorageDepotDescriptor Null = (StorageDepotDescriptor)EventScope.Null;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public EventScope DefaultScope
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xA45890", Offset = "0xA44290", VA = "0x180A45890")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xC4CD90", Offset = "0xC4B790", VA = "0x180C4CD90")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public List<ScopeDescriptorPair> Descriptors
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			readonly get
			{
				return _003CDescriptors_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CDescriptors_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}
	}
}
