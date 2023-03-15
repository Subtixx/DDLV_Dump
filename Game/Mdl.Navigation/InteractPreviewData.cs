using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C4D")]
	[CreateAssetMenu]
	public class InteractPreviewData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004498")]
		[SerializeField]
		private string _text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004499")]
		[SerializeField]
		private bool _showOutline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400449A")]
		[SerializeField]
		private bool _holdButton;

		[Cpp2IlInjected.Token(Token = "0x1700078F")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600386D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000790")]
		public bool ShowOutline
		{
			[Cpp2IlInjected.Token(Token = "0x600386E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
			get
			{
				return _showOutline;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000791")]
		public bool HoldButton
		{
			[Cpp2IlInjected.Token(Token = "0x600386F")]
			[Cpp2IlInjected.Address(RVA = "0xBA1880", Offset = "0xBA0280", VA = "0x180BA1880")]
			get
			{
				return _holdButton;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003870")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public InteractPreviewData()
		{
		}
	}
}
