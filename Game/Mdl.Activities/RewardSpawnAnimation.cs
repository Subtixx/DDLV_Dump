using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Missions;
using Mdl.Systems;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B8C")]
	public class RewardSpawnAnimation : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000B8D")]
		public struct RewardSpawnAnimationOriginScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400404F")]
			private readonly Vector3 originPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4004050")]
			private readonly TaskCompletionSource<bool> tcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4004051")]
			private readonly GridScript gridScript;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4004052")]
			private readonly EventHandler<NewGridObjectEventArgs> delegateToRemove;

			[Cpp2IlInjected.Token(Token = "0x600357B")]
			[Cpp2IlInjected.Address(RVA = "0x1603E90", Offset = "0x1602890", VA = "0x181603E90")]
			public RewardSpawnAnimationOriginScope(Vector3 originPosition, TaskCompletionSource<bool> tcs, GridScript gridScript, EventHandler<NewGridObjectEventArgs> delegateToRemove)
			{
				//IL_001c: Expected O, but got I4
				float z = originPosition.z;
				this.tcs = tcs;
				this.gridScript = gridScript;
				this.delegateToRemove = (EventHandler<NewGridObjectEventArgs>)0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600357C")]
			[Cpp2IlInjected.Address(RVA = "0x1603D40", Offset = "0x1602740", VA = "0x181603D40", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_004a
				//IL_0010: Expected O, but got I4
				//IL_0034: Expected O, but got I4
				//IL_0049: Expected O, but got I4
				GridScript gridScript = this.gridScript;
				int num = 0;
				if (gridScript != (UnityEngine.Object)num)
				{
					GridScript gridScript2 = this.gridScript;
					EventHandler<NewGridObjectEventArgs> eventHandler = delegateToRemove;
					gridScript2.remove_NewGridObjectAddedEvent((EventHandler<>)(object)eventHandler);
					bool flag = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)1);
					bool flag2 = default(bool);
					if ((object)typeof(RewardSpawnAnimation).TypeHandle != null && flag2)
					{
						RewardSpawnAnimation.originPosition = (Vector3?)(object)0;
					}
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004041")]
		[SerializeField]
		private GameObject _animationStartVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004042")]
		[SerializeField]
		private GameObject _animationProjectileVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4004043")]
		[SerializeField]
		private string _animationProjectileVFXEndTrigger = "out";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4004044")]
		[SerializeField]
		private GameObject _animationEndVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4004045")]
		[SerializeField]
		private AK.Wwise.Event _rewardGroundSpawnLandSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4004046")]
		[SerializeField]
		internal RewardSpawnAnimationData _animationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004047")]
		[SerializeField]
		[ItemID]
		private int _overrideOriginLocationWhen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004048")]
		[SerializeField]
		[GUIDName("CustomLocationList")]
		private string _overrideOriginLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004049")]
		internal Vector3? usedOriginPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400404A")]
		internal Task taskToWait;

		[Cpp2IlInjected.Token(Token = "0x400404D")]
		private const string DefaultValuesAddress = "guid:3e62a442e9fa92b4cb168c3fa05d9e3c";

		[Cpp2IlInjected.Token(Token = "0x400404E")]
		public static Vector3? originPosition;

		[Cpp2IlInjected.Token(Token = "0x17000739")]
		private Item OverrideOriginLocationWhen
		{
			[Cpp2IlInjected.Token(Token = "0x600356F")]
			[Cpp2IlInjected.Address(RVA = "0xCC3ED0", Offset = "0xCC28D0", VA = "0x180CC3ED0")]
			get
			{
				long num = Convert.ToInt64((uint)_overrideOriginLocationWhen);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700073A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x70"), Cpp2IlInjected.Token(Token = "0x400404B")]
		public bool AnimationOver
		{
			[Cpp2IlInjected.Token(Token = "0x6003570")]
			[Cpp2IlInjected.Address(RVA = "0x975C90", Offset = "0x974690", VA = "0x180975C90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003571")]
			[Cpp2IlInjected.Address(RVA = "0x976530", Offset = "0x974F30", VA = "0x180976530")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000096")]
		public event EventHandler AnimationOverEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6003572")]
			[Cpp2IlInjected.Address(RVA = "0xCC3E30", Offset = "0xCC2830", VA = "0x180CC3E30")]
			[CompilerGenerated]
			add
			{
				EventHandler animationOverEvent = this.AnimationOverEvent;
				Delegate @delegate = Delegate.Combine(animationOverEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != animationOverEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003573")]
			[Cpp2IlInjected.Address(RVA = "0xCC3F30", Offset = "0xCC2930", VA = "0x180CC3F30")]
			[CompilerGenerated]
			remove
			{
				EventHandler animationOverEvent = this.AnimationOverEvent;
				Delegate @delegate = Delegate.Remove(animationOverEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != animationOverEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003574")]
		[Cpp2IlInjected.Address(RVA = "0xCC3790", Offset = "0xCC2190", VA = "0x180CC3790")]
		private void Start()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003575")]
		[Cpp2IlInjected.Address(RVA = "0xCC3570", Offset = "0xCC1F70", VA = "0x180CC3570")]
		public void SetFromLocationSource(LocationSource locationSource)
		{
			//Discarded unreachable code: IL_002a
			//IL_0029: Expected O, but got I4
			int num = 0;
			MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
			bool flag = default(bool);
			if (flag)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				int num2 = 0;
				usedOriginPosition = (Vector3?)(object)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003576")]
		[Cpp2IlInjected.Address(RVA = "0xCC3440", Offset = "0xCC1E40", VA = "0x180CC3440")]
		[AsyncStateMachine(typeof(_003CPlayAnimation_003Ed__22))]
		private Task PlayAnimation(Vector3 origin, CancellationToken ct)
		{
			float z = origin.z;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003577")]
		[Cpp2IlInjected.Address(RVA = "0xCC2F70", Offset = "0xCC1970", VA = "0x180CC2F70")]
		private void OnAnimationOver()
		{
			EventHandler animationOverEvent = this.AnimationOverEvent;
			AnimationOver = true;
			if (animationOverEvent == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003578")]
		[Cpp2IlInjected.Address(RVA = "0xCC3000", Offset = "0xCC1A00", VA = "0x180CC3000")]
		public unsafe static RewardSpawnAnimationOriginScope OriginScope(Vector3 originPosition, [System.Runtime.InteropServices.Optional] RewardSpawnAnimationData rewardSpawnAnimationDataOverride, [System.Runtime.InteropServices.Optional] GridScript grid)
		{
			//IL_0019: Expected F4, but got O
			//IL_0014: Expected native int or pointer, but got O
			//IL_005e: Expected O, but got I4
			//IL_007a: Expected F4, but got I4
			//IL_0075: Expected native int or pointer, but got O
			//IL_0085: Expected F4, but got I4
			//IL_0080: Expected native int or pointer, but got O
			_003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass26_0();
			CS_0024_003C_003E8__locals0.rewardSpawnAnimationDataOverride = (RewardSpawnAnimationData)(object)grid;
			((Vector3*)(IntPtr)CS_0024_003C_003E8__locals0.originPosition)->z = (float)CS_0024_003C_003E8__locals0;
			bool flag = default(bool);
			if (flag)
			{
				SceneStack sceneStack = SystemRoot.Instance._sceneStack;
				GameObject gameObject = default(GameObject);
				Mdl.Environments.Environment component = gameObject.GetComponent<Mdl.Environments.Environment>();
			}
			bool flag2 = default(bool);
			if (!flag2)
			{
				Task<> task = (Task<>)(object)(CS_0024_003C_003E8__locals0.task = (Task<bool>)(object)((TaskCompletionSource<>)(object)new TaskCompletionSource<TResult>()).m_task);
				EventHandler<NewGridObjectEventArgs> eventHandler = (EventHandler<NewGridObjectEventArgs>)(object)new EventHandler<TEventArgs>(setupDelegate);
				RewardSpawnAnimation.originPosition = (Vector3?)(object)0;
				EventHandler<NewGridObjectEventArgs> eventHandler2 = (EventHandler<NewGridObjectEventArgs>)(object)new EventHandler<TEventArgs>(setupDelegate);
				int num = 0;
				int num2 = 0;
				((Vector3*)(IntPtr)originPosition)->x = num2;
			}
			int num3 = 0;
			((Vector3*)(IntPtr)originPosition)->x = num3;
			throw new NullReferenceException();
			[Cpp2IlInjected.Token(Token = "0x6003580")]
			[Cpp2IlInjected.Address(RVA = "0x1614EE0", Offset = "0x16138E0", VA = "0x181614EE0")]
			void setupDelegate(object sender, NewGridObjectEventArgs args)
			{
				//Discarded unreachable code: IL_00a3
				//IL_0022: Expected O, but got I4
				//IL_003e: Expected O, but got I4
				//IL_0064: Expected O, but got I4
				//IL_0080: Expected O, but got I4
				int num4 = 0;
				int num5 = 0;
				bool flag3 = default(bool);
				if (flag3)
				{
					ActivityItemType activityItemType = default(ActivityItemType);
					int num6 = (int)activityItemType;
				}
				ActivityItemType activityItemType2 = default(ActivityItemType);
				ItemType itemType = default(ItemType);
				if (activityItemType2 != ActivityItemType.Ephemeral || itemType == ItemType.Currency)
				{
					int num7 = 0;
					RewardSpawnAnimation rewardSpawnAnimation = default(RewardSpawnAnimation);
					if (rewardSpawnAnimation == (UnityEngine.Object)num7)
					{
					}
					bool flag4 = default(bool);
					if (flag4)
					{
						RewardSpawnAnimationData rewardSpawnAnimationDataOverride2 = CS_0024_003C_003E8__locals0.rewardSpawnAnimationDataOverride;
						int num8 = 0;
						if (rewardSpawnAnimationDataOverride2 == (UnityEngine.Object)num8 || CS_0024_003C_003E8__locals0.rewardSpawnAnimationDataOverride.automaticPickup)
						{
							AnimationCurve animationHeightCurve = rewardSpawnAnimationDataOverride2.animationHeightCurve;
						}
					}
				}
				int num9 = 0;
				RewardSpawnAnimation rewardSpawnAnimation2 = default(RewardSpawnAnimation);
				if (rewardSpawnAnimation2 != (UnityEngine.Object)num9)
				{
					float z = CS_0024_003C_003E8__locals0.originPosition.z;
					int num10 = 0;
					rewardSpawnAnimation2.usedOriginPosition = (Vector3?)(object)num10;
					Task<bool> task2 = (Task<bool>)(rewardSpawnAnimation2.taskToWait = CS_0024_003C_003E8__locals0.task);
					RewardSpawnAnimationData rewardSpawnAnimationData = (rewardSpawnAnimation2._animationData = CS_0024_003C_003E8__locals0.rewardSpawnAnimationDataOverride);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003579")]
		[Cpp2IlInjected.Address(RVA = "0xCC3DE0", Offset = "0xCC27E0", VA = "0x180CC3DE0")]
		public RewardSpawnAnimation()
		{
		}
	}
}
