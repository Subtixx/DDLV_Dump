using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue
{
	[Cpp2IlInjected.Token(Token = "0x200056C")]
	public abstract class FtueCondition : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200056D")]
		public delegate void BecameTrue(FtueCondition condition);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002194")]
		public bool inverse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002195")]
		public List<FtueCondition> preConditions = (List<FtueCondition>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002196")]
		private Client client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002197")]
		private bool init;

		[Cpp2IlInjected.Token(Token = "0x14000039")]
		public event BecameTrue OnBecameTrue
		{
			[Cpp2IlInjected.Token(Token = "0x600183F")]
			[Cpp2IlInjected.Address(RVA = "0x1471590", Offset = "0x146FF90", VA = "0x181471590")]
			[CompilerGenerated]
			add
			{
				BecameTrue onBecameTrue = this.OnBecameTrue;
				Delegate @delegate = Delegate.Combine(onBecameTrue, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBecameTrue)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001840")]
			[Cpp2IlInjected.Address(RVA = "0x1471630", Offset = "0x1470030", VA = "0x181471630")]
			[CompilerGenerated]
			remove
			{
				BecameTrue onBecameTrue = this.OnBecameTrue;
				Delegate @delegate = Delegate.Remove(onBecameTrue, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onBecameTrue)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001841")]
		[Cpp2IlInjected.Address(RVA = "0x1471100", Offset = "0x146FB00", VA = "0x181471100")]
		public void Init(Client client)
		{
			//Discarded unreachable code: IL_003d, IL_0043
			int num = 0;
			this.client = client;
			init = (byte)num != 0;
			List<FtueCondition> list = preConditions;
			bool flag = default(bool);
			if (flag)
			{
				BecameTrue becameTrue = OnPreConditionBecameTrue;
				BecameTrue becameTrue2 = OnPreConditionBecameTrue;
			}
			bool flag2 = default(bool);
			if (!flag2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001842")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void _Init(Client client);

		[Cpp2IlInjected.Token(Token = "0x6001843")]
		[Cpp2IlInjected.Address(RVA = "0x1471360", Offset = "0x146FD60", VA = "0x181471360")]
		private bool PreConditionsAreTrue()
		{
			//Discarded unreachable code: IL_0029, IL_002f
			int num2;
			bool flag = default(bool);
			while (true)
			{
				int num = 0;
				num2 = 0;
				List<FtueCondition> list = preConditions;
				if (!flag)
				{
					break;
				}
				if (flag)
				{
					int num3 = 0;
					num2++;
					break;
				}
			}
			if (num2 + 1 != 0)
			{
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6001844")]
		[Cpp2IlInjected.Address(RVA = "0x1471320", Offset = "0x146FD20", VA = "0x181471320")]
		private void OnPreConditionBecameTrue(FtueCondition c)
		{
			if (PreConditionsAreTrue())
			{
				CleanUpPreconditions();
				Client client = this.client;
				_Init(client);
				init = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001845")]
		[Cpp2IlInjected.Address(RVA = "0x1470F70", Offset = "0x146F970", VA = "0x181470F70")]
		private void CleanUpPreconditions()
		{
			//Discarded unreachable code: IL_0019
			List<FtueCondition> list = preConditions;
			bool flag = default(bool);
			if (flag)
			{
				BecameTrue becameTrue = OnPreConditionBecameTrue;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001846")]
		[Cpp2IlInjected.Address(RVA = "0x14712E0", Offset = "0x146FCE0", VA = "0x1814712E0")]
		public bool IsTrue()
		{
			if (init)
			{
				if (!inverse)
				{
					_CleanUp();
				}
				return !_IsTrue();
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001847")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "5")]
		protected virtual bool _IsTrue()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001848")]
		[Cpp2IlInjected.Address(RVA = "0x9B5670", Offset = "0x9B4070", VA = "0x1809B5670")]
		protected void RaiseBecameTrue()
		{
			this.OnBecameTrue?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001849")]
		[Cpp2IlInjected.Address(RVA = "0x14710C0", Offset = "0x146FAC0", VA = "0x1814710C0")]
		public void CleanUp()
		{
			CleanUpPreconditions();
			_CleanUp();
			init = false;
		}

		[Cpp2IlInjected.Token(Token = "0x600184A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void _CleanUp();

		[Cpp2IlInjected.Token(Token = "0x600184B")]
		[Cpp2IlInjected.Address(RVA = "0x1471510", Offset = "0x146FF10", VA = "0x181471510")]
		protected FtueCondition()
		{
		}
	}
}
