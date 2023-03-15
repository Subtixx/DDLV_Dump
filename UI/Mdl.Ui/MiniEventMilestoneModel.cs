using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Meta;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000477")]
	public class MiniEventMilestoneModel
	{
		[Cpp2IlInjected.Token(Token = "0x170004BE")]
		public MiniEventProgress MiniEventProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6001CDD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CMiniEventProgress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CDE")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CMiniEventProgress_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BF")]
		public MiniEventData MiniEventData
		{
			[Cpp2IlInjected.Token(Token = "0x6001CDF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CMiniEventData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CE0")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CMiniEventData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C0")]
		public MiniEventMilestoneData MiniEventMilestoneData
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CMiniEventMilestoneData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CE2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CMiniEventMilestoneData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004C1")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x40016AB")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE3")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CE4")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004C2")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x40016AC")]
		public MilestoneState MilestoneState
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE5")]
			[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CE6")]
			[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004C3")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40016AD")]
		public int TargetAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE7")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CE8")]
			[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
			set;
		} = 1;


		[Cpp2IlInjected.Token(Token = "0x170004C4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x40016AE")]
		public int CurrentAmount
		{
			[Cpp2IlInjected.Token(Token = "0x6001CE9")]
			[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001CEA")]
			[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170004C5")]
		public Dictionary<TextType, string> TextDict
		{
			[Cpp2IlInjected.Token(Token = "0x6001CEB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CTextDict_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CEC")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CTextDict_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<TextType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x170004C6")]
		public Dictionary<SpriteType, string> ImageAddressDict
		{
			[Cpp2IlInjected.Token(Token = "0x6001CED")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CImageAddressDict_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CEE")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CImageAddressDict_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<SpriteType, string>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x6001CEF")]
		[Cpp2IlInjected.Address(RVA = "0x12926B0", Offset = "0x12910B0", VA = "0x1812926B0")]
		public void RefreshData()
		{
			//Discarded unreachable code: IL_0021, IL_0034, IL_003a, IL_0040, IL_004e, IL_0063, IL_0072, IL_0078, IL_008d, IL_00b2, IL_00da, IL_00df, IL_00ed, IL_0112, IL_011f, IL_0125, IL_012b, IL_0139, IL_0146, IL_014c, IL_01b4, IL_01c9, IL_01e7, IL_01e8, IL_0206, IL_0207
			if ((long)MiniEventMilestoneData != 0)
			{
				Dictionary<TextType, string> dictionary = TextDict;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				throw new NullReferenceException();
			}
			MiniEventProgress miniEventProgress = MiniEventProgress;
			if (miniEventProgress != null)
			{
				int num = (TargetAmount = miniEventProgress.currentObjective_.targetAmount_);
				int curAmount_ = miniEventProgress.currentObjective_.curAmount_;
				int index = Index;
				CurrentAmount = curAmount_;
				MilestoneState milestoneState = (MilestoneState = miniEventProgress.GetState(index));
			}
			Dictionary<TextType, string> dictionary2 = TextDict;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CF0")]
		[Cpp2IlInjected.Address(RVA = "0x1292C70", Offset = "0x1291670", VA = "0x181292C70")]
		public MiniEventMilestoneModel()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
