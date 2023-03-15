using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Platform.Playstation;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000307")]
	public class CollectionShardsGroup : CollectionItemGroup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000EC0")]
		private bool createWidgets = true;

		[Cpp2IlInjected.Token(Token = "0x60013AB")]
		[Cpp2IlInjected.Address(RVA = "0x1146D00", Offset = "0x1145700", VA = "0x181146D00", Slot = "6")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0046, IL_0050
			createWidgets = true;
			TemplateComponent header = _header;
			int active = 0;
			header.SetActive((byte)active != 0);
			if (base.IsVisible = base.Model.IsFirstGroup)
			{
				UpdateItemView();
			}
			OnRefresh?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60013AC")]
		[Cpp2IlInjected.Address(RVA = "0x1146550", Offset = "0x1144F50", VA = "0x181146550")]
		private void CreateWidgets()
		{
			//Discarded unreachable code: IL_0131, IL_0137, IL_013d, IL_0143, IL_0149, IL_014f, IL_0155, IL_015b, IL_0161, IL_0167, IL_016d, IL_0173, IL_0179
			//IL_00b8: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int childCount = _items.childCount;
			List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField = base.Model.CollectionItemModels;
			int num4 = childCount - 1;
			RectTransform items = _items;
			int index = items.childCount - 1;
			CollectionMemoryShardsItem component = items.GetChild(index).GetComponent<CollectionMemoryShardsItem>();
			component.Dispose();
			RecycleBin recycleBin = RecycleBin;
			GameObject trash = component.gameObject;
			recycleBin.SendToBin(trash);
			List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField2 = base.Model.CollectionItemModels;
			bool flag = default(bool);
			if (flag)
			{
				int childCount2 = _items.childCount;
				RecycleBin recycleBin2 = RecycleBin;
				Type typeFromHandle = typeof(CollectionMemoryShardsItem);
				RectTransform items2 = _items;
				ulong num5 = default(ulong);
				recycleBin2.FindReusableOrNew(typeFromHandle, items2).SetActive((byte)num5 != 0);
				CollectionMemoryShardsItem component2 = _items.GetChild(num3).GetComponent<CollectionMemoryShardsItem>();
				bool flag2 = num3 < 3;
				int size = ((List<>)(object)base.Model.CollectionItemModels)._size;
				component2.FocusNavigationElement.UsetAltLogicForScrolling = true;
				CollectionItemGroupModel collectionItemGroupModel = base.Model;
				List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField3 = collectionItemGroupModel.CollectionItemModels;
				((CollectionItem)component2).Model = (CollectionItemModel)(object)collectionItemGroupModel;
				num3++;
			}
			bool flag3 = default(bool);
			if (flag3)
			{
			}
			Transform transform = default(Transform);
			if ((object)transform != null)
			{
			}
			Transform transform2 = default(Transform);
			Transform parent = transform2.parent;
			if ((object)parent != null)
			{
			}
			if ((object)parent.parent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013AD")]
		[Cpp2IlInjected.Address(RVA = "0x1146D90", Offset = "0x1145790", VA = "0x181146D90", Slot = "7")]
		public override void UpdateItemView()
		{
			//Discarded unreachable code: IL_0089, IL_008f, IL_00a1
			int num = 0;
			if ((createWidgets ? 1 : 0) != num)
			{
				createWidgets = (byte)num != 0;
				CreateWidgets();
			}
			IEnumerator enumerator = _items.GetEnumerator();
			bool isPlaying = default(bool);
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				RectTransform viewPort = ViewPort;
				CollectionMemoryShardsItem collectionMemoryShardsItem = default(CollectionMemoryShardsItem);
				if ((object)collectionMemoryShardsItem.transform != null)
				{
				}
				bool flag = default(bool);
				((CollectionItem)collectionMemoryShardsItem).IsVisible = flag;
				int num5 = 0;
				isPlaying = Application.isPlaying;
				RecycleBin recycleBin = (collectionMemoryShardsItem.RecycleBin = RecycleBin);
				if (!isPlaying)
				{
				}
				collectionMemoryShardsItem.RefreshDisplay();
			}
			if (!isPlaying)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60013AE")]
		[Cpp2IlInjected.Address(RVA = "0x1146A30", Offset = "0x1145430", VA = "0x181146A30", Slot = "8")]
		internal override void Dispose()
		{
			//Discarded unreachable code: IL_0060, IL_0066, IL_006c, IL_007e
			//IL_0009: Expected O, but got I4
			int num = 0;
			base.Model = (CollectionItemGroupModel)num;
			TemplateComponent header = _header;
			int active = 0;
			header.SetActive((byte)active != 0);
			IEnumerator enumerator = _items.GetEnumerator();
			CollectionMemoryShardsItem collectionMemoryShardsItem = default(CollectionMemoryShardsItem);
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				collectionMemoryShardsItem.Dispose();
			}
			if ((object)collectionMemoryShardsItem != null)
			{
			}
			int num5 = 0;
			Type typeFromHandle = typeof(CollectionMemoryShardsView);
		}

		[Cpp2IlInjected.Token(Token = "0x60013AF")]
		[Cpp2IlInjected.Address(RVA = "0x1147040", Offset = "0x1145A40", VA = "0x181147040")]
		public CollectionShardsGroup()
		{
			((PSNUserAccount)(object)this)._002Ector();
		}
	}
}
