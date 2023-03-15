using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	public class BattlePassTask
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDescription_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CDescription_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CIconAddress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CIconAddress_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x400063E")]
		public int CurrencyReward
		{
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x400063F")]
		public int AvailableOnDay
		{
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60007FE")]
			[Cpp2IlInjected.Address(RVA = "0x7252E0", Offset = "0x723CE0", VA = "0x1807252E0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public JObject GameObjectiveData
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CGameObjectiveData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CGameObjectiveData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x1024B60", Offset = "0x1023560", VA = "0x181024B60")]
		public void SetToUnavailable()
		{
			//IL_0009: Expected O, but got I8
			//IL_0012: Expected I4, but got I8
			GameObjectiveData = (JObject)0;
			CurrencyReward = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BattlePassTask()
		{
		}
	}
}
