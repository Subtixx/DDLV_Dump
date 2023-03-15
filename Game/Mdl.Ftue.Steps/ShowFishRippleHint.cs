using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Scene;
using Mdl.Activities;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Steps
{
	[Cpp2IlInjected.Token(Token = "0x2000591")]
	[CreateAssetMenu]
	public class ShowFishRippleHint : FtueStep, IWorldHint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002250")]
		public VillageAreaType fishLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002251")]
		public float colliderRadius = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002252")]
		public Vector3 worldObjectOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002253")]
		public float zoom = -1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002254")]
		public string messageKey = "tutorial_fishing_ripple_hint";

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002255")]
		public BubblePosition bubblePosition;

		[Cpp2IlInjected.Token(Token = "0x1700035D")]
		public FishRipple RippleToSelect
		{
			[Cpp2IlInjected.Token(Token = "0x60018D9")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CRippleToSelect_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60018DA")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			private set
			{
				_003CRippleToSelect_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035E")]
		public string MessageKey
		{
			[Cpp2IlInjected.Token(Token = "0x60018DB")]
			[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740", Slot = "5")]
			get
			{
				return messageKey;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700035F")]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x60018DC")]
			[Cpp2IlInjected.Address(RVA = "0xF50530", Offset = "0xF4EF30", VA = "0x180F50530", Slot = "6")]
			get
			{
				Vector3 vector = default(Vector3);
				float z = vector.z;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000360")]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x60018DD")]
			[Cpp2IlInjected.Address(RVA = "0xBC59C0", Offset = "0xBC43C0", VA = "0x180BC59C0", Slot = "7")]
			get
			{
				return colliderRadius;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000361")]
		public float Zoom
		{
			[Cpp2IlInjected.Token(Token = "0x60018DE")]
			[Cpp2IlInjected.Address(RVA = "0xD392E0", Offset = "0xD37CE0", VA = "0x180D392E0", Slot = "8")]
			get
			{
				return zoom;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000362")]
		public Collider Collider
		{
			[Cpp2IlInjected.Token(Token = "0x60018DF")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000363")]
		public WorldHintCompletion Completion
		{
			[Cpp2IlInjected.Token(Token = "0x60018E0")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "10")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000364")]
		public BubblePosition BubblePosition
		{
			[Cpp2IlInjected.Token(Token = "0x60018E1")]
			[Cpp2IlInjected.Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950", Slot = "11")]
			get
			{
				return bubblePosition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000365")]
		public bool RecenterCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60018E2")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "12")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018E3")]
		[Cpp2IlInjected.Address(RVA = "0xF50030", Offset = "0xF4EA30", VA = "0x180F50030", Slot = "4")]
		[AsyncStateMachine(typeof(_003CDoExecute_003Ed__26))]
		protected override Task<FtueResult> DoExecute(FtueResult result, Client client, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result2 = default(Task<>);
			return (Task<FtueResult>)(object)result2;
		}

		[Cpp2IlInjected.Token(Token = "0x60018E4")]
		[Cpp2IlInjected.Address(RVA = "0xF503F0", Offset = "0xF4EDF0", VA = "0x180F503F0")]
		private unsafe IEnumerable<FishRipple> GetValidRipples(IEnumerable<FishRipple> ripples, VillageAreaType location)
		{
			//Discarded unreachable code: IL_0024
			Func<FishRipple, bool> func = (Func<FishRipple, bool>)(object)(Func<T, TResult>)((FishRipple r) => (IntPtr)(void*)r.BodyOfWater.VillageArea == (IntPtr)(void*)(int)location);
			return (IEnumerable<FishRipple>)Enumerable.Where<FishRipple>((IEnumerable<>)ripples, (Func<, >)(object)func);
		}

		[Cpp2IlInjected.Token(Token = "0x60018E5")]
		[Cpp2IlInjected.Address(RVA = "0xF50190", Offset = "0xF4EB90", VA = "0x180F50190")]
		private FishRipple FindClosest(IEnumerable<FishRipple> ripples, Vector3 position)
		{
			//Discarded unreachable code: IL_0047, IL_004d, IL_0053
			int num = 0;
			int num2 = 0;
			int num4 = default(int);
			float z2 = default(float);
			if (num != 0)
			{
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					if (num2 == (int)num3)
					{
						goto IL_002c;
					}
					num2++;
				}
				Vector3 vector = default(Vector3);
				float z = vector.z;
				z2 = position.z;
				num4 = 0;
				goto IL_002c;
			}
			goto IL_003d;
			IL_003d:
			if (num != 0)
			{
			}
			throw new NullReferenceException();
			IL_002c:
			num4 += num4;
			z2 += 4.37E-43f;
			goto IL_003d;
		}

		[Cpp2IlInjected.Token(Token = "0x60018E6")]
		[Cpp2IlInjected.Address(RVA = "0xF504D0", Offset = "0xF4EED0", VA = "0x180F504D0")]
		public ShowFishRippleHint()
		{
		}
	}
}
