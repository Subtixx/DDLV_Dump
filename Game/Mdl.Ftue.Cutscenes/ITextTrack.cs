using System.Collections.Generic;
using Cpp2IlInjected;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005CB")]
	public interface ITextTrack
	{
		[Cpp2IlInjected.Token(Token = "0x60019D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetTrackText(Dictionary<string, string> textForTracks, bool localizeText);
	}
}
