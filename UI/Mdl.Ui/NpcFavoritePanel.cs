using System;
using Cpp2IlInjected;
using Definitions.Items;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000526")]
	public class NpcFavoritePanel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001BC6")]
		[SerializeField]
		private NpcFavoriteItem _favoriteItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001BC7")]
		[SerializeField]
		private RectTransform _mcItemsContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001BC8")]
		public bool Darken;

		[Cpp2IlInjected.Token(Token = "0x6002183")]
		[Cpp2IlInjected.Address(RVA = "0x12A02D0", Offset = "0x129ECD0", VA = "0x1812A02D0")]
		internal void RefreshDisplay(Character character)
		{
			//Discarded unreachable code: IL_0060, IL_0072
			int num = 0;
			GameObject gameObject = default(GameObject);
			if (_mcItemsContent.GetEnumerator() != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num += 328;
				int num3 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				if (num == 0)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			int num5 = 0;
			if ((object)gameObject != null)
			{
				int num6 = 0;
			}
			int num7 = default(int);
			if (num5 < num7)
			{
				Item item = default(Item);
				int itemID = item.ItemID;
				NpcFavoriteItem npcFavoriteItem = default(NpcFavoriteItem);
				npcFavoriteItem.Darken = false;
				num5++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002184")]
		[Cpp2IlInjected.Address(RVA = "0x12A0240", Offset = "0x129EC40", VA = "0x1812A0240")]
		internal void Animate(int preferredIndex, PreferredItemStatus newStatus)
		{
			//Discarded unreachable code: IL_001b
			Transform child = _mcItemsContent.GetChild(preferredIndex);
			if ((object)child != null && (object)child.GetComponent<NpcFavoriteItem>() == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002185")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public NpcFavoritePanel()
		{
		}
	}
}
