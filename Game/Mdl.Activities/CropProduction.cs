using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.WellKnownTypes;
using Mdl.Environments;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B57")]
	public class CropProduction : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003F10")]
		public GameObject ReadyVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003F11")]
		public float MaxSecondsBetweenScaleAnimation = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003F12")]
		public BoingScaleEffectData ReadyScaleAnimationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003F13")]
		public GameObject harvestVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003F15")]
		private GardenData.Types.GardeningSlot gardeningSlot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003F16")]
		private bool inVillage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003F17")]
		private Coroutine scaleAnimationCoroutine;

		[Cpp2IlInjected.Token(Token = "0x17000718")]
		public Item ProducedItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003466")]
			[Cpp2IlInjected.Address(RVA = "0x1105990", Offset = "0x1104390", VA = "0x181105990")]
			get
			{
				//Discarded unreachable code: IL_0056
				GardenData.Types.GardeningSlot gardeningSlot = this.gardeningSlot;
				if (gardeningSlot != null && gardeningSlot.Harvest != null && this.gardeningSlot.Harvest.numberOfProductionLeft_ != 0)
				{
					Item plantedSeedItem = this.gardeningSlot.PlantedSeedItem;
					SeedItemData seedItemData = default(SeedItemData);
					if (seedItemData.producesItem_)
					{
						Item producedItem = seedItemData.ProducedItem;
						bool flag = default(bool);
						if (flag)
						{
							return seedItemData.ProducedItem;
						}
					}
				}
				return Item.Invalid;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000719")]
		public bool IsProductionReady
		{
			[Cpp2IlInjected.Token(Token = "0x6003467")]
			[Cpp2IlInjected.Address(RVA = "0x1105750", Offset = "0x1104150", VA = "0x181105750")]
			get
			{
				//Discarded unreachable code: IL_0067
				//IL_004a: Expected O, but got I4
				TreeAndBushData harvest = gardeningSlot.Harvest;
				ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
				Client metaClient = SystemRoot.Instance.MetaClient;
				bool flag = inVillage;
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = metaClient.TransactionContext;
				int num = 0;
				DateTime endOfGrowthTime = harvest.GetEndOfGrowthTime((SeedItemData)num, world_, _003CTransactionContext_003Ek__BackingField, flag);
				DateTime serverTime = SystemRoot.Instance.MetaClient.ServerTime;
				return endOfGrowthTime <= serverTime;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000093")]
		public event EventHandler ProductionReadyEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6003468")]
			[Cpp2IlInjected.Address(RVA = "0x11056B0", Offset = "0x11040B0", VA = "0x1811056B0")]
			[CompilerGenerated]
			add
			{
				EventHandler productionReadyEvent = this.ProductionReadyEvent;
				Delegate @delegate = Delegate.Combine(productionReadyEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != productionReadyEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003469")]
			[Cpp2IlInjected.Address(RVA = "0x1105B30", Offset = "0x1104530", VA = "0x181105B30")]
			[CompilerGenerated]
			remove
			{
				EventHandler productionReadyEvent = this.ProductionReadyEvent;
				Delegate @delegate = Delegate.Remove(productionReadyEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != productionReadyEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600346A")]
		[Cpp2IlInjected.Address(RVA = "0x1104EF0", Offset = "0x11038F0", VA = "0x181104EF0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0062
			//IL_0021: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			int handle = base.gameObject.scene.m_Handle;
			GameObject gameObject = default(GameObject);
			VillageEnvironment component = gameObject.GetComponent<VillageEnvironment>();
			int num = 0;
			bool flag = component != (UnityEngine.Object)num;
			GameObject readyVisual = ReadyVisual;
			int num2 = 0;
			inVillage = flag;
			if (readyVisual != (UnityEngine.Object)num2 && (long)gardeningSlot == 0)
			{
				GameObject readyVisual2 = ReadyVisual;
				int active = 0;
				readyVisual2.SetActive((byte)active != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600346B")]
		[Cpp2IlInjected.Address(RVA = "0x1104A00", Offset = "0x1103400", VA = "0x181104A00")]
		public void Init(GardenData.Types.GardeningSlot gardeningSlot, CancellationToken ct)
		{
			//IL_0079: Expected O, but got I4
			this.gardeningSlot = gardeningSlot;
			if (gardeningSlot.Harvest != null && gardeningSlot.Harvest.numberOfProductionLeft_ != 0)
			{
				TreeAndBushData harvest = gardeningSlot.Harvest;
				Client client = default(Client);
				Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = client.TransactionContext;
				if (!harvest.IsDead(_003CTransactionContext_003Ek__BackingField))
				{
					TreeAndBushData harvest2 = gardeningSlot.Harvest;
					Client client2 = default(Client);
					ProfileWorld world_ = client2.profile.world_;
					bool flag = inVillage;
					int num = 0;
					Client client3 = default(Client);
					Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField2 = client3.TransactionContext;
					int num2 = 0;
					DateTime endOfGrowthTime = harvest2.GetEndOfGrowthTime((SeedItemData)num2, world_, _003CTransactionContext_003Ek__BackingField2, flag);
					Client client4 = default(Client);
					DateTime serverTime = client4.ServerTime;
					bool ready = endOfGrowthTime <= serverTime;
					UpdateVisual(ready);
					Timestamp endOfLife_ = gardeningSlot.Harvest.endOfLife_;
					if (endOfLife_ != null)
					{
						DateTime dateTime = endOfLife_.ToDateTime();
					}
					DateTime maxValue = DateTime.MaxValue;
					bool flag2 = endOfGrowthTime < maxValue;
					DateTime maxValue2 = DateTime.MaxValue;
					if (endOfGrowthTime < maxValue2)
					{
						int num3 = 0;
						Task asyncTask = default(Task);
						asyncTask.FireAndForgetTask();
					}
					return;
				}
			}
			int ready2 = 0;
			UpdateVisual((byte)ready2 != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600346C")]
		[Cpp2IlInjected.Address(RVA = "0x1105560", Offset = "0x1103F60", VA = "0x181105560")]
		[AsyncStateMachine(typeof(_003CWaitForNextEvent_003Ed__16))]
		private Task WaitForNextEvent(DateTime nextEventTimestamp, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600346D")]
		[Cpp2IlInjected.Address(RVA = "0x1105000", Offset = "0x1103A00", VA = "0x181105000")]
		private void UpdateVisual(bool ready)
		{
			//IL_0010: Expected O, but got I4
			//IL_0126: Expected O, but got I4
			GameObject readyVisual = ReadyVisual;
			int num = 0;
			if (readyVisual != (UnityEngine.Object)num)
			{
				ReadyVisual.SetActive(ready);
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item producedItem = ProducedItem;
			CropItemData cropItemData = default(CropItemData);
			if (cropItemData != null && cropItemData.cropType_ != CropType.Vegetable)
			{
				return;
			}
			if (!ready)
			{
				if ((long)scaleAnimationCoroutine == 0)
				{
					return;
				}
				MeshRenderer[] componentsInChildren = GetComponentsInChildren<MeshRenderer>();
				Func<MeshRenderer, IEnumerable<Material>> func = default(Func<MeshRenderer, IEnumerable<Material>>);
				if (_003C_003Ec._003C_003E9__17_1 == null)
				{
					func = (Func<MeshRenderer, IEnumerable<Material>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MeshRenderer x)
					{
						Material[] materialArray2 = ((Renderer)x).GetMaterialArray();
						throw new NullReferenceException();
					});
				}
				Material[] array = Enumerable.SelectMany<MeshRenderer, Material>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func).ToArray<Material>();
				int num2 = 0;
				int length = array.Length;
				if (num2 < length)
				{
					array[num2].DisableKeyword("_HAS_BOING_EFFECT_ON");
					num2++;
					int num3 = 0;
				}
				return;
			}
			Func<MeshRenderer, IEnumerable<Material>> func2 = default(Func<MeshRenderer, IEnumerable<Material>>);
			if (_003C_003Ec._003C_003E9__17_0 == null)
			{
				func2 = (Func<MeshRenderer, IEnumerable<Material>>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(MeshRenderer x)
				{
					Material[] materialArray = ((Renderer)x).GetMaterialArray();
					throw new NullReferenceException();
				});
			}
			MeshRenderer[] array2 = default(MeshRenderer[]);
			Material[] array3 = Enumerable.SelectMany<MeshRenderer, Material>((IEnumerable<>)(object)array2, (Func<, >)(object)func2).ToArray<Material>();
			int num4 = 0;
			int length2 = array3.Length;
			while (num4 >= length2)
			{
			}
			array3[num4].EnableKeyword("_HAS_BOING_EFFECT_ON");
			num4++;
			int _003C_003E1__state = default(int);
			_003CReadyScaleAnimation_003Ed__18 _003CReadyScaleAnimation_003Ed__ = new _003CReadyScaleAnimation_003Ed__18(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CReadyScaleAnimation_003Ed__._003C_003E4__this = (CropProduction)num4;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600346E")]
		[Cpp2IlInjected.Address(RVA = "0x1104E80", Offset = "0x1103880", VA = "0x181104E80")]
		[IteratorStateMachine(typeof(_003CReadyScaleAnimation_003Ed__18))]
		private IEnumerator ReadyScaleAnimation()
		{
			int _003C_003E1__state = default(int);
			_003CReadyScaleAnimation_003Ed__18 _003CReadyScaleAnimation_003Ed__ = new _003CReadyScaleAnimation_003Ed__18(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CReadyScaleAnimation_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600346F")]
		[Cpp2IlInjected.Address(RVA = "0x11056A0", Offset = "0x11040A0", VA = "0x1811056A0")]
		public CropProduction()
		{
		}
	}
}
