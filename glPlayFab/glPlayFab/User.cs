using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.ClientModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[DebuggerDisplay("{PlayFabId} - {EntityId}")]
	public class User
	{
		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public string PlayFabId
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CPlayFabId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CPlayFabId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public string EntityId
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CEntityId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CEntityId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public string EntityType
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CEntityType_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CEntityType_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x15048E0", Offset = "0x15032E0", VA = "0x1815048E0")]
		public static User FromLogin(LoginResult result)
		{
			//Discarded unreachable code: IL_0046
			User user = new User();
			string text = (user.PlayFabId = result.PlayFabId);
			string text2 = (user.EntityId = result.EntityToken.Entity.Id);
			string text3 = (user.EntityType = result.EntityToken.Entity.Type);
			return user;
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public User()
		{
		}
	}
}
