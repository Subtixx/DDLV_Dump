using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200034D")]
	internal class DeactivatedReason : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000FA4")]
		public TextBase textBase;

		[Cpp2IlInjected.Token(Token = "0x60014DC")]
		[Cpp2IlInjected.Address(RVA = "0x1127D10", Offset = "0x1126710", VA = "0x181127D10")]
		public void UpdateMessage(string reasonStringId)
		{
			//Discarded unreachable code: IL_00b8
			//IL_0010: Expected O, but got I4
			while (true)
			{
				TextBase textBase = this.textBase;
				int num = 0;
				if (textBase != (Object)num)
				{
					break;
				}
				string[] array = new string[5];
				if ("Attempted to set deactivated reason '" != null && "Attempted to set deactivated reason '" == null)
				{
					continue;
				}
				array[0] = "Attempted to set deactivated reason '";
				if (reasonStringId != null && "Attempted to set deactivated reason '" == null)
				{
					continue;
				}
				array[1] = reasonStringId;
				if ("' on " != null && "' on " == null)
				{
					continue;
				}
				array[2] = "' on ";
				string fullPath = this.GetFullPath();
				if (fullPath == null || fullPath != null)
				{
					array[3] = fullPath;
					if (" but textBase wasn't set" == null || " but textBase wasn't set" != null)
					{
						array[4] = " but textBase wasn't set";
						Debug.LogError(string.Concat(array));
						return;
					}
				}
			}
			this.textBase.StringID = reasonStringId;
		}

		[Cpp2IlInjected.Token(Token = "0x60014DD")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DeactivatedReason()
		{
		}
	}
}
