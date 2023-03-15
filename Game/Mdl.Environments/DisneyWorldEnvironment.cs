using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Util;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Grid;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000635")]
	internal class DisneyWorldEnvironment : Environment
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000636")]
		public class SpawnableCharacter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400252D")]
			[ItemID]
			[SerializeField]
			private int _character;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400252E")]
			public Transform Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400252F")]
			[SerializeField]
			[ItemID]
			private int _conditions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4002530")]
			public bool RefreshWhenConditionChange;

			[Cpp2IlInjected.Token(Token = "0x170003E4")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400252C")]
			public int Index
			{
				[Cpp2IlInjected.Token(Token = "0x6001BA1")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6001BA2")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170003E5")]
			public Item Character
			{
				[Cpp2IlInjected.Token(Token = "0x6001BA3")]
				[Cpp2IlInjected.Address(RVA = "0x137F260", Offset = "0x137DC60", VA = "0x18137F260")]
				get
				{
					long num = Convert.ToInt64((uint)_character);
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170003E6")]
			public Item ConditionsItem
			{
				[Cpp2IlInjected.Token(Token = "0x6001BA4")]
				[Cpp2IlInjected.Address(RVA = "0x137F2C0", Offset = "0x137DCC0", VA = "0x18137F2C0")]
				get
				{
					long num = Convert.ToInt64((uint)_conditions);
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001BA5")]
			[Cpp2IlInjected.Address(RVA = "0x137EF70", Offset = "0x137D970", VA = "0x18137EF70")]
			public bool AreConditionsTrue(IProfile profile, ITransactionContext context)
			{
				int conditions = _conditions;
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001BA6")]
			[Cpp2IlInjected.Address(RVA = "0x137F030", Offset = "0x137DA30", VA = "0x18137F030")]
			public bool AreConditionsTrue()
			{
				//Discarded unreachable code: IL_0024
				Client metaClient = SystemRoot.Instance.MetaClient;
				Client metaClient2 = SystemRoot.Instance.MetaClient;
				long num = Convert.ToInt64((uint)_conditions);
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001BA7")]
			[Cpp2IlInjected.Address(RVA = "0x137F210", Offset = "0x137DC10", VA = "0x18137F210")]
			private static bool StoryCharactersOnly(Item item)
			{
				int itemID = item.ItemID;
				bool result = default(bool);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6001BA8")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SpawnableCharacter()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002527")]
		public List<SpawnableCharacter> SpawnableCharacters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002529")]
		private GridScript[] gridScriptsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400252A")]
		private Dictionary<Item, int> SpawnedInfo = (Dictionary<Item, int>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400252B")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x170003E3")]
		public override IEnumerable<GridScript> GridScriptsList
		{
			[Cpp2IlInjected.Token(Token = "0x6001B92")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0", Slot = "4")]
			get
			{
				GridScript[] array = gridScriptsList;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003D")]
		public event EventHandler FirstVisitEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001B90")]
			[Cpp2IlInjected.Address(RVA = "0x1632AF0", Offset = "0x16314F0", VA = "0x181632AF0")]
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
			[Cpp2IlInjected.Token(Token = "0x6001B91")]
			[Cpp2IlInjected.Address(RVA = "0x1632B90", Offset = "0x1631590", VA = "0x181632B90")]
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

		[Cpp2IlInjected.Token(Token = "0x6001B93")]
		[Cpp2IlInjected.Address(RVA = "0x1631A50", Offset = "0x1630450", VA = "0x181631A50")]
		private void Awake()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001B94")]
		[Cpp2IlInjected.Address(RVA = "0x16321B0", Offset = "0x1630BB0", VA = "0x1816321B0", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__9))]
		protected override Task Init(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B95")]
		[Cpp2IlInjected.Address(RVA = "0x1632000", Offset = "0x1630A00", VA = "0x181632000", Slot = "5")]
		[AsyncStateMachine(typeof(_003CEnterEnvironment_003Ed__11))]
		internal override Task EnterEnvironment(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B96")]
		[Cpp2IlInjected.Address(RVA = "0x1631FC0", Offset = "0x16309C0", VA = "0x181631FC0")]
		public void OnDestroy()
		{
			while (true)
			{
				if ((object)this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B97")]
		[Cpp2IlInjected.Address(RVA = "0x1631B00", Offset = "0x1630500", VA = "0x181631B00")]
		private bool CanSpawnInDisneyWorld(Item characterItem)
		{
			//Discarded unreachable code: IL_001d
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			bool flag = default(bool);
			if (!flag)
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B98")]
		[Cpp2IlInjected.Address(RVA = "0x1632680", Offset = "0x1631080", VA = "0x181632680", Slot = "9")]
		public override bool ShouldSpawnCharacter(Item characterItem)
		{
			//Discarded unreachable code: IL_0056
			//IL_0014: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			ProfileWorld world_ = SystemRoot.Instance.MetaClient.profile.world_;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && !flag2)
			{
				return flag2;
			}
			List<SpawnableCharacter> spawnableCharacters = SpawnableCharacters;
			Func<SpawnableCharacter, bool> cpp2il__autoParamName__idx_ = (Func<SpawnableCharacter, bool>)(object)(Func<T, TResult>)delegate(SpawnableCharacter x)
			{
				//Discarded unreachable code: IL_000d
				//IL_000d: Expected I4, but got O
				int character = x._character;
				return (byte)(int)typeof(Item).TypeHandle != 0;
			};
			return ((IEnumerable<>)spawnableCharacters).Any<SpawnableCharacter>((Func<, >)(object)cpp2il__autoParamName__idx_);
		}

		[Cpp2IlInjected.Token(Token = "0x6001B99")]
		[Cpp2IlInjected.Address(RVA = "0x1632870", Offset = "0x1631270", VA = "0x181632870", Slot = "10")]
		public override void SpawnCharacter(Mdl.Characters.Character character)
		{
			//Discarded unreachable code: IL_004a, IL_0064
			Mdl.Characters.Character character2 = character;
			base.SpawnCharacter(character);
			List<SpawnableCharacter> spawnableCharacters = SpawnableCharacters;
			Predicate<SpawnableCharacter> predicate = (Predicate<SpawnableCharacter>)(object)(Predicate<T>)delegate(SpawnableCharacter x)
			{
				//Discarded unreachable code: IL_001c
				int character4 = x._character;
				if ((object)character2.Item == null)
				{
				}
				return x.AreConditionsTrue();
			};
			SpawnableCharacter spawnableCharacter = (SpawnableCharacter)((List<T>)(object)spawnableCharacters).Find((Predicate<>)(object)predicate);
			if (spawnableCharacter != null)
			{
				Dictionary<Item, int> spawnedInfo = SpawnedInfo;
				Item character3 = spawnableCharacter.Character;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B9A")]
		[Cpp2IlInjected.Address(RVA = "0x1632180", Offset = "0x1630B80", VA = "0x181632180", Slot = "12")]
		public override GridScript GetCurrentGrid(Vector3 position, out bool voidGrid)
		{
			float z = position.z;
			GridScript[] array = gridScriptsList;
			GridScript result = default(GridScript);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B9B")]
		[Cpp2IlInjected.Address(RVA = "0x1632330", Offset = "0x1630D30", VA = "0x181632330")]
		private void OnConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_009d, IL_00a3, IL_00a9, IL_00af, IL_00b5
			//IL_0029: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			Mdl.Characters.Character character3 = default(Mdl.Characters.Character);
			while (true)
			{
				int num = 0;
				List<Item> list = (List<Item>)(object)Enumerable.ToList<Item>((IEnumerable<>)(object)((Dictionary<TKey, TValue>)(object)SpawnedInfo).get_Keys());
				if (flag)
				{
					Item characterItem = (Item)0;
					List<SpawnableCharacter> spawnableCharacters = SpawnableCharacters;
					Predicate<SpawnableCharacter> predicate = (Predicate<SpawnableCharacter>)(object)(Predicate<T>)delegate(SpawnableCharacter x)
					{
						//Discarded unreachable code: IL_001c
						//IL_0015: Expected I4, but got O
						int character4 = x._character;
						return ((object)typeof(Item).TypeHandle == null) ? ((byte)(int)typeof(Item).TypeHandle != 0) : x.AreConditionsTrue();
					};
					SpawnableCharacter spawnableCharacter = (SpawnableCharacter)((List<T>)(object)spawnableCharacters).Find((Predicate<>)(object)predicate);
					while (spawnableCharacter == null)
					{
					}
					while (!spawnableCharacter.RefreshWhenConditionChange)
					{
					}
					Dictionary<Item, int> spawnedInfo = SpawnedInfo;
					Item character = spawnableCharacter.Character;
					while (!flag2)
					{
					}
					int _003CIndex_003Ek__BackingField = spawnableCharacter.Index;
					Item character2 = spawnableCharacter.Character;
					int num2 = 0;
					if (character3 != (UnityEngine.Object)num2)
					{
						SpawnCharacter(character3);
						break;
					}
					continue;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B9C")]
		[Cpp2IlInjected.Address(RVA = "0x1631C10", Offset = "0x1630610", VA = "0x181631C10")]
		private void CreateEventHandler()
		{
			//Discarded unreachable code: IL_00ac
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			List<SpawnableCharacter> spawnableCharacters = SpawnableCharacters;
			Func<SpawnableCharacter, bool> cpp2il__autoParamName__idx_ = default(Func<SpawnableCharacter, bool>);
			if (_003C_003Ec._003C_003E9__19_0 == null)
			{
				cpp2il__autoParamName__idx_ = (Func<SpawnableCharacter, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((SpawnableCharacter x) => x.RefreshWhenConditionChange));
			}
			if (!((IEnumerable<>)spawnableCharacters).Any<SpawnableCharacter>((Func<, >)(object)cpp2il__autoParamName__idx_))
			{
				return;
			}
			List<SpawnableCharacter> spawnableCharacters2 = SpawnableCharacters;
			Func<SpawnableCharacter, Item> func = default(Func<SpawnableCharacter, Item>);
			if (_003C_003Ec._003C_003E9__19_1 == null)
			{
				func = (Func<SpawnableCharacter, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(SpawnableCharacter x)
				{
					//Discarded unreachable code: IL_000d
					int conditions = x._conditions;
					return (Item)typeof(Item).TypeHandle;
				});
			}
			ConditionListener mask = ConditionItemData.GetMask(Enumerable.Select<SpawnableCharacter, Item>((IEnumerable<>)spawnableCharacters2, (Func<, >)(object)func));
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B9D")]
		[Cpp2IlInjected.Address(RVA = "0x1631FC0", Offset = "0x16309C0", VA = "0x181631FC0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001B9E")]
		[Cpp2IlInjected.Address(RVA = "0x1632A70", Offset = "0x1631470", VA = "0x181632A70")]
		public DisneyWorldEnvironment()
		{
		}
	}
}
