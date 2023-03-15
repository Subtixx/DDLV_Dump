using System;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Logging;
using Gameloft.Tracking.Service;
using Gameloft.Tracking.Storage;
using Serilog;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal sealed class EtsService : IEtsServiceProtocol, IServiceProtocol, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly IServiceProtocol innerService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Task responseProcessorTask;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x28C0980", Offset = "0x28BF380", VA = "0x1828C0980", Slot = "6")]
			get
			{
				IServiceProtocol serviceProtocol = innerService;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public OnlineEnvironment Environment
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x28C08B0", Offset = "0x28BF2B0", VA = "0x1828C08B0", Slot = "7")]
			get
			{
				int num = 0;
				num += num;
				num++;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OnServiceControlStateHandler OnServiceBan
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x28C0810", Offset = "0x28BF210", VA = "0x1828C0810", Slot = "4")]
			[CompilerGenerated]
			add
			{
				OnServiceControlStateHandler onServiceBan = this.OnServiceBan;
				Delegate @delegate = Delegate.Combine(onServiceBan, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onServiceBan)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x28C09D0", Offset = "0x28BF3D0", VA = "0x1828C09D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
				OnServiceControlStateHandler onServiceBan = this.OnServiceBan;
				Delegate @delegate = Delegate.Remove(onServiceBan, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onServiceBan)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x28C0790", Offset = "0x28BF190", VA = "0x1828C0790")]
		internal EtsService(TrackingContext context, IServiceProtocol service)
		{
			ILogger logger = (this.logger = context.Logger.SubLogger(this));
			innerService = service;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x28C06C0", Offset = "0x28BF0C0", VA = "0x1828C06C0", Slot = "8")]
		public void SetupEnvironment(OnlineEnvironment environment)
		{
			//Discarded unreachable code: IL_001d
			IServiceProtocol serviceProtocol = innerService;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			EventScope _003CEventScope_003Ek__BackingField = environment.EventScope;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28C0460", Offset = "0x28BEE60", VA = "0x1828C0460", Slot = "9")]
		public Task<HttpResponseMessage> SendEventsAsync(IEventsSelection batchToUpload, CancellationToken cancellationToken)
		{
			IServiceProtocol serviceProtocol = innerService;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			Action<Task<HttpResponseMessage>> action = (Action<Task<HttpResponseMessage>>)(object)(Action<T>)delegate(Task<HttpResponseMessage> t)
			{
				//Discarded unreachable code: IL_004a, IL_0050, IL_0056, IL_005c, IL_0062, IL_0068, IL_006e
				HttpStatusCode statusCode = ((HttpResponseMessage)((Task<TResult>)(object)t).Result).statusCode;
				EtsService etsService = this;
				bool flag = default(bool);
				if (flag)
				{
					EtsService etsService2 = this;
					ILogger logger = etsService2.logger;
					string text = $"Tracking banned by server (reason={etsService2})";
					if (this.OnServiceBan == null)
					{
					}
				}
				ILogger logger2 = etsService.logger;
			};
			TaskScheduler s_defaultTaskScheduler = TaskScheduler.s_defaultTaskScheduler;
			Task task = default(Task);
			responseProcessorTask = task;
			task = (Task)(object)((object)task + (object)task);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28C0160", Offset = "0x28BEB60", VA = "0x1828C0160", Slot = "10")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0013
			int num = 0;
			IServiceProtocol serviceProtocol = innerService;
			if (responseProcessorTask == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28C0240", Offset = "0x28BEC40", VA = "0x1828C0240")]
		private bool ProcessResponse(IEventsSelection selection, EtsStatusCode code)
		{
			if (code > EtsStatusCode.UploadBlocked)
			{
				if ((long)"Events rejected by ETS..." > 1)
				{
					if ("Events rejected by ETS..." == null)
					{
						goto IL_0070;
					}
					if ("Events rejected by ETS..." == null)
					{
						goto IL_0080;
					}
					if ("Events rejected by ETS..." != null && (long)"Events rejected by ETS..." != 1)
					{
						if ("Events rejected by ETS..." != null)
						{
							if ("Events rejected by ETS..." == null || "Events rejected by ETS..." == null)
							{
								goto IL_0061;
							}
							if ((long)"Events rejected by ETS..." != 1)
							{
								goto IL_005f;
							}
						}
						ILogger logger = this.logger;
						goto IL_005f;
					}
				}
				goto IL_0061;
			}
			goto IL_0068;
			IL_0070:
			ILogger logger2 = this.logger;
			goto IL_0078;
			IL_0078:
			while (code != EtsStatusCode.UploadBlocked)
			{
			}
			goto IL_0080;
			IL_0080:
			ILogger logger3 = this.logger;
			throw new NullReferenceException();
			IL_0068:
			if (code == EtsStatusCode.PackageVersionRejected)
			{
				goto IL_0070;
			}
			goto IL_0078;
			IL_005f:
			int num = 0;
			goto IL_0061;
			IL_0061:
			ILogger logger4 = this.logger;
			goto IL_0068;
		}
	}
}
