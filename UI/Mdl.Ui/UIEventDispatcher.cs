using Cpp2IlInjected;
using Meta;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200082E")]
	public class UIEventDispatcher
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400304D")]
		[HideInInspector]
		public UnityEvent<bool> OnToolMenuChanged = (UnityEvent<bool>)(object)new UnityEvent<T0>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400304E")]
		[HideInInspector]
		public UnityEvent<bool> OnItemSelectorOnOff = (UnityEvent<bool>)(object)new UnityEvent<T0>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400304F")]
		[HideInInspector]
		public UnityEvent<bool> OnGenericAlertOnOff = (UnityEvent<bool>)(object)new UnityEvent<T0>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003050")]
		[HideInInspector]
		public UnityEvent OnNotEnoughMana = new UnityEvent();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003051")]
		[HideInInspector]
		public UnityEvent OnSomethingConsumed = new UnityEvent();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003052")]
		[HideInInspector]
		public UnityEvent<AddedFriendshipSummary> OnFriendshipAdded = (UnityEvent<AddedFriendshipSummary>)(object)new UnityEvent<T0>();

		[Cpp2IlInjected.Token(Token = "0x6003411")]
		[Cpp2IlInjected.Address(RVA = "0xC95E80", Offset = "0xC94880", VA = "0x180C95E80")]
		public UIEventDispatcher()
		{
		}
	}
}
