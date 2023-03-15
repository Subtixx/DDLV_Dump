using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200037B")]
	[RequiredAllNotNull]
	public class CookingHistoryIngredientItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010DC")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40010DD")]
		[SerializeField]
		private SpriteAtlasImage _backgroundType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40010DE")]
		[SerializeField]
		private Color _backgroundTypeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40010DF")]
		[SerializeField]
		private Color _backgroundTypeEmptyColor;

		[Cpp2IlInjected.Token(Token = "0x6001640")]
		[Cpp2IlInjected.Address(RVA = "0x14A7CA0", Offset = "0x14A66A0", VA = "0x1814A7CA0")]
		internal void Init(Item ingredient, Sprite bgTypeSprite)
		{
			//Discarded unreachable code: IL_008b
			SpriteAtlasImage backgroundType = _backgroundType;
			string text2 = (backgroundType.ImageAddress = bgTypeSprite.name);
			AsyncAtlassedIcon mcIcon = _mcIcon;
			if (text2 == null)
			{
				mcIcon.gameObject.SetActive(value: true);
				Image image = _backgroundType.Image;
				Color color = (image.color = _backgroundTypeColor);
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				AsyncAtlassedIcon mcIcon2 = _mcIcon;
			}
			else
			{
				GameObject gameObject = mcIcon.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				Image image2 = _backgroundType.Image;
				Color color2 = (image2.color = _backgroundTypeEmptyColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001641")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CookingHistoryIngredientItem()
		{
		}
	}
}
