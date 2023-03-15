using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Meta.Online;
using Meta.Util;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200004E")]
public class SettingScope : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public const int PRIORITY_LOADING = 80;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public const int PRIORITY_PAUSE = 85;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public const int PRIORITY_MENU = 90;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public const int PRIORITY_VIDEO = 95;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public const int PRIORITY_DEFAULT = 100;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static List<SettingScope> ActiveScopes = (List<SettingScope>)(object)new List<T>();

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static SettingScope _enableMenuLimiter;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40001E6")]
	public int Priority
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x40001E7")]
	public int? TargetFrameRate
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xF4C7E0", Offset = "0xF4B1E0", VA = "0x180F4C7E0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xF4CB30", Offset = "0xF4B530", VA = "0x180F4CB30")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x40001E8")]
	public int? VSyncCount
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xAC86D0", Offset = "0xAC70D0", VA = "0x180AC86D0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xAC87A0", Offset = "0xAC71A0", VA = "0x180AC87A0")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x24"), Cpp2IlInjected.Token(Token = "0x40001E9")]
	public ThreadPriority? BackgroundLoadingPriority
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xF4C770", Offset = "0xF4B170", VA = "0x180F4C770")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xF4C7F0", Offset = "0xF4B1F0", VA = "0x180F4C7F0")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[field: Cpp2IlInjected.FieldOffset(Offset = "0x2C"), Cpp2IlInjected.Token(Token = "0x40001EA")]
	public bool Enabled
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xDD7720", Offset = "0xDD6120", VA = "0x180DD7720")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xDD7730", Offset = "0xDD6130", VA = "0x180DD7730")]
		private set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string DebugName
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
		[CompilerGenerated]
		get
		{
			return _003CDebugName_003Ek__BackingField;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
		[CompilerGenerated]
		private set
		{
			_003CDebugName_003Ek__BackingField = value;
			/*Error: Unexpected end of block*/;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public static bool EnableMenuLimiter
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xF4C780", Offset = "0xF4B180", VA = "0x180F4C780")]
		get
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xF4C800", Offset = "0xF4B200", VA = "0x180F4C800")]
		set
		{
			//Discarded unreachable code: IL_0057
			//IL_0022: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			if (!value)
			{
				SettingScope enableMenuLimiter = _enableMenuLimiter;
				if (enableMenuLimiter != null)
				{
					if (((List<T>)(object)ActiveScopes).Remove((T)enableMenuLimiter))
					{
						ApplyTargetFrameRateSetting((GraphicSettingsData)0);
						int num = 0;
						ApplyVSyncSetting((GameSettings)0, (GraphicSettingsData)num);
						int num2 = 0;
						ApplyBackgroundLoadingPrioritySetting();
					}
					enableMenuLimiter.Log("End SettingScope:");
				}
				ActiveScopes = (List<SettingScope>)0;
			}
			int num3 = 0;
			string text = default(string);
			ActiveScopes = (List<SettingScope>)(object)new SettingScope(90, (Nullable<>)num3, (Nullable<>)num3, (Nullable<>)num3, text);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0xF4C560", Offset = "0xF4AF60", VA = "0x180F4C560")]
	public SettingScope(int priority = 100, [Optional] int? targetFps, [Optional] int? vSyncCount, [Optional] ThreadPriority? threadPriority, [Optional] string debugName)
	{
		//Discarded unreachable code: IL_006b
		//IL_000d: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_004f: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		BackgroundLoadingPriority = (ThreadPriority?)(object)0;
		Enabled = true;
		Priority = priority;
		VSyncCount = vSyncCount;
		TargetFrameRate = targetFps;
		DebugName = (string)0;
		if (!((List<T>)(object)ActiveScopes).Contains((T)this))
		{
			((List<T>)(object)ActiveScopes).Add((T)this);
			ApplyTargetFrameRateSetting((GraphicSettingsData)0);
			int num = 0;
			ApplyVSyncSetting((GameSettings)0, (GraphicSettingsData)num);
			int num2 = 0;
			ApplyBackgroundLoadingPrioritySetting();
		}
		Log("New SettingScope:");
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0xF4BCC0", Offset = "0xF4A6C0", VA = "0x180F4BCC0", Slot = "4")]
	public void Dispose()
	{
		//Discarded unreachable code: IL_0030
		//IL_0014: Expected O, but got I4
		//IL_001d: Expected O, but got I4
		//IL_001d: Expected O, but got I4
		if (((List<T>)(object)ActiveScopes).Remove((T)this))
		{
			ApplyTargetFrameRateSetting((GraphicSettingsData)0);
			int num = 0;
			ApplyVSyncSetting((GameSettings)0, (GraphicSettingsData)num);
			int num2 = 0;
			ApplyBackgroundLoadingPrioritySetting();
		}
		Log("End SettingScope:");
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xF4C380", Offset = "0xF4AD80", VA = "0x180F4C380")]
	public void SetEnabled(bool value)
	{
		//IL_0016: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		if (Enabled != value)
		{
			Enabled = value;
			ApplyTargetFrameRateSetting((GraphicSettingsData)0);
			int num = 0;
			ApplyVSyncSetting((GameSettings)0, (GraphicSettingsData)num);
			int num2 = 0;
			ApplyBackgroundLoadingPrioritySetting();
			string text = "Disabled";
			if (Enabled)
			{
				text = "Enabled";
			}
			string prefix = text + " SettingScope:";
			Log(prefix);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0xF4BE30", Offset = "0xF4A830", VA = "0x180F4BE30")]
	private void Log(string prefix = "")
	{
		//IL_0014: Expected O, but got I4
		//IL_0031: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		int num = default(int);
		int num2 = default(int);
		string text4 = default(string);
		ThreadPriority threadPriority = default(ThreadPriority);
		string text6 = default(string);
		do
		{
			if ((object)TargetFrameRate != null)
			{
				string text = $" TargetFrameRate: {num} ";
				string text2 = prefix + text;
			}
			if ((object)VSyncCount != null)
			{
				string text3 = $" VSyncCount: {num2} ";
				text4 = prefix + text3;
			}
			if ((object)BackgroundLoadingPriority != null)
			{
				string text5 = $" BackgroundLoadingPriority: {threadPriority} ";
				text6 = text4 + text5;
			}
		}
		while (string.IsNullOrEmpty(DebugName));
		string text7 = DebugName;
		Debug.Log(text6 + " [" + text7 + "]");
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xF4B150", Offset = "0xF49B50", VA = "0x180F4B150")]
	public static void ApplyAll()
	{
		//IL_0006: Expected O, but got I4
		//IL_000f: Expected O, but got I4
		//IL_000f: Expected O, but got I4
		ApplyTargetFrameRateSetting((GraphicSettingsData)0);
		int num = 0;
		ApplyVSyncSetting((GameSettings)0, (GraphicSettingsData)num);
		int num2 = 0;
		ApplyBackgroundLoadingPrioritySetting();
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0xF4B4B0", Offset = "0xF49EB0", VA = "0x180F4B4B0")]
	public static void ApplyTargetFrameRateSetting([Optional] GraphicSettingsData setting)
	{
		//Discarded unreachable code: IL_0081, IL_0087, IL_008d
		//IL_002c: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_0062: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		int num = 0;
		if ((object)setting == null)
		{
		}
		int num2 = 0;
		List<SettingScope> activeScopes = ActiveScopes;
		bool flag = default(bool);
		if (flag)
		{
			while (!flag)
			{
			}
			if (num2 == 0)
			{
			}
		}
		if (!flag)
		{
			int num3 = 0;
			if (setting == (UnityEngine.Object)num3)
			{
				return;
			}
		}
		int num4 = 0;
		int num5 = default(int);
		if (Application.targetFrameRate != num5)
		{
			int num6 = 0;
			int targetFrameRate = Application.targetFrameRate;
			if (string.IsNullOrEmpty((string)0))
			{
			}
			int num7 = 0;
			string arg = " [" + (string)num7 + "]";
			Debug.Log($"SETTING TargetFrameRate: {targetFrameRate} => {targetFrameRate}{arg}");
			Application.targetFrameRate = num5;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0xF4B8A0", Offset = "0xF4A2A0", VA = "0x180F4B8A0")]
	public static void ApplyVSyncSetting([Optional] GameSettings gameSetting, [Optional] GraphicSettingsData setting)
	{
		//Discarded unreachable code: IL_0097, IL_009d
		//IL_0079: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		int num = 0;
		int num2 = 0;
		if (Application.platform == RuntimePlatform.OSXPlayer)
		{
			return;
		}
		Client client = default(Client);
		int num3 = default(int);
		if (gameSetting == null)
		{
			if (client != null)
			{
			}
			num3 = 0;
		}
		if ((object)setting == null)
		{
		}
		int num4 = 0;
		List<SettingScope> activeScopes = ActiveScopes;
		bool flag = default(bool);
		if (flag)
		{
			while (!flag)
			{
			}
			if (num4 == 0)
			{
			}
		}
		if (!flag && num3 == 0)
		{
			return;
		}
		if (client != null)
		{
		}
		int num5 = 0;
		int num6 = 0;
		if (QualitySettings.vSyncCount != 1)
		{
			int num7 = 0;
			int vSyncCount = QualitySettings.vSyncCount;
			int num8 = 0;
			int num9 = default(int);
			if (num9 != 0)
			{
			}
			int num10 = 0;
			string arg = " [" + (string)num10 + "]";
			Debug.Log($"SETTING vSyncCount: {vSyncCount} => {num9}{arg}");
			QualitySettings.vSyncCount = 1;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0xF4C060", Offset = "0xF4AA60", VA = "0x180F4C060")]
	public static ThreadPriority Map(MetaThreadPriority prio, ThreadPriority defaultPrio)
	{
		if (prio == MetaThreadPriority.Low)
		{
		}
		int num = 0;
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0xF4B1B0", Offset = "0xF49BB0", VA = "0x180F4B1B0")]
	public static void ApplyBackgroundLoadingPrioritySetting()
	{
		//Discarded unreachable code: IL_0065, IL_006b
		//IL_0047: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		int num = 0;
		List<SettingScope> activeScopes = ActiveScopes;
		bool flag = default(bool);
		if (flag)
		{
			while (!flag)
			{
			}
			if (num == 0)
			{
			}
		}
		int num2 = 0;
		if (Application.backgroundLoadingPriority != ThreadPriority.Normal)
		{
			int num3 = 0;
			ThreadPriority backgroundLoadingPriority = Application.backgroundLoadingPriority;
			int num4 = 0;
			ThreadPriority threadPriority = default(ThreadPriority);
			if (threadPriority != 0)
			{
			}
			int num5 = 0;
			string arg = " [" + (string)num5 + "]";
			Debug.Log($"SETTING BackgroundLoadingPriority: {backgroundLoadingPriority} => {threadPriority}{arg}");
			Application.backgroundLoadingPriority = ThreadPriority.Normal;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0xF4C090", Offset = "0xF4AA90", VA = "0x180F4C090")]
	private static void OnScopeAdded(SettingScope scope)
	{
		//Discarded unreachable code: IL_0031
		//IL_001f: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		if (!((List<T>)(object)ActiveScopes).Contains((T)scope))
		{
			((List<T>)(object)ActiveScopes).Add((T)scope);
			ApplyTargetFrameRateSetting((GraphicSettingsData)0);
			int num = 0;
			ApplyVSyncSetting((GameSettings)0, (GraphicSettingsData)num);
			int num2 = 0;
			ApplyBackgroundLoadingPrioritySetting();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0xF4C270", Offset = "0xF4AC70", VA = "0x180F4C270")]
	private static void OnScopeRemoved(SettingScope scope)
	{
		//Discarded unreachable code: IL_0026
		//IL_0014: Expected O, but got I4
		//IL_001d: Expected O, but got I4
		//IL_001d: Expected O, but got I4
		if (((List<T>)(object)ActiveScopes).Remove((T)scope))
		{
			ApplyTargetFrameRateSetting((GraphicSettingsData)0);
			int num = 0;
			ApplyVSyncSetting((GameSettings)0, (GraphicSettingsData)num);
			int num2 = 0;
			ApplyBackgroundLoadingPrioritySetting();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0xF4C1D0", Offset = "0xF4ABD0", VA = "0x180F4C1D0")]
	private static void OnScopeChanged()
	{
		//IL_0006: Expected O, but got I4
		//IL_000f: Expected O, but got I4
		//IL_000f: Expected O, but got I4
		ApplyTargetFrameRateSetting((GraphicSettingsData)0);
		int num = 0;
		ApplyVSyncSetting((GameSettings)0, (GraphicSettingsData)num);
		int num2 = 0;
		ApplyBackgroundLoadingPrioritySetting();
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0xF4C4E0", Offset = "0xF4AEE0", VA = "0x180F4C4E0")]
	static SettingScope()
	{
		/*Error: Unexpected end of block*/;
	}
}
