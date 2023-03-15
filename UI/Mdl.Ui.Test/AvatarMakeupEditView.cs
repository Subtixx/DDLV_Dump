using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Decals;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Customization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Test
{
	[Cpp2IlInjected.Token(Token = "0x20008E1")]
	public class AvatarMakeupEditView : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20008E2")]
		public delegate void Exit();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40034FE")]
		[SerializeField]
		private DecalEditView _decalView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40034FF")]
		[SerializeField]
		private Button _backButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003502")]
		private AvatarAppearance _avatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003503")]
		private Camera _camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003504")]
		private HistoryStack<DesignWorkingCopy> _designHistory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003505")]
		private bool _constructed;

		[Cpp2IlInjected.Token(Token = "0x170007D7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x4003500")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x60037D5")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60037D6")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000056")]
		public event Exit OnExit
		{
			[Cpp2IlInjected.Token(Token = "0x60037D7")]
			[Cpp2IlInjected.Address(RVA = "0x88C330", Offset = "0x88AD30", VA = "0x18088C330")]
			[CompilerGenerated]
			add
			{
				Exit onExit = this.OnExit;
				Delegate @delegate = Delegate.Combine(onExit, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onExit)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60037D8")]
			[Cpp2IlInjected.Address(RVA = "0x88C3D0", Offset = "0x88ADD0", VA = "0x18088C3D0")]
			[CompilerGenerated]
			remove
			{
				Exit onExit = this.OnExit;
				Delegate @delegate = Delegate.Remove(onExit, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onExit)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60037D9")]
		[Cpp2IlInjected.Address(RVA = "0x88BAD0", Offset = "0x88A4D0", VA = "0x18088BAD0")]
		private void Construct()
		{
			//Discarded unreachable code: IL_0051
			GameObject gameObject = _decalView.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			Button.ButtonClickedEvent onClick = _backButton.m_OnClick;
			UnityAction call = Back;
			onClick.AddListener(call);
			Camera camera = (_camera = SystemRoot.Instance._playerCamera);
			_constructed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60037DA")]
		[Cpp2IlInjected.Address(RVA = "0x88BC80", Offset = "0x88A680", VA = "0x18088BC80")]
		public void Init(AvatarAppearance avatar)
		{
			if (!_constructed)
			{
				GameObject gameObject = _decalView.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				Button.ButtonClickedEvent onClick = _backButton.m_OnClick;
				UnityAction call = Back;
				onClick.AddListener(call);
				Camera camera = (_camera = SystemRoot.Instance._playerCamera);
				_constructed = true;
			}
			_avatar = avatar;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60037DB")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88A810", VA = "0x18088BE10")]
		public void Show()
		{
			//Discarded unreachable code: IL_002c
			HistoryStack<DesignWorkingCopy> historyStack = (_designHistory = (HistoryStack<DesignWorkingCopy>)(object)new HistoryStack<T>((T)new DesignWorkingCopy()));
			base.gameObject.SetActive(value: true);
			IsShown = true;
			StartEditingDecals();
		}

		[Cpp2IlInjected.Token(Token = "0x60037DC")]
		[Cpp2IlInjected.Address(RVA = "0x88BC40", Offset = "0x88A640", VA = "0x18088BC40")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0018
			GameObject gameObject = base.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			IsShown = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60037DD")]
		[Cpp2IlInjected.Address(RVA = "0x88C310", Offset = "0x88AD10", VA = "0x18088C310")]
		public void UpdateState(float deltaTime)
		{
			//Discarded unreachable code: IL_000d
			_decalView.UpdateState(deltaTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60037DE")]
		[Cpp2IlInjected.Address(RVA = "0x88BEE0", Offset = "0x88A8E0", VA = "0x18088BEE0")]
		private void StartEditingDecals()
		{
			//Discarded unreachable code: IL_0167
			//IL_00ae: Expected O, but got I4
			DecalRenderingTool decalRenderingTool = _avatar.decalRenderingTool;
			int mode = 0;
			decalRenderingTool.StartProjector((ProjectorMode)mode, ProjectorResolution.R1024);
			_avatar.Animator.SetTrigger("BindPose");
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			((Renderer)_avatar.combinedHead).Internal_GetPropertyBlock(materialPropertyBlock);
			Texture texture = materialPropertyBlock.GetTexture("_AvatarNormalTex");
			materialPropertyBlock.Clear();
			materialPropertyBlock.SetTexture("_AvatarNormalTex", texture);
			((Renderer)_avatar.combinedHead).Internal_SetPropertyBlock(materialPropertyBlock);
			AvatarAppearance avatar = _avatar;
			AvatarHeadSkinnedMesh head = avatar.head;
			DecalRenderingTool decalRenderingTool2 = avatar.decalRenderingTool;
			SkinnedMeshRenderer smr = head.Smr;
			int worldSpace = 0;
			int num = 0;
			decalRenderingTool2.SetRenderer(smr, (Material)num, (byte)worldSpace != 0);
			Collider component = _avatar.GetComponent<Collider>();
			int num2 = ((component.enabled = false) ? 1 : 0);
			MeshCollider orAddComponent = _avatar.combinedHead.GetOrAddComponent<MeshCollider>();
			orAddComponent.enabled = true;
			Mesh mesh = new Mesh();
			_avatar.combinedHead.BakeMesh(mesh);
			orAddComponent.sharedMesh = mesh;
			Camera camera = _camera;
			DecalEditView decalView = _decalView;
			Transform transform = camera.transform;
			AvatarAppearance avatar2 = _avatar;
			AvatarHeadSkinnedMesh head2 = avatar2.head;
			if (avatar2.IsMale)
			{
			}
			UnityEngine.Vector3 vector = default(UnityEngine.Vector3);
			float z = vector.z;
			List<IDecal> list = (List<IDecal>)(object)new List<T>();
			float transitionDuration = _avatar.orbitCameraTarget.cameraConfig.transitionDuration;
			HistoryStack<DesignWorkingCopy> designHistory = _designHistory;
		}

		[Cpp2IlInjected.Token(Token = "0x60037DF")]
		[Cpp2IlInjected.Address(RVA = "0x88B9A0", Offset = "0x88A3A0", VA = "0x18088B9A0")]
		private void Back()
		{
			//Discarded unreachable code: IL_0050
			Collider component = _avatar.GetComponent<Collider>();
			int num = ((component.enabled = false) ? 1 : 0);
			SkinnedMeshRenderer combinedHead = _avatar.combinedHead;
			bool flag2 = default(bool);
			if (flag2)
			{
			}
			_avatar.Animator.SetTrigger("Exit");
			this.OnExit?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x60037E0")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public AvatarMakeupEditView()
		{
		}
	}
}
