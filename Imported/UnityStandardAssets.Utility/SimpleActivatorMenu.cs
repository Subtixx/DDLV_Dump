using System.Xml;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Text camSwitchButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public GameObject[] objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private int m_CurrentActiveObject;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1970", Offset = "0x3DC0370", VA = "0x183DC1970")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_002c
			//IL_0017: Expected I4, but got I8
			GameObject[] array = objects;
			Text text = camSwitchButton;
			m_CurrentActiveObject = 0;
			string text2 = array[0].name;
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)text).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1880", Offset = "0x3DC0280", VA = "0x183DC1880")]
		public void NextCamera()
		{
			//Discarded unreachable code: IL_0067
			GameObject[] array = objects;
			int currentActiveObject = m_CurrentActiveObject;
			currentActiveObject++;
			int num = 0;
			GameObject[] array2 = default(GameObject[]);
			if (num < array.Length)
			{
				GameObject gameObject = array[num];
				bool active = num == currentActiveObject;
				gameObject.SetActive(active);
				array2 = objects;
				num++;
			}
			Text text = camSwitchButton;
			m_CurrentActiveObject = currentActiveObject;
			string text2 = array2[currentActiveObject].name;
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)text).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SimpleActivatorMenu()
		{
		}
	}
}
