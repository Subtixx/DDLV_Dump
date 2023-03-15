using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	public class StoreConfig : IOnlineLiveopsConfig, IServerDataConfig
	{
		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return _003COnlineId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500", Slot = "5")]
			[CompilerGenerated]
			set
			{
				_003COnlineId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400060C")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400060D")]
		public DateTime StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590", Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public DateTime? EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0xC561A0", Offset = "0xC54BA0", VA = "0x180C561A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x1024D60", Offset = "0x1023760", VA = "0x181024D60", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x400060F")]
		public bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0", Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600077E")]
			[Cpp2IlInjected.Address(RVA = "0xA62700", Offset = "0xA61100", VA = "0x180A62700", Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return _003CMinGameVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0", Slot = "15")]
			[CompilerGenerated]
			set
			{
				_003CMinGameVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public DateTime? LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8C0", Offset = "0x8BA2C0", VA = "0x1808BB8C0")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8D0", Offset = "0x8BA2D0", VA = "0x1808BB8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public StoreDefinition Definition
		{
			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CDefinition_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			set
			{
				_003CDefinition_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public List<StoreContent> Contents
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CContents_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			set
			{
				_003CContents_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public StoreConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x14F68B0", Offset = "0x14F52B0", VA = "0x1814F68B0")]
		public StoreConfig(StoreConfig other)
		{
			//IL_00c7: Expected O, but got I4
			string text = (OnlineId = other.OnlineId);
			int num = (Version = other.Version);
			DateTime dateTime = (StartDate = other.StartDate);
			DateTime? dateTime2 = (EndDate = other.EndDate);
			bool flag = (IsHidden = other.IsHidden);
			string text2 = (MinGameVersion = other.MinGameVersion);
			DateTime? dateTime3 = (LastUpdateTimestamp = other.LastUpdateTimestamp);
			StoreDefinition storeDefinition = (Definition = other.Definition);
			List<StoreContent> list = other.Contents;
			if (list != null)
			{
				Func<StoreContent, StoreContent> _003C_003E9__37_ = _003C_003Ec._003C_003E9__37_0;
				if (_003C_003E9__37_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((StoreContent x) => new StoreContent(x));
				}
				List<StoreContent> list2 = (List<StoreContent>)(object)Enumerable.ToList<StoreContent>(Enumerable.Select<StoreContent, StoreContent>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__37_));
			}
			int num2 = 0;
			Contents = (List<StoreContent>)num2;
			throw new NullReferenceException();
		}
	}
}
