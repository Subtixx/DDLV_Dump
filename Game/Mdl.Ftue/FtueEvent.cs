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
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x200056E")]
	[CreateAssetMenu]
	public class FtueEvent : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200056F")]
		public delegate void Triggered(FtueEvent evt);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002199")]
		public Triggered OnTriggered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400219A")]
		public bool cancelPlayerTasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400219B")]
		public bool ignoreCurrentTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400219D")]
		public List<FtueCondition> conditions = (List<FtueCondition>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400219E")]
		[ItemID]
		[SerializeField]
		private List<int> _conditionsItems = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400219F")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40021A0")]
		public FtueStepSequence stepSequence;

		[Cpp2IlInjected.Token(Token = "0x17000339")]
		public FtueItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001850")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001851")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001852")]
		[Cpp2IlInjected.Address(RVA = "0x1471F20", Offset = "0x1470920", VA = "0x181471F20")]
		public void Init(Meta.Online.Client client, FtueItemData itemData)
		{
			//Discarded unreachable code: IL_007d
			//IL_0021: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			int num = 0;
			ItemData = itemData;
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)num;
			ConditionListener mask = ConditionItemData.GetMask((IEnumerable<>)_conditionsItems);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			}
			eventHandler = (ConditionEventHandler)num;
			List<FtueCondition> list = conditions;
			bool flag = default(bool);
			if (flag)
			{
				FtueCondition.BecameTrue becameTrue = OnConditionBecameTrue;
				FtueCondition.BecameTrue becameTrue2 = OnConditionBecameTrue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001853")]
		[Cpp2IlInjected.Address(RVA = "0x1471EB0", Offset = "0x14708B0", VA = "0x181471EB0")]
		public bool HasAnyConditions()
		{
			if (Enumerable.Any<FtueCondition>((IEnumerable<>)conditions))
			{
				return true;
			}
			return Enumerable.Any<int>((IEnumerable<>)_conditionsItems);
		}

		[Cpp2IlInjected.Token(Token = "0x6001854")]
		[Cpp2IlInjected.Address(RVA = "0x14716D0", Offset = "0x14700D0", VA = "0x1814716D0")]
		public bool AllConditionsAreTrue()
		{
			//IL_0053: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
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
				if (!ConditionItemData.Evaluate((IEnumerable<>)_conditionsItems, (IProfile)num2, (ITransactionContext)num2))
				{
					break;
				}
				List<FtueCondition> list = conditions;
				if (flag)
				{
					if (!flag)
					{
						continue;
					}
					int num3 = 0;
					num2++;
				}
				if (num2 + 1 == 0)
				{
				}
				break;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001855")]
		[Cpp2IlInjected.Address(RVA = "0x1472240", Offset = "0x1470C40", VA = "0x181472240")]
		private void OnConditionBecameTrue(FtueCondition c)
		{
			if (AllConditionsAreTrue())
			{
				OnTriggered?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001856")]
		[Cpp2IlInjected.Address(RVA = "0x1471D50", Offset = "0x1470750", VA = "0x181471D50")]
		[AsyncStateMachine(typeof(_003CExecute_003Ed__16))]
		public Task<FtueResult> Execute(Meta.Online.Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<FtueResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001857")]
		[Cpp2IlInjected.Address(RVA = "0x14719F0", Offset = "0x14703F0", VA = "0x1814719F0")]
		public void CleanUp()
		{
			//Discarded unreachable code: IL_0019, IL_001f
			List<FtueCondition> list = conditions;
			bool flag = default(bool);
			if (flag)
			{
				FtueCondition.BecameTrue becameTrue = OnConditionBecameTrue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001858")]
		[Cpp2IlInjected.Address(RVA = "0x1472240", Offset = "0x1470C40", VA = "0x181472240")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			if (AllConditionsAreTrue())
			{
				OnTriggered?.Invoke(this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001859")]
		[Cpp2IlInjected.Address(RVA = "0x1471BA0", Offset = "0x14705A0", VA = "0x181471BA0")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			ConditionListener mask = ConditionItemData.GetMask((IEnumerable<>)_conditionsItems);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600185A")]
		[Cpp2IlInjected.Address(RVA = "0x840940", Offset = "0x83F340", VA = "0x180840940")]
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

		[Cpp2IlInjected.Token(Token = "0x600185B")]
		[Cpp2IlInjected.Address(RVA = "0x1472280", Offset = "0x1470C80", VA = "0x181472280")]
		public FtueEvent()
		{
		}
	}
}
