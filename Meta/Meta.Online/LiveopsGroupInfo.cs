using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Google.Protobuf;
using Newtonsoft.Json;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F2B")]
	public class LiveopsGroupInfo<T> : ILiveopsGroup where T : IFetchable, IMessage, new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000F2C")]
		private class LiveopsSerializeData
		{
			[Cpp2IlInjected.Token(Token = "0x170015B0")]
			public Dictionary<string, string> Data
			{
				[Cpp2IlInjected.Token(Token = "0x6007CAB")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return ((LiveopsGroupInfo<>.LiveopsSerializeData)(object)this)._003CData_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6007CAC")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					((LiveopsGroupInfo<>.LiveopsSerializeData)(object)this)._003CData_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007CAD")]
			[Cpp2IlInjected.Address(RVA = "0x29F92C0", Offset = "0x29F7CC0", VA = "0x1829F92C0")]
			public LiveopsSerializeData()
			{
				((LiveopsGroupInfo<>.LiveopsSerializeData)(object)this).Data = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
				base._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000F2D")]
		public class FetchActionResult
		{
			[Cpp2IlInjected.Token(Token = "0x170015B1")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x0"), Cpp2IlInjected.Token(Token = "0x4003DEE")]
			public bool IsSuccess
			{
				[Cpp2IlInjected.Token(Token = "0x6007CAE")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6007CAF")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170015B2")]
			public Dictionary<string, T> UpdatedData
			{
				[Cpp2IlInjected.Token(Token = "0x6007CB0")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x6007CB1")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015B3")]
			public List<string> IdsNotFound
			{
				[Cpp2IlInjected.Token(Token = "0x6007CB2")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
				[Cpp2IlInjected.Token(Token = "0x6007CB3")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170015B4")]
			public bool HasChanges
			{
				[Cpp2IlInjected.Token(Token = "0x6007CB4")]
				[Cpp2IlInjected.Address(RVA = "0x1ECC3C0", Offset = "0x1ECADC0", VA = "0x181ECC3C0")]
				get
				{
					//Discarded unreachable code: IL_0019
					if (((Dictionary<TKey, TValue>)(object)this.get_UpdatedData()).Count > 0)
					{
						return true;
					}
					List<string> idsNotFound = (List<string>)(object)this.get_IdsNotFound();
					bool result = default(bool);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6007CB5")]
			[Cpp2IlInjected.Address(RVA = "0x9130A0", Offset = "0x911AA0", VA = "0x1809130A0")]
			public FetchActionResult()
			{
			}//Discarded unreachable code: IL_0007

		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003DE7")]
		private readonly JsonSerializerSettings jsonSerializer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4003DE8")]
		protected readonly OnlineClient onlineClient;

		[Cpp2IlInjected.Token(Token = "0x170015A9")]
		public string LocalFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6007C9B")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return ((LiveopsGroupInfo<>)(object)this)._003CLocalFilename_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007C9C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
				((LiveopsGroupInfo<>)(object)this)._003CLocalFilename_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AA")]
		public Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6007C9D")]
			[Cpp2IlInjected.Address(RVA = "0x29F8FF0", Offset = "0x29F79F0", VA = "0x1829F8FF0", Slot = "6")]
			get
			{
				Type result = default(Type);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AB")]
		public Func<CancellationToken, List<KnownLiveopsItem>, Task<FetchActionResult>> FetchAction
		{
			[Cpp2IlInjected.Token(Token = "0x6007C9E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return ((LiveopsGroupInfo<>)(object)this)._003CFetchAction_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007C9F")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				((LiveopsGroupInfo<>)(object)this)._003CFetchAction_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AC")]
		public Func<CancellationToken, Dictionary<string, T>, Task<bool>> OnDataLoadedAction
		{
			[Cpp2IlInjected.Token(Token = "0x6007CA0")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return ((LiveopsGroupInfo<>)(object)this)._003COnDataLoadedAction_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007CA1")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			set
			{
				((LiveopsGroupInfo<>)(object)this)._003COnDataLoadedAction_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AD")]
		public Dictionary<string, T> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6007CA2")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return ((LiveopsGroupInfo<>)(object)this)._003CData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6007CA3")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			set
			{
				((LiveopsGroupInfo<>)(object)this)._003CData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AE")]
		public object RawData
		{
			[Cpp2IlInjected.Token(Token = "0x6007CA4")]
			[Cpp2IlInjected.Address(RVA = "0x91DDB0", Offset = "0x91C7B0", VA = "0x18091DDB0", Slot = "7")]
			get
			{
				string localFilename = ((ILiveopsGroup)this).LocalFilename;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170015AF")]
		public List<KnownLiveopsItem> KnownItems
		{
			[Cpp2IlInjected.Token(Token = "0x6007CA5")]
			[Cpp2IlInjected.Address(RVA = "0x29F9050", Offset = "0x29F7A50", VA = "0x1829F9050")]
			get
			{
				//Discarded unreachable code: IL_0016
				Dictionary<, > data = this.get_Data();
				if ((object)typeof(_003C_003Ec).TypeHandle == null)
				{
				}
				IEnumerable<> enumerable = default(IEnumerable<>);
				return (List<KnownLiveopsItem>)(object)Enumerable.ToList<KnownLiveopsItem>(enumerable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007CA6")]
		[Cpp2IlInjected.Address(RVA = "0x29F8EE0", Offset = "0x29F78E0", VA = "0x1829F8EE0")]
		public LiveopsGroupInfo(OnlineClient onlineClient)
		{
			((LiveopsGroupInfo<>)(object)this).jsonSerializer = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
				DefaultValueHandling = DefaultValueHandling.Ignore
			};
			((LiveopsGroupInfo<>)(object)this).Data = (Dictionary<string, T>)(object)new Dictionary<TKey, TValue>();
			base._002Ector();
			((LiveopsGroupInfo<>)(object)this).onlineClient = onlineClient;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007CA7")]
		[Cpp2IlInjected.Address(RVA = "0x29F8CE0", Offset = "0x29F76E0", VA = "0x1829F8CE0", Slot = "8")]
		[AsyncStateMachine(typeof(LiveopsGroupInfo<>._003CLoad_003Ed__27))]
		public Task Load(string serializedData, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6007CA8")]
		[Cpp2IlInjected.Address(RVA = "0x29F8B80", Offset = "0x29F7580", VA = "0x1829F8B80", Slot = "9")]
		[AsyncStateMachine(typeof(LiveopsGroupInfo<>._003CFetch_003Ed__28))]
		public Task<string> Fetch(bool forceRefreshAndReturn, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}
	}
}
