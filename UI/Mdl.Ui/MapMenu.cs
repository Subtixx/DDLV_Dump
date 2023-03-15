using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AK.Wwise;
using Assets.Scripts.Gestures;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using Gameloft.Common;
using glPlayFab.Disney;
using Mdl.Activities;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Gestures;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000633")]
	[RequiredAllNotNull]
	public class MapMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000634")]
		private enum specificSecretLocation
		{
			[Cpp2IlInjected.Token(Token = "0x40022EC")]
			none,
			[Cpp2IlInjected.Token(Token = "0x40022ED")]
			beachCave
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4002287")]
		public float MagnetDist = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4002288")]
		[Range(0f, 1f)]
		public float SpeedCap = 0.009f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4002289")]
		[Range(0f, 1f)]
		public float TweakScrollFactor = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x400228A")]
		[SerializeField]
		private float _consoleSpeedCapMultiplier = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400228B")]
		[SerializeField]
		private float _consoleScrollFactorMultiplier = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x400228C")]
		[ItemID]
		[Space]
		[SerializeField]
		private int _moanaBoatItemID = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400228D")]
		[SerializeField]
		[ItemID]
		private int _walleGardenItemID = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x400228E")]
		[SerializeField]
		[ItemID]
		private int _restaurantItemID = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400228F")]
		[SerializeField]
		[ItemID]
		private int _scroogeStoreItemID = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4002290")]
		[ItemID]
		[SerializeField]
		private int _dreamCastleItemID = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4002291")]
		[SerializeField]
		[ItemID]
		private int _giantWillowTreeItemID = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4002292")]
		[SerializeField]
		[ItemID]
		private int _beachCaveItemID = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4002293")]
		[SerializeField]
		[ItemID]
		private int _beachCaveSceneID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4002294")]
		[SerializeField]
		private float _scroogeHouseOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4002295")]
		private MapItem PinnedItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4002296")]
		private bool _isGamepadConnected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4002297")]
		private Vector2 _scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4002298")]
		private MapMenuParams _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4002299")]
		private bool _refreshCharactersInBuildings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400229A")]
		private List<ItemScript> _buildingScripts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400229B")]
		private List<ItemScript> _stallItemScripts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400229C")]
		private List<FastTravelDestination> _fastTravelPods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400229D")]
		private List<GameObject> _characterHouses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400229E")]
		private ItemScript _restaurantItemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400229F")]
		private GameObject _restaurantObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40022A0")]
		private ItemScript _playerHouseItemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40022A1")]
		private GameObject _playerHouseObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40022A2")]
		private ItemScript _giantWillowTreeItemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40022A3")]
		private GameObject _giantWillowTreeObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40022A4")]
		private ItemScript _beachCaveItemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40022A5")]
		private GameObject _beachCaveObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40022A6")]
		private ItemScript _scroogeStoreItemScript;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40022A7")]
		private GameObject _scroogeStoreObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40022A8")]
		private GameObject _castleObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40022A9")]
		private Dictionary<CharacterManager.CharacterInstance, GameObject> _dictCharacterItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40022AA")]
		private Dictionary<Item, Queue<GameObject>> _dictCharactersInBuildings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40022AB")]
		private MoveGesture _moveGesture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40022AC")]
		private MapCameraTransform _positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40022AD")]
		private FocusNavigationElement _focusedElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40022AE")]
		private Coroutine _coUpdateCharacters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40022AF")]
		private Meta.Character _hangingOutCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40022B0")]
		private CharacterManager _characterManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40022B1")]
		private RectTransform _mapBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40022B2")]
		[SerializeField]
		[Space]
		private GameObject _prefabCharacterItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40022B3")]
		[SerializeField]
		private GameObject _prefabHarvestItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40022B4")]
		[SerializeField]
		private MapGateItem _prefabGateItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40022B5")]
		[SerializeField]
		private GameObject _prefabCharacterHouseItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40022B6")]
		[SerializeField]
		private GameObject _prefabRestaurantItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40022B7")]
		[SerializeField]
		private GameObject _prefabStallItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40022B8")]
		[SerializeField]
		private GameObject _prefabBoatItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40022B9")]
		[SerializeField]
		private GameObject _prefabGardenItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40022BA")]
		[SerializeField]
		private GameObject _prefabStoreItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40022BB")]
		[SerializeField]
		[RequiredComponent(typeof(Camera))]
		private GameObject _mcCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40022BC")]
		[SerializeField]
		private GameObject _focusCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40022BD")]
		[SerializeField]
		private RectTransform _focusedHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x40022BE")]
		[SerializeField]
		private CanvasGroup _hoveredHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40022BF")]
		[SerializeField]
		private RectTransform _mcMapHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x40022C0")]
		[SerializeField]
		private GameObject _mcContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40022C1")]
		[SerializeField]
		private GameObject _mcBgHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x40022C2")]
		[SerializeField]
		private Transform _mcCameraDest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x40022C3")]
		[SerializeField]
		private GameObject _mcCharactersHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x40022C4")]
		[SerializeField]
		private GameObject _mcCropsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x40022C5")]
		[SerializeField]
		private GameObject _mcGatesHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x40022C6")]
		[SerializeField]
		private GameObject _mcAvatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x40022C7")]
		[SerializeField]
		private MapGateItem _mcWishingWellItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x40022C8")]
		[SerializeField]
		private GameObject _mcBuildingsHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x40022C9")]
		[SerializeField]
		private Button _btnFastTravel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x40022CA")]
		[SerializeField]
		private Button _btnFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x40022CB")]
		[SerializeField]
		private BaseButton _btnCastle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x40022CC")]
		[SerializeField]
		private MapFilterToggleButton _btnZoomIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x40022CD")]
		[SerializeField]
		private MapFilterToggleButton _btnZoomOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x40022CE")]
		[SerializeField]
		private RawImage _avatarPortrait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x40022CF")]
		[SerializeField]
		private MapFilterToggleButton _btnCharacterFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x40022D0")]
		[SerializeField]
		private MapFilterToggleButton _btnVegetableFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x40022D1")]
		[SerializeField]
		private MapFilterToggleButton _btnBuildingFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x40022D2")]
		private bool _characterFilterToggled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x359")]
		[Cpp2IlInjected.Token(Token = "0x40022D3")]
		private bool _vegetableFilterToggled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35A")]
		[Cpp2IlInjected.Token(Token = "0x40022D4")]
		private bool _buildingFilterToggled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x40022D5")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x40022D6")]
		[SerializeField]
		private GameObject _filtersHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x40022D7")]
		[SerializeField]
		[ItemID]
		private int _wildGardenItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x40022D8")]
		[SerializeField]
		private RectTransform ItemHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x40022D9")]
		[SerializeField]
		private Vector2 MapOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40022DA")]
		[SerializeField]
		private Vector2 MapOffsetGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x40022DB")]
		[SerializeField]
		private float _minZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x40022DC")]
		[SerializeField]
		private float _maxZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x40022DD")]
		[SerializeField]
		private float _defaultZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x40022DE")]
		[SerializeField]
		private float _cropGroupingDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x40022DF")]
		[SerializeField]
		private float _animMaxDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x40022E0")]
		[SerializeField]
		private AK.Wwise.Event _gamepadHoverSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x40022E1")]
		[SerializeField]
		private AK.Wwise.Event _zoomInSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x40022E2")]
		[SerializeField]
		private AK.Wwise.Event _zoomOutSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x40022E3")]
		public UnityEvent OnDisplayRefreshed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x40022E4")]
		[SerializeField]
		private float _alphaForLockBiome;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x40022E5")]
		[SerializeField]
		private float _alphaForLockAreaName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x40022E6")]
		[SerializeField]
		private float _alphaForUnlockAreaName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x40022E7")]
		private bool _isSameFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x40022E8")]
		private bool _isFastTravelMenuVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x40022E9")]
		private Coroutine _waitFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x40022EA")]
		[SerializeField]
		private RecycleBin _recycleBin;

		[Cpp2IlInjected.Token(Token = "0x17000616")]
		public List<FastTravelDestination> FastTravelPods
		{
			[Cpp2IlInjected.Token(Token = "0x6002860")]
			[Cpp2IlInjected.Address(RVA = "0x118AB30", Offset = "0x1189530", VA = "0x18118AB30")]
			get
			{
				return _fastTravelPods;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000617")]
		public MapGateItem McWishingWellItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002861")]
			[Cpp2IlInjected.Address(RVA = "0x118AB40", Offset = "0x1189540", VA = "0x18118AB40")]
			get
			{
				return _mcWishingWellItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000618")]
		public MapMenuParams MenuParam
		{
			[Cpp2IlInjected.Token(Token = "0x6002862")]
			[Cpp2IlInjected.Address(RVA = "0x976350", Offset = "0x974D50", VA = "0x180976350")]
			get
			{
				return _param;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002863")]
		[Cpp2IlInjected.Address(RVA = "0x1180AB0", Offset = "0x117F4B0", VA = "0x181180AB0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00a3
			//IL_0081: Expected O, but got I4
			base.OnPush(stack, param);
			Meta.Character character = (_hangingOutCharacter = SystemRoot.Instance.Client.Profile.HangoutState.HangingOutWithCharacter);
			CharacterManager characterManager = (_characterManager = SystemRoot.Instance.GetSystem<CharacterManager>());
			int num = 0;
			if (param != null)
			{
				object[] @params = param.Params;
				if (@params != null && @params.Length > num)
				{
					object obj = @params[0];
					if (obj != null)
					{
						if ((object)"{il2cpp array field local14->}" == (object)typeof(MapMenuParams).TypeHandle)
						{
						}
						int num2 = 0;
						if (obj != null)
						{
							int num3 = 0;
						}
					}
				}
			}
			_param = (MapMenuParams)num;
			int num4 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			SystemRoot.Instance.GetSystem<AudioManager>().PushGameState(AudioManager.GameState.MainMenu);
			_isFastTravelMenuVisible = (byte)num != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6002864")]
		[Cpp2IlInjected.Address(RVA = "0x11896D0", Offset = "0x11880D0", VA = "0x1811896D0")]
		[AsyncStateMachine(typeof(_003CUpdatePortrait_003Ed__108))]
		private Task UpdatePortrait()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002865")]
		[Cpp2IlInjected.Address(RVA = "0x11809D0", Offset = "0x117F3D0", VA = "0x1811809D0")]
		private void OnPopupStackChanged(IMenu menu)
		{
			//Discarded unreachable code: IL_0049
			if (_isFastTravelMenuVisible)
			{
			}
			if (menu == null)
			{
			}
			int num = 0;
			bool isFastTravelMenuVisible = menu != null;
			int num2 = 0;
			_isFastTravelMenuVisible = isFastTravelMenuVisible;
			if (UiRoot.Instance._popupStack.IsEmpty && _isFastTravelMenuVisible)
			{
				_isFastTravelMenuVisible = false;
				OnLayoutChange();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002866")]
		[Cpp2IlInjected.Address(RVA = "0x117DD60", Offset = "0x117C760", VA = "0x18117DD60")]
		private void OpenFastTravelTab()
		{
			//Discarded unreachable code: IL_003e
			//IL_003d: Expected I4, but got I8
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			MapFastTravelPopupArgs mapFastTravelPopupArgs = new MapFastTravelPopupArgs();
			mapFastTravelPopupArgs.MapMenu = this;
			int num2 = (mapFastTravelPopupArgs.TabIndex = 0);
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuMapFastTravel, mapFastTravelPopupArgs, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002867")]
		[Cpp2IlInjected.Address(RVA = "0x117DC40", Offset = "0x117C640", VA = "0x18117DC40")]
		private void OpenRealmsTabs()
		{
			//Discarded unreachable code: IL_0040
			//IL_0023: Expected I4, but got I8
			//IL_003f: Expected I4, but got I8
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			MapFastTravelPopupArgs mapFastTravelPopupArgs = new MapFastTravelPopupArgs();
			mapFastTravelPopupArgs.MapMenu = this;
			mapFastTravelPopupArgs.TabIndex = 1;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuMapFastTravel, mapFastTravelPopupArgs, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002868")]
		[Cpp2IlInjected.Address(RVA = "0x1180090", Offset = "0x117EA90", VA = "0x181180090", Slot = "26")]
		public override void OnPop()
		{
			//Discarded unreachable code: IL_014b, IL_015d, IL_0163, IL_0175, IL_017b, IL_018d, IL_0193, IL_01a5, IL_01ab, IL_01bd
			//IL_0030: Expected O, but got I4
			int num = 0;
			base.OnPop();
			_isFastTravelMenuVisible = (byte)num != 0;
			Transform transform = _mcWishingWellItem.transform;
			RectTransform rectTransform = (RectTransform)(transform.parentInternal = ItemHolder);
			PinnedItem = (MapItem)num;
			StopAllCoroutines();
			TweenMax.KillAllByCancelationToken(this);
			IEnumerator enumerator = _mcCharactersHolder.transform.GetEnumerator();
			GameObject gameObject = default(GameObject);
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
				UnityEngine.Object.Destroy(gameObject);
			}
			if ((object)gameObject != null)
			{
				int num4 = 0;
			}
			Type typeFromHandle = typeof(MapHarvestItem);
			int num5 = 0;
			IEnumerator enumerator2 = gameObject.transform.GetEnumerator();
			GameObject gameObject2 = default(GameObject);
			if (enumerator2 != null)
			{
				int num6 = 0;
				if (enumerator2 == null)
				{
					throw new InvalidCastException();
				}
				int num7 = 0;
				if (enumerator2 == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject2);
			}
			if ((object)gameObject2 != null)
			{
				int num8 = 0;
			}
			Transform transform2 = default(Transform);
			IEnumerator enumerator3 = transform2.GetEnumerator();
			GameObject gameObject3 = default(GameObject);
			if (enumerator3 != null)
			{
				int num9 = 0;
				if (enumerator3 == null)
				{
					throw new InvalidCastException();
				}
				int num10 = 0;
				if (enumerator3 == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject3);
			}
			if ((object)gameObject3 != null)
			{
				int num11 = 0;
			}
			IEnumerator enumerator4 = default(IEnumerator);
			GameObject gameObject4 = default(GameObject);
			if (enumerator4 != null)
			{
				int num12 = 0;
				if (enumerator4 == null)
				{
					throw new InvalidCastException();
				}
				int num13 = 0;
				if (enumerator4 == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject4);
			}
			if ((object)gameObject4 != null)
			{
				int num14 = 0;
			}
			Transform transform3 = default(Transform);
			IEnumerator enumerator5 = transform3.GetEnumerator();
			GameObject gameObject5 = default(GameObject);
			if (enumerator5 != null)
			{
				int num15 = 0;
				if (enumerator5 == null)
				{
					throw new InvalidCastException();
				}
				int num16 = 0;
				if (enumerator5 == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject5);
			}
			if ((object)gameObject5 != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002869")]
		[Cpp2IlInjected.Address(RVA = "0x19C5B40", Offset = "0x19C4540", VA = "0x1819C5B40")]
		private static IEnumerable<> Filter<T>(IEnumerable<> P_0, BuildingItemType P_1)
		{
			Func<ItemScript, bool> func = default(Func<ItemScript, bool>);
			IEnumerable<ItemScript> enumerable = (IEnumerable<ItemScript>)Enumerable.Where<ItemScript>(P_0, (Func<, >)(object)func);
			if (func == null)
			{
			}
			if (enumerable == null)
			{
			}
			IEnumerable<ItemScript> enumerable2 = default(IEnumerable<ItemScript>);
			IEnumerator<ItemScript> enumerator = (IEnumerator<ItemScript>)((IEnumerable<T>)enumerable2).GetEnumerator();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600286A")]
		[Cpp2IlInjected.Address(RVA = "0x117E570", Offset = "0x117CF70", VA = "0x18117E570", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_003a, IL_0091, IL_009e, IL_00a5, IL_00d0, IL_00d7, IL_0114, IL_0125, IL_012a, IL_0138, IL_0140, IL_014d, IL_015e, IL_016b, IL_017f, IL_0184, IL_019b, IL_01a0, IL_01a8, IL_01b7, IL_01c6, IL_01de, IL_01ed, IL_01f5, IL_0211, IL_0219, IL_0229, IL_022d, IL_024f, IL_0265, IL_0273, IL_027a, IL_028b, IL_02a1, IL_02af, IL_02b6, IL_02c7, IL_02dd, IL_02eb, IL_02f2, IL_032b, IL_036b, IL_0396, IL_03a2, IL_03ab, IL_03af, IL_03d9, IL_03fa, IL_0421, IL_042f, IL_0440, IL_0445, IL_044d, IL_0465, IL_0474, IL_0479, IL_0497, IL_049f
			//IL_008b: Expected O, but got I4
			//IL_0135: Expected O, but got I4
			//IL_0135: Expected O, but got I4
			//IL_0325: Expected O, but got I4
			//IL_033d: Expected I4, but got I8
			//IL_03d3: Expected O, but got I4
			//IL_041b: Expected O, but got I4
			//IL_0462: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			base.OnFocusIn();
			_refreshCharactersInBuildings = true;
			if ((_btnCharacterFilter._isSelected ? 1 : 0) != num)
			{
				IEnumerator routine = UpdateCharactersCoroutine();
				Coroutine coroutine = (_coUpdateCharacters = StartCoroutine(routine));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600286B")]
		[Cpp2IlInjected.Address(RVA = "0x117FC80", Offset = "0x117E680", VA = "0x18117FC80", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//Discarded unreachable code: IL_0030
			SystemRoot.Instance.GetSystem<AudioManager>().PopGameState();
			if (popAfterFocusOut)
			{
			}
			Coroutine waitFrame = _waitFrame;
			if (waitFrame != null)
			{
				StopCoroutine(waitFrame);
			}
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600286C")]
		[Cpp2IlInjected.Address(RVA = "0x1185030", Offset = "0x1183A30", VA = "0x181185030", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0022
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value = OnPopupStackChanged;
			popupStack.OnCurrentMenuChanged += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600286D")]
		[Cpp2IlInjected.Address(RVA = "0x11856E0", Offset = "0x11840E0", VA = "0x1811856E0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0036
			int num = 0;
			MenuStack popupStack = UiRoot.Instance._popupStack;
			MenuStack.CurrentMenuChanged value = OnPopupStackChanged;
			popupStack.OnCurrentMenuChanged -= value;
			MenuLayoutTemplate oldLayout = _oldLayout;
			((Menu)this).RemoveRewiredMapCategory(oldLayout);
			StopAllCoroutines();
		}

		[Cpp2IlInjected.Token(Token = "0x600286E")]
		[Cpp2IlInjected.Address(RVA = "0x117DC40", Offset = "0x117C640", VA = "0x18117DC40")]
		public void OnCastleClickHandler()
		{
			//Discarded unreachable code: IL_0040
			//IL_0023: Expected I4, but got I8
			//IL_003f: Expected I4, but got I8
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			MapFastTravelPopupArgs mapFastTravelPopupArgs = new MapFastTravelPopupArgs();
			mapFastTravelPopupArgs.MapMenu = this;
			mapFastTravelPopupArgs.TabIndex = 1;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuMapFastTravel, mapFastTravelPopupArgs, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600286F")]
		[Cpp2IlInjected.Address(RVA = "0x117DD60", Offset = "0x117C760", VA = "0x18117DD60")]
		public void OnFastTravelClicked()
		{
			//Discarded unreachable code: IL_003e
			//IL_003d: Expected I4, but got I8
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			MapFastTravelPopupArgs mapFastTravelPopupArgs = new MapFastTravelPopupArgs();
			mapFastTravelPopupArgs.MapMenu = this;
			int num2 = (mapFastTravelPopupArgs.TabIndex = 0);
			int num3 = 0;
			ulong num4 = default(ulong);
			redirection.Redirect(RedirectionType.MenuMapFastTravel, mapFastTravelPopupArgs, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num4 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002870")]
		[Cpp2IlInjected.Address(RVA = "0xF2E840", Offset = "0xF2D240", VA = "0x180F2E840")]
		public void OnCloseClicked()
		{
			//Discarded unreachable code: IL_001e
			AK.Wwise.Event @event = closeSFX;
			GameObject gameObject = base.gameObject;
			uint num = @event.Post(gameObject);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6002871")]
		[Cpp2IlInjected.Address(RVA = "0x117DE30", Offset = "0x117C830", VA = "0x18117DE30")]
		public void OnFilterUpdated()
		{
			//Discarded unreachable code: IL_015e, IL_0164, IL_0176, IL_017c, IL_018e, IL_0194, IL_01a6
			int num = 0;
			if ((_btnCharacterFilter._isSelected ? 1 : 0) == num)
			{
				Coroutine coUpdateCharacters = _coUpdateCharacters;
				StopCoroutine(coUpdateCharacters);
				((Dictionary<TKey, TValue>)(object)_dictCharacterItems).Clear();
				((Dictionary<TKey, TValue>)(object)_dictCharactersInBuildings).Clear();
				IEnumerator enumerator = _mcCharactersHolder.transform.GetEnumerator();
				GameObject gameObject = default(GameObject);
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
					UnityEngine.Object.Destroy(gameObject);
				}
				if ((object)gameObject == null)
				{
				}
			}
			if (_mcCharactersHolder.transform.childCount == 0)
			{
				_refreshCharactersInBuildings = true;
				RefreshCharacters(useAni: true);
			}
			MapFilterToggleButton btnVegetableFilter = _btnVegetableFilter;
			GameObject mcCropsHolder = _mcCropsHolder;
			if (!btnVegetableFilter._isSelected)
			{
				RecycleBin recycleBin = _recycleBin;
				Transform container = mcCropsHolder.transform;
				Type typeFromHandle = typeof(MapHarvestItem);
				int num4 = 0;
				recycleBin.SendChildrenToBin(container, typeFromHandle);
			}
			Transform transform = default(Transform);
			if (transform.childCount == 0)
			{
				RefreshCrops(useAni: true);
			}
			if (!_btnBuildingFilter._isSelected)
			{
				IEnumerator enumerator2 = _mcGatesHolder.transform.GetEnumerator();
				GameObject gameObject2 = default(GameObject);
				if (enumerator2 != null)
				{
					int num5 = 0;
					if (enumerator2 == null)
					{
						throw new InvalidCastException();
					}
					int num6 = 0;
					if (enumerator2 == null)
					{
						throw new InvalidCastException();
					}
					UnityEngine.Object.Destroy(gameObject2);
				}
				if ((object)gameObject2 != null)
				{
					int num7 = 0;
				}
				Transform transform2 = default(Transform);
				IEnumerator enumerator3 = transform2.GetEnumerator();
				GameObject gameObject3 = default(GameObject);
				if (enumerator3 != null)
				{
					int num8 = 0;
					if (enumerator3 == null)
					{
						throw new InvalidCastException();
					}
					int num9 = 0;
					if (enumerator3 == null)
					{
						throw new InvalidCastException();
					}
					UnityEngine.Object.Destroy(gameObject3);
				}
				if ((object)gameObject3 != null)
				{
					int num10 = 0;
				}
			}
			Transform transform3 = default(Transform);
			if (transform3.childCount != 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002872")]
		[Cpp2IlInjected.Address(RVA = "0x11897D0", Offset = "0x11881D0", VA = "0x1811897D0")]
		private void Update()
		{
			//IL_01ba: Expected O, but got I4
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			MoveGesture moveGesture = _moveGesture;
			int num2 = 0;
			if (moveGesture != null)
			{
				int num3 = 0;
				float deltaTime = Time.deltaTime;
				moveGesture.Update(deltaTime);
				MoveGesture moveGesture2 = _moveGesture;
				ScrollRect scrollRect = _scrollRect;
				bool flag2 = (scrollRect.enabled = !moveGesture2.TwoFingers);
				MoveGesture moveGesture3 = _moveGesture;
				float _003CDeltaScale_003Ek__BackingField = moveGesture3.DeltaScale;
				if (moveGesture3 != null)
				{
					float scaleDelta = _003CDeltaScale_003Ek__BackingField * 0.005f;
					ZoomInOut(scaleDelta);
				}
			}
			int count = instance._popupStack.Count;
			if (instance._genericAlert.gameObject.activeSelf)
			{
				return;
			}
			int num4 = 0;
			if ((_isGamepadConnected ? 1 : 0) == num4)
			{
			}
			float axis = Input.GetAxis(147);
			if (!(axis <= 0.2f))
			{
				ZoomInOut(axis);
			}
			if (_scrollRect.enabled)
			{
				if (!_isGamepadConnected)
				{
					return;
				}
				if (!_filtersHolder.activeSelf)
				{
					FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
					int num5 = ((focusNavigation.enabled = false) ? 1 : 0);
					base.MenuNavigation.FocusNavigation.ReleaseClickBlocking();
					float axis2 = Input.GetAxis(144);
					float axis3 = Input.GetAxis(145);
					axis = axis2;
					if (!(axis > 0.05f))
					{
						axis = axis3;
						if (axis <= 0.05f)
						{
							goto IL_01ba;
						}
					}
					float maxZoom = _maxZoom;
					float num6 = Mathf.Max(0.2f, maxZoom);
					float tweakScrollFactor = TweakScrollFactor;
					float speedCap = SpeedCap;
					int num7 = 0;
					if (InputDetectionHelper.IsConsole())
					{
					}
					maxZoom = num6;
					float num8 = Math.Min(num6, maxZoom);
					axis2 = num8;
					maxZoom = num6;
					float num9 = Math.Min(num8, maxZoom);
					ScrollRect scrollRect2 = _scrollRect;
					int num10 = 0;
					Vector2 normalizedPosition = scrollRect2.normalizedPosition;
					scrollRect2.normalizedPosition = (Vector2)num10;
					goto IL_01ba;
				}
			}
			while (!_isGamepadConnected)
			{
			}
			base.MenuNavigation.FocusNavigation.enabled = true;
			throw new NullReferenceException();
			IL_01ba:
			UpdateFocus(isInZoom: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002873")]
		[Cpp2IlInjected.Address(RVA = "0x1189CF0", Offset = "0x11886F0", VA = "0x181189CF0")]
		public void ZoomInOut(float scaleDelta)
		{
			//Discarded unreachable code: IL_01b9, IL_01bf, IL_01c5, IL_01d7
			//IL_005a: Expected O, but got I4
			//IL_01a7: Expected O, but got I4
			int num = 0;
			CanvasGroup hoveredHolder = _hoveredHolder;
			int num2 = ((hoveredHolder.blocksRaycasts = false) ? 1 : 0);
			IEnumerator enumerator = _hoveredHolder.transform.GetEnumerator();
			MouseOverFocusChange mouseOverFocusChange = default(MouseOverFocusChange);
			if (enumerator != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					num++;
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num6 = 0;
				mouseOverFocusChange.OnPointerExit((PointerEventData)num6);
			}
			if ((object)mouseOverFocusChange != null)
			{
				int num7 = 0;
			}
			Transform transform = default(Transform);
			if ((object)transform != null)
			{
			}
			Vector3 vector = default(Vector3);
			float z = vector.z;
			Vector3 vector2 = default(Vector3);
			float z2 = vector2.z;
			int num8 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			float z3;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num9 = 0;
				Vector3 vector3 = default(Vector3);
				z3 = vector3.z;
			}
			z3 = scaleDelta;
			float num10 = Mathf.Min(z3, -1f);
			num10 = scaleDelta;
			float num11 = Mathf.Min(num10, -1f);
			num11 = z;
			float num12 = Mathf.Min(num11, 1f);
			z = num12;
			num12 = num10;
			float num13 = Mathf.Max(num12, 1f);
			num13 = scaleDelta;
			float num14 = Mathf.Max(num13, 1f);
			num14 = z;
			float num15 = Mathf.Max(num14, 1f);
			Vector3 vector4 = default(Vector3);
			float z4 = vector4.z;
			if (!(1f > scaleDelta))
			{
				num10 = scaleDelta;
				Vector3 vector5 = default(Vector3);
				float z5 = vector5.z;
				Vector3 vector6 = default(Vector3);
				float z6 = vector6.z;
				Vector3 vector7 = default(Vector3);
				float z7 = vector7.z;
			}
			Vector3 vector8 = default(Vector3);
			float z8 = vector8.z;
			Vector3 vector9 = default(Vector3);
			float z9 = vector9.z;
			Vector3 vector10 = default(Vector3);
			float z10 = vector10.z;
			int num16 = 0;
			Vector3 vector11 = default(Vector3);
			float y = vector11.y;
			int num17 = 0;
			UiRoot instance2 = UiRoot.Instance;
			int useKeyboardAsController2 = 0;
			if (instance2.IsControllerConnected((byte)useKeyboardAsController2 != 0))
			{
			}
			if (z10 <= num13 || (object)transform != null)
			{
			}
			uint num18 = default(uint);
			if (num18 == 0)
			{
			}
			if ((object)transform != null)
			{
			}
			if (num18 == 0)
			{
			}
			if ((object)transform != null)
			{
			}
			int num19 = 0;
			if (transform != (UnityEngine.Object)num19)
			{
				Transform transform2 = transform.transform;
				Transform transform3 = default(Transform);
				if ((object)transform3 == null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002874")]
		[Cpp2IlInjected.Address(RVA = "0x11829B0", Offset = "0x11813B0", VA = "0x1811829B0")]
		private void RefreshCastle()
		{
			//Discarded unreachable code: IL_00af
			//IL_0010: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			GameObject castleObject = _castleObject;
			int num = 0;
			if (!(castleObject == (UnityEngine.Object)num))
			{
				if (!_btnCastle.gameObject.activeSelf)
				{
					_btnCastle.gameObject.SetActive(value: true);
				}
				Transform transform = _btnCastle.transform;
				GameObject mcContent = _mcContent;
				GameObject castleObject2 = _castleObject;
				Transform transform2 = mcContent.transform;
				int num2 = 0;
				if ((object)transform2 != null)
				{
				}
				BaseButton btnCastle = _btnCastle;
				int num3 = 0;
				btnCastle.transform.localScale = (Vector3)num3;
				BaseButton btnCastle2 = _btnCastle;
				int num4 = 0;
				float z = Vector3.one.z;
				int num5 = 0;
				TweenLiteArgs vars = default(TweenLiteArgs);
				TweenLite tweenLite = TweenLite.To(btnCastle2, 0.35f, vars, int.MinValue, this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002875")]
		[Cpp2IlInjected.Address(RVA = "0x1182D70", Offset = "0x1181770", VA = "0x181182D70")]
		private void RefreshCharacters(bool useAni = false)
		{
			//Discarded unreachable code: IL_025d, IL_0263, IL_0268, IL_0275, IL_0293, IL_029c, IL_02c5, IL_02cb, IL_02dd, IL_02e3, IL_02e9, IL_02ef, IL_02f5, IL_02fb, IL_0301, IL_0307, IL_030d, IL_0313, IL_0319, IL_031f, IL_0325, IL_032b, IL_0331, IL_0337, IL_033d, IL_0343, IL_0349, IL_034f, IL_0355, IL_035b, IL_0361, IL_0367, IL_036d, IL_0373, IL_0379, IL_037f, IL_0385, IL_038b, IL_0391, IL_0397, IL_039d, IL_03a3, IL_03a9, IL_03af, IL_03b5, IL_03bb, IL_03c1, IL_03c7, IL_03cd, IL_03d3
			//IL_0020: Expected I4, but got I8
			//IL_0086: Expected I4, but got I8
			//IL_00d2: Expected O, but got I4
			//IL_011c: Expected O, but got I4
			//IL_01b2: Expected O, but got I4
			//IL_01ca: Expected O, but got I4
			ulong num4 = default(ulong);
			GameObject gameObject = default(GameObject);
			CharacterManager characterManager = default(CharacterManager);
			ulong num8 = default(ulong);
			Func<CharacterManager.CharacterInstance, bool> func = default(Func<CharacterManager.CharacterInstance, bool>);
			Mdl.Online.Client client = default(Mdl.Online.Client);
			Meta.Character character = default(Meta.Character);
			Meta.Character character2 = default(Meta.Character);
			bool flag3 = default(bool);
			bool flag5 = default(bool);
			bool flag7 = default(bool);
			uint num12 = default(uint);
			Meta.Character character3 = default(Meta.Character);
			specificSecretLocation specificSecretLocation = default(specificSecretLocation);
			ItemScript itemScript = default(ItemScript);
			GameObject gameObject2 = default(GameObject);
			GameObject gameObject3 = default(GameObject);
			Action<MapItem> onMapItemClicked = default(Action<MapItem>);
			bool flag8 = default(bool);
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (!_mcAvatarItem.activeSelf)
				{
					_mcAvatarItem.SetActive((byte)num4 != 0);
				}
				Camera component = _mcCamera.GetComponent<Camera>();
				UpdateAvatar();
				IEnumerator enumerator = _mcCharactersHolder.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num5 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num6 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					UnityEngine.Object.Destroy(gameObject);
				}
				int num7 = 0;
				if ((object)gameObject != null)
				{
				}
				Dictionary<CharacterManager.CharacterInstance, GameObject> dictionary = (Dictionary<CharacterManager.CharacterInstance, GameObject>)(object)new Dictionary<TKey, TValue>();
				Dictionary<Item, Queue<GameObject>> dictionary2 = (Dictionary<Item, Queue<GameObject>>)(object)new Dictionary<TKey, TValue>();
				IEnumerable<CharacterManager.CharacterInstance> characterInstances = (IEnumerable<CharacterManager.CharacterInstance>)characterManager.GetCharacterInstances((byte)num8 != 0);
				if (_003C_003Ec._003C_003E9__125_0 == null)
				{
					func = (Func<CharacterManager.CharacterInstance, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CharacterManager.CharacterInstance x)
					{
						//Discarded unreachable code: IL_0018
						if (x.MetaCharacter == null)
						{
						}
						return !x.MetaCharacter.InRealm;
					});
				}
				IEnumerable<CharacterManager.CharacterInstance> enumerable = (IEnumerable<CharacterManager.CharacterInstance>)Enumerable.Where<CharacterManager.CharacterInstance>((IEnumerable<>)characterInstances, (Func<, >)(object)func);
				Profile profile = client.Profile;
				ProfileWorld world_ = profile.world_;
				int num9 = 0;
				IEnumerable<MissionSlot> allMissionSlot = (IEnumerable<MissionSlot>)world_.GetAllMissionSlot((Func<, >)num9);
				Meta.Character _003CHangingOutWithCharacter_003Ek__BackingField = profile.HangoutState.HangingOutWithCharacter;
				int num10 = Enumerable.Count<CharacterManager.CharacterInstance>((IEnumerable<>)enumerable);
				if (num10 != 0)
				{
					_003C_003Ec__DisplayClass125_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass125_0();
					CS_0024_003C_003E8__locals0.character = (CharacterManager.CharacterInstance)(object)CS_0024_003C_003E8__locals0;
					int num11 = 0;
					if (character.IsSecretAndHide)
					{
						continue;
					}
					int currentCharacterSchedule = (int)characterManager.GetCurrentCharacterSchedule((CharacterManager.CharacterInstance)num11);
					bool flag = _003CHangingOutWithCharacter_003Ek__BackingField == character2;
					if (_003CHangingOutWithCharacter_003Ek__BackingField == character2)
					{
					}
					if (currentCharacterSchedule == 2)
					{
					}
					bool flag2 = currentCharacterSchedule == 3;
					if (!flag && flag3)
					{
						bool flag4 = currentCharacterSchedule == 5;
					}
					if (!flag && flag5)
					{
						bool flag6 = currentCharacterSchedule == 6;
					}
					if (flag || flag7)
					{
					}
					if (currentCharacterSchedule == 9)
					{
					}
					if (num12 != 7 || !flag)
					{
					}
					ScheduleType freeTimeSchedule = _003CHangingOutWithCharacter_003Ek__BackingField.FreeTimeSchedule;
					if (num7 != 0)
					{
						int num13 = 0;
						if ((long)character3.secretCharacterData_ != 0 && specificSecretLocation == specificSecretLocation.beachCave)
						{
							Predicate<ItemScript> predicate = (Predicate<ItemScript>)(object)(Predicate<T>)delegate(ItemScript x)
							{
								Item item = x.Item;
								int house = CS_0024_003C_003E8__locals0.character.Data.House;
								throw new NullReferenceException();
							};
							int num14 = 0;
							if (!(itemScript == (UnityEngine.Object)num14))
							{
								gameObject2 = itemScript.gameObject;
								int num15 = 0;
								if (!(gameObject2 == (UnityEngine.Object)num15))
								{
								}
							}
						}
					}
					while ((object)gameObject2 == null)
					{
					}
					Transform transform = gameObject2.transform;
					gameObject3.GetComponent<MapCharacterItem>().OnMapItemClicked = onMapItemClicked;
					Transform transform2 = gameObject3.transform;
					int num16 = 0;
					float z = Vector3.one.z;
					int num17 = 0;
					int num18 = 0;
					int num19 = 0;
					int num20 = 0;
					if (num18 != 0)
					{
					}
					if (!flag8)
					{
						Transform transform3 = itemScript.gameObject.transform;
						int itemID = itemScript.Item.ItemID;
					}
					Transform transform4 = gameObject3.transform;
					float z2 = vector.z;
					float z3 = vector2.z;
					Transform transform5 = gameObject3.transform;
					throw new NullReferenceException();
				}
				if (num10 != 0)
				{
				}
				if (specificSecretLocation == specificSecretLocation.none)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002876")]
		[Cpp2IlInjected.Address(RVA = "0x117FDB0", Offset = "0x117E7B0", VA = "0x18117FDB0")]
		private void OnMapItemClicked(MapItem mapItem)
		{
			//Discarded unreachable code: IL_00a9
			//IL_0022: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00a5: Expected O, but got I4
			int num = 0;
			bool flag = default(bool);
			if (flag && (object)mapItem != null)
			{
				int num2 = 0;
				if ((object)mapItem != null)
				{
				}
			}
			FocusNavigationElement focusedElement = _focusedElement;
			int num3 = 0;
			if (!(focusedElement != (UnityEngine.Object)num3))
			{
				bool flag2 = this != mapItem;
				PinnedItem = mapItem;
			}
			MapItem component = _focusedElement.GetComponent<MapItem>();
			bool flag3 = component != focusedElement;
			PinnedItem = component;
			GameObject pinVisual = default(GameObject);
			if (_focusedHolder.childCount > 0)
			{
				RectTransform focusedHolder = _focusedHolder;
				int index = 0;
				pinVisual = focusedHolder.GetChild(index).GetComponent<MapItem>().PinVisual;
				int num4 = 0;
				bool active = component != (UnityEngine.Object)num4;
				pinVisual.SetActive(active);
			}
			int num5 = 0;
			if (!(pinVisual != (UnityEngine.Object)num5))
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002877")]
		[Cpp2IlInjected.Address(RVA = "0x1185790", Offset = "0x1184190", VA = "0x181185790")]
		private void UpdateAvatar()
		{
			//Discarded unreachable code: IL_0046
			//IL_003d: Expected O, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			Transform transform = _mcAvatarItem.transform;
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			GameObject mcContent = _mcContent;
			GameObject _003CgameObject_003Ek__BackingField = avatar.gameObject;
			Transform transform2 = mcContent.transform;
			int num = 0;
			if ((object)transform2 != null)
			{
			}
			Vector2 scale = ((MapMenu)RectTransformUtilities.GetPosOnUIFrom3D(_003CgameObject_003Ek__BackingField, (RectTransform)num))._scale;
			Vector2 vector = /*Error near IL_0043: Stack underflow*/* scale;
		}

		[Cpp2IlInjected.Token(Token = "0x6002878")]
		[Cpp2IlInjected.Address(RVA = "0x11860F0", Offset = "0x1184AF0", VA = "0x1811860F0")]
		[IteratorStateMachine(typeof(_003CUpdateCharactersCoroutine_003Ed__128))]
		private IEnumerator UpdateCharactersCoroutine()
		{
			int _003C_003E1__state = default(int);
			_003CUpdateCharactersCoroutine_003Ed__128 _003CUpdateCharactersCoroutine_003Ed__ = new _003CUpdateCharactersCoroutine_003Ed__128(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateCharactersCoroutine_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002879")]
		[Cpp2IlInjected.Address(RVA = "0x117D7B0", Offset = "0x117C1B0", VA = "0x18117D7B0")]
		private specificSecretLocation GetSpecificSecretLocation(CharacterManager.CharacterInstance character)
		{
			if (character.MetaCharacter.secretCharacterData_.spawnedInLocation_.locationTypeCase_ == SecretCharacterLocationFilter.LocationTypeOneofCase.Scene)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				int scene = character.MetaCharacter.secretCharacterData_.spawnedInLocation_.Scene;
				SceneItemData sceneItemData = default(SceneItemData);
				if (sceneItemData.sceneType_ == SceneType.Cave && (IntPtr)sceneItemData.Item == (IntPtr)_beachCaveSceneID)
				{
					return specificSecretLocation.beachCave;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600287A")]
		[Cpp2IlInjected.Address(RVA = "0x1186160", Offset = "0x1184B60", VA = "0x181186160")]
		private void UpdateCharacters()
		{
			//Discarded unreachable code: IL_0351, IL_0359
			//IL_0012: Expected I4, but got I8
			//IL_0072: Expected O, but got I4
			//IL_00af: Expected O, but got I4
			//IL_00cb: Expected O, but got I4
			//IL_00ee: Expected O, but got I4
			//IL_0124: Expected O, but got I4
			//IL_0155: Expected O, but got I4
			//IL_016d: Expected O, but got I4
			//IL_01d4: Expected O, but got I4
			//IL_01e0: Expected O, but got I4
			//IL_027c: Expected O, but got I4
			//IL_0294: Expected O, but got I4
			//IL_02aa: Expected O, but got I8
			//IL_02b3: Expected O, but got I8
			//IL_02bc: Expected O, but got I8
			//IL_02d9: Expected O, but got I4
			//IL_02f1: Expected O, but got I4
			//IL_0320: Expected O, but got I4
			ulong num4 = default(ulong);
			Meta.Character character2 = default(Meta.Character);
			Meta.Character character3 = default(Meta.Character);
			Meta.Character character4 = default(Meta.Character);
			GameObject gameObject = default(GameObject);
			bool flag4 = default(bool);
			int num14 = default(int);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			GameObject gameObject2 = default(GameObject);
			ScheduleType scheduleType = default(ScheduleType);
			bool flag8 = default(bool);
			uint num19 = default(uint);
			bool flag11 = default(bool);
			Meta.Character character5 = default(Meta.Character);
			specificSecretLocation specificSecretLocation = default(specificSecretLocation);
			ItemScript itemScript2 = default(ItemScript);
			ulong num22 = default(ulong);
			ItemScript itemScript3 = default(ItemScript);
			Transform transform3 = default(Transform);
			Transform transform4 = default(Transform);
			bool flag12 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				IEnumerable<CharacterManager.CharacterInstance> characterInstances = (IEnumerable<CharacterManager.CharacterInstance>)_characterManager.GetCharacterInstances((byte)num4 != 0);
				Func<CharacterManager.CharacterInstance, bool> _003C_003E9__130_ = _003C_003Ec._003C_003E9__130_0;
				if (_003C_003E9__130_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(CharacterManager.CharacterInstance x)
					{
						//Discarded unreachable code: IL_0018
						if (x.MetaCharacter == null)
						{
						}
						return !x.MetaCharacter.InRealm;
					};
				}
				IEnumerable<CharacterManager.CharacterInstance> enumerable = (IEnumerable<CharacterManager.CharacterInstance>)Enumerable.Where<CharacterManager.CharacterInstance>((IEnumerable<>)characterInstances, (Func<, >)(object)_003C_003E9__130_);
				_003C_003Ec__DisplayClass130_0 CS_0024_003C_003E8__locals1;
				if (enumerable != null)
				{
					CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass130_0();
					CS_0024_003C_003E8__locals1.character = (CharacterManager.CharacterInstance)(object)CS_0024_003C_003E8__locals1;
					int num5 = 0;
					if (character2.IsSecretAndHide)
					{
						continue;
					}
					int currentCharacterSchedule = (int)_characterManager.GetCurrentCharacterSchedule((CharacterManager.CharacterInstance)num5);
					Meta.Character hangingOutCharacter = _hangingOutCharacter;
					bool flag = hangingOutCharacter == character3;
					if (hangingOutCharacter == character3)
					{
					}
					if (currentCharacterSchedule == 2)
					{
					}
					bool flag2 = currentCharacterSchedule == 3;
					if (!flag)
					{
						GameObject restaurantObject = _restaurantObject;
						int num6 = 0;
						if (!(restaurantObject != (UnityEngine.Object)num6))
						{
						}
					}
					if (!flag)
					{
						GameObject playerHouseObject = _playerHouseObject;
						int num7 = 0;
						if (playerHouseObject != (UnityEngine.Object)num7)
						{
							bool flag3 = currentCharacterSchedule == 6;
						}
					}
					if (!flag)
					{
						GameObject scroogeStoreObject = _scroogeStoreObject;
						int num8 = 0;
						if (!(scroogeStoreObject != (UnityEngine.Object)num8))
						{
						}
					}
					if (currentCharacterSchedule == 9)
					{
					}
					if (currentCharacterSchedule != 7 || !flag)
					{
					}
					if (flag2)
					{
						goto IL_0127;
					}
					if (num3 != 0)
					{
						int num9 = 0;
						if ((long)character4.secretCharacterData_ != 0 && GetSpecificSecretLocation((CharacterManager.CharacterInstance)num9) != 0)
						{
							goto IL_0127;
						}
					}
					goto IL_017e;
				}
				goto IL_0187;
				IL_0127:
				List<ItemScript> buildingScripts = _buildingScripts;
				Predicate<ItemScript> predicate = (Predicate<ItemScript>)(object)(Predicate<T>)delegate(ItemScript x)
				{
					Item item5 = x.Item;
					int house3 = CS_0024_003C_003E8__locals1.character.Data.House;
					throw new NullReferenceException();
				};
				ItemScript itemScript = (ItemScript)((List<T>)(object)buildingScripts).Find((Predicate<>)(object)predicate);
				int num10 = 0;
				if (!(itemScript == (UnityEngine.Object)num10))
				{
					gameObject = itemScript.gameObject;
					int num11 = 0;
					flag4 = gameObject == (UnityEngine.Object)num11;
					if (!flag4)
					{
						goto IL_017e;
					}
				}
				while ((flag4 ? 1 : 0) != _scroogeStoreItemID)
				{
				}
				goto IL_017e;
				IL_0187:
				int num12 = 0;
				if (enumerable != null)
				{
					int num13 = 0;
				}
				if (num3 != 0 || num3 != num14)
				{
					continue;
				}
				if (flag5)
				{
				}
				int num15 = 0;
				RectTransform component = UiRoot.Instance._menuStack.GetComponent<RectTransform>();
				int num16 = 0;
				if (!flag6)
				{
					continue;
				}
				CharacterManager.CharacterInstance character = (CharacterManager.CharacterInstance)num2;
				int num17 = 0;
				if (!(gameObject2 != (UnityEngine.Object)num17))
				{
					continue;
				}
				Transform transform = gameObject2.transform;
				MapCharacterItem component2 = gameObject2.GetComponent<MapCharacterItem>();
				int num18 = (int)scheduleType;
				Item invalid = Item.Invalid;
				bool flag7 = num18 == 5;
				if (flag8)
				{
				}
				bool flag9;
				if (num18 != 2 || flag8)
				{
					flag9 = num18 == 3;
					while (!flag8)
					{
					}
				}
				bool flag10 = num18 == 6;
				if (flag8)
				{
				}
				flag9 = flag7;
				if (num18 == 9)
				{
				}
				if (num19 != 7 || !flag8)
				{
				}
				if (flag11)
				{
				}
				if (flag9 || ((long)character5.secretCharacterData_ != 0 && specificSecretLocation == specificSecretLocation.beachCave))
				{
					Predicate<ItemScript> predicate2 = (Predicate<ItemScript>)(object)(Predicate<T>)delegate(ItemScript x)
					{
						Item item4 = x.Item;
						int house2 = character.Data.House;
						throw new NullReferenceException();
					};
					int num20 = 0;
					if (!(itemScript2 == (UnityEngine.Object)num20))
					{
						GameObject gameObject3 = itemScript2.gameObject;
						int num21 = 0;
						if (!(gameObject3 == (UnityEngine.Object)num21))
						{
						}
					}
				}
				if (specificSecretLocation == specificSecretLocation.none)
				{
					if (num22 != 0)
					{
					}
					int price = ((BattlePassReward)num22).Price;
					int price2 = ((BattlePassReward)num22).Price;
					int price3 = ((BattlePassReward)num22).Price;
					Predicate<ItemScript> predicate3 = (Predicate<ItemScript>)(object)(Predicate<T>)delegate(ItemScript x)
					{
						Item item3 = x.Item;
						int house = character.Data.House;
						throw new NullReferenceException();
					};
					int num23 = 0;
					if (itemScript3 != (UnityEngine.Object)num23)
					{
						GameObject gameObject4 = itemScript3.gameObject;
						int num24 = 0;
						if (gameObject4 != (UnityEngine.Object)num24)
						{
							Item item = itemScript3.Item;
							Transform transform2 = itemScript3.transform;
							Item item2 = itemScript3.Item;
						}
					}
				}
				if ((object)transform != null)
				{
				}
				int num25 = 0;
				if (transform3 != (UnityEngine.Object)num25)
				{
					GameObject gameObject5 = transform3.gameObject;
					if ((object)transform4 != null)
					{
					}
					int num26 = 0;
					int num27 = 0;
					int num28 = 0;
					int num29 = 0;
					int num30 = 0;
					int num31 = 0;
				}
				if (flag12)
				{
					break;
				}
				continue;
				IL_017e:
				while ((object)gameObject == null)
				{
				}
				num3++;
				goto IL_0187;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600287B")]
		[Cpp2IlInjected.Address(RVA = "0x1184110", Offset = "0x1182B10", VA = "0x181184110")]
		private void RefreshCrops(bool useAni = false)
		{
			//Discarded unreachable code: IL_0298, IL_029e, IL_02a4, IL_02aa, IL_02b0, IL_02b6, IL_02bc, IL_02c2, IL_02c8, IL_02ce, IL_02da, IL_02e6, IL_02ec, IL_02f2, IL_02f8, IL_02fe, IL_0304, IL_030a, IL_0310, IL_0316, IL_031c, IL_0322, IL_0328
			//IL_00d4: Expected O, but got I4
			//IL_011f: Expected O, but got I4
			//IL_013d: Expected O, but got I4
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_018d: Invalid comparison between F4 and O
			//IL_022d: Expected I4, but got I8
			Func<Garden, bool> func = default(Func<Garden, bool>);
			Func<Garden, float> func3 = default(Func<Garden, float>);
			uint num4 = default(uint);
			WaterStateDisplay waterStateDisplay = default(WaterStateDisplay);
			Vector2 vector = default(Vector2);
			Vector2 vector3 = default(Vector2);
			MapHarvestItem mapHarvestItem = default(MapHarvestItem);
			GardenItemData gardenItemData = default(GardenItemData);
			GameObject gameObject = default(GameObject);
			ulong num11 = default(ulong);
			Action<MapItem> onMapItemClicked = default(Action<MapItem>);
			int num19 = default(int);
			while (true)
			{
				int num = 0;
				Garden[] array = Filter<Garden>((IEnumerable<>)_buildingScripts, BuildingItemType.Garden).ToArray<Garden>();
				Func<Garden, bool> _003C_003E9__131_ = _003C_003Ec._003C_003E9__131_0;
				if (_003C_003E9__131_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Garden x)
					{
						//IL_0010: Expected O, but got I4
						CropProduction componentInChildren2 = x.GetComponentInChildren<CropProduction>();
						int num22 = 0;
						if (componentInChildren2 != (UnityEngine.Object)num22)
						{
							Item producedItem = componentInChildren2.ProducedItem;
							ItemType itemType = default(ItemType);
							if (itemType == ItemType.ActivityItem)
							{
								Item producedItem2 = componentInChildren2.ProducedItem;
								ActivityItemType activityItemType = default(ActivityItemType);
								if (activityItemType == ActivityItemType.Crop)
								{
									return componentInChildren2.IsProductionReady;
								}
							}
						}
						int num23 = 0;
						throw new NullReferenceException();
					};
				}
				Garden[] array2 = Enumerable.Where<Garden>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__131_).ToArray<Garden>();
				if (_003C_003Ec._003C_003E9__131_1 == null)
				{
					func = (Func<Garden, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Garden x)
					{
						//Discarded unreachable code: IL_0011
						//IL_0010: Expected O, but got I4
						Sapling componentInChildren = x.GetComponentInChildren<Sapling>();
						int num21 = 0;
						return componentInChildren != (UnityEngine.Object)num21;
					});
				}
				Garden[] array3 = Enumerable.Where<Garden>((IEnumerable<>)(object)array, (Func<, >)(object)func).ToArray<Garden>();
				IEnumerable<Garden> enumerable = (IEnumerable<Garden>)Enumerable.Concat<Garden>((IEnumerable<>)(object)array2, (IEnumerable<>)(object)array3);
				Func<Garden, bool> func2 = (Func<Garden, bool>)(object)(Func<T, TResult>)delegate(Garden x)
				{
					//Discarded unreachable code: IL_0027
					//IL_0009: Expected O, but got I4
					int num20 = 0;
					bool flag3 = x != (UnityEngine.Object)num20;
					return (!flag3) ? flag3 : (x.Data.ID != _wildGardenItemID);
				};
				IEnumerable<Garden> enumerable2 = (IEnumerable<Garden>)Enumerable.Where<Garden>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
				if (enumerable2 != null)
				{
					if (_003C_003Ec._003C_003E9__131_3 == null)
					{
						func3 = (Func<Garden, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Garden x)
						{
							//Discarded unreachable code: IL_000e
							Transform transform3 = x.transform;
							Vector3 vector4 = default(Vector3);
							return vector4.z;
						});
					}
					IOrderedEnumerable<Garden> orderedEnumerable = (IOrderedEnumerable<Garden>)Enumerable.OrderByDescending<Garden, float>((IEnumerable<>)enumerable2, (Func<, >)(object)func3);
				}
				int num2 = 0;
				Vector2 zero = Vector2.zero;
				int num3 = Enumerable.Count<Garden>((IEnumerable<>)num);
				if (num3 != 0)
				{
					if (num < (int)num4)
					{
						num += num;
						if (num == (int)num4)
						{
							goto IL_00fa;
						}
						num++;
					}
					if (num3 != 0 && num3 != 0)
					{
						goto IL_00fa;
					}
					goto IL_010b;
				}
				goto IL_028b;
				IL_028b:
				if (num3 != 0)
				{
				}
				if (num == 0)
				{
					return;
				}
				continue;
				IL_010b:
				while (num == 0)
				{
				}
				while (num != 0)
				{
				}
				int num5 = 0;
				if (!(waterStateDisplay != (UnityEngine.Object)num5))
				{
				}
				bool flag = (object)waterStateDisplay.GetWateringStateAndRatio() != null;
				int num6 = 0;
				if (waterStateDisplay != (UnityEngine.Object)num6)
				{
					while (!flag)
					{
					}
				}
				if ((object)_mcContent.transform != null)
				{
				}
				Vector2 scale = ((MapMenu)vector)._scale;
				Vector2 vector2 = /*Error near IL_015b: Stack underflow*/* scale;
				int num7 = 0;
				IEnumerator enumerator = _mcCropsHolder.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num8 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					if ((object)_cropGroupingDistance <= vector3)
					{
						continue;
					}
					float cropGroupingDistance = _cropGroupingDistance;
					bool activeSelf = mapHarvestItem._waterIcon.gameObject.activeSelf;
					if (flag == activeSelf)
					{
						if (mapHarvestItem._waterIcon.gameObject.activeSelf)
						{
							continue;
						}
						while (flag)
						{
						}
						if (mapHarvestItem._garden.Data.cropType_ != gardenItemData.cropType_)
						{
							continue;
						}
					}
					int gardenCount = mapHarvestItem._gardenCount;
					gardenCount = (mapHarvestItem.Count = gardenCount + 1);
				}
				int num10 = 0;
				if (gardenItemData != null)
				{
				}
				if (num != 0)
				{
					break;
				}
				while (num10 != 0)
				{
				}
				Type typeFromHandle = typeof(MapHarvestItem);
				gameObject.SetActive((byte)num11 != 0);
				Transform transform = gameObject.transform;
				MapHarvestItem component = gameObject.GetComponent<MapHarvestItem>();
				component.OnMapItemClicked = onMapItemClicked;
				int num12 = ((component.IsPinned = false) ? 1 : 0);
				component.transform.SetAsFirstSibling();
				Transform transform2 = gameObject.transform;
				int num13 = 0;
				int num14 = 0;
				float z = Vector3.one.z;
				int num15 = 0;
				int num16 = 0;
				int num17 = 0;
				int num18 = 0;
				num++;
				goto IL_028b;
				IL_00fa:
				num19 += num19;
				num19 += 312;
				goto IL_010b;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600287C")]
		[Cpp2IlInjected.Address(RVA = "0x1187A40", Offset = "0x1186440", VA = "0x181187A40")]
		private void UpdateCrops()
		{
			//Discarded unreachable code: IL_005d, IL_0063, IL_0069, IL_006f, IL_0075, IL_0081
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			uint num2 = default(uint);
			MapHarvestItem mapHarvestItem = default(MapHarvestItem);
			Vector2 vector = default(Vector2);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = _mcCropsHolder.transform.GetEnumerator();
				if (enumerator != null)
				{
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						break;
					}
					GameObject gameObject = mapHarvestItem._garden.gameObject;
					if ((object)_mcContent.transform != null)
					{
					}
					Vector2 scale = ((MapMenu)vector)._scale;
					Vector2 vector2 = /*Error near IL_004d: Stack underflow*/* scale;
				}
				if ((object)typeof(RectTransform).TypeHandle != null)
				{
				}
				if ((object)vector == null)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600287D")]
		[Cpp2IlInjected.Address(RVA = "0x1185F90", Offset = "0x1184990", VA = "0x181185F90")]
		private void UpdateCastle()
		{
			//Discarded unreachable code: IL_0050
			//IL_0010: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			GameObject castleObject = _castleObject;
			int num = 0;
			if (castleObject != (UnityEngine.Object)num)
			{
				Transform transform = _btnCastle.transform;
				GameObject mcContent = _mcContent;
				GameObject castleObject2 = _castleObject;
				Transform transform2 = mcContent.transform;
				int num2 = 0;
				if ((object)transform2 != null)
				{
				}
				Vector2 scale = ((MapMenu)RectTransformUtilities.GetPosOnUIFrom3D(castleObject2, (RectTransform)num2))._scale;
				Vector2 vector = /*Error near IL_004d: Stack underflow*/* scale;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600287E")]
		[Cpp2IlInjected.Address(RVA = "0x1180ED0", Offset = "0x117F8D0", VA = "0x181180ED0")]
		private void RefreshBuildings(bool useAni = false)
		{
			//IL_01cc: Expected O, but got I4
			//IL_02a1: Expected O, but got I4
			//IL_02ae: Expected O, but got I4
			//IL_02b6: Expected O, but got I4
			//IL_02be: Expected O, but got I4
			//IL_02c6: Expected O, but got I4
			//IL_02fa: Expected O, but got I4
			//IL_0305: Expected O, but got I4
			int num2;
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			TweenLiteArgs vars = default(TweenLiteArgs);
			uint tagNum = default(uint);
			bool active = default(bool);
			Transform transform3 = default(Transform);
			GameObject gameObject2 = default(GameObject);
			GameObject target = default(GameObject);
			List<Item> buildingMapMarkers;
			Mdl.Online.Client client = default(Mdl.Online.Client);
			GameObject gameObject3 = default(GameObject);
			Action<MapItem> onMapItemClicked = default(Action<MapItem>);
			bool active2 = default(bool);
			Transform parent2 = default(Transform);
			Action<MapItem> onMapItemClicked2 = default(Action<MapItem>);
			GameObject questMarker2 = default(GameObject);
			bool active3 = default(bool);
			Transform parent3 = default(Transform);
			Action<MapItem> onMapItemClicked3 = default(Action<MapItem>);
			bool active4 = default(bool);
			bool flag4 = default(bool);
			while (true)
			{
				int num = 0;
				num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				Vector2 zero = Vector2.zero;
				int num6 = Enumerable.Count<FastTravelDestination>((IEnumerable<>)_fastTravelPods);
				List<FastTravelDestination> fastTravelPods = _fastTravelPods;
				if (flag)
				{
					if (!flag2)
					{
						while ((object)typeof(UnityEngine.Object).TypeHandle == null)
						{
						}
						while (flag2)
						{
						}
						MapMenuParams param = _param;
						if (param != null)
						{
							FastTravelDestination _003CFastTravelOrigin_003Ek__BackingField = param.FastTravelOrigin;
							while (flag3)
							{
							}
						}
						if ((object)_mcContent.transform != null)
						{
						}
						Vector2 scale = _scale;
						float y = _scale.y;
						MapGateItem prefabGateItem = _prefabGateItem;
						Transform parent = _mcGatesHolder.transform;
						MapGateItem mapGateItem = UnityEngine.Object.Instantiate(prefabGateItem, parent);
						Transform transform = mapGateItem.transform;
						Action action = (mapGateItem.OnGateItemClicked = OnCloseClicked);
						while (!useAni)
						{
						}
						Transform transform2 = mapGateItem.transform;
						int num7 = 0;
						float z = Vector3.one.z;
						int num8 = 0;
						int num9 = 0;
						int num10 = 0;
						int num11 = 0;
						TweenLite tweenLite = TweenLite.To(mapGateItem, 0.35f, vars, (int)tagNum, this);
						num4++;
					}
					GameObject gameObject = _mcWishingWellItem.gameObject;
					if (_param == null)
					{
					}
					gameObject.SetActive(active);
					MapGateItem mcWishingWellItem = _mcWishingWellItem;
					MapGateItem mcWishingWellItem2 = _mcWishingWellItem;
					Action action2 = (mcWishingWellItem2.OnGateItemClicked = OnCloseClicked);
				}
				if (num6 != 0)
				{
					continue;
				}
				if ((object)transform3 != null)
				{
				}
				gameObject2.GetComponent<MapGateItem>().Target = target;
				buildingMapMarkers = (List<Item>)(object)client.Profile.get_BuildingMapMarkers();
				MapBuildingItem component = gameObject3.GetComponent<MapBuildingItem>();
				component.Item = (Item)component;
				component.OnMapItemClicked = onMapItemClicked;
				component.RefreshDisplay();
				GameObject questMarker = component.QuestMarker;
				int price = ((BattlePassReward)(object)component).Price;
				questMarker.SetActive(active2);
				if ((object)questMarker.transform != null)
				{
				}
				Transform transform4 = gameObject3.transform;
				int num12 = 0;
				if (transform4 != (UnityEngine.Object)num12)
				{
					GameObject gameObject4 = UnityEngine.Object.Instantiate(questMarker, parent2);
					MapBuildingItem component2 = gameObject4.GetComponent<MapBuildingItem>();
					component2.Item = (Item)component2;
					component2.OnMapItemClicked = onMapItemClicked2;
					component2.RefreshDisplay();
					questMarker2 = component2.QuestMarker;
					int price2 = ((BattlePassReward)(object)component2).Price;
					questMarker2.SetActive(active3);
					if ((object)questMarker2.transform != null)
					{
					}
					Transform transform5 = gameObject4.transform;
				}
				GameObject gameObject5 = UnityEngine.Object.Instantiate(questMarker2, parent3);
				MapBuildingItem component3 = gameObject5.GetComponent<MapBuildingItem>();
				component3.Item = (Item)component3;
				component3.OnMapItemClicked = onMapItemClicked3;
				component3.RefreshDisplay();
				GameObject questMarker3 = component3.QuestMarker;
				int price3 = ((BattlePassReward)(object)component3).Price;
				questMarker3.SetActive(active4);
				if ((object)questMarker3.transform != null)
				{
				}
				Transform transform6 = gameObject5.transform;
				if (flag4)
				{
					break;
				}
			}
			Meta.Online.Client client2 = default(Meta.Online.Client);
			ProfileWorld world_ = client2.profile.world_;
			int price4 = ((BattlePassReward)num2).Price;
			bool flag5 = default(bool);
			if (!flag5)
			{
				int price5 = ((BattlePassReward)num2).Price;
				int price6 = ((BattlePassReward)num2).Price;
			}
			int price7 = ((BattlePassReward)num2).Price;
			int price8 = ((BattlePassReward)num2).Price;
			GameObject mcBuildingsHolder = _mcBuildingsHolder;
			Transform transform7 = mcBuildingsHolder.transform;
			Transform transform8 = mcBuildingsHolder.transform;
			GameObject gameObject6 = default(GameObject);
			MapBuildingItem component4 = gameObject6.GetComponent<MapBuildingItem>();
			GameObject target2 = default(GameObject);
			component4.Target = target2;
			int price9 = ((BattlePassReward)num2).Price;
			component4.Item = (Item)price9;
			Action<MapItem> onMapItemClicked4 = default(Action<MapItem>);
			component4.OnMapItemClicked = onMapItemClicked4;
			component4.RefreshDisplay();
			GameObject questMarker4 = component4.QuestMarker;
			Func<Item, bool> cpp2il__autoParamName__idx_ = default(Func<Item, bool>);
			if (_003C_003Ec._003C_003E9__134_2 == null)
			{
				BuildingItemType buildingItemType = default(BuildingItemType);
				cpp2il__autoParamName__idx_ = (Func<Item, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item building) => buildingItemType == BuildingItemType.Stall));
			}
			bool flag6 = ((IEnumerable<>)buildingMapMarkers).Any<Item>((Func<, >)(object)cpp2il__autoParamName__idx_);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600287F")]
		[Cpp2IlInjected.Address(RVA = "0x1185930", Offset = "0x1184330", VA = "0x181185930")]
		private void UpdateBuildings()
		{
			//Discarded unreachable code: IL_00e6, IL_00ec, IL_00f2, IL_00f8, IL_00fe, IL_010a, IL_0116, IL_011c, IL_0122, IL_012e
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			uint num3 = default(uint);
			MapGateItem mapGateItem = default(MapGateItem);
			Vector2 vector = default(Vector2);
			Transform transform = default(Transform);
			Transform transform2 = default(Transform);
			uint num7 = default(uint);
			uint num8 = default(uint);
			MapBuildingItem mapBuildingItem = default(MapBuildingItem);
			Transform transform3 = default(Transform);
			Vector2 vector3 = default(Vector2);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				Vector2 zero = Vector2.zero;
				IEnumerator enumerator = _mcGatesHolder.transform.GetEnumerator();
				if (enumerator != null)
				{
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					int num4 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					GameObject gameObject = mapGateItem._fastTravelPod.gameObject;
					if ((object)_mcContent.transform != null)
					{
					}
					Vector2 scale = ((MapMenu)vector)._scale;
					Vector2 vector2 = /*Error near IL_005a: Stack underflow*/* scale;
				}
				int num5 = 0;
				if ((object)typeof(RectTransform).TypeHandle != null)
				{
					int num6 = 0;
				}
				if ((object)vector == null)
				{
					if ((object)transform != null)
					{
					}
					IEnumerator enumerator2 = transform2.GetEnumerator();
					if (num5 < (int)num7)
					{
						num5 += num5;
						num5++;
					}
					if (enumerator2 != null)
					{
						if (num5 < (int)num8)
						{
							num5 += num5;
							num5++;
						}
						num5 += 312;
						num5 += 328;
						int num9 = 0;
						if (num5 == 0)
						{
							break;
						}
						GameObject target = mapBuildingItem.Target;
						if ((object)transform3 == null)
						{
						}
					}
					if ((object)typeof(RectTransform).TypeHandle != null)
					{
					}
					if ((object)vector3 == null)
					{
						return;
					}
					continue;
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002880")]
		[Cpp2IlInjected.Address(RVA = "0x117DD10", Offset = "0x117C710", VA = "0x18117DD10", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0026
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = (_isGamepadConnected = instance.IsControllerConnected((byte)useKeyboardAsController != 0));
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6002881")]
		[Cpp2IlInjected.Address(RVA = "0x1187D00", Offset = "0x1186700", VA = "0x181187D00")]
		private void UpdateFocus(bool isInZoom = false)
		{
			//IL_0047: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_0084: Invalid comparison between F4 and O
			//IL_00ff: Expected O, but got I4
			//IL_0117: Expected O, but got I4
			//IL_0131: Expected O, but got I4
			//IL_0131: Expected O, but got I4
			//IL_0137: Invalid comparison between F4 and O
			//IL_01b2: Expected O, but got I4
			//IL_01ca: Expected O, but got I4
			//IL_01e4: Expected O, but got I4
			//IL_01e4: Expected O, but got I4
			//IL_01ea: Invalid comparison between F4 and O
			//IL_0265: Expected O, but got I4
			//IL_027d: Expected O, but got I4
			//IL_0297: Expected O, but got I4
			//IL_0297: Expected O, but got I4
			//IL_029d: Invalid comparison between F4 and O
			//IL_02ba: Invalid comparison between F4 and O
			//IL_02c5: Invalid comparison between F4 and O
			//IL_02d3: Expected O, but got I4
			//IL_02ee: Expected O, but got I4
			//IL_02fd: Expected O, but got I4
			//IL_02fd: Expected O, but got I4
			//IL_0309: Expected O, but got I4
			//IL_0317: Expected O, but got I4
			//IL_0317: Expected O, but got I4
			//IL_0326: Expected O, but got I4
			//IL_0338: Expected O, but got I4
			//IL_0347: Expected O, but got I4
			//IL_0347: Expected O, but got I4
			uint num2 = default(uint);
			MapItem mapItem = default(MapItem);
			Vector2 vector = default(Vector2);
			float magnetDist = default(float);
			Transform transform = default(Transform);
			uint num8 = default(uint);
			uint num9 = default(uint);
			MapItem mapItem2 = default(MapItem);
			Vector2 vector2 = default(Vector2);
			Transform transform2 = default(Transform);
			uint num15 = default(uint);
			uint num16 = default(uint);
			MapItem mapItem3 = default(MapItem);
			Vector2 vector3 = default(Vector2);
			Transform transform3 = default(Transform);
			uint num22 = default(uint);
			uint num23 = default(uint);
			MapItem mapItem4 = default(MapItem);
			Vector2 vector4 = default(Vector2);
			Transform transform4 = default(Transform);
			Vector2 vector5 = default(Vector2);
			Transform transform5 = default(Transform);
			Vector2 vector6 = default(Vector2);
			Transform transform6 = default(Transform);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			uint num37 = default(uint);
			uint num38 = default(uint);
			while (true)
			{
				int num = 0;
				if ((object)base.transform != null)
				{
				}
				if (_mcGatesHolder.transform.GetEnumerator() != null)
				{
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
					if (num == 0)
					{
						num += 328;
					}
					int num3 = 0;
					if (num == 0)
					{
						continue;
					}
					int num4 = 0;
					if (mapItem != (UnityEngine.Object)num4)
					{
						GameObject pinVisual = mapItem.PinVisual;
						int num5 = 0;
						if (pinVisual != (UnityEngine.Object)num5 && (object)mapItem.PinVisual.transform == null)
						{
						}
					}
					vector = RectTransformUtilities.SwitchToRectTransform((RectTransform)num, (RectTransform)num);
					magnetDist = MagnetDist;
					while ((object)magnetDist <= vector)
					{
					}
				}
				int num6 = 0;
				if ((object)vector != null)
				{
					int num7 = 0;
				}
				if (num != 0)
				{
					continue;
				}
				IEnumerator enumerator = transform.GetEnumerator();
				if (num6 < (int)num8)
				{
					num6 += num6;
					num6++;
				}
				if (num6 != 0)
				{
					if (num6 < (int)num9)
					{
						num6 += num6;
						num6++;
					}
					if (num6 == 0)
					{
						num6 += 312;
						num6 += 328;
					}
					int num10 = 0;
					if (num6 == 0)
					{
						continue;
					}
					int num11 = 0;
					if (mapItem2 != (UnityEngine.Object)num11)
					{
						GameObject pinVisual2 = mapItem2.PinVisual;
						int num12 = 0;
						if (pinVisual2 != (UnityEngine.Object)num12 && (object)mapItem2.PinVisual.transform == null)
						{
						}
					}
					vector2 = RectTransformUtilities.SwitchToRectTransform((RectTransform)num6, (RectTransform)num);
					while ((object)magnetDist <= vector2)
					{
					}
				}
				int num13 = 0;
				if ((object)vector2 != null)
				{
					int num14 = 0;
				}
				if (num != 0)
				{
					continue;
				}
				IEnumerator enumerator2 = transform2.GetEnumerator();
				if (num13 < (int)num15)
				{
					num13 += num13;
					num13++;
				}
				if (num13 != 0)
				{
					if (num13 < (int)num16)
					{
						num13 += num13;
						num13++;
					}
					if (num13 == 0)
					{
						num13 += 312;
						num13 += 328;
					}
					int num17 = 0;
					if (num13 == 0)
					{
						continue;
					}
					int num18 = 0;
					if (mapItem3 != (UnityEngine.Object)num18)
					{
						GameObject pinVisual3 = mapItem3.PinVisual;
						int num19 = 0;
						if (pinVisual3 != (UnityEngine.Object)num19 && (object)mapItem3.PinVisual.transform == null)
						{
						}
					}
					vector3 = RectTransformUtilities.SwitchToRectTransform((RectTransform)num13, (RectTransform)num);
					while ((object)magnetDist <= vector3)
					{
					}
				}
				int num20 = 0;
				if ((object)vector3 != null)
				{
					int num21 = 0;
				}
				if (num != 0)
				{
					continue;
				}
				IEnumerator enumerator3 = transform3.GetEnumerator();
				if (num20 < (int)num22)
				{
					num20 += num20;
					num20++;
				}
				if (num20 != 0)
				{
					if (num20 < (int)num23)
					{
						num20 += num20;
						num20++;
					}
					if (num20 == 0)
					{
						num20 += 312;
						num20 += 328;
					}
					int num24 = 0;
					if (num20 == 0)
					{
						continue;
					}
					int num25 = 0;
					if (mapItem4 != (UnityEngine.Object)num25)
					{
						GameObject pinVisual4 = mapItem4.PinVisual;
						int num26 = 0;
						if (pinVisual4 != (UnityEngine.Object)num26 && (object)mapItem4.PinVisual.transform == null)
						{
						}
					}
					vector4 = RectTransformUtilities.SwitchToRectTransform((RectTransform)num20, (RectTransform)num);
					while ((object)magnetDist <= vector4)
					{
					}
				}
				int num27 = 0;
				if ((object)vector4 != null)
				{
					int num28 = 0;
				}
				if (num != 0)
				{
					continue;
				}
				if ((object)transform4 != null)
				{
				}
				if ((object)magnetDist > vector5)
				{
				}
				if ((object)transform5 != null)
				{
				}
				if ((object)magnetDist > vector6)
				{
				}
				int num29 = 0;
				if (transform6 != (UnityEngine.Object)num29)
				{
					FocusNavigationElement component = transform6.GetComponent<FocusNavigationElement>();
				}
				int num30 = 0;
				int num31 = 0;
				if (transform6 != (UnityEngine.Object)num31)
				{
					int num32 = 0;
					if ((UnityEngine.Object)num27 != (UnityEngine.Object)num32)
					{
						bool flag = (UnityEngine.Object)num27 != transform6;
					}
				}
				int num33 = 0;
				if (!((UnityEngine.Object)num27 == (UnityEngine.Object)num33))
				{
					int num34 = 0;
					if (transform6 == (UnityEngine.Object)num34)
					{
						continue;
					}
					int num35 = 0;
					if (transform6 != (UnityEngine.Object)num35)
					{
						int num36 = 0;
						if ((UnityEngine.Object)num27 != (UnityEngine.Object)num36 && flag2 && !flag3)
						{
						}
					}
				}
				if (num27 < (int)num37)
				{
					num27 += num27;
					num27++;
				}
				if (num27 != 0)
				{
					if (num27 < (int)num38)
					{
						num27 += num27;
						num27++;
					}
					num27 += 312;
					num27 += 328;
					int num39 = 0;
					if (num27 != 0)
					{
						break;
					}
				}
			}
			int num40 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002882")]
		[Cpp2IlInjected.Address(RVA = "0x11850D0", Offset = "0x1183AD0", VA = "0x1811850D0")]
		public void ResetFilterToggle()
		{
			//Discarded unreachable code: IL_0035
			BaseButton[] componentsInChildren = _filtersHolder.GetComponentsInChildren<BaseButton>();
			int num = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				componentsInChildren[num].OnHighlightRemoved?.Invoke();
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002883")]
		[Cpp2IlInjected.Address(RVA = "0x1185180", Offset = "0x1183B80", VA = "0x181185180")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_0090, IL_0096, IL_00a8
			//IL_0064: Expected O, but got I4
			int num = 0;
			if ((_isGamepadConnected ? 1 : 0) == num)
			{
				IEnumerator enumerator = _focusedHolder.GetEnumerator();
				GameObject gameObject = default(GameObject);
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
					UnityEngine.Object.Destroy(gameObject);
				}
				if ((object)gameObject != null)
				{
					int num4 = 0;
				}
				int num5 = 0;
			}
			else if (!_filtersHolder.activeSelf)
			{
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				int num6 = 0;
				focusNavigation.RemoveFocus((ISupportsFocusNavigation)num6);
			}
			else
			{
				MenuNavigation menuNavigation = default(MenuNavigation);
				FocusNavigation focusNavigation2 = menuNavigation.FocusNavigation;
				FocusNavigationElement component = _filtersHolder.transform.GetChild(1).GetComponent<FocusNavigationElement>();
				focusNavigation2.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002884")]
		[Cpp2IlInjected.Address(RVA = "0x117D970", Offset = "0x117C370", VA = "0x18117D970", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0074, IL_0075, IL_0076, IL_0077, IL_00bd
			if (redirectionType > RedirectionType.MainMenuGoToMap)
			{
				if (redirectionType != RedirectionType.GamePopCurrentMenu)
				{
					return;
				}
				if (_filtersHolder.activeSelf)
				{
					_btnFilter.m_OnClick?.Invoke();
					return;
				}
			}
			else if ((object)this != null)
			{
				if ((object)this != null)
				{
					if ((object)this == null)
					{
						return;
					}
					if ((long)this != 1)
					{
						int num = 0;
						MainMenuBar _003CMainMenuBar_003Ek__BackingField = UiRoot.Instance.MainMenuBar;
						switch (redirectionType)
						{
						}
						return;
					}
				}
				if (_isSameFrame)
				{
					return;
				}
				_isSameFrame = true;
				int _003C_003E1__state = default(int);
				_003CWaitFrame_003Ed__141 _003CWaitFrame_003Ed__ = new _003CWaitFrame_003Ed__141(_003C_003E1__state);
				_003C_003E1__state = 0;
				_003CWaitFrame_003Ed__._003C_003E4__this = this;
				Coroutine coroutine = (_waitFrame = StartCoroutine(_003CWaitFrame_003Ed__));
				Button btnFilter = _btnFilter;
			}
			OnCloseClicked();
		}

		[Cpp2IlInjected.Token(Token = "0x6002885")]
		[Cpp2IlInjected.Address(RVA = "0x1189C80", Offset = "0x1188680", VA = "0x181189C80")]
		[IteratorStateMachine(typeof(_003CWaitFrame_003Ed__141))]
		private IEnumerator WaitFrame()
		{
			int _003C_003E1__state = default(int);
			_003CWaitFrame_003Ed__141 _003CWaitFrame_003Ed__ = new _003CWaitFrame_003Ed__141(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CWaitFrame_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002886")]
		[Cpp2IlInjected.Address(RVA = "0x118A8C0", Offset = "0x11892C0", VA = "0x18118A8C0")]
		public unsafe MapMenu()
		{
			//IL_0044: Expected I4, but got O
			//IL_0051: Expected I4, but got O
			//IL_005e: Expected I4, but got O
			//IL_006b: Expected I4, but got O
			//IL_007a: Expected I4, but got O
			//IL_0089: Expected I4, but got O
			//IL_0098: Expected I4, but got O
			//IL_00aa: Expected I4, but got O
			//IL_00d0: Expected F4, but got I4
			//IL_00cb: Expected native int or pointer, but got O
			//IL_010e: Expected F4, but got I4
			//IL_0109: Expected native int or pointer, but got O
			//IL_0129: Expected F4, but got I4
			//IL_0124: Expected native int or pointer, but got O
			Item invalid = Item.Invalid;
			int num = 0;
			_beachCaveSceneID = (int)invalid;
			_scroogeHouseOffset = 25f;
			_scale = Vector2.zero;
			((Vector2*)(IntPtr)_scale)->y = 0f;
			_characterHouses = (List<GameObject>)(object)new List<T>();
			int num2 = 0;
			_characterFilterToggled = true;
			_buildingFilterToggled = true;
			Vector2 zero = Vector2.zero;
			int num3 = 0;
			MapOffset = zero;
			((Vector2*)(IntPtr)MapOffset)->y = 0f;
			MapOffsetGP = Vector2.zero;
			((Vector2*)(IntPtr)MapOffsetGP)->y = 0f;
			_minZoom = 1f;
			_maxZoom = 2.5f;
			_defaultZoom = 2.5f;
			_cropGroupingDistance = 50f;
			_animMaxDelay = 0.4f;
			_alphaForLockBiome = 0.3f;
			_alphaForLockAreaName = 0.5f;
			_alphaForUnlockAreaName = 0.75f;
			base._002Ector();
		}
	}
}
