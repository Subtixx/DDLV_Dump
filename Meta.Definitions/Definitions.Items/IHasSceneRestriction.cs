using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006D1")]
	public interface IHasSceneRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x1700139A")]
		Item? SceneRestrictionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6004C18")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
