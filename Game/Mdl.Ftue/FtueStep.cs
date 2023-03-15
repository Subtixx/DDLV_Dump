using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Meta.Online;
using Meta.Util;
using UnityEngine;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x200057C")]
	public abstract class FtueStep : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40021EA")]
		public List<ControlSchemeType> onlyInControlType = (List<ControlSchemeType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40021EB")]
		public bool lockPlayerActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40021EC")]
		public bool lockShortcuts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40021ED")]
		public bool blockInputWhileWaiting = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40021EE")]
		public float waitBefore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40021EF")]
		public float waitAfter;

		[Cpp2IlInjected.Token(Token = "0x6001895")]
		[Cpp2IlInjected.Address(RVA = "0x8B5380", Offset = "0x8B3D80", VA = "0x1808B5380")]
		public static Type GetStepType(FtueStepType type)
		{
			if (type <= FtueStepType.AddCookingIngredients)
			{
			}
			int num = 0;
			return typeof(FtueStep);
		}

		[Cpp2IlInjected.Token(Token = "0x6001896")]
		[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3C10", VA = "0x1808B5210")]
		[AsyncStateMachine(typeof(_003CExecute_003Ed__7))]
		public Task<FtueResult> Execute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001897")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6001898")]
		[Cpp2IlInjected.Address(RVA = "0x8B5580", Offset = "0x8B3F80", VA = "0x1808B5580")]
		protected FtueStep()
		{
		}
	}
}
