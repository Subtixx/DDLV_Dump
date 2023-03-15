using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Gameloft.Common;
using Mdl.Online;
using Mdl.Systems;
using Meta.Online;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000613")]
	public class MailItem : CustomButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40021BE")]
		public StartMenu.Phase Phase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40021BF")]
		[SerializeField]
		private RectTransformHelper _rectTransformHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40021C0")]
		[SerializeField]
		private RectTransform _highlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40021C1")]
		[SerializeField]
		private RectTransform _highlightedSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40021C2")]
		[SerializeField]
		private int _hightlightOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40021C3")]
		private bool _clickReleased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40021C4")]
		public MailboxMenu _mailboxMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40021C5")]
		public string _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40021C6")]
		public InboxMessage InboxMessageData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40021C7")]
		public GameObject _claimIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40021C8")]
		[SerializeField]
		private Sprite[] _icons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40021C9")]
		[SerializeField]
		private SpriteAtlasImage _imageIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40021CA")]
		[SerializeField]
		private CanvasGroup _viewHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40021CB")]
		private bool isRewarded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x40021CC")]
		public bool isRead;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15A")]
		[Cpp2IlInjected.Token(Token = "0x40021CD")]
		public bool isClaimed;

		[Cpp2IlInjected.Token(Token = "0x60027BB")]
		[Cpp2IlInjected.Address(RVA = "0xF9E290", Offset = "0xF9CC90", VA = "0x180F9E290")]
		public void Init()
		{
			//Discarded unreachable code: IL_00b3
			//IL_0010: Expected O, but got I4
			MailboxMenu mailboxMenu = _mailboxMenu;
			int num = 0;
			if (mailboxMenu == (UnityEngine.Object)num)
			{
				MailboxMenu mailboxMenu2 = (_mailboxMenu = base.gameObject.transform.GetComponentInParent<MailboxMenu>());
			}
			TextBase label = base.View.Label;
			string text = (label.Text = _title);
			if (!_mailboxMenu._isDebug)
			{
				bool flag = InboxMessageData.IsRead;
				InboxMessage inboxMessageData = InboxMessageData;
				isRead = flag;
				bool flag2 = (isClaimed = inboxMessageData.IsClaimed);
			}
			List<InboxItemReward> rewards = (List<InboxItemReward>)(object)InboxMessageData.GetRewards();
			GameObject claimIcon = _claimIcon;
			bool active = default(bool);
			isRewarded = active;
			int num2 = 0;
			claimIcon.SetActive(active);
			ChangeDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x60027BC")]
		[Cpp2IlInjected.Address(RVA = "0xF9EC20", Offset = "0xF9D620", VA = "0x180F9EC20", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_00d3
			base.OnEnable();
			UnityEvent onSelected = OnSelected;
			UnityAction call = OnSelectedHandler;
			onSelected.AddListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = OnDeSelectedHandler;
			onDeselected.AddListener(call2);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call3 = OnHighlightedHandler;
			onHighlighted.AddListener(call3);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call4 = OnDeHighlightedHandler;
			onDehighlighted.AddListener(call4);
			UnityEvent onActivated = OnActivated;
			UnityAction call5 = OnActivatedHandler;
			onActivated.AddListener(call5);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027BD")]
		[Cpp2IlInjected.Address(RVA = "0xF9E8E0", Offset = "0xF9D2E0", VA = "0x180F9E8E0", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_00d3
			UnityEvent onSelected = OnSelected;
			UnityAction call = OnSelectedHandler;
			onSelected.RemoveListener(call);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call2 = OnDeSelectedHandler;
			onDeselected.RemoveListener(call2);
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call3 = OnHighlightedHandler;
			onHighlighted.RemoveListener(call3);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call4 = OnDeHighlightedHandler;
			onDehighlighted.RemoveListener(call4);
			UnityEvent onActivated = OnActivated;
			UnityAction call5 = OnActivatedHandler;
			onActivated.RemoveListener(call5);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaOnlineClient != null)
			{
				OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
				OnlineClient.ConnectionModeChanged value = OnConnectionModeChanged;
				metaOnlineClient.OnConnectionModeChanged -= value;
			}
			base.OnDisable();
		}

		[Cpp2IlInjected.Token(Token = "0x60027BE")]
		[Cpp2IlInjected.Address(RVA = "0xF9E450", Offset = "0xF9CE50", VA = "0x180F9E450")]
		[AsyncStateMachine(typeof(_003COnConnectionModeChangedTask_003Ed__19))]
		private Task OnConnectionModeChangedTask(OnlineClient.OnlineStatus currentOnlineStatus)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027BF")]
		[Cpp2IlInjected.Address(RVA = "0xF9E570", Offset = "0xF9CF70", VA = "0x180F9E570")]
		private void OnConnectionModeChanged(OnlineClient.OnlineStatus currentOnlineStatus, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60027C0")]
		[Cpp2IlInjected.Address(RVA = "0xF9EF60", Offset = "0xF9D960", VA = "0x180F9EF60")]
		private void OnHighlightedHandler()
		{
			//Discarded unreachable code: IL_00ad
			//IL_005c: Expected F4, but got I4
			GameObject gameObject = base.View.Background.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			TextMeshProUGUI textComponent = base.View.Label.TextComponent;
			Image image = _imageIcon.Image;
			int num = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
			int num2 = 0;
			ChangeDisplay();
			_rectTransformHelper.X = num2;
			bool active2 = default(bool);
			_highlighted.gameObject.SetActive(active2);
			GameObject gameObject2 = _highlightedSelected.gameObject;
			bool isSelected = ((TemplateButton)this)._isSelected;
			gameObject2.SetActive(isSelected);
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				base.IsSelected = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027C1")]
		[Cpp2IlInjected.Address(RVA = "0xF9E6D0", Offset = "0xF9D0D0", VA = "0x180F9E6D0")]
		public void OnDeHighlightedHandler()
		{
			//Discarded unreachable code: IL_0096
			//IL_003e: Expected F4, but got I4
			GameObject gameObject = _highlightedSelected.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _highlighted.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			RectTransformHelper rectTransformHelper = _rectTransformHelper;
			int num = 0;
			rectTransformHelper.X = num;
			GameObject gameObject3 = base.View.Background.gameObject;
			bool isSelected = ((TemplateButton)this)._isSelected;
			gameObject3.SetActive(isSelected);
			TextMeshProUGUI textComponent = base.View.Label.TextComponent;
			Image image = _imageIcon.Image;
			int num2 = 0;
			UIGameColors gameColors = UiRoot.Instance._gameColors;
			ChangeDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x60027C2")]
		[Cpp2IlInjected.Address(RVA = "0xF9F150", Offset = "0xF9DB50", VA = "0x180F9F150")]
		private void OnSelectedHandler()
		{
			//Discarded unreachable code: IL_0049
			//IL_0023: Expected O, but got I4
			bool isOnline = InboxMessageData.IsOnline;
			int num = 0;
			Mdl.Online.Client client = default(Mdl.Online.Client);
			if (!isOnline || client.MetaClient.OnlineClient.IsFullOnlineWithNativeRefresh((CancellationToken)num))
			{
				isRead = true;
				int num2 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
			_mailboxMenu.SelectTab(this);
			OnHighlightedHandler();
		}

		[Cpp2IlInjected.Token(Token = "0x60027C3")]
		[Cpp2IlInjected.Address(RVA = "0xF9F370", Offset = "0xF9DD70", VA = "0x180F9F370")]
		[AsyncStateMachine(typeof(_003CRequestRead_003Ed__24))]
		private Task RequestRead()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027C4")]
		[Cpp2IlInjected.Address(RVA = "0xF9E000", Offset = "0xF9CA00", VA = "0x180F9E000")]
		private void ChangeDisplay()
		{
			//IL_0068: Expected O, but got I4
			CanvasGroup component = _imageIcon.GetComponent<CanvasGroup>();
			TextMeshProUGUI textComponent = base.View.Label.TextComponent;
			if (!isRead)
			{
			}
			textComponent.alpha = 0.4f;
			component.alpha = 0.4f;
			bool isOnline = InboxMessageData.IsOnline;
			int num = 0;
			if (isOnline && !SystemRoot.Instance.Client.MetaClient.OnlineClient.IsFullOnlineWithNativeRefresh((CancellationToken)num))
			{
				Sprite[] icons = _icons;
				SpriteAtlasImage imageIcon = _imageIcon;
				string text2 = (imageIcon.ImageAddress = icons[2].name);
				return;
			}
			SpriteAtlasImage imageIcon2 = _imageIcon;
			Sprite[] icons2 = _icons;
			bool flag = isRead;
			Sprite sprite = default(Sprite);
			string text3 = sprite.name;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027C5")]
		[Cpp2IlInjected.Address(RVA = "0xF9E890", Offset = "0xF9D290", VA = "0x180F9E890")]
		private void OnDeSelectedHandler()
		{
			//Discarded unreachable code: IL_001b, IL_001c
			GameObject gameObject = base.View.Background.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60027C6")]
		[Cpp2IlInjected.Address(RVA = "0xF9E440", Offset = "0xF9CE40", VA = "0x180F9E440")]
		private void OnActivatedHandler()
		{
			OnDeHighlightedHandler();
		}

		[Cpp2IlInjected.Token(Token = "0x60027C7")]
		[Cpp2IlInjected.Address(RVA = "0xE39A90", Offset = "0xE38490", VA = "0x180E39A90")]
		public void ClickReleased()
		{
			_clickReleased = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60027C8")]
		[Cpp2IlInjected.Address(RVA = "0x863470", Offset = "0x861E70", VA = "0x180863470")]
		public MailItem()
		{
		}
	}
}
