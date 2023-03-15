using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C2B")]
	public static class CameraExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000C2C")]
		private class CameraState : ICameraState, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40043DD")]
			private Vector3 _position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40043DE")]
			private Quaternion _rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40043DF")]
			private Transform _cameraTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40043E0")]
			private bool _restored;

			[Cpp2IlInjected.Token(Token = "0x6003763")]
			[Cpp2IlInjected.Address(RVA = "0x13E4630", Offset = "0x13E3030", VA = "0x1813E4630")]
			public unsafe CameraState(Camera camera)
			{
				//Discarded unreachable code: IL_0037
				//IL_0029: Expected native int or pointer, but got O
				Transform transform = (_cameraTransform = camera.transform);
				Transform transform2 = camera.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				((Vector3*)(IntPtr)_position)->z = z;
				Transform transform3 = camera.transform;
			}

			[Cpp2IlInjected.Token(Token = "0x6003764")]
			[Cpp2IlInjected.Address(RVA = "0x13E4510", Offset = "0x13E2F10", VA = "0x1813E4510", Slot = "4")]
			[AsyncStateMachine(typeof(_003CRestoreAsync_003Ed__5))]
			public Task RestoreAsync(CancellationToken ct)
			{
				int num = 0;
				Task result = default(Task);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6003765")]
			[Cpp2IlInjected.Address(RVA = "0x13E44A0", Offset = "0x13E2EA0", VA = "0x1813E44A0", Slot = "5")]
			public void Dispose()
			{
				if (!_restored)
				{
					Debug.LogWarning("Camera position wasn't restored");
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003762")]
		[Cpp2IlInjected.Address(RVA = "0x164BE20", Offset = "0x164A820", VA = "0x18164BE20")]
		public static ICameraState Save(this Camera camera)
		{
			CameraState cameraState = new CameraState(camera);
			/*Error: Unexpected end of block*/;
		}
	}
}
