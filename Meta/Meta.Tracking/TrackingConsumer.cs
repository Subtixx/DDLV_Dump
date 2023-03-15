using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A8C")]
	public abstract class TrackingConsumer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002944")]
		protected List<string> observedEvents;

		[Cpp2IlInjected.Token(Token = "0x17000FA6")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6005B74")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6005B75")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FA7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4002946")]
		public bool IsMain
		{
			[Cpp2IlInjected.Token(Token = "0x6005B76")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005B77")]
			[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B73")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void TrackEvent(TrackingEventBase trackingEvent, bool isHighPriority = false);

		[Cpp2IlInjected.Token(Token = "0x6005B78")]
		[Cpp2IlInjected.Address(RVA = "0x78B9B0", Offset = "0x78A3B0", VA = "0x18078B9B0")]
		public TrackingConsumer()
		{
			List<string> list = (observedEvents = (List<string>)(object)new List<T>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B79")]
		[Cpp2IlInjected.Address(RVA = "0x78B8C0", Offset = "0x78A2C0", VA = "0x18078B8C0", Slot = "5")]
		public virtual bool ShouldTrack(TrackingEventBase trackingEvent)
		{
			//Discarded unreachable code: IL_0029
			List<string> cpp2il__autoParamName__idx_ = observedEvents;
			Func<string, bool> cpp2il__autoParamName__idx_2 = (Func<string, bool>)(object)(Func<T, TResult>)delegate(string x)
			{
				//Discarded unreachable code: IL_0014
				string eventName = trackingEvent.EventName;
				return x.Equals(eventName);
			};
			return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<string>((Func<, >)(object)cpp2il__autoParamName__idx_2);
		}

		[Cpp2IlInjected.Token(Token = "0x6005B7A")]
		[Cpp2IlInjected.Address(RVA = "0x78B7B0", Offset = "0x78A1B0", VA = "0x18078B7B0", Slot = "6")]
		protected virtual object GetComplexParam(object compParam)
		{
			if (compParam != null)
			{
				int num = 0;
				if (compParam != null)
				{
					object result = default(object);
					return result;
				}
				int num2 = 0;
				object result2 = default(object);
				if (compParam != null)
				{
					return result2;
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005B7B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract object GetProduct(TrackingProducts complexParamProduct);

		[Cpp2IlInjected.Token(Token = "0x6005B7C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract object GetReward(TrackingRewards complexParamReward);
	}
}
