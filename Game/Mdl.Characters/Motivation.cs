using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008AB")]
	public abstract class Motivation<C> : IMotivation where C : MotivationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40030CE")]
		protected C config;

		[Cpp2IlInjected.Token(Token = "0x170005DF")]
		public virtual IMotivation SubMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x6002816")]
			[Cpp2IlInjected.Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0", Slot = "12")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005E0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x40030CD")]
		public bool WasPaused
		{
			[Cpp2IlInjected.Token(Token = "0x6002817")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0", Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002818")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x6002819")]
		[Cpp2IlInjected.Address(RVA = "0x28B2890", Offset = "0x28B1290", VA = "0x1828B2890", Slot = "13")]
		public virtual string GetInfo(GameObject agent)
		{
			//Discarded unreachable code: IL_000c
			return GetType().Name;
		}

		[Cpp2IlInjected.Token(Token = "0x600281A")]
		[Cpp2IlInjected.Address(RVA = "0x28B2950", Offset = "0x28B1350", VA = "0x1828B2950")]
		public Motivation(C config)
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600281B")]
		[Cpp2IlInjected.Address(RVA = "0x28B27E0", Offset = "0x28B11E0", VA = "0x1828B27E0", Slot = "8")]
		public void Begin(GameObject agent)
		{
			//Discarded unreachable code: IL_0011
			//IL_0010: Expected O, but got I4
			DoBegin(agent);
			int num = 0;
			DoBegin((GameObject)num);
		}

		[Cpp2IlInjected.Token(Token = "0x600281C")]
		[Cpp2IlInjected.Address(RVA = "0x28B2830", Offset = "0x28B1230", VA = "0x1828B2830", Slot = "9")]
		public bool Execute(float elapsed, GameObject agent)
		{
			if (DoExecute(elapsed, agent))
			{
				return true;
			}
			DoFinish(agent);
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600281D")]
		[Cpp2IlInjected.Address(RVA = "0x25BEFC0", Offset = "0x25BD9C0", VA = "0x1825BEFC0", Slot = "10")]
		public void Finish(GameObject agent)
		{
			//Discarded unreachable code: IL_0008
			DoBegin(agent);
		}

		[Cpp2IlInjected.Token(Token = "0x600281E")]
		[Cpp2IlInjected.Address(RVA = "0x28B2900", Offset = "0x28B1300", VA = "0x1828B2900", Slot = "11")]
		public void Pause(GameObject agent)
		{
			//Discarded unreachable code: IL_0008
			DoPause(agent);
		}

		[Cpp2IlInjected.Token(Token = "0x600281F")]
		[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "14")]
		public virtual bool CanBeInterrupted(GameObject interruptee, GameObject interruptor)
		{
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002820")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract void DoBegin(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002821")]
		[Cpp2IlInjected.Address(Slot = "16")]
		protected abstract void DoFinish(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002822")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract void DoPause(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002823")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract bool DoExecute(float elapsed, GameObject agent);
	}
}
