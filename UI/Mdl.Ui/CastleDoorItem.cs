using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Localization.Formatter;
using Google.Protobuf.Collections;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000622")]
	public class CastleDoorItem : BaseButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400221F")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4002220")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4002221")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4002222")]
		[SerializeField]
		private RectTransform _holder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4002223")]
		[SerializeField]
		private GameObject _regularBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4002224")]
		[SerializeField]
		private GameObject _selectedBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4002225")]
		[SerializeField]
		private GameObject _highlightBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4002226")]
		[SerializeField]
		private bool _isLockedByLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x209")]
		[Cpp2IlInjected.Token(Token = "0x4002227")]
		private bool _isLockedByCharacterCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20A")]
		[Cpp2IlInjected.Token(Token = "0x4002228")]
		private bool _isLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4002229")]
		private WorldData.Types.World _realm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400222A")]
		private bool _readyToUnlock;

		[Cpp2IlInjected.Token(Token = "0x17000603")]
		public bool IsLocked
		{
			[Cpp2IlInjected.Token(Token = "0x600280A")]
			[Cpp2IlInjected.Address(RVA = "0xA6E910", Offset = "0xA6D310", VA = "0x180A6E910")]
			get
			{
				return _isLocked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000604")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x21C"), Cpp2IlInjected.Token(Token = "0x400222B")]
		internal int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600280B")]
			[Cpp2IlInjected.Address(RVA = "0xA6E900", Offset = "0xA6D300", VA = "0x180A6E900")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600280C")]
			[Cpp2IlInjected.Address(RVA = "0xA6E940", Offset = "0xA6D340", VA = "0x180A6E940")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000605")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x220"), Cpp2IlInjected.Token(Token = "0x400222C")]
		internal int Row
		{
			[Cpp2IlInjected.Token(Token = "0x600280D")]
			[Cpp2IlInjected.Address(RVA = "0xA6E920", Offset = "0xA6D320", VA = "0x180A6E920")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600280E")]
			[Cpp2IlInjected.Address(RVA = "0xA6E950", Offset = "0xA6D350", VA = "0x180A6E950")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000606")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x224"), Cpp2IlInjected.Token(Token = "0x400222D")]
		internal int Col
		{
			[Cpp2IlInjected.Token(Token = "0x600280F")]
			[Cpp2IlInjected.Address(RVA = "0xA6E8F0", Offset = "0xA6D2F0", VA = "0x180A6E8F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002810")]
			[Cpp2IlInjected.Address(RVA = "0xA6E930", Offset = "0xA6D330", VA = "0x180A6E930")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6002811")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1A0", Offset = "0xA6CBA0", VA = "0x180A6E1A0")]
		internal unsafe void RefreshDisplay(WorldData.Types.World realm)
		{
			//Discarded unreachable code: IL_0183, IL_0240
			//IL_014d: Expected O, but got I4
			int num = 0;
			WorldData.Types.World world = (_realm = realm);
			WorldData.Types.World world2 = realm;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			WorldData.Types.World world3 = realm;
			MapField<string, Realm> realms_ = world_.realms_;
			string worldName_ = world3.worldName_;
			if (((MapField<TKey, TValue>)(object)realms_).TryGetValue((TKey)worldName_, out *(TValue*)num))
			{
				_isLocked = (byte)num != 0;
				_isActive = true;
				RefreshActive();
				_readyToUnlock = (byte)num != 0;
			}
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			ProfilePlayer player_ = profile.player_;
			int unlockAtLevel_ = realm.unlockAtLevel_;
			bool flag = (_isLockedByLevel = (long)(IntPtr)ProfilePlayer._repeated_tools_codec < (long)unlockAtLevel_);
			int num2 = profile.world_.UnlockCharacterCount();
			WorldData.Types.World world4 = realm;
			bool isLockedByLevel = _isLockedByLevel;
			bool flag2 = (_isLockedByCharacterCount = num2 < world4.unlockCharacterCount_);
			if (!isLockedByLevel && !flag2)
			{
				int count = ((RepeatedField<T>)(object)realm.unlockCost_).Count;
			}
			_isLocked = true;
			if (!isLockedByLevel)
			{
				if ((_isLockedByCharacterCount ? 1 : 0) == num)
				{
					if (((RepeatedField<T>)(object)realm.unlockCost_).Count <= 0)
					{
						bool flag3 = (_readyToUnlock = ((RepeatedField<T>)(object)_realm.unlockCost_).Count > 0);
						bool isActive = default(bool);
						if ((_isLockedByLevel ? 1 : 0) == num)
						{
							isActive = (_isLockedByCharacterCount ? 1 : 0) == num;
						}
						_isActive = isActive;
						RefreshActive();
						string text = default(string);
						_tfLabel.Text = text;
						AsyncAtlassedIcon mcIcon = _mcIcon;
						CanvasGroup canvasGroup = _canvasGroup;
						if (_isLocked)
						{
						}
						canvasGroup.alpha = 1f;
						Button.ButtonClickedEvent onClick = base.ButtonComponent.m_OnClick;
						UnityAction call = delegate
						{
							//Discarded unreachable code: IL_0016
							CastleDoorItem castleDoorItem = this;
							WorldData.Types.World realm2 = realm;
							castleDoorItem.OnSelectDoor(realm2);
						};
						onClick.AddListener(call);
						FocusNavigationElement component = GetComponent<FocusNavigationElement>();
						bool flag4 = (component.IgnoreThis = _isLocked);
						return;
					}
					int num3 = 0;
					string text2 = LocalizationManager.FromStringID("menu.common_ready_unlock", (IResolver)num3);
				}
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				int unlockCharacterCount_ = realm.unlockCharacterCount_;
				throw new NullReferenceException();
			}
			Dictionary<string, object> dictionary2 = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			int unlockAtLevel_2 = realm.unlockAtLevel_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002812")]
		[Cpp2IlInjected.Address(RVA = "0xA6DFF0", Offset = "0xA6C9F0", VA = "0x180A6DFF0")]
		private void OnSelectDoor(WorldData.Types.World realm)
		{
			//Discarded unreachable code: IL_005d
			if (!_readyToUnlock)
			{
				int num = 0;
				UiRoot.Instance._popupStack.Pop();
				int num2 = 0;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				Type typeFromHandle = typeof(HudMenu);
				menuStack.PopAllAbove(typeFromHandle);
				PlayerNavigation playerNavigation = default(PlayerNavigation);
				playerNavigation.EnterRealmShortcut(realm);
				AK.Wwise.Event sfxEvent = _sfxEvent;
				GameObject gameObject = base.gameObject;
				uint num3 = sfxEvent.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002813")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF20", Offset = "0xA6C920", VA = "0x180A6DF20")]
		public void OnHighlight(bool highlighted)
		{
			//Discarded unreachable code: IL_0050
			//IL_004d: Expected F4, but got I4
			if (!_isLocked)
			{
				SoundComponent component = GetComponent<SoundComponent>();
				if ((object)component != null)
				{
					int index = 0;
					component.PostSfx(index);
				}
				Highlight.SetActive(highlighted);
				_highlightBg.SetActive(highlighted);
				RectTransform holder = _holder;
				int num = 0;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = (TweenerCore<Vector2, Vector2, VectorOptions>)(object)DOTweenModuleUI.DOAnchorPosY(holder, (float)(highlighted ? 1 : 0), 0.1f, (byte)num != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002814")]
		[Cpp2IlInjected.Address(RVA = "0x855CC0", Offset = "0x8546C0", VA = "0x180855CC0")]
		public CastleDoorItem()
		{
		}
	}
}
