using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000843")]
	[RequiredAllNotNull]
	[RequireComponent(typeof(RectTransform))]
	public class FocusCursor : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030B6")]
		[SerializeField]
		private SpriteAtlasImage _cursorImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030B7")]
		[SerializeField]
		private AsyncAtlassedIcon _cursorExtraImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030B8")]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.Token(Token = "0x1700076D")]
		public SpriteAtlasImage CursorImage
		{
			[Cpp2IlInjected.Token(Token = "0x6003488")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _cursorImage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076E")]
		public AsyncAtlassedIcon CursorExtraImage
		{
			[Cpp2IlInjected.Token(Token = "0x6003489")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _cursorExtraImage;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700076F")]
		public RectTransform RectTransform
		{
			[Cpp2IlInjected.Token(Token = "0x600348A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _rectTransform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600348B")]
		[Cpp2IlInjected.Address(RVA = "0x1661010", Offset = "0x165FA10", VA = "0x181661010")]
		private void Awake()
		{
			RectTransform rectTransform = (_rectTransform = GetComponent<RectTransform>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600348C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FocusCursor()
		{
		}
	}
}
