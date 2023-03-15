using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010FB")]
	public enum FacePartType
	{
		[Cpp2IlInjected.Token(Token = "0x4004612")]
		[OriginalName("FacePartType_Eyes")]
		Eyes,
		[Cpp2IlInjected.Token(Token = "0x4004613")]
		[OriginalName("FacePartType_Nose")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4004614")]
		[OriginalName("FacePartType_Mouth")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4004615")]
		[OriginalName("FacePartType_Jaw")]
		Jaw
	}
}
