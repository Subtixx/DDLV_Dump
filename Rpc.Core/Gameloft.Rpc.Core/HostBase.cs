using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace Gameloft.Rpc.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class HostBase<TServiceType> : IDisposable where TServiceType : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly IReadOnlyDictionary<Type, TServiceType> services;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly IReadOnlyDictionary<Type, object> singletons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool disposedValue;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private IEnumerable<IDisposable> DisposableList
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1C1AE60", Offset = "0x1C19860", VA = "0x181C1AE60")]
			get
			{
				//Discarded unreachable code: IL_000e
				IReadOnlyDictionary<Type, object> readOnlyDictionary = ((HostBase<>)(object)this).singletons;
				IEnumerable<object> enumerable = default(IEnumerable<object>);
				return (IEnumerable<IDisposable>)Enumerable.Cast<IDisposable>((IEnumerable)enumerable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AA30", Offset = "0x1C19430", VA = "0x181C1AA30")]
		internal HostBase(IEnumerable<TServiceType> services, IReadOnlyDictionary<Type, object> singletons)
		{
			if ((object)typeof(_003C_003Ec).TypeHandle == null)
			{
			}
			Func<, > func = default(Func<, >);
			Dictionary<, > dictionary = (Dictionary<, >)(((HostBase<>)(object)this).services = (IReadOnlyDictionary<Type, TServiceType>)Enumerable.ToDictionary<_0021_00210, _0021_00211, _0021_00212>((IEnumerable<>)services, func, func));
			((HostBase<>)(object)this).singletons = singletons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xFB4AA0", Offset = "0xFB34A0", VA = "0x180FB4AA0")]
		public TConcreteType GetService<TConcreteType>() where TConcreteType : class, TServiceType
		{
			IReadOnlyDictionary<, > readOnlyDictionary = (IReadOnlyDictionary<, >)((HostBase<>)(object)this).services;
			Type type = default(Type);
			if ((object)type == null)
			{
			}
			if ((object)type != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xFB4980", Offset = "0xFB3380", VA = "0x180FB4980")]
		public TInstance GetInstance<TInstance>() where TInstance : class
		{
			IReadOnlyDictionary<Type, object> readOnlyDictionary = ((HostBase<>)(object)this).singletons;
			Type typeFromHandle = typeof(Type);
			if ((object)typeFromHandle == null)
			{
			}
			if ((object)typeFromHandle != null)
			{
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xFB4BD0", Offset = "0xFB35D0", VA = "0x180FB4BD0")]
		public bool HasInstance<TInstance>() where TInstance : class
		{
			IReadOnlyDictionary<Type, object> readOnlyDictionary = ((HostBase<>)(object)this).singletons;
			int num = 0;
			uint num2 = default(uint);
			Type type = default(Type);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					type = (Type)(object)((object)type + (object)type);
					throw new NullReferenceException();
				}
				num++;
			}
			return ((IReadOnlyDictionary<TKey, TValue>)readOnlyDictionary).ContainsKey((TKey)type);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A790", Offset = "0x1C19190", VA = "0x181C1A790", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
			//Discarded unreachable code: IL_0049, IL_004f
			int num = 0;
			IEnumerable<IDisposable> disposableList;
			if (disposing)
			{
				disposableList = (IEnumerable<IDisposable>)this.get_DisposableList();
				if (disposableList != null)
				{
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_002d;
						}
						num++;
					}
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					goto IL_002d;
				}
				goto IL_003d;
			}
			goto IL_0041;
			IL_003d:
			if (disposableList == null)
			{
			}
			goto IL_0041;
			IL_0041:
			((HostBase<>)(object)this).disposedValue = true;
			return;
			IL_002d:
			num += 312;
			num += 312;
			goto IL_003d;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A9B0", Offset = "0x1C193B0", VA = "0x181C1A9B0", Slot = "4")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_000e
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
