using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x20008BA")]
	internal class TheForgottenCharacter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030E7")]
		[SerializeField]
		private AssetReference limboVfxAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40030E8")]
		[SerializeField]
		private AssetReference limboMaterialAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030E9")]
		[SerializeField]
		[Proto("Meta.Customization.Avatar, Meta")]
		private string outfit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40030EA")]
		private AvatarAppearance avatarApperance;

		[Cpp2IlInjected.Token(Token = "0x6002855")]
		[Cpp2IlInjected.Address(RVA = "0x1073A20", Offset = "0x1072420", VA = "0x181073A20")]
		private void Start()
		{
			AvatarAppearance avatarAppearance = (avatarApperance = GetComponentInChildren<AvatarAppearance>());
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6002856")]
		[Cpp2IlInjected.Address(RVA = "0x10735C0", Offset = "0x1071FC0", VA = "0x1810735C0")]
		[AsyncStateMachine(typeof(_003CLoadTheForgotten_003Ed__5))]
		private Task LoadTheForgotten()
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002857")]
		[Cpp2IlInjected.Address(RVA = "0x10736E0", Offset = "0x10720E0", VA = "0x1810736E0")]
		public void SetFloatMaterialsParameter(string parameterName, float newValue)
		{
			//Discarded unreachable code: IL_009d, IL_00a3, IL_00a9, IL_00af, IL_00b5
			int num = 0;
			int vfxLayer = LayerMask.NameToLayer("VFX");
			Renderer[] componentsInChildren = GetComponentsInChildren<Renderer>();
			Func<Renderer, bool> func = default(Func<Renderer, bool>);
			Func<Renderer, bool> func2 = func;
			if (func2 == null)
			{
				func = (Func<Renderer, bool>)(object)(Func<T, TResult>)delegate(Renderer x)
				{
					//Discarded unreachable code: IL_001a
					if (x.gameObject.layer == vfxLayer)
					{
						int num5 = 0;
					}
					return (object)x == null;
				};
			}
			IEnumerable<Renderer> enumerable = (IEnumerable<Renderer>)Enumerable.Where<Renderer>((IEnumerable<>)(object)componentsInChildren, (Func<, >)(object)func2);
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			int num4 = default(int);
			if (enumerable != null)
			{
				uint num3 = default(uint);
				if (num < (int)num3)
				{
					num += num;
					if (num == (int)num3)
					{
						goto IL_0084;
					}
					num++;
				}
				num4 = 0;
				num4 += num4;
				num += 312;
				goto IL_0084;
			}
			goto IL_0097;
			IL_0097:
			if (enumerable == null)
			{
			}
			return;
			IL_0084:
			num4 += num4;
			num += 312;
			num++;
			goto IL_0097;
		}

		[Cpp2IlInjected.Token(Token = "0x6002858")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TheForgottenCharacter()
		{
		}
	}
}
