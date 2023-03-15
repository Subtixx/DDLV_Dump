using Cpp2IlInjected;
using MoreMountains.NiceVibrations;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class VibrationsManager : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xD46320", Offset = "0xD44D20", VA = "0x180D46320")]
	private void Awake()
	{
		int num = 0;
		MMVibrationManager.iOSInitializeHaptics();
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xD46370", Offset = "0xD44D70", VA = "0x180D46370")]
	private void OnDisable()
	{
		int num = 0;
		MMVibrationManager.iOSReleaseHaptics();
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0xD465A0", Offset = "0xD44FA0", VA = "0x180D465A0")]
	public static void TriggerVibrate()
	{
		int num = 0;
		MMVibrationManager.Vibrate();
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0xD46500", Offset = "0xD44F00", VA = "0x180D46500")]
	public static void TriggerSelection()
	{
		int defaultToRegularVibrate = 0;
		MMVibrationManager.Haptic(HapticTypes.Selection, (byte)defaultToRegularVibrate != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xD46550", Offset = "0xD44F50", VA = "0x180D46550")]
	public static void TriggerSuccess()
	{
		int defaultToRegularVibrate = 0;
		MMVibrationManager.Haptic(HapticTypes.Success, (byte)defaultToRegularVibrate != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0xD465F0", Offset = "0xD44FF0", VA = "0x180D465F0")]
	public static void TriggerWarning()
	{
		int defaultToRegularVibrate = 0;
		MMVibrationManager.Haptic(HapticTypes.Warning, (byte)defaultToRegularVibrate != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xD463C0", Offset = "0xD44DC0", VA = "0x180D463C0")]
	public static void TriggerFailure()
	{
		int defaultToRegularVibrate = 0;
		MMVibrationManager.Haptic(HapticTypes.Failure, (byte)defaultToRegularVibrate != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0xD46460", Offset = "0xD44E60", VA = "0x180D46460")]
	public static void TriggerLightImpact()
	{
		int defaultToRegularVibrate = 0;
		MMVibrationManager.Haptic(HapticTypes.LightImpact, (byte)defaultToRegularVibrate != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xD464B0", Offset = "0xD44EB0", VA = "0x180D464B0")]
	public static void TriggerMediumImpact()
	{
		int defaultToRegularVibrate = 0;
		MMVibrationManager.Haptic(HapticTypes.MediumImpact, (byte)defaultToRegularVibrate != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xD46410", Offset = "0xD44E10", VA = "0x180D46410")]
	public static void TriggerHeavyImpact()
	{
		int defaultToRegularVibrate = 0;
		MMVibrationManager.Haptic(HapticTypes.HeavyImpact, (byte)defaultToRegularVibrate != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public VibrationsManager()
	{
	}
}
