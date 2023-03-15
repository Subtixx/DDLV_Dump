using System;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BF6")]
	public class DisableTalkingCameraScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400429F")]
		private TalkAction talkAction;

		[Cpp2IlInjected.Token(Token = "0x60036A6")]
		[Cpp2IlInjected.Address(RVA = "0x1631880", Offset = "0x1630280", VA = "0x181631880")]
		public DisableTalkingCameraScope()
		{
			//Discarded unreachable code: IL_0048
			//IL_0038: Expected O, but got I4
			PlayerTask currentTask = SystemRoot.Instance.GetSystem<PlayerNavigation>().CurrentTask;
			if ((object)currentTask != null)
			{
				TalkAction component = currentTask.GetComponent<TalkAction>();
			}
			this.talkAction = (TalkAction)(object)currentTask;
			TalkAction talkAction = this.talkAction;
			int num = 0;
			if (talkAction != (UnityEngine.Object)num)
			{
				this.talkAction.UpdateCamera = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60036A7")]
		[Cpp2IlInjected.Address(RVA = "0x1631800", Offset = "0x1630200", VA = "0x181631800", Slot = "4")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0020
			//IL_0010: Expected O, but got I4
			TalkAction talkAction = this.talkAction;
			int num = 0;
			if (talkAction != (UnityEngine.Object)num)
			{
				this.talkAction.UpdateCamera = true;
			}
		}
	}
}
