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
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[Category("Hangout")]
	[Description("stop hangout with avatar")]
	public class StopHangout : MdlActionTask
	{
		[Cpp2IlInjected.Token(Token = "0x17000119")]
		private HangoutSystem HangoutSystem
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62350", VA = "0x180F63950")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.GetSystem<HangoutSystem>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xF63690", Offset = "0xF62090", VA = "0x180F63690", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_006e
			//IL_0061: Expected O, but got I4
			Debug.LogWarning("END HANGOUT");
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			int hangout = 0;
			system.SetHangout((byte)hangout != 0);
			((object)this)._002Ector();
			StopHangoutWithCharacter.Types.Request request = new StopHangoutWithCharacter.Types.Request();
			int num = (request.characterID_ = base.CharacterComponent.MetaCharacter.Data.iD_);
			HangoutSystem system2 = SystemRoot.Instance.GetSystem<HangoutSystem>();
			int num2 = 0;
			system2.StopHangout(request, (CancellationToken)num2, true).FireAndForgetTask();
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public StopHangout()
		{
		}
	}
}
