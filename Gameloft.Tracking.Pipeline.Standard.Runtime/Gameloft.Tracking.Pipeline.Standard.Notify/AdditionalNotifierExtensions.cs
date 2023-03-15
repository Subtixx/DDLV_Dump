using System;
using Cpp2IlInjected;
using Gameloft.Tracking.Notify;
using Gameloft.Tracking.Pipeline.Standard.Events;

namespace Gameloft.Tracking.Pipeline.Standard.Notify
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class AdditionalNotifierExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x28B74D0", Offset = "0x28B5ED0", VA = "0x1828B74D0")]
		internal static void ReportSessionInactiveError(this Notifier notifier, StandardEvent e)
		{
			//Discarded unreachable code: IL_001b
			//IL_001a: Expected O, but got I4
			int _003CType_003Ek__BackingField = e.EventData.Type;
			Gameloft.Tracking.Notify.NotifierExtensions.ReportAppError(notifier, ErrorCode.SessionNotStarted, "Tracking session wasn't started", (object)_003CType_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x28B7410", Offset = "0x28B5E10", VA = "0x1828B7410")]
		internal static void ReportIOWriteError(this Notifier notifier, StandardEvent evt, Exception e)
		{
			//Discarded unreachable code: IL_002a
			//IL_0029: Expected O, but got I4
			if ((int)evt.BatchSize > 0 || evt.Priority == EventPriority.High)
			{
			}
			int _003CType_003Ek__BackingField = evt.EventData.Type;
			Gameloft.Tracking.Notify.NotifierExtensions.ReportIOError(notifier, ErrorCode.BatchingSlotWriteFailed, e, (object)_003CType_003Ek__BackingField);
		}
	}
}
