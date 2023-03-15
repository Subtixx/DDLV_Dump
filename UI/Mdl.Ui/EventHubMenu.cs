using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200047A")]
	public class EventHubMenu : TemplateMenu
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40016BC")]
		[SerializeField]
		private LoopVerticalScrollRect _eventList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40016BD")]
		[SerializeField]
		private EventHubEventDetails _eventDetails;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40016BE")]
		private MiniEventProgress[] _miniEvents;

		[Cpp2IlInjected.Token(Token = "0x6001CFC")]
		[Cpp2IlInjected.Address(RVA = "0x13FB020", Offset = "0x13F9A20", VA = "0x1813FB020", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0047
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_eventList).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnEventItemData);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_eventList).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnEventItemSelected);
			((UnityEvent<T0>)(object)onItemSelect).AddListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CFD")]
		[Cpp2IlInjected.Address(RVA = "0x13FB150", Offset = "0x13F9B50", VA = "0x1813FB150", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0047
			((object)this)._002Ector();
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)_eventList).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnEventItemData);
			((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
			LoopScrollRect.ListEvents onItemSelect = ((LoopScrollRect)_eventList).m_OnItemSelect;
			UnityAction<ListEventData> unityAction2 = (UnityAction<ListEventData>)(object)new UnityAction<T0>(OnEventItemSelected);
			((UnityEvent<T0>)(object)onItemSelect).RemoveListener((UnityAction<>)(object)unityAction2);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CFE")]
		[Cpp2IlInjected.Address(RVA = "0x13FAD30", Offset = "0x13F9730", VA = "0x1813FAD30", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//IL_00af: Expected I4, but got I8
			base.OnPush(stack, param);
			GameObject gameObject = _eventDetails.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			MiniEventStatesData miniEventStates_ = _003CInstance_003Ek__BackingField.MetaClient.profile.player_.miniEventStates_;
			if (miniEventStates_ == null)
			{
				return;
			}
			MapField<string, MiniEventProgress> progress_ = miniEventStates_.progress_;
			if (progress_ == null || ((MapField<TKey, TValue>)(object)progress_).Count <= 0)
			{
				return;
			}
			MiniEventProgress[] array = (_miniEvents = new MiniEventProgress[((MapField<TKey, TValue>)(object)progress_).Count]);
			ICollection<MiniEventProgress> values = (ICollection<MiniEventProgress>)((MapField<TKey, TValue>)(object)progress_).get_Values();
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				if (num2 == (int)num3)
				{
					num += num;
					throw new NullReferenceException();
				}
				num2++;
			}
			ulong num4 = default(ulong);
			_eventDetails.gameObject.SetActive((byte)num4 != 0);
			MiniEventProgress[] miniEvents = _miniEvents;
			LoopVerticalScrollRect eventList = _eventList;
			int num5 = (eventList.totalCount = miniEvents.Length);
			LoopVerticalScrollRect eventList2 = _eventList;
			int num7 = (eventList2.SelectedIndex = 0);
			LoopVerticalScrollRect eventList3 = _eventList;
			int offset = 0;
			eventList3.RefillCells(offset);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CFF")]
		[Cpp2IlInjected.Address(RVA = "0x13FABC0", Offset = "0x13F95C0", VA = "0x1813FABC0")]
		public void OnEventItemData(ListEventData data)
		{
			//Discarded unreachable code: IL_0041
			EventListItem component = data.DisplayObject.GetComponent<EventListItem>();
			MiniEventProgress[] miniEvents = _miniEvents;
			int itemIndex = data.ItemIndex;
			MiniEventProgress miniEvent = miniEvents[itemIndex];
			bool selected = _eventList.SelectedIndex == data.ItemIndex;
			component.Refresh(miniEvent, selected);
		}

		[Cpp2IlInjected.Token(Token = "0x6001D00")]
		[Cpp2IlInjected.Address(RVA = "0x13FAC90", Offset = "0x13F9690", VA = "0x1813FAC90")]
		public void OnEventItemSelected(ListEventData data)
		{
			//Discarded unreachable code: IL_0041
			_eventDetails.gameObject.SetActive(value: true);
			EventHubEventDetails eventDetails = _eventDetails;
			MiniEventProgress[] miniEvents = _miniEvents;
			int itemIndex = data.ItemIndex;
			MiniEventProgress miniEvent = miniEvents[itemIndex];
			eventDetails.Refresh(miniEvent);
			_eventList.RefreshCells();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D01")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF70", Offset = "0xE19970", VA = "0x180E1AF70")]
		public EventHubMenu()
		{
		}
	}
}
