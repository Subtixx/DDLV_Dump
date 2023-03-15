using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200031B")]
	public class CollectionTooltipMemoryShardsElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000371")]
		public MemoryShardItemData MemoryShardItemData
		{
			[Cpp2IlInjected.Token(Token = "0x60013FE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CMemoryShardItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60013FF")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				_003CMemoryShardItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000372")]
		public CollectionTooltipMemoryShards tooltipView
		{
			[Cpp2IlInjected.Token(Token = "0x6001400")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CtooltipView_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001401")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CtooltipView_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001402")]
		[Cpp2IlInjected.Address(RVA = "0x114CA30", Offset = "0x114B430", VA = "0x18114CA30", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_016f, IL_01dd, IL_01f7
			//IL_009e: Expected O, but got I4
			//IL_00f4: Expected O, but got I4
			//IL_0120: Expected O, but got I4
			//IL_01ac: Expected O, but got I4
			//IL_01d5: Expected O, but got I4
			//IL_01f1: Expected O, but got I4
			//IL_0209: Expected I4, but got I8
			int num = 0;
			if ((IntPtr)MemoryShardItemData == (IntPtr)num)
			{
				IItemData itemData = base.ItemData;
				MemoryShardItemData memoryShardItemData = default(MemoryShardItemData);
				MemoryShardItemData = memoryShardItemData;
			}
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			if (((RepeatedField<T>)(object)MemoryShardItemData.shards_).Count <= 0)
			{
				return;
			}
			MemoryShardItemData memoryShardItemData2 = MemoryShardItemData;
			ProfilePlayer player_ = profile.player_;
			int iD = memoryShardItemData2.ID;
			bool flag = default(bool);
			if (!flag)
			{
				RewardAppearanceCondition appearanceCondition_ = ((MemoryShardItemData.Types.ShardData)((RepeatedField<T>)(object)MemoryShardItemData.shards_)[num]).appearanceCondition_;
				if (appearanceCondition_ == RewardAppearanceCondition.Anywhere || appearanceCondition_ == RewardAppearanceCondition.Custom)
				{
					CollectionTooltipMemoryShards collectionTooltipMemoryShards = tooltipView;
					int num2 = 0;
					if (collectionTooltipMemoryShards != (UnityEngine.Object)num2)
					{
						GameObject icon = tooltipView.Icon;
						int active = 0;
						icon.SetActive((byte)active != 0);
						tooltipView.Layout.childAlignment = TextAnchor.MiddleCenter;
						TextMeshProUGUI textComponent = tooltipView.Label.TextComponent;
					}
					Dictionary<TextType, string> dictionary = base.Texts;
					int num3 = 0;
					string text = LocalizationManager.FromStringID("collection.by_progressing", (IResolver)num3);
					throw new NullReferenceException();
				}
				RewardAppearanceCondition appearanceCondition_2 = ((MemoryShardItemData.Types.ShardData)((RepeatedField<T>)(object)MemoryShardItemData.shards_)[num]).appearanceCondition_;
				string text2 = ((Enum)appearanceCondition_2).ToString();
				RewardAppearanceCondition rewardAppearanceCondition = appearanceCondition_2;
				string conditionName = text2.ToLower();
				Dictionary<SpriteType, string> dictionary2 = base.Sprites;
				AssetAddress[] assetAddresses = view.AssetAddresses;
				Func<AssetAddress, bool> func = (Func<AssetAddress, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0009
					string text3 = conditionName;
					bool result = default(bool);
					return result;
				};
				int num4 = MoreLinq.FindIndex<AssetAddress>((IEnumerable<>)(object)assetAddresses, (Func<, >)(object)func);
				num4 += num4;
				throw new NullReferenceException();
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001403")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipMemoryShardsElementModel()
		{
		}
	}
}
