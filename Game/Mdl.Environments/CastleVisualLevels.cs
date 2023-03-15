using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Audio;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200062B")]
	public class CastleVisualLevels : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40024FE")]
		[SerializeField]
		private CastleVisualLevel cursedLightParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40024FF")]
		[SerializeField]
		private CastleVisualLevel uncursedLightParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002500")]
		[SerializeField]
		private int uncursedLightTimeLock = 120;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002501")]
		[SerializeField]
		private int timeInterval = 5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002502")]
		[SerializeField]
		private GameObject meshModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002503")]
		[SerializeField]
		private GameObject uncursedCastlePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002504")]
		[SerializeField]
		private GameObject cursedCastlePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002505")]
		[ItemID]
		[SerializeField]
		private int liftCurseCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002506")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002507")]
		private CurseState curseState;

		[Cpp2IlInjected.Token(Token = "0x170003E2")]
		private Item liftCurseConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001B52")]
			[Cpp2IlInjected.Address(RVA = "0x12D9D80", Offset = "0x12D8780", VA = "0x1812D9D80")]
			get
			{
				long num = Convert.ToInt64((uint)liftCurseCondition);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B53")]
		[Cpp2IlInjected.Address(RVA = "0x12D8B50", Offset = "0x12D7550", VA = "0x1812D8B50")]
		private bool EvaluateLiftCurseCondition()
		{
			long num = Convert.ToInt64((uint)liftCurseCondition);
			int num2 = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Mdl.Online.Client client = _003CInstance_003Ek__BackingField.Client;
				if ((object)client != null && client.MetaClient == null)
				{
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				Mdl.Online.Client client2 = _003CInstance_003Ek__BackingField2.Client;
				if ((object)client2 != null && client2.MetaClient == null)
				{
				}
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B54")]
		[Cpp2IlInjected.Address(RVA = "0x12D9060", Offset = "0x12D7A60", VA = "0x1812D9060")]
		private void OnEnable()
		{
			CreateEventHandler();
			RefreshAll();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B55")]
		[Cpp2IlInjected.Address(RVA = "0x12D8FF0", Offset = "0x12D79F0", VA = "0x1812D8FF0")]
		private void OnDisable()
		{
			//IL_001a: Expected O, but got I8
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			CancelInvoke("UpdateUncursedLightTimerCallback");
		}

		[Cpp2IlInjected.Token(Token = "0x6001B56")]
		[Cpp2IlInjected.Address(RVA = "0x12D8D40", Offset = "0x12D7740", VA = "0x1812D8D40")]
		private bool IsCurseCleared()
		{
			return EvaluateLiftCurseCondition();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B57")]
		[Cpp2IlInjected.Address(RVA = "0x12D8D50", Offset = "0x12D7750", VA = "0x1812D8D50")]
		private bool IsWaitCurseClearDone()
		{
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Meta.Online.Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null)
				{
					int uncursedLightLockedTimer_ = metaClient.profile.world_.uncursedLightLockedTimer_;
					int num = 0;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B58")]
		[Cpp2IlInjected.Address(RVA = "0x12D9750", Offset = "0x12D8150", VA = "0x1812D9750")]
		private void StartInterval()
		{
			CancelInvoke("UpdateUncursedLightTimerCallback");
		}

		[Cpp2IlInjected.Token(Token = "0x6001B59")]
		[Cpp2IlInjected.Address(RVA = "0x12D97E0", Offset = "0x12D81E0", VA = "0x1812D97E0")]
		private void StopInterval()
		{
			CancelInvoke("UpdateUncursedLightTimerCallback");
		}

		[Cpp2IlInjected.Token(Token = "0x6001B5A")]
		[Cpp2IlInjected.Address(RVA = "0x12D98E0", Offset = "0x12D82E0", VA = "0x1812D98E0")]
		private bool UncursedLockTimeDone()
		{
			//IL_0030: Expected O, but got I4
			int uncursedLightLockedTimer_ = SystemRoot.Instance.MetaClient.profile.world_.uncursedLightLockedTimer_;
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			int num = 0;
			int num2 = 0;
			system.IsUnlockCurseLight = (bool?)(object)num2;
			system.UpdateTimeOfDay();
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B5B")]
		[Cpp2IlInjected.Address(RVA = "0x12D9AE0", Offset = "0x12D84E0", VA = "0x1812D9AE0")]
		private void UpdateUncursedLightTimerCallback()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> asyncTask = default(Task<>);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B5C")]
		[Cpp2IlInjected.Address(RVA = "0x12D9C40", Offset = "0x12D8640", VA = "0x1812D9C40")]
		[AsyncStateMachine(typeof(_003CUpdateUncursedLightTimer_003Ed__19))]
		private Task<bool> UpdateUncursedLightTimer()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B5D")]
		[Cpp2IlInjected.Address(RVA = "0x12D9230", Offset = "0x12D7C30", VA = "0x1812D9230")]
		public void Refresh()
		{
			//Discarded unreachable code: IL_0057
			bool flag = EvaluateLiftCurseCondition();
			if (flag)
			{
			}
			bool flag2 = IsWaitCurseClearDone();
			SetCursedState(flag2);
			SystemRoot.Instance.GetSystem<AudioManager>().SetVillageState(flag);
			if (flag2)
			{
			}
			GameObject[] objectsToDisable = cursedLightParams.objectsToDisable;
			if (_003C_003Ec._003C_003E9__24_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(GameObject x)
				{
					disableObject(x);
				};
			}
			[Cpp2IlInjected.Token(Token = "0x6001B67")]
			[Cpp2IlInjected.Address(RVA = "0x12D9820", Offset = "0x12D8220", VA = "0x1812D9820")]
			static void disableObject(GameObject obj)
			{
				//Discarded unreachable code: IL_0021
				//IL_0009: Expected O, but got I4
				int num = 0;
				if (!(obj == (UnityEngine.Object)num))
				{
					int active = 0;
					obj.SetActive((byte)active != 0);
				}
				else
				{
					Debug.LogError("RefreshLight: reference missing in disable objects.)");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B5E")]
		[Cpp2IlInjected.Address(RVA = "0x12D95C0", Offset = "0x12D7FC0", VA = "0x1812D95C0")]
		private void SetCursedState(bool isCurseLifted)
		{
			//Discarded unreachable code: IL_0080
			//IL_0014: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			if (isCurseLifted)
			{
			}
			GameObject gameObject = cursedCastlePrefab;
			int num = 0;
			if (gameObject == (UnityEngine.Object)num)
			{
				return;
			}
			GameObject gameObject2 = meshModel;
			int num2 = 0;
			if (!(gameObject2 == (UnityEngine.Object)num2))
			{
				string a = meshModel.name;
				string b = gameObject.name;
				if (!string.Equals(a, b))
				{
					Transform parent = meshModel.transform.parent.transform;
					GameObject gameObject3 = UnityEngine.Object.Instantiate(gameObject, parent);
					UnityEngine.Object.Destroy(meshModel);
					meshModel = gameObject3;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B5F")]
		[Cpp2IlInjected.Address(RVA = "0x12D9080", Offset = "0x12D7A80", VA = "0x1812D9080")]
		public void RefreshAll()
		{
			//Discarded unreachable code: IL_0060
			//IL_004b: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			Meta.Online.Client client = default(Meta.Online.Client);
			do
			{
				Refresh();
				if (EvaluateLiftCurseCondition() || IsWaitCurseClearDone())
				{
					bool flag = UncursedLockTimeDone();
					if (!flag)
					{
						StartInterval();
						return;
					}
					while (!flag)
					{
					}
					continue;
				}
				return;
			}
			while (client.profile.world_.uncursedLightLockedTimer_ <= 0);
			int num = 0;
			AudioManager audioManager = default(AudioManager);
			audioManager.IsUnlockCurseLight = (bool?)(object)num;
			audioManager.UpdateTimeOfDay();
			Meta.Online.Client client2 = default(Meta.Online.Client);
			client2.ResetUncursedTimeAcumulatedAsync(-1, (CancellationToken)num).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B60")]
		[Cpp2IlInjected.Address(RVA = "0x12D97E0", Offset = "0x12D81E0", VA = "0x1812D97E0")]
		public void StopAll()
		{
			CancelInvoke("UpdateUncursedLightTimerCallback");
		}

		[Cpp2IlInjected.Token(Token = "0x6001B61")]
		[Cpp2IlInjected.Address(RVA = "0x12D9470", Offset = "0x12D7E70", VA = "0x1812D9470")]
		private void SetCursedLight(bool isCurseLifted)
		{
			//Discarded unreachable code: IL_002e
			if (isCurseLifted)
			{
			}
			GameObject[] objectsToDisable = cursedLightParams.objectsToDisable;
			if (_003C_003Ec._003C_003E9__24_1 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(GameObject x)
				{
					disableObject(x);
				};
			}
			[Cpp2IlInjected.Token(Token = "0x6001B67")]
			[Cpp2IlInjected.Address(RVA = "0x12D9820", Offset = "0x12D8220", VA = "0x1812D9820")]
			static void disableObject(GameObject obj)
			{
				//Discarded unreachable code: IL_0021
				//IL_0009: Expected O, but got I4
				int num = 0;
				if (!(obj == (UnityEngine.Object)num))
				{
					int active = 0;
					obj.SetActive((byte)active != 0);
				}
				else
				{
					Debug.LogError("RefreshLight: reference missing in disable objects.)");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B62")]
		[Cpp2IlInjected.Address(RVA = "0x12D8960", Offset = "0x12D7360", VA = "0x1812D8960")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)liftCurseCondition);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B63")]
		[Cpp2IlInjected.Address(RVA = "0xA44AA0", Offset = "0xA434A0", VA = "0x180A44AA0")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B64")]
		[Cpp2IlInjected.Address(RVA = "0x12D8E80", Offset = "0x12D7880", VA = "0x1812D8E80")]
		private void OnConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_005c
			bool flag = EvaluateLiftCurseCondition();
			if ((flag ? CurseState.Cursed : CurseState.None) == curseState)
			{
				return;
			}
			curseState = (flag ? CurseState.Cursed : CurseState.None);
			SystemRoot.Instance.GetSystem<AudioManager>().UpdateTimeOfDay();
			if (flag)
			{
				CancelInvoke("UpdateUncursedLightTimerCallback");
			}
			Refresh();
			if (flag)
			{
				if (UncursedLockTimeDone())
				{
					RefreshAll();
				}
				else
				{
					StartInterval();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B65")]
		[Cpp2IlInjected.Address(RVA = "0x12D8E80", Offset = "0x12D7880", VA = "0x1812D8E80")]
		private void UpdateConditionChanged()
		{
			//Discarded unreachable code: IL_005c
			bool flag = EvaluateLiftCurseCondition();
			if ((flag ? CurseState.Cursed : CurseState.None) == curseState)
			{
				return;
			}
			curseState = (flag ? CurseState.Cursed : CurseState.None);
			SystemRoot.Instance.GetSystem<AudioManager>().UpdateTimeOfDay();
			if (flag)
			{
				CancelInvoke("UpdateUncursedLightTimerCallback");
			}
			Refresh();
			if (flag)
			{
				if (UncursedLockTimeDone())
				{
					RefreshAll();
				}
				else
				{
					StartInterval();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001B66")]
		[Cpp2IlInjected.Address(RVA = "0x12D9D60", Offset = "0x12D8760", VA = "0x1812D9D60")]
		public CastleVisualLevels()
		{
		}//IL_000a: Expected I4, but got I8
		//IL_0013: Expected I4, but got I8

	}
}
