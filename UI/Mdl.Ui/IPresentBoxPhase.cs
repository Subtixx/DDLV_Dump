using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000502")]
	public interface IPresentBoxPhase
	{
		[Cpp2IlInjected.Token(Token = "0x1700051E")]
		PresentItems PresentItems
		{
			[Cpp2IlInjected.Token(Token = "0x6002092")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002093")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700051F")]
		GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x6002094")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6002095")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RefreshData(int boxIndex);

		[Cpp2IlInjected.Token(Token = "0x6002096")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PlayIdle([Optional] Action onComplete);

		[Cpp2IlInjected.Token(Token = "0x6002097")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PlayIntro([Optional] Action onComplete);

		[Cpp2IlInjected.Token(Token = "0x6002098")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PlayOutro([Optional] Action onComplete);

		[Cpp2IlInjected.Token(Token = "0x6002099")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PlayFullSequence([Optional] Action onComplete);
	}
}
