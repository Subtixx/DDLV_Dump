using System;
using Cpp2IlInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[Icon("Dialogue", false, "")]
	[Description("either set targetPosition or targetGameObject. tells the ai to move them. this action is blocking until the npc reached the destination.")]
	[EventReceiver(new string[] { "OnCustomEvent" })]
	[Category("Mdl/AI")]
	public class AiMoveToTarget : ActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public BBParameter<Vector3> targetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public BBParameter<GameObject> targetGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public BBParameter<string> eventNameDone;

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xA3CEB0", Offset = "0xA3B8B0", VA = "0x180A3CEB0", Slot = "9")]
			get
			{
				//Discarded unreachable code: IL_000c
				return GetType().Name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		private GameObject Character
		{
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xA3CE50", Offset = "0xA3B850", VA = "0x180A3CE50")]
			get
			{
				IBlackboard blackboard = ((Task)this)._blackboard;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBC0", Offset = "0xA3B5C0", VA = "0x180A3CBC0", Slot = "13")]
		protected override void OnExecute()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA90", Offset = "0xA3B490", VA = "0x180A3CA90")]
		public void OnCustomEvent(EventData receivedEvent)
		{
			//Discarded unreachable code: IL_003f
			string b = default(string);
			if (!base.isActive || !string.Equals(receivedEvent.name.ToUpper(), b))
			{
				return;
			}
			object value = receivedEvent.value;
			if (value != null && value != null)
			{
				GameObject character = Character;
				bool flag = default(bool);
				if (flag)
				{
					EndAction(success: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDE0", Offset = "0xA3B7E0", VA = "0x180A3CDE0")]
		public AiMoveToTarget()
		{
			BBParameter<> bBParameter = default(BBParameter<>);
			eventNameDone = (BBParameter<string>)(object)bBParameter;
			base._002Ector();
		}
	}
}
