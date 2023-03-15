using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

[Cpp2IlInjected.Token(Token = "0x200000D")]
[RequireComponent(typeof(Image))]
public class ForcedReset : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2F117D0", Offset = "0x2F101D0", VA = "0x182F117D0")]
	private void Update()
	{
		//Discarded unreachable code: IL_0020
		if (CrossPlatformInputManager.activeInput.GetButtonDown("ResetObject"))
		{
			Scene sceneAt = SceneManager.GetSceneAt(0);
			string sceneName = default(string);
			SceneManager.LoadScene(sceneName);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public ForcedReset()
	{
	}
}
