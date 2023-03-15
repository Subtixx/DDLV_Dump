using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Environments;
using Mdl.Systems;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[Category("Application")]
	public class MoanaRealmMove : ActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		[RequiredField]
		public BBParameter<int> destination;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0xEFB720", Offset = "0xEFA120", VA = "0x180EFB720", Slot = "9")]
			get
			{
				BBParameter<int> arg = destination;
				return $"Move towards destion with index {arg}. Use -1 to go back to the Island.";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xEFB490", Offset = "0xEF9E90", VA = "0x180EFB490", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0030
			//IL_001f: Expected I4, but got O
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			GameObject gameObject = default(GameObject);
			MoanaRealmController component = gameObject.GetComponent<MoanaRealmController>();
			int num = (int)((BBParameter<T>)(object)destination).value;
			int num2 = 0;
			System.Threading.Tasks.Task asyncTask = default(System.Threading.Tasks.Task);
			asyncTask.FireAndForgetTask();
			EndAction();
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D130", Offset = "0xA3BB30", VA = "0x180A3D130")]
		public MoanaRealmMove()
		{
		}
	}
}
