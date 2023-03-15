using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.CloudScriptModels;
using PlayFab.ProfilesModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class EntityPlayStreamEvent<T>
	{
		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public string SchemaVersion
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamEvent<>)(object)this)._003CSchemaVersion_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamEvent<>)(object)this)._003CSchemaVersion_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public EventFullName FullName
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamEvent<>)(object)this)._003CFullName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamEvent<>)(object)this)._003CFullName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamEvent<>)(object)this)._003CId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamEvent<>)(object)this)._003CId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40002ED")]
		public DateTime Timestamp
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x6E6160", Offset = "0x6E4B60", VA = "0x1806E6160")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public PlayFab.CloudScriptModels.EntityKey Entity
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamEvent<>)(object)this)._003CEntity_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamEvent<>)(object)this)._003CEntity_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public PlayFab.CloudScriptModels.EntityKey Originator
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamEvent<>)(object)this)._003COriginator_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamEvent<>)(object)this)._003COriginator_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public OriginInfo OriginInfo
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamEvent<>)(object)this)._003COriginInfo_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamEvent<>)(object)this)._003COriginInfo_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public T Payload
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamEvent<>)(object)this)._003CPayload_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamEvent<>)(object)this)._003CPayload_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public EntityLineage EntityLineage
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return ((EntityPlayStreamEvent<>)(object)this)._003CEntityLineage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			set
			{
				((EntityPlayStreamEvent<>)(object)this)._003CEntityLineage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
		public EntityPlayStreamEvent()
		{
		}//Discarded unreachable code: IL_0007

	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class EntityPlayStreamEvent : EntityPlayStreamEvent<object>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x102E220", Offset = "0x102CC20", VA = "0x18102E220")]
		public EntityPlayStreamEvent()
		{
			((EntityPlayStreamEvent<T>)(object)this)._002Ector();
		}
	}
}
