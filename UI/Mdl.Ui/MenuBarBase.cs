using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200026A")]
	public class MenuBarBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000AE2")]
		public MainMenuTabButton SelectedTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000AE3")]
		public CanvasGroup CanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000AE4")]
		[SerializeField]
		protected RectTransform _content;

		[Cpp2IlInjected.Token(Token = "0x6000F65")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		public virtual void RefreshDisplay()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000F66")]
		[Cpp2IlInjected.Address(RVA = "0x118DF30", Offset = "0x118C930", VA = "0x18118DF30", Slot = "5")]
		public virtual void SetSelectedTab(RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_008c
			//IL_0043: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			List<MainMenuTabButton> list = (List<MainMenuTabButton>)(object)Enumerable.ToList<MainMenuTabButton>((IEnumerable<>)(object)_content.GetComponentsInChildren<MainMenuTabButton>(includeInactive: true));
			Predicate<MainMenuTabButton> predicate = (Predicate<MainMenuTabButton>)(object)(Predicate<T>)delegate(MainMenuTabButton x)
			{
				//Discarded unreachable code: IL_0031
				//IL_0010: Expected O, but got I4
				ShortcutDefinition shortcutDefinition = x.ShortcutDefinition;
				int num4 = 0;
				bool flag2 = shortcutDefinition != (UnityEngine.Object)num4;
				if (!flag2)
				{
					return flag2;
				}
				ShortcutDefinition shortcutDefinition2 = x.ShortcutDefinition;
				RedirectionType redirectionType2 = redirectionType;
				return shortcutDefinition2.RedirectionType == redirectionType2;
			};
			MainMenuTabButton mainMenuTabButton = (MainMenuTabButton)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			int num = 0;
			if (mainMenuTabButton != (UnityEngine.Object)num)
			{
				MainMenuTabButton selectedTab = SelectedTab;
				int num2 = 0;
				if (selectedTab != (UnityEngine.Object)num2)
				{
					MainMenuTabButton selectedTab2 = SelectedTab;
					int num3 = ((selectedTab2.IsSelected = false) ? 1 : 0);
				}
				SelectedTab = mainMenuTabButton;
				SelectedTab.IsSelected = true;
				RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F67")]
		[Cpp2IlInjected.Address(RVA = "0x118DC60", Offset = "0x118C660", VA = "0x18118DC60", Slot = "6")]
		public virtual void Redirect(MainMenuTabButton navTabButton, [Optional] ItemFilterData filter)
		{
			//Discarded unreachable code: IL_003f
			//IL_0010: Expected O, but got I4
			ShortcutDefinition shortcutDefinition = navTabButton.ShortcutDefinition;
			int num = 0;
			if (shortcutDefinition != (UnityEngine.Object)num)
			{
				int num2 = 0;
				MenuStack menuStack = UiRoot.Instance._menuStack;
				int num3 = 0;
				IMenu bottom = menuStack.Bottom;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F68")]
		[Cpp2IlInjected.Address(RVA = "0x118DB10", Offset = "0x118C510", VA = "0x18118DB10")]
		[AsyncStateMachine(typeof(_003CRedirectTask_003Ed__6))]
		public Task RedirectTask(MainMenuTabButton navTabButton, CancellationToken ct, [Optional] ItemFilterData filter)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F69")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MenuBarBase()
		{
		}
	}
}
