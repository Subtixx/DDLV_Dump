using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Rewards;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004FF")]
	public class PresentItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001AF2")]
		[SerializeField]
		private AsyncAtlassedIcon _mcImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001AF3")]
		[SerializeField]
		private TextBase _tfAmount;

		[Cpp2IlInjected.Token(Token = "0x600208A")]
		[Cpp2IlInjected.Address(RVA = "0xE19870", Offset = "0xE18270", VA = "0x180E19870")]
		public void RefreshData(ItemReward reward, bool useCharacterIcon = false)
		{
			//Discarded unreachable code: IL_0022
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = reward.Item;
			AsyncAtlassedIcon mcImage = _mcImage;
			string text = default(string);
			_tfAmount.Text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x600208B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PresentItem()
		{
		}
	}
}
