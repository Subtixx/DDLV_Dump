using System.ComponentModel;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Rewired
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AddComponentMenu("Rewired/Input Manager")]
	public sealed class InputManager : InputManager_Base
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool ignoreRecompile;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1E955F0", Offset = "0x1E93FF0", VA = "0x181E955F0", Slot = "4")]
		protected override void OnInitialized()
		{
			UnsubscribeEvents();
			SceneManager.add_sceneLoaded((UnityAction<, >)(object)new UnityAction<T0, T1>(OnSceneLoaded));
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1E955E0", Offset = "0x1E93FE0", VA = "0x181E955E0", Slot = "5")]
		protected override void OnDeinitialized()
		{
			UnsubscribeEvents();
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1E95530", Offset = "0x1E93F30", VA = "0x181E95530", Slot = "6")]
		protected override void DetectPlatform()
		{
			//IL_002b: Expected I4, but got I8
			//IL_0034: Expected I4, but got I8
			//IL_003d: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			scriptingBackend = (ScriptingBackend)num;
			editorPlatform = (EditorPlatform)num;
			webplayerPlatform = (WebplayerPlatform)num;
			isEditor = (byte)num != 0;
			int num3 = 0;
			platform = Platform.Windows;
			scriptingBackend = ScriptingBackend.IL2CPP;
			scriptingAPILevel = ScriptingAPILevel.NetStandard20;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		protected override void CheckRecompile()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1E95590", Offset = "0x1E93F90", VA = "0x181E95590", Slot = "8")]
		protected override IExternalTools GetExternalTools()
		{
			ExternalTools externalTools = default(ExternalTools);
			externalTools.Destroy();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1E95470", Offset = "0x1E93E70", VA = "0x181E95470")]
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			if (Regex.IsMatch(deviceName, searchPattern, RegexOptions.IgnoreCase))
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1E955F0", Offset = "0x1E93FF0", VA = "0x181E955F0")]
		private void SubscribeEvents()
		{
			UnsubscribeEvents();
			SceneManager.add_sceneLoaded((UnityAction<, >)(object)new UnityAction<T0, T1>(OnSceneLoaded));
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1E956C0", Offset = "0x1E940C0", VA = "0x181E956C0")]
		private void UnsubscribeEvents()
		{
			SceneManager.remove_sceneLoaded((UnityAction<, >)(object)new UnityAction<T0, T1>(OnSceneLoaded));
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1E956B0", Offset = "0x1E940B0", VA = "0x181E956B0")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			OnSceneLoaded();
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1E95770", Offset = "0x1E94170", VA = "0x181E95770")]
		public InputManager()
		{
		}
	}
}
