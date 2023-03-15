using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000326")]
	public class CollectionTooltipHangoutBuffElementModel : CollectionTooltipProfessionElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x6001426")]
		[Cpp2IlInjected.Address(RVA = "0x114C0C0", Offset = "0x114AAC0", VA = "0x18114C0C0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_0090, IL_00c2, IL_00f3, IL_0106, IL_010d, IL_010e
			//IL_00b0: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			ProfessionItemData professionItemData = base.ProfessionItemData;
			if (professionItemData == null)
			{
				IItemData itemData = ((CollectionTooltipElementModel)this).ItemData;
				ProfessionItemData professionItemData2 = default(ProfessionItemData);
				base.ProfessionItemData = professionItemData2;
			}
			RepeatedField<ProfessionItemData.Types.HangoutBuffData> hangoutBuffs_ = professionItemData.hangoutBuffs_;
			Dictionary<TextType, string> dictionary2 = default(Dictionary<TextType, string>);
			if (hangoutBuffs_ != null && ((RepeatedField<T>)(object)hangoutBuffs_).Count > 0)
			{
				int num = 0;
				Dictionary<SpriteType, string> dictionary = default(Dictionary<SpriteType, string>);
				if (Application.isPlaying)
				{
					dictionary = ((CollectionTooltipElementModel)this).Sprites;
					Client client = default(Client);
					Profile profile = client.profile;
					ProfilePlayer player_ = profile.player_;
					WeedController weedController_ = profile.weedController_;
					int num2 = 0;
					ProfessionItemData.Types.HangoutBuffData hangoutBuffData = default(ProfessionItemData.Types.HangoutBuffData);
					BuffType buffType_ = hangoutBuffData.buffType_;
					BuffDisplayData staticBuffData = player_.GetStaticBuffData(BuffOrigin.Hangout, buffType_);
					throw new NullReferenceException();
				}
				dictionary2 = ((CollectionTooltipElementModel)this).Texts;
				IEqualityComparer<> comparer = (IEqualityComparer<>)((Dictionary<, >)(object)dictionary).comparer;
				throw new NullReferenceException();
			}
			int[] buckets = ((Dictionary<, >)(object)dictionary2).buckets;
			int num3 = 0;
			string text = LocalizationManager.FromStringID("collection.label_unlock_at_friendship", (IResolver)num3) + " 2";
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001427")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipHangoutBuffElementModel()
		{
		}
	}
}
