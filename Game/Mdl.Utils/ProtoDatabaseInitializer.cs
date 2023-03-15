using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Gameloft.FileSystem.Abstraction;
using Meta;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200079A")]
	public static class ProtoDatabaseInitializer
	{
		[Cpp2IlInjected.Token(Token = "0x1400004C")]
		public static event Action<bool> PreInitProtoDatabaseEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60021CA")]
			[Cpp2IlInjected.Address(RVA = "0xCB9B60", Offset = "0xCB8560", VA = "0x180CB9B60")]
			[CompilerGenerated]
			add
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60021CB")]
			[Cpp2IlInjected.Address(RVA = "0xCB9C20", Offset = "0xCB8620", VA = "0x180CB9C20")]
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = default(Delegate);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60021C9")]
		[Cpp2IlInjected.Address(RVA = "0xCB9770", Offset = "0xCB8170", VA = "0x180CB9770")]
		[RuntimeInitializeOnLoadMethod]
		public static void InitializeProtoDatabase()
		{
			InitializeProtoDatabase(force: false);
		}

		[Cpp2IlInjected.Token(Token = "0x60021CC")]
		[Cpp2IlInjected.Address(RVA = "0xCB9780", Offset = "0xCB8180", VA = "0x180CB9780")]
		public static void InitializeProtoDatabase(bool force)
		{
			//Discarded unreachable code: IL_006c, IL_0072, IL_0078
			if (force)
			{
				int num = 0;
				UnityFileSystem.InitFileSystem();
				IFileSystem _003CData_003Ek__BackingField = FileSystem.Data;
				Assembly[] array = new Assembly[2];
				Assembly assembly = typeof(ItemDatabase).Assembly;
				if ((object)assembly != null && (object)assembly == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[0] = assembly;
				Assembly assembly2 = typeof(Profile).Assembly;
				if ((object)assembly2 != null && (object)assembly2 == null)
				{
					throw new IndexOutOfRangeException();
				}
				array[1] = assembly2;
				int num2 = 0;
			}
		}
	}
}
