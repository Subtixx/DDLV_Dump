using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Systems;
using Mdl.Ui.Widgets;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000206")]
	public class IntroducableComponent : Introducable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40008E7")]
		[SerializeField]
		private UnityEvent _onIntroduced;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40008E8")]
		[SerializeField]
		private UnityEvent _onNotIntroduced;

		[Cpp2IlInjected.Token(Token = "0x6000CEC")]
		[Cpp2IlInjected.Address(RVA = "0xD27DA0", Offset = "0xD267A0", VA = "0x180D27DA0", Slot = "4")]
		public override Task Introduce()
		{
			_onIntroduced?.Invoke();
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0xD27E00", Offset = "0xD26800", VA = "0x180D27E00")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0039
			ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
			HudApparitionPhases phases = phase;
			if (!player_.HasHudApparition(phases))
			{
			}
			_onIntroduced?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public IntroducableComponent()
		{
		}
	}
}
