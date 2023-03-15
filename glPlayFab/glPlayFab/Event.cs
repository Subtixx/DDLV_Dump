using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class Event
	{
		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public TimeFrame TimeFrame
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CTimeFrame_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CTimeFrame_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400017F")]
		public bool HandledByScheduler
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x21"), Cpp2IlInjected.Token(Token = "0x4000180")]
		public bool IsDisabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xBA1880", Offset = "0xBA0280", VA = "0x180BA1880")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xBA18C0", Offset = "0xBA02C0", VA = "0x180BA18C0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CTitle_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CDescription_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CDescription_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public List<string> Locations
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CLocations_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CLocations_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public List<string> ExcludeLocations
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CExcludeLocations_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CExcludeLocations_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public List<string> Labels
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CLabels_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CLabels_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4000186")]
		public int Priority
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Matchers ParticipationConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CParticipationConditions_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			set
			{
				_003CParticipationConditions_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Matchers AdvertisementConditions
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CAdvertisementConditions_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CAdvertisementConditions_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x68"), Cpp2IlInjected.Token(Token = "0x4000189")]
		public bool WorksOffline
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0xFB0200", Offset = "0xFAEC00", VA = "0x180FB0200")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		[field: Cpp2IlInjected.Token(Token = "0x400018A")]
		public static JsonSerializerSettings JsonSerializerSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x102E8D0", Offset = "0x102D2D0", VA = "0x18102E8D0")]
			get;
		} = new JsonSerializerSettings
		{
			TypeNameHandling = TypeNameHandling.All
		};


		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		[JsonIgnore]
		public bool IsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x102E8C0", Offset = "0x102D2C0", VA = "0x18102E8C0")]
			get
			{
				return !IsDisabled;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x102E750", Offset = "0x102D150", VA = "0x18102E750")]
		public string ToJson()
		{
			JsonSerializerSettings settings = JsonSerializerSettings;
			return JsonConvert.SerializeObject(this, settings);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x102E600", Offset = "0x102D000", VA = "0x18102E600")]
		public static Event FromJson(string s)
		{
			JsonSerializerSettings settings = JsonSerializerSettings;
			return JsonConvert.DeserializeObject<Event>(s, settings);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1BAEBB0", Offset = "0x1BAD5B0", VA = "0x181BAEBB0")]
		public static T FromJson<T>(string s) where T : Event
		{
			Event @event = FromJson(s);
			if (@event == null)
			{
			}
			while (@event != null)
			{
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x102E700", Offset = "0x102D100", VA = "0x18102E700", Slot = "4")]
		public virtual Task Start()
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public Event()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x102E840", Offset = "0x102D240", VA = "0x18102E840")]
		static Event()
		{
			throw new NullReferenceException();
		}
	}
}
