using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Ui.Widgets;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000376")]
	[RequiredAllNotNull]
	public class CookingCategorySelector : FilterSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40010CE")]
		public FilterItem _prefabCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40010CF")]
		public RectTransform _categories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40010D0")]
		public DynamicFilterConfig filterConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40010D1")]
		[ItemID]
		[SerializeField]
		[ItemID(ItemType.Tag)]
		[Tooltip("Tag for the golden potato")]
		[Header("Cooking tags")]
		private int _cookingSecretTagID;

		[Cpp2IlInjected.Token(Token = "0x170003D0")]
		public List<Filter> AllFilters
		{
			[Cpp2IlInjected.Token(Token = "0x600161E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CAllFilters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600161F")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CAllFilters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<Filter>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x170003D1")]
		public List<Filter> SelectedFilters
		{
			[Cpp2IlInjected.Token(Token = "0x6001620")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CSelectedFilters_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001621")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CSelectedFilters_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (List<Filter>)(object)new List<T>();


		[Cpp2IlInjected.Token(Token = "0x6001622")]
		[Cpp2IlInjected.Address(RVA = "0x14A6120", Offset = "0x14A4B20", VA = "0x1814A6120")]
		public void Init()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001623")]
		[Cpp2IlInjected.Address(RVA = "0x14A6E00", Offset = "0x14A5800", VA = "0x1814A6E00")]
		protected void SelectFilter(FilterItem button)
		{
			//Discarded unreachable code: IL_0065, IL_006b, IL_0071, IL_0083
			int num = 0;
			List<Filter> list = SelectedFilters;
			Filter _003CFilter_003Ek__BackingField = button.Filter;
			if (((List<T>)(object)list).Contains((T)_003CFilter_003Ek__BackingField))
			{
				return;
			}
			((List<T>)(object)SelectedFilters).Clear();
			IEnumerator enumerator = _categories.GetEnumerator();
			FilterItem filterItem = default(FilterItem);
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
				int num5 = ((filterItem.isSelected = false) ? 1 : 0);
			}
			if ((object)filterItem != null)
			{
				int num6 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001624")]
		[Cpp2IlInjected.Address(RVA = "0x14A65C0", Offset = "0x14A4FC0", VA = "0x1814A65C0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_005d, IL_0069, IL_007b
			int num = 0;
			IEnumerator enumerator = _categories.GetEnumerator();
			Delegate @delegate = default(Delegate);
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
				FilterItem.Clicked clicked = SelectFilter;
				@delegate = Delegate.Remove(clicked, clicked);
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				FilterItem filterItem = default(FilterItem);
				filterItem.OnClicked = (FilterItem.Clicked)@delegate;
			}
			if ((object)@delegate == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001625")]
		[Cpp2IlInjected.Address(RVA = "0x14A6870", Offset = "0x14A5270", VA = "0x1814A6870")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0130, IL_013c, IL_0142, IL_0148, IL_0154
			//IL_0099: Expected F4, but got I4
			//IL_00be: Expected O, but got I4
			int num = 0;
			List<Filter> list = AllFilters;
			RectTransform categories = _categories;
			int childCount = categories.childCount;
			FilterItem prefabCategory = _prefabCategory;
			RectTransform categories2 = _categories;
			FilterItem filterItem = UnityEngine.Object.Instantiate(prefabCategory, categories2);
			FilterItem component = _categories.GetChild(num).GetComponent<FilterItem>();
			Transform transform = component.transform;
			float z = Vector3.zero.z;
			List<Filter> list2 = AllFilters;
			List<Filter> list3 = SelectedFilters;
			List<Filter> list4 = AllFilters;
			bool isSelected = default(bool);
			component.isSelected = isSelected;
			Transform transform2 = component.transform;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			uint num2 = default(uint);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetDelay((int)num2);
			FilterItem.Clicked clicked = SelectFilter;
			Delegate @delegate = default(Delegate);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				component.OnClicked = (FilterItem.Clicked)num;
				FilterItem.Clicked clicked2 = SelectFilter;
				Delegate delegate2 = default(Delegate);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					component.OnClicked = (FilterItem.Clicked)delegate2;
					num++;
					List<Filter> list5 = AllFilters;
					IEnumerator enumerator = categories.GetEnumerator();
					GameObject gameObject = default(GameObject);
					if (enumerator != null)
					{
						uint num3 = default(uint);
						if (num < (int)num3)
						{
							num += num;
							num++;
						}
						if (enumerator == null)
						{
						}
						int num4 = 0;
						if (enumerator == null)
						{
							throw new InvalidCastException();
						}
						List<Filter> list6 = AllFilters;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
						num++;
					}
					if ((object)gameObject == null)
					{
					}
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001626")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public override void SelectFilters(HashSet<Filter> filters)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001627")]
		[Cpp2IlInjected.Address(RVA = "0x14A60B0", Offset = "0x14A4AB0", VA = "0x1814A60B0", Slot = "5")]
		public override HashSet<Filter> CurrentFilters()
		{
			return (HashSet<Filter>)(object)new HashSet<T>((IEqualityComparer<>)SelectedFilters);
		}

		[Cpp2IlInjected.Token(Token = "0x6001628")]
		[Cpp2IlInjected.Address(RVA = "0x14A70E0", Offset = "0x14A5AE0", VA = "0x1814A70E0")]
		public CookingCategorySelector()
		{
		}
	}
}
