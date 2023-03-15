using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000727")]
	public enum CharacterFacingBehavior
	{
		[Cpp2IlInjected.Token(Token = "0x4002986")]
		[Tooltip("Default behaviour, the character will run the turn animation")]
		Animated = 0,
		[Cpp2IlInjected.Token(Token = "0x4002987")]
		[Tooltip("This is occasionally useful for tasks whose animations will be overwritten by the turn animation")]
		NotAnimated = 1,
		[Cpp2IlInjected.Token(Token = "0x4002988")]
		Default = 0
	}
}
