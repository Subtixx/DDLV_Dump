using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Gameloft.Common;
using glPlayFab;
using Mdl.Systems;
using Meta.Online;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200060D")]
	public class MailDisplayManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002196")]
		[SerializeField]
		private TextBase _messageDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002197")]
		[SerializeField]
		private TextBase _messageTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002198")]
		public RectTransform _rewardContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002199")]
		[SerializeField]
		private RectTransform _rewardListTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400219A")]
		[SerializeField]
		private MailRewardItem _rewardPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400219B")]
		[SerializeField]
		private TextBase _expiredIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400219C")]
		[SerializeField]
		private ButtonTmPro _claimBtn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400219D")]
		[SerializeField]
		private ScrollRect _scrollRectMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400219E")]
		[SerializeField]
		private TextBase _liveIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400219F")]
		[SerializeField]
		private TextBase _hiddenLive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40021A0")]
		[SerializeField]
		private AsyncMenu _cloudSaveWarningPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40021A1")]
		[SerializeField]
		private ShortcutDefinition _resetgameShortcut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40021A2")]
		[SerializeField]
		private AK.Wwise.Event _claimSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40021A4")]
		public UnityEvent OnClaimSuccessfull;

		[Cpp2IlInjected.Token(Token = "0x170005FF")]
		internal MailItem DisplayedMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600279F")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			[CompilerGenerated]
			get
			{
				return _003CDisplayedMessage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60027A0")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			[CompilerGenerated]
			private set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027A1")]
		[Cpp2IlInjected.Address(RVA = "0xF9C7A0", Offset = "0xF9B1A0", VA = "0x180F9C7A0")]
		private void ClearList(RectTransform list)
		{
			//Discarded unreachable code: IL_0022, IL_0034
			IEnumerator enumerator = list.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			if ((object)gameObject == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027A2")]
		[Cpp2IlInjected.Address(RVA = "0xF9CF30", Offset = "0xF9B930", VA = "0x180F9CF30")]
		public void Refresh(MailItem message)
		{
			//Discarded unreachable code: IL_00d7, IL_0104, IL_0121, IL_020b
			//IL_004d: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			//IL_0186: Expected I4, but got I8
			//IL_019c: Expected O, but got I4
			//IL_019c: Expected O, but got I4
			//IL_01b4: Expected O, but got I4
			//IL_01b4: Expected O, but got I4
			//IL_01ca: Expected O, but got I4
			//IL_0200: Expected O, but got I4
			int num = 0;
			if ((object)message != null)
			{
				DisplayedMessage = message;
				TextBase messageDescription = _messageDescription;
				TextBase messageTitle = _messageTitle;
				string title_ = message.InboxMessageData.title_;
				string message2 = "[Mailbox Debug] Tittle : " + title_;
				int num2 = 0;
				Debug.Log(message2);
				string message3 = "[Mailbox Debug] Subtitle : " + (string)num2;
				int num3 = 0;
				Debug.Log(message3);
				Debug.Log("[Mailbox Debug] Description : " + (string)num3);
				RectTransform rewardListTransform = _rewardListTransform;
				ClearList(rewardListTransform);
				bool flag = default(bool);
				if (flag)
				{
					MailRewardItem rewardPrefab = _rewardPrefab;
					RectTransform rewardListTransform2 = _rewardListTransform;
					MailRewardItem mailRewardItem = UnityEngine.Object.Instantiate(rewardPrefab, rewardListTransform2);
				}
				MailboxMenu mailboxMenu = default(MailboxMenu);
				TextBase textBase = default(TextBase);
				if (!mailboxMenu._isDebug)
				{
					TextBase offlineWarningMessage = mailboxMenu._offlineWarningMessage;
					bool flag2 = default(bool);
					if (!flag2)
					{
						int num4 = 0;
						DateTime utcNow = DateTime.UtcNow;
						DateTime dateTime = default(DateTime);
						TimeSpan timeSpan = dateTime - utcNow;
						Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
						throw new NullReferenceException();
					}
					textBase.StringID = "menu.mailbox_expired";
				}
				bool adjustRectWidthToText = textBase._adjustRectWidthToText;
				bool flag3 = default(bool);
				if (!flag3)
				{
					int active = 0;
					GameObject gameObject = default(GameObject);
					gameObject.SetActive((byte)active != 0);
				}
				Client client = default(Client);
				DateTime serverTime = client.ServerTime;
				DateTime dateTime2 = default(DateTime);
				TimeSpan timeSpan2 = dateTime2 - serverTime;
				GameObject gameObject2 = _liveIn.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				GameObject gameObject3 = default(GameObject);
				ulong num5 = default(ulong);
				gameObject3.SetActive((byte)num5 != 0);
				TextBase liveIn = _liveIn;
				int num6 = default(int);
				int num7 = default(int);
				string text = $"Live in {num6}m{num7}s";
				int num8 = default(int);
				num6 = num8;
				int num9 = default(int);
				num7 = num9;
				string text2 = $"Live in {num6}h{num7}m";
				TextBase liveIn2 = _liveIn;
				int num10 = default(int);
				string text4 = (liveIn2.Text = $"Live in {num10}d");
				bool active3 = default(bool);
				liveIn2.gameObject.SetActive(active3);
				GameObject gameObject4 = default(GameObject);
				bool active4 = default(bool);
				gameObject4.SetActive(active4);
				int _003C_003E1__state = default(int);
				_003CRebuildContentLayout_003Ed__20 _003CRebuildContentLayout_003Ed__ = new _003CRebuildContentLayout_003Ed__20(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CRebuildContentLayout_003Ed__._003C_003E4__this = (MailDisplayManager)0;
			}
			Debug.Log("[Mailbox Debug] message is null ");
		}

		[Cpp2IlInjected.Token(Token = "0x60027A3")]
		[Cpp2IlInjected.Address(RVA = "0xF9CEC0", Offset = "0xF9B8C0", VA = "0x180F9CEC0")]
		[IteratorStateMachine(typeof(_003CRebuildContentLayout_003Ed__20))]
		private IEnumerator RebuildContentLayout()
		{
			int _003C_003E1__state = default(int);
			_003CRebuildContentLayout_003Ed__20 _003CRebuildContentLayout_003Ed__ = new _003CRebuildContentLayout_003Ed__20(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRebuildContentLayout_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027A4")]
		[Cpp2IlInjected.Address(RVA = "0xF9CC80", Offset = "0xF9B680", VA = "0x180F9CC80")]
		public void OnClaimBtnClicked()
		{
			//Discarded unreachable code: IL_0087
			//IL_002b: Expected O, but got I4
			bool isLoggedInWithAllServices = SystemRoot.Instance.MetaClient.OnlineClient.IsLoggedInWithAllServices;
			int num = 0;
			if (isLoggedInWithAllServices)
			{
			}
			MailItem mailItem = DisplayedMessage;
			int num2 = 0;
			if (mailItem == (UnityEngine.Object)num2)
			{
			}
			bool flag = !DisplayedMessage.InboxMessageData.IsOnline;
			ScrollRect scrollRectMessage = _scrollRectMessage;
			ButtonTmPro claimBtn = _claimBtn;
			RectTransform viewport = scrollRectMessage.m_Viewport;
			if ((object)claimBtn.transform != null)
			{
			}
			bool flag2 = default(bool);
			if (flag != flag2)
			{
				CancellationToken cancellationToken = GetComponentInParent<MailboxMenu>().CancellationToken;
				OnClaimBtnClickedTask(cancellationToken).FireAndForgetTask();
			}
			[Cpp2IlInjected.Token(Token = "0x60027AC")]
			[Cpp2IlInjected.Address(RVA = "0xF9DA80", Offset = "0xF9C480", VA = "0x180F9DA80")]
			Task OnClaimBtnClickedTask(CancellationToken ct)
			{
				//IL_0010: Expected O, but got I4
				//IL_007c: Expected O, but got I4
				//IL_009d: Expected O, but got I4
				MailItem mailItem2 = DisplayedMessage;
				int num3 = 0;
				if (!(mailItem2 == (UnityEngine.Object)num3))
				{
					InboxMessage inboxMessageData = DisplayedMessage.InboxMessageData;
					bool isLoggedInWithAllServices2 = SystemRoot.Instance.MetaClient.OnlineClient.IsLoggedInWithAllServices;
					bool hasGameloftID = SystemRoot.Instance.MetaClient.CredentialProvider.HasGameloftID;
					int num4 = 0;
					if (isLoggedInWithAllServices2)
					{
						Client client = default(Client);
						LoginResult _003CloginResult_003Ek__BackingField = client.OnlineClient.ClientSession.loginResult;
						if (_003CloginResult_003Ek__BackingField != null)
						{
							string gameloftIDLink = _003CloginResult_003Ek__BackingField.GetGameloftIDLink();
						}
					}
					bool flag3 = string.IsNullOrEmpty((string)num4);
					int num5 = default(int);
					if (!hasGameloftID)
					{
						num5 = 0;
					}
					Client client2 = default(Client);
					string rememberGameloftIDLink = client2.CredentialProvider.RememberGameloftIDLink;
					bool flag4 = string.Equals((string)num5, rememberGameloftIDLink);
					int num6 = 0;
					if (!flag4 && !flag4 && !flag4 && inboxMessageData.IsMarkerPurchase)
					{
						_claimBtn.PostWwiseEvent();
						int num7 = 0;
						Task result = default(Task);
						return result;
					}
					int num8 = 0;
				}
				_claimBtn.PostWwiseEvent();
				int num9 = 0;
				Task completedTask = Task.CompletedTask;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60027A5")]
		[Cpp2IlInjected.Address(RVA = "0xF9CC50", Offset = "0xF9B650", VA = "0x180F9CC50")]
		private bool IsAccountLinkingAllowed()
		{
			int num = 0;
			int num2 = 0;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027A6")]
		[Cpp2IlInjected.Address(RVA = "0xF9C2B0", Offset = "0xF9ACB0", VA = "0x180F9C2B0")]
		public void ChangeDisplayClaimed(bool isClaimed)
		{
			//IL_00d7: Expected F4, but got I4
			ButtonTmPro claimBtn = _claimBtn;
			if (!isClaimed)
			{
				claimBtn.GetComponent<Button>().interactable = true;
				_claimBtn.IsActive = true;
				_claimBtn.Label.StringID = "menu.common_claim";
				_expiredIn.TextComponent.alpha = 1f;
				CanvasGroup component = _rewardListTransform.GetComponent<CanvasGroup>();
				_claimBtn.GetComponent<CanvasGroup>().alpha = 1f;
				component.alpha = 1f;
				return;
			}
			Button component2 = claimBtn.GetComponent<Button>();
			int num = ((component2.interactable = false) ? 1 : 0);
			ButtonTmPro claimBtn2 = _claimBtn;
			int num2 = ((claimBtn2.IsActive = false) ? 1 : 0);
			_claimBtn.OnHighlightExit();
			_claimBtn.Label.StringID = "menu.common_claimed";
			TextMeshProUGUI textComponent = _expiredIn.TextComponent;
			int num3 = 0;
			textComponent.alpha = num3;
			CanvasGroup component3 = _rewardListTransform.GetComponent<CanvasGroup>();
			CanvasGroup component4 = _claimBtn.GetComponent<CanvasGroup>();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60027A7")]
		[Cpp2IlInjected.Address(RVA = "0xF9CB10", Offset = "0xF9B510", VA = "0x180F9CB10")]
		[AsyncStateMachine(typeof(_003CCloudSaveWarningTask_003Ed__24))]
		private Task CloudSaveWarningTask(string packName, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027A8")]
		[Cpp2IlInjected.Address(RVA = "0xF9C970", Offset = "0xF9B370", VA = "0x180F9C970")]
		private Task<int> CloudSaveWarningPromptTask(string packName)
		{
			//Discarded unreachable code: IL_0061
			TaskCompletionSource<int> tcs = (TaskCompletionSource<int>)(object)new TaskCompletionSource<TResult>();
			CloudSaveWarningPrompt.CloudSaveWarningPromptParam cloudSaveWarningPromptParam = new CloudSaveWarningPrompt.CloudSaveWarningPromptParam();
			cloudSaveWarningPromptParam.PackName = packName;
			Action<int> action = (cloudSaveWarningPromptParam.AnswerAction = (Action<int>)(object)(Action<T>)delegate(int answer)
			{
				//Discarded unreachable code: IL_000e
				//IL_000c: Expected O, but got I4
				bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)answer);
			});
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			AsyncMenu cloudSaveWarningPrompt = _cloudSaveWarningPrompt;
			popupStack.Push(cloudSaveWarningPrompt, cloudSaveWarningPromptParam);
			return (Task<int>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x60027A9")]
		[Cpp2IlInjected.Address(RVA = "0xF9C520", Offset = "0xF9AF20", VA = "0x180F9C520")]
		[AsyncStateMachine(typeof(_003CClaimMessage_003Ed__26))]
		public Task ClaimMessage(InboxMessageKey key, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027AA")]
		[Cpp2IlInjected.Address(RVA = "0xF9C670", Offset = "0xF9B070", VA = "0x180F9C670")]
		[AsyncStateMachine(typeof(_003CClaimMessage_003Ed__27))]
		public Task ClaimMessage(CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60027AB")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MailDisplayManager()
		{
		}
	}
}
