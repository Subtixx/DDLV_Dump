using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.AdminModels;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000E87")]
	public class ClientNetworkData : NetworkDataProvider
	{
		[Cpp2IlInjected.Token(Token = "0x1700151F")]
		public override Profile WorldProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6007914")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return _003CWorldProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007915")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500", Slot = "5")]
			[CompilerGenerated]
			set
			{
				_003CWorldProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001520")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003AD9")]
		public override int LocalPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6007916")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007917")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001521")]
		public override Profile[] PlayerProfiles
		{
			[Cpp2IlInjected.Token(Token = "0x6007918")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return _003CPlayerProfiles_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007919")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "9")]
			[CompilerGenerated]
			set
			{
				_003CPlayerProfiles_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new Profile[4];


		[Cpp2IlInjected.Token(Token = "0x17001522")]
		public override bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x600791A")]
			[Cpp2IlInjected.Address(RVA = "0x1673B90", Offset = "0x1672590", VA = "0x181673B90", Slot = "10")]
			get
			{
				if (WorldProfile != null)
				{
					int localPlayerId = LocalPlayerId;
					return LocalPlayerId < 4;
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600791B")]
		[Cpp2IlInjected.Address(RVA = "0x1673B30", Offset = "0x1672530", VA = "0x181673B30")]
		public ClientNetworkData()
		{
			((RevokeItemError)(object)this)._002Ector();
		}
	}
}
