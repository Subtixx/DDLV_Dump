using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x2000900")]
	internal class FaceSelectionView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000901")]
		public delegate void FacePartTypeSelected(FacePartType facePartType, int index);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003559")]
		public LoopVerticalScrollRect loopScrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400355B")]
		private FacePartType _currentType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400355C")]
		private List<AvatarFaceConfig.FacePartOption> _options = (List<AvatarFaceConfig.FacePartOption>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x14000068")]
		public event FacePartTypeSelected OnFacePartTypeSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003891")]
			[Cpp2IlInjected.Address(RVA = "0x1525B20", Offset = "0x1524520", VA = "0x181525B20")]
			[CompilerGenerated]
			add
			{
				FacePartTypeSelected onFacePartTypeSelected = this.OnFacePartTypeSelected;
				Delegate @delegate = Delegate.Combine(onFacePartTypeSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFacePartTypeSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003892")]
			[Cpp2IlInjected.Address(RVA = "0x1525BC0", Offset = "0x15245C0", VA = "0x181525BC0")]
			[CompilerGenerated]
			remove
			{
				FacePartTypeSelected onFacePartTypeSelected = this.OnFacePartTypeSelected;
				Delegate @delegate = Delegate.Remove(onFacePartTypeSelected, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFacePartTypeSelected)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003893")]
		[Cpp2IlInjected.Address(RVA = "0x1525610", Offset = "0x1524010", VA = "0x181525610")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0021
			LoopScrollRect.ListEvents onItemData = ((LoopScrollRect)loopScrollRect).m_OnItemData;
			UnityAction<ListEventData> unityAction = (UnityAction<ListEventData>)(object)new UnityAction<T0>(UpdateData);
			((UnityEvent<T0>)(object)onItemData).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6003894")]
		[Cpp2IlInjected.Address(RVA = "0x15257F0", Offset = "0x15241F0", VA = "0x1815257F0")]
		private void UpdateData(ListEventData data)
		{
			//Discarded unreachable code: IL_00cb
			FaceTypeView component = data.DisplayObject.GetComponent<FaceTypeView>();
			int size = ((List<>)(object)_options)._size;
			int num = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			FaceTypeView.Selected value = SelectOption;
			FaceTypeView.Selected onSelected = component.OnSelected;
			Delegate @delegate = Delegate.Remove(onSelected, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onSelected)
				{
				}
				FaceTypeView.Selected b = SelectOption;
				FaceTypeView.Selected onSelected2 = component.OnSelected;
				Delegate delegate2 = Delegate.Combine(onSelected2, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					while ((object)delegate2 != onSelected2)
					{
					}
					int itemIndex = data.ItemIndex;
					Button button = component._button;
					component.Index = itemIndex;
					button.m_OnClick.RemoveAllListeners();
					Button.ButtonClickedEvent onClick = component._button.m_OnClick;
					UnityAction call = component.SelectCurrent;
					onClick.AddListener(call);
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003895")]
		[Cpp2IlInjected.Address(RVA = "0xE44720", Offset = "0xE43120", VA = "0x180E44720")]
		public void Clear()
		{
			//Discarded unreachable code: IL_003c
			//IL_000e: Expected I4, but got I8
			loopScrollRect.totalCount = 0;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)loopScrollRect).m_Content;
			int num = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x6003896")]
		[Cpp2IlInjected.Address(RVA = "0x15256D0", Offset = "0x15240D0", VA = "0x1815256D0")]
		public void Populate(FacePartType facePartType, AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_0084
			//IL_0010: Expected I4, but got I8
			loopScrollRect.totalCount = 0;
			LoopVerticalScrollRect loopVerticalScrollRect = loopScrollRect;
			int offset = 0;
			loopVerticalScrollRect.RefillCells(offset);
			RectTransform content = ((LoopScrollRect)loopScrollRect).m_Content;
			int num = 0;
			Vector2 vector = (content.anchoredPosition = Vector2.zero);
			_currentType = facePartType;
			List<AvatarFaceConfig.FacePartOption> options = default(List<AvatarFaceConfig.FacePartOption>);
			_options = options;
			List<AvatarFaceConfig.FacePartOption> options2 = _options;
			LoopVerticalScrollRect loopVerticalScrollRect2 = loopScrollRect;
			int num2 = (loopVerticalScrollRect2.totalCount = ((List<>)(object)options2)._size);
			LoopVerticalScrollRect loopVerticalScrollRect3 = loopScrollRect;
			int offset2 = 0;
			loopVerticalScrollRect3.RefillCells(offset2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003897")]
		[Cpp2IlInjected.Address(RVA = "0x15257D0", Offset = "0x15241D0", VA = "0x1815257D0")]
		private void SelectOption(int index)
		{
			FacePartTypeSelected onFacePartTypeSelected = this.OnFacePartTypeSelected;
			if (onFacePartTypeSelected != null)
			{
				FacePartType currentType = _currentType;
				onFacePartTypeSelected(currentType, index);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003898")]
		[Cpp2IlInjected.Address(RVA = "0x1525AA0", Offset = "0x15244A0", VA = "0x181525AA0")]
		public FaceSelectionView()
		{
		}
	}
}
