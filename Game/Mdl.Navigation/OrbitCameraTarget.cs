using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C3A")]
	public class OrbitCameraTarget : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000C3B")]
		public struct CameraView
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400444D")]
			public string nameKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400444E")]
			public Transform camera;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004448")]
		public Transform startCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4004449")]
		public OrbitCameraConfig cameraConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400444A")]
		public Transform lookAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400444B")]
		[SerializeField]
		private Transform _anchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400444C")]
		public List<CameraView> cameraViews = (List<CameraView>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x1700077C")]
		public Transform anchor
		{
			[Cpp2IlInjected.Token(Token = "0x6003802")]
			[Cpp2IlInjected.Address(RVA = "0xF076C0", Offset = "0xF060C0", VA = "0x180F076C0")]
			get
			{
				//IL_0010: Expected O, but got I4
				Transform transform = _anchor;
				int num = 0;
				if (transform != (UnityEngine.Object)num)
				{
					return _anchor;
				}
				return startCamera;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003803")]
		[Cpp2IlInjected.Address(RVA = "0xF07640", Offset = "0xF06040", VA = "0x180F07640")]
		public OrbitCameraTarget()
		{
		}
	}
}
