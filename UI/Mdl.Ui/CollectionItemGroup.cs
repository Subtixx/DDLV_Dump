using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002EC")]
	public class CollectionItemGroup : MonoBehaviour, IHasText, IHasSpriteURI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000E33")]
		[SerializeField]
		protected TemplateComponent _header;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000E34")]
		[SerializeField]
		protected RectTransform _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000E35")]
		public RecycleBin RecycleBin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000E36")]
		public RectTransform ViewPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000E38")]
		public UnityEvent OnRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000E39")]
		public UnityEvent OnDispose;

		[Cpp2IlInjected.Token(Token = "0x1700034D")]
		public CollectionItemGroupModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x60012F6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60012F7")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700034E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4000E37")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60012F8")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60012F9")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700034F")]
		public RectTransform Items
		{
			[Cpp2IlInjected.Token(Token = "0x60012FA")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _items;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012FB")]
		[Cpp2IlInjected.Address(RVA = "0x1004540", Offset = "0x1002F40", VA = "0x181004540")]
		private void OnDisable()
		{
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x60012FC")]
		[Cpp2IlInjected.Address(RVA = "0x1004560", Offset = "0x1002F60", VA = "0x181004560", Slot = "6")]
		public virtual void RefreshDisplay()
		{
			//Discarded unreachable code: IL_016c, IL_0172, IL_0178, IL_017e, IL_0184, IL_018a, IL_0190, IL_0196, IL_019c, IL_01a2
			//IL_00d6: Expected I4, but got I8
			//IL_0128: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if ((IntPtr)Model != (IntPtr)num2)
			{
				int childCount = _items.childCount;
				List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField = Model.CollectionItemModels;
				int num4 = childCount - 1;
				RectTransform items = _items;
				int index = items.childCount - 1;
				CollectionItem component = items.GetChild(index).GetComponent<CollectionItem>();
				component.Dispose();
				RecycleBin recycleBin = RecycleBin;
				GameObject trash = component.gameObject;
				recycleBin.SendToBin(trash);
				int constraintCount = _items.GetComponent<GridLayoutGroup>().m_ConstraintCount;
				List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField2 = Model.CollectionItemModels;
				bool flag = default(bool);
				if (flag)
				{
					int childCount2 = _items.childCount;
					RecycleBin recycleBin2 = RecycleBin;
					Type typeFromHandle = typeof(CollectionItem);
					RectTransform items2 = _items;
					ulong num5 = default(ulong);
					recycleBin2.FindReusableOrNew(typeFromHandle, items2).SetActive((byte)num5 != 0);
					bool flag2 = num3 < constraintCount;
					int size = ((List<>)(object)Model.CollectionItemModels)._size;
					size -= constraintCount;
					bool flag3 = num3 >= size;
					CollectionItem component2 = _items.GetChild(num3).GetComponent<CollectionItem>();
					component2.FocusNavigationElement.UsetAltLogicForScrolling = true;
					component2.Model = (CollectionItemModel)num2;
					num3++;
				}
				if ((flag ? 1 : 0) <= (true ? 1 : 0))
				{
				}
				int num6 = 0;
				if (flag)
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
				if ((object)parent.parent != null)
				{
				}
				Transform transform3 = default(Transform);
				if ((object)transform3 != null)
				{
				}
				bool flag4 = default(bool);
				if (flag4)
				{
				}
				bool flag5 = default(bool);
				if (flag5)
				{
				}
			}
			Dispose();
		}

		[Cpp2IlInjected.Token(Token = "0x60012FD")]
		[Cpp2IlInjected.Address(RVA = "0x1004B00", Offset = "0x1003500", VA = "0x181004B00", Slot = "7")]
		public virtual void UpdateItemView()
		{
			//Discarded unreachable code: IL_0091, IL_0097, IL_009d, IL_00af
			int num = 0;
			IEnumerator enumerator = _items.GetEnumerator();
			UiRoot instance = default(UiRoot);
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
				CollectionItem collectionItem = default(CollectionItem);
				if ((object)collectionItem.transform != null)
				{
				}
				bool flag = default(bool);
				collectionItem.IsVisible = flag;
				int num5 = 0;
				if (!Application.isPlaying)
				{
					RecycleBin recycleBin = (collectionItem.RecycleBin = RecycleBin);
				}
				int num6 = 0;
				instance = UiRoot.Instance;
				RecycleBin recycleBin2 = (collectionItem.RecycleBin = instance._itemRecycleBin);
				collectionItem.RefreshDisplay();
			}
			if ((object)instance == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60012FE")]
		[Cpp2IlInjected.Address(RVA = "0x10042F0", Offset = "0x1002CF0", VA = "0x1810042F0", Slot = "4")]
		public string GetText(TextType textType)
		{
			//Discarded unreachable code: IL_0077
			//IL_0020: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			if (textType != TextType.Title)
			{
				int num = 0;
			}
			string collectionName_ = Model.CollectionSetItemData.collectionName_;
			int num2 = 0;
			string arg = LocalizationManager.FromStringID(collectionName_, (IResolver)num2);
			List<CollectionItemModel> _003CCollectionItemModels_003Ek__BackingField = Model.CollectionItemModels;
			Func<CollectionItemModel, bool> func = default(Func<CollectionItemModel, bool>);
			if (_003C_003Ec._003C_003E9__19_0 == null)
			{
				func = (Func<CollectionItemModel, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CollectionItemModel x) => x.IsCollected));
			}
			int num3 = Enumerable.Count<CollectionItemModel>((IEnumerable<>)_003CCollectionItemModels_003Ek__BackingField, (Func<, >)(object)func);
			int _003CTotalItems_003Ek__BackingField = Model.TotalItems;
			return $"{arg} ({num3}/{num3})";
		}

		[Cpp2IlInjected.Token(Token = "0x60012FF")]
		[Cpp2IlInjected.Address(RVA = "0x1004500", Offset = "0x1002F00", VA = "0x181004500", Slot = "5")]
		public string GetURI(SpriteType spriteType)
		{
			//Discarded unreachable code: IL_0017
			if (spriteType != SpriteType.Icon)
			{
				int num = 0;
			}
			return Model.CollectionSetItemData.iconAddress_;
		}

		[Cpp2IlInjected.Token(Token = "0x6001300")]
		[Cpp2IlInjected.Address(RVA = "0x1003E20", Offset = "0x1002820", VA = "0x181003E20", Slot = "8")]
		internal virtual void Dispose()
		{
			//Discarded unreachable code: IL_0060, IL_0066, IL_006c, IL_007e
			//IL_0009: Expected O, but got I4
			int num = 0;
			Model = (CollectionItemGroupModel)num;
			TemplateComponent header = _header;
			int active = 0;
			header.SetActive((byte)active != 0);
			IEnumerator enumerator = _items.GetEnumerator();
			CollectionItem collectionItem = default(CollectionItem);
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
				collectionItem.Dispose();
			}
			if ((object)collectionItem != null)
			{
			}
			int num5 = 0;
			Type typeFromHandle = typeof(CollectionItem);
		}

		[Cpp2IlInjected.Token(Token = "0x6001301")]
		[Cpp2IlInjected.Address(RVA = "0x10040F0", Offset = "0x1002AF0", VA = "0x1810040F0")]
		internal CollectionItem GetAnyVisibleItem()
		{
			//Discarded unreachable code: IL_003c, IL_0042
			int num = 0;
			IEnumerator enumerator = _items.GetEnumerator();
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
			}
			if (enumerator != null)
			{
			}
			int num4 = default(int);
			if (num4 != 0)
			{
			}
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001302")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CollectionItemGroup()
		{
		}
	}
}
