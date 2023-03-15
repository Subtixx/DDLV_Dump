using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Meta;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000473")]
	public class MiniEventMenuModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400169D")]
		public List<MiniEventMilestoneModel> MilestoneModels = (List<MiniEventMilestoneModel>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x170004B3")]
		public MiniEventData MiniEventData
		{
			[Cpp2IlInjected.Token(Token = "0x6001CAC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CMiniEventData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CAD")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CMiniEventData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B4")]
		public MiniEventProgress MiniEventProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6001CAE")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CMiniEventProgress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CAF")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CMiniEventProgress_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B5")]
		public Dictionary<TextType, string> TextDict
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CTextDict_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CB1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CTextDict_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<TextType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x170004B6")]
		public Dictionary<SpriteType, string> ImageAddressDict
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CImageAddressDict_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CB3")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CImageAddressDict_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<SpriteType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x170004B7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x4001698")]
		public int CurrentMilestone
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB4")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CB5")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004B8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x4001699")]
		public int TotalMilestone
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB6")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CB7")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004B9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x400169A")]
		public int CollectedCurrencyAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB8")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CB9")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004BA")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x400169B")]
		public TimeSpan TimeLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6001CBA")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CBB")]
			[Cpp2IlInjected.Address(RVA = "0xA62710", Offset = "0xA61110", VA = "0x180A62710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004BB")]
		public IItemData EventCurrencyItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001CBC")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CEventCurrencyItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CBD")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			set
			{
				_003CEventCurrencyItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBE")]
		[Cpp2IlInjected.Address(RVA = "0x1290AF0", Offset = "0x128F4F0", VA = "0x181290AF0")]
		public void RefreshData()
		{
			//Discarded unreachable code: IL_001b, IL_002e, IL_0034, IL_003a, IL_0048, IL_005d, IL_0063, IL_0069, IL_00ad, IL_00c2, IL_00c8, IL_00ce, IL_00dc, IL_00f1, IL_00f7, IL_00fd, IL_010a, IL_012a, IL_012f, IL_0134, IL_017b, IL_0189, IL_0196, IL_019c, IL_01a2, IL_01b0, IL_01c0, IL_01de, IL_01f2, IL_020f, IL_028a, IL_0290, IL_02a5, IL_02c4, IL_02e8, IL_02e9, IL_02ef
			//IL_01cc: Expected O, but got I4
			//IL_0220: Expected I4, but got I8
			//IL_0259: Expected O, but got I4
			int num = 0;
			if ((IntPtr)MiniEventData != (IntPtr)num)
			{
				Dictionary<TextType, string> dictionary = TextDict;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBF")]
		[Cpp2IlInjected.Address(RVA = "0x1291510", Offset = "0x128FF10", VA = "0x181291510")]
		public MiniEventMenuModel()
		{
		}
	}
}
