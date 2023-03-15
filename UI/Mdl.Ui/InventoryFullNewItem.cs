using System;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20005D5")]
	public class InventoryFullNewItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002070")]
		[SerializeField]
		private AsyncAtlassedIcon _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002071")]
		[SerializeField]
		private GameObject _newLabelHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002072")]
		[SerializeField]
		private Vector2 _firstItemScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002073")]
		[SerializeField]
		private Vector2 _itemScale;

		[Cpp2IlInjected.Token(Token = "0x6002646")]
		[Cpp2IlInjected.Address(RVA = "0xD2C580", Offset = "0xD2AF80", VA = "0x180D2C580")]
		public void Init(int index, ItemInstance itemInstance)
		{
			//Discarded unreachable code: IL_004e
			Item item = itemInstance.Item;
			bool flag = default(bool);
			if (flag)
			{
				AsyncAtlassedIcon icon = _icon;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item2 = itemInstance.Item;
			}
			GameObject newLabelHolder = _newLabelHolder;
			bool active = index == 0;
			newLabelHolder.SetActive(active);
			Transform transform = base.transform;
			if ((object)transform != null)
			{
			}
			if (index == 0 && (object)transform == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002647")]
		[Cpp2IlInjected.Address(RVA = "0xD2C7A0", Offset = "0xD2B1A0", VA = "0x180D2C7A0")]
		public unsafe InventoryFullNewItem()
		{
			//IL_001b: Expected F4, but got I4
			//IL_0016: Expected native int or pointer, but got O
			//IL_0028: Expected O, but got I8
			//IL_0033: Expected native int or pointer, but got O
			int num = 0;
			_firstItemScale = Vector2.one;
			((Vector2*)(IntPtr)_firstItemScale)->y = 0f;
			_itemScale = (Vector2)1061997773;
			((Vector2*)(IntPtr)_itemScale)->y = 0.8f;
			base._002Ector();
		}
	}
}
