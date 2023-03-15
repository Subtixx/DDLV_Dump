using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Events
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal static class EventBatcher
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly IReadOnlyList<string> IgnoreParamsForComparison;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x28C0A70", Offset = "0x28BF470", VA = "0x1828C0A70")]
		[IteratorStateMachine(typeof(_003CBatch_003Ed__0))]
		public static IEnumerable<StandardEvent> Batch(IEnumerable<StandardEvent> events)
		{
			//IL_0012: Expected I4, but got I8
			int num = 0;
			_003CBatch_003Ed__0 _003CBatch_003Ed__ = default(_003CBatch_003Ed__0);
			_003CBatch_003Ed__._003C_003E1__state = -2;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003CBatch_003Ed__._003C_003E3__events = events;
			_003CBatch_003Ed__._003C_003El__initialThreadId = currentManagedThreadId;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x28C0AE0", Offset = "0x28BF4E0", VA = "0x1828C0AE0")]
		private static string ComputeBatchingKey(StandardEvent @event)
		{
			//Discarded unreachable code: IL_00b1
			//IL_009b: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			StringBuilder stringBuilder = new StringBuilder(128);
			int _003CType_003Ek__BackingField = @event.EventData.Type;
			StringBuilder stringBuilder2 = stringBuilder.Append(_003CType_003Ek__BackingField);
			StringBuilder stringBuilder3 = stringBuilder.Append(" # ");
			Dictionary<string, object> _003CUserData_003Ek__BackingField = @event.EventData.UserData;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				if (@event.SmartBatchProperties != null)
				{
					bool flag3 = default(bool);
					while (flag3)
					{
					}
				}
				StringBuilder stringBuilder4 = stringBuilder.Append(" # ");
				StringBuilder stringBuilder5 = stringBuilder.Append(" # ");
			}
			if (flag)
			{
				StringBuilder stringBuilder6 = stringBuilder.Append("sbp");
				StringBuilder stringBuilder7 = stringBuilder.Append(" # ");
				bool flag4 = default(bool);
				if (flag4)
				{
					StringBuilder stringBuilder8 = stringBuilder.Append((string)num2);
					StringBuilder stringBuilder9 = stringBuilder.Append(" # ");
				}
			}
			return stringBuilder.ToString();
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x28C0EE0", Offset = "0x28BF8E0", VA = "0x1828C0EE0")]
		private static object Sum(object obj1, object obj2)
		{
			//Discarded unreachable code: IL_00c1
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected I8, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected I8, but got Unknown
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected I4, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected I4, but got Unknown
			int num = 0;
			if (obj1 != null)
			{
				if (obj1 == null)
				{
					if (obj1 == null)
					{
						if (obj1 == null)
						{
							if (obj1 == null)
							{
								if (obj1 == null)
								{
									if (obj1 == null)
									{
										goto IL_00b7;
									}
									int num2 = 0;
									CultureInfo invariantCulture = CultureInfo.InvariantCulture;
									double num3 = Convert.ToDouble(obj2, invariantCulture);
								}
								int num4 = 0;
								CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
								float num5 = Convert.ToSingle(obj2, invariantCulture2);
							}
							int num6 = 0;
							CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
							ulong num7 = Convert.ToUInt64(obj2, invariantCulture3);
							object obj3 = default(object);
							num7 = (ulong)(long)(num7 + obj3);
						}
						int num8 = 0;
						CultureInfo invariantCulture4 = CultureInfo.InvariantCulture;
						long num9 = Convert.ToInt64(obj2, invariantCulture4);
						object obj4 = default(object);
						num9 += obj4;
					}
					int num10 = 0;
					CultureInfo invariantCulture5 = CultureInfo.InvariantCulture;
					uint num11 = Convert.ToUInt32(obj2, invariantCulture5);
					object obj5 = default(object);
					num11 = (uint)(int)(num11 + obj5);
				}
				int num12 = 0;
				CultureInfo invariantCulture6 = CultureInfo.InvariantCulture;
				int num13 = Convert.ToInt32(obj2, invariantCulture6);
				object obj6 = default(object);
				num13 += obj6;
			}
			goto IL_00b7;
			IL_00b7:
			if (obj1 != null)
			{
				throw new NullReferenceException();
			}
			Type arg = default(Type);
			ArgumentException ex = new ArgumentException($"Sum is not supported for {arg}");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x28C13F0", Offset = "0x28BFDF0", VA = "0x1828C13F0")]
		static EventBatcher()
		{
			string[] array;
			while (true)
			{
				array = new string[4];
				if ("gt" != null && "gt" == null)
				{
					continue;
				}
				array[0] = "gt";
				if ("ses_t" != null && "ses_t" == null)
				{
					continue;
				}
				array[1] = "ses_t";
				if ("count" == null || "count" != null)
				{
					array[2] = "count";
					if ("count_sb" == null || "count_sb" != null)
					{
						break;
					}
				}
			}
			array[3] = "count_sb";
			throw new NullReferenceException();
		}
	}
}
