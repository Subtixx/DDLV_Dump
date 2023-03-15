using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class InterceptorBuilderBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly HashSet<Type> beforeTypes = (HashSet<Type>)(object)new HashSet<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HashSet<Type> afterTypes = (HashSet<Type>)(object)new HashSet<T>();

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4000014")]
		internal object InterceptorType
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal IEnumerable<Type> BeforeTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get
			{
				HashSet<Type> hashSet = beforeTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		internal IEnumerable<Type> AfterTypes
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				HashSet<Type> hashSet = afterTypes;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ServiceFilterFunc ServiceFilterFunc
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CServiceFilterFunc_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CServiceFilterFunc_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x38DDD80", Offset = "0x38DC780", VA = "0x1838DDD80")]
		public InterceptorBuilderBase(object interceptorType)
		{
			InterceptorType = interceptorType;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x19AC850", Offset = "0x19AB250", VA = "0x1819AC850")]
		public InterceptorBuilderBase Before<TInterceptorType>()
		{
			//Discarded unreachable code: IL_000f
			Type item = default(Type);
			bool flag = ((HashSet<T>)(object)beforeTypes).Add((T)item);
			return this;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x19AC7B0", Offset = "0x19AB1B0", VA = "0x1819AC7B0")]
		public InterceptorBuilderBase After<TInterceptorType>()
		{
			//Discarded unreachable code: IL_000f
			Type item = default(Type);
			bool flag = ((HashSet<T>)(object)afterTypes).Add((T)item);
			return this;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2E744A0", Offset = "0x2E72EA0", VA = "0x182E744A0")]
		public InterceptorBuilderBase Filter(ServiceFilterFunc serviceFilterFunc)
		{
			ServiceFilterFunc = serviceFilterFunc;
			return this;
		}
	}
}
