using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008AA")]
	public interface IMotivation
	{
		[Cpp2IlInjected.Token(Token = "0x170005DD")]
		IMotivation SubMotivation
		{
			[Cpp2IlInjected.Token(Token = "0x600280E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170005DE")]
		bool WasPaused
		{
			[Cpp2IlInjected.Token(Token = "0x600280F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6002810")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string GetInfo(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002811")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool CanBeInterrupted(GameObject interruptee, GameObject interruptor);

		[Cpp2IlInjected.Token(Token = "0x6002812")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Begin(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002813")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool Execute(float elapsed, GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002814")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Finish(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6002815")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Pause(GameObject agent);
	}
}
