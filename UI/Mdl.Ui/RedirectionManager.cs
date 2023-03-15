using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Characters;
using Mdl.Grid;
using Mdl.Motion;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Online;
using Meta.Tracking;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000875")]
	public class RedirectionManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40031E9")]
		internal Dictionary<RedirectionType, AsyncMenu> _dictMenu = (Dictionary<RedirectionType, AsyncMenu>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40031EA")]
		[SerializeField]
		private AssetReferenceGameObject _prefabIngameDebug;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40031EB")]
		[Space]
		[SerializeField]
		private RectTransform _joystickHitArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40031EC")]
		[SerializeField]
		private CanvasScaler _joystickCanvasScaler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40031ED")]
		[SerializeField]
		[Space]
		private AsyncMenu _menuPhone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40031EE")]
		[SerializeField]
		private AsyncMenu _menuEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40031EF")]
		[SerializeField]
		private AsyncMenu _menuEventHub;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40031F0")]
		[SerializeField]
		private AsyncMenu _menuCatalog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40031F1")]
		[SerializeField]
		private AsyncMenu _menuMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40031F2")]
		[SerializeField]
		private AsyncMenu _menuShop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40031F3")]
		[SerializeField]
		private AsyncMenu _menuGift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40031F4")]
		[SerializeField]
		private AsyncMenu _menuWardrobe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40031F5")]
		[SerializeField]
		private AsyncMenu _menuAvatarCustom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40031F6")]
		[SerializeField]
		private AsyncMenu _menuLevelup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40031F7")]
		[SerializeField]
		private AsyncMenu _menuProfessionChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40031F8")]
		[SerializeField]
		private AsyncMenu _menuMemoryShardsPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40031F9")]
		[SerializeField]
		private AsyncMenu _menuNotEnoughCurrencyPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40031FA")]
		[SerializeField]
		private AsyncMenu _menuPlayerNamePopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40031FB")]
		[SerializeField]
		private AsyncMenu _menuWishSelectPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40031FC")]
		[SerializeField]
		private AsyncMenu _menuPresentPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40031FD")]
		[SerializeField]
		private AsyncMenu _menuPhoto;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40031FE")]
		[SerializeField]
		private AsyncMenu _menuItemInfoPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40031FF")]
		[SerializeField]
		private AsyncMenu _menuEventOpeningPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003200")]
		[SerializeField]
		private AsyncMenu _menuCharacterUnlockedPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003201")]
		[SerializeField]
		private AsyncMenu _menuCharacterSummon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003202")]
		[SerializeField]
		private AsyncMenu _menuRequestReward;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4003203")]
		[SerializeField]
		private AsyncMenu _menuDecal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4003204")]
		[SerializeField]
		private AsyncMenu _menuCollection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4003205")]
		[SerializeField]
		private AsyncMenu _menuAchievement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4003206")]
		[SerializeField]
		private AsyncMenu _menuNewItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4003207")]
		[SerializeField]
		private AsyncMenu _menuQuestLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4003208")]
		[SerializeField]
		private AsyncMenu _menuEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4003209")]
		[SerializeField]
		private AsyncMenu _menuInGameShop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400320A")]
		[SerializeField]
		private AsyncMenu _menuSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400320B")]
		[SerializeField]
		private AsyncMenu _menuMiniEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400320C")]
		[SerializeField]
		private AsyncMenu _menuStorage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400320D")]
		[SerializeField]
		private AsyncMenu _menuHouseExpansion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400320E")]
		[SerializeField]
		private AsyncMenu _menuInventoryFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400320F")]
		[SerializeField]
		private AsyncMenu _menuCrafting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003210")]
		[SerializeField]
		private AsyncMenu _tutorialMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003211")]
		[SerializeField]
		private AsyncMenu _menuFastTravelPopUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4003212")]
		[SerializeField]
		private AsyncMenu _menuInventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003213")]
		[SerializeField]
		private AsyncMenu _menuSideInventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003214")]
		[SerializeField]
		private AssetReference _resetScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003215")]
		[SerializeField]
		private AsyncMenu _startMenuCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4003216")]
		[SerializeField]
		private AsyncMenu _skinPopup;

		[Cpp2IlInjected.Token(Token = "0x4003218")]
		private const int _menuFlowLimit = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4003219")]
		private Queue<RedirectionType> _menuFlow = (Queue<RedirectionType>)(object)new Queue<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400321A")]
		private bool _isInRedirection;

		[Cpp2IlInjected.Token(Token = "0x17000787")]
		public bool IsInRedirection
		{
			[Cpp2IlInjected.Token(Token = "0x6003576")]
			[Cpp2IlInjected.Address(RVA = "0xE2EB60", Offset = "0xE2D560", VA = "0x180E2EB60")]
			get
			{
				return _isInRedirection;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000788")]
		public GameObject IngameDebug
		{
			[Cpp2IlInjected.Token(Token = "0x6003577")]
			[Cpp2IlInjected.Address(RVA = "0x976350", Offset = "0x974D50", VA = "0x180976350")]
			[CompilerGenerated]
			get
			{
				return _003CIngameDebug_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003578")]
			[Cpp2IlInjected.Address(RVA = "0xE2EB70", Offset = "0xE2D570", VA = "0x180E2EB70")]
			[CompilerGenerated]
			set
			{
				_003CIngameDebug_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003579")]
		[Cpp2IlInjected.Address(RVA = "0xE2E580", Offset = "0xE2CF80", VA = "0x180E2E580")]
		private void Start()
		{
			//Discarded unreachable code: IL_000d, IL_001a, IL_0027, IL_0034, IL_0050, IL_0069, IL_0087, IL_00d0, IL_00ef
			//IL_004a: Expected O, but got I4
			//IL_0066: Expected O, but got I4
			//IL_0084: Expected O, but got I4
			Dictionary<RedirectionType, AsyncMenu> dictMenu = _dictMenu;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600357A")]
		[Cpp2IlInjected.Address(RVA = "0xE2B2B0", Offset = "0xE29CB0", VA = "0x180E2B2B0")]
		public RedirectionType GetRedirectionType(AssetReference assetReference)
		{
			//Discarded unreachable code: IL_001c, IL_0022, IL_0028
			bool flag = default(bool);
			do
			{
				int num = 0;
				Dictionary<RedirectionType, AsyncMenu> dictMenu = _dictMenu;
			}
			while (flag && assetReference.AssetGUID == null);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600357B")]
		[Cpp2IlInjected.Address(RVA = "0xE2B250", Offset = "0xE29C50", VA = "0x180E2B250")]
		public AsyncMenu GetMenuAssetReference(RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_0009
			Dictionary<RedirectionType, AsyncMenu> dictMenu = _dictMenu;
			AsyncMenu result = default(AsyncMenu);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600357C")]
		[Cpp2IlInjected.Address(RVA = "0xE2B460", Offset = "0xE29E60", VA = "0x180E2B460")]
		public bool IsMenuRedirection(RedirectionType redirectionType)
		{
			if (redirectionType != 0)
			{
				int num = 0;
			}
			return redirectionType < RedirectionType.GameClickButton;
		}

		[Cpp2IlInjected.Token(Token = "0x600357D")]
		[Cpp2IlInjected.Address(RVA = "0xE2BCB0", Offset = "0xE2A6B0", VA = "0x180E2BCB0")]
		public unsafe void Redirect(RedirectionType redirectionType, [Optional] MenuParam menuParam, [Optional] PlayerTaskCollider playerTaskCollider, [Optional] ItemFilterData itemFilters, [Optional] string bundleId, [Optional] Action resultItemsGiven, bool useFadeOutEffect = false, bool popAllAboveHud = false, bool skipConfirmation = false, bool saveProfile = true)
		{
			//Discarded unreachable code: IL_02cc, IL_02dc, IL_02e1, IL_02eb, IL_02ee, IL_02f3, IL_02f6, IL_02fb, IL_031e, IL_0326
			//IL_0015: Expected I4, but got O
			//IL_0021: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_00e8: Expected O, but got I4
			//IL_00e8: Expected I4, but got I8
			//IL_00e8: Expected O, but got I4
			//IL_00e8: Expected O, but got I4
			//IL_014e: Expected I4, but got I8
			//IL_01e8: Expected O, but got I4
			//IL_0209: Expected O, but got I4
			//IL_0217: Expected O, but got I4
			//IL_0225: Expected O, but got I4
			//IL_0233: Expected O, but got I4
			//IL_0241: Expected O, but got I4
			//IL_0250: Expected O, but got I4
			//IL_0266: Expected O, but got I4
			//IL_0274: Expected O, but got I4
			//IL_0282: Expected O, but got I4
			//IL_0290: Expected O, but got I4
			//IL_029c: Expected O, but got I4
			//IL_031b: Expected O, but got I4
			int num = 0;
			Queue<RedirectionType> menuFlow = _menuFlow;
			RedirectionType redirectionType2 = (RedirectionType)((Queue<T>)(object)_menuFlow).Dequeue();
			bool flag = default(bool);
			if (flag)
			{
				RedirectionType redirectionType3 = default(RedirectionType);
				string text = ((Enum)redirectionType3).ToString();
				RedirectionType redirectionType4 = redirectionType3;
				string text2 = text.Replace("Menu", "");
				string text3 = "" + text2 + "/";
			}
			int num2 = 0;
			uint num3 = default(uint);
			if (SystemRoot.ErrorReporter != null && num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			int num4 = 0;
			UiRoot instance = UiRoot.Instance;
			MenuStack menuStack = instance._menuStack;
			MenuStack popupStack = instance._popupStack;
			HudMenu menu = menuStack.GetMenu<HudMenu>();
			MenuStack menuStack2 = instance._menuStack;
			Type typeFromHandle = typeof(HudMenu);
			menuStack2.PopAllAbove(typeFromHandle);
			FadeEffect fadeEffect = instance._fadeEffect;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = default(int);
			EasingFunction easingFunction = new EasingFunction(num8, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<float, float>*/)(&Easing.Linear));
			num8 = 0;
			ulong num9 = default(ulong);
			fadeEffect.Fade(1f, (Color)num5, (Color)num7, easingFunction, (byte)num9 != 0, (Tween<>.FinishEventHandler)num2);
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			menu?.HideBuffTip();
			if ((object)menu != null)
			{
			}
			CancellationToken cancellationToken = menu.CancellationToken;
			_003C_003Ec _003C_003E = default(_003C_003Ec);
			Func<Task> func = default(Func<Task>);
			if (_003C_003Ec._003C_003E9__71_0 == null)
			{
				_003C_003E = _003C_003Ec._003C_003E9;
				func = (Func<Task>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)new Func<TResult>(_003C_003E._003CQuitGameTask_003Eb__71_0));
			}
			int num10 = 0;
			ulong num11 = default(ulong);
			Task<bool> asyncTask = (Task<bool>)(object)this.DoExitTask("menu.quit_game_title", "menu.quit_game_save_desc", (byte)num10 != 0, (byte)num11 != 0, (Func<>)(object)func, cancellationToken);
			int num12 = 0;
			asyncTask.FireAndForgetTask();
			num12 += num12;
			if ((long)"menu.quit_game_save_desc" != 983040)
			{
				return;
			}
			int num13 = 0;
			int num14 = 0;
			Task task = default(Task);
			task.FireAndForgetTask();
			Client client = default(Client);
			if ((long)"menu.quit_game_save_desc" == 920832)
			{
				if (_003C_003E == null || task != null)
				{
				}
				SaveProfile.Types.Request request = new SaveProfile.Types.Request();
				request.forceSaving_ = true;
				CancellationToken cancellationToken2 = menu.CancellationToken;
				Task<SaveProfile.Types.Response> task2 = (Task<SaveProfile.Types.Response>)(object)client.SaveProfileAsync(request, cancellationToken2);
			}
			if ((long)"menu.quit_game_save_desc" == 921088)
			{
				if (client == null || client.NetworkData != null)
				{
				}
				int num15 = 0;
				if (menu == (UnityEngine.Object)num15)
				{
				}
				Func<Task> func2 = (Func<Task>)(object)new Func<TResult>(StopAndReturnToStartMenu);
				WardrobeMenuParam wardrobeMenuParam = new WardrobeMenuParam();
				wardrobeMenuParam.ItemFilters = (ItemFilterData)0;
				if (func2 != null)
				{
				}
				wardrobeMenuParam.OnFocusInAction = (Action)num2;
				if (func2 != null)
				{
				}
				wardrobeMenuParam.AnswerAction = (Action<int>)num2;
				if (func2 != null)
				{
				}
				wardrobeMenuParam.OnPopAction = (Action)num2;
				if (func2 != null)
				{
				}
				wardrobeMenuParam.Params = (object[])num2;
				CatalogMenuParam catalogMenuParam = new CatalogMenuParam();
				catalogMenuParam.ItemFilterData = (ItemFilterData)0;
				catalogMenuParam.IsInEditMode = true;
				if (func2 != null)
				{
				}
				catalogMenuParam.OnFocusInAction = (Action)num2;
				if (func2 != null)
				{
				}
				catalogMenuParam.AnswerAction = (Action<int>)num2;
				if (func2 != null)
				{
				}
				catalogMenuParam.OnPopAction = (Action)num2;
				if (func2 != null)
				{
				}
				catalogMenuParam.Params = (object[])num2;
				int num16 = 0;
				CatalogMenu catalogMenu = default(CatalogMenu);
				if (catalogMenu != (UnityEngine.Object)num16)
				{
					catalogMenu.IsPopAll = true;
				}
				int num17 = 0;
				MenuStack menuStack3 = UiRoot.Instance._menuStack;
				Type typeFromHandle2 = typeof(HudMenu);
				menuStack3.PopAllAbove(typeFromHandle2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600357E")]
		[Cpp2IlInjected.Address(RVA = "0xE2BB00", Offset = "0xE2A500", VA = "0x180E2BB00")]
		[AsyncStateMachine(typeof(_003CRedirectTask_003Ed__60))]
		public Task RedirectTask(CancellationToken ct, RedirectionType redirectionType, [Optional] MenuParam menuParam, [Optional] PlayerTaskCollider playerTaskCollider, [Optional] ItemFilterData itemFilters, [Optional] string bundleId, [Optional] Action resultItemsGiven, bool useFadeOutEffect = false, bool popAllAboveHud = false, bool waitUntilPop = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600357F")]
		[Cpp2IlInjected.Address(RVA = "0xE2AE00", Offset = "0xE29800", VA = "0x180E2AE00")]
		[AsyncStateMachine(typeof(_003CDoPostCharacterUnlockFlow_003Ed__61))]
		internal Task DoPostCharacterUnlockFlow(Item characterItem, bool skipPhotoMode, CancellationToken ct, bool fastFade = false)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003580")]
		[Cpp2IlInjected.Address(RVA = "0xE2B090", Offset = "0xE29A90", VA = "0x180E2B090")]
		private Vector3 GetCharacterPosOffset(Mdl.Characters.Character character, out bool shouldCrouch)
		{
			int num = 0;
			if ("WallE!EVE" == null || num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003581")]
		[Cpp2IlInjected.Address(RVA = "0xE2AFB0", Offset = "0xE299B0", VA = "0x180E2AFB0")]
		private Vector3 GetCharacterPosOffset(Vector3 size, out bool shouldCrouch)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003582")]
		[Cpp2IlInjected.Address(RVA = "0xE2B7E0", Offset = "0xE2A1E0", VA = "0x180E2B7E0")]
		private Task OpenMenu(AsyncMenu asyncMenu, MenuStack stack, bool waitUntilExit, MenuParam param)
		{
			TaskCompletionSource<bool> tcs = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>();
			Action action = delegate
			{
				//Discarded unreachable code: IL_000e
				//IL_000c: Expected O, but got I4
				bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)1);
			};
			if (!waitUntilExit)
			{
			}
			IntPtr method_ptr = ((Delegate)action).method_ptr;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003583")]
		[Cpp2IlInjected.Address(RVA = "0xE2B5B0", Offset = "0xE29FB0", VA = "0x180E2B5B0")]
		private Task OpenMenu(RedirectionType redirectionType, [Optional] MenuParam menuParam, [Optional] PlayerTaskCollider playerTaskCollider, [Optional] ItemFilterData itemFilters, [Optional] string bundleId, [Optional] Action resultItemsGiven, bool useFadeOutEffect = false, bool popAllAboveHud = false, bool waitUntilPop = false)
		{
			if (menuParam == null)
			{
				MenuParam menuParam2 = new MenuParam();
			}
			TaskCompletionSource<bool> tcs = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>();
			if ((long)menuParam.OnFocusInAction == 0)
			{
				Action action = (menuParam.OnFocusInAction = delegate
				{
					//Discarded unreachable code: IL_000e
					//IL_000c: Expected O, but got I4
					bool flag2 = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)1);
				});
				if ((long)menuParam.OnPopAction == 0)
				{
					Action action2 = (menuParam.OnPopAction = delegate
					{
						//Discarded unreachable code: IL_000e
						//IL_000c: Expected O, but got I4
						bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)1);
					});
				}
			}
			Task<> task = (Task<>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003584")]
		[Cpp2IlInjected.Address(RVA = "0xE2E980", Offset = "0xE2D380", VA = "0x180E2E980")]
		[AsyncStateMachine(typeof(_003CToggleIngameDebug_003Ed__66))]
		public Task ToggleIngameDebug(bool show)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003585")]
		[Cpp2IlInjected.Address(RVA = "0xE2AF40", Offset = "0xE29940", VA = "0x180E2AF40")]
		[IteratorStateMachine(typeof(_003CFetchCanvasHelperRef_003Ed__67))]
		private IEnumerator FetchCanvasHelperRef()
		{
			int _003C_003E1__state = default(int);
			_003CFetchCanvasHelperRef_003Ed__67 _003CFetchCanvasHelperRef_003Ed__ = new _003CFetchCanvasHelperRef_003Ed__67(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CFetchCanvasHelperRef_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003586")]
		[Cpp2IlInjected.Address(RVA = "0xE2B480", Offset = "0xE29E80", VA = "0x180E2B480")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_0035
			//IL_0011: Expected O, but got I4
			int num = 0;
			CanvasHelper instanceMain = CanvasHelper.InstanceMain;
			int num2 = 0;
			if (instanceMain != (UnityEngine.Object)num2)
			{
				int num3 = 0;
				CanvasHelper instanceMain2 = CanvasHelper.InstanceMain;
				CanvasHelper.OrientationEventHandler value = OnOrientationChanged;
				instanceMain2.OnOrientationChanged -= value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003587")]
		[Cpp2IlInjected.Address(RVA = "0xE2B5A0", Offset = "0xE29FA0", VA = "0x180E2B5A0")]
		private void OnOrientationChanged(bool isLandscape)
		{
			RefreshMenuLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6003588")]
		[Cpp2IlInjected.Address(RVA = "0xE2DB30", Offset = "0xE2C530", VA = "0x180E2DB30")]
		public void RefreshMenuLayout()
		{
			//Discarded unreachable code: IL_0049
			//IL_001b: Expected O, but got I4
			int num = 0;
			CanvasScaler component = UiRoot.Instance._menuStack.GetComponent<CanvasScaler>();
			int num2 = 0;
			if (!(component == (UnityEngine.Object)num2))
			{
				int num3 = 0;
				IMenu top = UiRoot.Instance._menuStack.Top;
				if (top == null)
				{
				}
				int num4 = 0;
				bool flag = default(bool);
				if (flag)
				{
					bool isStaticMenu = top.IsStaticMenu;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003589")]
		[Cpp2IlInjected.Address(RVA = "0xE2B960", Offset = "0xE2A360", VA = "0x180E2B960")]
		public Task QuitGameTask(CancellationToken ct, bool skipConfirmation = false, bool saveProfile = true)
		{
			if (!saveProfile)
			{
			}
			Func<Task> func = default(Func<Task>);
			if (_003C_003Ec._003C_003E9__71_0 == null)
			{
				func = (Func<Task>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<TResult>)delegate
				{
					int num = 0;
					UiRoot.Instance?._popupStack?.PopAll();
					TrackingManager.Instance?.OnExitGame();
					int num2 = 0;
					Application.Quit();
					int num3 = 0;
					return Task.CompletedTask;
				});
			}
			Task<bool> task = (Task<bool>)(object)this.DoExitTask("menu.quit_game_title", "menu.quit_game_save_desc", skipConfirmation, saveProfile, (Func<>)(object)func, ct);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600358A")]
		[Cpp2IlInjected.Address(RVA = "0xE2DCA0", Offset = "0xE2C6A0", VA = "0x180E2DCA0")]
		public Task ReturnToMainMenuTask(CancellationToken ct, bool skipConfirmation = false, bool saveProfile = true)
		{
			Func<Task> func = (Func<Task>)(object)new Func<TResult>(StopAndReturnToStartMenu);
			Task<bool> task = (Task<bool>)(object)this.DoExitTask("menu.return_to_main_menu_title", "menu.return_to_main_menu_desc", skipConfirmation, saveProfile, (Func<>)(object)func, ct);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600358B")]
		[Cpp2IlInjected.Address(RVA = "0xE2E880", Offset = "0xE2D280", VA = "0x180E2E880")]
		[AsyncStateMachine(typeof(_003CStopAndReturnToStartMenu_003Ed__73))]
		public Task StopAndReturnToStartMenu()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600358C")]
		[Cpp2IlInjected.Address(RVA = "0xE2AC70", Offset = "0xE29670", VA = "0x180E2AC70")]
		[AsyncStateMachine(typeof(_003CDoExitTask_003Ed__74))]
		private Task<bool> DoExitTask(string titleLocId, string msgLocId, bool skipConfirmation, bool saveProfile, Func<Task> onExitCB, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600358D")]
		[Cpp2IlInjected.Address(RVA = "0xE2D900", Offset = "0xE2C300", VA = "0x180E2D900")]
		public void RefreshJoystick()
		{
			//Discarded unreachable code: IL_0063
			//IL_002e: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0062: Expected O, but got I8
			if (SystemRoot.Instance.GetSystem<PlayerNavigation>()._playerConfig.defaultControls != 0)
			{
				return;
			}
			RectTransform joystickHitArea = _joystickHitArea;
			CanvasScaler joystickCanvasScaler = _joystickCanvasScaler;
			int num = 0;
			if (joystickHitArea == (UnityEngine.Object)num)
			{
				return;
			}
			int num2 = 0;
			if (!(joystickCanvasScaler == (UnityEngine.Object)num2))
			{
				int num3 = 0;
				if (!CanvasHelper.InstanceMain.IsLandscape)
				{
					joystickCanvasScaler.m_MatchWidthOrHeight = 0.25f;
				}
				else
				{
					_joystickCanvasScaler = (CanvasScaler)0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600358E")]
		[Cpp2IlInjected.Address(RVA = "0xE2DD90", Offset = "0xE2C790", VA = "0x180E2DD90")]
		private void SetupAndPushCatalog([Optional] MenuParam menuParam, [Optional] ItemFilterData itemFilters, bool IsFromSideInventory = false)
		{
			//IL_0026: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			//IL_00f9: Expected I4, but got I8
			GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
			int num = 0;
			InventorySideMenu menu = UiRoot.Instance._menuStack.GetMenu<InventorySideMenu>();
			int num2 = 0;
			if (system != (UnityEngine.Object)num2 && system.CanStartEditMode)
			{
				menuParam?.OnFocusInAction?.Invoke();
				_isInRedirection = false;
				if (itemFilters != null)
				{
					GridEditModeStartData gridEditModeStartData = new GridEditModeStartData();
					gridEditModeStartData.ItemFilters = itemFilters;
					system.StartSystem(gridEditModeStartData);
				}
				int num3 = 0;
				system.StartSystem((ISystemData)num3);
			}
			int num4 = 0;
			if (system != (UnityEngine.Object)num4)
			{
				if (!IsFromSideInventory)
				{
					int num5 = 0;
					if (menu == (UnityEngine.Object)num5)
					{
						int num6 = 0;
						MenuStack menuStack = UiRoot.Instance._menuStack;
					}
				}
				int num7 = 0;
				MenuStack menuStack2 = UiRoot.Instance._menuStack;
				AsyncMenu menuCatalog = _menuCatalog;
				menuStack2.Push(menuCatalog, menuParam);
				return;
			}
			int num8 = 0;
			if (menuParam != null)
			{
				int num9 = 0;
				if (menuParam != null)
				{
					goto IL_00e5;
				}
				CatalogMenuParam catalogMenuParam = new CatalogMenuParam(menuParam);
			}
			CatalogMenuParam catalogMenuParam2 = new CatalogMenuParam();
			goto IL_00e5;
			IL_00e5:
			bool flag = default(bool);
			if (flag || flag)
			{
			}
			catalogMenuParam2.ForceOpenCatalog = true;
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			bool flag3 = (catalogMenuParam2.IsInEditMode = num8 != 0);
			catalogMenuParam2.ItemFilterData = itemFilters;
			bool flag4 = default(bool);
			while (flag4)
			{
			}
			int num10 = 0;
			MenuStack menuStack3 = UiRoot.Instance._menuStack;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600358F")]
		[Cpp2IlInjected.Address(RVA = "0xE2E240", Offset = "0xE2CC40", VA = "0x180E2E240")]
		private MenuParam SetupParamForSideMenu(MenuParam menuParam, RedirectionType redirectionType)
		{
			//Discarded unreachable code: IL_00c8
			object[] array3;
			do
			{
				IL_0000:
				if (menuParam == null)
				{
					MenuParam menuParam2 = new MenuParam();
					object[] array = new object[1];
					if (array != null && array == null)
					{
						goto IL_0000;
					}
					array[0] = array;
				}
				object[] @params = menuParam.Params;
				if (@params != null)
				{
					int length = @params.Length;
					if (length != 0)
					{
						int num = length + 1;
						object[] array2 = new object[num];
						int num2 = 0;
						int length2 = array2.Length;
						if (num2 < length2)
						{
							object[] params2 = menuParam.Params;
							object obj = params2[num2];
							if (obj != null && params2 == null)
							{
								goto IL_0000;
							}
							array2[0] = obj;
							num2++;
						}
						if (num2 != 0 && num2 == 0)
						{
							goto IL_0000;
						}
						num += 4;
					}
				}
				array3 = new object[1];
			}
			while (array3 != null && array3 == null);
			array3[0] = array3;
			menuParam.Params = array3;
			return menuParam;
		}

		[Cpp2IlInjected.Token(Token = "0x6003590")]
		[Cpp2IlInjected.Address(RVA = "0xE2EAA0", Offset = "0xE2D4A0", VA = "0x180E2EAA0")]
		public RedirectionManager()
		{
		}
	}
}
