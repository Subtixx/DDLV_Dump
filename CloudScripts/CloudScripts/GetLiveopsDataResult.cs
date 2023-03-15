using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using glPlayFab.Disney;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	public abstract class GetLiveopsDataResult<T> where T : IOnlineLiveopsConfig
	{
		[Cpp2IlInjected.Token(Token = "0x200016C")]
		public class ConfigInfo
		{
			[Cpp2IlInjected.Token(Token = "0x17000101")]
			public string Id
			{
				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return ((GetLiveopsDataResult<>.ConfigInfo)(object)this)._003CId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					((GetLiveopsDataResult<>.ConfigInfo)(object)this)._003CId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000102")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x400068B")]
			public DisneyCloudScript.GetDataState CurrentState
			{
				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000103")]
			public DateTime LastUpdateTimestamp
			{
				[Cpp2IlInjected.Token(Token = "0x60004CF")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x60004D0")]
				[Cpp2IlInjected.Address(RVA = "0x7F4590", Offset = "0x7F2F90", VA = "0x1807F4590")]
				[CompilerGenerated]
				set
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000104")]
			public T Config
			{
				[Cpp2IlInjected.Token(Token = "0x60004D1")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
			public ConfigInfo()
			{
			}//Discarded unreachable code: IL_0007

		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public List<ConfigInfo> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return ((GetLiveopsDataResult<>)(object)this)._003CConfigs_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				((GetLiveopsDataResult<>)(object)this)._003CConfigs_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x2452E90", Offset = "0x2451890", VA = "0x182452E90")]
		protected GetLiveopsDataResult()
		{
			List<> list = default(List<>);
			((GetLiveopsDataResult<>)(object)this).Configs = (List<ConfigInfo>)(object)list;
			base._002Ector();
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	public abstract class GetLiveopsDataResult
	{
		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public Dictionary<string, KnownConfig> KnownConfigIds
		{
			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CKnownConfigIds_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CKnownConfigIds_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected GetLiveopsDataResult()
		{
		}
	}
}
