using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Definitions.Missions;
using Mdl.Characters;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200079F")]
	public class CharacterQuestMarker : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002CA5")]
		[SerializeField]
		private SpriteAtlasImage _questAvailableBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002CA6")]
		[SerializeField]
		private SpriteAtlasImage _questOnGoingBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002CA7")]
		[SerializeField]
		private SpriteAtlasImage _questCompletedBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002CA8")]
		[SerializeField]
		private SpriteAtlasImage _questAvailableIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002CA9")]
		[SerializeField]
		private SpriteAtlasImage _questOnGoingIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4002CAA")]
		[SerializeField]
		private SpriteAtlasImage _questCompletedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4002CAB")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4002CAC")]
		[SerializeField]
		[Header("Settings")]
		private float _maxDistance = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4002CAD")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _minOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4002CAE")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _maxOpacity = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4002CAF")]
		[SerializeField]
		private float _minOpacityDistance = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4002CB0")]
		[SerializeField]
		private float _maxOpacityDistance = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4002CB1")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _minScale = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4002CB2")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _maxScale = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4002CB3")]
		[SerializeField]
		private float _minScaleDistance = 15f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4002CB4")]
		[SerializeField]
		private float _maxScaleDistance = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4002CB5")]
		[SerializeField]
		private bool _hideWhenCharacterNotVisible = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
		[Cpp2IlInjected.Token(Token = "0x4002CB6")]
		[SerializeField]
		public bool IsMailbox;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4002CB8")]
		private Character _character;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4002CB9")]
		private Collider _characterCollider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4002CBA")]
		private bool _isHidden;

		[Cpp2IlInjected.FieldOffset(Offset = "0x101")]
		[Cpp2IlInjected.Token(Token = "0x4002CBB")]
		public bool ForceHide;

		[Cpp2IlInjected.Token(Token = "0x170006D6")]
		public GameObject Target
		{
			[Cpp2IlInjected.Token(Token = "0x60030C0")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			get
			{
				return _targetObject;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D7")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0xE8"), Cpp2IlInjected.Token(Token = "0x4002CB7")]
		public MissionSlotState State
		{
			[Cpp2IlInjected.Token(Token = "0x60030C1")]
			[Cpp2IlInjected.Address(RVA = "0xFF9FC0", Offset = "0xFF89C0", VA = "0x180FF9FC0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60030C2")]
			[Cpp2IlInjected.Address(RVA = "0xFFA200", Offset = "0xFF8C00", VA = "0x180FFA200")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170006D8")]
		private GameObject _playerAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x60030C3")]
			[Cpp2IlInjected.Address(RVA = "0xFFA080", Offset = "0xFF8A80", VA = "0x180FFA080")]
			get
			{
				//IL_0013: Expected O, but got I4
				//IL_0013: Expected O, but got I4
				if ((object)SystemRoot.Instance != null)
				{
				}
				int num = 0;
				int num2 = 0;
				if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
				{
					SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
					if ((object)_003CInstance_003Ek__BackingField != null)
					{
						return _003CInstance_003Ek__BackingField._avatar.gameObject;
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D9")]
		private Camera _camera
		{
			[Cpp2IlInjected.Token(Token = "0x60030C4")]
			[Cpp2IlInjected.Address(RVA = "0xFF9FD0", Offset = "0xFF89D0", VA = "0x180FF9FD0")]
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

		[Cpp2IlInjected.Token(Token = "0x60030C5")]
		[Cpp2IlInjected.Address(RVA = "0xF9B6A0", Offset = "0xF9A0A0", VA = "0x180F9B6A0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0013
			Transform transform = base.transform;
			float z = Vector3.zero.z;
		}

		[Cpp2IlInjected.Token(Token = "0x60030C6")]
		[Cpp2IlInjected.Address(RVA = "0xFF97C0", Offset = "0xFF81C0", VA = "0x180FF97C0", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_0140
			//IL_00ac: Expected I4, but got O
			//IL_0113: Expected O, but got I4
			//IL_0127: Expected O, but got I4
			int num = 0;
			if ((object)this == null || (object)this == null)
			{
				return;
			}
			GameObject gameObject = _questAvailableBackground.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _questCompletedBackground.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _questOnGoingBackground.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
			GameObject gameObject4 = _questAvailableIcon.gameObject;
			int active4 = 0;
			gameObject4.SetActive((byte)active4 != 0);
			GameObject gameObject5 = _questCompletedIcon.gameObject;
			int active5 = 0;
			gameObject5.SetActive((byte)active5 != 0);
			GameObject gameObject6 = _questOnGoingIcon.gameObject;
			int num2 = 0;
			int active6 = 0;
			gameObject6.SetActive((byte)active6 != 0);
			CharacterQuestMarker characterQuestMarker = default(CharacterQuestMarker);
			State = (MissionSlotState)characterQuestMarker;
			if ((long)characterQuestMarker != 3)
			{
				if ((long)characterQuestMarker != 2)
				{
					if ((long)characterQuestMarker != 1)
					{
						goto IL_00fe;
					}
					GameObject gameObject7 = _questAvailableBackground.gameObject;
				}
				_questOnGoingBackground.gameObject.SetActive(value: true);
			}
			_questCompletedBackground.gameObject.SetActive(value: true);
			_questCompletedIcon.gameObject.SetActive(value: true);
			goto IL_00fe;
			IL_00fe:
			if (num2 == 0)
			{
			}
			int num3 = 0;
			if (num2 != 0)
			{
				_character = (Character)num2;
				Character character = _character;
				int num4 = 0;
				Collider component = default(Collider);
				if (character != (UnityEngine.Object)num4)
				{
					component = _character.GetComponent<Collider>();
				}
				_characterCollider = component;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030C7")]
		[Cpp2IlInjected.Address(RVA = "0xFF9BE0", Offset = "0xFF85E0", VA = "0x180FF9BE0")]
		private void UpdateScaleAndAlpha()
		{
			//IL_0024: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_0077: Expected O, but got I4
			//IL_0131: Expected F4, but got I4
			Transform transform = base.transform;
			int num = 0;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			GameObject targetObject = _targetObject;
			int num2 = 0;
			if (!(targetObject == (UnityEngine.Object)num2) && _targetObject.activeInHierarchy)
			{
				Character character = _character;
				int num3 = 0;
				if (!(character != (UnityEngine.Object)num3) || !_character.TraversingLink)
				{
					GameObject playerAvatar = _playerAvatar;
					int num4 = 0;
					if (!(playerAvatar != (UnityEngine.Object)num4))
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
					float num5 = default(float);
					if (!(num5 > _maxDistance) && !_isHidden && !ForceHide)
					{
						float maxOpacity = _maxOpacity;
						CanvasGroup canvasGroup = _canvasGroup;
						float minOpacity = _minOpacity;
						minOpacity = (canvasGroup.alpha = Mathf.Lerp(maxOpacity, minOpacity, num5));
						float maxScale = _maxScale;
						float minScale = _minScale;
						num5 = Mathf.Lerp(maxScale, minScale, num5);
						Transform transform4 = base.transform;
						return;
					}
					CanvasGroup canvasGroup2 = _canvasGroup;
					int num7 = 0;
					canvasGroup2.alpha = num7;
				}
			}
			Transform transform5 = base.transform;
			float z4 = Vector3.zero.z;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030C8")]
		[Cpp2IlInjected.Address(RVA = "0xFF9270", Offset = "0xFF7C70", VA = "0x180FF9270")]
		public void CheckVisibleOnInterval()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60030C9")]
		[Cpp2IlInjected.Address(RVA = "0xFF9F40", Offset = "0xFF8940", VA = "0x180FF9F40", Slot = "13")]
		protected override void Update()
		{
			base.Update();
			UpdateScaleAndAlpha();
		}

		[Cpp2IlInjected.Token(Token = "0x60030CA")]
		[Cpp2IlInjected.Address(RVA = "0xFF9F60", Offset = "0xFF8960", VA = "0x180FF9F60")]
		public CharacterQuestMarker()
		{
		}
	}
}
