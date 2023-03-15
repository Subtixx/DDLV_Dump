using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008FD")]
	public class WalkAround : Motivation<WalkAroundConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003223")]
		private float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003224")]
		private Task playAnimInTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003225")]
		private Task playAnimOutTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003226")]
		private bool setAnimOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003227")]
		private Task walkTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003228")]
		private CancellationTokenSource ctSource;

		[Cpp2IlInjected.Token(Token = "0x600295F")]
		[Cpp2IlInjected.Address(RVA = "0xD4D620", Offset = "0xD4C020", VA = "0x180D4D620")]
		public WalkAround(WalkAroundConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002960")]
		[Cpp2IlInjected.Address(RVA = "0xD4D1A0", Offset = "0xD4BBA0", VA = "0x180D4D1A0", Slot = "13")]
		public override string GetInfo(GameObject agent)
		{
			//Discarded unreachable code: IL_0072
			object[] array;
			string text = default(string);
			string newLine;
			while (true)
			{
				array = new object[4];
				string info = ((Motivation<C>)(object)this).GetInfo(agent);
				if (info != null && info == null)
				{
					continue;
				}
				array[0] = info;
				if (text != null && text == null)
				{
					continue;
				}
				array[1] = text;
				int num = 0;
				newLine = Environment.NewLine;
				if (newLine == null || newLine != null)
				{
					array[2] = newLine;
					float num2 = duration;
					if (newLine == null || newLine != null)
					{
						break;
					}
				}
			}
			array[3] = newLine;
			return string.Format("{0} - {1}{2}Duration : {3}", array);
		}

		[Cpp2IlInjected.Token(Token = "0x6002961")]
		[Cpp2IlInjected.Address(RVA = "0xD4CA90", Offset = "0xD4B490", VA = "0x180D4CA90", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//Discarded unreachable code: IL_007a
			//IL_0020: Expected F4, but got I4
			//IL_0020: Expected F4, but got I4
			CancellationTokenSource cancellationTokenSource = (ctSource = new CancellationTokenSource());
			int threadIDExecutingCallbacks = cancellationTokenSource.m_threadIDExecutingCallbacks;
			float num = (duration = UnityEngine.Random.Range((float)cancellationTokenSource.m_state, (float)threadIDExecutingCallbacks));
			setAnimOverride = false;
			if (cancellationTokenSource == null)
			{
				int num2 = UnityEngine.Random.Range(0, 100);
				setAnimOverride = (byte)num2 != 0;
			}
			if (setAnimOverride)
			{
				SetAnimOverride(agent, 1f);
			}
			Task task = walkTask;
			if (cancellationTokenSource == null)
			{
				CancellationToken token = ctSource.Token;
				Task task2 = default(Task);
				playAnimInTask = task2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002962")]
		[Cpp2IlInjected.Address(RVA = "0xD4D550", Offset = "0xD4BF50", VA = "0x180D4D550")]
		private void SetAnimOverride(GameObject agent, float weight)
		{
			//Discarded unreachable code: IL_0024
			//IL_0010: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			Animator componentInChildren = agent.GetComponentInChildren<Animator>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num)
			{
				int layerIndex = componentInChildren.GetLayerIndex((string)num);
				componentInChildren.SetLayerWeight(layerIndex, weight);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002963")]
		[Cpp2IlInjected.Address(RVA = "0xD4CF70", Offset = "0xD4B970", VA = "0x180D4CF70", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_008e
			//IL_0014: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			//IL_0022: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0044: Expected O, but got I4
			//IL_0051: Expected F4, but got I4
			//IL_0065: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			//IL_0086: Expected O, but got I4
			ctSource.Cancel();
			int num = 0;
			walkTask = (Task)num;
			playAnimInTask = (Task)num;
			playAnimOutTask = (Task)num;
			if ((object)typeof(UnityEngine.Object).TypeHandle == null)
			{
				Animator componentInChildren = agent.GetComponentInChildren<Animator>();
				int num2 = 0;
				if (componentInChildren != (UnityEngine.Object)num2)
				{
					int layerIndex = componentInChildren.GetLayerIndex((string)num2);
					int num3 = 0;
					componentInChildren.SetLayerWeight(layerIndex, num3);
				}
			}
			Animator componentInChildren2 = agent.GetComponentInChildren<Animator>();
			int num4 = 0;
			bool flag = componentInChildren2 != (UnityEngine.Object)num4;
			if (flag)
			{
				int num5 = 0;
				if (!flag)
				{
					componentInChildren2.ResetTrigger((string)num5);
					componentInChildren2.ResetTrigger((string)num5);
				}
			}
			CharacterUtil.EnableCharacter(agent, enable: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6002964")]
		[Cpp2IlInjected.Address(RVA = "0xCC8B20", Offset = "0xCC7520", VA = "0x180CC8B20", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			IMotivation subMotivation = ((IMotivation)this).SubMotivation;
		}

		[Cpp2IlInjected.Token(Token = "0x6002965")]
		[Cpp2IlInjected.Address(RVA = "0xD4CC40", Offset = "0xD4B640", VA = "0x180D4CC40", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			//IL_0034: Invalid comparison between I4 and F4
			Task task = playAnimInTask;
			if (task == null || task.IsCompleted || playAnimInTask.IsCanceled)
			{
				float num = duration;
				int num2 = 0;
				duration = num;
				if ((float)num2 >= num)
				{
					if (1 == 0)
					{
					}
					CancellationToken cancellationToken = default(CancellationToken);
					bool flag = default(bool);
					if ((object)cancellationToken != null && !flag)
					{
						bool flag2 = default(bool);
						while (!flag2)
						{
						}
					}
					throw new NullReferenceException();
				}
				Task task2 = walkTask;
				if (task2 == null || task2.IsCompleted)
				{
					if (agent.GetComponent<INpc>() != null)
					{
					}
					Transform transform = agent.transform;
					CancellationTokenSource cancellationTokenSource = ctSource;
					CancellationToken cancellationToken = cancellationTokenSource.Token;
					Timer timer = cancellationTokenSource.m_timer;
					Task task3 = default(Task);
					walkTask = task3;
				}
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002966")]
		[Cpp2IlInjected.Address(RVA = "0xD4D3F0", Offset = "0xD4BDF0", VA = "0x180D4D3F0")]
		[AsyncStateMachine(typeof(_003CPlayAnimation_003Ed__13))]
		private Task PlayAnimation(GameObject agent, string animState, string triggerToSet, string triggerToReset, float maxTime, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
