using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000216")]
	public class FriendshipProgressRewardItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400093A")]
		[SerializeField]
		private AsyncImage _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400093B")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0x166E110", Offset = "0x166CB10", VA = "0x18166E110")]
		public void RefreshData(ItemReward rewardData)
		{
			//Discarded unreachable code: IL_009b
			//IL_001f: Expected O, but got I4
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			AsyncImage icon = _icon;
			TextBase tfAmount = _tfAmount;
			int num = 0;
			if (tfAmount != (Object)num)
			{
				_tfAmount.TextComponent.autoSizeTextContainer = true;
				string text = default(string);
				_tfAmount.Text = text;
				TextMeshProUGUI textComponent = _tfAmount.TextComponent;
				int forceTextReparsing = 0;
				int ignoreActiveState = 0;
				textComponent.ForceMeshUpdate((byte)ignoreActiveState != 0, (byte)forceTextReparsing != 0);
				TextBase tfAmount2 = _tfAmount;
				RectTransform rectTransform = tfAmount2.RectTransform;
				TextMeshProUGUI textComponent2 = tfAmount2.TextComponent;
				Vector2 sizeDelta = _tfAmount.RectTransform.sizeDelta;
				_tfAmount.RectTransform.ForceUpdateRectTransforms();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FriendshipProgressRewardItem()
		{
		}
	}
}
