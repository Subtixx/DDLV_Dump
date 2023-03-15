using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Photo
{
	[Cpp2IlInjected.Token(Token = "0x200094F")]
	public class PhotoViewAdditionalParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003715")]
		public bool isInCrouchMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4003716")]
		public bool initFromAvatarRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003717")]
		public Transform freeCamStartTransform;

		[Cpp2IlInjected.Token(Token = "0x6003A5E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PhotoViewAdditionalParameters()
		{
		}
	}
}
