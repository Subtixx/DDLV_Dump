using System.Linq.Expressions.Interpreter;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200099F")]
	public class TimePlayedComparator : IntComparator
	{
		[Cpp2IlInjected.Token(Token = "0x6005458")]
		[Cpp2IlInjected.Address(RVA = "0x7896C0", Offset = "0x7880C0", VA = "0x1807896C0")]
		public TimePlayedComparator(MiniProfile miniProfile)
		{
			((System.Linq.Expressions.Interpreter.LessThanInstruction.LessThanInt32)(object)this)._002Ector((object)miniProfile);
		}

		[Cpp2IlInjected.Token(Token = "0x6005459")]
		[Cpp2IlInjected.Address(RVA = "0x789620", Offset = "0x788020", VA = "0x180789620", Slot = "4")]
		public override bool IsOlder(MiniProfile other)
		{
			//Discarded unreachable code: IL_001e
			MiniProfile miniProfile = ((MiniProfileComparator)this).MiniProfile;
			int timePlayedInMinutes_ = other.timePlayedInMinutes_;
			int timePlayedInMinutes_2 = miniProfile.timePlayedInMinutes_;
			return IsOlder(timePlayedInMinutes_2, timePlayedInMinutes_);
		}

		[Cpp2IlInjected.Token(Token = "0x600545A")]
		[Cpp2IlInjected.Address(RVA = "0x7895F0", Offset = "0x787FF0", VA = "0x1807895F0", Slot = "5")]
		public override bool IsNewer(MiniProfile other)
		{
			//Discarded unreachable code: IL_001e
			MiniProfile miniProfile = ((MiniProfileComparator)this).MiniProfile;
			int timePlayedInMinutes_ = other.timePlayedInMinutes_;
			int timePlayedInMinutes_2 = miniProfile.timePlayedInMinutes_;
			return IsNewer(timePlayedInMinutes_2, timePlayedInMinutes_);
		}

		[Cpp2IlInjected.Token(Token = "0x600545B")]
		[Cpp2IlInjected.Address(RVA = "0x789650", Offset = "0x788050", VA = "0x180789650", Slot = "6")]
		public override string ToDebugStr()
		{
			//Discarded unreachable code: IL_0018
			//IL_0017: Expected O, but got I4
			int timePlayedInMinutes_ = ((MiniProfileComparator)this).MiniProfile.timePlayedInMinutes_;
			return $"TimePlayedInMin={timePlayedInMinutes_}";
		}
	}
}
