using Cpp2IlInjected;
using Gameloft.Tracking.EventConveyor;
using Gameloft.Tracking.Pipeline.Standard.Service;
using Gameloft.Tracking.Pipeline.Standard.Storage;
using Gameloft.Tracking.Scheduling;
using Gameloft.Tracking.Service;
using Gameloft.Tracking.Storage;

namespace Gameloft.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal interface IComponentFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IStorageFactory CreateStorageFactory();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IScopeablePersistentStorage CreateScopeablePersistentStorage(TrackingContext context, ExtendedStorageOptions options);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Gameloft.Tracking.EventConveyor.IEventConveyor CreateEventConveyor(TrackingContext context, IPersistentStorage storageInstance, ConveyorOptions options);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IUploadScheduler CreateScheduler(TrackingContext context, IPersistentStorage storageInstance, IServiceProtocol serviceInstance, SchedulerOptions options);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IEtsServiceProtocol CreateService(TrackingContext context, Session sessionInstance, ExtendedServiceOptions options);
	}
}
