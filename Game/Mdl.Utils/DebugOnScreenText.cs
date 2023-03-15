using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200073F")]
	public class DebugOnScreenText : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000740")]
		public delegate void AddOnScreenText(StringBuilder dest);

		[Cpp2IlInjected.Token(Token = "0x4002A07")]
		private static GameObject _instanceGO;

		[Cpp2IlInjected.Token(Token = "0x4002A08")]
		private static DebugOnScreenText _instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002A09")]
		public Text onScreenText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A0B")]
		private StringBuilder stringBuffer;

		[Cpp2IlInjected.Token(Token = "0x17000493")]
		public static DebugOnScreenText Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6002041")]
			[Cpp2IlInjected.Address(RVA = "0x161B9C0", Offset = "0x161A3C0", VA = "0x18161B9C0")]
			get
			{
				//Discarded unreachable code: IL_005c
				//IL_000f: Expected O, but got I4
				//IL_0021: Expected O, but got I4
				DebugOnScreenText instance = _instance;
				int num = 0;
				if (instance == (UnityEngine.Object)num)
				{
					GameObject instanceGO = _instanceGO;
					int num2 = 0;
					if (instanceGO == (UnityEngine.Object)num2)
					{
						_instanceGO = new GameObject();
						_instanceGO.name = "DebugOnScreenTextInst";
						UnityEngine.Object.DontDestroyOnLoad(_instanceGO);
						_instanceGO = (GameObject)(object)_instanceGO.AddComponent<DebugOnScreenText>();
					}
				}
				return _instance;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000046")]
		public event AddOnScreenText OnAddOnScreenText
		{
			[Cpp2IlInjected.Token(Token = "0x6002042")]
			[Cpp2IlInjected.Address(RVA = "0x161B920", Offset = "0x161A320", VA = "0x18161B920")]
			[CompilerGenerated]
			add
			{
				AddOnScreenText onAddOnScreenText = this.OnAddOnScreenText;
				Delegate @delegate = Delegate.Combine(onAddOnScreenText, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAddOnScreenText)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002043")]
			[Cpp2IlInjected.Address(RVA = "0x161BB90", Offset = "0x161A590", VA = "0x18161BB90")]
			[CompilerGenerated]
			remove
			{
				AddOnScreenText onAddOnScreenText = this.OnAddOnScreenText;
				Delegate @delegate = Delegate.Remove(onAddOnScreenText, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onAddOnScreenText)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002044")]
		[Cpp2IlInjected.Address(RVA = "0x161B4C0", Offset = "0x1619EC0", VA = "0x18161B4C0")]
		public void Awake()
		{
			//IL_00a6: Expected O, but got I4
			UnityEngine.Object builtinResource = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
			int num = 0;
			if ((object)builtinResource == null || (object)builtinResource != null)
			{
				GameObject instanceGO = _instanceGO;
				Canvas canvas = instanceGO.AddComponent<Canvas>();
				CanvasScaler canvasScaler = instanceGO.AddComponent<CanvasScaler>();
				GraphicRaycaster graphicRaycaster = instanceGO.AddComponent<GraphicRaycaster>();
				Canvas component = instanceGO.GetComponent<Canvas>();
				int num2 = (int)(component.renderMode = RenderMode.ScreenSpaceOverlay);
				GameObject gameObject = new GameObject();
				gameObject.name = "debug_text";
				Transform transform = gameObject.transform;
				Transform transform3 = (transform.parent = instanceGO.transform);
				Text text = gameObject.AddComponent<Text>();
				Text text2 = (onScreenText = gameObject.GetComponent<Text>());
				onScreenText.font = (Font)num;
				onScreenText.text = "DebugOnScreenText\nDefault\nText";
				onScreenText.fontSize = 18;
				onScreenText.alignment = TextAnchor.MiddleLeft;
				onScreenText.horizontalOverflow = HorizontalWrapMode.Overflow;
				onScreenText.verticalOverflow = VerticalWrapMode.Overflow;
				RectTransform component2 = onScreenText.GetComponent<RectTransform>();
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002045")]
		[Cpp2IlInjected.Address(RVA = "0x161B830", Offset = "0x161A230", VA = "0x18161B830")]
		private void Start()
		{
			StringBuilder stringBuilder = (stringBuffer = new StringBuilder(2048));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002046")]
		[Cpp2IlInjected.Address(RVA = "0x161B8A0", Offset = "0x161A2A0", VA = "0x18161B8A0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0046
			StringBuilder stringBuilder = stringBuffer.Clear();
			AddOnScreenText onAddOnScreenText = this.OnAddOnScreenText;
			if (onAddOnScreenText != null)
			{
				StringBuilder dest = stringBuffer;
				onAddOnScreenText(dest);
			}
			StringBuilder stringBuilder2 = stringBuffer;
			Text text = onScreenText;
			string text2 = stringBuilder2.ToString();
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)text).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6002047")]
		[Cpp2IlInjected.Address(RVA = "0x161B8A0", Offset = "0x161A2A0", VA = "0x18161B8A0")]
		private void UpdateText()
		{
			//Discarded unreachable code: IL_0046
			StringBuilder stringBuilder = stringBuffer.Clear();
			AddOnScreenText onAddOnScreenText = this.OnAddOnScreenText;
			if (onAddOnScreenText != null)
			{
				StringBuilder dest = stringBuffer;
				onAddOnScreenText(dest);
			}
			StringBuilder stringBuilder2 = stringBuffer;
			Text text = onScreenText;
			string text2 = stringBuilder2.ToString();
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)text).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6002048")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugOnScreenText()
		{
		}
	}
}
