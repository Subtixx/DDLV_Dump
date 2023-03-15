using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DAB")]
	public class UpdateUserInfo
	{
		[Cpp2IlInjected.Token(Token = "0x2000DAC")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x170013BB")]
			public string DisplayName
			{
				[Cpp2IlInjected.Token(Token = "0x6007248")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CDisplayName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007249")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CDisplayName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170013BC")]
			public string AvatarImageId
			{
				[Cpp2IlInjected.Token(Token = "0x600724A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CAvatarImageId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600724B")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CAvatarImageId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170013BD")]
			public string AvatarImageUrl
			{
				[Cpp2IlInjected.Token(Token = "0x600724C")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CAvatarImageUrl_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600724D")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CAvatarImageUrl_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170013BE")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4003704")]
			public bool ChangeAvatarOnly
			{
				[Cpp2IlInjected.Token(Token = "0x600724E")]
				[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600724F")]
				[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6007250")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000DAD")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4003706")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4003707")]
			InvalidArgs,
			[Cpp2IlInjected.Token(Token = "0x4003708")]
			DisplayNameChangeOnCooldown,
			[Cpp2IlInjected.Token(Token = "0x4003709")]
			ProfaneDisplayName,
			[Cpp2IlInjected.Token(Token = "0x400370A")]
			LegacyDisplayNameChangeFailed,
			[Cpp2IlInjected.Token(Token = "0x400370B")]
			EntityDisplayNameChangeFailed,
			[Cpp2IlInjected.Token(Token = "0x400370C")]
			Failed
		}

		[Cpp2IlInjected.Token(Token = "0x2000DAE")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x170013BF")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400370D")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6007251")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007252")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170013C0")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x6007253")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007254")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170013C1")]
			public string ItemId
			{
				[Cpp2IlInjected.Token(Token = "0x6007257")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CItemId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007258")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CItemId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007255")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007256")]
			[Cpp2IlInjected.Address(RVA = "0x763FD0", Offset = "0x7629D0", VA = "0x180763FD0")]
			public Result WithPlayFabError(PlayFabError error)
			{
				PlayFabError = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6007259")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007247")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UpdateUserInfo()
		{
		}
	}
}
