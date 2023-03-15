using Cpp2IlInjected;
using Gameloft.Tracking.EventConveyor;
using Gameloft.Tracking.Logging;
using Gameloft.Tracking.Pipeline.Standard.Service;
using Gameloft.Tracking.Pipeline.Standard.Storage;
using Gameloft.Tracking.Scheduling;
using Gameloft.Tracking.Service;
using Gameloft.Tracking.Storage;
using Serilog;

namespace Gameloft.Tracking.Pipeline.Standard
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class DefaultComponentFactory : IComponentFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28BF770", Offset = "0x28BE170", VA = "0x1828BF770", Slot = "9")]
		public virtual IStorageFactory CreateStorageFactory()
		{
			Gameloft.Tracking.Storage.DefaultStorageFactory defaultStorageFactory = new Gameloft.Tracking.Storage.DefaultStorageFactory();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28BF400", Offset = "0x28BDE00", VA = "0x1828BF400", Slot = "10")]
		public virtual Gameloft.Tracking.EventConveyor.IEventConveyor CreateEventConveyor(TrackingContext context, IPersistentStorage storageInstance, ConveyorOptions options)
		{
			ILogger _003CLogger_003Ek__BackingField = context.Logger;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28BF570", Offset = "0x28BDF70", VA = "0x1828BF570", Slot = "11")]
		public virtual IScopeablePersistentStorage CreateScopeablePersistentStorage(TrackingContext context, ExtendedStorageOptions options)
		{
			ILogger _003CLogger_003Ek__BackingField = context.Logger;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28BF4B0", Offset = "0x28BDEB0", VA = "0x1828BF4B0", Slot = "12")]
		public virtual IUploadScheduler CreateScheduler(TrackingContext context, IPersistentStorage storageInstance, IServiceProtocol serviceInstance, SchedulerOptions options)
		{
			ILogger _003CLogger_003Ek__BackingField = context.Logger;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28BF610", Offset = "0x28BE010", VA = "0x1828BF610", Slot = "13")]
		public virtual IEtsServiceProtocol CreateService(TrackingContext context, Session sessionInstance, ExtendedServiceOptions options)
		{
			HttpRequestFactory httpRequestFactory = new HttpRequestFactory();
			ILogger _003CLogger_003Ek__BackingField = context.Logger;
			EtsService etsService = default(EtsService);
			ILogger logger = (etsService.logger = context.Logger.SubLogger(etsService));
			Gameloft.Tracking.Service.TrackingService innerService = default(Gameloft.Tracking.Service.TrackingService);
			etsService.innerService = innerService;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public DefaultComponentFactory()
		{
		}
	}
}
