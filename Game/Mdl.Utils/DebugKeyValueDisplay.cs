using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Cpp2IlInjected;
using Definitions.Grid;
using Mdl.InputSystem;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200073D")]
	public class DebugKeyValueDisplay : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40029FF")]
		private Dictionary<string, Dictionary<string, string>> all_data = (Dictionary<string, Dictionary<string, string>>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002A00")]
		private float topOffset = 120f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002A01")]
		private int categoryFontSize = 18;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002A02")]
		private GUIStyle categoryStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002A03")]
		private int keyValueFontSize = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002A04")]
		private GUIStyle keyStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002A05")]
		private GUIStyle valueStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002A06")]
		private float screenColumnCount = 5f;

		[Cpp2IlInjected.Token(Token = "0x6002032")]
		[Cpp2IlInjected.Address(RVA = "0x1619880", Offset = "0x1618280", VA = "0x181619880")]
		private void Awake()
		{
			//Discarded unreachable code: IL_00f0
			//IL_004d: Expected O, but got I4
			//IL_009a: Expected O, but got I4
			//IL_00ef: Expected O, but got I4
			GUIStyle gUIStyle = (categoryStyle = new GUIStyle());
			GUIStyle gUIStyle2 = categoryStyle;
			int num = (int)(gUIStyle2.alignment = TextAnchor.UpperLeft);
			GUIStyle gUIStyle3 = categoryStyle;
			int num3 = (gUIStyle3.fontSize = categoryFontSize);
			GUIStyleState normal = categoryStyle.normal;
			int num4 = 0;
			normal.textColor = (Color)num4;
			GUIStyle gUIStyle4 = (keyStyle = new GUIStyle());
			keyStyle.alignment = TextAnchor.UpperRight;
			GUIStyle gUIStyle5 = keyStyle;
			int num6 = (gUIStyle5.fontSize = keyValueFontSize);
			GUIStyleState normal2 = keyStyle.normal;
			int num7 = 0;
			normal2.textColor = (Color)num7;
			GUIStyle gUIStyle6 = (valueStyle = new GUIStyle());
			GUIStyle gUIStyle7 = valueStyle;
			int num8 = (int)(gUIStyle7.alignment = TextAnchor.UpperLeft);
			GUIStyle gUIStyle8 = valueStyle;
			int num10 = (gUIStyle8.fontSize = keyValueFontSize);
			GUIStyleState normal3 = valueStyle.normal;
			int num11 = 0;
			normal3.textColor = (Color)num11;
		}

		[Cpp2IlInjected.Token(Token = "0x6002033")]
		[Cpp2IlInjected.Address(RVA = "0x1619F80", Offset = "0x1618980", VA = "0x181619F80")]
		private void OnGUI()
		{
			//Discarded unreachable code: IL_002c
			int num = 0;
			int num2 = 0;
			int width = Screen.width;
			int num3 = 0;
			int height = Screen.height;
			Dictionary<string, Dictionary<string, string>> dictionary = all_data;
			bool flag = default(bool);
			if (flag)
			{
				int num4 = 0;
				int num5 = keyValueFontSize;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002034")]
		[Cpp2IlInjected.Address(RVA = "0x1619C60", Offset = "0x1618660", VA = "0x181619C60")]
		private void OnGUI_DrawCategory(Vector2 position, Vector2 size, Dictionary<string, string> data)
		{
			//Discarded unreachable code: IL_0038, IL_003e, IL_0044
			//IL_0026: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			bool flag = default(bool);
			if (flag)
			{
			}
			string text = stringBuilder.ToString();
			GUI.Label((Rect)num, text, (GUIStyle)num);
			string text2 = stringBuilder2.ToString();
			GUI.Label((Rect)num2, text2, (GUIStyle)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x6002035")]
		[Cpp2IlInjected.Address(RVA = "0x1619B20", Offset = "0x1618520", VA = "0x181619B20")]
		private static (bool, DebugKeyValueDisplay) GetInstance()
		{
			//IL_0014: Expected O, but got I4
			DebugKeyValueDisplay component = SystemRoot.Instance.GetComponent<DebugKeyValueDisplay>();
			int num = 0;
			bool flag = component != (UnityEngine.Object)num;
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002036")]
		[Cpp2IlInjected.Address(RVA = "0x161A220", Offset = "0x1618C20", VA = "0x18161A220")]
		[Conditional("DEBUG")]
		public static void ResetValues(string category)
		{
			//Discarded unreachable code: IL_000a
			if ((object)DebugKeyValueDisplay.GetInstance() == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002037")]
		[Cpp2IlInjected.Address(RVA = "0x161A2A0", Offset = "0x1618CA0", VA = "0x18161A2A0")]
		[Conditional("DEBUG")]
		public static void UpdateValue(string category, string key, string value)
		{
			//Discarded unreachable code: IL_000e, IL_0012, IL_001e, IL_0024, IL_0028, IL_002f, IL_0035
			if ((object)DebugKeyValueDisplay.GetInstance() != null)
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002038")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG")]
		public static void UpdateValue(string category, string key, Vector3 value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002039")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG")]
		public static void UpdateValue(string category, string key, Vector2 value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600203A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG")]
		public static void UpdateValue(string category, string key, float value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600203B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG")]
		public static void UpdateValue(string category, string key, InputAction value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600203C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG")]
		public static void UpdateValue(string category, string key, bool value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600203D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		[Conditional("DEBUG")]
		public static void UpdateValue(string category, string key, GridPosition value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600203E")]
		[Cpp2IlInjected.Address(RVA = "0x161A440", Offset = "0x1618E40", VA = "0x18161A440")]
		public DebugKeyValueDisplay()
		{
		}//IL_0022: Expected I4, but got I8
		//IL_002c: Expected I4, but got I8

	}
}
