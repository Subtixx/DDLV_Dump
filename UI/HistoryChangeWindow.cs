using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Ui;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HistoryChangeWindow : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public Action OnClose;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[SerializeField]
	private ListBase _itemList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	[SerializeField]
	private BaseButton _okButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	[SerializeField]
	[Header("Sizing")]
	private float _singleRowHeight = 483f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	[SerializeField]
	private float _doubleRowHeight = 741f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	[SerializeField]
	private RectTransform _mcContent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	[SerializeField]
	private GridLayoutGroup _mcGridLayoutGroup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private Mdl.Avatar.AvatarCustomization _avatarCustomization;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private ListInventory _inventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private List<Item> _dataList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private FocusNavigation _focusNavigation;

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xAEA220", Offset = "0xAE8C20", VA = "0x180AEA220")]
	public void SetData(Mdl.Avatar.AvatarCustomization avatarCustomization, ListInventory inventory, List<Item> dataList, int nbItems)
	{
		//Discarded unreachable code: IL_0032
		_avatarCustomization = avatarCustomization;
		_inventory = inventory;
		_dataList = dataList;
		List<Item> dataList2 = _dataList;
		ListBase itemList = _itemList;
		int num = (itemList.TotalCount = ((List<>)(object)dataList2)._size);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0xAE9690", Offset = "0xAE8090", VA = "0x180AE9690")]
	public void OnEnable()
	{
		//Discarded unreachable code: IL_0041
		ListBase.ListEvents onItemData = _itemList.m_OnItemData;
		UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
		((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
		ListBase.ListEvents onItemTap = _itemList.m_OnItemTap;
		UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemTap);
		((UnityEvent<T0>)(object)onItemTap).AddListener((UnityAction<>)(object)unityAction2);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0xAE9580", Offset = "0xAE7F80", VA = "0x180AE9580")]
	public void OnDisable()
	{
		//Discarded unreachable code: IL_0041
		ListBase.ListEvents onItemData = _itemList.m_OnItemData;
		UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
		((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		ListBase.ListEvents onItemTap = _itemList.m_OnItemTap;
		UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemTap);
		((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xAE9470", Offset = "0xAE7E70", VA = "0x180AE9470")]
	public void OnDestroy()
	{
		//Discarded unreachable code: IL_0041
		ListBase.ListEvents onItemData = _itemList.m_OnItemData;
		UnityAction<ListBase.ListEventData> unityAction = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemDataHandler);
		((UnityEvent<T0>)(object)onItemData).RemoveListener((UnityAction<>)(object)unityAction);
		ListBase.ListEvents onItemTap = _itemList.m_OnItemTap;
		UnityAction<ListBase.ListEventData> unityAction2 = (UnityAction<ListBase.ListEventData>)(object)new UnityAction<T0>(OnItemTap);
		((UnityEvent<T0>)(object)onItemTap).RemoveListener((UnityAction<>)(object)unityAction2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0xAEA2D0", Offset = "0xAE8CD0", VA = "0x180AEA2D0")]
	public void SetFocus(FocusNavigation focusNavigation)
	{
		//Discarded unreachable code: IL_007e
		//IL_0071: Expected O, but got I4
		_focusNavigation = focusNavigation;
		List<Item> dataList = _dataList;
		ListBase itemList = _itemList;
		int index = 0;
		FocusNavigationElement component = itemList.GetItemByDataIndex(index).gameObject.GetComponent<FocusNavigationElement>();
		FocusNavigationElement component2 = _okButton.GetComponent<FocusNavigationElement>();
		focusNavigation.SetFocus(component2);
		List<Item> dataList2 = _dataList;
		RectTransform mcContent = _mcContent;
		int size = ((List<>)(object)dataList2)._size;
		int num = 0;
		Vector2 sizeDelta = mcContent.sizeDelta;
		if (size > 6)
		{
		}
		mcContent.sizeDelta = (Vector2)num;
		_mcGridLayoutGroup.constraintCount = 1;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0xAE97A0", Offset = "0xAE81A0", VA = "0x180AE97A0")]
	private void OnItemDataHandler(ListBase.ListEventData args)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0xAE9F70", Offset = "0xAE8970", VA = "0x180AE9F70")]
	private void OnItemTap(ListBase.ListEventData args)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0xAE93C0", Offset = "0xAE7DC0", VA = "0x180AE93C0")]
	[IteratorStateMachine(typeof(_003CDelayedStartFocus_003Ed__18))]
	public IEnumerator DelayedStartFocus()
	{
		int _003C_003E1__state = default(int);
		_003CDelayedStartFocus_003Ed__18 _003CDelayedStartFocus_003Ed__ = new _003CDelayedStartFocus_003Ed__18(_003C_003E1__state);
		_003C_003E1__state = 0;
		_003CDelayedStartFocus_003Ed__._003C_003E4__this = this;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xAE9430", Offset = "0xAE7E30", VA = "0x180AE9430")]
	public void OnClickOk()
	{
		//Discarded unreachable code: IL_0022
		OnClose?.Invoke();
		GameObject gameObject = base.gameObject;
		int active = 0;
		gameObject.SetActive((byte)active != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0xAEA450", Offset = "0xAE8E50", VA = "0x180AEA450")]
	public HistoryChangeWindow()
	{
	}
}
