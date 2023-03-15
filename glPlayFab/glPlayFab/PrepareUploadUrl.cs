using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PrepareUploadUrl
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000029")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000038")]
			public uint Version
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000039")]
			public int ImageFileSize
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x400003A")]
			public int ThumbFileSize
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Failed,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			MissingImage,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			UrlResultNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			ImageUrlNotFound
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000042")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public string Nonce
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CNonce_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CNonce_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4000045")]
			public uint Version
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public string ImageUploadUrl
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
				[CompilerGenerated]
				get
				{
					return _003CImageUploadUrl_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
				[CompilerGenerated]
				set
				{
					_003CImageUploadUrl_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public string ImageId
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				[CompilerGenerated]
				get
				{
					return _003CImageId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
				[CompilerGenerated]
				set
				{
					_003CImageId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public string ThumbUploadUrl
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
				[CompilerGenerated]
				get
				{
					return _003CThumbUploadUrl_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
				[CompilerGenerated]
				set
				{
					_003CThumbUploadUrl_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public string ThumbId
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
				[CompilerGenerated]
				get
				{
					return _003CThumbId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x63FB60", Offset = "0x63E560", VA = "0x18063FB60")]
				[CompilerGenerated]
				set
				{
					_003CThumbId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x763FD0", Offset = "0x7629D0", VA = "0x180763FD0")]
			public Result WithPlayFabError(PlayFabError error)
			{
				PlayFabError = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PrepareUploadUrl()
		{
		}
	}
}
