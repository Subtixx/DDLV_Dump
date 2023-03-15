using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Cheats;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Ui.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x20009D3")]
	[CreateAssetMenu]
	internal class CheatShowMenu : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40039BB")]
		private int _selectedMenuIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40039BC")]
		private RedirectionType _selectedRedirectione;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40039BD")]
		public AsyncMenu DebugAddBackpackMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40039BE")]
		public AsyncMenu DebugShorcutIndicator;

		[Cpp2IlInjected.Token(Token = "0x17000866")]
		public string[] MenuNames
		{
			[Cpp2IlInjected.Token(Token = "0x6003D7D")]
			[Cpp2IlInjected.Address(RVA = "0x1000530", Offset = "0xFFEF30", VA = "0x181000530")]
			get
			{
				//Discarded unreachable code: IL_0098
				//IL_0076: Expected O, but got I4
				List<string> list = (List<string>)(object)new List<T>();
				((List<T>)(object)list).Add((T)"Hud");
				((List<T>)(object)list).Add((T)"Game");
				Array values = Enum.GetValues(typeof(RedirectionType));
				List<string> list2 = (List<string>)(object)new List<T>();
				int num = 0;
				RedirectionType redirectionType;
				if ((redirectionType = RedirectionType.None) == RedirectionType.None)
				{
					Predicate<string> predicate = (Predicate<string>)(object)(Predicate<T>)delegate(string x)
					{
						//Discarded unreachable code: IL_001f
						//IL_000d: Expected O, but got I4
						RedirectionType redirectionType3 = redirectionType;
						string text = ((Enum)redirectionType3).ToString();
						redirectionType = redirectionType3;
						return text.Contains(x);
					};
					if (!((List<T>)(object)list).Exists((Predicate<>)(object)predicate))
					{
						RedirectionType redirectionType2 = redirectionType;
						string item = ((Enum)redirectionType2).ToString();
						redirectionType = redirectionType2;
						((List<T>)(object)list2).Add((T)item);
					}
				}
				num++;
				return (string[])(object)((List<T>)(object)list2).ToArray();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000867")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\UI\\Cheats\\CheatShowMenu.cs", 34)]
		public int Menu
		{
			[Cpp2IlInjected.Token(Token = "0x6003D7E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return _selectedMenuIndex;
			}
			[Cpp2IlInjected.Token(Token = "0x6003D7F")]
			[Cpp2IlInjected.Address(RVA = "0x1000850", Offset = "0xFFF250", VA = "0x181000850")]
			set
			{
				//Discarded unreachable code: IL_000e
				string text = MenuNames[value];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003D80")]
		[Cpp2IlInjected.Address(RVA = "0x1000380", Offset = "0xFFED80", VA = "0x181000380")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\UI\\Cheats\\CheatShowMenu.cs", 49)]
		public void OpenMenu()
		{
			//Discarded unreachable code: IL_0051
			//IL_004b: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num2 = 0;
			CancellationToken cancellationToken = UiRoot.Instance._menuStack.GetMenu<HudMenu>().CancellationToken;
			RedirectionType selectedRedirectione = _selectedRedirectione;
			int num3 = 0;
			int num4 = 0;
			redirection.RedirectTask(cancellationToken, selectedRedirectione, (MenuParam)num4, (PlayerTaskCollider)num3, (ItemFilterData)num3, (string)num3, (Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6003D81")]
		[Cpp2IlInjected.Address(RVA = "0x1000480", Offset = "0xFFEE80", VA = "0x181000480")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\UI\\Cheats\\CheatShowMenu.cs", 63)]
		public void ShowAddBackpackItemMenu()
		{
			//Discarded unreachable code: IL_001f
			//IL_001e: Expected O, but got I4
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			AsyncMenu debugAddBackpackMenu = DebugAddBackpackMenu;
			int num2 = 0;
			menuStack.Push(debugAddBackpackMenu, (MenuParam)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D82")]
		[Cpp2IlInjected.Address(RVA = "0x10004C0", Offset = "0xFFEEC0", VA = "0x1810004C0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\UI\\Cheats\\CheatShowMenu.cs", 69)]
		public void ShowDebugShorcutIndicator()
		{
			//Discarded unreachable code: IL_001f
			//IL_001e: Expected O, but got I4
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			AsyncMenu debugShorcutIndicator = DebugShorcutIndicator;
			int num2 = 0;
			menuStack.Push(debugShorcutIndicator, (MenuParam)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6003D83")]
		[Cpp2IlInjected.Address(RVA = "0x1000500", Offset = "0xFFEF00", VA = "0x181000500")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\UI\\Cheats\\CheatShowMenu.cs", 75)]
		public void ShowDisclaimerPrompt()
		{
			//Discarded unreachable code: IL_000e
			int num = 0;
			IDesignerHost activeDesigner = ((IDesignerEventService)UiRoot.Instance).ActiveDesigner;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D84")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public CheatShowMenu()
		{
		}
	}
}
