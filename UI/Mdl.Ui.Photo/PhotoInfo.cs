using System;
using Cpp2IlInjected;

namespace Mdl.Ui.Photo
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200093E")]
	public class PhotoInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003669")]
		public string backgroundName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400366A")]
		public string characterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400366B")]
		public string filterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400366C")]
		public bool useLogo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400366D")]
		public string photoType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400366E")]
		public string animationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400366F")]
		public string animationName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003670")]
		public string frameName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003671")]
		public string orientationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003672")]
		public string avatarState;

		[Cpp2IlInjected.Token(Token = "0x60039F6")]
		[Cpp2IlInjected.Address(RVA = "0x9C0670", Offset = "0x9BF070", VA = "0x1809C0670")]
		public PhotoInfo(PhotoInfo another)
		{
			string text = (backgroundName = another.backgroundName);
			string text2 = (characterName = another.characterName);
			string text3 = (filterName = another.filterName);
			bool flag = (useLogo = another.useLogo);
			string text4 = (photoType = another.photoType);
			string text5 = (animationType = another.animationType);
			string text6 = (animationName = another.animationName);
			string text7 = (frameName = another.frameName);
			string text8 = (orientationState = another.orientationState);
			string text9 = (avatarState = another.avatarState);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039F7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PhotoInfo()
		{
		}
	}
}
