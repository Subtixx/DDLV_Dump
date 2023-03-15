using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	public abstract class BaseDataReport : IDataReport
	{
		[Cpp2IlInjected.Token(Token = "0x2000177")]
		public class Context
		{
			[Cpp2IlInjected.Token(Token = "0x17000197")]
			public string EnginePath
			{
				[Cpp2IlInjected.Token(Token = "0x60006D7")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CEnginePath_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60006D8")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CEnginePath_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000198")]
			public string GamePath
			{
				[Cpp2IlInjected.Token(Token = "0x60006D9")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CGamePath_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60006DA")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CGamePath_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Context()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public abstract string UniqueKey
		{
			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public string Output
		{
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return _003COutput_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500", Slot = "7")]
			[CompilerGenerated]
			set
			{
				_003COutput_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return _003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510", Slot = "9")]
			[CompilerGenerated]
			set
			{
				_003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		public abstract void Build(Context ctx);

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x1024120", Offset = "0x1022B20", VA = "0x181024120")]
		protected BaseDataReport()
		{
		}
	}
}
