using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Mdl.Activities;
using Mdl.Avatar;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007C7")]
	public class LootOfflineMarker : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002DAE")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002DAF")]
		[SerializeField]
		[Header("Settings")]
		private float _maxDistance = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4002DB0")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _minOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002DB1")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _maxOpacity = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4002DB2")]
		[SerializeField]
		private float _minOpacityDistance = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002DB3")]
		[SerializeField]
		private float _maxOpacityDistance = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4002DB4")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _minScale = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002DB5")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _maxScale = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4002DB6")]
		[SerializeField]
		private float _minScaleDistance = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002DB7")]
		[SerializeField]
		private float _maxScaleDistance = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4002DB8")]
		[SerializeField]
		private bool _hideWhenTargetNotVisible = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002DB9")]
		private LootBoxObject _lootBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002DBA")]
		private Collider _lootBoxCollider;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002DBB")]
		private bool _isHidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4002DBC")]
		public bool ForceHide;

		[Cpp2IlInjected.Token(Token = "0x170006FE")]
		public GameObject Target
		{
			[Cpp2IlInjected.Token(Token = "0x60031AC")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _targetObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006FF")]
		private GameObject _playerAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x60031AD")]
			[Cpp2IlInjected.Address(RVA = "0xF9C1F0", Offset = "0xF9ABF0", VA = "0x180F9C1F0")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					PlayerAvatar avatar = _003CInstance_003Ek__BackingField._avatar;
					if ((object)avatar != null)
					{
						return avatar.gameObject;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000700")]
		private Camera _camera
		{
			[Cpp2IlInjected.Token(Token = "0x60031AE")]
			[Cpp2IlInjected.Address(RVA = "0xF9C140", Offset = "0xF9AB40", VA = "0x180F9C140")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField;
				do
				{
					_003CInstance_003Ek__BackingField = SystemRoot.Instance;
				}
				while ((object)_003CInstance_003Ek__BackingField == null);
				return _003CInstance_003Ek__BackingField._playerCamera;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031AF")]
		[Cpp2IlInjected.Address(RVA = "0xF9B6A0", Offset = "0xF9A0A0", VA = "0x180F9B6A0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0013
			Transform transform = base.transform;
			float z = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60031B0")]
		[Cpp2IlInjected.Address(RVA = "0xF9BC40", Offset = "0xF9A640", VA = "0x180F9BC40", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_0025
			//IL_000b: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			_lootBox = (LootBoxObject)0;
			LootBoxObject lootBox = _lootBox;
			if ((object)lootBox != null)
			{
				Collider component = lootBox.GetComponent<Collider>();
			}
			_lootBoxCollider = (Collider)num;
		}

		[Cpp2IlInjected.Token(Token = "0x60031B1")]
		[Cpp2IlInjected.Address(RVA = "0xF9BDB0", Offset = "0xF9A7B0", VA = "0x180F9BDB0")]
		private void UpdateScaleAndAlpha()
		{
			//IL_0024: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_0109: Expected F4, but got I4
			Transform transform = base.transform;
			int num = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			GameObject targetObject = _targetObject;
			int num2 = 0;
			if (!(targetObject == (UnityEngine.Object)num2) && _targetObject.activeInHierarchy)
			{
				GameObject playerAvatar = _playerAvatar;
				int num3 = 0;
				if (!(playerAvatar != (UnityEngine.Object)num3))
				{
					return;
				}
				Transform transform2 = _playerAvatar.transform;
				GameObject targetObject2 = _targetObject;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				Transform transform3 = targetObject2.transform;
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				float num4 = default(float);
				if (!(num4 > _maxDistance) && !_isHidden && !ForceHide)
				{
					float maxOpacity = _maxOpacity;
					CanvasGroup canvasGroup = _canvasGroup;
					float minOpacity = _minOpacity;
					minOpacity = (canvasGroup.alpha = Mathf.Lerp(maxOpacity, minOpacity, num4));
					float maxScale = _maxScale;
					float minScale = _minScale;
					num4 = Mathf.Lerp(maxScale, minScale, num4);
					Transform transform4 = base.transform;
					return;
				}
				CanvasGroup canvasGroup2 = _canvasGroup;
				int num6 = 0;
				canvasGroup2.alpha = num6;
			}
			Transform transform5 = base.transform;
			float z4 = Vector3.zero.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031B2")]
		[Cpp2IlInjected.Address(RVA = "0xF9B6F0", Offset = "0xF9A0F0", VA = "0x180F9B6F0")]
		public void CheckVisibleOnInterval()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60031B3")]
		[Cpp2IlInjected.Address(RVA = "0xF9C0C0", Offset = "0xF9AAC0", VA = "0x180F9C0C0", Slot = "13")]
		protected override void Update()
		{
			base.Update();
			UpdateScaleAndAlpha();
		}

		[Cpp2IlInjected.Token(Token = "0x60031B4")]
		[Cpp2IlInjected.Address(RVA = "0xF9C0E0", Offset = "0xF9AAE0", VA = "0x180F9C0E0")]
		public LootOfflineMarker()
		{
		}
	}
}
