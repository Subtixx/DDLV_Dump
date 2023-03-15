using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Missions;
using Google.Protobuf.Collections;
using Mdl.Characters;
using Mdl.Dialogues;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Grids;
using Meta.Online;
using Meta.Util;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007E9")]
	public class WorldUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E7B")]
		private PositionHandler _positionHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E7C")]
		private GardeningStallShelvesContent _gardeningStallShelvesContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002E7D")]
		private MultipleChoiceTaskHandler _multipleChoiceTaskHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002E7E")]
		[SerializeField]
		private MultipleChoiceTaskHandler _multipleChoiceTaskPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002E7F")]
		[SerializeField]
		private PositionHandler _positionHandlerPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002E80")]
		[SerializeField]
		private GardeningStallShelvesContent _gardeningStallShelvesPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002E81")]
		[SerializeField]
		private NPCConversation _npcConversationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002E82")]
		[SerializeField]
		private CharacterQuestMarker _characterQuestMarkerPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002E83")]
		[SerializeField]
		private ManaMeditateInfo _manaMeditatePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002E84")]
		[SerializeField]
		private NotEnoughManaInfo _notEnoughManaPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002E85")]
		[SerializeField]
		private InteractionPreviewInfo _interactionPreviewInfoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002E86")]
		[SerializeField]
		private CurrencyGainInfo _currencyGainInfoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002E87")]
		[ItemID]
		[SerializeField]
		private int _villageIntroCutsceneID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4002E88")]
		private bool _isIntroCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7D")]
		[Cpp2IlInjected.Token(Token = "0x4002E89")]
		private bool _isShowingInteractionPreview;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002E8A")]
		private List<CharacterQuestMarker> _instantiatedQuestMarkers = (List<CharacterQuestMarker>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002E8B")]
		private Task refreshQuestMarkerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002E8C")]
		private int showCount = 1;

		[Cpp2IlInjected.Token(Token = "0x1700071E")]
		public PositionHandler PositionHandler
		{
			[Cpp2IlInjected.Token(Token = "0x600326B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _positionHandler;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700071F")]
		private Item _villageIntroCutsceneItem
		{
			[Cpp2IlInjected.Token(Token = "0x600326C")]
			[Cpp2IlInjected.Address(RVA = "0x8ECAC0", Offset = "0x8EB4C0", VA = "0x1808ECAC0")]
			get
			{
				long num = Convert.ToInt64((uint)_villageIntroCutsceneID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600326D")]
		[Cpp2IlInjected.Address(RVA = "0x8EB0A0", Offset = "0x8E9AA0", VA = "0x1808EB0A0")]
		private bool IsIntroCompleted()
		{
			//Discarded unreachable code: IL_0071
			//IL_0042: Expected O, but got I8
			bool isIntroCompleted = _isIntroCompleted;
			if (!isIntroCompleted)
			{
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				RepeatedField<int> completedFtueEvents_ = SystemRoot.Instance.MetaClient.profile.player_.completedFtueEvents_;
				long num2 = Convert.ToInt64((uint)_villageIntroCutsceneID);
				bool flag = ((RepeatedField<T>)(object)completedFtueEvents_).Contains((T)num2);
				if (flag || DebugSettings.WasCreatedThisSession != flag || settings.disableAllFtue_ == flag)
				{
				}
				bool flag2 = (_isIntroCompleted = 1 != 0);
			}
			return isIntroCompleted;
		}

		[Cpp2IlInjected.Token(Token = "0x600326E")]
		[Cpp2IlInjected.Address(RVA = "0x8EB270", Offset = "0x8E9C70", VA = "0x1808EB270")]
		public MultipleChoiceTaskHandler MultipleChoiceStart(List<PlayerTaskDefinition> playerTasks, GameObject target)
		{
			//Discarded unreachable code: IL_002c
			bool flag = default(bool);
			if (flag)
			{
				GameObject obj = default(GameObject);
				UnityEngine.Object.Destroy(obj);
			}
			MultipleChoiceTaskHandler multipleChoiceTaskPrefab = _multipleChoiceTaskPrefab;
			Transform parent = base.transform;
			return _multipleChoiceTaskHandler = UnityEngine.Object.Instantiate(multipleChoiceTaskPrefab, parent);
		}

		[Cpp2IlInjected.Token(Token = "0x600326F")]
		[Cpp2IlInjected.Address(RVA = "0x8EB480", Offset = "0x8E9E80", VA = "0x1808EB480")]
		public PositionHandler PositionHandlerStart(GameObject target)
		{
			//Discarded unreachable code: IL_003a
			//IL_0013: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
				GameObject obj = default(GameObject);
				UnityEngine.Object.Destroy(obj);
			}
			int num = 0;
			PositionHandler result = default(PositionHandler);
			if (target != (UnityEngine.Object)num)
			{
				PositionHandler positionHandlerPrefab = _positionHandlerPrefab;
				Transform parent = base.transform;
				result = (_positionHandler = UnityEngine.Object.Instantiate(positionHandlerPrefab, parent));
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003270")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F90", Offset = "0x8E8990", VA = "0x1808E9F90")]
		public void GardeningShelvesStart(List<GameObject> targets, Shop shop, GridObject gridObject)
		{
			//Discarded unreachable code: IL_002e
			bool flag = default(bool);
			if (flag)
			{
				GameObject obj = default(GameObject);
				UnityEngine.Object.Destroy(obj);
			}
			if (targets != null)
			{
				GardeningStallShelvesContent gardeningStallShelvesPrefab = _gardeningStallShelvesPrefab;
				Transform parent = base.transform;
				GardeningStallShelvesContent gardeningStallShelvesContent = (_gardeningStallShelvesContent = UnityEngine.Object.Instantiate(gardeningStallShelvesPrefab, parent));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003271")]
		[Cpp2IlInjected.Address(RVA = "0x8EA130", Offset = "0x8E8B30", VA = "0x1808EA130")]
		public void GardeningShelvesStop()
		{
			//Discarded unreachable code: IL_002d
			//IL_0010: Expected O, but got I4
			//IL_002c: Expected O, but got I8
			GardeningStallShelvesContent gardeningStallShelvesContent = _gardeningStallShelvesContent;
			int num = 0;
			if (gardeningStallShelvesContent != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(_gardeningStallShelvesContent.gameObject);
				_gardeningStallShelvesContent = (GardeningStallShelvesContent)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003272")]
		[Cpp2IlInjected.Address(RVA = "0x8EB7F0", Offset = "0x8EA1F0", VA = "0x1808EB7F0")]
		public void RemoveQuestMarkers()
		{
			//Discarded unreachable code: IL_0081, IL_0087, IL_008d, IL_0093
			//IL_006b: Expected O, but got I4
			int num = 0;
			((List<T>)(object)_instantiatedQuestMarkers).Clear();
			CharacterQuestMarker[] componentsInChildren = base.transform.GetComponentsInChildren<CharacterQuestMarker>();
			Func<CharacterQuestMarker, bool> _003C_003E9__25_ = _003C_003Ec._003C_003E9__25_0;
			if (_003C_003E9__25_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((CharacterQuestMarker x) => !x.IsMailbox);
			}
			IEnumerable<CharacterQuestMarker> enumerable = (IEnumerable<CharacterQuestMarker>)Enumerable.Where<CharacterQuestMarker>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)_003C_003E9__25_);
			int num4 = default(int);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0075;
					}
					num++;
				}
				GameObject gameObject = default(GameObject);
				Transform transform = gameObject.transform;
				int num3 = 0;
				transform.parent = (Transform)num3;
				num4 = 0;
				GameObject obj = default(GameObject);
				UnityEngine.Object.Destroy(obj);
				goto IL_0075;
			}
			goto IL_007c;
			IL_0075:
			num4 += num4;
			goto IL_007c;
			IL_007c:
			if (enumerable == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003273")]
		[Cpp2IlInjected.Address(RVA = "0x8EB600", Offset = "0x8EA000", VA = "0x1808EB600")]
		public void RefreshQuestMarkers()
		{
			Task task = refreshQuestMarkerTask;
			if ((task == null || task.IsCompleted) && IsIntroCompleted())
			{
				int num = 0;
				Task task2 = default(Task);
				refreshQuestMarkerTask = task2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003274")]
		[Cpp2IlInjected.Address(RVA = "0x8E98A0", Offset = "0x8E82A0", VA = "0x1808E98A0")]
		private unsafe void ForceRefreshQuestMarkers()
		{
			//Discarded unreachable code: IL_0114, IL_011a, IL_0120, IL_0126, IL_0132, IL_0138, IL_013e, IL_0144, IL_014a, IL_0150, IL_0156, IL_015c
			//IL_0023: Expected I4, but got I8
			//IL_00d1: Expected O, but got I4
			//IL_00d1: Expected I4, but got I8
			ulong num2 = default(ulong);
			uint num3 = default(uint);
			Client client = default(Client);
			int num4 = default(int);
			MissionSlotState missionSlotState = default(MissionSlotState);
			CharacterQuestMarker characterQuestMarker = default(CharacterQuestMarker);
			int num5 = default(int);
			object[] array = default(object[]);
			GameObject gameObject = default(GameObject);
			ulong num6 = default(ulong);
			Transform transform = default(Transform);
			while (true)
			{
				int num = 0;
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				RemoveQuestMarkers();
				IEnumerable<Mdl.Characters.Character> activeCharacters = (IEnumerable<Mdl.Characters.Character>)SystemRoot.Instance.GetSystem<CharacterManager>().GetActiveCharacters((byte)num2 != 0);
				if (activeCharacters != null)
				{
					_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_0();
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_00a4;
						}
						num++;
					}
					CS_0024_003C_003E8__locals0.character = (Mdl.Characters.Character)(object)CS_0024_003C_003E8__locals0;
					RepeatedField<CharacterRestaurantOrder> characterRestaurantOrders_ = client.profile.world_.characterRestaurantOrders_;
					Func<CharacterRestaurantOrder, bool> cpp2il__autoParamName__idx_ = (Func<CharacterRestaurantOrder, bool>)(object)(Func<T, TResult>)delegate(CharacterRestaurantOrder x)
					{
						//Discarded unreachable code: IL_002b
						Item characterItem = x.CharacterItem;
						Item _003CItem_003Ek__BackingField = CS_0024_003C_003E8__locals0.character.Item;
						bool flag = *(Item*)characterItem == *(Item*)_003CItem_003Ek__BackingField;
						return (!flag) ? flag : (!x.fulfilled_);
					};
					if (((IEnumerable<>)(object)characterRestaurantOrders_).Any<CharacterRestaurantOrder>((Func<, >)(object)cpp2il__autoParamName__idx_))
					{
						continue;
					}
					num4 = (int)missionSlotState;
					while (missionSlotState == MissionSlotState.Invalid)
					{
					}
					float maxOpacity = characterQuestMarker._maxOpacity;
					num5 = 0;
					array = new object[2];
					if (array != null && array == null)
					{
						throw new NullReferenceException();
					}
					goto IL_00a4;
				}
				goto IL_00d1;
				IL_00a4:
				array[0] = array;
				if (array != null && array == null)
				{
					break;
				}
				array[1] = array;
				characterQuestMarker.Init(gameObject, (byte)num6 != 0, (Nullable<>)num5, array);
				goto IL_00d1;
				IL_00d1:
				int num7 = 0;
				if (activeCharacters != null)
				{
				}
				if (num4 == 0)
				{
					CharacterFriendshipBar[] componentsInChildren = transform.GetComponentsInChildren<CharacterFriendshipBar>();
					int length = componentsInChildren.Length;
					if (num7 < length)
					{
						componentsInChildren[num7].RefreshQuestMarker();
						num7++;
					}
					return;
				}
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003275")]
		[Cpp2IlInjected.Address(RVA = "0x8EC5F0", Offset = "0x8EAFF0", VA = "0x1808EC5F0")]
		public void ShowManaRefillGizmo()
		{
			//Discarded unreachable code: IL_0059
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			GameObject head = SystemRoot.Instance._avatar.CharacterVisualNodes.Head;
			GameObject gameObject = _manaMeditatePrefab.gameObject;
			CancellationToken token = cancellationTokenSource.Token;
			int num = 0;
			InfoGizmo infoGizmo = default(InfoGizmo);
			InfoGizmo manaGizmo = infoGizmo;
			Coroutine coroutine = Coroutines.Delay(delegate
			{
				//Discarded unreachable code: IL_0011
				UnityEngine.Object.Destroy(manaGizmo.gameObject);
			}, 1.5f);
		}

		[Cpp2IlInjected.Token(Token = "0x6003276")]
		[Cpp2IlInjected.Address(RVA = "0x8EC160", Offset = "0x8EAB60", VA = "0x1808EC160")]
		public void ShowLowManaGizmo(bool notEnough)
		{
			//Discarded unreachable code: IL_0079
			GameObject headIcon;
			GameObject infoGizmoPrefab;
			CancellationToken token;
			object[] array;
			do
			{
				Type typeFromHandle = typeof(NotEnoughManaInfo);
				GetGizmoByType(typeFromHandle)?.Kill();
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
				headIcon = SystemRoot.Instance._avatar.CharacterVisualNodes.HeadIcon;
				infoGizmoPrefab = _notEnoughManaPrefab.gameObject;
				token = cancellationTokenSource.Token;
				array = new object[1];
			}
			while (array != null && array == null);
			array[0] = array;
			InfoGizmo infoGizmo = InfoGizmoStart(headIcon, infoGizmoPrefab, token, array);
		}

		[Cpp2IlInjected.Token(Token = "0x6003277")]
		[Cpp2IlInjected.Address(RVA = "0x8EB750", Offset = "0x8EA150", VA = "0x1808EB750")]
		public void RemoveNotEnoughMana()
		{
			Type typeFromHandle = typeof(NotEnoughManaInfo);
			GetGizmoByType(typeFromHandle)?.Kill();
		}

		[Cpp2IlInjected.Token(Token = "0x6003278")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB40", Offset = "0x8EA540", VA = "0x1808EBB40")]
		public void ShowCurrencyGain(CurrencyGainCurrencyType currencyType, CurrencyGainAnimationType animationType, [System.Runtime.InteropServices.Optional] Transform source, [System.Runtime.InteropServices.Optional] RectTransform lastPos, int amount = -1)
		{
			//Discarded unreachable code: IL_0061
			//IL_000f: Expected O, but got I4
			int num = 0;
			if (source == (UnityEngine.Object)num)
			{
				int num2 = 0;
				Transform transform = UiRoot.Instance._worldCanvas.transform;
			}
			CurrencyGainInfo currencyGainInfo = UnityEngine.Object.Instantiate(_currencyGainInfoPrefab, source);
			CurrencyGainInfo component = currencyGainInfo.GetComponent<CurrencyGainInfo>();
			CurrencyGainInfo currencyGainInfo2 = currencyGainInfo;
			Action<object> action = (Action<object>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_0011
				UnityEngine.Object.Destroy(currencyGainInfo.gameObject);
			};
			int num3 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003279")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD30", Offset = "0x8EA730", VA = "0x1808EBD30")]
		public void ShowInteractionPreview(GameObject target, InteractPreviewData[] interactionMessages, params object[] args)
		{
			//Discarded unreachable code: IL_008e
			//IL_008b: Expected O, but got I4
			while (true)
			{
				DestroyInteractionPreview(target);
				if (!IsIntroCompleted() || _isShowingInteractionPreview)
				{
					break;
				}
				_isShowingInteractionPreview = true;
				object[] array = new object[3];
				int num = 0;
				object obj = Enumerable.ElementAtOrDefault<object>((IEnumerable<>)(object)args, num);
				if (obj != null && obj == null)
				{
					continue;
				}
				array[0] = obj;
				object obj2 = Enumerable.ElementAtOrDefault<object>((IEnumerable<>)(object)args, 1);
				if (obj2 == null || obj2 != null)
				{
					array[1] = obj2;
					if (interactionMessages == null || obj2 != null)
					{
						array[2] = interactionMessages;
						GameObject infoGizmoPrefab = _interactionPreviewInfoPrefab.gameObject;
						int num2 = 0;
						InfoGizmo infoGizmo = InfoGizmoStart(target, infoGizmoPrefab, (CancellationToken)num2, array);
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600327A")]
		[Cpp2IlInjected.Address(RVA = "0x8E9530", Offset = "0x8E7F30", VA = "0x1808E9530")]
		public void DestroyInteractionPreview([System.Runtime.InteropServices.Optional] GameObject targetToKeep)
		{
			//Discarded unreachable code: IL_007c, IL_0082, IL_0088, IL_009a
			//IL_004a: Expected O, but got I4
			Component component = default(Component);
			int num6 = default(int);
			while (true)
			{
				int num = 0;
				if ((_isShowingInteractionPreview ? 1 : 0) == num)
				{
					return;
				}
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					Type typeFromHandle = typeof(InteractionPreviewInfo);
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					if ((object)component == null)
					{
					}
					int num4 = 0;
					int num5 = 0;
					if (!(component != (UnityEngine.Object)num5))
					{
						continue;
					}
					if ((object)targetToKeep != null)
					{
						int instanceID = targetToKeep.GetInstanceID();
					}
					bool flag = num6 == num;
					if (num != (flag ? 1 : 0))
					{
						num++;
					}
				}
				if (num == 0)
				{
					bool flag2 = (_isShowingInteractionPreview = num > 0);
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600327B")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF60", Offset = "0x8E9960", VA = "0x1808EAF60")]
		public InfoGizmo InfoGizmoStart(GameObject target, GameObject infoGizmoPrefab, CancellationToken ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_0018
			Transform parent = base.transform;
			InfoGizmo component = UnityEngine.Object.Instantiate(infoGizmoPrefab, parent).GetComponent<InfoGizmo>();
			int num = 0;
			return component;
		}

		[Cpp2IlInjected.Token(Token = "0x600327C")]
		[Cpp2IlInjected.Address(RVA = "0x8EADD0", Offset = "0x8E97D0", VA = "0x1808EADD0")]
		[AsyncStateMachine(typeof(_003CInfoGizmoStart_003Ed__36))]
		public Task<InfoGizmo> InfoGizmoStart(GameObject target, AssetReferenceGameObject infoGizmoPrefab, CancellationToken ct, params object[] parameters)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<InfoGizmo>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600327D")]
		[Cpp2IlInjected.Address(RVA = "0x8EB3D0", Offset = "0x8E9DD0", VA = "0x1808EB3D0")]
		internal void NpcConversationStart(DialogueInstance e)
		{
			//Discarded unreachable code: IL_001c
			NPCConversation npcConversationPrefab = _npcConversationPrefab;
			Transform parent = base.transform;
			UnityEngine.Object.Instantiate(npcConversationPrefab, parent).Init(e);
		}

		[Cpp2IlInjected.Token(Token = "0x600327E")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8F0", Offset = "0x8EB2F0", VA = "0x1808EC8F0")]
		public void Show()
		{
			//Discarded unreachable code: IL_0017
			if (showCount == 1)
			{
				base.gameObject.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600327F")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD20", Offset = "0x8E9720", VA = "0x1808EAD20")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0036
			//IL_0035: Expected I4, but got I8
			int num = showCount;
			if (num == 1)
			{
				GameObject gameObject = base.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			showCount = num;
			Debug.LogError("Too many WorldUI.Hide()");
			showCount = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6003280")]
		[Cpp2IlInjected.Address(RVA = "0x8EC7E0", Offset = "0x8EB1E0", VA = "0x1808EC7E0")]
		public void ShowQuestMarkers()
		{
			//Discarded unreachable code: IL_0013, IL_0019
			List<CharacterQuestMarker> instantiatedQuestMarkers = _instantiatedQuestMarkers;
			bool flag = default(bool);
			if (flag)
			{
				GameObject gameObject = default(GameObject);
				gameObject.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003281")]
		[Cpp2IlInjected.Address(RVA = "0x8EAB90", Offset = "0x8E9590", VA = "0x1808EAB90")]
		public bool HideQuestMarkers()
		{
			//Discarded unreachable code: IL_002a, IL_0030, IL_0036, IL_003c
			int num = 0;
			List<CharacterQuestMarker> instantiatedQuestMarkers = _instantiatedQuestMarkers;
			bool flag = default(bool);
			if (flag)
			{
				GameObject gameObject = default(GameObject);
				bool activeSelf = gameObject.activeSelf;
				int active = 0;
				GameObject gameObject2 = default(GameObject);
				gameObject2.SetActive((byte)active != 0);
			}
			GameObject gameObject3 = default(GameObject);
			return gameObject3.activeSelf;
		}

		[Cpp2IlInjected.Token(Token = "0x6003282")]
		[Cpp2IlInjected.Address(RVA = "0x8EBF50", Offset = "0x8EA950", VA = "0x1808EBF50")]
		public void ShowLootOfflineMarkers()
		{
			//Discarded unreachable code: IL_003b, IL_0041, IL_0053
			//IL_0027: Expected O, but got I4
			IEnumerator enumerator = base.transform.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				LootOfflineMarker lootOfflineMarker = default(LootOfflineMarker);
				flag = lootOfflineMarker != (UnityEngine.Object)num3;
				while (!flag)
				{
				}
				lootOfflineMarker.ForceHide = false;
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003283")]
		[Cpp2IlInjected.Address(RVA = "0x8EA770", Offset = "0x8E9170", VA = "0x1808EA770")]
		public void HideLootOfflineMarkers()
		{
			//Discarded unreachable code: IL_003b, IL_0041, IL_0053
			//IL_0027: Expected O, but got I4
			IEnumerator enumerator = base.transform.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				LootOfflineMarker lootOfflineMarker = default(LootOfflineMarker);
				flag = lootOfflineMarker != (UnityEngine.Object)num3;
				while (!flag)
				{
				}
				lootOfflineMarker.ForceHide = true;
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003284")]
		[Cpp2IlInjected.Address(RVA = "0x8EC3E0", Offset = "0x8EADE0", VA = "0x1808EC3E0")]
		public void ShowMailboxMarkers()
		{
			//Discarded unreachable code: IL_0044, IL_004a, IL_005c
			//IL_0027: Expected O, but got I4
			IEnumerator enumerator = base.transform.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				CharacterQuestMarker characterQuestMarker = default(CharacterQuestMarker);
				flag = characterQuestMarker != (UnityEngine.Object)num3;
				while (!flag)
				{
				}
				while (!characterQuestMarker.IsMailbox)
				{
				}
				characterQuestMarker.ForceHide = false;
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003285")]
		[Cpp2IlInjected.Address(RVA = "0x8EA980", Offset = "0x8E9380", VA = "0x1808EA980")]
		public void HideMailboxMarkers()
		{
			//Discarded unreachable code: IL_0044, IL_004a, IL_005c
			//IL_0027: Expected O, but got I4
			IEnumerator enumerator = base.transform.GetEnumerator();
			bool flag = default(bool);
			if (enumerator != null)
			{
				int num = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				CharacterQuestMarker characterQuestMarker = default(CharacterQuestMarker);
				flag = characterQuestMarker != (UnityEngine.Object)num3;
				while (!flag)
				{
				}
				while (!characterQuestMarker.IsMailbox)
				{
				}
				characterQuestMarker.ForceHide = true;
			}
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003286")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4C0", Offset = "0x8E8EC0", VA = "0x1808EA4C0")]
		public InfoGizmo GetGizmoByType(Type gizmoType)
		{
			//Discarded unreachable code: IL_0050, IL_0062
			//IL_0032: Expected O, but got I4
			int num = 0;
			IEnumerator enumerator = base.transform.GetEnumerator();
			bool flag = default(bool);
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
				Component component = default(Component);
				if ((object)component == null)
				{
				}
				int num4 = 0;
				int num5 = 0;
				flag = component != (UnityEngine.Object)num5;
				while (!flag)
				{
				}
				num++;
			}
			num++;
			if (flag)
			{
			}
			if (num != 0)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003287")]
		[Cpp2IlInjected.Address(RVA = "0x8EA1F0", Offset = "0x8E8BF0", VA = "0x1808EA1F0")]
		public InfoGizmo GetActiveGizmoByType(Type gizmoType)
		{
			//Discarded unreachable code: IL_0051, IL_0057, IL_0069
			//IL_0032: Expected O, but got I4
			Component component = default(Component);
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				IEnumerator enumerator = base.transform.GetEnumerator();
				if (enumerator != null)
				{
					int num2 = 0;
					if (enumerator == null)
					{
						break;
					}
					int num3 = 0;
					if (enumerator == null)
					{
						throw new InvalidCastException();
					}
					if ((object)component == null)
					{
					}
					int num4 = 0;
					int num5 = 0;
					if (!(component != (UnityEngine.Object)num5))
					{
						continue;
					}
					while (!flag)
					{
					}
					num++;
				}
				num++;
				if (flag)
				{
				}
				if (num != 0)
				{
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003288")]
		[Cpp2IlInjected.Address(RVA = "0x8ECA30", Offset = "0x8EB430", VA = "0x1808ECA30")]
		public WorldUI()
		{
		}//IL_0016: Expected I4, but got I8

	}
}
