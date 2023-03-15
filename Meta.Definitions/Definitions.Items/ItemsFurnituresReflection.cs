using System;
using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200061C")]
	public static class ItemsFurnituresReflection
	{
		[Cpp2IlInjected.Token(Token = "0x40021AE")]
		private static FileDescriptor descriptor;

		[Cpp2IlInjected.Token(Token = "0x170012D9")]
		public static FileDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004932")]
			[Cpp2IlInjected.Address(RVA = "0x654D90", Offset = "0x653790", VA = "0x180654D90")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004933")]
		[Cpp2IlInjected.Address(RVA = "0x654850", Offset = "0x653250", VA = "0x180654850")]
		static ItemsFurnituresReflection()
		{
			byte[] descriptorData;
			FileDescriptor[] dependencies;
			Type[] array2;
			Type typeFromHandle;
			while (true)
			{
				string[] array = new string[7];
				if ("ChtJdGVtcy9JdGVtc0Z1cm5pdHVyZXMucHJvdG8SEURlZmluaXRpb25zLkl0" != null && "ChtJdGVtcy9JdGVtc0Z1cm5pdHVyZXMucHJvdG8SEURlZmluaXRpb25zLkl0" == null)
				{
					continue;
				}
				array[0] = "ChtJdGVtcy9JdGVtc0Z1cm5pdHVyZXMucHJvdG8SEURlZmluaXRpb25zLkl0";
				if ("ZW1zKvQBChFGdXJuaXR1cmVJdGVtVHlwZRIdChlGdXJuaXR1cmVJdGVtVHlw" != null && "ZW1zKvQBChFGdXJuaXR1cmVJdGVtVHlwZRIdChlGdXJuaXR1cmVJdGVtVHlw" == null)
				{
					continue;
				}
				array[1] = "ZW1zKvQBChFGdXJuaXR1cmVJdGVtVHlwZRIdChlGdXJuaXR1cmVJdGVtVHlw";
				if ("ZV9EZWZhdWx0EAASJgoiRnVybml0dXJlSXRlbVR5cGVfR3JvdW5kQWx0ZXJh" != null && "ZV9EZWZhdWx0EAASJgoiRnVybml0dXJlSXRlbVR5cGVfR3JvdW5kQWx0ZXJh" == null)
				{
					continue;
				}
				array[2] = "ZV9EZWZhdWx0EAASJgoiRnVybml0dXJlSXRlbVR5cGVfR3JvdW5kQWx0ZXJh";
				if ("dGlvbhABEiEKHUZ1cm5pdHVyZUl0ZW1UeXBlX0xhbmRzY2FwaW5nEAISGgoW" != null && "dGlvbhABEiEKHUZ1cm5pdHVyZUl0ZW1UeXBlX0xhbmRzY2FwaW5nEAISGgoW" == null)
				{
					continue;
				}
				array[3] = "dGlvbhABEiEKHUZ1cm5pdHVyZUl0ZW1UeXBlX0xhbmRzY2FwaW5nEAISGgoW";
				if ("RnVybml0dXJlSXRlbVR5cGVfRG9vchADEh0KGUZ1cm5pdHVyZUl0ZW1UeXBl" != null && "RnVybml0dXJlSXRlbVR5cGVfRG9vchADEh0KGUZ1cm5pdHVyZUl0ZW1UeXBl" == null)
				{
					continue;
				}
				array[4] = "RnVybml0dXJlSXRlbVR5cGVfRG9vchADEh0KGUZ1cm5pdHVyZUl0ZW1UeXBl";
				if ("X1JlcXVlc3QQBRIdChlGdXJuaXR1cmVJdGVtVHlwZV9CbG9ja2VyEAYSGwoX" != null && "X1JlcXVlc3QQBRIdChlGdXJuaXR1cmVJdGVtVHlwZV9CbG9ja2VyEAYSGwoX" == null)
				{
					continue;
				}
				array[5] = "X1JlcXVlc3QQBRIdChlGdXJuaXR1cmVJdGVtVHlwZV9CbG9ja2VyEAYSGwoX";
				if ("RnVybml0dXJlSXRlbVR5cGVfRmVuY2UQB2IGcHJvdG8z" == null || "RnVybml0dXJlSXRlbVR5cGVfRmVuY2UQB2IGcHJvdG8z" != null)
				{
					array[6] = "RnVybml0dXJlSXRlbVR5cGVfRmVuY2UQB2IGcHJvdG8z";
					descriptorData = Convert.FromBase64String(string.Concat(array));
					dependencies = new FileDescriptor[0];
					array2 = new Type[1];
					typeFromHandle = typeof(FurnitureItemType);
					if ((object)typeFromHandle == null || (object)typeFromHandle != null)
					{
						break;
					}
				}
			}
			array2[0] = typeFromHandle;
			GeneratedClrTypeInfo generatedCodeInfo = default(GeneratedClrTypeInfo);
			FileDescriptor fileDescriptor = FileDescriptor.FromGeneratedCode(descriptorData, dependencies, generatedCodeInfo);
			throw new NullReferenceException();
		}
	}
}
