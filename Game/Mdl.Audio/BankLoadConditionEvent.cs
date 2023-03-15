using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000AF0")]
	public class BankLoadConditionEvent
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003C99")]
		[ItemID]
		[SerializeField]
		private int loadAudioBankCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4003C9A")]
		[SerializeField]
		[ItemID]
		private int unloadAudioBankCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C9B")]
		public Bank bank;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003C9C")]
		public AK.Wwise.Event activeEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003C9D")]
		public AK.Wwise.Event inactiveEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003C9E")]
		public string tag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003C9F")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003CA0")]
		private bool bankLoaded;

		[Cpp2IlInjected.Token(Token = "0x170006F1")]
		private Item loadAudioBankConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003247")]
			[Cpp2IlInjected.Address(RVA = "0x163A910", Offset = "0x1639310", VA = "0x18163A910")]
			get
			{
				long num = Convert.ToInt64((uint)loadAudioBankCondition);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F2")]
		private Item unloadAudioBankConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003249")]
			[Cpp2IlInjected.Address(RVA = "0x163A970", Offset = "0x1639370", VA = "0x18163A970")]
			get
			{
				long num = Convert.ToInt64((uint)unloadAudioBankCondition);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003248")]
		[Cpp2IlInjected.Address(RVA = "0x163A060", Offset = "0x1638A60", VA = "0x18163A060")]
		private bool EvaluateLoadAudioBankCondition()
		{
			long num = Convert.ToInt64((uint)loadAudioBankCondition);
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			long num2 = Convert.ToInt64((uint)loadAudioBankCondition);
			int num3 = 0;
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

		[Cpp2IlInjected.Token(Token = "0x600324A")]
		[Cpp2IlInjected.Address(RVA = "0x163A2F0", Offset = "0x1638CF0", VA = "0x18163A2F0")]
		private bool EvaluateUnloadAudioBankCondition()
		{
			long num = Convert.ToInt64((uint)unloadAudioBankCondition);
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			long num2 = Convert.ToInt64((uint)unloadAudioBankCondition);
			int num3 = 0;
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

		[Cpp2IlInjected.Token(Token = "0x600324B")]
		[Cpp2IlInjected.Address(RVA = "0x163A590", Offset = "0x1638F90", VA = "0x18163A590")]
		public void Init()
		{
			//Discarded unreachable code: IL_008f
			//IL_008e: Expected O, but got I8
			if (!EvaluateLoadAudioBankCondition())
			{
				CreateEventHandler();
				return;
			}
			if (!bankLoaded)
			{
				if (EvaluateLoadAudioBankCondition())
				{
					LoadBank();
					return;
				}
				if (!bankLoaded)
				{
					return;
				}
			}
			if (EvaluateUnloadAudioBankCondition())
			{
				AK.Wwise.Event @event = inactiveEvent;
				if (@event != null)
				{
					AudioManager audioManager = default(AudioManager);
					GameObject gameObject = audioManager.gameObject;
					uint num = @event.Post(gameObject);
				}
				bank?.Unload();
				ConditionEventHandler conditionEventHandler = eventHandler;
				bankLoaded = false;
				conditionEventHandler?.Dispose();
				eventHandler = (ConditionEventHandler)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600324C")]
		[Cpp2IlInjected.Address(RVA = "0x163A030", Offset = "0x1638A30", VA = "0x18163A030")]
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

		[Cpp2IlInjected.Token(Token = "0x600324D")]
		[Cpp2IlInjected.Address(RVA = "0x1639D00", Offset = "0x1638700", VA = "0x181639D00")]
		private void CreateEventHandler(bool loadEvent = true)
		{
			//Discarded unreachable code: IL_007c
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			int num2 = loadAudioBankCondition;
			if ((object)typeof(Item).TypeHandle == null)
			{
				if (!loadEvent)
				{
					long num3 = Convert.ToInt64((uint)unloadAudioBankCondition);
					long num4 = Convert.ToInt64((uint)unloadAudioBankCondition);
				}
				int itemID = loadAudioBankConditionItem.ItemID;
				if (SystemRoot.Instance.MetaClient.Dispatcher != null)
				{
					ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnConditionChanged;
				}
				ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
				eventHandler = conditionEventHandler;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600324E")]
		[Cpp2IlInjected.Address(RVA = "0x163A030", Offset = "0x1638A30", VA = "0x18163A030")]
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

		[Cpp2IlInjected.Token(Token = "0x600324F")]
		[Cpp2IlInjected.Address(RVA = "0x163A7F0", Offset = "0x16391F0", VA = "0x18163A7F0")]
		private void OnConditionChanged(ConditionListener conditionListener)
		{
			//Discarded unreachable code: IL_007e
			//IL_007d: Expected O, but got I8
			if (!bankLoaded)
			{
				if (EvaluateLoadAudioBankCondition())
				{
					LoadBank();
					return;
				}
				if (!bankLoaded)
				{
					return;
				}
			}
			if (EvaluateUnloadAudioBankCondition())
			{
				AK.Wwise.Event @event = inactiveEvent;
				if (@event != null)
				{
					AudioManager audioManager = default(AudioManager);
					GameObject gameObject = audioManager.gameObject;
					uint num = @event.Post(gameObject);
				}
				bank?.Unload();
				ConditionEventHandler conditionEventHandler = eventHandler;
				bankLoaded = false;
				conditionEventHandler?.Dispose();
				eventHandler = (ConditionEventHandler)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003250")]
		[Cpp2IlInjected.Address(RVA = "0x163A6D0", Offset = "0x16390D0", VA = "0x18163A6D0")]
		private void LoadBank()
		{
			//Discarded unreachable code: IL_0050
			Bank bank = this.bank;
			if (bank != null)
			{
				int saveDecodedBank = 0;
				int decodeBank = 0;
				bank.Load((byte)decodeBank != 0, (byte)saveDecodedBank != 0);
			}
			AK.Wwise.Event @event = activeEvent;
			if (@event != null)
			{
				GameObject gameObject = SystemRoot.Instance.GetSystem<AudioManager>().gameObject;
				uint num = @event.Post(gameObject);
			}
			bankLoaded = true;
			int loadEvent = 0;
			CreateEventHandler((byte)loadEvent != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003251")]
		[Cpp2IlInjected.Address(RVA = "0x163A580", Offset = "0x1638F80", VA = "0x18163A580")]
		public void ForceLoadBank()
		{
			if (!bankLoaded)
			{
				LoadBank();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003252")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public BankLoadConditionEvent()
		{
		}
	}
}
