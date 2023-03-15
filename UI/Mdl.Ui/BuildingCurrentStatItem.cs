using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200029E")]
	[RequiredAllNotNull]
	public class BuildingCurrentStatItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000BCC")]
		public TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000BCD")]
		public TextBase _tfCurrent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000BCE")]
		public TextBase _tfDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000BCF")]
		public GameObject _mcDifference;

		[Cpp2IlInjected.Token(Token = "0x6001073")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public BuildingCurrentStatItem()
		{
		}
	}
}
