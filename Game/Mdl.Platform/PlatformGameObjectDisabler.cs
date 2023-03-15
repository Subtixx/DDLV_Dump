using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002AC")]
	public class PlatformGameObjectDisabler : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400150A")]
		[SerializeField]
		private bool DisableForAllConsoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400150B")]
		[SerializeField]
		private List<RuntimePlatform> Platforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400150C")]
		[SerializeField]
		private List<GameObject> GameObjectToDeactivate;

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0xF13B70", Offset = "0xF12570", VA = "0x180F13B70")]
		public void Awake()
		{
			//Discarded unreachable code: IL_0020
			int num = 0;
			RuntimePlatform platform = Application.platform;
			List<RuntimePlatform> platforms = Platforms;
			bool flag = default(bool);
			if (flag)
			{
				int gameObjectActivation = 0;
				SetGameObjectActivation((byte)gameObjectActivation != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
		public static bool IsCurrentPlatformConsole()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0xF13B70", Offset = "0xF12570", VA = "0x180F13B70")]
		private void DoPlatformDisable()
		{
			//Discarded unreachable code: IL_0020
			int num = 0;
			RuntimePlatform platform = Application.platform;
			List<RuntimePlatform> platforms = Platforms;
			bool flag = default(bool);
			if (flag)
			{
				int gameObjectActivation = 0;
				SetGameObjectActivation((byte)gameObjectActivation != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0xF13BE0", Offset = "0xF125E0", VA = "0x180F13BE0")]
		private void SetGameObjectActivation(bool isActive)
		{
			//Discarded unreachable code: IL_0020
			List<GameObject> gameObjectToDeactivate = GameObjectToDeactivate;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				string text = default(string);
				string text2 = $"PlatformDisabler {text} set to {text}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PlatformGameObjectDisabler()
		{
		}
	}
}
