using System;
using Cpp2IlInjected;
using Definitions.Scene;
using Mdl.Environments;
using Mdl.Systems;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000613")]
	[CreateAssetMenu]
	public class CurrentSceneTypeIs : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002494")]
		public SceneType sceneType;

		[Cpp2IlInjected.Token(Token = "0x6001AEF")]
		[Cpp2IlInjected.Address(RVA = "0x110AAF0", Offset = "0x11094F0", VA = "0x18110AAF0", Slot = "4")]
		protected override void _Init(Client client)
		{
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= OnEnvironmentEntered;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += OnEnvironmentEntered;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF0")]
		[Cpp2IlInjected.Address(RVA = "0x8B3070", Offset = "0x8B1A70", VA = "0x1808B3070")]
		private void OnEnvironmentEntered(object sender, EventArgs e)
		{
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF1")]
		[Cpp2IlInjected.Address(RVA = "0x110AB90", Offset = "0x1109590", VA = "0x18110AB90", Slot = "5")]
		protected unsafe override bool _IsTrue()
		{
			//Discarded unreachable code: IL_001b
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneType sceneType = this.sceneType;
			return (IntPtr)"{il2cpp field on {'constant23' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0x40}" == (IntPtr)(void*)(int)sceneType;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF2")]
		[Cpp2IlInjected.Address(RVA = "0x110AA80", Offset = "0x1109480", VA = "0x18110AA80", Slot = "6")]
		protected override void _CleanUp()
		{
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= OnEnvironmentEntered;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AF3")]
		[Cpp2IlInjected.Address(RVA = "0x8B32A0", Offset = "0x8B1CA0", VA = "0x1808B32A0")]
		public CurrentSceneTypeIs()
		{
		}
	}
}
