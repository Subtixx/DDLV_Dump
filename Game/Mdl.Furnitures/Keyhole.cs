using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Keyholes;
using Definitions.Util;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Streaming;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using Meta.Online;
using Unity.Services.Core.Internal;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Furnitures
{
	[Cpp2IlInjected.Token(Token = "0x2000563")]
	public class Keyhole : GridObjectStateUser, IPlayerTaskData, IDefaultGridStateProvider, IPlayerTaskProvider, IStreamableAssetRefToLoadProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400216C")]
		[SerializeField]
		private bool IsNotIntegratedKeyhole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400216D")]
		[SerializeField]
		private PlayerTaskDefinition _openKeyholeTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400216E")]
		public AssetReference menuToOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400216F")]
		public GameObject[] DisplayItemsSlots;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002170")]
		public GameObject defaultVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002171")]
		public AssetReferenceGameObject completedVisual;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002172")]
		public AssetReferenceGameObject defaultVisualRef;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002173")]
		public StreamableAssetRef streamableRefCmp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002174")]
		private Meta.Keyhole _keyhole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002175")]
		public int DelayBeforeEmptying = 3;

		[Cpp2IlInjected.Token(Token = "0x17000336")]
		private bool IsUsingStreamableAssetRef
		{
			[Cpp2IlInjected.Token(Token = "0x6001817")]
			[Cpp2IlInjected.Address(RVA = "0x11C53E0", Offset = "0x11C3DE0", VA = "0x1811C53E0")]
			get
			{
				//IL_0010: Expected O, but got I4
				StreamableAssetRef streamableAssetRef = streamableRefCmp;
				int num = 0;
				return streamableAssetRef != (UnityEngine.Object)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001818")]
		[Cpp2IlInjected.Address(RVA = "0x11C4220", Offset = "0x11C2C20", VA = "0x1811C4220", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_008a, IL_00a6, IL_00ac, IL_00b2, IL_00ba, IL_00c0, IL_00ca, IL_00d0, IL_00d6, IL_00dc, IL_00e2, IL_00e7, IL_00ed, IL_00f7, IL_00fd, IL_0102, IL_0108, IL_0111, IL_0117, IL_011d, IL_012b, IL_0131
			ICollection<Meta.Keyhole> values = (ICollection<Meta.Keyhole>)((MapField<TKey, TValue>)(object)SystemRoot.Instance.MetaClient.profile.world_.keyholes_).get_Values();
			Func<Meta.Keyhole, bool> func = (Func<Meta.Keyhole, bool>)(object)(Func<T, TResult>)delegate(Meta.Keyhole x)
			{
				//Discarded unreachable code: IL_0042
				//IL_0041: Expected O, but got I4
				KeyholeConfig config = x.Config;
				int num2 = 0;
				if (config != null)
				{
				}
				GridObject gridObject2 = gridObject;
				string keyholeConfigDataGUID_ = default(string);
				if (gridObject2 != null)
				{
					GridState state_ = gridObject2.state_;
					if (state_ != null)
					{
						KeyholeGridData keyhole3 = state_.Keyhole;
						if (keyhole3 != null)
						{
							keyholeConfigDataGUID_ = keyhole3.keyholeConfigDataGUID_;
						}
					}
				}
				return string.Equals((string)num2, keyholeConfigDataGUID_);
			};
			Meta.Keyhole keyhole = (_keyhole = Enumerable.FirstOrDefault<Meta.Keyhole>((IEnumerable<>)values, (Func<, >)(object)func));
			Meta.Keyhole keyhole2 = _keyhole;
			if (keyhole2 == null)
			{
				GridEditMode system = SystemRoot.Instance.GetSystem<GridEditMode>();
				if (!IsNotIntegratedKeyhole)
				{
					object[] array = new object[4];
					string text = base.name;
					throw new NullReferenceException();
				}
			}
			CancellationToken gridObjectStateCancellationToken = base.GridObjectStateCancellationToken;
			int num = 0;
			int startVfx = 0;
			UpdateSpawnedItems(keyhole2, (byte)startVfx != 0, gridObjectStateCancellationToken).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001819")]
		[Cpp2IlInjected.Address(RVA = "0x11C4F10", Offset = "0x11C3910", VA = "0x1811C4F10", Slot = "5")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_009f
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.KeyholeItemAdded value = OnKeyholeItemAdded;
			_003CDispatcher_003Ek__BackingField.OnKeyholeItemAdded += value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.KeyholeItemRemoved value2 = OnKeyholeItemRemoved;
			_003CDispatcher_003Ek__BackingField2.OnKeyholeItemRemoved += value2;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.KeyholeItemMoved value3 = OnKeyholeItemMoved;
			_003CDispatcher_003Ek__BackingField3.OnKeyholeItemMoved += value3;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.KeyholeLevelCompleted value4 = OnKeyholeLevelCompleted;
			_003CDispatcher_003Ek__BackingField4.OnKeyholeLevelCompleted += value4;
			base.Start();
		}

		[Cpp2IlInjected.Token(Token = "0x600181A")]
		[Cpp2IlInjected.Address(RVA = "0x11C4710", Offset = "0x11C3110", VA = "0x1811C4710", Slot = "6")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_00cc
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.KeyholeItemAdded value = OnKeyholeItemAdded;
					_003CDispatcher_003Ek__BackingField.OnKeyholeItemAdded -= value;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.KeyholeItemRemoved value2 = OnKeyholeItemRemoved;
					_003CDispatcher_003Ek__BackingField2.OnKeyholeItemRemoved -= value2;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField3 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.KeyholeItemMoved value3 = OnKeyholeItemMoved;
					_003CDispatcher_003Ek__BackingField3.OnKeyholeItemMoved -= value3;
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField4 = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.KeyholeLevelCompleted value4 = OnKeyholeLevelCompleted;
					_003CDispatcher_003Ek__BackingField4.OnKeyholeLevelCompleted -= value4;
				}
			}
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x600181B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public void InitFromGridState(GridState gridState)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600181C")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "9")]
		public bool ForceGridState(ref GridState gridState, ITransactionContext context)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600181D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "10")]
		public void ChangeGridState(GridState gridState, ITransactionContext context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600181E")]
		[Cpp2IlInjected.Address(RVA = "0x11C5280", Offset = "0x11C3C80", VA = "0x1811C5280")]
		[AsyncStateMachine(typeof(_003CUpdateSpawnedItems_003Ed__18))]
		private Task UpdateSpawnedItems(Meta.Keyhole keyhole, bool startVfx, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600181F")]
		[Cpp2IlInjected.Address(RVA = "0x11C4B20", Offset = "0x11C3520", VA = "0x1811C4B20")]
		private void OnKeyholeItemAdded(Meta.Keyhole keyhole, Item itemAdded, ItemState itemState, int amount)
		{
			if (keyhole == _keyhole)
			{
				CancellationToken gridObjectStateCancellationToken = base.GridObjectStateCancellationToken;
				UpdateSpawnedItems(keyhole, startVfx: true, gridObjectStateCancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001820")]
		[Cpp2IlInjected.Address(RVA = "0x11C4C40", Offset = "0x11C3640", VA = "0x1811C4C40")]
		private void OnKeyholeItemRemoved(Meta.Keyhole keyhole, Item itemAdded, ItemState itemState, int amount)
		{
			if (keyhole == _keyhole)
			{
				CancellationToken gridObjectStateCancellationToken = base.GridObjectStateCancellationToken;
				int startVfx = 0;
				UpdateSpawnedItems(keyhole, (byte)startVfx != 0, gridObjectStateCancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001821")]
		[Cpp2IlInjected.Address(RVA = "0x11C4BB0", Offset = "0x11C35B0", VA = "0x1811C4BB0")]
		private void OnKeyholeItemMoved(Meta.Keyhole keyhole)
		{
			if (keyhole == _keyhole)
			{
				CancellationToken gridObjectStateCancellationToken = base.GridObjectStateCancellationToken;
				int startVfx = 0;
				UpdateSpawnedItems(keyhole, (byte)startVfx != 0, gridObjectStateCancellationToken).FireAndForgetTask();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001822")]
		[Cpp2IlInjected.Address(RVA = "0x11C4CD0", Offset = "0x11C36D0", VA = "0x1811C4CD0")]
		private void OnKeyholeLevelCompleted(Meta.Keyhole keyhole, int _)
		{
			//Discarded unreachable code: IL_0063
			if (_keyhole != null)
			{
				string gUID_ = keyhole.gUID_;
				if ("NULL: {0}\n{1}" != null)
				{
					int currentLevel_ = keyhole.currentLevel_;
					int count = ((RepeatedField<T>)(object)keyhole.Config.levels_).Count;
					if (currentLevel_ < count)
					{
						int num = 0;
						Task asyncTask = default(Task);
						asyncTask.FireAndForgetTask();
					}
				}
			}
			if ((long)_keyhole == 0)
			{
				string arg = base.name;
				Debug.LogError($"NULL: {arg}\n{this}");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001823")]
		[Cpp2IlInjected.Address(RVA = "0x11C3FC0", Offset = "0x11C29C0", VA = "0x1811C3FC0")]
		[AsyncStateMachine(typeof(_003CEmptyKeyholeAsync_003Ed__23))]
		private Task EmptyKeyholeAsync(Meta.Keyhole keyhole)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001824")]
		[Cpp2IlInjected.Address(RVA = "0x11C41B0", Offset = "0x11C2BB0", VA = "0x1811C41B0", Slot = "11")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__24))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__24(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001825")]
		[Cpp2IlInjected.Address(RVA = "0x11C40C0", Offset = "0x11C2AC0", VA = "0x1811C40C0", Slot = "12")]
		public object GetStreamableAssetToLoadKey()
		{
			int num = 0;
			if (Application.isPlaying)
			{
				Meta.Keyhole keyhole = _keyhole;
				if (keyhole != null && Meta.Keyhole.IsKeyholeCompleted(keyhole) && completedVisual.RuntimeKeyIsValid())
				{
					Unity.Services.Core.Internal.DependencyTree tree = ((Unity.Services.Core.Internal.IPackageRegistry)completedVisual).Tree;
				}
			}
			if (!defaultVisualRef.RuntimeKeyIsValid())
			{
				int num2 = 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001826")]
		[Cpp2IlInjected.Address(RVA = "0x11C53D0", Offset = "0x11C3DD0", VA = "0x1811C53D0")]
		public Keyhole()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
