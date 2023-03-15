using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Avatar
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000A58")]
	public class ConditionalBlendShape
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003933")]
		public bool expanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4003934")]
		public bool avatarIsMale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4003935")]
		public bool avatarIsFemale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003936")]
		public string blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003937")]
		public bool whenWearing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003938")]
		public ClothingItemType clothingType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003939")]
		public List<BlendShapeCondition> conditions = (List<BlendShapeCondition>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6003028")]
		[Cpp2IlInjected.Address(RVA = "0xA8E500", Offset = "0xA8CF00", VA = "0x180A8E500")]
		public ConditionalBlendShape()
		{
		}
	}
}
