using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Definitions.Scene;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Streaming;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200061C")]
	public class AreaLocksController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200061D")]
		public delegate void CastleUnlockedDelegate();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024B4")]
		public int delayBetweenAnimations = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40024B5")]
		public int delayDestroyAreaThornes = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024B6")]
		public int msDelayNavMeshBlockersRemove = 500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40024B7")]
		public AK.Wwise.Event _lockRemovedSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40024B8")]
		public AK.Wwise.Event _unlockAreaJingle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40024B9")]
		[SerializeField]
		public AreaLock[] _areaLocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40024BA")]
		[SerializeField]
		public CastleThornsLock _castleThornsLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40024BB")]
		[SerializeField]
		private CastleStairLock[] _castleThorns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40024BC")]
		private ConditionEventHandler castleThornConditionsEventHandler;

		[Cpp2IlInjected.Token(Token = "0x170003DC")]
		public CastleStairLock[] CastleLocks
		{
			[Cpp2IlInjected.Token(Token = "0x6001B1F")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
			get
			{
				return _castleThorns;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DD")]
		public static bool IsStreamingAreaBlockers
		{
			[Cpp2IlInjected.Token(Token = "0x6001B22")]
			[Cpp2IlInjected.Address(RVA = "0xA45450", Offset = "0xA43E50", VA = "0x180A45450")]
			get
			{
				GridObjectStreamingManager instance = GridObjectStreamingManager._instance;
				if ((object)instance != null)
				{
					return instance.ActiveConfig.IsStreamingAreaLocksBigThorns;
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003DE")]
		public bool CastleUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6001B26")]
			[Cpp2IlInjected.Address(RVA = "0xA45350", Offset = "0xA43D50", VA = "0x180A45350")]
			get
			{
				//Discarded unreachable code: IL_0028
				Profile profile = SystemRoot.Instance.MetaClient.profile;
				CastleThornsLock castleThornsLock = _castleThornsLock;
				ProfileWorld world_ = profile.world_;
				Item castleItem = castleThornsLock.CastleItem;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003C")]
		public event CastleUnlockedDelegate OnCastleUnlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6001B20")]
			[Cpp2IlInjected.Address(RVA = "0xA452B0", Offset = "0xA43CB0", VA = "0x180A452B0")]
			[CompilerGenerated]
			add
			{
				CastleUnlockedDelegate onCastleUnlocked = this.OnCastleUnlocked;
				Delegate @delegate = Delegate.Combine(onCastleUnlocked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCastleUnlocked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001B21")]
			[Cpp2IlInjected.Address(RVA = "0xA454B0", Offset = "0xA43EB0", VA = "0x180A454B0")]
			[CompilerGenerated]
			remove
			{
				CastleUnlockedDelegate onCastleUnlocked = this.OnCastleUnlocked;
				Delegate @delegate = Delegate.Remove(onCastleUnlocked, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onCastleUnlocked)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B23")]
		[Cpp2IlInjected.Address(RVA = "0xA44EA0", Offset = "0xA438A0", VA = "0x180A44EA0")]
		private void Start()
		{
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			RefreshCastleThorns().FireAndForgetTask();
			CreateEventHandler();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B24")]
		[Cpp2IlInjected.Address(RVA = "0xA44AA0", Offset = "0xA434A0", VA = "0x180A44AA0")]
		private void OnDestroy()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = castleThornConditionsEventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B25")]
		[Cpp2IlInjected.Address(RVA = "0xA44AD0", Offset = "0xA434D0", VA = "0x180A44AD0")]
		[AsyncStateMachine(typeof(_003CLoadThorns_003Ed__19))]
		public Task LoadThorns()
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B27")]
		[Cpp2IlInjected.Address(RVA = "0xA44C50", Offset = "0xA43650", VA = "0x180A44C50")]
		[AsyncStateMachine(typeof(_003CRefreshCastleThorns_003Ed__22))]
		private Task RefreshCastleThorns()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B28")]
		[Cpp2IlInjected.Address(RVA = "0xA44770", Offset = "0xA43170", VA = "0x180A44770")]
		internal void DebugRefreshVillageThorns()
		{
			//Discarded unreachable code: IL_006a
			//IL_004b: Expected O, but got I4
			//IL_0060: Expected O, but got I4
			AreaLock[] areaLocks = _areaLocks;
			int num = 0;
			int length = areaLocks.Length;
			if (num >= length)
			{
				return;
			}
			AreaLock areaLock = areaLocks[num];
			Client client = default(Client);
			MapField<int, Village.Types.VillageArea> areas_ = client.profile.Village.areas_;
			bool flag = default(bool);
			if (flag)
			{
				GameObject _003CAreaThorns_003Ek__BackingField = areaLock.AreaThorns;
				int num2 = 0;
				int num3 = 0;
				if (_003CAreaThorns_003Ek__BackingField != (UnityEngine.Object)num3)
				{
					GameObject _003CAreaThorns_003Ek__BackingField2 = areaLock.AreaThorns;
					RunAndCleanAnimations(_003CAreaThorns_003Ek__BackingField2, (Transform)num2).FireAndForgetTask();
				}
			}
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B29")]
		[Cpp2IlInjected.Address(RVA = "0xA45030", Offset = "0xA43A30", VA = "0x180A45030")]
		private void UnlockArea_OnAreaUnlocked(bool isCastleArea, VillageAreaType areaType, Transform unlockOrigin)
		{
			//Discarded unreachable code: IL_0130
			//IL_004b: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0116: Expected O, but got I4
			if (!isCastleArea)
			{
				AreaLock[] areaLocks = _areaLocks;
				int num = 0;
				int length = areaLocks.Length;
				if (num >= length)
				{
					return;
				}
				AreaLock areaLock = areaLocks[num];
				if (areaLock._areaType == areaType)
				{
					GameObject _003CAreaThorns_003Ek__BackingField = areaLock.AreaThorns;
					int num2 = 0;
					if (_003CAreaThorns_003Ek__BackingField != (UnityEngine.Object)num2)
					{
						if ((areaLock.playUnlockSfx ? 1 : 0) != num)
						{
							CastleThornsLock castleThornsLock = _castleThornsLock;
							AK.Wwise.Event lockRemovedSFX = _lockRemovedSFX;
							if (castleThornsLock != null)
							{
							}
							uint num3 = lockRemovedSFX.Post((GameObject)num);
						}
						if ((areaLock.playUnlockAreaJingle ? 1 : 0) != num)
						{
							AK.Wwise.Event unlockAreaJingle = _unlockAreaJingle;
							GameObject gameObject = base.gameObject;
							uint num4 = unlockAreaJingle.Post(gameObject);
						}
						GameObject _003CAreaThorns_003Ek__BackingField2 = areaLock.AreaThorns;
						RunAndCleanAnimations(_003CAreaThorns_003Ek__BackingField2, unlockOrigin).FireAndForgetTask();
					}
				}
				num++;
			}
			CastleThornsLock castleThornsLock2 = _castleThornsLock;
			AK.Wwise.Event lockRemovedSFX2 = castleThornsLock2._lockRemovedSFX;
			GameObject _003CCastleThorns_003Ek__BackingField = castleThornsLock2.CastleThorns;
			uint num5 = lockRemovedSFX2.Post(_003CCastleThorns_003Ek__BackingField);
			CastleThornsLock castleThornsLock3 = _castleThornsLock;
			AK.Wwise.Event unlockMusic = castleThornsLock3._unlockMusic;
			GameObject _003CCastleThorns_003Ek__BackingField2 = castleThornsLock3.CastleThorns;
			uint num6 = unlockMusic.Post(_003CCastleThorns_003Ek__BackingField2);
			if (_castleThornsLock != null)
			{
			}
			int num7 = 0;
			RunAndCleanAnimations((GameObject)num7, unlockOrigin).FireAndForgetTask();
			this.OnCastleUnlocked?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B2A")]
		[Cpp2IlInjected.Address(RVA = "0xA44D60", Offset = "0xA43760", VA = "0x180A44D60")]
		[AsyncStateMachine(typeof(_003CRunAndCleanAnimations_003Ed__25))]
		private Task RunAndCleanAnimations(GameObject objectRoot, Transform unlockOrigin)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B2B")]
		[Cpp2IlInjected.Address(RVA = "0xA44980", Offset = "0xA43380", VA = "0x180A44980")]
		[AsyncStateMachine(typeof(_003CDisableNavMeshBlockersAfterWait_003Ed__26))]
		private Task DisableNavMeshBlockersAfterWait(GameObject objectRoot)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B2C")]
		[Cpp2IlInjected.Address(RVA = "0xA44570", Offset = "0xA42F70", VA = "0x180A44570")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			castleThornConditionsEventHandler?.Dispose();
			int num = 0;
			castleThornConditionsEventHandler = (ConditionEventHandler)num;
			CastleStairLock[] castleThorns = _castleThorns;
			int length = castleThorns.Length;
			if (num < length)
			{
				int itemID = castleThorns[num].ConditionItem.ItemID;
				num++;
			}
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			if (_003CDispatcher_003Ek__BackingField != null)
			{
				ProfileEventDispatcher.AnyConditionChanged callback = OnCastleThornConditionChanged;
				conditionEventHandler = _003CDispatcher_003Ek__BackingField.RegisterToAnyConditionChanged((ConditionListener)num, callback);
			}
			castleThornConditionsEventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B2D")]
		[Cpp2IlInjected.Address(RVA = "0xA44AA0", Offset = "0xA434A0", VA = "0x180A44AA0")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = castleThornConditionsEventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B2E")]
		[Cpp2IlInjected.Address(RVA = "0xA44BF0", Offset = "0xA435F0", VA = "0x180A44BF0")]
		private void OnCastleThornConditionChanged(ConditionListener conditionListener)
		{
			RefreshCastleThorns().FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B2F")]
		[Cpp2IlInjected.Address(RVA = "0xA45290", Offset = "0xA43C90", VA = "0x180A45290")]
		public AreaLocksController()
		{
		}//IL_000a: Expected I4, but got I8
		//IL_0014: Expected I4, but got I8
		//IL_0021: Expected I4, but got I8

	}
}
