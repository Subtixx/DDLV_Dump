using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.HideAvatarParts
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class RenderAlphaMask : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		[SerializeField]
		private int _alphaMaskLayer = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		[SerializeField]
		private Camera _alphaMaskCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		[SerializeField]
		private Material _alphaMaskMat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		[SerializeField]
		private CustomRenderTexture _dilatedTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private int _originalLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private Material _originalMat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private SkinnedMeshRenderer _skinnedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x1E97CF0", Offset = "0x1E966F0", VA = "0x181E97CF0")]
		private void Awake()
		{
			int num = (_originalLayer = base.gameObject.layer);
			SkinnedMeshRenderer skinnedMeshRenderer = (_skinnedMesh = GetComponent<SkinnedMeshRenderer>());
			Material material = (_originalMat = ((Renderer)_skinnedMesh).GetMaterial());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x1E97D90", Offset = "0x1E96790", VA = "0x181E97D90")]
		public void DoRender()
		{
			//Discarded unreachable code: IL_0073
			GameObject gameObject = base.gameObject;
			int num = (gameObject.layer = _alphaMaskLayer);
			SkinnedMeshRenderer skinnedMesh = _skinnedMesh;
			Material alphaMaskMat = _alphaMaskMat;
			((Renderer)skinnedMesh).SetMaterial(alphaMaskMat);
			_alphaMaskCamera.Render();
			_dilatedTexture.Update();
			GameObject gameObject2 = base.gameObject;
			int num2 = (gameObject2.layer = _originalLayer);
			SkinnedMeshRenderer skinnedMesh2 = _skinnedMesh;
			Material originalMat = _originalMat;
			((Renderer)skinnedMesh2).SetMaterial(originalMat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1E97E30", Offset = "0x1E96830", VA = "0x181E97E30")]
		public RenderAlphaMask()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
