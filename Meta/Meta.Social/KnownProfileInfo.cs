using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.ProfilesModels;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000D98")]
	public class KnownProfileInfo
	{
		[Cpp2IlInjected.Token(Token = "0x170013B2")]
		public string EntityId
		{
			[Cpp2IlInjected.Token(Token = "0x60071F7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CEntityId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60071F8")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CEntityId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B3")]
		public string PlayfabId
		{
			[Cpp2IlInjected.Token(Token = "0x60071F9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CPlayfabId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60071FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			private set
			{
				_003CPlayfabId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B4")]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60071FB")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CDisplayName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60071FC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CDisplayName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B5")]
		public string AvatarUrl
		{
			[Cpp2IlInjected.Token(Token = "0x60071FD")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CAvatarUrl_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60071FE")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CAvatarUrl_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170013B6")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60071FF")]
			[Cpp2IlInjected.Address(RVA = "0x18A0B30", Offset = "0x189F530", VA = "0x1818A0B30")]
			get
			{
				if (!string.IsNullOrEmpty(EntityId) && !string.IsNullOrEmpty(PlayfabId))
				{
					return !string.IsNullOrEmpty(DisplayName);
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007200")]
		[Cpp2IlInjected.Address(RVA = "0x18A0A50", Offset = "0x189F450", VA = "0x1818A0A50")]
		public unsafe static KnownProfileInfo New(string entityId, string playfabId, string displayName, string avatarUrl)
		{
			//Discarded unreachable code: IL_002d
			//IL_000b: Expected O, but got I4
			int num = 0;
			KnownProfileInfo knownProfileInfo = default(KnownProfileInfo);
			((object)knownProfileInfo).FieldGetter((string)num, displayName, ref *(object*)avatarUrl);
			knownProfileInfo.EntityId = entityId;
			knownProfileInfo.PlayfabId = playfabId;
			knownProfileInfo.DisplayName = "PlayerName";
			knownProfileInfo.AvatarUrl = avatarUrl;
			return knownProfileInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6007201")]
		[Cpp2IlInjected.Address(RVA = "0x18A0A10", Offset = "0x189F410", VA = "0x1818A0A10")]
		public static KnownProfileInfo New(FollowData friendInfo, string entityId)
		{
			//Discarded unreachable code: IL_001f
			string avatar_ = friendInfo.avatar_;
			string displayName_ = friendInfo.displayName_;
			string playfabId_ = friendInfo.playfabId_;
			return New(entityId, playfabId_, displayName_, avatar_);
		}

		[Cpp2IlInjected.Token(Token = "0x6007202")]
		[Cpp2IlInjected.Address(RVA = "0x18A09A0", Offset = "0x189F3A0", VA = "0x1818A09A0")]
		public static KnownProfileInfo New(EntityProfileBody profile)
		{
			//Discarded unreachable code: IL_002f
			EntityLineage lineage = profile.Lineage;
			string displayName = profile.DisplayName;
			string masterPlayerAccountId = lineage.MasterPlayerAccountId;
			string titlePlayerAccountId = lineage.TitlePlayerAccountId;
			string avatarUrl = profile.AvatarUrl;
			return New(titlePlayerAccountId, masterPlayerAccountId, displayName, avatarUrl);
		}

		[Cpp2IlInjected.Token(Token = "0x6007203")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public KnownProfileInfo()
		{
		}
	}
}
