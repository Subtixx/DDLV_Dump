using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200056E")]
	public class BackpackItemInfo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001DA5")]
		[SerializeField]
		private TextBase _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001DA6")]
		[SerializeField]
		private StarComponent _stars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001DA7")]
		[SerializeField]
		private TextBase _description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001DA8")]
		[SerializeField]
		private GameObject _giftInfoItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001DA9")]
		[SerializeField]
		private GameObject _eatInfoItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001DAA")]
		[SerializeField]
		private GameObject _sellInfoItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001DAB")]
		[SerializeField]
		private GameObject _questsInfoItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001DAC")]
		[SerializeField]
		private CurrencyItemView _giftCurrencyItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001DAD")]
		[SerializeField]
		private CurrencyItemView _eatCurrencyItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001DAE")]
		[SerializeField]
		private CurrencyItemView _sellCurrencyItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4001DAF")]
		[SerializeField]
		private QuestFilterItem[] _questItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4001DB0")]
		[SerializeField]
		private HorizontalLayoutGroup _bonusAndQuests;

		[Cpp2IlInjected.Token(Token = "0x6002390")]
		[Cpp2IlInjected.Address(RVA = "0xA5ADE0", Offset = "0xA597E0", VA = "0x180A5ADE0")]
		public unsafe void Refresh(Item item, ItemState state, int amount, bool canSell, int stars)
		{
			//Discarded unreachable code: IL_01e9
			//IL_008b: Expected I4, but got I8
			//IL_00a6: Expected I4, but got I8
			int num = 0;
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			TextBase title = _title;
			StarComponent stars2 = _stars;
			TextBase description = _description;
			IBackpackItem backpackItem = default(IBackpackItem);
			IItemData itemData = default(IItemData);
			if (backpackItem == null || itemData == null)
			{
			}
			description.StringID = "";
			GameObject giftInfoItem = _giftInfoItem;
			int active = 0;
			giftInfoItem.SetActive((byte)active != 0);
			GameObject eatInfoItem = _eatInfoItem;
			int active2 = 0;
			eatInfoItem.SetActive((byte)active2 != 0);
			ItemType itemType = default(ItemType);
			bool flag = default(bool);
			if (itemType == ItemType.ActivityItem && flag)
			{
				ulong num2 = default(ulong);
				_eatInfoItem.SetActive((byte)num2 != 0);
				CurrencyItemView eatCurrencyItem = _eatCurrencyItem;
				Item invalid = Item.Invalid;
				ulong num3 = default(ulong);
				eatCurrencyItem.RefreshData(invalid, num, (byte)num3 != 0);
			}
			bool flag2 = default(bool);
			bool flag3 = !flag2;
			_sellInfoItem.SetActive(flag3);
			if (flag3)
			{
				ProfilePlayer player_ = profile.player_;
				int isReduction = 0;
				int num4 = default(int);
				player_.ApplyBuff(BuffType.SoftCurrencyMultiplier, ref *(int*)num4, (byte)isReduction != 0, num);
				CurrencyItemView sellCurrencyItem = _sellCurrencyItem;
				int num5 = 0;
				Item softCurrencyItem = CurrencyItem.SoftCurrencyItem;
			}
			ProfileWorld world_ = profile.world_;
			IEnumerable<ProfileWorld.FilterInfo> enumerable = default(IEnumerable<ProfileWorld.FilterInfo>);
			if (enumerable != null)
			{
				GameObject questsInfoItem = _questsInfoItem;
				bool active3 = Enumerable.Any<ProfileWorld.FilterInfo>((IEnumerable<>)enumerable);
				questsInfoItem.SetActive(active3);
				HorizontalLayoutGroup bonusAndQuests = _bonusAndQuests;
				bool flag4 = Enumerable.Any<ProfileWorld.FilterInfo>((IEnumerable<>)enumerable);
				if (Enumerable.Any<ProfileWorld.FilterInfo>((IEnumerable<>)enumerable))
				{
					QuestFilterItem[] questItems = _questItems;
					if (num < questItems.Length)
					{
						ProfileWorld.FilterInfo filterInfo = Enumerable.ElementAtOrDefault<ProfileWorld.FilterInfo>((IEnumerable<>)enumerable, num);
						GameObject gameObject = _questItems[num].gameObject;
						bool active4 = filterInfo != null;
						gameObject.SetActive(active4);
						if (filterInfo != null)
						{
							_questItems[num].Init(filterInfo);
						}
						QuestFilterItem[] questItems2 = _questItems;
						num++;
					}
				}
			}
			_eatInfoItem.transform.RebuildLayout();
			_sellInfoItem.transform.RebuildLayout();
			_giftInfoItem.transform.RebuildLayout();
			_eatInfoItem.transform.parent.RebuildLayout();
			if ((object)_bonusAndQuests.transform == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002391")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD00", Offset = "0xA59700", VA = "0x180A5AD00")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0085
			TextBase description = _description;
			TextBase title = _title;
			description.StringID = "";
			title.StringID = "";
			GameObject giftInfoItem = _giftInfoItem;
			int active = 0;
			giftInfoItem.SetActive((byte)active != 0);
			GameObject eatInfoItem = _eatInfoItem;
			int active2 = 0;
			eatInfoItem.SetActive((byte)active2 != 0);
			GameObject sellInfoItem = _sellInfoItem;
			int active3 = 0;
			sellInfoItem.SetActive((byte)active3 != 0);
			GameObject questsInfoItem = _questsInfoItem;
			int active4 = 0;
			questsInfoItem.SetActive((byte)active4 != 0);
			StarComponent stars = _stars;
			int num2 = (stars.Star = 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002392")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public BackpackItemInfo()
		{
		}
	}
}
