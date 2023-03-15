using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using NodeCanvas.DialogueTrees;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x20009EB")]
	public class UpgradeBuildingData : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x20009EC")]
		public delegate void BuildingUpgrade();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40036B8")]
		[SerializeField]
		[ItemID]
		protected int _employeeCharacter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40036B9")]
		[SerializeField]
		protected Transform _employeePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40036BA")]
		public bool IsCastle;

		[Cpp2IlInjected.Token(Token = "0x170006A1")]
		public Item EmployeeCharacter
		{
			[Cpp2IlInjected.Token(Token = "0x6002E6D")]
			[Cpp2IlInjected.Address(RVA = "0xD3DB80", Offset = "0xD3C580", VA = "0x180D3DB80")]
			get
			{
				long num = Convert.ToInt64((uint)_employeeCharacter);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006A2")]
		public Vector3 EmployeePosition
		{
			[Cpp2IlInjected.Token(Token = "0x6002E6E")]
			[Cpp2IlInjected.Address(RVA = "0xD3DBE0", Offset = "0xD3C5E0", VA = "0x180D3DBE0")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000072")]
		public event BuildingUpgrade OnBuildingUpgrade
		{
			[Cpp2IlInjected.Token(Token = "0x6002E6B")]
			[Cpp2IlInjected.Address(RVA = "0xD3DAE0", Offset = "0xD3C4E0", VA = "0x180D3DAE0")]
			[CompilerGenerated]
			add
			{
				BuildingUpgrade onBuildingUpgrade = this.OnBuildingUpgrade;
				Delegate @delegate = Delegate.Combine(onBuildingUpgrade, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBuildingUpgrade)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002E6C")]
			[Cpp2IlInjected.Address(RVA = "0xD3DC20", Offset = "0xD3C620", VA = "0x180D3DC20")]
			[CompilerGenerated]
			remove
			{
				BuildingUpgrade onBuildingUpgrade = this.OnBuildingUpgrade;
				Delegate @delegate = Delegate.Remove(onBuildingUpgrade, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBuildingUpgrade)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002E6F")]
		[Cpp2IlInjected.Address(RVA = "0xD3D9D0", Offset = "0xD3C3D0", VA = "0x180D3D9D0")]
		public bool IsLocked()
		{
			//Discarded unreachable code: IL_0026
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			Item item = GetItemScript().Item;
			bool flag = default(bool);
			return !flag;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E70")]
		[Cpp2IlInjected.Address(RVA = "0xD3D3E0", Offset = "0xD3BDE0", VA = "0x180D3D3E0")]
		public ItemScript GetItemScript()
		{
			//IL_0010: Expected O, but got I4
			ItemScript component = GetComponent<ItemScript>();
			int num = 0;
			if (component == (UnityEngine.Object)num)
			{
				return GetComponentInParent<ItemScript>();
			}
			return component;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E71")]
		[Cpp2IlInjected.Address(RVA = "0xD3D7B0", Offset = "0xD3C1B0", VA = "0x180D3D7B0")]
		public IBuildingUnlockable GetUnlockData()
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = GetItemScript().Item;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E72")]
		[Cpp2IlInjected.Address(RVA = "0xD3D8B0", Offset = "0xD3C2B0", VA = "0x180D3D8B0")]
		private RepeatedField<UpgradeData> GetUpgradeData()
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = GetItemScript().Item;
			IItemData itemData = default(IItemData);
			if (itemData != null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E73")]
		[Cpp2IlInjected.Address(RVA = "0xD3D490", Offset = "0xD3BE90", VA = "0x180D3D490")]
		public UpgradeData GetNextLevelUpgradeData(int level)
		{
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = GetItemScript().Item;
			IItemData itemData = default(IItemData);
			if (itemData != null && itemData != null)
			{
				int num = level;
				if (_003C_003Ec._003C_003E9__15_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((UpgradeData x) => x.level_);
				}
				int num2 = default(int);
				if (num < num2)
				{
					Predicate<UpgradeData> predicate = (Predicate<UpgradeData>)(object)(Predicate<T>)delegate(UpgradeData x)
					{
						//Discarded unreachable code: IL_0015
						int num3 = level;
						num3++;
						return x.level_ == num3;
					};
					UpgradeData result = default(UpgradeData);
					return result;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E74")]
		[Cpp2IlInjected.Address(RVA = "0xD3D290", Offset = "0xD3BC90", VA = "0x180D3D290")]
		[AsyncStateMachine(typeof(_003CGetDialogueForUpgrade_003Ed__16))]
		public Task<DialogueTree> GetDialogueForUpgrade(int level)
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<DialogueTree>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002E75")]
		[Cpp2IlInjected.Address(RVA = "0x8E4E10", Offset = "0x8E3810", VA = "0x1808E4E10")]
		public void BuildingUpgraded()
		{
			this.OnBuildingUpgrade?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002E76")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public UpgradeBuildingData()
		{
		}
	}
}
