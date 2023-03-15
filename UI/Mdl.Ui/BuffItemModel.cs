using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Campaign;
using Mdl.Systems;
using Meta;
using Meta.Online;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000570")]
	internal class BuffItemModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DBA")]
		public TimeSpan TimeLeft;

		[Cpp2IlInjected.Token(Token = "0x17000584")]
		public MicroEventData MicroEventData
		{
			[Cpp2IlInjected.Token(Token = "0x600239C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CMicroEventData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600239D")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CMicroEventData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000585")]
		public CampaignData CampaignData
		{
			[Cpp2IlInjected.Token(Token = "0x600239E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCampaignData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600239F")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCampaignData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000586")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4001DB8")]
		public int BuffPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x60023A0")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60023A1")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000587")]
		public BuffDisplayData BuffDisplayData
		{
			[Cpp2IlInjected.Token(Token = "0x60023A2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CBuffDisplayData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60023A3")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CBuffDisplayData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000588")]
		public Dictionary<TextType, string> TextDict
		{
			[Cpp2IlInjected.Token(Token = "0x60023A4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CTextDict_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60023A5")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CTextDict_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<TextType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x17000589")]
		public Dictionary<SpriteType, string> ImageAddressDict
		{
			[Cpp2IlInjected.Token(Token = "0x60023A6")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CImageAddressDict_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60023A7")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CImageAddressDict_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<SpriteType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x60023A8")]
		[Cpp2IlInjected.Address(RVA = "0xA66450", Offset = "0xA64E50", VA = "0x180A66450")]
		public BuffItemModel(MicroEventData microEventData, [Optional] CampaignData campaignData)
		{
			MicroEventData = microEventData;
			CampaignData = campaignData;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023A9")]
		[Cpp2IlInjected.Address(RVA = "0xA66550", Offset = "0xA64F50", VA = "0x180A66550")]
		public BuffItemModel(int buffPercentage, BuffDisplayData buffDisplayData)
		{
			BuffDisplayData = buffDisplayData;
			BuffPercentage = buffPercentage;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60023AA")]
		[Cpp2IlInjected.Address(RVA = "0xA65D70", Offset = "0xA64770", VA = "0x180A65D70")]
		public void RefreshData()
		{
			//Discarded unreachable code: IL_001b, IL_002d, IL_0033, IL_0039, IL_0047, IL_005c, IL_006b, IL_0071, IL_007f, IL_0094, IL_00a3, IL_00a9, IL_00b7, IL_00cc, IL_00db, IL_015d, IL_0172, IL_0181, IL_0187, IL_0195, IL_01aa, IL_01b9, IL_01bf, IL_01cd, IL_01e2, IL_01f6, IL_020a, IL_0218, IL_022d, IL_023c, IL_0242, IL_0252
			if ((long)MicroEventData != 0)
			{
				Dictionary<TextType, string> dictionary = TextDict;
				throw new NullReferenceException();
			}
			CampaignData campaignData = CampaignData;
			if (campaignData != null)
			{
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = SystemRoot.Instance.MetaClient.TransactionContext;
				DateTime dateTime = campaignData.EndDate(profile, _003CTransactionContext_003Ek__BackingField);
				DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
				TimeSpan timeSpan = (TimeLeft = dateTime - serverTime);
			}
			if ((long)BuffDisplayData != 0)
			{
				Dictionary<TextType, string> dictionary2 = TextDict;
				throw new NullReferenceException();
			}
		}
	}
}
