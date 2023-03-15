using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x200083F")]
	[CreateAssetMenu]
	public class CheatHeptic : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600252A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5C0", Offset = "0xA7AFC0", VA = "0x180A7C5C0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatHeptic.cs", 9)]
		public void Vibrate()
		{
			int num = 0;
			VibrationsManager.TriggerVibrate();
		}

		[Cpp2IlInjected.Token(Token = "0x600252B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5A0", Offset = "0xA7AFA0", VA = "0x180A7C5A0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatHeptic.cs", 15)]
		public void Selection()
		{
			int num = 0;
			VibrationsManager.TriggerSelection();
		}

		[Cpp2IlInjected.Token(Token = "0x600252C")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5B0", Offset = "0xA7AFB0", VA = "0x180A7C5B0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatHeptic.cs", 20)]
		public void Success()
		{
			int num = 0;
			VibrationsManager.TriggerSuccess();
		}

		[Cpp2IlInjected.Token(Token = "0x600252D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C5D0", Offset = "0xA7AFD0", VA = "0x180A7C5D0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatHeptic.cs", 25)]
		public void Warning()
		{
			int num = 0;
			VibrationsManager.TriggerWarning();
		}

		[Cpp2IlInjected.Token(Token = "0x600252E")]
		[Cpp2IlInjected.Address(RVA = "0xA7C560", Offset = "0xA7AF60", VA = "0x180A7C560")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatHeptic.cs", 30)]
		public void Failure()
		{
			int num = 0;
			VibrationsManager.TriggerFailure();
		}

		[Cpp2IlInjected.Token(Token = "0x600252F")]
		[Cpp2IlInjected.Address(RVA = "0xA7C580", Offset = "0xA7AF80", VA = "0x180A7C580")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatHeptic.cs", 35)]
		public void LightImpact()
		{
			int num = 0;
			VibrationsManager.TriggerLightImpact();
		}

		[Cpp2IlInjected.Token(Token = "0x6002530")]
		[Cpp2IlInjected.Address(RVA = "0xA7C590", Offset = "0xA7AF90", VA = "0x180A7C590")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatHeptic.cs", 40)]
		public void MediumImpac()
		{
			int num = 0;
			VibrationsManager.TriggerMediumImpact();
		}

		[Cpp2IlInjected.Token(Token = "0x6002531")]
		[Cpp2IlInjected.Address(RVA = "0xA7C570", Offset = "0xA7AF70", VA = "0x180A7C570")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatHeptic.cs", 45)]
		public void HeavyImpact()
		{
			int num = 0;
			VibrationsManager.TriggerHeavyImpact();
		}

		[Cpp2IlInjected.Token(Token = "0x6002532")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public CheatHeptic()
		{
		}
	}
}
