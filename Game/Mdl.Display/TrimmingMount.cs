using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Display
{
	[Cpp2IlInjected.Token(Token = "0x2000821")]
	public class TrimmingMount : ItemSupport
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D5F")]
		[SerializeField]
		private TrimmingMountSetter trimmingSetter;

		[Cpp2IlInjected.Token(Token = "0x6002474")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "6")]
		public override bool HasOffsetFromRoot(Item attachedItem)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002475")]
		[Cpp2IlInjected.Address(RVA = "0x13E02F0", Offset = "0x13DECF0", VA = "0x1813E02F0", Slot = "7")]
		public override Renderer GetVisualRenderer()
		{
			return GetComponentInChildren<Renderer>();
		}

		[Cpp2IlInjected.Token(Token = "0x6002476")]
		[Cpp2IlInjected.Address(RVA = "0x13E00E0", Offset = "0x13DEAE0", VA = "0x1813E00E0", Slot = "5")]
		protected override Task DoAttachObject(GameObject objToAttach)
		{
			//Discarded unreachable code: IL_0066
			Transform transform = objToAttach.transform;
			Transform transform3 = (transform.parent = base.gameObject.transform);
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = base.Item;
			IItemData itemData = default(IItemData);
			if (itemData != null)
			{
				Item item2 = base.Item;
				ItemType itemType = default(ItemType);
				if (itemType == ItemType.Trimming)
				{
					TrimmingMountSetter trimmingMountSetter = trimmingSetter;
					Item item3 = base.Item;
					TrimmingItemType _003CTrimmingItemType_003Ek__BackingField = default(TrimmingItemType);
					trimmingMountSetter.TrimmingItemType = _003CTrimmingItemType_003Ek__BackingField;
					trimmingMountSetter.TrimmingItem = item3;
				}
			}
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6002477")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public TrimmingMount()
		{
		}
	}
}
