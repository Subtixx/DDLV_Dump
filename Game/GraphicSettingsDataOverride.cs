using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200004F")]
[CreateAssetMenu]
public class GraphicSettingsDataOverride : ScriptableObject
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class FloatSetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public float Value;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FloatSetting()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class FloatArraySetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[NonReorderable]
		public float[] Value = new float[32];

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1042240", Offset = "0x1040C40", VA = "0x181042240")]
		public FloatArraySetting()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class LevelList
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public string Level;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[NonReorderable]
		public List<string> Platforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[NonReorderable]
		public List<FloatSetting> FloatSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[NonReorderable]
		public List<FloatArraySetting> FloatArraySetting;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public LevelList()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	[SerializeField]
	[NonReorderable]
	public List<LevelList> Overrides;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xCE1A00", Offset = "0xCE0400", VA = "0x180CE1A00")]
	public void ApplySettingsOverride([Optional] string levelName)
	{
		//Discarded unreachable code: IL_00f3, IL_00f9, IL_00ff, IL_0105, IL_010b, IL_0111, IL_0117, IL_011d, IL_0123, IL_0129, IL_012f, IL_0135, IL_013b, IL_0141, IL_0147, IL_014d, IL_0153, IL_0159, IL_015f, IL_0165
		//IL_00c9: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		//IL_00ec: Expected O, but got I4
		//IL_00ec: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		List<GraphicSettingsData> originalGraphicSettingsData = GraphicSettings.Instance.OriginalGraphicSettingsData;
		object syncRoot = ((List<>)(object)originalGraphicSettingsData)._syncRoot;
		int size = ((List<>)(object)originalGraphicSettingsData)._size;
		num4++;
		object syncRoot2 = ((List<>)(object)originalGraphicSettingsData)._syncRoot;
		if (_003C_003Ec._003C_003E9__4_0 == null)
		{
			_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GraphicSettingsData x)
			{
				//Discarded unreachable code: IL_000f
				//IL_000f: Expected I4, but got O
				string text = x.Name;
				int num7 = 0;
				return (byte)(int)typeof(GraphicSettings).TypeHandle != 0;
			};
		}
		IEnumerable<GraphicSettingsData> enumerable = default(IEnumerable<GraphicSettingsData>);
		GraphicSettingsData graphicSettingsData = Enumerable.FirstOrDefault<GraphicSettingsData>((IEnumerable<>)enumerable);
		int num5 = 0;
		Type typeFromHandle = typeof(GraphicSettingsData);
		bool flag = default(bool);
		if (flag)
		{
			bool flag2 = default(bool);
			while (!flag2)
			{
			}
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			if (flag3 && flag4)
			{
				bool flag5 = default(bool);
				while (!flag5)
				{
				}
				bool flag6 = default(bool);
				if (flag6)
				{
					FieldInfo fieldInfo = default(FieldInfo);
					while ((object)fieldInfo == null)
					{
					}
					Type fieldType = fieldInfo.FieldType;
					Type typeFromHandle2 = typeof(bool);
					if (!((object)fieldType).Equals((object)typeFromHandle2))
					{
						bool isEnum = fieldType.IsEnum;
						if (!isEnum)
						{
							object obj = Convert.ChangeType(isEnum, fieldType);
						}
					}
					bool flag7 = default(bool);
					fieldInfo.SetValue(num2, flag7);
				}
				bool flag8 = default(bool);
				if (flag8)
				{
					int num6 = 0;
					FieldInfo fieldInfo2 = default(FieldInfo);
					while ((object)fieldInfo2 == null)
					{
					}
					fieldInfo2.SetValue(num2, num6);
				}
			}
		}
		Debug.LogException((Exception)num4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
	public GraphicSettingsDataOverride()
	{
	}
}
