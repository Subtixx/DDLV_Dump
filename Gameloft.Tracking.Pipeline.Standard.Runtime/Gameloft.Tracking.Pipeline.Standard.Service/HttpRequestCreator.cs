using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Gameloft.Tracking.Events;
using Gameloft.Tracking.Pipeline.Standard.Events;
using Gameloft.Tracking.Pipeline.Standard.Serialization.Binary;
using Gameloft.Tracking.Service;
using Gameloft.Tracking.Storage;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal abstract class HttpRequestCreator : IHttpRequestCreator
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x28C2110", Offset = "0x28C0B10", VA = "0x1828C2110", Slot = "4")]
			get
			{
				return EventPackage?.IsEmpty ?? true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected OnlineEnvironment Environment
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1D26310", Offset = "0x1D24D10", VA = "0x181D26310")]
			[CompilerGenerated]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x28C2130", Offset = "0x28C0B30", VA = "0x1828C2130")]
			[CompilerGenerated]
			private set
			{
				EventScope eventScope = (EventScope)(_003CEnvironment_003Ek__BackingField = (OnlineEnvironment)value.EventScope);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected EtsPackage EventPackage
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CEventPackage_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CEventPackage_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x400006C")]
		protected int MaxEventsPerPackage
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x28C20D0", Offset = "0x28C0AD0", VA = "0x1828C20D0")]
		protected HttpRequestCreator(ServiceOptions options)
		{
			//Discarded unreachable code: IL_0015
			int num = (MaxEventsPerPackage = options.maxNumberOfEventsPerPackage);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract HttpRequestMessage CreateRequest();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x28C1A80", Offset = "0x28C0480", VA = "0x1828C1A80", Slot = "8")]
		public virtual void Build(OnlineEnvironment env, IEventsSelection selection, Session session)
		{
			//Discarded unreachable code: IL_00a3, IL_00a9, IL_00af
			IEnumerable<StandardEvent> enumerable2;
			IEnumerable<StandardEvent> enumerable = default(IEnumerable<StandardEvent>);
			EtsPackage etsPackage = default(EtsPackage);
			int num3;
			do
			{
				int num = 0;
				EventScope eventScope = (EventScope)(Environment = (OnlineEnvironment)env.EventScope);
				int num2 = MaxEventsPerPackage;
				enumerable2 = (IEnumerable<StandardEvent>)Enumerable.Take<StandardEvent>((IEnumerable<>)enumerable, num2);
				Func<StandardEvent, EventData> _003C_003E9__2_ = EtsPackage._003C_003Ec._003C_003E9__2_0;
				if (_003C_003E9__2_ == null)
				{
					EtsPackage._003C_003Ec._003C_003E9 = (EtsPackage._003C_003Ec)(object)(Func<T, TResult>)((StandardEvent e) => e.EventData);
				}
				List<EventData> list = (List<EventData>)(((Package)etsPackage).Events = (IReadOnlyCollection<object>)Enumerable.ToList<EventData>(Enumerable.Select<StandardEvent, EventData>((IEnumerable<>)enumerable2, (Func<, >)(object)_003C_003E9__2_)));
				etsPackage.Initialize();
				EventPackage = etsPackage;
				num3 = 0;
			}
			while (enumerable2 != null);
			if ((long)num3 < (long)(IntPtr)typeof(IDisposable).TypeHandle)
			{
				num3 += num3;
				if ((object)"{il2cpp array field local7->}" == (object)typeof(IEventsSelection).TypeHandle)
				{
					goto IL_0098;
				}
				num3++;
			}
			if (num3 == 0)
			{
				return;
			}
			goto IL_0098;
			IL_0098:
			num3 += 328;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x28C1E60", Offset = "0x28C0860", VA = "0x1828C1E60")]
		public static IHttpRequestCreator Create(ServiceOptions options)
		{
			do
			{
				int num = 0;
			}
			while (false);
			JsonHttpRequestCreator jsonHttpRequestCreator = new JsonHttpRequestCreator((ServiceOptions)(object)"application/json");
			if ((long)new MediaTypeHeaderValue("application/json") == 1)
			{
				BinaryHttpRequestCreator binaryHttpRequestCreator = new BinaryHttpRequestCreator((ServiceOptions)(object)"application/gl-stream");
				MediaTypeHeaderValue mediaTypeHeaderValue = (binaryHttpRequestCreator.contentType = new MediaTypeHeaderValue("application/gl-stream"));
				BinaryFormatter binaryFormatter = (binaryHttpRequestCreator.formatter = new BinaryFormatter());
				int num2 = (binaryHttpRequestCreator.MaxEventsPerPackage = options.maxNumberOfEventsPerPackage);
				throw new NullReferenceException();
			}
			string message = default(string);
			ArgumentException ex = new ArgumentException(message);
			/*Error: Unexpected end of block*/;
		}
	}
}
