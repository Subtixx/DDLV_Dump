using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200068E")]
	public class QuestLogReward : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024DA")]
		[SerializeField]
		private AsyncAtlassedIcon _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024DB")]
		[SerializeField]
		private GameObject _friendshipIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024DC")]
		[SerializeField]
		private TextBase _countText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024DD")]
		[SerializeField]
		private GameObject _countContainer;

		[Cpp2IlInjected.Token(Token = "0x6002A55")]
		[Cpp2IlInjected.Address(RVA = "0xF31CB0", Offset = "0xF306B0", VA = "0x180F31CB0")]
		public void Init(AnyReward reward)
		{
			//Discarded unreachable code: IL_00b6, IL_00ce, IL_00d7, IL_00ef, IL_0100, IL_0105
			//IL_0094: Expected O, but got I4
			if (reward == null)
			{
				return;
			}
			GameObject countContainer = _countContainer;
			bool active = reward.rewardCase_ != AnyReward.RewardOneofCase.CharacterUnlock;
			countContainer.SetActive(active);
			GameObject gameObject = _icon.gameObject;
			bool active2 = reward.rewardCase_ != AnyReward.RewardOneofCase.Friendship;
			gameObject.SetActive(active2);
			GameObject friendshipIcon = _friendshipIcon;
			bool active3 = reward.rewardCase_ == AnyReward.RewardOneofCase.Friendship;
			friendshipIcon.SetActive(active3);
			if (reward.rewardCase_ <= AnyReward.RewardOneofCase.Null)
			{
				TextBase countText = _countText;
				ItemReward item = reward.Item;
				int num = 0;
				if (item != null)
				{
					int amount_ = item.amount_;
				}
				string text2 = (countText.Text = $"x{num}");
				AsyncAtlassedIcon icon = _icon;
				if (reward.Item != null)
				{
				}
				IItemData itemData = default(IItemData);
				if (itemData == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A56")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public QuestLogReward()
		{
		}
	}
}
