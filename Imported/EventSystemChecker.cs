using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EventSystemChecker : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2F10560", Offset = "0x2F0EF60", VA = "0x182F10560")]
	private void Awake()
	{
		//Discarded unreachable code: IL_002c
		if (!Object.FindObjectOfType<EventSystem>())
		{
			GameObject gameObject = new GameObject("EventSystem");
			EventSystem eventSystem = gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>().m_ForceModuleActive = true;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public EventSystemChecker()
	{
	}
}
