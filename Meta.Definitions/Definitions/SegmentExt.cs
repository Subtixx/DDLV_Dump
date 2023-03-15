using Cpp2IlInjected;
using Definitions.Conditions;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	public static class SegmentExt
	{
		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x3847F40", Offset = "0x3846940", VA = "0x183847F40")]
		public static ConditionsList GetConditions(this ISegment segment)
		{
			//Discarded unreachable code: IL_003a
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			ConditionsList conditionsList = new ConditionsList();
			if ((object)typeof(ISegment).TypeHandle != null)
			{
				if ((long)conditionsList == 1)
				{
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_0037;
					}
					string text = text + text;
					num += 312;
				}
				if (num != 2)
				{
				}
			}
			goto IL_0037;
			IL_0037:
			ConditionsList result = default(ConditionsList);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x3847E20", Offset = "0x3846820", VA = "0x183847E20")]
		public static ConditionsList GetConditions(this FilterType filterType)
		{
			//Discarded unreachable code: IL_002f
			ConditionsList result = new ConditionsList();
			if (filterType != null)
			{
				FilterType.TypeOneofCase typeCase_ = filterType.typeCase_;
				if (typeCase_ == FilterType.TypeOneofCase.SegmentId)
				{
					string segmentId = filterType.SegmentId;
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_002d;
					}
				}
				if (typeCase_ == FilterType.TypeOneofCase.Conditions)
				{
					ConditionsList conditions = filterType.Conditions;
				}
			}
			goto IL_002d;
			IL_002d:
			return result;
		}
	}
}
