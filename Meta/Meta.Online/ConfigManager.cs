using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using glPlayFab;
using Google.Protobuf;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PlayFab;
using Serilog;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F06")]
	public class ConfigManager : BaseOnlineManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000F07")]
		public delegate void ConfigChanged(ConfigType configsChanged);

		[Cpp2IlInjected.Token(Token = "0x17001581")]
		public override double FetchDataIntervalTime
		{
			[Cpp2IlInjected.Token(Token = "0x6007BE6")]
			[Cpp2IlInjected.Address(RVA = "0x16893D0", Offset = "0x1687DD0", VA = "0x1816893D0", Slot = "4")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001582")]
		public override string LocalFileRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6007BE7")]
			[Cpp2IlInjected.Address(RVA = "0x1689470", Offset = "0x1687E70", VA = "0x181689470", Slot = "5")]
			get
			{
				return "config";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001583")]
		public string CurrentVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6007BE9")]
			[Cpp2IlInjected.Address(RVA = "0x1689300", Offset = "0x1687D00", VA = "0x181689300")]
			get
			{
				//Discarded unreachable code: IL_001b
				Client arg = base.client;
				Client arg2 = base.client;
				return $"{arg}.{arg2}";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001584")]
		public Dictionary<ConfigType, ConfigInfo> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6007BEC")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CConfigs_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007BED")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CConfigs_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<ConfigType, ConfigInfo>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x17001585")]
		public bool IsInEditor
		{
			[Cpp2IlInjected.Token(Token = "0x6007BEE")]
			[Cpp2IlInjected.Address(RVA = "0x16893E0", Offset = "0x1687DE0", VA = "0x1816893E0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.client.IsGameRunningInEditor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001586")]
		[field: Cpp2IlInjected.Token(Token = "0x4003D47")]
		public static JsonSerializerSettings JsonSerializerSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6007BF1")]
			[Cpp2IlInjected.Address(RVA = "0x1689410", Offset = "0x1687E10", VA = "0x181689410")]
			get;
		} = new JsonSerializerSettings
		{
			TypeNameHandling = TypeNameHandling.All
		};


		[Cpp2IlInjected.Token(Token = "0x1400009E")]
		public event ConfigChanged OnConfigChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6007BEF")]
			[Cpp2IlInjected.Address(RVA = "0x1689260", Offset = "0x1687C60", VA = "0x181689260")]
			[CompilerGenerated]
			add
			{
				ConfigChanged onConfigChanged = this.OnConfigChanged;
				Delegate @delegate = Delegate.Combine(onConfigChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConfigChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007BF0")]
			[Cpp2IlInjected.Address(RVA = "0x16894A0", Offset = "0x1687EA0", VA = "0x1816894A0")]
			[CompilerGenerated]
			remove
			{
				ConfigChanged onConfigChanged = this.OnConfigChanged;
				Delegate @delegate = Delegate.Remove(onConfigChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onConfigChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007BE8")]
		[Cpp2IlInjected.Address(RVA = "0x1688080", Offset = "0x1686A80", VA = "0x181688080")]
		public string BuildConfigFileRelativePath(string configKey)
		{
			return Path.Combine(LocalFileRoot, configKey) + ".json";
		}

		[Cpp2IlInjected.Token(Token = "0x6007BEA")]
		[Cpp2IlInjected.Address(RVA = "0x16882D0", Offset = "0x1686CD0", VA = "0x1816882D0")]
		public string ConfigKey(ConfigType type)
		{
			//Discarded unreachable code: IL_0020
			Client arg = base.client;
			Client arg2 = base.client;
			string text = $"{arg}.{arg2}";
			string result = default(string);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BEB")]
		[Cpp2IlInjected.Address(RVA = "0x1688120", Offset = "0x1686B20", VA = "0x181688120")]
		public string ConfigFileRelativePath(ConfigType type)
		{
			//Discarded unreachable code: IL_0035
			Client arg = base.client;
			Client arg2 = base.client;
			string text = $"{arg}.{arg2}";
			string path = default(string);
			return Path.Combine(LocalFileRoot, path) + ".json";
		}

		[Cpp2IlInjected.Token(Token = "0x6007BF2")]
		[Cpp2IlInjected.Address(RVA = "0x16891D0", Offset = "0x1687BD0", VA = "0x1816891D0")]
		public ConfigManager(OnlineClient onlineClient)
			: base(onlineClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007BF3")]
		[Cpp2IlInjected.Address(RVA = "0x1688400", Offset = "0x1686E00", VA = "0x181688400")]
		private BaseConfig DeserializeConfig(JObject data)
		{
			int num = 0;
			if (data != null)
			{
				JToken value = data.GetValue("ClassType");
				if (value != null)
				{
					string text = value.ToString();
				}
			}
			if ("ClassType" != null)
			{
			}
			object obj = default(object);
			if ("ClassType" != null && obj != null)
			{
				int num2 = 0;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007BF4")]
		[Cpp2IlInjected.Address(RVA = "0x1688810", Offset = "0x1687210", VA = "0x181688810")]
		public ConfigInfo GetConfig(ConfigType type)
		{
			Dictionary<ConfigType, ConfigInfo> dictionary = Configs;
			Func<KeyValuePair<ConfigType, ConfigInfo>, bool> func = (Func<KeyValuePair<ConfigType, ConfigInfo>, bool>)(object)(Func<T, TResult>)delegate
			{
				ConfigType configType = type;
				bool result = default(bool);
				return result;
			};
			IEnumerable<KeyValuePair<ConfigType, ConfigInfo>> enumerable = (IEnumerable<KeyValuePair<ConfigType, ConfigInfo>>)Enumerable.Where<KeyValuePair<ConfigType, ConfigInfo>>((IEnumerable<>)dictionary, (Func<, >)(object)func);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007BF5")]
		[Cpp2IlInjected.Address(RVA = "0x1688920", Offset = "0x1687320", VA = "0x181688920")]
		public Dictionary<string, List<ConfigDef>> GetDataByType(ConfigType type)
		{
			Dictionary<string, List<ConfigDef>> dictionary = (Dictionary<string, List<ConfigDef>>)(object)new Dictionary<TKey, TValue>();
			Dictionary<ConfigType, ConfigInfo> dictionary2 = Configs;
			Func<KeyValuePair<ConfigType, ConfigInfo>, bool> func = (Func<KeyValuePair<ConfigType, ConfigInfo>, bool>)(object)(Func<T, TResult>)delegate
			{
				ConfigType configType = type;
				bool result = default(bool);
				return result;
			};
			IEnumerable<KeyValuePair<ConfigType, ConfigInfo>> enumerable = (IEnumerable<KeyValuePair<ConfigType, ConfigInfo>>)Enumerable.Where<KeyValuePair<ConfigType, ConfigInfo>>((IEnumerable<>)dictionary2, (Func<, >)(object)func);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007BF6")]
		[Cpp2IlInjected.Address(RVA = "0x1688AA0", Offset = "0x16874A0", VA = "0x181688AA0")]
		public Dictionary<string, JObject> GetJsonDataByType(ConfigType type)
		{
			Dictionary<string, JObject> result = default(Dictionary<string, JObject>);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BF7")]
		[Cpp2IlInjected.Address(RVA = "0x16CE2D0", Offset = "0x16CCCD0", VA = "0x1816CE2D0")]
		public Dictionary<string, T> GetJsonDataByType<T>(ConfigType type)
		{
			int num = 0;
			ConfigInfo configInfo = default(ConfigInfo);
			if (configInfo != null)
			{
				Dictionary<string, List<ConfigDef>> _003CData_003Ek__BackingField = configInfo.ConfigData.Data;
				if (this == null)
				{
				}
				Func<KeyValuePair<string, List<ConfigDef>>, bool> func = default(Func<KeyValuePair<string, List<ConfigDef>>, bool>);
				IEnumerable<KeyValuePair<string, List<ConfigDef>>> enumerable = (IEnumerable<KeyValuePair<string, List<ConfigDef>>>)Enumerable.Where<KeyValuePair<string, List<ConfigDef>>>((IEnumerable<>)_003CData_003Ek__BackingField, (Func<, >)(object)func);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007BF8")]
		[Cpp2IlInjected.Address(RVA = "0x16CE610", Offset = "0x16CD010", VA = "0x1816CE610")]
		public List<T> GetProtobufDataByType<T>(ConfigType type, [Optional] List<string> ids) where T : IMessage, new()
		{
			//Discarded unreachable code: IL_0070, IL_0076, IL_007c, IL_0082, IL_0088
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected I4, but got Unknown
			ConfigInfo configInfo = default(ConfigInfo);
			Func<KeyValuePair<string, List<ConfigDef>>, bool> func = default(Func<KeyValuePair<string, List<ConfigDef>>, bool>);
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				if (configInfo == null)
				{
					break;
				}
				BaseConfig _003CConfigData_003Ek__BackingField = configInfo.ConfigData;
				Dictionary<string, List<ConfigDef>> _003CData_003Ek__BackingField = _003CConfigData_003Ek__BackingField.Data;
				string _003CBaseVersion_003Ek__BackingField = _003CConfigData_003Ek__BackingField.BaseVersion;
				if (this == null)
				{
					string _003CBaseVersion_003Ek__BackingField2 = _003CConfigData_003Ek__BackingField.BaseVersion;
				}
				IEnumerable<KeyValuePair<string, List<ConfigDef>>> enumerable = (IEnumerable<KeyValuePair<string, List<ConfigDef>>>)Enumerable.Where<KeyValuePair<string, List<ConfigDef>>>((IEnumerable<>)_003CData_003Ek__BackingField, (Func<, >)(object)func);
				if (flag && ids != null)
				{
					while (!flag2)
					{
					}
				}
				int num2 = 0;
				num2 += num2;
				num2++;
				if (num == 0)
				{
					num2 += 312;
					num2 += typeof(List<ConfigDef>.Enumerator).TypeHandle;
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007BF9")]
		[Cpp2IlInjected.Address(RVA = "0x1688AF0", Offset = "0x16874F0", VA = "0x181688AF0")]
		private bool LoadConfigs()
		{
			//Discarded unreachable code: IL_0059, IL_005e, IL_0061, IL_0066, IL_008b, IL_00f2, IL_00f8, IL_00fe, IL_0104, IL_010a, IL_0110, IL_0116, IL_011c, IL_0122, IL_0128, IL_012e, IL_0134
			//IL_002b: Expected O, but got I4
			ConfigType configType = default(ConfigType);
			uint num3 = default(uint);
			object obj = default(object);
			string text = default(string);
			int num;
			do
			{
				num = 0;
				Dictionary<ConfigType, ConfigInfo> dictionary = Configs;
				if (dictionary != null && ((Dictionary<TKey, TValue>)(object)dictionary).Count > 0)
				{
					int num2 = 0;
				}
				ISerializerPlugin plugin = PluginManager.GetPlugin<ISerializerPlugin>(PluginContract.PlayFab_Serializer, "");
				IEnumerable<Enum> flags = (IEnumerable<Enum>)EnumExt.GetFlags((Enum)configType);
				if (flags != null)
				{
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							obj += obj;
							int num4 = 0;
							if (obj != null)
							{
								Dictionary<ConfigType, ConfigInfo> dictionary2 = Configs;
								throw new NullReferenceException();
							}
							Client client = base.client;
							Serilog.ILogger _003CLog_003Ek__BackingField = client.Log;
							string text2 = $"ConfigManager/LoadConfigs -> failed to load cached config info of type '{client}' found in file '{text}'.";
							string text3 = "ConfigManager/LoadConfigs -> failed to load cached config info from file '" + text + "' because client is desync. Some part of the game might not work as expected (ex: events).";
							goto IL_00e0;
						}
						num++;
					}
					IEnumerable<Enum> enumerable = flags;
					Dictionary<ConfigType, ConfigInfo> dictionary3 = Configs;
					throw new NullReferenceException();
				}
				goto IL_00e0;
				IL_00e0:
				if (flags != null)
				{
				}
			}
			while (num != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007BFA")]
		[Cpp2IlInjected.Address(RVA = "0x1687C70", Offset = "0x1686670", VA = "0x181687C70")]
		private void ApplyConfig(ConfigInfo configInfo)
		{
			//Discarded unreachable code: IL_0041, IL_0047, IL_004d, IL_0053, IL_0059, IL_005f
			//IL_0023: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			bool flag = default(bool);
			object obj = default(object);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Dictionary<string, List<ConfigDef>> _003CData_003Ek__BackingField = configInfo.ConfigData.Data;
				if (!flag)
				{
					break;
				}
				int num4 = 0;
				if (!((object)flag).Equals((object)num4))
				{
					while (obj == null)
					{
					}
					if (flag2)
					{
						bool flag3 = !base.client.IsGameRunningInEditor;
					}
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007BFB")]
		[Cpp2IlInjected.Address(RVA = "0x16890E0", Offset = "0x1687AE0", VA = "0x1816890E0", Slot = "6")]
		protected override Task<bool> Load(CancellationToken ct)
		{
			return (Task<bool>)(object)Task.FromResult(LoadConfigs());
		}

		[Cpp2IlInjected.Token(Token = "0x6007BFC")]
		[Cpp2IlInjected.Address(RVA = "0x16886F0", Offset = "0x16870F0", VA = "0x1816886F0", Slot = "7")]
		[AsyncStateMachine(typeof(_003CFetchAndSave_003Ed__32))]
		protected override Task FetchAndSave(bool forceSave, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BFD")]
		[Cpp2IlInjected.Address(RVA = "0x16885B0", Offset = "0x1686FB0", VA = "0x1816885B0")]
		[AsyncStateMachine(typeof(_003CFetchAndSave_003Ed__33))]
		private Task FetchAndSave(ConfigType configTypes, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007BFE")]
		[Cpp2IlInjected.Address(RVA = "0x1689150", Offset = "0x1687B50", VA = "0x181689150")]
		static ConfigManager()
		{
			throw new NullReferenceException();
		}
	}
}
