using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000616")]
	public class MailRewardItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40021D8")]
		[SerializeField]
		private AsyncAtlassedIcon _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40021D9")]
		[SerializeField]
		private GameObject _friendshipIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40021DA")]
		[SerializeField]
		private TextBase _countText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40021DB")]
		[SerializeField]
		private GameObject _countContainer;

		[Cpp2IlInjected.Token(Token = "0x60027CD")]
		[Cpp2IlInjected.Address(RVA = "0xF9F470", Offset = "0xF9DE70", VA = "0x180F9F470")]
		public void Init(InboxItemReward reward)
		{
			//Discarded unreachable code: IL_0076
			//IL_001d: Expected O, but got I4
			if (reward == null)
			{
				return;
			}
			int amount_ = reward.amount_;
			TextBase countText = _countText;
			string text2 = (countText.Text = $"x{amount_}");
			GameObject countContainer = _countContainer;
			bool active = reward.amount_ > 1;
			countContainer.SetActive(active);
			int id_ = reward.id_;
			bool flag = default(bool);
			if (!flag)
			{
				Debug.Log("[Mailbox Debug] Message Reward Item Is Invalid");
				return;
			}
			string text3 = default(string);
			Debug.Log("[Mailbox Debug] Message Reward ID " + text3);
			AsyncAtlassedIcon icon = _icon;
			IItemData itemData = default(IItemData);
			if (itemData == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027CE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MailRewardItem()
		{
		}
	}
}
