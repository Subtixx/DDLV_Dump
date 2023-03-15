using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Activities;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Ftue;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Streaming;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Missions;
using Meta.Online;
using ScreenEffect;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x2000989")]
	public class CookingStall : Stall, IHighlightRendererOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200098A")]
		public delegate void CurrentTutorialStepChanged(FtueStep step);

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400348A")]
		public CookingStallState State;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400348B")]
		[SerializeField]
		private Transform _cookingPot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400348C")]
		public AK.Wwise.Event _sfxPickEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400348D")]
		public AK.Wwise.Event _sfxDropEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400348E")]
		public AK.Wwise.Event _sfxStartCooking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400348F")]
		public AK.Wwise.Event _sfxInventoryFull;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4003490")]
		public AK.Wwise.Event _mCookingSuccess;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4003491")]
		public AK.Wwise.Event _mCookingDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003492")]
		public Switch[] _mCookingMealRating;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003493")]
		public string CookingSuccessEmployeeEmotion = "Celebrate";

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4003494")]
		public string CookingFailureEmployeeEmotion = "Sad";

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003495")]
		public string CookingGoodIngredientsEmployeeEmotion = "Happy";

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003496")]
		public string CookingBadIngredientsEmployeeEmotion = "Sad";

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003497")]
		public string CookingAddIngredientAnimation = "Smell";

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4003498")]
		public string CookingAddIngredientStateName = "smell";

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4003499")]
		public List<GameObject> CookingAddIngredientVFXPrefabs = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400349A")]
		public GameObject CookingSuccessVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400349B")]
		public GameObject NewCookbookInformationVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400349C")]
		private GameObject newCookbookInformationVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400349D")]
		public CookingDragAndDropSettings CookingDragAndDropSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400349E")]
		public Transform EndFlowEmployeePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400349F")]
		public Transform EndFlowMealPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40034A0")]
		public Transform EndFlowInitialCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40034A1")]
		public Transform EndFlowFinalCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40034A2")]
		public Transform EndFlowLargeInitialCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40034A3")]
		public Transform EndFlowLargeFinalCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40034A4")]
		public Bounds EndFlowLargeThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40034A5")]
		public float EndFlowAnimationDuration = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40034A6")]
		public AssetReference EndFlowResultPopup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40034A7")]
		public List<GameObject> EndFlowToDisable = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40034A8")]
		public GameObject EndFlowSuccessMealVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40034A9")]
		public bool IsTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40034AA")]
		[ItemID]
		[SerializeField]
		private int _forcedEmployeeItemID = 10000018;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40034AB")]
		private Item ingredientItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40034AC")]
		private GameObject ingredientGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40034AD")]
		private Vector3 lastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x40034AE")]
		private bool inInteraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40034AF")]
		private CancellationTokenSource characterAnimationCTS = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40034B3")]
		private List<Item> selectedIngredients = (List<Item>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40034B4")]
		private Item previouslyMadeMeal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40034B6")]
		public InputAction inputDropIngredient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40034B7")]
		private FtueStep _currentTutorialStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40034B8")]
		private Toolbox.TemporarySwitchToolScope temporarySwitchToolScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40034B9")]
		private StreamableAssetRef streamableAssetRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40034BA")]
		private float savedFixedDeltaTime;

		[Cpp2IlInjected.Token(Token = "0x1700065E")]
		public Item ForcedEmployeeItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002C7D")]
			[Cpp2IlInjected.Address(RVA = "0x10FE2E0", Offset = "0x10FCCE0", VA = "0x1810FE2E0")]
			get
			{
				long num = Convert.ToInt64((uint)_forcedEmployeeItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700065F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x248"), Cpp2IlInjected.Token(Token = "0x40034B0")]
		public Item SelectedRecipe
		{
			[Cpp2IlInjected.Token(Token = "0x6002C7E")]
			[Cpp2IlInjected.Address(RVA = "0x10FE340", Offset = "0x10FCD40", VA = "0x1810FE340")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002C7F")]
			[Cpp2IlInjected.Address(RVA = "0x10FE5F0", Offset = "0x10FCFF0", VA = "0x1810FE5F0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000660")]
		public IEnumerable<Item> SelectedIngredientList
		{
			[Cpp2IlInjected.Token(Token = "0x6002C84")]
			[Cpp2IlInjected.Address(RVA = "0xCA8BC0", Offset = "0xCA75C0", VA = "0x180CA8BC0")]
			get
			{
				List<Item> list = selectedIngredients;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000661")]
		public FtueStep CurrentTutorialStep
		{
			[Cpp2IlInjected.Token(Token = "0x6002C87")]
			[Cpp2IlInjected.Address(RVA = "0x10FE2D0", Offset = "0x10FCCD0", VA = "0x1810FE2D0")]
			get
			{
				return _currentTutorialStep;
			}
			[Cpp2IlInjected.Token(Token = "0x6002C88")]
			[Cpp2IlInjected.Address(RVA = "0x10FE530", Offset = "0x10FCF30", VA = "0x1810FE530")]
			set
			{
				if (_currentTutorialStep != value)
				{
					_currentTutorialStep = value;
					CurrentTutorialStepChanged onCurrentTutorialStepChanged = this.OnCurrentTutorialStepChanged;
					if (onCurrentTutorialStepChanged != null)
					{
						FtueStep currentTutorialStep = _currentTutorialStep;
						onCurrentTutorialStepChanged(currentTutorialStep);
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000662")]
		public bool CanStartCooking
		{
			[Cpp2IlInjected.Token(Token = "0x6002C89")]
			[Cpp2IlInjected.Address(RVA = "0x10FDD20", Offset = "0x10FC720", VA = "0x1810FDD20")]
			get
			{
				//Discarded unreachable code: IL_00db
				//IL_0022: Expected I4, but got O
				List<Item> list = selectedIngredients;
				CookWithIngredients.Types.Request request = new CookWithIngredients.Types.Request();
				IItemData itemData = base.ItemData;
				RepeatedField<int> ingredients_ = request.ingredients_;
				request.cookingStationItemID_ = (int)request;
				List<Item> list2 = selectedIngredients;
				Func<Item, int> _003C_003E9__64_ = _003C_003Ec._003C_003E9__64_0;
				if (_003C_003E9__64_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => x.ItemID);
				}
				IEnumerable<Item> enumerable = (IEnumerable<Item>)Enumerable.Select<Item, int>((IEnumerable<>)list2, (Func<, >)(object)_003C_003E9__64_);
				((RepeatedField<T>)(object)ingredients_).Add((IEnumerable<>)enumerable);
				uint num = (request.containerInventoryID_ = SystemRoot.Instance.MetaClient.profile.Backpack.iD_);
				request.DryRun = true;
				Client metaClient = SystemRoot.Instance.MetaClient;
				Client metaClient2 = SystemRoot.Instance.MetaClient;
				Client metaClient3 = SystemRoot.Instance.MetaClient;
				Client metaClient4 = SystemRoot.Instance.MetaClient;
				CookWithIngredients.Types.Response response = new CookWithIngredients.Types.Response();
				response.request_ = request;
				Client metaClient5 = SystemRoot.Instance.MetaClient;
				return ((TransactionAction<TResult>)(object)response).IsValid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006D")]
		public event EventHandler<bool> ChangeCookingMenuVisibilityEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002C80")]
			[Cpp2IlInjected.Address(RVA = "0x10FDB40", Offset = "0x10FC540", VA = "0x1810FDB40")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002C81")]
			[Cpp2IlInjected.Address(RVA = "0x10FE350", Offset = "0x10FCD50", VA = "0x1810FE350")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006E")]
		public event EventHandler<Item> IngredientEnteredPotEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6002C82")]
			[Cpp2IlInjected.Address(RVA = "0x10FDBE0", Offset = "0x10FC5E0", VA = "0x1810FDBE0")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002C83")]
			[Cpp2IlInjected.Address(RVA = "0x10FE3F0", Offset = "0x10FCDF0", VA = "0x1810FE3F0")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400006F")]
		public event CurrentTutorialStepChanged OnCurrentTutorialStepChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6002C85")]
			[Cpp2IlInjected.Address(RVA = "0x10FDC80", Offset = "0x10FC680", VA = "0x1810FDC80")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002C86")]
			[Cpp2IlInjected.Address(RVA = "0x10FE490", Offset = "0x10FCE90", VA = "0x1810FE490")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while (@delegate != this)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8A")]
		[Cpp2IlInjected.Address(RVA = "0x10FCD50", Offset = "0x10FB750", VA = "0x1810FCD50", Slot = "4")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_0094
			//IL_0071: Expected O, but got I4
			base.Start();
			if (State == CookingStallState.PlayerCookingStation)
			{
				StreamableAssetRef streamableAssetRef = (this.streamableAssetRef = base.transform.parent.GetComponent<StreamableAssetRef>());
			}
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			Mdl.Systems.System.SystemEvent value = OnPlayerNavigationStatusChanged;
			system.SystemPausedEvent += value;
			Mdl.Systems.System.SystemEvent value2 = OnPlayerNavigationStatusChanged;
			system.SystemResumedEvent += value2;
			InputTriggerReleased trigger = new InputTriggerReleased();
			int num = default(int);
			InputActionBool inputActionBool = new InputActionBool("CookingStall_DropIngredient", trigger, (InputProvider)num);
			num = 0;
			inputDropIngredient = inputActionBool;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				bool flag3 = !system.IsPaused;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8B")]
		[Cpp2IlInjected.Address(RVA = "0x10FBE80", Offset = "0x10FA880", VA = "0x1810FBE80", Slot = "6")]
		internal override void Init()
		{
			//Discarded unreachable code: IL_0019
			((List<T>)(object)selectedIngredients).Clear();
			Item item = (SelectedRecipe = Item.Invalid);
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8C")]
		[Cpp2IlInjected.Address(RVA = "0x10FD360", Offset = "0x10FBD60", VA = "0x1810FD360")]
		private unsafe void Update()
		{
			//IL_0010: Expected O, but got I4
			//IL_0079: Expected native int or pointer, but got O
			//IL_00f1: Expected O, but got I4
			Vector3 vector = default(Vector3);
			while (true)
			{
				GameObject gameObject = ingredientGO;
				int num = 0;
				if (!(gameObject != (UnityEngine.Object)num))
				{
					return;
				}
				int num2 = 0;
				float deltaTime = Time.deltaTime;
				InputAction[] array = new InputAction[1];
				InputAction inputAction = inputDropIngredient;
				if (inputAction == null || array != null)
				{
					array[0] = inputAction;
					InputAction.UpdateAll(deltaTime, array);
					if (inputDropIngredient.IsTriggered)
					{
						break;
					}
					Transform transform = ingredientGO.transform;
					float z = vector.z;
					((Vector3*)(IntPtr)lastPosition)->z = z;
					Transform transform2 = ingredientGO.transform;
					CookingDragAndDropSettings cookingDragAndDropSettings = CookingDragAndDropSettings;
					int num3 = 0;
					int num4 = 0;
					int height = Screen.height;
					int num5 = 0;
					int height2 = Screen.height;
					CookingDragAndDropSettings cookingDragAndDropSettings2 = CookingDragAndDropSettings;
					int num6 = 0;
					int num7 = 0;
					int width = Screen.width;
					int num8 = 0;
					int width2 = Screen.width;
					CookingDragAndDropSettings cookingDragAndDropSettings3 = CookingDragAndDropSettings;
					Transform transform3 = ingredientGO.transform;
					int num9 = 0;
					Vector3 one = Vector3.one;
					transform3.localScale = (Vector3)num9;
					return;
				}
			}
			int isByGamepads = 0;
			DropIngredient((byte)isByGamepads != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8D")]
		[Cpp2IlInjected.Address(RVA = "0x10FBF10", Offset = "0x10FA910", VA = "0x1810FBF10", Slot = "5")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_004d
			//IL_002d: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			((object)this)._002Ector();
			if ((long)characterAnimationCTS != 0)
			{
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				PlayerNavigation system = _003CInstance_003Ek__BackingField.GetSystem<PlayerNavigation>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				Mdl.Systems.System.SystemEvent systemEvent = OnPlayerNavigationStatusChanged;
				Mdl.Systems.System.SystemEvent systemEvent2 = OnPlayerNavigationStatusChanged;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8E")]
		[Cpp2IlInjected.Address(RVA = "0x10FAE90", Offset = "0x10F9890", VA = "0x1810FAE90")]
		public void DropIngredient(bool isByGamepads = false)
		{
			//Discarded unreachable code: IL_00b2
			//IL_0010: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			GameObject gameObject = ingredientGO;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				Rigidbody rigidbody = ingredientGO.AddComponent<Rigidbody>();
				if (isByGamepads)
				{
				}
				Transform transform = ingredientGO.transform;
				float z = lastPosition.z;
				Vector3 vector = default(Vector3);
				float z2 = vector.z;
				CookingDragAndDropSettings cookingDragAndDropSettings = CookingDragAndDropSettings;
				float z3 = UnityEngine.Random.insideUnitSphere.z;
				CookingDragAndDropSettings cookingDragAndDropSettings2 = CookingDragAndDropSettings;
				Action action = SuccessCallback;
				Action action2 = FailureCallback;
				int num2 = 0;
				int num3 = 0;
				Task asyncTask = default(Task);
				asyncTask.FireAndForgetTask();
				ingredientGO = (GameObject)num2;
				AK.Wwise.Event sfxDropEvent = _sfxDropEvent;
				GameObject gameObject2 = base.gameObject;
				uint num4 = sfxDropEvent.Post(gameObject2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C8F")]
		[Cpp2IlInjected.Address(RVA = "0x10FD010", Offset = "0x10FBA10", VA = "0x1810FD010")]
		private void SuccessCallback()
		{
			//Discarded unreachable code: IL_0060
			//IL_005e: Expected O, but got I4
			if (inInteraction)
			{
				List<Item> list = selectedIngredients;
				Item item = ingredientItem;
				((List<T>)(object)list).Add((T)item);
				OnIngredientsChanged(add: true);
				int num = 0;
				VibrationsManager.TriggerMediumImpact();
				EventHandler<Item> ingredientEnteredPotEvent = this.IngredientEnteredPotEvent;
				if (ingredientEnteredPotEvent != null)
				{
					Item e = ingredientItem;
					ingredientEnteredPotEvent(this, (TEventArgs)e);
				}
				((EventHandler<TEventArgs>)(object)this.ChangeCookingMenuVisibilityEvent)?.Invoke((object)this, (TEventArgs)1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C90")]
		[Cpp2IlInjected.Address(RVA = "0x10FB350", Offset = "0x10F9D50", VA = "0x1810FB350")]
		private void FailureCallback()
		{
			//IL_001c: Expected O, but got I4
			if (inInteraction)
			{
				((EventHandler<TEventArgs>)(object)this.ChangeCookingMenuVisibilityEvent)?.Invoke((object)this, (TEventArgs)1);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C91")]
		[Cpp2IlInjected.Address(RVA = "0x10FC100", Offset = "0x10FAB00", VA = "0x1810FC100")]
		private void OnIngredientsChanged(bool add)
		{
			//IL_001b: Expected I4, but got O
			//IL_00de: Expected O, but got I4
			//IL_0162: Expected F8, but got I4
			//IL_01db: Expected O, but got I4
			CookWithIngredients.Types.Request request = new CookWithIngredients.Types.Request();
			IItemData itemData = base.ItemData;
			RepeatedField<int> ingredients_ = request.ingredients_;
			request.cookingStationItemID_ = (int)request;
			List<Item> list = selectedIngredients;
			Func<Item, int> _003C_003E9__74_ = _003C_003Ec._003C_003E9__74_0;
			if (_003C_003E9__74_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Item x) => x.ItemID);
			}
			IEnumerable<Item> enumerable = (IEnumerable<Item>)Enumerable.Select<Item, int>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__74_);
			((RepeatedField<T>)(object)ingredients_).Add((IEnumerable<>)enumerable);
			uint num = (request.containerInventoryID_ = SystemRoot.Instance.MetaClient.profile.Backpack.iD_);
			request.DryRun = true;
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			Client metaClient3 = SystemRoot.Instance.MetaClient;
			Client metaClient4 = SystemRoot.Instance.MetaClient;
			CookWithIngredients.Types.Response response = new CookWithIngredients.Types.Response();
			response.request_ = request;
			Client metaClient5 = SystemRoot.Instance.MetaClient;
			Mdl.Characters.Character currentEmployee = base.CurrentEmployee;
			int num2 = 0;
			Mdl.Characters.Character currentEmployee2 = default(Mdl.Characters.Character);
			if (currentEmployee != (UnityEngine.Object)num2)
			{
				List<Item> list2 = selectedIngredients;
				int size = ((List<>)(object)list2)._size;
				int num3 = 0;
				if (!add)
				{
					if (size <= 0)
					{
						goto IL_01a4;
					}
					int recipeItemID_ = response.recipeItemID_;
					int num4 = default(int);
					if (list2 == null)
					{
						int mealItemID_ = response.mealItemID_;
						Item item = previouslyMadeMeal;
						MealItemData mealItemData = default(MealItemData);
						int starRating_ = mealItemData.starRating_;
						MealItemData mealItemData2 = default(MealItemData);
						if (mealItemData2 != null)
						{
						}
						if (mealItemData2 != null)
						{
						}
						CancellationToken token = characterAnimationCTS.Token;
						num4 = 0;
						int num5 = 0;
						Task asyncTask = default(Task);
						asyncTask.FireAndForgetTask();
					}
					string cookingBadIngredientsEmployeeEmotion = CookingBadIngredientsEmployeeEmotion;
					TimeSpan duration2 = TimeSpan.FromSeconds(num4);
					CancellationToken token2 = characterAnimationCTS.Token;
					PlayAnimation(cookingBadIngredientsEmployeeEmotion, duration2, token2).FireAndForgetTask();
				}
				currentEmployee2 = base.CurrentEmployee;
				Animator _003CAnimatorComponent_003Ek__BackingField = currentEmployee2.AnimatorComponent;
				string cookingAddIngredientAnimation = CookingAddIngredientAnimation;
				_003CAnimatorComponent_003Ek__BackingField.SetTrigger(cookingAddIngredientAnimation);
				goto IL_01a4;
			}
			goto IL_01b5;
			IL_01a4:
			int mealItemID_2 = response.mealItemID_;
			previouslyMadeMeal = (Item)currentEmployee2;
			goto IL_01b5;
			IL_01b5:
			List<Item> list3 = selectedIngredients;
			if (response.newRecipe_)
			{
				GameObject newCookbookInformationVFXPrefab = NewCookbookInformationVFXPrefab;
				int num6 = 0;
				bool flag = default(bool);
				if (newCookbookInformationVFXPrefab != (UnityEngine.Object)num6 && flag)
				{
					GameObject newCookbookInformationVFXPrefab2 = NewCookbookInformationVFXPrefab;
					Transform cookingPot = _cookingPot;
					GameObject gameObject = (newCookbookInformationVFXInstance = UnityEngine.Object.Instantiate(newCookbookInformationVFXPrefab2, cookingPot));
				}
				return;
			}
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6002C9E")]
			[Cpp2IlInjected.Address(RVA = "0x10FD200", Offset = "0x10FBC00", VA = "0x1810FD200")]
			[AsyncStateMachine(typeof(_003C_003COnIngredientsChanged_003Eg__PlayAnimation_007C74_1_003Ed))]
			Task PlayAnimation(string triggerName, TimeSpan duration, CancellationToken _ct)
			{
				int num7 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C92")]
		[Cpp2IlInjected.Address(RVA = "0x10FAB10", Offset = "0x10F9510", VA = "0x1810FAB10", Slot = "7")]
		protected override void CustomEmployeeSetup(Mdl.Characters.Character employee, bool startInteraction)
		{
			//Discarded unreachable code: IL_001c
			//IL_0011: Expected O, but got I4
			base.CustomEmployeeSetup(employee, startInteraction);
			int num = 0;
			if (employee != (UnityEngine.Object)num)
			{
				employee.EnableAI(startInteraction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C93")]
		[Cpp2IlInjected.Address(RVA = "0x10FABC0", Offset = "0x10F95C0", VA = "0x1810FABC0", Slot = "8")]
		protected override void CustomSetup(bool startInteraction)
		{
			//Discarded unreachable code: IL_00a5
			//IL_000d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			//IL_0038: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			if (!startInteraction)
			{
				int num = 0;
				temporarySwitchToolScope = (Toolbox.TemporarySwitchToolScope)num;
				GameObject gameObject = newCookbookInformationVFXInstance;
				int num2 = 0;
				bool flag = gameObject != (UnityEngine.Object)num2;
				int num3 = 0;
				if (flag)
				{
					UnityEngine.Object.Destroy(newCookbookInformationVFXInstance);
					newCookbookInformationVFXInstance = (GameObject)num3;
				}
				Time.fixedDeltaTime = savedFixedDeltaTime;
				GameObject gameObject2 = ingredientGO;
				int num4 = 0;
				if (!(gameObject2 != (UnityEngine.Object)num4))
				{
					goto IL_009d;
				}
				UnityEngine.Object.Destroy(ingredientGO);
				ingredientGO = (GameObject)num3;
			}
			int num5 = 0;
			float num6 = (savedFixedDeltaTime = Time.fixedDeltaTime);
			Time.fixedDeltaTime = 1f / 30f;
			Toolbox _003CToolbox_003Ek__BackingField = SystemRoot.Instance._avatar.Toolbox;
			int num7 = 0;
			goto IL_009d;
			IL_009d:
			inInteraction = startInteraction;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C94")]
		[Cpp2IlInjected.Address(RVA = "0x10FBCB0", Offset = "0x10FA6B0", VA = "0x1810FBCB0", Slot = "10")]
		[IteratorStateMachine(typeof(_003CGetEmployeeItems_003Ed__78))]
		protected override IEnumerable<Item> GetEmployeeItems()
		{
			new _003CGetEmployeeItems_003Ed__78(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002C95")]
		[Cpp2IlInjected.Address(RVA = "0x10FA3B0", Offset = "0x10F8DB0", VA = "0x1810FA3B0")]
		[AsyncStateMachine(typeof(_003CAddIngredient_003Ed__79))]
		public Task AddIngredient(Item item, bool isByGamepad = false)
		{
			int itemID = item.ItemID;
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C96")]
		[Cpp2IlInjected.Address(RVA = "0x10FB3B0", Offset = "0x10F9DB0", VA = "0x1810FB3B0")]
		public RecipeItemData GetChosenRecipeFromIngredients()
		{
			//Discarded unreachable code: IL_0170, IL_0176, IL_017c, IL_0182, IL_0188, IL_018e, IL_0194, IL_019a, IL_01a0, IL_01a6, IL_01ac
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			List<Item> list = selectedIngredients;
			Func<Item, ICookingIngredient> _003C_003E9__80_ = _003C_003Ec._003C_003E9__80_0;
			if (_003C_003E9__80_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0008
					ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
					ICookingIngredient result = default(ICookingIngredient);
					return result;
				};
			}
			ICookingIngredient[] array = Enumerable.Select<Item, ICookingIngredient>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__80_).ToArray<ICookingIngredient>();
			int capacity = default(int);
			List<ICookingIngredient> list2 = (List<ICookingIngredient>)(object)new List<T>(capacity);
			capacity = array.Length;
			bool flag = default(bool);
			bool flag2 = default(bool);
			RecipeItemData recipeItemData = default(RecipeItemData);
			if (flag && flag2)
			{
				((List<T>)(object)list2).Clear();
				((List<T>)(object)list2).AddRange((IEnumerable<>)(object)array);
				int num4 = 0;
				RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = recipeItemData.ingredients_;
				Func<RecipeItemData.Types.Ingredient, bool> func = default(Func<RecipeItemData.Types.Ingredient, bool>);
				if (_003C_003Ec._003C_003E9__80_1 == null)
				{
					func = (Func<RecipeItemData.Types.Ingredient, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((RecipeItemData.Types.Ingredient x) => x.ingredientCase_ == RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID));
				}
				IOrderedEnumerable<RecipeItemData.Types.Ingredient> orderedEnumerable = (IOrderedEnumerable<RecipeItemData.Types.Ingredient>)Enumerable.OrderByDescending<RecipeItemData.Types.Ingredient, bool>((IEnumerable<>)(object)ingredients_, (Func<, >)(object)func);
				if (orderedEnumerable != null)
				{
					_003C_003Ec__DisplayClass80_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass80_0();
					CS_0024_003C_003E8__locals0.ingredient = (RecipeItemData.Types.Ingredient)(object)CS_0024_003C_003E8__locals0;
					RecipeItemData.Types.Ingredient ingredient = CS_0024_003C_003E8__locals0.ingredient;
					RecipeItemData.Types.Ingredient.IngredientOneofCase ingredientCase_ = ingredient.ingredientCase_;
					if (ingredient != null)
					{
						if (ingredient != null)
						{
							if (ingredient != null)
							{
								while (ingredientCase_ != RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
								{
								}
								Predicate<ICookingIngredient> predicate = (Predicate<ICookingIngredient>)(object)(Predicate<T>)delegate
								{
									Item? anyItem3 = (Item?)CS_0024_003C_003E8__locals0.ingredient.get_AnyItem();
									throw new NullReferenceException();
								};
							}
							Predicate<ICookingIngredient> predicate2 = (Predicate<ICookingIngredient>)(object)(Predicate<T>)delegate
							{
								Item? anyItem2 = (Item?)CS_0024_003C_003E8__locals0.ingredient.get_AnyItem();
								throw new NullReferenceException();
							};
						}
						Predicate<ICookingIngredient> predicate3 = (Predicate<ICookingIngredient>)(object)(Predicate<T>)delegate
						{
							Item? anyItem = (Item?)CS_0024_003C_003E8__locals0.ingredient.get_AnyItem();
							throw new NullReferenceException();
						};
						int num5 = ((List<T>)(object)list2).FindIndex((Predicate<>)(object)predicate3);
					}
					Predicate<ICookingIngredient> predicate4 = (Predicate<ICookingIngredient>)(object)(Predicate<T>)delegate
					{
						Item? item = (Item?)CS_0024_003C_003E8__locals0.ingredient.get_Item();
						throw new NullReferenceException();
					};
					int num6 = ((List<T>)(object)list2).FindIndex((Predicate<>)(object)predicate4);
					while (num6 == -1)
					{
					}
					num4++;
					((List<T>)(object)list2).RemoveAt(num6);
				}
				if (orderedEnumerable != null)
				{
				}
				int count = ((RepeatedField<T>)(object)recipeItemData.ingredients_).Count;
				while (num4 != count)
				{
				}
			}
			return recipeItemData;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C97")]
		[Cpp2IlInjected.Address(RVA = "0x10FCCD0", Offset = "0x10FB6D0", VA = "0x1810FCCD0")]
		public void RemoveIngredient(Item item, bool animate = true)
		{
			//Discarded unreachable code: IL_0015
			List<Item> list = selectedIngredients;
			bool flag = default(bool);
			if (animate != flag)
			{
				int add = 0;
				OnIngredientsChanged((byte)add != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C98")]
		[Cpp2IlInjected.Address(RVA = "0x10FA9D0", Offset = "0x10F93D0", VA = "0x1810FA9D0")]
		[AsyncStateMachine(typeof(_003CCookWithIngredients_003Ed__82))]
		public Task<(CookWithIngredients.Types.Response, Task)> CookWithIngredients(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<(CookWithIngredients.Types.Response, Task)>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C99")]
		[Cpp2IlInjected.Address(RVA = "0x10FA870", Offset = "0x10F9270", VA = "0x1810FA870", Slot = "9")]
		[AsyncStateMachine(typeof(_003CCanInteract_003Ed__83))]
		public override Task<bool> CanInteract(PlayerTask task, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C9A")]
		[Cpp2IlInjected.Address(RVA = "0x10FA4E0", Offset = "0x10F8EE0", VA = "0x1810FA4E0")]
		private bool CanInteract()
		{
			//Discarded unreachable code: IL_0070
			if (!IsTutorial)
			{
				return true;
			}
			ProtoDatabase _003CInstance_003Ek__BackingField = ProtoDatabase.Instance;
			Item characterItem = Item.Invalid;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			IBuildingUnlockable buildingUnlockable = default(IBuildingUnlockable);
			if (buildingUnlockable != null)
			{
				characterItem = (Item)buildingUnlockable;
			}
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			Func<MissionObjective, bool> func = (Func<MissionObjective, bool>)(object)(Func<T, TResult>)delegate(MissionObjective x)
			{
				if (x.Data.customStepCase_ == MissionObjectiveData.CustomStepOneofCase.CookMeal && x.MissionSlot.class_ == MissionSlotClass.Story)
				{
					Item characterItem2 = x.MissionSlot.CharacterItem;
				}
				int num = 0;
				throw new NullReferenceException();
			};
			bool flag = Enumerable.Any<MissionObjective>(world_.GetOnGoingMissionObjectives((Func<, >)(object)func));
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002C9B")]
		[Cpp2IlInjected.Address(RVA = "0x10FBD20", Offset = "0x10FA720", VA = "0x1810FBD20", Slot = "11")]
		public void GetRenderers(List<Renderer> renderers)
		{
			//Discarded unreachable code: IL_003b
			//IL_0010: Expected O, but got I4
			StreamableAssetRef streamableAssetRef = this.streamableAssetRef;
			int num = 0;
			if (streamableAssetRef != (UnityEngine.Object)num && this.streamableAssetRef.IsLoaded)
			{
				StreamableAssetRef streamableAssetRef2 = this.streamableAssetRef;
			}
			else
			{
				((Component)base.transform.parent).GetComponentsInChildren<Renderer>((List<>)(object)renderers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C9C")]
		[Cpp2IlInjected.Address(RVA = "0x10FCC40", Offset = "0x10FB640", VA = "0x1810FCC40")]
		private void OnPlayerNavigationStatusChanged(Mdl.Systems.System system)
		{
			//Discarded unreachable code: IL_000f
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = !system.IsPaused;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002C9D")]
		[Cpp2IlInjected.Address(RVA = "0x10FD940", Offset = "0x10FC340", VA = "0x1810FD940")]
		public CookingStall()
		{
		}//IL_0074: Expected I4, but got I8

	}
}
