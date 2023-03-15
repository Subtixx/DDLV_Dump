using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public class LikeNewsFeed
	{
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public string UgcItemId
			{
				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CUgcItemId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CUgcItemId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public string CreatorId
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CCreatorId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CCreatorId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			ProfileNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			UgcItemNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			UgcProfileNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			UpdateStatsFailed,
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			Failed
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000516")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600034B")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public string UgcItemId
			{
				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CUgcItemId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600034E")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CUgcItemId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000518")]
			public int BonusSocialRewards
			{
				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000350")]
				[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		public class ResultReceiver
		{
			[Cpp2IlInjected.Token(Token = "0x17000090")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000519")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000353")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public ResultReceiver WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ResultReceiver()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LikeNewsFeed()
		{
		}
	}
}
