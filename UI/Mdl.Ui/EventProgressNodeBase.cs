using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000469")]
	[ExecuteInEditMode]
	public abstract class EventProgressNodeBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001666")]
		public EventProgressPivot Pivot;

		[Cpp2IlInjected.Token(Token = "0x6001C7E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract int GetStateValue();

		[Cpp2IlInjected.Token(Token = "0x6001C7F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RefreshDisplay();

		[Cpp2IlInjected.Token(Token = "0x6001C80")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected EventProgressNodeBase()
		{
		}
	}
}
