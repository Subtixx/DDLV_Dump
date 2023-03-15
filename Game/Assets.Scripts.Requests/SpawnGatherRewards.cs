using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Utils;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[Description("SpawnGatherRewards")]
	[Category("Mdl/Hangout")]
	public class SpawnGatherRewards : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private BBParameter<Task<bool>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private CancellationTokenSource cts = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xF55D50", Offset = "0xF54750", VA = "0x180F55D50", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_004e
			//IL_0016: Expected O, but got I4
			((object)this)._002Ector();
			Character characterComponent = base.CharacterComponent;
			int num = 0;
			if (characterComponent != (Object)num)
			{
				Character characterComponent2 = base.CharacterComponent;
				Character characterComponent3 = base.CharacterComponent;
				int num2 = 0;
				AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
				Task<> task = default(Task<>);
				BBParameter<> bBParameter = (BBParameter<>)(object)(this.task = (BBParameter<Task<bool>>)(object)BBParameter<T>.op_Implicit((T)task));
			}
			int success = 0;
			EndAction((byte)success != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xF56200", Offset = "0xF54C00", VA = "0x180F56200")]
		[AsyncStateMachine(typeof(_003CSpawnRewards_003Ed__3))]
		protected Task<bool> SpawnRewards(Character character)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xF55F80", Offset = "0xF54980", VA = "0x180F55F80", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_00b8
			//IL_00a7: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			((object)this)._002Ector();
			Task<bool> value = (Task<bool>)((BBParameter<T>)(object)task).value;
			if (value != null && value.IsCompletedSuccessfully())
			{
				EndAction(success: true);
			}
			else
			{
				if (((BBParameter<T>)(object)task).value != null && !((System.Threading.Tasks.Task)((BBParameter<T>)(object)task).value).IsCanceled && !((System.Threading.Tasks.Task)((BBParameter<T>)(object)task).value).IsFaulted)
				{
					return;
				}
				BBParameter<Task<bool>> bBParameter = task;
				if (bBParameter != null)
				{
					Task<bool> value2 = (Task<bool>)((BBParameter<T>)(object)bBParameter).value;
					if (value2 != null)
					{
						bool isCanceled = value2.IsCanceled;
						int num = 0;
					}
				}
				int num2 = 0;
				BBParameter<Task<bool>> bBParameter2 = task;
				bool isFaulted = default(bool);
				if (bBParameter2 != null)
				{
					isFaulted = ((System.Threading.Tasks.Task)((BBParameter<T>)(object)bBParameter2).value).IsFaulted;
				}
				Debug.LogWarning($"SpawnGatherRewards.OnUpdate() ending action in failure (task.value.IsCanceled={num2}, task.value.IsFaulted={isFaulted})");
				int success = 0;
				EndAction((byte)success != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xF56340", Offset = "0xF54D40", VA = "0x180F56340")]
		public SpawnGatherRewards()
		{
		}
	}
}
