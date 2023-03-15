using System;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000AEA")]
	public class AudioEmitterBankLoader
	{
		[Cpp2IlInjected.Token(Token = "0x2000AEB")]
		public delegate void BankLoaded(AudioEmitterBankLoader bankLoader);

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003C8B")]
		private bool bankLoading;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003C8C")]
		private int referenceCount;

		[Cpp2IlInjected.Token(Token = "0x170006EF")]
		public Bank BankToLoad
		{
			[Cpp2IlInjected.Token(Token = "0x600322A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CBankToLoad_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600322B")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			private set
			{
				_003CBankToLoad_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F0")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003C89")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600322C")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600322D")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000081")]
		public event BankLoaded OnBankLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600322E")]
			[Cpp2IlInjected.Address(RVA = "0xA4D1B0", Offset = "0xA4BBB0", VA = "0x180A4D1B0")]
			[CompilerGenerated]
			add
			{
				BankLoaded onBankLoaded = this.OnBankLoaded;
				Delegate @delegate = Delegate.Combine(onBankLoaded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBankLoaded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600322F")]
			[Cpp2IlInjected.Address(RVA = "0xA4D250", Offset = "0xA4BC50", VA = "0x180A4D250")]
			[CompilerGenerated]
			remove
			{
				BankLoaded onBankLoaded = this.OnBankLoaded;
				Delegate @delegate = Delegate.Remove(onBankLoaded, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBankLoaded)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003230")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public AudioEmitterBankLoader(Bank bank)
		{
			BankToLoad = bank;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003231")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF90", Offset = "0xA4B990", VA = "0x180A4CF90")]
		public void Load()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003232")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0B0", Offset = "0xA4BAB0", VA = "0x180A4D0B0")]
		public void Unload()
		{
			uint num = default(uint);
			referenceCount = (int)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003233")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0D0", Offset = "0xA4BAD0", VA = "0x180A4D0D0")]
		public void Update()
		{
			//Discarded unreachable code: IL_006d
			//IL_005f: Expected I4, but got I8
			if (referenceCount > 0 && !IsLoaded && !bankLoading)
			{
				Bank bank = BankToLoad;
				bankLoading = true;
				AkCallbackManager.BankCallback callback = OnSoundBankLoaded;
				bank.LoadAsync(callback);
			}
			if (IsLoaded && !bankLoading)
			{
				Bank bank2 = BankToLoad;
				referenceCount = 0;
				bank2.Unload();
				IsLoaded = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003234")]
		[Cpp2IlInjected.Address(RVA = "0xA4CFA0", Offset = "0xA4B9A0", VA = "0x180A4CFA0")]
		private void OnSoundBankLoaded(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie)
		{
			//Discarded unreachable code: IL_0046
			if (in_eLoadResult != AKRESULT.AK_Success)
			{
				string name = BankToLoad.Name;
				Debug.Log($"Failed to load audio bank {name} result {name}");
				bankLoading = false;
			}
			else
			{
				BankLoaded onBankLoaded = this.OnBankLoaded;
				IsLoaded = true;
				onBankLoaded(this);
				bankLoading = false;
			}
		}
	}
}
