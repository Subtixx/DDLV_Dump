using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Newtonsoft.Json;
using PlayFab;
using Serilog;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	public class PlayFabSysHttp : ITransportPlugin, IPlayFabPlugin
	{
		[Cpp2IlInjected.Token(Token = "0x2000147")]
		public delegate void ReloginCallback(Action<LoginResponse> newLoginResponseEvent, LoginResponse previousValidLoginResponse);

		[Cpp2IlInjected.Token(Token = "0x2000148")]
		public delegate void PlayFabErrorCallback(PlayFabError playFabError);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private readonly HttpClientWithTimeout _client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private readonly string[] AuthTypes;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public static readonly int TimeSinceLoginThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private readonly ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private ICloudScriptExecutor cloudScriptExecutor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private SemaphoreSlim reloginSemaphore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private long counter;

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return logger;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public ICloudScriptExecutor CloudScriptExecutor
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return cloudScriptExecutor;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public LoginResponse LastValidLoginResponse
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CLastValidLoginResponse_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				_003CLastValidLoginResponse_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x40004D3")]
		public bool AllowRetryOnConnectionErrors
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public static string DefaultAcceptLanguage
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x1041E10", Offset = "0x1040810", VA = "0x181041E10")]
			[CompilerGenerated]
			get
			{
				return _003CDefaultAcceptLanguage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x10420D0", Offset = "0x1040AD0", VA = "0x1810420D0")]
			[CompilerGenerated]
			set
			{
				//IL_0006: Expected I4, but got O
				TimeSinceLoginThreshold = (int)value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		[field: Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static JsonSerializerSettings NewtonJsonSerializer
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x1041E70", Offset = "0x1040870", VA = "0x181041E70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event ReloginCallback RequestPlayFabReloginCB
		{
			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x1041D10", Offset = "0x1040710", VA = "0x181041D10")]
			[CompilerGenerated]
			add
			{
				ReloginCallback requestPlayFabReloginCB = PlayFabSysHttp.RequestPlayFabReloginCB;
				Delegate @delegate = Delegate.Combine(requestPlayFabReloginCB, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != requestPlayFabReloginCB)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x1041FD0", Offset = "0x10409D0", VA = "0x181041FD0")]
			[CompilerGenerated]
			remove
			{
				ReloginCallback requestPlayFabReloginCB = PlayFabSysHttp.RequestPlayFabReloginCB;
				Delegate @delegate = Delegate.Remove(requestPlayFabReloginCB, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != requestPlayFabReloginCB)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event PlayFabErrorCallback OnPlayFabErrorCB
		{
			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x1041C10", Offset = "0x1040610", VA = "0x181041C10")]
			[CompilerGenerated]
			add
			{
				PlayFabErrorCallback onPlayFabErrorCB = PlayFabSysHttp.OnPlayFabErrorCB;
				Delegate @delegate = Delegate.Combine(onPlayFabErrorCB, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPlayFabErrorCB)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x1041ED0", Offset = "0x10408D0", VA = "0x181041ED0")]
			[CompilerGenerated]
			remove
			{
				PlayFabErrorCallback onPlayFabErrorCB = PlayFabSysHttp.OnPlayFabErrorCB;
				Delegate @delegate = Delegate.Remove(onPlayFabErrorCB, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPlayFabErrorCB)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x1041080", Offset = "0x103FA80", VA = "0x181041080")]
		private void Info(string msg, params object[] parameters)
		{
			if (logger != null)
			{
				string text = "[PlayFab]" + msg;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x10415F0", Offset = "0x103FFF0", VA = "0x1810415F0")]
		private void Warning(string msg, params object[] parameters)
		{
			if (logger != null)
			{
				string text = "[PlayFab]" + msg;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x1040D70", Offset = "0x103F770", VA = "0x181040D70")]
		private void Error(string msg, params object[] parameters)
		{
			if (logger != null)
			{
				string text = "[PlayFab]" + msg;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x1040C70", Offset = "0x103F670", VA = "0x181040C70")]
		private void Error(Exception e, [Optional] string msg, params object[] parameters)
		{
			if (logger != null)
			{
				string text = "[PlayFab]" + msg;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x1041200", Offset = "0x103FC00", VA = "0x181041200")]
		public static void SetPlugin([Optional] ILogger logger, [Optional] ICloudScriptExecutor cloudScriptExecutor)
		{
			IPlayFabPlugin plugin = PluginManager.GetPlugin<IPlayFabPlugin>(PluginContract.PlayFab_Transport, "");
			if (plugin != null)
			{
				int num = 0;
				if (plugin != null)
				{
					return;
				}
			}
			PluginManager.SetPlugin(new PlayFabSysHttp(logger, cloudScriptExecutor), PluginContract.PlayFab_Transport);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x1040FB0", Offset = "0x103F9B0", VA = "0x181040FB0")]
		public static PlayFabSysHttp GetPlayfabSysHTTP()
		{
			if (PluginManager.GetPlugin<ITransportPlugin>(PluginContract.PlayFab_Transport, "") == null)
			{
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x1040E00", Offset = "0x103F800", VA = "0x181040E00")]
		public static PlayFabSysHttp GetOrCreatePlayfabSysHTTP([Optional] Serilog.ILogger logger)
		{
			//IL_0023: Expected O, but got I4
			ITransportPlugin plugin = PluginManager.GetPlugin<ITransportPlugin>(PluginContract.PlayFab_Transport, "");
			if (plugin != null)
			{
				int num = 0;
				if (plugin != null)
				{
					goto IL_0032;
				}
			}
			int num2 = default(int);
			PlayFabSysHttp playFabSysHttp = new PlayFabSysHttp(new SerilogAdapter(logger), (ICloudScriptExecutor)num2);
			num2 = 0;
			PluginManager.SetPlugin(playFabSysHttp, PluginContract.PlayFab_Transport);
			goto IL_0032;
			IL_0032:
			return playFabSysHttp;
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x1041930", Offset = "0x1040330", VA = "0x181041930")]
		public PlayFabSysHttp([Optional] ILogger logger, [Optional] ICloudScriptExecutor cloudScriptExecutor)
		{
			string[] array;
			while (true)
			{
				_client = new HttpClientWithTimeout();
				array = new string[4];
				if ("X-SecretKey" != null && "X-SecretKey" == null)
				{
					continue;
				}
				array[0] = "X-SecretKey";
				if ("X-Authorization" != null && "X-Authorization" == null)
				{
					continue;
				}
				array[1] = "X-Authorization";
				if ("X-Authentication" == null || "X-Authentication" != null)
				{
					array[2] = "X-Authentication";
					if ("X-EntityToken" == null || "X-EntityToken" != null)
					{
						break;
					}
				}
			}
			array[3] = "X-EntityToken";
			AuthTypes = array;
			reloginSemaphore = new SemaphoreSlim(1);
			base._002Ector();
			this.logger = logger;
			this.cloudScriptExecutor = cloudScriptExecutor;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x1041340", Offset = "0x103FD40", VA = "0x181041340")]
		public void SetScriptExecutor(ICloudScriptExecutor cloudScriptExecutor)
		{
			ICloudScriptExecutor cloudScriptExecutor2 = this.cloudScriptExecutor;
			int num = 0;
			this.cloudScriptExecutor = cloudScriptExecutor;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x1041110", Offset = "0x103FB10", VA = "0x181041110")]
		public static string SerializeObject(object o)
		{
			JsonSerializerSettings settings = NewtonJsonSerializer;
			return JsonConvert.SerializeObject(o, settings);
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x1040A00", Offset = "0x103F400", VA = "0x181040A00")]
		public static object DeserializeObject(string s)
		{
			JsonSerializerSettings settings = NewtonJsonSerializer;
			return JsonConvert.DeserializeObject(s, settings);
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x26D2960", Offset = "0x26D1360", VA = "0x1826D2960")]
		public static T DeserializeObject<T>(string s)
		{
			object obj = ((ICloneable)s).Clone();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x1040AF0", Offset = "0x103F4F0", VA = "0x181040AF0", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoPost_003Ed__46))]
		public Task<object> DoPost(string fullUrl, object request, Dictionary<string, string> extraHeaders)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<object>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x10413D0", Offset = "0x103FDD0", VA = "0x1810413D0")]
		[AsyncStateMachine(typeof(_003CTryRelogin_003Ed__47))]
		private Task<bool> TryRelogin(string fullUrl, object request, Dictionary<string, string> extraHeaders)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x1041680", Offset = "0x1040080", VA = "0x181041680")]
		[AsyncStateMachine(typeof(_003C_DoPost_003Ed__48))]
		public Task<object> _DoPost(string fullUrl, object request, Dictionary<string, string> extraHeaders)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<object>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x1041800", Offset = "0x1040200", VA = "0x181041800")]
		static PlayFabSysHttp()
		{
			//IL_0027: Expected I4, but got O
			JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
				TypeNameHandling = TypeNameHandling.All
			};
			NetCoreSerializationBinder netCoreSerializationBinder = (NetCoreSerializationBinder)(jsonSerializerSettings.SerializationBinder = new NetCoreSerializationBinder());
			TimeSinceLoginThreshold = (int)jsonSerializerSettings;
			throw new NullReferenceException();
		}
	}
}
