using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Characters;
using Mdl.Utils;
using NodeCanvas.DialogueTrees;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200041B")]
	[RequiredAllNotNull]
	public class DialogueButton : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200041C")]
		public struct IconForProfession
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40014B3")]
			[ItemID]
			public int ProfessionID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40014B4")]
			public Sprite professionSprite;

			[Cpp2IlInjected.Token(Token = "0x1700044F")]
			public Item ProfessionItem
			{
				[Cpp2IlInjected.Token(Token = "0x6001AA8")]
				[Cpp2IlInjected.Address(RVA = "0xA285B0", Offset = "0xA26FB0", VA = "0x180A285B0")]
				get
				{
					return (Item)typeof(Item).TypeHandle;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4001495")]
		private const int defaultPadding = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001496")]
		private bool _isLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001497")]
		[SerializeField]
		private FocusNavigationElement _focusNavigationElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001498")]
		[SerializeField]
		[Header("Icons")]
		private SpriteAtlasImage _discussIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001499")]
		[SerializeField]
		private SpriteAtlasImage _giftIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400149A")]
		[SerializeField]
		private SpriteAtlasImage _requestIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400149B")]
		[SerializeField]
		private SpriteAtlasImage _requestCompletedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400149C")]
		[SerializeField]
		private SpriteAtlasImage _requestOngoingIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400149D")]
		[SerializeField]
		private SpriteAtlasImage _wishIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400149E")]
		[SerializeField]
		private SpriteAtlasImage _restaurantIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400149F")]
		[SerializeField]
		private SpriteAtlasImage _hangoutStartIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40014A0")]
		[SerializeField]
		private SpriteAtlasImage _hangoutStartWithoutProfessionIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40014A1")]
		[SerializeField]
		private SpriteAtlasImage _hangoutStopIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40014A2")]
		[SerializeField]
		private SpriteAtlasImage _shopIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40014A3")]
		[SerializeField]
		private SpriteAtlasImage _loreIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40014A4")]
		[SerializeField]
		private GameObject _bgWhite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40014A5")]
		[SerializeField]
		private GameObject _bgLore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40014A6")]
		[SerializeField]
		private GameObject _labelNew;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40014A7")]
		[Header("Containers")]
		public CanvasGroup CanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40014A8")]
		public ButtonTmPro ChoiceButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40014A9")]
		[SerializeField]
		private GameObject _mcLockedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40014AA")]
		[SerializeField]
		private GameObject _mcChoiceIconContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40014AB")]
		[SerializeField]
		private LayoutElement _mcLabelContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40014AC")]
		[SerializeField]
		private GameObject _mcIconContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40014AD")]
		[SerializeField]
		private GameObject _mcRightIconPlaceholder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40014AE")]
		[SerializeField]
		[Header("Friendship")]
		public GameObject _mcFriendshipContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40014AF")]
		[SerializeField]
		public TextBase _tfFriendshipBonus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40014B0")]
		[Header("Enable interaction delay")]
		private float _delay = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40014B2")]
		public List<IconForProfession> iconForProfessionsList;

		[Cpp2IlInjected.Token(Token = "0x1700044D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xEC"), Cpp2IlInjected.Token(Token = "0x40014B1")]
		public int BonusXp
		{
			[Cpp2IlInjected.Token(Token = "0x6001A9E")]
			[Cpp2IlInjected.Address(RVA = "0x12B98B0", Offset = "0x12B82B0", VA = "0x1812B98B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001A9F")]
			[Cpp2IlInjected.Address(RVA = "0x12B9940", Offset = "0x12B8340", VA = "0x1812B9940")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700044E")]
		public bool IsInteractable
		{
			[Cpp2IlInjected.Token(Token = "0x6001AA0")]
			[Cpp2IlInjected.Address(RVA = "0x12B98C0", Offset = "0x12B82C0", VA = "0x1812B98C0")]
			get
			{
				ButtonTmPro choiceButton = ChoiceButton;
				if ((object)choiceButton != null)
				{
					Button buttonComponent = choiceButton.ButtonComponent;
					if ((object)buttonComponent != null)
					{
						bool interactable = ((Selectable)buttonComponent).m_Interactable;
						int num = 0;
					}
				}
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA1")]
		[Cpp2IlInjected.Address(RVA = "0x12B8A30", Offset = "0x12B7430", VA = "0x1812B8A30")]
		public void RefreshDisplay(KeyValuePair<IStatement, int> option, bool useBonusXP, Character character)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA2")]
		[Cpp2IlInjected.Address(RVA = "0x12B9850", Offset = "0x12B8250", VA = "0x1812B9850")]
		public void SetLabelNewVisibility(bool visible)
		{
			//Discarded unreachable code: IL_0012
			_labelNew.gameObject.SetActive(visible);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA3")]
		[Cpp2IlInjected.Address(RVA = "0x12B87C0", Offset = "0x12B71C0", VA = "0x1812B87C0")]
		public void DisableButton()
		{
			//Discarded unreachable code: IL_0016
			Button buttonComponent = ChoiceButton.ButtonComponent;
			int num = ((buttonComponent.interactable = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA4")]
		[Cpp2IlInjected.Address(RVA = "0x12B8880", Offset = "0x12B7280", VA = "0x1812B8880")]
		public void EnableButton()
		{
			//Discarded unreachable code: IL_0080
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_005b: Expected O, but got I4
			GameObject gameObject = base.gameObject;
			int num = 0;
			if (gameObject == (UnityEngine.Object)num)
			{
				return;
			}
			ButtonTmPro choiceButton = ChoiceButton;
			int num2 = 0;
			if (choiceButton == (UnityEngine.Object)num2)
			{
				return;
			}
			GameObject gameObject2 = ChoiceButton.gameObject;
			int num3 = 0;
			if (!(gameObject2 == (UnityEngine.Object)num3))
			{
				Button buttonComponent = ChoiceButton.ButtonComponent;
				int num4 = 0;
				if (!(buttonComponent == (UnityEngine.Object)num4))
				{
					Button buttonComponent2 = ChoiceButton.ButtonComponent;
					bool flag2 = (buttonComponent2.interactable = !_isLocked);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA5")]
		[Cpp2IlInjected.Address(RVA = "0x12B8800", Offset = "0x12B7200", VA = "0x1812B8800")]
		public void EnableButtonWithDelay()
		{
			Action action = EnableButton;
			float delay = _delay;
			Coroutine coroutine = Coroutines.Delay(action, delay);
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA6")]
		[Cpp2IlInjected.Address(RVA = "0x12B89F0", Offset = "0x12B73F0", VA = "0x1812B89F0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0016
			ChoiceButton.ButtonComponent.m_OnClick.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6001AA7")]
		[Cpp2IlInjected.Address(RVA = "0x12B9890", Offset = "0x12B8290", VA = "0x1812B9890")]
		public DialogueButton()
		{
		}
	}
}
