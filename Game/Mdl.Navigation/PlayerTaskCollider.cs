using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Utils;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C89")]
	[RequireComponent(typeof(Collider))]
	public class PlayerTaskCollider : MonoBehaviour, IPlayerTaskProvider
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000C8A")]
		public class Condition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4004631")]
			public bool not;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4004632")]
			[ItemID]
			public int condition;

			[Cpp2IlInjected.Token(Token = "0x60039FA")]
			[Cpp2IlInjected.Address(RVA = "0x1603510", Offset = "0x1601F10", VA = "0x181603510")]
			public Condition(bool not, int condition)
			{
				this.not = not;
				this.condition = condition;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400462B")]
		public PlayerTaskDefinition TaskDefinition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400462C")]
		public Transform Destination;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400462D")]
		public Transform CustomInteractionPreviewPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400462E")]
		public List<Condition> ActiveWhen = (List<Condition>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x400462F")]
		private static readonly ProfilerMarker s_checkConditions;

		[Cpp2IlInjected.Token(Token = "0x4004630")]
		private static readonly ProfilerMarker s_getComponents;

		[Cpp2IlInjected.Token(Token = "0x170007C6")]
		public IPlayerTaskConditional PlayerTaskConditional
		{
			[Cpp2IlInjected.Token(Token = "0x60039F4")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CPlayerTaskConditional_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60039F5")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CPlayerTaskConditional_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60039F6")]
		[Cpp2IlInjected.Address(RVA = "0xCAE870", Offset = "0xCAD270", VA = "0x180CAE870")]
		[IteratorStateMachine(typeof(_003CGetAllTasks_003Ed__11))]
		public IEnumerable<PlayerTaskDefinition> GetAllTasks()
		{
			new _003CGetAllTasks_003Ed__11(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039F7")]
		[Cpp2IlInjected.Address(RVA = "0xCAE8E0", Offset = "0xCAD2E0", VA = "0x180CAE8E0", Slot = "4")]
		[IteratorStateMachine(typeof(_003CGetTasks_003Ed__12))]
		public IEnumerable<PlayerTaskDefinition> GetTasks()
		{
			new _003CGetTasks_003Ed__12(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60039F8")]
		[Cpp2IlInjected.Address(RVA = "0xCAEA10", Offset = "0xCAD410", VA = "0x180CAEA10")]
		public PlayerTaskCollider()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60039F9")]
		[Cpp2IlInjected.Address(RVA = "0xCAE950", Offset = "0xCAD350", VA = "0x180CAE950")]
		static PlayerTaskCollider()
		{
			//IL_0021: Expected O, but got I
			//IL_003c: Expected O, but got I
			int num = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("CheckConditions", categoryId, (MarkerFlags)flags, metadataCount);
			int num2 = 0;
			s_checkConditions = (ProfilerMarker)(long)intPtr;
			int flags2 = 0;
			int metadataCount2 = 0;
			ushort categoryId2 = default(ushort);
			s_getComponents = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("GetComponents", categoryId2, (MarkerFlags)flags2, metadataCount2);
		}
	}
}
