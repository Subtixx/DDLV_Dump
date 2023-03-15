using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200045A")]
	public class EventContentLeaderboard : EventContentBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40015FA")]
		private EventContentLeaderboardModel _model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40015FB")]
		[SerializeField]
		private LoopVerticalScrollRect _listItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40015FC")]
		[SerializeField]
		private EventLeaderboardRecordItem _playerRecordItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40015FD")]
		[SerializeField]
		private RectTransform _mcRewardsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40015FE")]
		[SerializeField]
		private GameObject _prefabRewardItem;

		[Cpp2IlInjected.Token(Token = "0x6001C21")]
		[Cpp2IlInjected.Address(RVA = "0xF26C30", Offset = "0xF25630", VA = "0x180F26C30")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0035
			LoopVerticalScrollRect listItems = _listItems;
			LoopScrollRect.ScrollDelegate value = OnScrollUpdated;
			listItems.ScrollUpdate += value;
			int _003C_003E1__state = default(int);
			_003COnRepeat_003Ed__10 _003COnRepeat_003Ed__ = new _003COnRepeat_003Ed__10(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRepeat_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003COnRepeat_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6001C22")]
		[Cpp2IlInjected.Address(RVA = "0xF26B10", Offset = "0xF25510", VA = "0x180F26B10")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0042
			LoopVerticalScrollRect listItems = _listItems;
			LoopScrollRect.ScrollDelegate value = OnScrollUpdated;
			listItems.ScrollUpdate -= value;
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C23")]
		[Cpp2IlInjected.Address(RVA = "0xF26ED0", Offset = "0xF258D0", VA = "0x180F26ED0", Slot = "4")]
		public override void RefreshData(EventContentModelBase model)
		{
			//Discarded unreachable code: IL_0032
			if (model != null)
			{
				int num = 0;
				if (model != null)
				{
					int num2 = 0;
					_model = (EventContentLeaderboardModel)model;
					EventContentLeaderboardModel model2 = _model;
					EventLeaderboardRecordItem playerRecordItem = _playerRecordItem;
					EventLeaderboardRecordModel eventLeaderboardRecordModel = (playerRecordItem._model = model2.PlayerRecord);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C24")]
		[Cpp2IlInjected.Address(RVA = "0xF26FB0", Offset = "0xF259B0", VA = "0x180F26FB0", Slot = "5")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0088
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemData2 = ((LoopScrollRect)_listItems).m_OnItemData;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
			((UnityEvent<T0>)(object)onItemData2).AddListener((UnityAction<>)(object)unityAction2);
			List<EventLeaderboardRecordModel> records = _model.Records;
			LoopVerticalScrollRect listItems = _listItems;
			int num = (listItems.totalCount = ((List<>)(object)records)._size);
			LoopVerticalScrollRect listItems2 = _listItems;
			int offset = 0;
			listItems2.RefillCells(offset);
			RefreshPlayerRecord();
			RefreshRewards();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C25")]
		[Cpp2IlInjected.Address(RVA = "0xF26D20", Offset = "0xF25720", VA = "0x180F26D20")]
		private void OnItemDataHandler(ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001C26")]
		[Cpp2IlInjected.Address(RVA = "0xF26E50", Offset = "0xF25850", VA = "0x180F26E50")]
		[IteratorStateMachine(typeof(_003COnRepeat_003Ed__10))]
		private IEnumerator OnRepeat()
		{
			int _003C_003E1__state = default(int);
			_003COnRepeat_003Ed__10 _003COnRepeat_003Ed__ = new _003COnRepeat_003Ed__10(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003COnRepeat_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C27")]
		[Cpp2IlInjected.Address(RVA = "0xF27130", Offset = "0xF25B30", VA = "0x180F27130")]
		private void RefreshPlayerRecord()
		{
			//Discarded unreachable code: IL_006a, IL_0070, IL_0076, IL_007c, IL_008e
			int num = 0;
			IEnumerator enumerator = ((LoopScrollRect)_listItems).m_Content.GetEnumerator();
			EventLeaderboardRecordModel model = default(EventLeaderboardRecordModel);
			bool flag = default(bool);
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
				EventLeaderboardRecordModel playerRecord = _model.PlayerRecord;
				EventLeaderboardRecordItem eventLeaderboardRecordItem = default(EventLeaderboardRecordItem);
				model = eventLeaderboardRecordItem._model;
				flag = playerRecord == model;
				while (playerRecord != model)
				{
				}
			}
			if (model != null)
			{
				int num4 = 0;
			}
			bool active = !flag;
			GameObject gameObject = default(GameObject);
			gameObject.SetActive(active);
			GameObject gameObject2 = default(GameObject);
			if (!gameObject2.activeSelf)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C28")]
		[Cpp2IlInjected.Address(RVA = "0xF27390", Offset = "0xF25D90", VA = "0x180F27390")]
		public void RefreshRewards()
		{
			//Discarded unreachable code: IL_0158, IL_015e, IL_0164, IL_016a, IL_0170, IL_0176, IL_017c, IL_0182, IL_0188, IL_018e, IL_0194, IL_019a, IL_01a6
			int num = 0;
			if ((IntPtr)_model == (IntPtr)num)
			{
				return;
			}
			DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
			MegaEventProgress megaEventProgress_ = SystemRoot.Instance.MetaClient.profile.player_.megaEventProgress_;
			if (!megaEventProgress_.IsActive)
			{
			}
			int num2 = 0;
			MegaEventData megaEventData = FakeData.Instance.MegaEventData;
			DateTime _003CEndTime_003Ek__BackingField = megaEventProgress_.EndTime;
			DateTime _003CStartTime_003Ek__BackingField = megaEventProgress_.StartTime;
			bool _003CIsFinished_003Ek__BackingField = megaEventData.GetState(serverTime, _003CStartTime_003Ek__BackingField, _003CEndTime_003Ek__BackingField) == MegaEventState.InRewarding;
			int childCount = _mcRewardsHolder.childCount;
			List<EventLeaderboardRewardModel> rewards = _model.Rewards;
			GameObject prefabRewardItem = _prefabRewardItem;
			RectTransform mcRewardsHolder = _mcRewardsHolder;
			GameObject gameObject = UnityEngine.Object.Instantiate(prefabRewardItem, mcRewardsHolder);
			childCount++;
			EventContentLeaderboardModel model = _model;
			IEnumerator enumerator = _mcRewardsHolder.GetEnumerator();
			if (enumerator != null)
			{
				if (enumerator == null)
				{
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				List<EventLeaderboardRewardModel> rewards2 = _model.Rewards;
				int active = 0;
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive((byte)active != 0);
				GameObject gameObject3 = default(GameObject);
				gameObject3.SetActive(value: true);
				EventLeaderboardRewardItem eventLeaderboardRewardItem = default(EventLeaderboardRewardItem);
				eventLeaderboardRewardItem.IsFinished = _003CIsFinished_003Ek__BackingField;
				int num4 = (eventLeaderboardRewardItem.PlayerRank = _model.PlayerRecord.Rank);
				EventContentLeaderboardModel model2 = _model;
				List<EventLeaderboardRewardModel> rewards3 = model2.Rewards;
				eventLeaderboardRewardItem.Model = (EventLeaderboardRewardModel)(object)model2;
				eventLeaderboardRewardItem.RefreshDisplay();
				Transform transform = default(Transform);
				if ((object)transform != null)
				{
				}
				num++;
			}
			if ((object)typeof(RectTransform).TypeHandle != null)
			{
				int num5 = 0;
			}
			Transform transform2 = default(Transform);
			if ((object)transform2 == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C29")]
		[Cpp2IlInjected.Address(RVA = "0xF26EC0", Offset = "0xF258C0", VA = "0x180F26EC0")]
		private void OnScrollUpdated()
		{
			RefreshPlayerRecord();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C2A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventContentLeaderboard()
		{
		}
	}
}
