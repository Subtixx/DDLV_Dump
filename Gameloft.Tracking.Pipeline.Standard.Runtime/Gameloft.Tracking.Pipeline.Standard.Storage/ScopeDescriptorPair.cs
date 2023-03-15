using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Storage;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Gameloft.Tracking.Pipeline.Standard.Storage
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal struct ScopeDescriptorPair
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public EventScope Scope
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xA45890", Offset = "0xA44290", VA = "0x180A45890")]
			[CompilerGenerated]
			readonly get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xC4CD90", Offset = "0xC4B790", VA = "0x180C4CD90")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		[JsonProperty]
		public JObject Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			readonly get
			{
				return _003CDescriptor_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CDescriptor_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		[JsonIgnore]
		public Dictionary<StorageCategory, StorageDescriptor> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x28C76D0", Offset = "0x28C60D0", VA = "0x1828C76D0")]
			get
			{
				JObject jObject = Descriptor;
				if (jObject != null)
				{
					return jObject.ToObject<Dictionary<StorageCategory, StorageDescriptor>>();
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x28C7720", Offset = "0x28C6120", VA = "0x1828C7720")]
			set
			{
				JObject jObject = (Descriptor = JObject.FromObject(value));
				/*Error: Unexpected end of block*/;
			}
		}
	}
}
