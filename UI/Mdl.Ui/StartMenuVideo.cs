using Cpp2IlInjected;
using UnityEngine.Video;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200072C")]
	public class StartMenuVideo : IntroVideoMenu
	{
		[Cpp2IlInjected.Token(Token = "0x6002D98")]
		[Cpp2IlInjected.Address(RVA = "0x860040", Offset = "0x85EA40", VA = "0x180860040", Slot = "39")]
		public override void OnSkipClickedHandler()
		{
			//Discarded unreachable code: IL_0024
			//IL_0022: Expected O, but got I4
			int num = 0;
			if (!UiRoot.Instance.CutSceneSkipper.gameObject.activeInHierarchy)
			{
				int num2 = 0;
				base.Video_loopPointReached((VideoPlayer)num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002D99")]
		[Cpp2IlInjected.Address(RVA = "0x8600A0", Offset = "0x85EAA0", VA = "0x1808600A0")]
		public StartMenuVideo()
		{
		}
	}
}
