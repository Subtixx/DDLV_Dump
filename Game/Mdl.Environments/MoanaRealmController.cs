using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Characters;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000659")]
	public class MoanaRealmController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200065A")]
		public enum Destination
		{
			[Cpp2IlInjected.Token(Token = "0x40025E9")]
			East,
			[Cpp2IlInjected.Token(Token = "0x40025EA")]
			West,
			[Cpp2IlInjected.Token(Token = "0x40025EB")]
			North,
			[Cpp2IlInjected.Token(Token = "0x40025EC")]
			South,
			[Cpp2IlInjected.Token(Token = "0x40025ED")]
			Island
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200065B")]
		public class SeaSection
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40025EE")]
			public AssetReference SectionParentAsset;

			[Cpp2IlInjected.Token(Token = "0x6001C5D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SeaSection()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025D1")]
		private int currentPosition = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40025D2")]
		private GameObject _currentSeaAreaObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40025D3")]
		private float FadeDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40025D4")]
		private float FadeTime = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40025D5")]
		[ItemID]
		[SerializeField]
		private int _characterMoana = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40025D6")]
		[ItemID]
		[SerializeField]
		private int _characterMaui = (int)Item.Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40025D7")]
		[Header("Boat")]
		public GameObject BoatParentGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40025D8")]
		public Transform BoatAvatarTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40025D9")]
		public Transform BoatMoanaTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40025DA")]
		[Space]
		[Header("Island")]
		[Space(10f)]
		public GameObject IslandParentGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40025DB")]
		public Transform IslandAvatarTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40025DC")]
		public Transform IslandMoanaTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40025DD")]
		public Collider IslandGridObjectVisibilityVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40025DE")]
		private List<Collider> colliders = (List<Collider>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40025DF")]
		[Space]
		[Space(10f)]
		[Header("Sea")]
		public int SeaWidth = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40025E0")]
		public int SeaHeight = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40025E1")]
		[Space]
		[SerializeField]
		public SeaSection[] SeaSectionsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40025E2")]
		[ItemID]
		[SerializeField]
		[Space]
		[ItemID(ItemType.Condition)]
		[Header("Lantern")]
		[Space(10f)]
		private int _lanternConditionItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40025E3")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40025E4")]
		public string lanternLayerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40025E5")]
		public string addLanternTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40025E6")]
		public string removeLanternTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40025E7")]
		private bool gridObjectsVisible = true;

		[Cpp2IlInjected.Token(Token = "0x170003FB")]
		public int CurrentPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6001C4F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return currentPosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FC")]
		public Item Moana
		{
			[Cpp2IlInjected.Token(Token = "0x6001C50")]
			[Cpp2IlInjected.Address(RVA = "0xEFB430", Offset = "0xEF9E30", VA = "0x180EFB430")]
			get
			{
				long num = Convert.ToInt64((uint)_characterMoana);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FD")]
		public Item Maui
		{
			[Cpp2IlInjected.Token(Token = "0x6001C51")]
			[Cpp2IlInjected.Address(RVA = "0xEFB3D0", Offset = "0xEF9DD0", VA = "0x180EFB3D0")]
			get
			{
				long num = Convert.ToInt64((uint)_characterMaui);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003FE")]
		public Item LanternConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001C52")]
			[Cpp2IlInjected.Address(RVA = "0xEFB370", Offset = "0xEF9D70", VA = "0x180EFB370")]
			get
			{
				long num = Convert.ToInt64((uint)_lanternConditionItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C53")]
		[Cpp2IlInjected.Address(RVA = "0xEFB160", Offset = "0xEF9B60", VA = "0x180EFB160")]
		private void Start()
		{
			//Discarded unreachable code: IL_004d
			GameObject gameObject = (_currentSeaAreaObject = IslandParentGameObject);
			CreateEventHandler();
			Environment environment = GetComponent<Environment>();
			Environment environment2 = environment;
			EventHandler value = OnEnvironmentEnteredEvent;
			environment2.EnvironmentEnteredEvent += value;
			[Cpp2IlInjected.Token(Token = "0x6001C5F")]
			[Cpp2IlInjected.Address(RVA = "0x1216C90", Offset = "0x1215690", VA = "0x181216C90")]
			void OnEnvironmentEnteredEvent(object sender, EventArgs e)
			{
				//Discarded unreachable code: IL_002c
				Environment environment3 = environment;
				EventHandler value2 = OnEnvironmentEnteredEvent;
				environment3.EnvironmentEnteredEvent -= value2;
				MoanaRealmController moanaRealmController = this;
				int conditionListener = 0;
				moanaRealmController.OnConditionChanged((ConditionListener)conditionListener);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C54")]
		[Cpp2IlInjected.Address(RVA = "0xEFA7F0", Offset = "0xEF91F0", VA = "0x180EFA7F0")]
		private void OnDestroy()
		{
			while (true)
			{
				if ((object)this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C55")]
		[Cpp2IlInjected.Address(RVA = "0xEFA4E0", Offset = "0xEF8EE0", VA = "0x180EFA4E0")]
		[AsyncStateMachine(typeof(_003CChangeSection_003Ed__34))]
		public Task ChangeSection(int destination)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C56")]
		[Cpp2IlInjected.Address(RVA = "0xEFA960", Offset = "0xEF9360", VA = "0x180EFA960")]
		[AsyncStateMachine(typeof(_003CExecuteChangeSection_003Ed__35))]
		private Task ExecuteChangeSection(AssetReference destinationParentAsset)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C57")]
		[Cpp2IlInjected.Address(RVA = "0xEFA830", Offset = "0xEF9230", VA = "0x180EFA830")]
		[AsyncStateMachine(typeof(_003CExecuteChangeSection_003Ed__36))]
		private Task ExecuteChangeSection(GameObject destinationParentGameObject)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C58")]
		[Cpp2IlInjected.Address(RVA = "0xEFAEF0", Offset = "0xEF98F0", VA = "0x180EFAEF0")]
		private void SetIslandGridObjectsVisibility(bool visible)
		{
			//Discarded unreachable code: IL_0091
			int num = 0;
			int num2 = 0;
			if (gridObjectsVisible == visible)
			{
				return;
			}
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			GridObjectScript[] componentsInChildren = gameObject.GetComponentsInChildren<GridObjectScript>(includeInactive: true);
			int num3 = 0;
			int length = componentsInChildren.Length;
			if (num3 < length)
			{
				Collider islandGridObjectVisibilityVolume = IslandGridObjectVisibilityVolume;
				GridObjectScript gridObjectScript = componentsInChildren[num3];
				Transform transform = gridObjectScript.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				bool flag = default(bool);
				if (flag)
				{
					gridObjectScript.gameObject.SetActive(visible);
				}
				num3++;
			}
			gridObjectsVisible = visible;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C59")]
		[Cpp2IlInjected.Address(RVA = "0xEFA5F0", Offset = "0xEF8FF0", VA = "0x180EFA5F0")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)_lanternConditionItemID);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C5A")]
		[Cpp2IlInjected.Address(RVA = "0xEFAA90", Offset = "0xEF9490", VA = "0x180EFAA90")]
		private void OnConditionChanged(ConditionListener conditionListener)
		{
			//IL_0027: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int characterMoana = _characterMoana;
			Mdl.Characters.Character character = default(Mdl.Characters.Character);
			if ((object)character != null)
			{
			}
			int num = 0;
			Animator moanaAnimator = (Animator)num;
			Animator animator = moanaAnimator;
			int num2 = 0;
			if (animator != (UnityEngine.Object)num2)
			{
				Animator animator2 = moanaAnimator;
				string layerName = lanternLayerName;
				int layerIndex = animator2.GetLayerIndex(layerName);
				long num3 = Convert.ToInt64((uint)_lanternConditionItemID);
				Client metaClient = SystemRoot.Instance.MetaClient;
				Client metaClient2 = SystemRoot.Instance.MetaClient;
				Animator animator3 = moanaAnimator;
				bool flag = default(bool);
				if (flag)
				{
					int num4 = layerIndex;
					Animator animator4 = moanaAnimator;
					int layerIndex2 = layerIndex;
					animator4.SetLayerWeight(layerIndex2, 1f);
					Animator animator5 = moanaAnimator;
					string trigger = addLanternTrigger;
					animator5.SetTrigger(trigger);
					throw new NullReferenceException();
				}
				int layerIndex3 = layerIndex;
				float layerWeight = animator3.GetLayerWeight(layerIndex3);
				if ((object)animator3 == null)
				{
					Animator animator6 = moanaAnimator;
					string trigger2 = removeLanternTrigger;
					animator6.SetTrigger(trigger2);
					WaitThenRemoveLayer().FireAndForgetTask();
				}
			}
			[Cpp2IlInjected.Token(Token = "0x6001C67")]
			[Cpp2IlInjected.Address(RVA = "0x1216F60", Offset = "0x1215960", VA = "0x181216F60")]
			[AsyncStateMachine(typeof(_003C_003Ec__DisplayClass40_0._003C_003COnConditionChanged_003Eg__WaitThenRemoveLayer_007C0_003Ed))]
			Task WaitThenRemoveLayer()
			{
				int num5 = 0;
				Task result = default(Task);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C5B")]
		[Cpp2IlInjected.Address(RVA = "0xEFA7F0", Offset = "0xEF91F0", VA = "0x180EFA7F0")]
		private void DisposeEventHandler()
		{
			while (true)
			{
				if ((object)this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C5C")]
		[Cpp2IlInjected.Address(RVA = "0xEFB270", Offset = "0xEF9C70", VA = "0x180EFB270")]
		public MoanaRealmController()
		{
		}//IL_0010: Expected I4, but got I8
		//IL_0033: Expected I4, but got O
		//IL_0040: Expected I4, but got O
		//IL_0056: Expected I4, but got I8
		//IL_005f: Expected I4, but got I8

	}
}
