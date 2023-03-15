using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Log;
using Mdl.Native.iOS;
using Mdl.Systems;
using Mdl.Utils.Log;
using Meta.ErrorReporting;
using Meta.Util;
using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting.Display;
using Serilog.Sinks.SystemConsole.Themes;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x20007B8")]
	public class SeriloggerWrapper : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20007B9")]
		private class SerilogContextHandler
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002BCA")]
			public ConcurrentDictionary<string, LogEventLevel> contextLogLevels = (ConcurrentDictionary<string, LogEventLevel>)(object)new ConcurrentDictionary<TKey, TValue>();

			[Cpp2IlInjected.Token(Token = "0x600226F")]
			[Cpp2IlInjected.Address(RVA = "0x14419A0", Offset = "0x14403A0", VA = "0x1814419A0")]
			public SerilogContextHandler()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002BC2")]
		public static readonly LogEventLevel MinimalLogVerbosity;

		[Cpp2IlInjected.Token(Token = "0x4002BC3")]
		public static readonly LogEventLevel DefaultLogVerbosity;

		[Cpp2IlInjected.Token(Token = "0x4002BC4")]
		public static LogEventLevel CurrentDefaultLogVerbosity = DefaultLogVerbosity;

		[Cpp2IlInjected.Token(Token = "0x4002BC5")]
		public const string ContextKey = "Context";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002BC6")]
		public readonly Serilog.ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BC7")]
		private readonly LoggingLevelSwitch levelSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002BC8")]
		private readonly SerilogContextHandler contextHandler;

		[Cpp2IlInjected.Token(Token = "0x170004CB")]
		public static SeriloggerWrapper Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6002260")]
			[Cpp2IlInjected.Address(RVA = "0xF49890", Offset = "0xF48290", VA = "0x180F49890")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002261")]
			[Cpp2IlInjected.Address(RVA = "0xF499F0", Offset = "0xF483F0", VA = "0x180F499F0")]
			[CompilerGenerated]
			private set
			{
				//IL_0006: Expected I4, but got O
				MinimalLogVerbosity = (LogEventLevel)value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CC")]
		public static Serilog.ILogger StaticLogger
		{
			[Cpp2IlInjected.Token(Token = "0x6002262")]
			[Cpp2IlInjected.Address(RVA = "0xF49940", Offset = "0xF48340", VA = "0x180F49940")]
			get
			{
				//Discarded unreachable code: IL_000b
				return Instance.logger;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004CD")]
		public IEnumerable<string> KnownContexts
		{
			[Cpp2IlInjected.Token(Token = "0x6002265")]
			[Cpp2IlInjected.Address(RVA = "0xF498F0", Offset = "0xF482F0", VA = "0x180F498F0")]
			get
			{
				ICollection<string> keys = (ICollection<string>)((ConcurrentDictionary<TKey, TValue>)(object)contextHandler.contextLogLevels).get_Keys();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002259")]
		[Cpp2IlInjected.Address(RVA = "0xF49650", Offset = "0xF48050", VA = "0x180F49650")]
		private SeriloggerWrapper(Serilog.ILogger logger, LoggingLevelSwitch llswitch, SerilogContextHandler contextHandler)
		{
			//Discarded unreachable code: IL_007a
			//IL_0021: Expected I4, but got O
			this.logger = logger;
			this.contextHandler = contextHandler;
			levelSwitch = llswitch;
			MinimalLogVerbosity = (LogEventLevel)this;
			int num = 0;
			DebugSettings.DebugSettingsDispatcher dispatcher = DebugSettings.Dispatcher;
			DebugSettings.DebugSettingsDispatcher.Load value = OnDebugSettingsChanged;
			dispatcher.OnLoad += value;
			int num2 = 0;
			DebugSettings.DebugSettingsDispatcher dispatcher2 = DebugSettings.Dispatcher;
			DebugSettings.DebugSettingsDispatcher.FirstMenuConfirm value2 = OnDebugSettingsChanged;
			dispatcher2.OnFirstMenuConfirm += value2;
			int num3 = 0;
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
				Application.logMessageReceived += Application_logMessageReceived;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600225A")]
		[Cpp2IlInjected.Address(RVA = "0xF48E10", Offset = "0xF47810", VA = "0x180F48E10")]
		public void InitVerbosityFromDebugSettings()
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			if (DebugSettings.Settings.useMinimalLogVerbosity_)
			{
			}
			LogEventLevel defaultLogVerbosity = DefaultLogVerbosity;
			LoggingLevelSwitch loggingLevelSwitch = Instance.levelSwitch;
			CurrentDefaultLogVerbosity = defaultLogVerbosity;
		}

		[Cpp2IlInjected.Token(Token = "0x600225B")]
		[Cpp2IlInjected.Address(RVA = "0xF48E10", Offset = "0xF47810", VA = "0x180F48E10")]
		private void OnDebugSettingsChanged()
		{
			//Discarded unreachable code: IL_0027
			int num = 0;
			if (DebugSettings.Settings.useMinimalLogVerbosity_)
			{
			}
			LogEventLevel defaultLogVerbosity = DefaultLogVerbosity;
			LoggingLevelSwitch loggingLevelSwitch = Instance.levelSwitch;
			CurrentDefaultLogVerbosity = defaultLogVerbosity;
		}

		[Cpp2IlInjected.Token(Token = "0x600225C")]
		[Cpp2IlInjected.Address(RVA = "0xF493B0", Offset = "0xF47DB0", VA = "0x180F493B0", Slot = "4")]
		void IDisposable.Dispose()
		{
			Debug.Log("dispose Serilogger");
			int num = 0;
			DebugSettings.DebugSettingsDispatcher dispatcher = DebugSettings.Dispatcher;
			DebugSettings.DebugSettingsDispatcher.Load value = OnDebugSettingsChanged;
			dispatcher.OnLoad -= value;
			int num2 = 0;
			DebugSettings.DebugSettingsDispatcher dispatcher2 = DebugSettings.Dispatcher;
			DebugSettings.DebugSettingsDispatcher.FirstMenuConfirm value2 = OnDebugSettingsChanged;
			dispatcher2.OnFirstMenuConfirm -= value2;
			Application.logMessageReceived -= Application_logMessageReceived;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600225D")]
		[Cpp2IlInjected.Address(RVA = "0xF48F80", Offset = "0xF47980", VA = "0x180F48F80")]
		public static LogEventLevel Map(LogType logType)
		{
			while (true)
			{
				if (logType != 0 && logType != 0 && logType != 0 && logType != 0 && logType != LogType.Assert)
				{
					/*Error: Could not find block for branch target IL_0014*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600225E")]
		[Cpp2IlInjected.Address(RVA = "0xF48B00", Offset = "0xF47500", VA = "0x180F48B00")]
		public static string EscapeProperty(string property)
		{
			return "\"" + property + "\"";
		}

		[Cpp2IlInjected.Token(Token = "0x600225F")]
		[Cpp2IlInjected.Address(RVA = "0xF481A0", Offset = "0xF46BA0", VA = "0x180F481A0")]
		private void Application_logMessageReceived(string condition, string stackTrace, LogType type)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002263")]
		[Cpp2IlInjected.Address(RVA = "0xF48610", Offset = "0xF47010", VA = "0x180F48610")]
		public static Serilog.ILogger CreateLogger(string contextName)
		{
			Serilog.ILogger logger = Instance.logger;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			LogEventLevel currentDefaultLogVerbosity = CurrentDefaultLogVerbosity;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002264")]
		[Cpp2IlInjected.Address(RVA = "0x1B22500", Offset = "0x1B20F00", VA = "0x181B22500")]
		public static Serilog.ILogger CreateLogger<T>()
		{
			int num = 0;
			Serilog.ILogger staticLogger = StaticLogger;
			Type type = default(Type);
			string fullName = type.FullName;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002266")]
		[Cpp2IlInjected.Address(RVA = "0xF48D00", Offset = "0xF47700", VA = "0x180F48D00")]
		public LogEventLevel GetLogLevel(string context)
		{
			//Discarded unreachable code: IL_0027
			string text = "\"" + context + "\"";
			ConcurrentDictionary<string, LogEventLevel> contextLogLevels = contextHandler.contextLogLevels;
			bool flag = default(bool);
			if (flag)
			{
			}
			return CurrentDefaultLogVerbosity;
		}

		[Cpp2IlInjected.Token(Token = "0x6002267")]
		[Cpp2IlInjected.Address(RVA = "0xF492C0", Offset = "0xF47CC0", VA = "0x180F492C0")]
		public void SetContextLogLevel(string context, LogEventLevel ll)
		{
			//Discarded unreachable code: IL_001e
			string text = "\"" + context + "\"";
			ConcurrentDictionary<string, LogEventLevel> contextLogLevels = contextHandler.contextLogLevels;
		}

		[Cpp2IlInjected.Token(Token = "0x6002268")]
		[Cpp2IlInjected.Address(RVA = "0xF490E0", Offset = "0xF47AE0", VA = "0x180F490E0")]
		public void SetAllContextLogLevel(LogEventLevel ll)
		{
			//Discarded unreachable code: IL_003c, IL_0042, IL_0048
			int num = 0;
			ICollection<string> collection = (ICollection<string>)((ConcurrentDictionary<TKey, TValue>)(object)contextHandler.contextLogLevels).get_Keys();
			if (collection != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0033;
					}
					num++;
				}
				ConcurrentDictionary<string, LogEventLevel> contextLogLevels = contextHandler.contextLogLevels;
				goto IL_0033;
			}
			goto IL_0037;
			IL_0037:
			if (collection == null)
			{
			}
			return;
			IL_0033:
			collection = (ICollection<string>)(object)((object)collection + (object)collection);
			goto IL_0037;
		}

		[Cpp2IlInjected.Token(Token = "0x6002269")]
		[Cpp2IlInjected.Address(RVA = "0xF49390", Offset = "0xF47D90", VA = "0x180F49390")]
		public void SetGlobalLogLevel(LogEventLevel ll)
		{
			//Discarded unreachable code: IL_000d
			levelSwitch.MinimumLevel = ll;
		}

		[Cpp2IlInjected.Token(Token = "0x600226A")]
		[Cpp2IlInjected.Address(RVA = "0xF48B40", Offset = "0xF47540", VA = "0x180F48B40")]
		private unsafe static bool ExcludeLog(LogEvent evt, SerilogContextHandler contextHandler)
		{
			//IL_004f: Expected O, but got I4
			//IL_0051: Expected I4, but got O
			int num = 0;
			Dictionary<string, LogEventPropertyValue> properties = evt._properties;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					goto IL_002f;
				}
				num++;
			}
			if ("Context" == null)
			{
				return (long)evt.Level < (long)(IntPtr)"{il2cpp field on {'constant21' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x8}";
			}
			goto IL_002f;
			IL_002f:
			string key = ((int*)num)->ToString();
			ConcurrentDictionary<string, LogEventLevel> contextLogLevels = contextHandler.contextLogLevels;
			LogEventLevel currentDefaultLogVerbosity = CurrentDefaultLogVerbosity;
			LogEventLevel logEventLevel = (LogEventLevel)((ConcurrentDictionary<TKey, TValue>)(object)contextLogLevels).GetOrAdd((TKey)key, (TValue)currentDefaultLogVerbosity);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600226B")]
		[Cpp2IlInjected.Address(RVA = "0xF48FB0", Offset = "0xF479B0", VA = "0x180F48FB0")]
		[RuntimeInitializeOnLoadMethod]
		public static void Reset()
		{
			//Discarded unreachable code: IL_0007
			SeriloggerWrapper seriloggerWrapper = Instance;
		}

		[Cpp2IlInjected.Token(Token = "0x600226C")]
		[Cpp2IlInjected.Address(RVA = "0xF48310", Offset = "0xF46D10", VA = "0x180F48310")]
		public static LoggerConfiguration CreateLoggerConfig([System.Runtime.InteropServices.Optional] IErrorReporter errorReporter, [System.Runtime.InteropServices.Optional] string outputTemplate)
		{
			//Discarded unreachable code: IL_0099
			//IL_0025: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			LoggerSinkConfiguration _003CWriteTo_003Ek__BackingField = new LoggerConfiguration().WriteTo;
			int num = 0;
			LogEventLevel currentDefaultLogVerbosity = CurrentDefaultLogVerbosity;
			int num2 = 0;
			LoggerSinkConfiguration _003CWriteTo_003Ek__BackingField2 = ConsoleLoggerConfigurationExtensions.Console(_003CWriteTo_003Ek__BackingField, currentDefaultLogVerbosity, "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}", (IFormatProvider)num, (LoggingLevelSwitch)num2, (Nullable<>)num2, (ConsoleTheme)num2).WriteTo;
			LogEventLevel currentDefaultLogVerbosity2 = CurrentDefaultLogVerbosity;
			if ((object)typeof(UnityLogSink).TypeHandle != null)
			{
				UnityLogSink unityLogSink = new UnityLogSink();
			}
			int num3 = default(int);
			MessageTemplateTextFormatter outputFormatter = new MessageTemplateTextFormatter(outputTemplate, (IFormatProvider)num3);
			num3 = 0;
			UnityLogSink unityLogSink2 = new UnityLogSink(outputFormatter);
			int num4 = 0;
			LoggerConfiguration loggerConfiguration = default(LoggerConfiguration);
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
				LoggerSinkConfiguration _003CWriteTo_003Ek__BackingField3 = loggerConfiguration.WriteTo;
				LogEventLevel currentDefaultLogVerbosity3 = CurrentDefaultLogVerbosity;
				NSLogSink nSLogSink = new NSLogSink();
			}
			if (errorReporter != null)
			{
				LoggerSinkConfiguration _003CWriteTo_003Ek__BackingField4 = loggerConfiguration.WriteTo;
				LogEventLevel currentDefaultLogVerbosity4 = CurrentDefaultLogVerbosity;
				ReporterSink reporterSink = new ReporterSink(errorReporter);
			}
			return loggerConfiguration;
		}

		[Cpp2IlInjected.Token(Token = "0x600226D")]
		[Cpp2IlInjected.Address(RVA = "0xF487C0", Offset = "0xF471C0", VA = "0x180F487C0")]
		public static SeriloggerWrapper Create([System.Runtime.InteropServices.Optional] IErrorReporter errorReporter)
		{
			//Discarded unreachable code: IL_0097, IL_009d
			//IL_0034: Expected O, but got I4
			int stackTraceType = 0;
			Application.SetStackTraceLogType(LogType.Error, (StackTraceLogType)stackTraceType);
			int stackTraceType2 = 0;
			Application.SetStackTraceLogType(LogType.Warning, (StackTraceLogType)stackTraceType2);
			int stackTraceType3 = 0;
			Application.SetStackTraceLogType(LogType.Log, (StackTraceLogType)stackTraceType3);
			LoggingLevelSwitch llswitch = new LoggingLevelSwitch();
			int num = 0;
			LoggerConfiguration loggerConfiguration = CreateLoggerConfig(errorReporter, (string)num).MinimumLevel.ControlledBy(llswitch);
			SerilogContextHandler contextHandler = new SerilogContextHandler();
			LoggerFilterConfiguration filter = loggerConfiguration.Filter;
			Func<LogEvent, bool> func = (Func<LogEvent, bool>)(object)(Func<T, TResult>)delegate(LogEvent le)
			{
				SerilogContextHandler serilogContextHandler2 = contextHandler;
				return ExcludeLog(le, serilogContextHandler2);
			};
			LoggerConfiguration loggerConfiguration2 = filter.ByExcluding((Func<, >)(object)func);
			Serilog.Core.Logger baseLogger = loggerConfiguration.CreateLogger();
			Serilogger.SetBaseLogger(baseLogger);
			SerilogContextHandler serilogContextHandler = contextHandler;
			return new SeriloggerWrapper(baseLogger, llswitch, serilogContextHandler);
		}
	}
}
