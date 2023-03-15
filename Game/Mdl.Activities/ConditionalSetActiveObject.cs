using System;
using System.Collections.Generic;
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

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B25")]
	public class ConditionalSetActiveObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DF7")]
		[SerializeField]
		[ItemID]
		private List<int> _conditionsItems = (List<int>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003DF8")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x6003360")]
		[Cpp2IlInjected.Address(RVA = "0xA8FCE0", Offset = "0xA8E6E0", VA = "0x180A8FCE0")]
		public void Start()
		{
			//IL_002f: Expected O, but got I4
			GameObject gameObject = base.gameObject;
			bool active = AllConditionsAreTrue();
			gameObject.SetActive(active);
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			ConditionListener mask = ConditionItemData.GetMask((IEnumerable<>)_conditionsItems);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003361")]
		[Cpp2IlInjected.Address(RVA = "0xA8FC60", Offset = "0xA8E660", VA = "0x180A8FC60")]
		public void OnDestroy()
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

		[Cpp2IlInjected.Token(Token = "0x6003362")]
		[Cpp2IlInjected.Address(RVA = "0xA8F900", Offset = "0xA8E300", VA = "0x180A8F900")]
		public bool AllConditionsAreTrue()
		{
			//IL_005c: Expected O, but got I4
			int num = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Mdl.Online.Client client = _003CInstance_003Ek__BackingField.Client;
				if ((object)client != null && client.MetaClient == null)
				{
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			Meta.Online.Client.ClientTransactionContext _003CTransactionContext_003Ek__BackingField = default(Meta.Online.Client.ClientTransactionContext);
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				Mdl.Online.Client client2 = _003CInstance_003Ek__BackingField2.Client;
				if ((object)client2 != null)
				{
					Meta.Online.Client _003CMetaClient_003Ek__BackingField = client2.MetaClient;
					if (_003CMetaClient_003Ek__BackingField != null)
					{
						_003CTransactionContext_003Ek__BackingField = _003CMetaClient_003Ek__BackingField.TransactionContext;
					}
				}
			}
			return ConditionItemData.Evaluate((IEnumerable<>)_conditionsItems, (IProfile)num, (ITransactionContext)_003CTransactionContext_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x6003363")]
		[Cpp2IlInjected.Address(RVA = "0xA8FC90", Offset = "0xA8E690", VA = "0x180A8FC90")]
		private void OnConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_0016
			GameObject gameObject = base.gameObject;
			bool active = AllConditionsAreTrue();
			gameObject.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x6003364")]
		[Cpp2IlInjected.Address(RVA = "0xA8FAB0", Offset = "0xA8E4B0", VA = "0x180A8FAB0")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			ConditionListener mask = ConditionItemData.GetMask((IEnumerable<>)_conditionsItems);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003365")]
		[Cpp2IlInjected.Address(RVA = "0xA8FC60", Offset = "0xA8E660", VA = "0x180A8FC60")]
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

		[Cpp2IlInjected.Token(Token = "0x6003366")]
		[Cpp2IlInjected.Address(RVA = "0xA8FEB0", Offset = "0xA8E8B0", VA = "0x180A8FEB0")]
		public ConditionalSetActiveObject()
		{
		}
	}
}
