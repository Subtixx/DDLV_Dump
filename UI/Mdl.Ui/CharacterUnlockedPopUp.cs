using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Core;
using Mdl.Systems;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004D6")]
	public class CharacterUnlockedPopUp : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001983")]
		private Item _characterItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001984")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001985")]
		[SerializeField]
		private TextBase _tfUnlockLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001986")]
		[SerializeField]
		private GameObject _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001987")]
		private CameraModifierCollection cameraModifiers;

		[Cpp2IlInjected.Token(Token = "0x6001F90")]
		[Cpp2IlInjected.Address(RVA = "0xFFF490", Offset = "0xFFDE90", VA = "0x180FFF490", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0027
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClicked;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F91")]
		[Cpp2IlInjected.Address(RVA = "0xFFF540", Offset = "0xFFDF40", VA = "0x180FFF540", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0027
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnCloseClicked;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F92")]
		[Cpp2IlInjected.Address(RVA = "0xFFF2D0", Offset = "0xFFDCD0", VA = "0x180FFF2D0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_003a
			base.OnPush(stack, param);
			if (param == null)
			{
				return;
			}
			object[] @params = param.Params;
			if (@params != null && @params.Length != 0)
			{
				object obj = @params[0];
				if (obj != null && obj != null)
				{
					object obj2 = (_characterItem = (Item)obj);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F93")]
		[Cpp2IlInjected.Address(RVA = "0xFFEE40", Offset = "0xFFD840", VA = "0x180FFEE40", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0048
			//IL_007e: Expected O, but got I8
			//IL_007e: Expected O, but got I4
			//IL_00ba: Expected O, but got I4
			base.OnFocusIn();
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item characterItem = _characterItem;
				CharacterItemData itemData = _003CInstance_003Ek__BackingField.GetItemData<CharacterItemData>(characterItem);
				Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
				TextBase tfUnlockLabel = _tfUnlockLabel;
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				throw new NullReferenceException();
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			int num = 0;
			CameraModifierCollection cameraModifierCollection = (cameraModifiers = _003CInstance_003Ek__BackingField2._playerCamera.StartModifiers<HideObstructorsForCutscene, CameraCollisionModifier>((GameObject)num));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F94")]
		[Cpp2IlInjected.Address(RVA = "0xFFF2A0", Offset = "0xFFDCA0", VA = "0x180FFF2A0", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			base.OnFocusOut(popAfterFocusOut, animate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F95")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnCloseClicked()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F96")]
		[Cpp2IlInjected.Address(RVA = "0xFFF390", Offset = "0xFFDD90", VA = "0x180FFF390")]
		private void PlayIntroStep1()
		{
			//Discarded unreachable code: IL_003c
			//IL_001a: Expected O, but got I8
			//IL_001a: Expected O, but got I4
			TextBase tfUnlockLabel = _tfUnlockLabel;
			int num = 0;
			TextMeshProUGUI textComponent = tfUnlockLabel.TextComponent;
			var vars = (_003C_003Ef__AnonymousType11<float, eEaseType>)(object)new
			{
				characterSpacing = (_003CcharacterSpacing_003Ej__TPar)num,
				Ease = (_003CEase_003Ej__TPar)38
			};
			TweenMax tweenMax = TweenMax.To(textComponent, 0.4f, vars, int.MinValue, this);
			_mcContent.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F97")]
		[Cpp2IlInjected.Address(RVA = "0xFFEDF0", Offset = "0xFFD7F0", VA = "0x180FFEDF0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_000f, IL_0010
			Button btnClose = _btnClose;
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F98")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public CharacterUnlockedPopUp()
		{
		}
	}
}
