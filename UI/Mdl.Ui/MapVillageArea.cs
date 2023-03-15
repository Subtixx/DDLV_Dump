using Cpp2IlInjected;
using Definitions.Scene;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000641")]
	[RequiredAllNotNull]
	public class MapVillageArea : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002310")]
		[SerializeField]
		private VillageAreaType _areaType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002311")]
		public Image McImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002312")]
		public CanvasGroup CanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002313")]
		public CanvasGroup AreaNameCanvasGroup;

		[Cpp2IlInjected.Token(Token = "0x1700061D")]
		public VillageAreaType AreaType
		{
			[Cpp2IlInjected.Token(Token = "0x60028B3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return _areaType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60028B4")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MapVillageArea()
		{
		}
	}
}
