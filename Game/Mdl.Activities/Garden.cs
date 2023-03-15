using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Navigation;
using Meta.Grids;
using ScreenEffect;
using UnityEngine;
using UnityEngine.Serialization;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B5D")]
	public class Garden : GridObjectStateUser, IHighlightRendererOverride, IPlayerTaskData, IPlayerTaskProvider, IPlayerTaskDataProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003F2B")]
		[SerializeField]
		private Transform _avatarTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003F2C")]
		[SerializeField]
		private PlayerTaskDefinition _plantSingleSlotTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003F2D")]
		[SerializeField]
		[FormerlySerializedAs("_harvestSingleSlotTask")]
		private PlayerTaskDefinition _harvestFruitTreeTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003F2E")]
		[SerializeField]
		private PlayerTaskDefinition _harvestVegetableTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003F2F")]
		[SerializeField]
		private bool _vegetableUseRendererOverride = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003F30")]
		private GardenItemData _gardenItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003F31")]
		private GardeningSlot[] gardeningSlots;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003F32")]
		private Renderer[] defaultRenderers;

		[Cpp2IlInjected.Token(Token = "0x1700071E")]
		public Transform AvatarTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6003488")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return _avatarTransform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700071F")]
		public GardenItemData Data
		{
			[Cpp2IlInjected.Token(Token = "0x6003489")]
			[Cpp2IlInjected.Address(RVA = "0x8C4EE0", Offset = "0x8C38E0", VA = "0x1808C4EE0")]
			get
			{
				//Discarded unreachable code: IL_0026
				GardenItemData gardenItemData = _gardenItemData;
				if (gardenItemData == null)
				{
					ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
					Item item = GetComponent<ItemScript>().Item;
					GardenItemData gardenItemData2 = default(GardenItemData);
					_gardenItemData = gardenItemData2;
				}
				return gardenItemData;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000720")]
		internal GardeningSlot SingleSlot
		{
			[Cpp2IlInjected.Token(Token = "0x600348A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5010", Offset = "0x8C3A10", VA = "0x1808C5010")]
			get
			{
				GardeningSlot[] array = gardeningSlots;
				if (array.Length == 1)
				{
					return array[0];
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000721")]
		public int UpgradeLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600348B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5040", Offset = "0x8C3A40", VA = "0x1808C5040")]
			get
			{
				//Discarded unreachable code: IL_003a
				GridObjectScript gridObjectScript = base.GridObjectScript;
				if ((object)gridObjectScript != null)
				{
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						GridState state_ = _003CGridObject_003Ek__BackingField.state_;
						if (state_ != null)
						{
							IGridStateData stateData = state_.StateData;
						}
					}
				}
				int num = 0;
				if (num != 0 && num != 0)
				{
					return num;
				}
				return -1;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600348C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E50", Offset = "0x8C3850", VA = "0x1808C4E50", Slot = "5")]
		protected override void Start()
		{
			Renderer[] array = (defaultRenderers = GetComponentsInChildren<Renderer>());
			base.Start();
			GardeningSlot[] array2 = (gardeningSlots = GetComponentsInChildren<GardeningSlot>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600348D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600348E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4B00", Offset = "0x8C3500", VA = "0x1808C4B00")]
		public GardeningSlot GetGardeningSlot(int slotIndex)
		{
			//Discarded unreachable code: IL_0029
			GardeningSlot[] array = gardeningSlots;
			Func<GardeningSlot, bool> func = (Func<GardeningSlot, bool>)(object)(Func<T, TResult>)delegate(GardeningSlot x)
			{
				//Discarded unreachable code: IL_0011
				int num = slotIndex;
				return x._slotIndex == num;
			};
			return Enumerable.FirstOrDefault<GardeningSlot>((IEnumerable<>)(object)array, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x600348F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C60", Offset = "0x8C3660", VA = "0x1808C4C60", Slot = "8")]
		public void GetRenderers(List<Renderer> renderers)
		{
			//Discarded unreachable code: IL_004f
			GardenItemData gardenItemData = _gardenItemData;
			if (gardenItemData == null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = GetComponent<ItemScript>().Item;
				GardenItemData gardenItemData2 = default(GardenItemData);
				_gardenItemData = gardenItemData2;
				GardenItemData gardenItemData3 = _gardenItemData;
			}
			if (gardenItemData.cropType_ == CropType.Vegetable && _vegetableUseRendererOverride)
			{
				Renderer[] array = defaultRenderers;
				((List<T>)(object)renderers).AddRange((IEnumerable<>)(object)array);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003490")]
		[Cpp2IlInjected.Address(RVA = "0x8C4DE0", Offset = "0x8C37E0", VA = "0x1808C4DE0", Slot = "9")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__20))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__20(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003491")]
		[Cpp2IlInjected.Address(RVA = "0x8C4BE0", Offset = "0x8C35E0", VA = "0x1808C4BE0", Slot = "10")]
		public Task<IPlayerTaskData> GetPlayerTaskData(PlayerTaskDefinition playerTaskDefinition, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0015
			//IL_0014: Expected O, but got I4
			if (gardeningSlots.Length == 1)
			{
			}
			return (Task<IPlayerTaskData>)(object)Task.FromResult((IPlayerTaskData)0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003492")]
		[Cpp2IlInjected.Address(RVA = "0x8C4ED0", Offset = "0x8C38D0", VA = "0x1808C4ED0")]
		public Garden()
		{
		}
	}
}
