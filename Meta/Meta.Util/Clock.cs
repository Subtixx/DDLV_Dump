using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AAD")]
	public class Clock
	{
		[Cpp2IlInjected.Token(Token = "0x2000AAE")]
		private class Appointment
		{
			[Cpp2IlInjected.Token(Token = "0x2000AAF")]
			public class AppointmentComparer : IComparer<Appointment>
			{
				[Cpp2IlInjected.Token(Token = "0x6005CF3")]
				[Cpp2IlInjected.Address(RVA = "0x1DF5BE0", Offset = "0x1DF45E0", VA = "0x181DF5BE0", Slot = "4")]
				public int Compare(Appointment x, Appointment y)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005CF4")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public AppointmentComparer()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002AC5")]
			public readonly DateTime DateTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002AC6")]
			public readonly CancellationToken CancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002AC7")]
			internal readonly TaskCompletionSource<bool> tcs;

			[Cpp2IlInjected.Token(Token = "0x4002AC8")]
			public static readonly AppointmentComparer Comparer = new AppointmentComparer();

			[Cpp2IlInjected.Token(Token = "0x1700103A")]
			public Task Task
			{
				[Cpp2IlInjected.Token(Token = "0x6005CF0")]
				[Cpp2IlInjected.Address(RVA = "0x997330", Offset = "0x995D30", VA = "0x180997330")]
				get
				{
					Task<> task = (Task<>)(object)((TaskCompletionSource<>)(object)tcs).m_task;
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005CF1")]
			[Cpp2IlInjected.Address(RVA = "0x997290", Offset = "0x995C90", VA = "0x180997290")]
			public Appointment(DateTime dateTime, CancellationToken ct)
			{
				CancellationToken = ct;
				DateTime = dateTime;
				TaskCompletionSource<bool> taskCompletionSource = (tcs = (TaskCompletionSource<bool>)(object)new TaskCompletionSource<TResult>());
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6005CF2")]
			[Cpp2IlInjected.Address(RVA = "0x997220", Offset = "0x995C20", VA = "0x180997220")]
			static Appointment()
			{
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002AC1")]
		private readonly List<Appointment> appointments = (List<Appointment>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002AC2")]
		private readonly Func<DateTime> currentTimeProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002AC3")]
		private readonly Func<TimeSpan> timeZoneOffsetProvider;

		[Cpp2IlInjected.Token(Token = "0x17001039")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4002AC4")]
		public bool IsPaused
		{
			[Cpp2IlInjected.Token(Token = "0x6005CE9")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005CEA")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CEB")]
		[Cpp2IlInjected.Address(RVA = "0x16740B0", Offset = "0x1672AB0", VA = "0x1816740B0")]
		public Clock(Func<DateTime> currentTimeProvider, Func<TimeSpan> timeZoneOffsetProvider)
		{
			this.currentTimeProvider = currentTimeProvider;
			this.timeZoneOffsetProvider = timeZoneOffsetProvider;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CEC")]
		[Cpp2IlInjected.Address(RVA = "0x1673F70", Offset = "0x1672970", VA = "0x181673F70")]
		[AsyncStateMachine(typeof(_003CWaitUntil_003Ed__9))]
		public Task WaitUntil(DateTime serverTimeStamp, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CED")]
		[Cpp2IlInjected.Address(RVA = "0x1673DF0", Offset = "0x16727F0", VA = "0x181673DF0")]
		public Task WaitFor(TimeSpan timeSpan, CancellationToken ct)
		{
			//Discarded unreachable code: IL_001b
			DateTime serverTimeStamp = (DateTime)currentTimeProvider() + timeSpan;
			return WaitUntil(serverTimeStamp, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CEE")]
		[Cpp2IlInjected.Address(RVA = "0x1673EB0", Offset = "0x16728B0", VA = "0x181673EB0")]
		public Task WaitUntilLocal(DateTime localTimeStamp, CancellationToken ct)
		{
			//Discarded unreachable code: IL_001d
			TimeSpan timeSpan = (TimeSpan)timeZoneOffsetProvider();
			DateTime serverTimeStamp = localTimeStamp - timeSpan;
			return WaitUntil(serverTimeStamp, ct);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CEF")]
		[Cpp2IlInjected.Address(RVA = "0x1673BF0", Offset = "0x16725F0", VA = "0x181673BF0")]
		public void Update()
		{
			//Discarded unreachable code: IL_0080, IL_0086, IL_008c, IL_0092
			//IL_0053: Expected O, but got I4
			int num = 0;
			if ((IsPaused ? 1 : 0) != num)
			{
				return;
			}
			DateTime dateTime = (DateTime)currentTimeProvider();
			Appointment appointment = Enumerable.FirstOrDefault<Appointment>((IEnumerable<>)appointments);
			if (appointment != null && appointment.DateTime < dateTime)
			{
				CancellationToken cancellationToken = appointment.CancellationToken;
				TaskCompletionSource<bool> tcs = appointment.tcs;
				bool flag = default(bool);
				if (!flag)
				{
					bool flag2 = ((TaskCompletionSource<TResult>)(object)tcs).TrySetResult((TResult)1);
				}
				bool flag3 = ((TaskCompletionSource<TResult>)(object)tcs).TrySetCanceled();
				List<Appointment> list = appointments;
				int index = 0;
				((List<T>)(object)list).RemoveAt(index);
				Appointment appointment2 = Enumerable.FirstOrDefault<Appointment>((IEnumerable<>)appointments);
			}
		}
	}
}
