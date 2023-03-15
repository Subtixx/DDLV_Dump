using Cpp2IlInjected;
using Mdl.Systems;
using NaughtyAttributes;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006BB")]
	public abstract class SettingsMenuPanel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400260F")]
		[SerializeField]
		protected SettingsPanel _settingsPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002610")]
		[NaughtyAttributes.ReadOnly]
		public FocusNavigationElement LastFocusedChild;

		[Cpp2IlInjected.Token(Token = "0x17000653")]
		public SettingsPanel SettingsPanel
		{
			[Cpp2IlInjected.Token(Token = "0x6002B66")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return _settingsPanel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000654")]
		protected GameSettingsSystem Settings
		{
			[Cpp2IlInjected.Token(Token = "0x6002B67")]
			[Cpp2IlInjected.Address(RVA = "0x14259D0", Offset = "0x14243D0", VA = "0x1814259D0")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<GameSettingsSystem>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000655")]
		public abstract FocusNavigationElement FirstFocusNavigationElement
		{
			[Cpp2IlInjected.Token(Token = "0x6002B68")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6002B69")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LoadGameSettings();

		[Cpp2IlInjected.Token(Token = "0x6002B6A")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected SettingsMenuPanel()
		{
		}
	}
}
