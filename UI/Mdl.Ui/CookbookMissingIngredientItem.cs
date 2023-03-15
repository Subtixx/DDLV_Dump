using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000373")]
	[RequiredAllNotNull]
	public class CookbookMissingIngredientItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010C4")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.Token(Token = "0x6001615")]
		[Cpp2IlInjected.Address(RVA = "0x14A5A90", Offset = "0x14A4490", VA = "0x1814A5A90")]
		public void RefreshDisplay(Item item)
		{
			//Discarded unreachable code: IL_000e
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			AsyncAtlassedIcon mcIcon = _mcIcon;
		}

		[Cpp2IlInjected.Token(Token = "0x6001616")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CookbookMissingIngredientItem()
		{
		}
	}
}
