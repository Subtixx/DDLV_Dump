using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class GameObjectField : ExpandableInspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private string currentTag;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private StringField nameField;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private StringField tagField;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private Getter isActiveGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private Getter nameGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private Getter tagGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private Setter isActiveSetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private Setter nameSetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private Setter tagSetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private PropertyInfo layerProp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private readonly List<Component> components = (List<Component>)(object)new List<T>(8);

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private readonly List<bool> componentsExpandedStates;

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		protected override int Length
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xE46AE0", Offset = "0xE454E0", VA = "0x180E46AE0", Slot = "15")]
			get
			{
				//Discarded unreachable code: IL_0012
				int size = ((List<>)(object)components)._size;
				return size + 4;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xE45F80", Offset = "0xE44980", VA = "0x180E45F80", Slot = "6")]
		public override void Initialize()
		{
			base.Initialize();
			Getter getter = (isActiveGetter = delegate
			{
				if (((InspectorField)this).m_value != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			});
			Setter setter = (isActiveSetter = delegate
			{
				//Discarded unreachable code: IL_0010
				object value5 = ((InspectorField)this).m_value;
				if (value5 != null && value5 != null)
				{
					return;
				}
				throw new InvalidCastException();
			});
			Getter getter2 = (nameGetter = delegate
			{
				if (((InspectorField)this).m_value != null)
				{
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			});
			Setter setter2 = (nameSetter = delegate(object value)
			{
				//Discarded unreachable code: IL_0059
				//IL_0025: Expected O, but got I4
				object value3 = ((InspectorField)this).m_value;
				int num2 = 0;
				if (value3 != null && (value == null || value != null))
				{
					object value4 = ((InspectorField)this).m_value;
					int num3 = 0;
					string text4 = (base.NameRaw = value4.GetNameWithType((Type)num3));
					RuntimeHierarchy connectedHierarchy = ((InspectorField)this).m_inspector.m_connectedHierarchy;
					if (!connectedHierarchy)
					{
						return;
					}
					if (((InspectorField)this).m_value != null)
					{
						Transform target = default(Transform);
						connectedHierarchy.RefreshNameOf(target);
						return;
					}
				}
				throw new InvalidCastException();
			});
			Getter getter3 = (tagGetter = delegate
			{
				if (((InspectorField)this).m_value != null)
				{
					string text = currentTag;
					bool flag = default(bool);
					if (!flag)
					{
						string text2 = default(string);
						currentTag = text2;
					}
					string text3 = currentTag;
					throw new NullReferenceException();
				}
				throw new InvalidCastException();
			});
			Setter setter3 = (tagSetter = delegate(object value)
			{
				//Discarded unreachable code: IL_0016
				object value2 = ((InspectorField)this).m_value;
				int num = 0;
				if (value2 != null && (value == null || value != null))
				{
					return;
				}
				throw new InvalidCastException();
			});
			PropertyInfo propertyInfo = (layerProp = typeof(GameObject).GetProperty("layer"));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xE464F0", Offset = "0xE44EF0", VA = "0x180E464F0", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(GameObject);
			return ((object)type).Equals((object)typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xE461E0", Offset = "0xE44BE0", VA = "0x180E461E0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			base.OnBound(variable);
			if (((InspectorField)this).m_value != null)
			{
				string text = default(string);
				currentTag = text;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xE46270", Offset = "0xE44C70", VA = "0x180E46270", Slot = "10")]
		protected override void OnUnbound()
		{
			//Discarded unreachable code: IL_001d
			base.OnUnbound();
			((List<T>)(object)components).Clear();
			((List<T>)(object)componentsExpandedStates).Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xE45720", Offset = "0xE44120", VA = "0x180E45720", Slot = "17")]
		protected override void ClearElements()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xE45A30", Offset = "0xE44430", VA = "0x180E45A30", Slot = "16")]
		protected override void GenerateElements()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xE462F0", Offset = "0xE44CF0", VA = "0x180E462F0", Slot = "14")]
		public override void Refresh()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xE46A10", Offset = "0xE45410", VA = "0x180E46A10")]
		public GameObjectField()
		{
			List<bool> list = default(List<bool>);
			componentsExpandedStates = list;
			base._002Ector();
		}
	}
}
