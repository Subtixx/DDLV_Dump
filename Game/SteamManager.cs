using System;
using System.Text;
using AOT;
using Cpp2IlInjected;
using Steamworks;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20000B2")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	protected static bool s_EverInitialized;

	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	protected static SteamManager s_instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	protected bool m_bInitialized;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	protected static SteamManager Instance
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xF616C0", Offset = "0xF600C0", VA = "0x180F616C0")]
		get
		{
			//Discarded unreachable code: IL_0028
			//IL_000f: Expected O, but got I4
			SteamManager steamManager = s_instance;
			int num = 0;
			if (!(steamManager == (UnityEngine.Object)num))
			{
				return s_instance;
			}
			return new GameObject("SteamManager").AddComponent<SteamManager>();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public static bool Initialized
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xF61540", Offset = "0xF5FF40", VA = "0x180F61540")]
		get
		{
			//Discarded unreachable code: IL_0027
			//IL_000f: Expected O, but got I4
			SteamManager steamManager = s_instance;
			int num = 0;
			if (!(steamManager == (UnityEngine.Object)num))
			{
			}
			return new GameObject("SteamManager").AddComponent<SteamManager>().m_bInitialized;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xF614B0", Offset = "0xF5FEB0", VA = "0x180F614B0")]
	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
		Debug.LogWarning($"[Steamworks] {pchDebugText}");
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xF61190", Offset = "0xF5FB90", VA = "0x180F61190")]
	[RuntimeInitializeOnLoadMethod]
	private static void InitOnPlayMode()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0xF60F40", Offset = "0xF5F940", VA = "0x180F60F40", Slot = "4")]
	protected virtual void Awake()
	{
		//Discarded unreachable code: IL_004f
		//IL_000f: Expected O, but got I4
		//IL_0018: Expected I4, but got O
		SteamManager steamManager = s_instance;
		int num = 0;
		if (!(steamManager != (UnityEngine.Object)num))
		{
			s_EverInitialized = (byte)(int)this != 0;
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			int num2 = 0;
			if (!(m_bInitialized = SteamAPI.Init()))
			{
				Debug.LogError("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", this);
			}
		}
		else
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0xF61310", Offset = "0xF5FD10", VA = "0x180F61310", Slot = "5")]
	protected unsafe virtual void OnEnable()
	{
		//IL_000f: Expected O, but got I4
		//IL_0018: Expected I4, but got O
		//IL_0038: Expected O, but got I4
		SteamManager steamManager = s_instance;
		int num = 0;
		if (steamManager == (UnityEngine.Object)num)
		{
			s_EverInitialized = (byte)(int)this != 0;
		}
		if (m_bInitialized && (long)m_SteamAPIWarningMessageHook == 0)
		{
			int num2 = default(int);
			SteamAPIWarningMessageHook_t steamAPIWarningMessageHook = new SteamAPIWarningMessageHook_t(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<int, StringBuilder, void>*/)(&SteamAPIDebugTextHook));
			num2 = 0;
			m_SteamAPIWarningMessageHook = steamAPIWarningMessageHook;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0xF61210", Offset = "0xF5FC10", VA = "0x180F61210", Slot = "6")]
	protected virtual void OnDestroy()
	{
		if (!(s_instance != this) && m_bInitialized)
		{
			int num = 0;
			SteamAPI.Shutdown();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0xF61530", Offset = "0xF5FF30", VA = "0x180F61530", Slot = "7")]
	protected virtual void Update()
	{
		if (m_bInitialized)
		{
			int num = 0;
			SteamAPI.RunCallbacks();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0xF61460", Offset = "0xF5FE60", VA = "0x180F61460")]
	public static void OpenInventoryStore(string url, bool useOverlay)
	{
		if (useOverlay)
		{
			int eMode = 0;
			SteamFriends.ActivateGameOverlayToWebPage(url, (EActivateGameOverlayToWebPageMode)eMode);
		}
		if (!useOverlay)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public SteamManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
	static SteamManager()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}
}
