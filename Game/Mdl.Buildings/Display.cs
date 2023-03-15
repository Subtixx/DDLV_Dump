using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Displays;
using Definitions.Items;
using Mdl.Characters;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x200099C")]
	public abstract class Display : MonoBehaviour, IPlayerTaskDataProvider, IInteractible
	{
		[Cpp2IlInjected.Token(Token = "0x200099D")]
		protected class SlotTransform
		{
			[Cpp2IlInjected.Token(Token = "0x17000679")]
			public unsafe Vector3 Position
			{
				[Cpp2IlInjected.Token(Token = "0x6002D1C")]
				[Cpp2IlInjected.Address(RVA = "0xF0A3C0", Offset = "0xF08DC0", VA = "0x180F0A3C0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x6002D1D")]
				[Cpp2IlInjected.Address(RVA = "0xF0A930", Offset = "0xF09330", VA = "0x180F0A930")]
				[CompilerGenerated]
				set
				{
					//IL_000e: Expected native int or pointer, but got O
					float z = value.z;
					((Vector3*)(IntPtr)_003CPosition_003Ek__BackingField)->z = z;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700067A")]
			public Quaternion Rotation
			{
				[Cpp2IlInjected.Token(Token = "0x6002D1E")]
				[Cpp2IlInjected.Address(RVA = "0xF0A3E0", Offset = "0xF08DE0", VA = "0x180F0A3E0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x6002D1F")]
				[Cpp2IlInjected.Address(RVA = "0xF0A940", Offset = "0xF09340", VA = "0x180F0A940")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002D20")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SlotTransform()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200099E")]
		public class SlotInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003520")]
			public GameObject GO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003521")]
			public DisplaySlotData Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003522")]
			public GameObject UnavailableGO;

			[Cpp2IlInjected.Token(Token = "0x1700067B")]
			public bool IsAvailable
			{
				[Cpp2IlInjected.Token(Token = "0x6002D21")]
				[Cpp2IlInjected.Address(RVA = "0x137EEE0", Offset = "0x137D8E0", VA = "0x18137EEE0")]
				get
				{
					//IL_0010: Expected O, but got I4
					GameObject gO = GO;
					int num = 0;
					if (gO != (UnityEngine.Object)num)
					{
						DisplaySlotData data = Data;
						if ((object)data != null)
						{
							DisplaySlot _003CDisplaySlot_003Ek__BackingField = data.DisplaySlot;
							if (_003CDisplaySlot_003Ek__BackingField != null)
							{
								return _003CDisplaySlot_003Ek__BackingField.isAvailable_;
							}
						}
					}
					int num2 = 0;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002D22")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SlotInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200099F")]
		public class InteractionSetup
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003523")]
			public Transform AvatarPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003524")]
			public Transform OwnerPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4003525")]
			public Transform CameraPosition;

			[Cpp2IlInjected.Token(Token = "0x6002D23")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public InteractionSetup()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003511")]
		[SerializeField]
		private List<InteractionSetup> _interactionSetupList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003512")]
		[SerializeField]
		private PlayerTaskDefinition _interactWithDisplayTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003513")]
		[SerializeField]
		private GameObject _unavailableItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003516")]
		private ColliderRedirection colliderRedirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400351B")]
		private SlotInfo[] _slotList = new SlotInfo[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400351D")]
		private SlotInfo currentInteractibleSlot;

		[Cpp2IlInjected.Token(Token = "0x1700066B")]
		public List<InteractionSetup> InteractionSetupList
		{
			[Cpp2IlInjected.Token(Token = "0x6002CEC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _interactionSetupList;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066C")]
		public PlayerTaskDefinition InteractWithDisplayTask
		{
			[Cpp2IlInjected.Token(Token = "0x6002CED")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _interactWithDisplayTask;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066D")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6002CEE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CItemScript_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CEF")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CItemScript_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066E")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF0")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CF1")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700066F")]
		private ColliderRedirection ColliderRedirection
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF2")]
			[Cpp2IlInjected.Address(RVA = "0x16353F0", Offset = "0x1633DF0", VA = "0x1816353F0")]
			get
			{
				//Discarded unreachable code: IL_0043
				//IL_0010: Expected O, but got I4
				ColliderRedirection colliderRedirection = this.colliderRedirection;
				int num = 0;
				if (colliderRedirection == (UnityEngine.Object)num)
				{
					ColliderRedirection colliderRedirection2 = (this.colliderRedirection = base.gameObject.GetOrAddComponent<ColliderRedirection>());
					base.gameObject.GetComponent<InteractionComponentCache>()?.RecacheComponents();
				}
				return this.colliderRedirection;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000670")]
		public Character CurrentOwner
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF3")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentOwner_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CF4")]
			[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
			[CompilerGenerated]
			private set
			{
				_003CCurrentOwner_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000671")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4003518")]
		public Item CurrentBuildingItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF5")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002CF6")]
			[Cpp2IlInjected.Address(RVA = "0x7252D0", Offset = "0x723CD0", VA = "0x1807252D0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000672")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x54"), Cpp2IlInjected.Token(Token = "0x4003519")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF7")]
			[Cpp2IlInjected.Address(RVA = "0x63F830", Offset = "0x63E230", VA = "0x18063F830")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002CF8")]
			[Cpp2IlInjected.Address(RVA = "0x63FC10", Offset = "0x63E610", VA = "0x18063FC10")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000673")]
		public IAvatarInfoProvider AvatarInfoProvider
		{
			[Cpp2IlInjected.Token(Token = "0x6002CF9")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CAvatarInfoProvider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CFA")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CAvatarInfoProvider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000674")]
		public SlotInfo[] SlotList
		{
			[Cpp2IlInjected.Token(Token = "0x6002CFB")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return _slotList;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000675")]
		public bool HasAnySlotUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6002CFC")]
			[Cpp2IlInjected.Address(RVA = "0x1635610", Offset = "0x1634010", VA = "0x181635610")]
			get
			{
				SlotInfo[] slotList = _slotList;
				Func<SlotInfo, bool> _003C_003E9__41_ = _003C_003Ec._003C_003E9__41_0;
				if (_003C_003E9__41_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SlotInfo x) => x != null);
				}
				return ((IEnumerable<>)(object)slotList).Any<SlotInfo>((Func<, >)(object)_003C_003E9__41_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000676")]
		public bool HasAnySlotItemAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6002CFD")]
			[Cpp2IlInjected.Address(RVA = "0x16354E0", Offset = "0x1633EE0", VA = "0x1816354E0")]
			get
			{
				SlotInfo[] slotList = _slotList;
				Func<SlotInfo, bool> _003C_003E9__43_ = _003C_003Ec._003C_003E9__43_0;
				if (_003C_003E9__43_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(SlotInfo x)
					{
						//IL_0014: Expected O, but got I4
						if (x != null)
						{
							GameObject gO = x.GO;
							int num = 0;
							if (gO != (UnityEngine.Object)num)
							{
								DisplaySlotData data = x.Data;
								if ((object)data != null)
								{
									DisplaySlot _003CDisplaySlot_003Ek__BackingField = data.DisplaySlot;
									if (_003CDisplaySlot_003Ek__BackingField != null)
									{
										return _003CDisplaySlot_003Ek__BackingField.isAvailable_;
									}
								}
							}
						}
						int num2 = 0;
						/*Error: Unexpected end of block*/;
					};
				}
				return ((IEnumerable<>)(object)slotList).Any<SlotInfo>((Func<, >)(object)_003C_003E9__43_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000677")]
		public PlayerTaskCollider TaskCollider
		{
			[Cpp2IlInjected.Token(Token = "0x6002CFE")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			[CompilerGenerated]
			get
			{
				return _003CTaskCollider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002CFF")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			[CompilerGenerated]
			private set
			{
				_003CTaskCollider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000678")]
		public SlotInfo CurrentInteractibleSlot
		{
			[Cpp2IlInjected.Token(Token = "0x6002D00")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			get
			{
				return currentInteractibleSlot;
			}
			[Cpp2IlInjected.Token(Token = "0x6002D01")]
			[Cpp2IlInjected.Address(RVA = "0x1635740", Offset = "0x1634140", VA = "0x181635740")]
			set
			{
				if (currentInteractibleSlot != value)
				{
					currentInteractibleSlot = value;
					SlotInfo slotInfo = currentInteractibleSlot;
					if (slotInfo != null)
					{
						_unavailableItemPrefab = (GameObject)(object)value;
						throw new NullReferenceException();
					}
					TaskCollider.Destination = (Transform)(object)slotInfo;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D02")]
		[Cpp2IlInjected.Address(RVA = "0x1633C90", Offset = "0x1632690", VA = "0x181633C90", Slot = "4")]
		public Task<IPlayerTaskData> GetPlayerTaskData(PlayerTaskDefinition playerTaskDefinition, CancellationToken ct)
		{
			//Discarded unreachable code: IL_002e
			//IL_0014: Expected O, but got I4
			//IL_0014: Expected O, but got I4
			//IL_002d: Expected O, but got I4
			if (currentInteractibleSlot != null)
			{
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2 && HasAnySlotItemAvailable)
			{
				SlotInfo slotInfo = currentInteractibleSlot;
			}
			return (Task<IPlayerTaskData>)(object)Task.FromResult((IPlayerTaskData)0);
		}

		[Cpp2IlInjected.Token(Token = "0x6002D03")]
		[Cpp2IlInjected.Address(RVA = "0x1634A60", Offset = "0x1633460", VA = "0x181634A60", Slot = "5")]
		public void OnActivation(GameObject previousInteractible)
		{
			//Discarded unreachable code: IL_0048
			//IL_0022: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			IAvatarInfoProvider avatarInfoProvider = AvatarInfoProvider;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			SlotInfo slotInfo = default(SlotInfo);
			if (slotInfo != null)
			{
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				ColliderRedirection colliderRedirection = ColliderRedirection;
				GameObject gameObject = (colliderRedirection.Redirection = slotInfo.GO);
				CurrentInteractibleSlot = slotInfo;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D04")]
		[Cpp2IlInjected.Address(RVA = "0x1634CC0", Offset = "0x16336C0", VA = "0x181634CC0", Slot = "6")]
		public void OnDeactivation(GameObject nextInteractible)
		{
			//Discarded unreachable code: IL_004c
			//IL_0009: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			//IL_004b: Expected O, but got I4
			int num = 0;
			if (!(nextInteractible == (UnityEngine.Object)num))
			{
				GameObject gameObject = base.gameObject;
				Transform parent = nextInteractible.transform.parent;
				if ((object)parent != null)
				{
					GameObject gameObject2 = parent.gameObject;
				}
				int num2 = 0;
				if (!(gameObject != (UnityEngine.Object)num2))
				{
					return;
				}
			}
			ColliderRedirection colliderRedirection = ColliderRedirection;
			int num3 = 0;
			CurrentInteractibleSlot = (SlotInfo)num3;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D05")]
		[Cpp2IlInjected.Address(RVA = "0x16347F0", Offset = "0x16331F0", VA = "0x1816347F0")]
		public void OnActivationFromDisplaySlot(DisplaySlotData activatedSlotData, GameObject previousInteractible)
		{
			//IL_0016: Expected O, but got I4
			int num = 0;
			if (!(previousInteractible == (UnityEngine.Object)num) && !(base.gameObject != previousInteractible))
			{
				DisplaySlotData displaySlotData = activatedSlotData;
				GameObject gameObject = default(GameObject);
				if (!(gameObject != previousInteractible))
				{
					return;
				}
			}
			SlotInfo[] slotList = _slotList;
			Func<SlotInfo, bool> func = (Func<SlotInfo, bool>)(object)(Func<T, TResult>)delegate(SlotInfo x)
			{
				if (x != null)
				{
				}
				bool result = default(bool);
				return result;
			};
			SlotInfo slotInfo = Enumerable.FirstOrDefault<SlotInfo>((IEnumerable<>)(object)slotList, (Func<, >)(object)func);
			SlotInfo slotInfo2 = currentInteractibleSlot;
			if (slotInfo2 != null)
			{
				DisplaySlotData data = slotInfo.Data;
				DisplaySlotData data2 = slotInfo2.Data;
				if (!(data != data2))
				{
					return;
				}
			}
			if (currentInteractibleSlot != slotInfo)
			{
				currentInteractibleSlot = slotInfo;
				SlotInfo slotInfo3 = currentInteractibleSlot;
				PlayerTaskCollider playerTaskCollider = default(PlayerTaskCollider);
				if (slotInfo3 != null)
				{
					Transform transform = (playerTaskCollider.Destination = slotInfo3.Data.PositionSetup.AvatarPosition);
					throw new NullReferenceException();
				}
				playerTaskCollider = TaskCollider;
				playerTaskCollider.Destination = (Transform)(object)slotInfo3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D06")]
		[Cpp2IlInjected.Address(RVA = "0x1634B90", Offset = "0x1633590", VA = "0x181634B90")]
		public void OnDeactivationFromDisplaySlot(DisplaySlotData deactivatedSlotData, GameObject nextInteractible)
		{
			//Discarded unreachable code: IL_003b
			//IL_0009: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			int num = 0;
			if (nextInteractible == (UnityEngine.Object)num || (base.gameObject != nextInteractible && deactivatedSlotData.RootObject != nextInteractible))
			{
				ColliderRedirection colliderRedirection = ColliderRedirection;
				int num2 = 0;
				CurrentInteractibleSlot = (SlotInfo)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D07")]
		[Cpp2IlInjected.Address(RVA = "0x1634F60", Offset = "0x1633960", VA = "0x181634F60")]
		private void TryActivateInteractibleSlot(GameObject previousInteractible)
		{
			//Discarded unreachable code: IL_00b3
			//IL_0019: Expected O, but got I4
			//IL_004e: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			IAvatarInfoProvider avatarInfoProvider = AvatarInfoProvider;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = 0;
			SlotInfo slotInfo = default(SlotInfo);
			if (!(previousInteractible == (UnityEngine.Object)num))
			{
				GameObject gameObject = base.gameObject;
				Transform parent = previousInteractible.transform.parent;
				int num2 = 0;
				if ((object)parent != null)
				{
					GameObject gameObject2 = parent.gameObject;
				}
				if (!(gameObject != (UnityEngine.Object)num2))
				{
					if (slotInfo != null)
					{
					}
					int num3 = 0;
					if (!((UnityEngine.Object)num2 != (UnityEngine.Object)num3))
					{
						return;
					}
					SlotInfo slotInfo2 = currentInteractibleSlot;
					GameObject gO = slotInfo.GO;
					GameObject gO2 = default(GameObject);
					if (slotInfo2 != null)
					{
						gO2 = slotInfo2.GO;
					}
					if (!(gO != gO2))
					{
						return;
					}
				}
			}
			ColliderRedirection colliderRedirection = ColliderRedirection;
			GameObject gameObject3 = (colliderRedirection.Redirection = slotInfo.GO);
			CurrentInteractibleSlot = slotInfo;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D08")]
		[Cpp2IlInjected.Address(RVA = "0x1633250", Offset = "0x1631C50", VA = "0x181633250")]
		private void Awake()
		{
			//Discarded unreachable code: IL_007a
			//IL_001e: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			ItemScript itemScript = (ItemScript = GetComponent<ItemScript>());
			ItemScript itemScript2 = ItemScript;
			int num = 0;
			if (itemScript2 != (UnityEngine.Object)num)
			{
				ItemScript itemScript3 = ItemScript;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = itemScript3.Item;
				IItemData itemData = default(IItemData);
				ItemData = itemData;
			}
			PlayerTaskDefinition interactWithDisplayTask = _interactWithDisplayTask;
			int num2 = 0;
			if (interactWithDisplayTask == (UnityEngine.Object)num2)
			{
				string text = base.gameObject.name;
				Debug.LogError("Missing PlayerTaskDefinition in 'Display' Script for gameobject '" + text + "'. Interaction with items won't work properly.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D09")]
		[Cpp2IlInjected.Address(RVA = "0x1634F10", Offset = "0x1633910", VA = "0x181634F10", Slot = "7")]
		protected virtual void Start()
		{
			PlayerTaskCollider playerTaskCollider = (TaskCollider = GetComponent<PlayerTaskCollider>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D0A")]
		[Cpp2IlInjected.Address(RVA = "0x1634DE0", Offset = "0x16337E0", VA = "0x181634DE0", Slot = "8")]
		protected virtual void OnDestroy()
		{
			ClearSlots();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D0B")]
		[Cpp2IlInjected.Address(RVA = "0x16352C0", Offset = "0x1633CC0", VA = "0x1816352C0")]
		private void Update()
		{
			SlotInfo slotInfo = currentInteractibleSlot;
			if (slotInfo != null)
			{
				GameObject gO = slotInfo.GO;
				TryActivateInteractibleSlot(gO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D0C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "9")]
		internal virtual void Init()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002D0D")]
		[Cpp2IlInjected.Address(RVA = "0x16343A0", Offset = "0x1632DA0", VA = "0x1816343A0")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__63))]
		public Task Init(DisplayInfo displayInfo, Character owner, Item buildingItem, int index, IAvatarInfoProvider avatarInfoProvider)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D0E")]
		[Cpp2IlInjected.Address(RVA = "0x1633470", Offset = "0x1631E70", VA = "0x181633470")]
		protected void ClearSlots()
		{
			//Discarded unreachable code: IL_0072
			//IL_0031: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			SlotInfo[] slotList = _slotList;
			int num = 0;
			if (slotList.Length <= 0)
			{
				return;
			}
			SlotInfo[] slotList2 = _slotList;
			SlotInfo slotInfo = default(SlotInfo);
			if (slotInfo != null)
			{
				GameObject gO = slotInfo.GO;
				int num2 = 0;
				if (gO != (UnityEngine.Object)num2)
				{
					bool flag = Addressables.ReleaseInstance(slotInfo.GO);
				}
				GameObject unavailableGO = slotInfo.UnavailableGO;
				int num3 = 0;
				if (unavailableGO != (UnityEngine.Object)num3)
				{
					bool flag2 = Addressables.ReleaseInstance(slotInfo.UnavailableGO);
				}
				SlotInfo[] slotList3 = _slotList;
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D0F")]
		[Cpp2IlInjected.Address(RVA = "0x1633710", Offset = "0x1632110", VA = "0x181633710")]
		private InteractionSetup FindBestInteractionSetup(GameObject slotItemVisual)
		{
			//Discarded unreachable code: IL_0068, IL_006e, IL_0074, IL_007a
			int num = 0;
			List<InteractionSetup> interactionSetupList = _interactionSetupList;
			IEnumerable<InteractionSetup> enumerable;
			Transform transform = default(Transform);
			if (interactionSetupList != null)
			{
				InteractionSetup interactionSetup = Enumerable.First<InteractionSetup>((IEnumerable<>)interactionSetupList);
				enumerable = (IEnumerable<InteractionSetup>)Enumerable.Skip<InteractionSetup>((IEnumerable<>)_interactionSetupList, 1);
				int num2 = 0;
				if (enumerable != null)
				{
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_0054;
						}
						num++;
					}
					transform = slotItemVisual.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					goto IL_0054;
				}
				goto IL_005b;
			}
			goto IL_005f;
			IL_005f:
			int num4 = 0;
			throw new NullReferenceException();
			IL_0054:
			transform = (Transform)(object)((object)transform + (object)transform);
			goto IL_005b;
			IL_005b:
			if (enumerable == null)
			{
			}
			goto IL_005f;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D10")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract List<SlotTransform> GetSlotTransforms(DisplayInfo displayInfo);

		[Cpp2IlInjected.Token(Token = "0x6002D11")]
		[Cpp2IlInjected.Address(RVA = "0x1633EE0", Offset = "0x16328E0", VA = "0x181633EE0")]
		private Task InitSlots(DisplayInfo displayInfo, List<SlotTransform> slotTransforms)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002D12")]
		[Cpp2IlInjected.Address(RVA = "0x1633BC0", Offset = "0x16325C0", VA = "0x181633BC0")]
		private string GetItemPrefabAddress(IItemData item)
		{
			//Discarded unreachable code: IL_001f
			if (item == null)
			{
			}
			IAvatarInfoProvider avatarInfoProvider = AvatarInfoProvider;
			if ((object)typeof(ClothingItemData).TypeHandle != null)
			{
				return (string)typeof(ClothingItemData).TypeHandle;
			}
			return (string)typeof(ClothingItemData).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D13")]
		[Cpp2IlInjected.Address(RVA = "0x1633D90", Offset = "0x1632790", VA = "0x181633D90")]
		[AsyncStateMachine(typeof(_003CInitSlot_003Ed__69))]
		private Task InitSlot(DisplaySlot displaySlot, int slotIdx, SlotTransform slotItemTransform)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D14")]
		[Cpp2IlInjected.Address(RVA = "0x1634500", Offset = "0x1632F00", VA = "0x181634500")]
		[AsyncStateMachine(typeof(_003CInstantiateSlotGameObject_003Ed__70))]
		private Task<GameObject> InstantiateSlotGameObject(DisplaySlot displaySlot, IItemData item, SlotTransform slotItemTransform)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D15")]
		[Cpp2IlInjected.Address(RVA = "0x1634DF0", Offset = "0x16337F0", VA = "0x181634DF0")]
		[AsyncStateMachine(typeof(_003COnSlotItemBought_003Ed__71))]
		protected Task OnSlotItemBought(DisplaySlotData slotItemBought)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D16")]
		[Cpp2IlInjected.Address(RVA = "0x16351A0", Offset = "0x1633BA0", VA = "0x1816351A0", Slot = "11")]
		[AsyncStateMachine(typeof(_003CUpdateDisplaySlotAvailability_003Ed__72))]
		protected virtual Task UpdateDisplaySlotAvailability(DisplaySlotData slotVisual)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D17")]
		[Cpp2IlInjected.Address(RVA = "0x1634680", Offset = "0x1633080", VA = "0x181634680")]
		[AsyncStateMachine(typeof(_003CInstantiateUnavailableItemVisual_003Ed__73))]
		private Task<GameObject> InstantiateUnavailableItemVisual(Vector3 position, Quaternion rotation, Transform parent)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GameObject>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002D18")]
		[Cpp2IlInjected.Address(RVA = "0x16352E0", Offset = "0x1633CE0", VA = "0x1816352E0")]
		private void ValidateTaskCollider()
		{
			//Discarded unreachable code: IL_0028
			//IL_001d: Expected O, but got I4
			//IL_001d: Expected O, but got I4
			if (!HasAnySlotItemAvailable)
			{
				if ((object)TaskCollider != null)
				{
				}
				int num = 0;
				int num2 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
				{
					PlayerTaskCollider playerTaskCollider = TaskCollider;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D19")]
		[Cpp2IlInjected.Address(RVA = "0x1633640", Offset = "0x1632040", VA = "0x181633640")]
		public void DisableInteraction()
		{
			//Discarded unreachable code: IL_0062
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			PlayerTaskCollider playerTaskCollider = TaskCollider;
			int num = 0;
			bool flag = playerTaskCollider != (UnityEngine.Object)num;
			int num2 = 0;
			if (flag)
			{
				TaskCollider.TaskDefinition = (PlayerTaskDefinition)num2;
			}
			SlotInfo[] slotList = _slotList;
			int length = slotList.Length;
			if (num2 < length)
			{
				slotList[num2]?.Data?.DisableInteraction();
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D1A")]
		[Cpp2IlInjected.Address(RVA = "0x16339E0", Offset = "0x16323E0", VA = "0x1816339E0")]
		private SlotInfo GetClosestSlotFrom(Vector3 pos)
		{
			//IL_0068: Expected O, but got I4
			//IL_0068: Expected O, but got I4
			SlotInfo[] slotList = _slotList;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int length = slotList.Length;
			if (num4 < length)
			{
				SlotInfo slotInfo = slotList[num3];
				if (slotInfo != null && slotInfo.IsAvailable)
				{
					Transform transform = slotInfo.GO.transform;
					float z = pos.z;
					Vector3 vector = default(Vector3);
					float z2 = vector.z;
					if (num2 != 0)
					{
					}
					int num5 = 0;
					int num6 = 0;
					if ((UnityEngine.Object)num5 == (UnityEngine.Object)num6)
					{
					}
				}
				num3++;
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002D1B")]
		[Cpp2IlInjected.Address(RVA = "0x1635390", Offset = "0x1633D90", VA = "0x181635390")]
		protected Display()
		{
		}
	}
}
