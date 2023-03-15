using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007AB")]
	[RequiredAllNotNull]
	public class HouseExpansionInfo : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002D18")]
		private int _currentFloorIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002D19")]
		private Action<int> _chooseFloorDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002D1A")]
		public CanvasGroup CanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002D1B")]
		[SerializeField]
		public ShortcutDefinition _shortcutDefinition;

		[Cpp2IlInjected.Token(Token = "0x170006E2")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x600310A")]
			[Cpp2IlInjected.Address(RVA = "0xAEF2A0", Offset = "0xAEDCA0", VA = "0x180AEF2A0")]
			get
			{
				float alpha = CanvasGroup.alpha;
				int num = 0;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x600310B")]
			[Cpp2IlInjected.Address(RVA = "0xAEF2D0", Offset = "0xAEDCD0", VA = "0x180AEF2D0")]
			set
			{
				//Discarded unreachable code: IL_0015
				//IL_0014: Expected F4, but got I4
				CanvasGroup canvasGroup = CanvasGroup;
				if (value)
				{
				}
				int num = 0;
				canvasGroup.alpha = num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600310C")]
		[Cpp2IlInjected.Address(RVA = "0xAEED70", Offset = "0xAED770", VA = "0x180AEED70", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [System.Runtime.InteropServices.Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_001d
			//IL_0011: Expected I4, but got O
			//IL_001c: Expected O, but got I4
			int num = 0;
			if ((object)typeof(int).TypeHandle != null)
			{
				HouseExpansionInfo houseExpansionInfo = default(HouseExpansionInfo);
				_currentFloorIndex = (int)houseExpansionInfo;
				if ((object)houseExpansionInfo != null)
				{
				}
				_chooseFloorDelegate = (Action<int>)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600310D")]
		[Cpp2IlInjected.Address(RVA = "0xAEF180", Offset = "0xAEDB80", VA = "0x180AEF180", Slot = "13")]
		protected override void Update()
		{
			//Discarded unreachable code: IL_0047
			base.Update();
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num2 = 0;
			IMenu top = menuStack.Top;
			if (top != null)
			{
				int num3 = 0;
				if (top != null && Input.GetButtonDown(_shortcutDefinition.Self.RewiredActionId))
				{
					OnActionClicked();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600310E")]
		[Cpp2IlInjected.Address(RVA = "0xAEEEB0", Offset = "0xAED8B0", VA = "0x180AEEEB0")]
		private void OnActionClicked()
		{
			//Discarded unreachable code: IL_00ab
			//IL_00a5: Expected O, but got I4
			//IL_00a5: Expected O, but got I4
			//IL_00a5: Expected O, but got I4
			//IL_00a5: Expected O, but got I4
			HouseExpansionMenu.HouseExpansionMenuParam houseExpansionMenuParam = new HouseExpansionMenu.HouseExpansionMenuParam();
			int num = (houseExpansionMenuParam.NumberOfFloorsInTheHouse = ((RepeatedField<T>)(object)SystemRoot.Instance.MetaClient.profile.world_.playerHouse_.floors_).Count);
			int num2 = (houseExpansionMenuParam.CurrentFloorIndex = _currentFloorIndex);
			Action<int> action = (houseExpansionMenuParam.ChooseFloorDelegate = _chooseFloorDelegate);
			houseExpansionMenuParam.Gizmo = this;
			int num3 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num4 = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			int num5 = 0;
			IMenu bottom = menuStack.Bottom;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			CancellationToken ct = default(CancellationToken);
			redirection.RedirectTask(ct, RedirectionType.MenuHouseExpansion, houseExpansionMenuParam, (PlayerTaskCollider)num7, (ItemFilterData)num7, (string)num7, (Action)num7, (byte)num7 != 0, (byte)num7 != 0, (byte)num7 != 0).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600310F")]
		[Cpp2IlInjected.Address(RVA = "0x87D270", Offset = "0x87BC70", VA = "0x18087D270")]
		public HouseExpansionInfo()
		{
		}
	}
}
