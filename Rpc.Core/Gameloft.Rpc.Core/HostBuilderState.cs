using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class HostBuilderState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<Type, CreateDelegateInfo> delegateInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly Dictionary<Type, object> singletons = (Dictionary<Type, object>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		internal IReadOnlyDictionary<Type, object> Singletons
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				Dictionary<Type, object> dictionary = singletons;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x38DC590", Offset = "0x38DAF90", VA = "0x1838DC590")]
		internal HostBuilderState(IReadOnlyDictionary<Type, CreateDelegateInfo> delegateInfos)
		{
			Func<KeyValuePair<Type, CreateDelegateInfo>, Type> _003C_003E9__4_ = _003C_003Ec._003C_003E9__4_0;
			if (_003C_003E9__4_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			Func<KeyValuePair<Type, CreateDelegateInfo>, CreateDelegateInfo> func = default(Func<KeyValuePair<Type, CreateDelegateInfo>, CreateDelegateInfo>);
			if (_003C_003Ec._003C_003E9__4_1 == null)
			{
				func = (Func<KeyValuePair<Type, CreateDelegateInfo>, CreateDelegateInfo>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				});
			}
			Dictionary<Type, KeyValuePair<Type, CreateDelegateInfo>> dictionary = (Dictionary<Type, KeyValuePair<Type, CreateDelegateInfo>>)(object)(this.delegateInfos = (Dictionary<Type, CreateDelegateInfo>)(object)Enumerable.ToDictionary<KeyValuePair<Type, CreateDelegateInfo>, Type, CreateDelegateInfo>((IEnumerable<>)delegateInfos, (Func<, >)(object)_003C_003E9__4_, (Func<, >)(object)func));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x19AADA0", Offset = "0x19A97A0", VA = "0x1819AADA0")]
		public TInstance GetInstance<TInstance>() where TInstance : class
		{
			Type typeFromHandle = typeof(Type);
			object instance = GetInstance(typeFromHandle);
			if (instance == null)
			{
			}
			if (instance != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x38DC460", Offset = "0x38DAE60", VA = "0x1838DC460")]
		public unsafe object GetInstance(Type type)
		{
			Dictionary<Type, object> dictionary = singletons;
			int num = 0;
			if (!((Dictionary<TKey, TValue>)(object)dictionary).TryGetValue((TKey)type, out *(TValue*)num))
			{
				if (!((Dictionary<TKey, TValue>)(object)delegateInfos).TryGetValue((TKey)type, out *(TValue*)num))
				{
					int num2 = 0;
				}
				Dictionary<Type, object> dictionary2 = singletons;
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}
	}
}
