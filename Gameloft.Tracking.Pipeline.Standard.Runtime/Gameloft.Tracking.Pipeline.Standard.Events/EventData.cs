using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.Serialization.Json;
using Gameloft.Tracking.Utils;
using Newtonsoft.Json;

namespace Gameloft.Tracking.Pipeline.Standard.Events
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class EventData
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		[JsonProperty]
		public Dictionary<string, object> UserData
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CUserData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CUserData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[JsonProperty]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400002F")]
		public int Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[JsonProperty]
		[JsonConverter(typeof(JsonTimestampConverter), new object[] { 1 })]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000030")]
		public DateTime TimeStamp
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		[JsonProperty]
		[JsonConverter(typeof(JsonTimestampConverter), new object[] { 2 })]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000031")]
		public DateTime TimeStampLocal
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		[JsonProperty]
		public string UUID
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CUUID_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CUUID_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		[JsonProperty]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000033")]
		public int Token
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		[JsonIgnore]
		internal uint Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x28C17D0", Offset = "0x28C01D0", VA = "0x1828C17D0")]
			get
			{
				//IL_0013: Expected O, but got I4
				//IL_0013: Expected I4, but got O
				int num = 0;
				string valueOrDefault = DictionaryExtensions.GetValueOrDefault<string, object, uint>((IReadOnlyDictionary<, >)UserData, (uint)(int)"count", (string)num);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x28C1940", Offset = "0x28C0340", VA = "0x1828C1940")]
			set
			{
				//Discarded unreachable code: IL_000d, IL_000e
				Dictionary<string, object> dictionary = UserData;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		[JsonIgnore]
		internal uint CountSmartBatch
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x28C1780", Offset = "0x28C0180", VA = "0x1828C1780")]
			get
			{
				//IL_0013: Expected O, but got I4
				//IL_0013: Expected I4, but got O
				int num = 0;
				string valueOrDefault = DictionaryExtensions.GetValueOrDefault<string, object, uint>((IReadOnlyDictionary<, >)UserData, (uint)(int)"count_sb", (string)num);
				/*Error: Unexpected end of block*/;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x28C18B0", Offset = "0x28C02B0", VA = "0x1828C18B0")]
			set
			{
				//Discarded unreachable code: IL_000d, IL_000e
				Dictionary<string, object> dictionary = UserData;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		[JsonIgnore]
		public ConnectivityType Connectivity
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x28C1820", Offset = "0x28C0220", VA = "0x1828C1820")]
			set
			{
				//Discarded unreachable code: IL_000f, IL_0010
				Dictionary<string, object> dictionary = UserData;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28C1700", Offset = "0x28C0100", VA = "0x1828C1700")]
		public EventData()
		{
			int num = 0;
			DateTime dateTime = (TimeStamp = DateTime.UtcNow);
			DateTime dateTime2 = default(DateTime);
			TimeStampLocal = dateTime2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28C1620", Offset = "0x28C0020", VA = "0x1828C1620")]
		public EventData(Dictionary<string, object> userData)
		{
			int num = 0;
			DateTime dateTime = (TimeStamp = DateTime.UtcNow);
			DateTime dateTime2 = default(DateTime);
			TimeStampLocal = dateTime2;
			if (userData != null)
			{
				UserData = userData;
			}
			ArgumentNullException ex = new ArgumentNullException("userData");
			/*Error: Unexpected end of block*/;
		}
	}
}
