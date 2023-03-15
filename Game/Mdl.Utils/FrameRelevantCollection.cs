using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200074D")]
	public class FrameRelevantCollection<ObjectType> : IReadOnlyCollection<ObjectType>, IEnumerable<ObjectType>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200074E")]
		public class UpdateRelevancy : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002A27")]
			private readonly FrameRelevantCollection<ObjectType> state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002A28")]
			private readonly HashSet<ObjectType> deleteObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002A29")]
			private readonly HashSet<ObjectType> newObjects;

			[Cpp2IlInjected.Token(Token = "0x6002080")]
			[Cpp2IlInjected.Address(RVA = "0x2BE4640", Offset = "0x2BE3040", VA = "0x182BE4640")]
			public UpdateRelevancy(FrameRelevantCollection<ObjectType> state)
			{
				//Discarded unreachable code: IL_005b
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Expected I4, but got Unknown
				((FrameRelevantCollection<>.UpdateRelevancy)(object)this).deleteObjects = (HashSet<ObjectType>)(object)new HashSet<T>();
				((FrameRelevantCollection<>.UpdateRelevancy)(object)this).newObjects = (HashSet<ObjectType>)(object)new HashSet<T>();
				base._002Ector();
				((FrameRelevantCollection<>.UpdateRelevancy)(object)this).state = state;
				HashSet<> hashes = (HashSet<>)(object)((FrameRelevantCollection<>)(object)state).hashes;
				HashSet<> hashSet = (HashSet<>)(object)((FrameRelevantCollection<>.UpdateRelevancy)(object)this).deleteObjects;
				int num = 0;
				num += num;
				num++;
				num += 312;
				num += typeof(HashSet<ObjectType>.Enumerator).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x6002081")]
			[Cpp2IlInjected.Address(RVA = "0x2BE39F0", Offset = "0x2BE23F0", VA = "0x182BE39F0", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_000d
				EvictVagrants();
				((IDisposable)this).Dispose();
			}

			[Cpp2IlInjected.Token(Token = "0x6002082")]
			[Cpp2IlInjected.Address(RVA = "0x2BE4070", Offset = "0x2BE2A70", VA = "0x182BE4070")]
			private void NotifyNewTenants()
			{
				//Discarded unreachable code: IL_0029
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Expected I4, but got Unknown
				HashSet<> hashSet = (HashSet<>)(object)((FrameRelevantCollection<>.UpdateRelevancy)(object)this).newObjects;
				FrameRelevantCollection<> frameRelevantCollection = (FrameRelevantCollection<>)(object)((FrameRelevantCollection<>.UpdateRelevancy)(object)this).state;
				int num = 0;
				num += num;
				num++;
				num += 312;
				num += typeof(HashSet<ObjectType>.Enumerator).TypeHandle;
			}

			[Cpp2IlInjected.Token(Token = "0x6002083")]
			[Cpp2IlInjected.Address(RVA = "0x2BE3A50", Offset = "0x2BE2450", VA = "0x182BE3A50")]
			private void EvictVagrants()
			{
				//Discarded unreachable code: IL_0057, IL_005d, IL_0063
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Expected I4, but got Unknown
				HashSet<> hashSet = (HashSet<>)(object)((FrameRelevantCollection<>.UpdateRelevancy)(object)this).deleteObjects;
				HashSet<> hashes = (HashSet<>)(object)((FrameRelevantCollection<>)(object)((FrameRelevantCollection<>.UpdateRelevancy)(object)this).state).hashes;
				int num = 0;
				num += num;
				num++;
				num += 312;
				if (num + typeof(HashSet<ObjectType>.Enumerator).TypeHandle != 0)
				{
				}
				int num2 = 0;
				num2 += num2;
				num2++;
				num2 += 312;
			}

			[Cpp2IlInjected.Token(Token = "0x6002084")]
			[Cpp2IlInjected.Address(RVA = "0x2BE3870", Offset = "0x2BE2270", VA = "0x182BE3870")]
			public void Add(ObjectType o)
			{
				//Discarded unreachable code: IL_002e
				if (((HashSet<T>)(object)((FrameRelevantCollection<>)(object)((FrameRelevantCollection<>.UpdateRelevancy)(object)this).state).hashes).Add((T)o))
				{
					bool flag = ((HashSet<T>)(object)((FrameRelevantCollection<>.UpdateRelevancy)(object)this).newObjects).Add((T)o);
				}
				RepeatedField<TagGroupWithRndOption> tags = (RepeatedField<TagGroupWithRndOption>)(object)((IHasTagsRnd)((FrameRelevantCollection<>.UpdateRelevancy)(object)this).deleteObjects).get_Tags();
			}

			[Cpp2IlInjected.Token(Token = "0x6002085")]
			[Cpp2IlInjected.Address(RVA = "0x2BE34F0", Offset = "0x2BE1EF0", VA = "0x182BE34F0")]
			public void AddRange(IEnumerable<ObjectType> withObjects)
			{
				//Discarded unreachable code: IL_000b, IL_0011
				int num = 0;
				num += num;
				num++;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4002A24")]
		protected readonly HashSet<ObjectType> hashes;

		[Cpp2IlInjected.Token(Token = "0x17000498")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600207C")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDEE0", Offset = "0x1FDC8E0", VA = "0x181FDDEE0", Slot = "4")]
			get
			{
				RepeatedField<TagGroupWithRndOption> tags = (RepeatedField<TagGroupWithRndOption>)(object)((IHasTagsRnd)((FrameRelevantCollection<>)(object)this).hashes).get_Tags();
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000047")]
		public event EventHandler<ObjectType> OnBecameRelevant
		{
			[Cpp2IlInjected.Token(Token = "0x6002075")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDD60", Offset = "0x1FDC760", VA = "0x181FDDD60")]
			[CompilerGenerated]
			add
			{
				EventHandler<> onBecameRelevant = (EventHandler<>)(object)((FrameRelevantCollection<>)(object)this).OnBecameRelevant;
				Delegate @delegate = Delegate.Combine(onBecameRelevant, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onBecameRelevant)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002076")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDF10", Offset = "0x1FDC910", VA = "0x181FDDF10")]
			[CompilerGenerated]
			remove
			{
				EventHandler<> onBecameRelevant = (EventHandler<>)(object)((FrameRelevantCollection<>)(object)this).OnBecameRelevant;
				Delegate @delegate = Delegate.Remove(onBecameRelevant, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onBecameRelevant)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000048")]
		public event EventHandler<ObjectType> OnLostRelevant
		{
			[Cpp2IlInjected.Token(Token = "0x6002077")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDE20", Offset = "0x1FDC820", VA = "0x181FDDE20")]
			[CompilerGenerated]
			add
			{
				EventHandler<> onLostRelevant = (EventHandler<>)(object)((FrameRelevantCollection<>)(object)this).OnLostRelevant;
				Delegate @delegate = Delegate.Combine(onLostRelevant, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onLostRelevant)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002078")]
			[Cpp2IlInjected.Address(RVA = "0x1FDDFD0", Offset = "0x1FDC9D0", VA = "0x181FDDFD0")]
			[CompilerGenerated]
			remove
			{
				EventHandler<> onLostRelevant = (EventHandler<>)(object)((FrameRelevantCollection<>)(object)this).OnLostRelevant;
				Delegate @delegate = Delegate.Remove(onLostRelevant, value);
				if ((object)@delegate == null)
				{
				}
				if ((object)@delegate != null)
				{
					while ((object)@delegate != onLostRelevant)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002079")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDC70", Offset = "0x1FDC670", VA = "0x181FDDC70")]
		public UpdateRelevancy UpdateFrameRelevancy()
		{
			return new UpdateRelevancy((FrameRelevantCollection<>)(object)this);
		}

		[Cpp2IlInjected.Token(Token = "0x600207A")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDAC0", Offset = "0x1FDC4C0", VA = "0x181FDDAC0", Slot = "7")]
		protected virtual void FireAdded(ObjectType o)
		{
			EventHandler<> onBecameRelevant = (EventHandler<>)(object)((FrameRelevantCollection<>)(object)this).OnBecameRelevant;
			if (onBecameRelevant != null)
			{
				object obj = ((ICloneable)onBecameRelevant).Clone();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600207B")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDB40", Offset = "0x1FDC540", VA = "0x181FDDB40", Slot = "8")]
		protected virtual void FireRemoved(ObjectType o)
		{
			EventHandler<> onLostRelevant = (EventHandler<>)(object)((FrameRelevantCollection<>)(object)this).OnLostRelevant;
			if (onLostRelevant != null)
			{
				object obj = ((ICloneable)onLostRelevant).Clone();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600207D")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDBF0", Offset = "0x1FDC5F0", VA = "0x181FDDBF0", Slot = "5")]
		public IEnumerator<ObjectType> GetEnumerator()
		{
			HashSet<> hashSet = (HashSet<>)(object)((FrameRelevantCollection<>)(object)this).hashes;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600207E")]
		[Cpp2IlInjected.Address(RVA = "0x1A3ECF0", Offset = "0x1A3D6F0", VA = "0x181A3ECF0", Slot = "6")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			//Discarded unreachable code: IL_0007
			return ((IEnumerable)this).GetEnumerator();
		}

		[Cpp2IlInjected.Token(Token = "0x600207F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDDCE0", Offset = "0x1FDC6E0", VA = "0x181FDDCE0")]
		public FrameRelevantCollection()
		{
			((FrameRelevantCollection<>)(object)this).hashes = (HashSet<ObjectType>)(object)new HashSet<T>();
			base._002Ector();
		}
	}
}
