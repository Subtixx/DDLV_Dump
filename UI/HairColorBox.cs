using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Ui;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000062")]
public class HairColorBox : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	[SerializeField]
	public BaseButton _topButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	[SerializeField]
	public BaseButton _bottomButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	[SerializeField]
	public BaseButton _leftButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	[SerializeField]
	public BaseButton _rightButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private List<BaseButton> _allButtons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private Dictionary<BaseButton, bool> _allButtonsState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	[SerializeField]
	public float ScrollSpeed = 60f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private float _modifier = 1f;

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xAE2750", Offset = "0xAE1150", VA = "0x180AE2750")]
	private void OnEnable()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0xAE24F0", Offset = "0xAE0EF0", VA = "0x180AE24F0")]
	private void OnDisable()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xAE2370", Offset = "0xAE0D70", VA = "0x180AE2370")]
	private void OnReleaseKillAll(BaseButton button)
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0xAE2370", Offset = "0xAE0D70", VA = "0x180AE2370")]
	private void KillAll()
	{
		throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xAE2A90", Offset = "0xAE1490", VA = "0x180AE2A90")]
	private void OnPressed(BaseButton button)
	{
		//Discarded unreachable code: IL_000e
		//IL_000d: Expected O, but got I4
		((Dictionary<TKey, TValue>)(object)_allButtonsState)[(TKey)button] = (TValue)1;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xAE2AF0", Offset = "0xAE14F0", VA = "0x180AE2AF0")]
	public HairColorBox()
	{
	}
}
