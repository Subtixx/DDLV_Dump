using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000037")]
public class GenericObjectDither : MonoBehaviour, IDitherable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[SerializeField]
	private bool _shouldDither = true;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EventHandler DitherableDestroyEvent
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8CA530", Offset = "0x8C8F30", VA = "0x1808CA530", Slot = "6")]
		[CompilerGenerated]
		add
		{
			EventHandler ditherableDestroyEvent = this.DitherableDestroyEvent;
			Delegate @delegate = Delegate.Combine(ditherableDestroyEvent, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != ditherableDestroyEvent)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8CA5D0", Offset = "0x8C8FD0", VA = "0x1808CA5D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
			EventHandler ditherableDestroyEvent = this.DitherableDestroyEvent;
			Delegate @delegate = Delegate.Remove(ditherableDestroyEvent, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != ditherableDestroyEvent)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8CA490", Offset = "0x8C8E90", VA = "0x1808CA490", Slot = "5")]
	public GameObject GetDitherableGameObject()
	{
		return base.gameObject;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0", Slot = "4")]
	public bool ShouldDither()
	{
		return _shouldDither;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8CA4A0", Offset = "0x8C8EA0", VA = "0x1808CA4A0")]
	private void OnDestroy()
	{
		if (this.DitherableDestroyEvent == null)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x8CA520", Offset = "0x8C8F20", VA = "0x1808CA520")]
	public GenericObjectDither()
	{
	}
}
