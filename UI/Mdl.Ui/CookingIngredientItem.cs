using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000383")]
	[RequiredAllNotNull]
	public class CookingIngredientItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010FA")]
		public TextBase AmountTextAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40010FB")]
		[SerializeField]
		public RectTransform AmountAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40010FC")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40010FD")]
		[SerializeField]
		private TextBase _tfName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40010FE")]
		[SerializeField]
		private CanvasGroup _highlightCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40010FF")]
		public IItemData ItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001100")]
		public Action<Item> OnIngredientItemSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001101")]
		[SerializeField]
		private BaseButton _button;

		[Cpp2IlInjected.Token(Token = "0x600165B")]
		[Cpp2IlInjected.Address(RVA = "0x14A9AF0", Offset = "0x14A84F0", VA = "0x1814A9AF0")]
		internal void Init(ICookingIngredient cookingIngredient)
		{
			//Discarded unreachable code: IL_0039
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			IItemData itemData = default(IItemData);
			ItemData = itemData;
			IItemData itemData2 = ItemData;
			bool flag = default(bool);
			if (flag)
			{
				IItemData itemData3 = ItemData;
				AsyncAtlassedIcon mcIcon = _mcIcon;
				IItemData itemData4 = ItemData;
				TextBase tfName = _tfName;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600165C")]
		[Cpp2IlInjected.Address(RVA = "0x14AA080", Offset = "0x14A8A80", VA = "0x1814AA080")]
		private void Start()
		{
			//Discarded unreachable code: IL_001c
			BaseButton button = _button;
			BaseButton.OnBaseButtonPress value = OnPress;
			button.OnPress += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600165D")]
		[Cpp2IlInjected.Address(RVA = "0x14A9CF0", Offset = "0x14A86F0", VA = "0x1814A9CF0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_001c
			BaseButton button = _button;
			BaseButton.OnBaseButtonPress value = OnPress;
			button.OnPress -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x600165E")]
		[Cpp2IlInjected.Address(RVA = "0x14A9E80", Offset = "0x14A8880", VA = "0x1814A9E80")]
		public void OnPress(BaseButton button)
		{
			//Discarded unreachable code: IL_0043
			//IL_0042: Expected O, but got I4
			if (!Input.GetMouseButton(0))
			{
				int num = 0;
				if (Input.touchCount <= 0)
				{
					return;
				}
			}
			IItemData itemData = ItemData;
			bool flag = default(bool);
			if (flag)
			{
				if (OnIngredientItemSelected != null)
				{
					IItemData itemData2 = ItemData;
				}
				BaseButton button2 = _button;
				int num2 = 0;
				button2.OnPointerUp((PointerEventData)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600165F")]
		[Cpp2IlInjected.Address(RVA = "0x14A9D80", Offset = "0x14A8780", VA = "0x1814A9D80")]
		public void OnHighlightEnable()
		{
			//Discarded unreachable code: IL_0040
			//IL_0010: Expected F4, but got I4
			CanvasGroup highlightCanvas = _highlightCanvas;
			int num = 0;
			highlightCanvas.alpha = num;
			Action callback = delegate
			{
				//Discarded unreachable code: IL_0011
				_highlightCanvas.alpha = 1f;
			};
			int _003C_003E1__state = default(int);
			_003CRebuildHighlightLayoutCoroutine_003Ed__13 _003CRebuildHighlightLayoutCoroutine_003Ed__ = new _003CRebuildHighlightLayoutCoroutine_003Ed__13(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRebuildHighlightLayoutCoroutine_003Ed__._003C_003E4__this = this;
			_003CRebuildHighlightLayoutCoroutine_003Ed__.callback = callback;
			Coroutine coroutine = StartCoroutine(_003CRebuildHighlightLayoutCoroutine_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6001660")]
		[Cpp2IlInjected.Address(RVA = "0x14A9FF0", Offset = "0x14A89F0", VA = "0x1814A9FF0")]
		[IteratorStateMachine(typeof(_003CRebuildHighlightLayoutCoroutine_003Ed__13))]
		private IEnumerator RebuildHighlightLayoutCoroutine(Action callback)
		{
			int _003C_003E1__state = default(int);
			_003CRebuildHighlightLayoutCoroutine_003Ed__13 _003CRebuildHighlightLayoutCoroutine_003Ed__ = new _003CRebuildHighlightLayoutCoroutine_003Ed__13(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRebuildHighlightLayoutCoroutine_003Ed__._003C_003E4__this = this;
			_003CRebuildHighlightLayoutCoroutine_003Ed__.callback = callback;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001661")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CookingIngredientItem()
		{
		}
	}
}
