using System;
using System.Reflection;
using Cpp2IlInjected;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public struct ExposedMethod
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private readonly MethodInfo method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private readonly RuntimeInspectorButtonAttribute properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private readonly bool isExtensionMethod;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public string Label
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x1521090", Offset = "0x151FA90", VA = "0x181521090")]
			get
			{
				//Discarded unreachable code: IL_000c
				return properties.m_label;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public bool IsInitializer
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x1521070", Offset = "0x151FA70", VA = "0x181521070")]
			get
			{
				//Discarded unreachable code: IL_000c
				return properties.m_isInitializer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool VisibleWhenInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x15210B0", Offset = "0x151FAB0", VA = "0x1815210B0")]
			get
			{
				ButtonVisibility visibility = properties.m_visibility;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public bool VisibleWhenUninitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x15210D0", Offset = "0x151FAD0", VA = "0x1815210D0")]
			get
			{
				ButtonVisibility visibility = properties.m_visibility;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1521020", Offset = "0x151FA20", VA = "0x181521020")]
		public ExposedMethod(MethodInfo method, RuntimeInspectorButtonAttribute properties, bool isExtensionMethod)
		{
			this.method = method;
			this.properties = properties;
			this.isExtensionMethod = isExtensionMethod;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1520F00", Offset = "0x151F900", VA = "0x181520F00")]
		public void Call(object source)
		{
			bool flag = default(bool);
			object[] array;
			do
			{
				if (!isExtensionMethod && !flag)
				{
					if (source == null)
					{
					}
					return;
				}
				array = new object[1];
			}
			while (source != null && array == null);
			array[0] = source;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1520DD0", Offset = "0x151F7D0", VA = "0x181520DD0")]
		public object CallAndReturnValue(object source)
		{
			bool flag = default(bool);
			object result = default(object);
			object[] array;
			do
			{
				if (!isExtensionMethod && !flag)
				{
					if (source == null)
					{
						int num = 0;
					}
					return result;
				}
				array = new object[1];
			}
			while (source != null && array == null);
			array[0] = source;
			throw new NullReferenceException();
		}
	}
}
