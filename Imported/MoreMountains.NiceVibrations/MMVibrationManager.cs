using System;
using Cpp2IlInjected;
using UnityEngine;

namespace MoreMountains.NiceVibrations
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public static class MMVibrationManager
	{
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public static long LightDuration;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public static long MediumDuration;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public static long HeavyDuration;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public static int LightAmplitude;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public static int MediumAmplitude;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public static int HeavyAmplitude;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private static int _sdkVersion;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private static long[] _lightimpactPattern;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private static int[] _lightimpactPatternAmplitude;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private static long[] _mediumimpactPattern;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private static int[] _mediumimpactPatternAmplitude;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static long[] _HeavyimpactPattern;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private static int[] _HeavyimpactPatternAmplitude;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private static long[] _successPattern;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private static int[] _successPatternAmplitude;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private static long[] _warningPattern;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private static int[] _warningPatternAmplitude;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private static long[] _failurePattern;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private static int[] _failurePatternAmplitude;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private static AndroidJavaClass UnityPlayer;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private static AndroidJavaObject CurrentActivity;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private static AndroidJavaObject AndroidVibrator;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private static AndroidJavaClass VibrationEffectClass;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private static AndroidJavaObject VibrationEffect;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private static int DefaultAmplitude;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private static IntPtr AndroidVibrateMethodRawClass;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private static jvalue[] AndroidVibrateMethodRawClassParameters;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private static bool iOSHapticsInitialized;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public static bool Android()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public static bool iOS()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2F168F0", Offset = "0x2F152F0", VA = "0x182F168F0")]
		public static void Vibrate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2F16880", Offset = "0x2F15280", VA = "0x182F16880")]
		public static void Haptic(HapticTypes type, bool defaultToRegularVibrate = false)
		{
			if (defaultToRegularVibrate)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2F16710", Offset = "0x2F15110", VA = "0x182F16710")]
		public static void AndroidVibrate(long milliseconds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2F16760", Offset = "0x2F15160", VA = "0x182F16760")]
		public static void AndroidVibrate(long milliseconds, int amplitude)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2F16680", Offset = "0x2F15080", VA = "0x182F16680")]
		public static void AndroidVibrate(long[] pattern, int repeat)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2F167F0", Offset = "0x2F151F0", VA = "0x182F167F0")]
		public static void AndroidVibrate(long[] pattern, int[] amplitudes, int repeat)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2F16500", Offset = "0x2F14F00", VA = "0x182F16500")]
		public static void AndroidCancelVibrations()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2F16960", Offset = "0x2F15360", VA = "0x182F16960")]
		private static void VibrationEffectClassInitialization()
		{
			//IL_000f: Expected I8, but got O
			LightDuration = (long)new AndroidJavaClass("android.os.VibrationEffect");
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2F16560", Offset = "0x2F14F60", VA = "0x182F16560")]
		public static int AndroidSDKVersion()
		{
			//Discarded unreachable code: IL_0006, IL_003b
			return _sdkVersion;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private static void InstantiateFeedbackGenerators()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private static void ReleaseFeedbackGenerators()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private static void SelectionHaptic()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private static void SuccessHaptic()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private static void WarningHaptic()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private static void FailureHaptic()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private static void LightImpactHaptic()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private static void MediumImpactHaptic()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private static void HeavyImpactHaptic()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2F17390", Offset = "0x2F15D90", VA = "0x182F17390")]
		public static void iOSInitializeHaptics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2F173E0", Offset = "0x2F15DE0", VA = "0x182F173E0")]
		public static void iOSReleaseHaptics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public static bool HapticsSupported()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F17430", Offset = "0x2F15E30", VA = "0x182F17430")]
		public static void iOSTriggerHaptics(HapticTypes type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0")]
		public static string iOSSDKVersion()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2F16A50", Offset = "0x2F15450", VA = "0x182F16A50")]
		static MMVibrationManager()
		{
			//Discarded unreachable code: IL_02d7
			//IL_001b: Expected I8, but got O
			//IL_003b: Expected I8, but got O
			//IL_005b: Expected I8, but got O
			//IL_007b: Expected I8, but got O
			//IL_009b: Expected I8, but got O
			//IL_00bb: Expected I8, but got O
			//IL_0106: Expected I8, but got O
			//IL_0140: Expected I8, but got O
			//IL_018b: Expected I8, but got O
			//IL_01c5: Expected I8, but got O
			//IL_0254: Expected I8, but got O
			//IL_02b0: Expected I8, but got O
			//IL_02ba: Expected I8, but got I4
			//IL_02c1: Expected I8, but got I4
			//IL_02cf: Expected I8, but got I4
			long[] array = new long[2];
			long num = (array[1] = LightDuration);
			LightDuration = (long)array;
			int[] array2 = new int[2];
			int num2 = (array2[0] = LightAmplitude);
			LightDuration = (long)array2;
			long[] array3 = new long[2];
			long num3 = (array3[1] = MediumDuration);
			LightDuration = (long)array3;
			int[] array4 = new int[2];
			int num4 = (array4[0] = MediumAmplitude);
			LightDuration = (long)array4;
			long[] array5 = new long[2];
			long num5 = (array5[1] = HeavyDuration);
			LightDuration = (long)array5;
			int[] array6 = new int[2];
			int num6 = (array6[0] = HeavyAmplitude);
			LightDuration = (long)array6;
			long[] array7 = new long[4];
			long lightDuration = LightDuration;
			int length = array7.Length;
			array7[1] = lightDuration;
			long num7 = (array7[2] = LightDuration);
			long num8 = (array7[3] = HeavyDuration);
			LightDuration = (long)array7;
			int[] array8 = new int[4];
			int lightAmplitude = LightAmplitude;
			int length2 = array8.Length;
			array8[0] = lightAmplitude;
			int num9 = (array8[1] = HeavyAmplitude);
			LightDuration = (long)array8;
			long[] array9 = new long[4];
			long heavyDuration = HeavyDuration;
			int length3 = array9.Length;
			array9[1] = heavyDuration;
			long num10 = (array9[2] = LightDuration);
			long num11 = (array9[3] = MediumDuration);
			LightDuration = (long)array9;
			int[] array10 = new int[4];
			int heavyAmplitude = HeavyAmplitude;
			int length4 = array10.Length;
			array10[0] = heavyAmplitude;
			int num12 = (array10[1] = MediumAmplitude);
			LightDuration = (long)array10;
			long[] array11 = new long[8];
			long mediumDuration = MediumDuration;
			int length5 = array11.Length;
			array11[1] = mediumDuration;
			long num13 = (array11[2] = LightDuration);
			long num14 = (array11[3] = MediumDuration);
			long num15 = (array11[4] = LightDuration);
			long num16 = (array11[5] = HeavyDuration);
			long num17 = (array11[6] = LightDuration);
			long num18 = (array11[7] = LightDuration);
			LightDuration = (long)array11;
			int[] array12 = new int[8];
			int mediumAmplitude = MediumAmplitude;
			int length6 = array12.Length;
			array12[0] = mediumAmplitude;
			int num19 = (array12[1] = MediumAmplitude);
			int num20 = (array12[2] = HeavyAmplitude);
			int num21 = (array12[3] = LightAmplitude);
			LightDuration = (long)array12;
			int num22 = 0;
			LightDuration = num22;
			LightDuration = num22;
			AndroidVibrateMethodRawClass = (IntPtr)num22;
			LightDuration = num22;
			iOSHapticsInitialized = (byte)num22 != 0;
		}
	}
}
