using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Buildings;
using Mdl.Items;
using Mdl.Systems;
using Mdl.Utils;
using ScreenEffect;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007E3")]
	public class StallShelfPriceButton : BaseButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4002E5E")]
		[NotNull]
		[SerializeField]
		private StallShelfPriceCell StallShelfPriceCell;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4002E5F")]
		[SerializeField]
		private AK.Wwise.Event onHoverStallItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4002E60")]
		public bool IsSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E1")]
		[Cpp2IlInjected.Token(Token = "0x4002E61")]
		public bool IsHighLighted;

		[Cpp2IlInjected.Token(Token = "0x6003247")]
		[Cpp2IlInjected.Address(RVA = "0x855B70", Offset = "0x854570", VA = "0x180855B70", Slot = "10")]
		public override void OnHighlightEnter()
		{
			//Discarded unreachable code: IL_0043
			//IL_0041: Expected O, but got I4
			if (!IsHighLighted)
			{
				AK.Wwise.Event @event = onHoverStallItem;
				IsHighLighted = true;
				if (@event != null)
				{
					GameObject gameObject = base.gameObject;
					uint num = @event.Post(gameObject);
				}
				GameObject target = StallShelfPriceCell._target;
				int num2 = 0;
				ScreenEffect.Highlight.AddHighlightTo(target, (AnimationCurve)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003248")]
		[Cpp2IlInjected.Address(RVA = "0x855C30", Offset = "0x854630", VA = "0x180855C30", Slot = "11")]
		public override void OnHighlightExit()
		{
			//Discarded unreachable code: IL_0032
			//IL_0030: Expected O, but got I4
			if (!IsSelected && IsHighLighted)
			{
				StallShelfPriceCell stallShelfPriceCell = StallShelfPriceCell;
				IsHighLighted = false;
				GameObject target = stallShelfPriceCell._target;
				int num = 0;
				ScreenEffect.Highlight.RemoveHighlightFrom(target, (AnimationCurve)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003249")]
		[Cpp2IlInjected.Address(RVA = "0x855760", Offset = "0x854160", VA = "0x180855760")]
		public void OnClicked()
		{
			//IL_0049: Expected O, but got I4
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			int num3 = 0;
			if (top != null)
			{
				int num4 = 0;
				if (top != null)
				{
					StallShelfInteractionEventArgs stallShelfInteractionEventArgs = new StallShelfInteractionEventArgs();
					if ((object)SystemRoot.Instance.GetSystem<StallSystem>().CurrentStall != null)
					{
						int num5 = 0;
					}
					stallShelfInteractionEventArgs.Stall = (ShoppingStall)num3;
					Item item = (stallShelfInteractionEventArgs.Item = StallShelfPriceCell._target.GetComponentInChildren<ItemScript>().Item);
					GameObject gameObject = (stallShelfInteractionEventArgs.Shelf = StallShelfPriceCell._target);
					return;
				}
			}
			int num6 = 0;
			MenuStack menuStack2 = UiRoot.Instance._menuStack;
			int num7 = 0;
			IMenu top2 = menuStack2.Top;
			while (top2 == null)
			{
			}
			int num8 = 0;
			while (top2 == null)
			{
			}
			StallShelfInteractionEventArgs stallShelfInteractionEventArgs2 = new StallShelfInteractionEventArgs();
			StallSystem stallSystem = default(StallSystem);
			Stall _003CCurrentStall_003Ek__BackingField = stallSystem.CurrentStall;
			if ((object)_003CCurrentStall_003Ek__BackingField != null)
			{
				int num9 = 0;
			}
			stallShelfInteractionEventArgs2.Stall = (ShoppingStall)_003CCurrentStall_003Ek__BackingField;
			Item item2 = (stallShelfInteractionEventArgs2.Item = StallShelfPriceCell._target.GetComponentInChildren<ItemScript>().Item);
			GameObject gameObject2 = (stallShelfInteractionEventArgs2.Shelf = StallShelfPriceCell._target);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600324A")]
		[Cpp2IlInjected.Address(RVA = "0x855CC0", Offset = "0x8546C0", VA = "0x180855CC0")]
		public StallShelfPriceButton()
		{
		}
	}
}
