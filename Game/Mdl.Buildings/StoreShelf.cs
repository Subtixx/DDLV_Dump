using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions;
using Definitions.Displays;
using Definitions.Items;
using Google.Protobuf.Collections;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009D4")]
	public class StoreShelf : StoreDisplay
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003652")]
		[SerializeField]
		private Transform[] _slotPositions;

		[Cpp2IlInjected.Token(Token = "0x17000698")]
		public Transform[] SlotPositions
		{
			[Cpp2IlInjected.Token(Token = "0x6002DF9")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			get
			{
				return _slotPositions;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002DFA")]
		[Cpp2IlInjected.Address(RVA = "0x105D140", Offset = "0x105BB40", VA = "0x18105D140", Slot = "10")]
		protected unsafe override List<SlotTransform> GetSlotTransforms(DisplayInfo displayInfo)
		{
			//IL_00a3: Expected native int or pointer, but got O
			//IL_00ef: Expected O, but got I4
			//IL_00ef: Expected O, but got I4
			//IL_00ef: Expected O, but got I4
			if (_slotPositions.Length != 0)
			{
				int count = ((RepeatedField<T>)(object)displayInfo.slots_).Count;
				List<SlotTransform> list = (List<SlotTransform>)(object)new List<T>();
				int num = 0;
				int num2 = 0;
				int count2 = ((RepeatedField<T>)(object)displayInfo.slots_).Count;
				if (num2 < count2)
				{
					Transform transform = _slotPositions[num];
					DisplaySlot displaySlot = (DisplaySlot)((RepeatedField<T>)(object)displayInfo.slots_)[num];
					ItemAmount item_ = displaySlot.item_;
					if (item_ != null)
					{
						Item item = item_.Item;
						ItemType itemType = default(ItemType);
						if (itemType == ItemType.Clothing)
						{
							Item item2 = displaySlot.item_.Item;
							ClothingItemType clothingItemType = default(ClothingItemType);
							if (clothingItemType != ClothingItemType.AccBack)
							{
							}
						}
					}
					SlotTransform slotTransform = new SlotTransform();
					Vector3 vector = default(Vector3);
					float z = vector.z;
					((Vector3*)(IntPtr)slotTransform.Position)->z = z;
					Vector3 up = Vector3.up;
					((List<T>)(object)list).Add((T)slotTransform);
					num++;
				}
				return list;
			}
			int length = _slotPositions.Length;
			int count3 = ((RepeatedField<T>)(object)displayInfo.slots_).Count;
			IItemData itemData = ((Display)this).ItemData;
			Debug.LogError($"StoreShelf/GetSlotTransforms => number of available Slot Positions ({length}) must be greater or equal to the number of items to spawn ({count3}) for display '{count3}'. Failed to initialize display slots.");
			List<SlotTransform> list2 = (List<SlotTransform>)(object)new List<T>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002DFB")]
		[Cpp2IlInjected.Address(RVA = "0x105D5A0", Offset = "0x105BFA0", VA = "0x18105D5A0")]
		public StoreShelf()
		{
		}
	}
}
