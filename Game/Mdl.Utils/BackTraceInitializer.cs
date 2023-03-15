using System;
using System.Runtime.CompilerServices;
using Backtrace.Unity;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Systems;
using Meta.ErrorReporting;
using Meta.Util;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200071B")]
	public class BackTraceInitializer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400294C")]
		private Transform parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400294D")]
		private AssetReference backtrace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400294E")]
		private Gameloft.Common.Version version;

		[Cpp2IlInjected.Token(Token = "0x17000479")]
		public static BackTraceInitializer Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6001F86")]
			[Cpp2IlInjected.Address(RVA = "0x1638FA0", Offset = "0x16379A0", VA = "0x181638FA0")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001F87")]
			[Cpp2IlInjected.Address(RVA = "0x1639110", Offset = "0x1637B10", VA = "0x181639110")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x50"), Cpp2IlInjected.Token(Token = "0x4002950")]
		private bool IsInit
		{
			[Cpp2IlInjected.Token(Token = "0x6001F88")]
			[Cpp2IlInjected.Address(RVA = "0x63F730", Offset = "0x63E130", VA = "0x18063F730")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001F89")]
			[Cpp2IlInjected.Address(RVA = "0x63FAE0", Offset = "0x63E4E0", VA = "0x18063FAE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700047B")]
		public bool IsUsingBacktrace
		{
			[Cpp2IlInjected.Token(Token = "0x6001F8C")]
			[Cpp2IlInjected.Address(RVA = "0x1639010", Offset = "0x1637A10", VA = "0x181639010")]
			get
			{
				int num = 0;
				DebugSettings settings = DebugSettings.Settings;
				if (!settings.forceBacktraceOn_)
				{
					int num2 = 0;
					bool flag = default(bool);
					if (settings != null || !flag)
					{
						int num3 = 0;
						throw new NullReferenceException();
					}
					Gameloft.Common.Version version = this.version;
					if (!flag)
					{
						Gameloft.Common.Version version2 = this.version;
						bool flag2 = default(bool);
						if (!flag2)
						{
							Gameloft.Common.Version version3 = this.version;
							bool result = default(bool);
							return result;
						}
					}
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047C")]
		public bool IsInitializingBacktraceOnBoot
		{
			[Cpp2IlInjected.Token(Token = "0x6001F8D")]
			[Cpp2IlInjected.Address(RVA = "0x1638FE0", Offset = "0x16379E0", VA = "0x181638FE0")]
			get
			{
				bool isUsingBacktrace = IsUsingBacktrace;
				if (!isUsingBacktrace)
				{
					return isUsingBacktrace;
				}
				int num = 0;
				return Application.platform != RuntimePlatform.Switch;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F8A")]
		[Cpp2IlInjected.Address(RVA = "0x1638870", Offset = "0x1637270", VA = "0x181638870")]
		public static void Create(AssetReference backtrace, Gameloft.Common.Version version, Transform parent)
		{
			//IL_0021: Expected O, but got I4
			BackTraceInitializer backTraceInitializer = default(BackTraceInitializer);
			backTraceInitializer.backtrace = backtrace;
			int build = version.version.build;
			string buildType = version.buildType;
			backTraceInitializer.version = (Gameloft.Common.Version)build;
			backTraceInitializer.version = (Gameloft.Common.Version)buildType;
			backTraceInitializer.parent = parent;
			Instance = backTraceInitializer;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F8B")]
		[Cpp2IlInjected.Address(RVA = "0x1638F20", Offset = "0x1637920", VA = "0x181638F20")]
		private BackTraceInitializer(AssetReference backtrace, Gameloft.Common.Version version, Transform parent)
		{
			//IL_0027: Expected O, but got I4
			this.backtrace = backtrace;
			int build = version.version.build;
			string buildType = version.buildType;
			this.version = (Gameloft.Common.Version)build;
			this.version = (Gameloft.Common.Version)buildType;
			this.parent = parent;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F8E")]
		[Cpp2IlInjected.Address(RVA = "0x1638980", Offset = "0x1637380", VA = "0x181638980")]
		public void InitializeBacktrace()
		{
			//Discarded unreachable code: IL_0043
			if (IsInit)
			{
				return;
			}
			if (!IsUsingBacktrace)
			{
				Boot.LogWithTime("not using backtrace");
				return;
			}
			IsInit = true;
			Boot.LogWithTime("using backtrace");
			AssetReference assetReference = backtrace;
			Action<AsyncOperationHandle<GameObject>> action = (Action<AsyncOperationHandle<GameObject>>)(object)(Action<T>)delegate
			{
				//Discarded unreachable code: IL_00cb
				Boot.LogWithTime("backtrace done");
				IErrorReporter _003CErrorReporter_003Ek__BackingField = SystemRoot.ErrorReporter;
				if (_003CErrorReporter_003Ek__BackingField != null)
				{
					int num = 0;
					if (_003CErrorReporter_003Ek__BackingField == null)
					{
					}
				}
				string value = default(string);
				BacktraceClient._instance["fullversion"] = value;
				string value2 = default(string);
				BacktraceClient._instance["version"] = value2;
				BacktraceClient instance = BacktraceClient._instance;
				string value3 = default(string);
				BacktraceClient._instance["version.build-id"] = value3;
				BacktraceClient instance2 = BacktraceClient._instance;
				string text = (instance2["version.build-type"] = version.buildType);
				int build = version.version.build;
				string value4 = default(string);
				BacktraceClient._instance["version.version"] = value4;
				string value5 = default(string);
				BacktraceClient._instance["version.commit"] = value5;
				BacktraceClient instance3 = BacktraceClient._instance;
				string text2 = (instance3["version.git-sha"] = version.hash);
			};
		}
	}
}
