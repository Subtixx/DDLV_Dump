using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Meta.Util;
using UnityEngine;

namespace Mdl.Ui
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20001E6")]
	public class ShortcutIndicatorSetTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000862")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000863")]
		public ControlType GamepadType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000864")]
		public RuntimePlatform Platform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000865")]
		[NonReorderable]
		public List<ShortcutIndicatorTemplate> GamepadKeyIndicators = (List<ShortcutIndicatorTemplate>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000866")]
		[NonReorderable]
		public List<GameObjectTemplate> GameObjectTemplates = (List<GameObjectTemplate>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000867")]
		public ShortcutSetDefinition ShortcutSet;

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x15EB4A0", Offset = "0x15E9EA0", VA = "0x1815EB4A0")]
		public List<ShortcutIndicatorTemplate> GetIndicatorTemplates()
		{
			//Discarded unreachable code: IL_0016
			List<ShortcutIndicatorTemplate> list = (List<ShortcutIndicatorTemplate>)(object)new List<T>();
			List<ShortcutIndicatorTemplate> gamepadKeyIndicators = GamepadKeyIndicators;
			((List<T>)(object)list).AddRange((IEnumerable<>)gamepadKeyIndicators);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x15EB410", Offset = "0x15E9E10", VA = "0x1815EB410")]
		public List<GameObjectTemplate> GetGameObjectTemplates()
		{
			//Discarded unreachable code: IL_0016
			List<GameObjectTemplate> list = (List<GameObjectTemplate>)(object)new List<T>();
			List<GameObjectTemplate> gameObjectTemplates = GameObjectTemplates;
			((List<T>)(object)list).AddRange((IEnumerable<>)gameObjectTemplates);
			return list;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x15EB530", Offset = "0x15E9F30", VA = "0x1815EB530")]
		public void SetTemplates(List<ShortcutIndicatorTemplate> indicatorTemplates, List<GameObjectTemplate> gameObjectTemplates)
		{
			//Discarded unreachable code: IL_0049
			//IL_000d: Expected O, but got I4
			ControlType gamepadType = GamepadType;
			string name = ((Enum)gamepadType).ToString();
			ControlType controlType = (GamepadType = gamepadType);
			Name = name;
			Action<ShortcutIndicatorTemplate> action = (Action<ShortcutIndicatorTemplate>)(object)(Action<T>)delegate(ShortcutIndicatorTemplate x)
			{
				//Discarded unreachable code: IL_003f
				List<ShortcutIndicatorTemplate> gamepadKeyIndicators = GamepadKeyIndicators;
				Predicate<ShortcutIndicatorTemplate> predicate2 = (Predicate<ShortcutIndicatorTemplate>)(object)(Predicate<T>)delegate(ShortcutIndicatorTemplate y)
				{
					//Discarded unreachable code: IL_0034
					//IL_0033: Expected O, but got I4
					ShortcutIndicatorTemplate shortcutIndicatorTemplate = x;
					ShortcutIndicator target4 = y.Target;
					ShortcutIndicator target5 = shortcutIndicatorTemplate.Target;
					if (target4 == target5)
					{
						return true;
					}
					ShortcutIndicator target6 = y.Target;
					int num6 = 0;
					return target6 == (UnityEngine.Object)num6;
				};
				int num4 = ((List<T>)(object)gamepadKeyIndicators).RemoveAll((Predicate<>)(object)predicate2);
				int num5 = 0;
				bool flag2 = default(bool);
				if (flag2)
				{
					ShortcutIndicatorTemplate item2 = default(ShortcutIndicatorTemplate);
					((List<T>)(object)GamepadKeyIndicators).Add((T)item2);
				}
			};
			((List<T>)(object)indicatorTemplates).ForEach((Action<>)(object)action);
			Action<GameObjectTemplate> action2 = (Action<GameObjectTemplate>)(object)(Action<T>)delegate(GameObjectTemplate x)
			{
				//Discarded unreachable code: IL_003f
				List<GameObjectTemplate> gameObjectTemplates2 = GameObjectTemplates;
				Predicate<GameObjectTemplate> predicate = (Predicate<GameObjectTemplate>)(object)(Predicate<T>)delegate(GameObjectTemplate y)
				{
					//Discarded unreachable code: IL_0034
					//IL_0033: Expected O, but got I4
					GameObjectTemplate gameObjectTemplate = x;
					GameObject target = y.Target;
					GameObject target2 = gameObjectTemplate.Target;
					if (target == target2)
					{
						return true;
					}
					GameObject target3 = y.Target;
					int num3 = 0;
					return target3 == (UnityEngine.Object)num3;
				};
				int num = ((List<T>)(object)gameObjectTemplates2).RemoveAll((Predicate<>)(object)predicate);
				int num2 = 0;
				bool flag = default(bool);
				if (flag)
				{
					GameObjectTemplate item = default(GameObjectTemplate);
					((List<T>)(object)GameObjectTemplates).Add((T)item);
				}
			};
			((List<T>)(object)gameObjectTemplates).ForEach((Action<>)(object)action2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C65")]
		[Cpp2IlInjected.Address(RVA = "0x15EB2D0", Offset = "0x15E9CD0", VA = "0x1815EB2D0")]
		public ShortcutIndicatorSetTemplate Clone()
		{
			ShortcutIndicatorSetTemplate shortcutIndicatorSetTemplate = new ShortcutIndicatorSetTemplate();
			List<ShortcutIndicatorTemplate> list = (shortcutIndicatorSetTemplate.GamepadKeyIndicators = (List<ShortcutIndicatorTemplate>)(object)new List<T>());
			List<GameObjectTemplate> list2 = (shortcutIndicatorSetTemplate.GameObjectTemplates = (List<GameObjectTemplate>)(object)new List<T>());
			string text = (shortcutIndicatorSetTemplate.Name = Name);
			ControlType controlType = (shortcutIndicatorSetTemplate.GamepadType = GamepadType);
			RuntimePlatform runtimePlatform = (shortcutIndicatorSetTemplate.Platform = Platform);
			List<ShortcutIndicatorTemplate> list3 = (shortcutIndicatorSetTemplate.GamepadKeyIndicators = GamepadKeyIndicators);
			ShortcutSetDefinition shortcutSetDefinition = (shortcutIndicatorSetTemplate.ShortcutSet = ShortcutSet);
			return shortcutIndicatorSetTemplate;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x15EBA20", Offset = "0x15EA420", VA = "0x1815EBA20")]
		public ShortcutIndicatorSetTemplate()
		{
		}
	}
}
