using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000846")]
	[CreateAssetMenu]
	public class CheatTest : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000847")]
		public enum SomeEnumType
		{
			[Cpp2IlInjected.Token(Token = "0x4002E24")]
			Value1,
			[Cpp2IlInjected.Token(Token = "0x4002E25")]
			Value2,
			[Cpp2IlInjected.Token(Token = "0x4002E26")]
			Value3
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E1B")]
		public float someFloat = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002E1C")]
		[Range(0f, 1f)]
		public float someFloatWithRange = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E1D")]
		public int someInt = 100;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002E1E")]
		public int someIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002E1F")]
		[Range(1f, 100f)]
		public int someIntWithRange = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002E20")]
		public string someString = "patate";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002E21")]
		public SomeEnumType someEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002E22")]
		public bool someToggle;

		[Cpp2IlInjected.Token(Token = "0x1700055D")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTest.cs", 35)]
		public float SomeFloat
		{
			[Cpp2IlInjected.Token(Token = "0x6002583")]
			[Cpp2IlInjected.Address(RVA = "0x837330", Offset = "0x835D30", VA = "0x180837330")]
			get
			{
				return someFloat;
			}
			[Cpp2IlInjected.Token(Token = "0x6002584")]
			[Cpp2IlInjected.Address(RVA = "0x837350", Offset = "0x835D50", VA = "0x180837350")]
			set
			{
				someFloat = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055E")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTest.cs", 42)]
		public float SomeFloatWithRange
		{
			[Cpp2IlInjected.Token(Token = "0x6002585")]
			[Cpp2IlInjected.Address(RVA = "0x837320", Offset = "0x835D20", VA = "0x180837320")]
			get
			{
				return someFloatWithRange;
			}
			[Cpp2IlInjected.Token(Token = "0x6002586")]
			[Cpp2IlInjected.Address(RVA = "0x837340", Offset = "0x835D40", VA = "0x180837340")]
			set
			{
				someFloatWithRange = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055F")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTest.cs", 49)]
		public int SomeInt
		{
			[Cpp2IlInjected.Token(Token = "0x6002587")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return someInt;
			}
			[Cpp2IlInjected.Token(Token = "0x6002588")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				someInt = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000560")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTest.cs", 56)]
		public int SomeIntWithRange
		{
			[Cpp2IlInjected.Token(Token = "0x6002589")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get
			{
				return someIntWithRange;
			}
			[Cpp2IlInjected.Token(Token = "0x600258A")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			set
			{
				someIntWithRange = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000561")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTest.cs", 63)]
		public string SomeString
		{
			[Cpp2IlInjected.Token(Token = "0x600258B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			get
			{
				return someString;
			}
			[Cpp2IlInjected.Token(Token = "0x600258C")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			set
			{
				someString = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000562")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTest.cs", 70)]
		public SomeEnumType SomeEnum
		{
			[Cpp2IlInjected.Token(Token = "0x600258D")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get
			{
				return someEnum;
			}
			[Cpp2IlInjected.Token(Token = "0x600258E")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set
			{
				someEnum = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000563")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTest.cs", 77)]
		public bool SomeToggle
		{
			[Cpp2IlInjected.Token(Token = "0x600258F")]
			[Cpp2IlInjected.Address(RVA = "0xA157F0", Offset = "0xA141F0", VA = "0x180A157F0")]
			get
			{
				return someToggle;
			}
			[Cpp2IlInjected.Token(Token = "0x6002590")]
			[Cpp2IlInjected.Address(RVA = "0xA15800", Offset = "0xA14200", VA = "0x180A15800")]
			set
			{
				someToggle = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002591")]
		[Cpp2IlInjected.Address(RVA = "0xA7FAA0", Offset = "0xA7E4A0", VA = "0x180A7FAA0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTest.cs", 84)]
		public void SomeMethod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6002592")]
		[Cpp2IlInjected.Address(RVA = "0xA7FAF0", Offset = "0xA7E4F0", VA = "0x180A7FAF0")]
		public CheatTest()
		{
		}//IL_0020: Expected I4, but got I8
		//IL_002a: Expected I4, but got I8

	}
}
