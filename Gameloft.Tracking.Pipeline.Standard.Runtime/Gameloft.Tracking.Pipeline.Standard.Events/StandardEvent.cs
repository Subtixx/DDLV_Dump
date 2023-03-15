using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Newtonsoft.Json;

namespace Gameloft.Tracking.Pipeline.Standard.Events
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal sealed class StandardEvent : Event
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public EventData EventData
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CEventData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CEventData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000038")]
		public EventPriority Priority
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4000039")]
		public uint BatchSize
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public List<string> SmartBatchProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CSmartBatchProperties_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CSmartBatchProperties_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[JsonIgnore]
		public bool IsBatchable
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28C7750", Offset = "0x28C6150", VA = "0x1828C7750")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[JsonIgnore]
		public bool IsSmartBatchable
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x28C7760", Offset = "0x28C6160", VA = "0x1828C7760")]
			get
			{
				while (SmartBatchProperties == null)
				{
				}
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public StandardEvent()
		{
			((XNode)(object)this)._002Ector();
		}
	}
}
