using System;
using System.Collections.Generic;
using Backtrace.Unity;
using Cpp2IlInjected;
using Meta.ErrorReporting;
using Serilog.Events;
using UnityEngine;

namespace Mdl.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000949")]
	public class BacktraceReporter : IErrorReporter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400338B")]
		private Dictionary<string, string> CustomKeySetPriorInit;

		[Cpp2IlInjected.Token(Token = "0x17000617")]
		private BacktraceClient client
		{
			[Cpp2IlInjected.Token(Token = "0x6002ACD")]
			[Cpp2IlInjected.Address(RVA = "0xA78290", Offset = "0xA76C90", VA = "0x180A78290")]
			get
			{
				return BacktraceClient._instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ACE")]
		[Cpp2IlInjected.Address(RVA = "0x1639B10", Offset = "0x1638510", VA = "0x181639B10")]
		public BacktraceReporter()
		{
			//Discarded unreachable code: IL_006e
			//IL_0016: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			Dictionary<string, string> dictionary = (CustomKeySetPriorInit = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>());
			int num = 0;
			Meta_002EErrorReporting_002EIErrorReporter_002ELogException((Exception)num);
			UnregisterAlwaysTraceException();
			BacktraceClient instance = BacktraceClient._instance;
			int num2 = 0;
			if (instance != (UnityEngine.Object)num2)
			{
				BacktraceClient instance2 = BacktraceClient._instance;
				Action<Exception> onUnhandledApplicationException = instance2.OnUnhandledApplicationException;
				Action<Exception> b = (Action<Exception>)(object)new Action<T>(OnBackTraceUnhandledApplicationException);
				Delegate @delegate = Delegate.Combine(onUnhandledApplicationException, b);
				int num3 = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				instance2.OnUnhandledApplicationException = (Action<Exception>)num3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002ACF")]
		[Cpp2IlInjected.Address(RVA = "0x1639160", Offset = "0x1637B60", VA = "0x181639160", Slot = "1")]
		~BacktraceReporter()
		{
			UnregisterAlwaysTraceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		void IErrorReporter.Log(string message, LogEventLevel level)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "5")]
		void IErrorReporter.LogException(Exception exception)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		void IErrorReporter.SetUserId(string userId)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD3")]
		[Cpp2IlInjected.Address(RVA = "0x1639650", Offset = "0x1638050", VA = "0x181639650", Slot = "8")]
		public void Report(string message, Exception e, Dictionary<string, string> metadata)
		{
			//Discarded unreachable code: IL_0010, IL_001a, IL_0031, IL_0032
			//IL_0022: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			if (metadata == null)
			{
				Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD4")]
		[Cpp2IlInjected.Address(RVA = "0x1639790", Offset = "0x1638190", VA = "0x181639790")]
		public void TransferCustomKeyToInstance()
		{
			//Discarded unreachable code: IL_002a, IL_0030
			//IL_0011: Expected O, but got I4
			int num = 0;
			BacktraceClient instance = BacktraceClient._instance;
			int num2 = 0;
			bool flag = default(bool);
			if (!(instance == (UnityEngine.Object)num2) && CustomKeySetPriorInit != null && flag)
			{
				BacktraceClient instance2 = BacktraceClient._instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD5")]
		[Cpp2IlInjected.Address(RVA = "0x16391B0", Offset = "0x1637BB0", VA = "0x1816391B0", Slot = "6")]
		void IErrorReporter.SetCustomKey(string key, string value)
		{
			//IL_000f: Expected O, but got I4
			BacktraceClient instance = BacktraceClient._instance;
			int num = 0;
			if (!(instance != (UnityEngine.Object)num))
			{
				if (CustomKeySetPriorInit != null)
				{
					throw new NullReferenceException();
				}
				return;
			}
			BacktraceClient._instance[key] = value;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD6")]
		[Cpp2IlInjected.Address(RVA = "0x16394C0", Offset = "0x1637EC0", VA = "0x1816394C0")]
		public void RegisterAlwaysTraceException()
		{
			//Discarded unreachable code: IL_0053
			//IL_0015: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			UnregisterAlwaysTraceException();
			BacktraceClient instance = BacktraceClient._instance;
			int num = 0;
			if (instance != (UnityEngine.Object)num)
			{
				BacktraceClient instance2 = BacktraceClient._instance;
				Action<Exception> onUnhandledApplicationException = instance2.OnUnhandledApplicationException;
				Action<Exception> b = (Action<Exception>)(object)new Action<T>(OnBackTraceUnhandledApplicationException);
				Delegate @delegate = Delegate.Combine(onUnhandledApplicationException, b);
				int num2 = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				instance2.OnUnhandledApplicationException = (Action<Exception>)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD7")]
		[Cpp2IlInjected.Address(RVA = "0x1639990", Offset = "0x1638390", VA = "0x181639990")]
		public void UnregisterAlwaysTraceException()
		{
			//Discarded unreachable code: IL_004d
			//IL_000f: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			BacktraceClient instance = BacktraceClient._instance;
			int num = 0;
			if (instance != (UnityEngine.Object)num)
			{
				BacktraceClient instance2 = BacktraceClient._instance;
				Action<Exception> onUnhandledApplicationException = instance2.OnUnhandledApplicationException;
				Action<Exception> value = (Action<Exception>)(object)new Action<T>(OnBackTraceUnhandledApplicationException);
				Delegate @delegate = Delegate.Remove(onUnhandledApplicationException, value);
				int num2 = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					throw new InvalidCastException();
				}
				instance2.OnUnhandledApplicationException = (Action<Exception>)num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002AD8")]
		[Cpp2IlInjected.Address(RVA = "0x16392D0", Offset = "0x1637CD0", VA = "0x1816392D0")]
		private void OnBackTraceUnhandledApplicationException(Exception e)
		{
			//Discarded unreachable code: IL_0019
			ILogger s_Logger = Debug.s_Logger;
			ILogger s_Logger2 = Debug.s_Logger;
			Debug.LogException(e);
			ILogger s_Logger3 = Debug.s_Logger;
		}
	}
}
