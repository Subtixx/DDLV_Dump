using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000316")]
	public class CollectionTooltipCropModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000367")]
		public CropItemData CropItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60013E0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CCropItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013E1")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CCropItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000368")]
		public SeedItemData SeedItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60013E2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CSeedItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013E3")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CSeedItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000369")]
		public List<VillageAreaType> Areas
		{
			[Cpp2IlInjected.Token(Token = "0x60013E4")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CAreas_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013E5")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CAreas_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013E6")]
		[Cpp2IlInjected.Address(RVA = "0x1149C90", Offset = "0x1148690", VA = "0x181149C90")]
		public unsafe static bool GetVillageAreas(CropItemData cropItemData, SeedItemData seedItemData, out List<VillageAreaType> areas)
		{
			//Discarded unreachable code: IL_005a
			//IL_0028: Expected O, but got I4
			//IL_004f: Expected O, but got Ref
			if (cropItemData.cropType_ != 0)
			{
				if (!seedItemData.hasGrowthBoost_)
				{
					int num = 0;
				}
				List<VillageAreaType> list = (List<VillageAreaType>)(object)new List<T>();
				VillageAreaType villageArea_ = seedItemData.villageArea_;
				((List<T>)(object)list).Add((T)villageArea_);
			}
			List<VillageAreaType> list2 = (List<VillageAreaType>)(object)(((List<>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref areas))._items = (T[])(object)Enumerable.ToList<VillageAreaType>(SystemRoot.Instance.MetaClient.profile.world_.GetFruitTreeAreas(cropItemData)));
			return (long)"{il2cpp field on {'constant40' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x18}" > 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60013E7")]
		[Cpp2IlInjected.Address(RVA = "0x1149E80", Offset = "0x1148880", VA = "0x181149E80", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_008d, IL_00ae, IL_0152
			//IL_00a6: Expected O, but got I4
			//IL_00d5: Expected F4, but got I4
			CropItemData cropItemData = CropItemData;
			if (cropItemData != null && (long)SeedItemData != 0 && (long)Areas != 0)
			{
				int num = 0;
				int num2 = 0;
				string text = "collection.label_where_to_find";
				if (cropItemData.cropType_ == CropType.Vegetable)
				{
					text = "collection.label_where_to_buy";
				}
				List<ActivityDataLocationFilter> list = (List<ActivityDataLocationFilter>)(object)AreaResolver.Resolver((List<>)(object)Areas);
				List<VillageAreaType> list2 = Areas;
				GameObject gameObject = default(GameObject);
				bool active = default(bool);
				gameObject.SetActive(active);
				List<VillageAreaType> list3 = Areas;
				bool active2 = default(bool);
				gameObject.SetActive(active2);
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				int producedAmount_ = SeedItemData.producedAmount_;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013E8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipCropModel()
		{
		}
	}
}
