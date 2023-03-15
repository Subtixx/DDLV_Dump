using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public class BundleConfig : IOnlineLiveopsConfig, IServerDataConfig
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return _003COnlineId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500", Slot = "5")]
			[CompilerGenerated]
			set
			{
				_003COnlineId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40005E0")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40005E1")]
		public DateTime StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590", Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public DateTime? EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xC561A0", Offset = "0xC54BA0", VA = "0x180C561A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x1024D60", Offset = "0x1023760", VA = "0x181024D60", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x40005E3")]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0", Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700", Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return _003CMinGameVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0", Slot = "15")]
			[CompilerGenerated]
			set
			{
				_003CMinGameVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public DateTime? LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8C0", Offset = "0x8BA2C0", VA = "0x1808BB8C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8D0", Offset = "0x8BA2D0", VA = "0x1808BB8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public ServerLoc TitleLoc
		{
			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CTitleLoc_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			set
			{
				_003CTitleLoc_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public List<Content> Contents
		{
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CContents_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CContents_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public List<Price> Prices
		{
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			[CompilerGenerated]
			get
			{
				return _003CPrices_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			[CompilerGenerated]
			set
			{
				_003CPrices_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public string IAPData
		{
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CIAPData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			set
			{
				_003CIAPData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public JObject Filter
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003CFilter_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			set
			{
				_003CFilter_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BundleConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x1024C40", Offset = "0x1023640", VA = "0x181024C40")]
		public BundleConfig(BundleConfig other)
		{
			string text = (OnlineId = other.OnlineId);
			int num = (Version = other.Version);
			DateTime dateTime = (StartDate = other.StartDate);
			DateTime? dateTime2 = (EndDate = other.EndDate);
			bool flag = (IsHidden = other.IsHidden);
			string text2 = (MinGameVersion = other.MinGameVersion);
			DateTime? dateTime3 = (LastUpdateTimestamp = other.LastUpdateTimestamp);
			ServerLoc serverLoc = (TitleLoc = new ServerLoc(other.TitleLoc));
			List<Content> list = (Contents = other.Contents);
			List<Price> list2 = (Prices = other.Prices);
			JObject jObject = (Filter = other.Filter);
			string text3 = (IAPData = other.IAPData);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x1024C10", Offset = "0x1023610", VA = "0x181024C10")]
		public void SetLoc(string language)
		{
			ServerLoc serverLoc = default(ServerLoc);
			TitleLoc = serverLoc;
			/*Error: Unexpected end of block*/;
		}
	}
}
