using Cpp2IlInjected;

namespace Mdl.Graphic.Sky
{
	[Cpp2IlInjected.Token(Token = "0x20004CF")]
	public struct GPUConstellationInfos
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4001E29")]
		public int remap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4001E2A")]
		public float alpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4001E2B")]
		public float atlasID;

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		public static int stride
		{
			[Cpp2IlInjected.Token(Token = "0x600152D")]
			[Cpp2IlInjected.Address(RVA = "0x8BC890", Offset = "0x8BB290", VA = "0x1808BC890")]
			get
			{
				return 12;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600152C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC880", Offset = "0x8BB280", VA = "0x1808BC880")]
		public GPUConstellationInfos(int remap, float alpha, float atlasID)
		{
			this.alpha = alpha;
			this.atlasID = atlasID;
			this.remap = remap;
		}
	}
}
