using System.Threading;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Activities;
using Mdl.Audio;
using Mdl.Systems;
using Meta;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[Description("start hangout with avatar")]
	[Category("Hangout")]
	public class StartHangout : MdlActionTask
	{
		[Cpp2IlInjected.Token(Token = "0x17000118")]
		private HangoutSystem HangoutSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0xF5CB10", Offset = "0xF5B510", VA = "0x180F5CB10")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<HangoutSystem>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xF5C850", Offset = "0xF5B250", VA = "0x180F5C850", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0068
			//IL_005b: Expected O, but got I4
			Debug.LogWarning("START HANGOUT");
			SystemRoot.Instance.GetSystem<AudioManager>().SetHangout(isStart: true);
			((object)this)._002Ector();
			StartHangoutWithCharacter.Types.Request request = new StartHangoutWithCharacter.Types.Request();
			int num = (request.characterID_ = base.CharacterComponent.MetaCharacter.Data.iD_);
			HangoutSystem system = SystemRoot.Instance.GetSystem<HangoutSystem>();
			int num2 = 0;
			system.StartHangout(request, (CancellationToken)num2, true).FireAndForgetTask();
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public StartHangout()
		{
		}
	}
}
