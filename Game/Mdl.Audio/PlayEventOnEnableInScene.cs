using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Mdl.Environments;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000B16")]
	public class PlayEventOnEnableInScene : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003DAF")]
		[SerializeField]
		private AK.Wwise.Event sfx_onEnableEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003DB0")]
		[SerializeField]
		private AK.Wwise.Event sfx_onDisableEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003DB1")]
		[ItemID]
		[SerializeField]
		private int playWalleMusicCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003DB2")]
		public GameObject emitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003DB3")]
		private bool eventPosted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003DB4")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x170006FB")]
		private Item PlayWalleMusicConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x600331F")]
			[Cpp2IlInjected.Address(RVA = "0x14B9D90", Offset = "0x14B8790", VA = "0x1814B9D90")]
			get
			{
				long num = Convert.ToInt64((uint)playWalleMusicCondition);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003320")]
		[Cpp2IlInjected.Address(RVA = "0x14B98A0", Offset = "0x14B82A0", VA = "0x1814B98A0")]
		private bool EvaluatePlayWalleMusicCondition()
		{
			long num = Convert.ToInt64((uint)playWalleMusicCondition);
			int num2 = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client client = _003CInstance_003Ek__BackingField.Client;
				if ((object)client != null && client.MetaClient == null)
				{
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				Client client2 = _003CInstance_003Ek__BackingField2.Client;
				if ((object)client2 != null && client2.MetaClient == null)
				{
				}
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003321")]
		[Cpp2IlInjected.Address(RVA = "0x14B9C10", Offset = "0x14B8610", VA = "0x1814B9C10")]
		private void OnEnable()
		{
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= Environment_AnyEnvironmentEnteredEvent;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += Environment_AnyEnvironmentEnteredEvent;
			if (!EvaluatePlayWalleMusicCondition())
			{
				CreateEventHandler();
				return;
			}
			if (EvaluatePlayWalleMusicCondition())
			{
				if (eventPosted)
				{
					goto IL_0078;
				}
				if (base.enabled)
				{
					AK.Wwise.Event @event = sfx_onEnableEvent;
					if (@event != null)
					{
						GameObject gameObject = emitter;
						uint num = @event.Post(gameObject);
					}
					eventPosted = true;
					return;
				}
			}
			if (!eventPosted)
			{
				return;
			}
			goto IL_0078;
			IL_0078:
			AK.Wwise.Event event2 = sfx_onDisableEvent;
			if (event2 != null)
			{
				GameObject gameObject2 = emitter;
				uint num2 = event2.Post(gameObject2);
			}
			Debug.Log("WALLEEVENT disabled enter env");
			eventPosted = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6003322")]
		[Cpp2IlInjected.Address(RVA = "0x14B9830", Offset = "0x14B8230", VA = "0x1814B9830")]
		private void Environment_AnyEnvironmentEnteredEvent(object sender, EventArgs e)
		{
			if (EvaluatePlayWalleMusicCondition())
			{
				if (base.enabled && !eventPosted)
				{
					AK.Wwise.Event @event = sfx_onEnableEvent;
					if (@event != null)
					{
						GameObject gameObject = emitter;
						uint num = @event.Post(gameObject);
					}
					eventPosted = true;
				}
			}
			else if (eventPosted)
			{
				AK.Wwise.Event event2 = sfx_onDisableEvent;
				if (event2 != null)
				{
					GameObject gameObject2 = emitter;
					uint num2 = event2.Post(gameObject2);
				}
				eventPosted = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003323")]
		[Cpp2IlInjected.Address(RVA = "0x14B9B60", Offset = "0x14B8560", VA = "0x1814B9B60")]
		private void OnDisable()
		{
			//IL_001a: Expected O, but got I8
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= Environment_AnyEnvironmentEnteredEvent;
			if (eventPosted)
			{
				AK.Wwise.Event @event = sfx_onDisableEvent;
				if (@event != null)
				{
					GameObject gameObject = emitter;
					uint num = @event.Post(gameObject);
				}
				eventPosted = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003324")]
		[Cpp2IlInjected.Address(RVA = "0x14B9640", Offset = "0x14B8040", VA = "0x1814B9640")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)playWalleMusicCondition);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003325")]
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

		[Cpp2IlInjected.Token(Token = "0x6003326")]
		[Cpp2IlInjected.Address(RVA = "0x14B9A90", Offset = "0x14B8490", VA = "0x1814B9A90")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			if (EvaluatePlayWalleMusicCondition())
			{
				if (eventPosted)
				{
					goto IL_0046;
				}
				if (base.enabled)
				{
					AK.Wwise.Event @event = sfx_onEnableEvent;
					if (@event != null)
					{
						GameObject gameObject = emitter;
						uint num = @event.Post(gameObject);
					}
					eventPosted = true;
					return;
				}
			}
			if (!eventPosted)
			{
				return;
			}
			goto IL_0046;
			IL_0046:
			AK.Wwise.Event event2 = sfx_onDisableEvent;
			if (event2 != null)
			{
				GameObject gameObject2 = emitter;
				uint num2 = event2.Post(gameObject2);
			}
			Debug.Log("WALLEEVENT disabled enter env");
			eventPosted = false;
		}

		[Cpp2IlInjected.Token(Token = "0x6003327")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PlayEventOnEnableInScene()
		{
		}
	}
}
