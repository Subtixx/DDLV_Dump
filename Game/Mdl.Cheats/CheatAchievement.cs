using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000838")]
	[CreateAssetMenu]
	public class CheatAchievement : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x17000539")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatAchievement.cs", 12)]
		public string AchievementId
		{
			[Cpp2IlInjected.Token(Token = "0x6002504")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CAchievementId_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002505")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CAchievementId_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = "1";


		[Cpp2IlInjected.Token(Token = "0x1700053A")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatAchievement.cs", 15)]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4002DFC")]
		public uint AchievementProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6002506")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6002507")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		} = 100u;


		[Cpp2IlInjected.Token(Token = "0x6002508")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatAchievement.cs", 18)]
		public void SetAchievementProgress()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002509")]
		[Cpp2IlInjected.Address(RVA = "0xA7BE30", Offset = "0xA7A830", VA = "0x180A7BE30")]
		public CheatAchievement()
		{
		}//IL_0015: Expected I4, but got I8

	}
}
