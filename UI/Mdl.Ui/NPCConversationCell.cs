using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Platform;
using NodeCanvas.DialogueTrees;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007D4")]
	[RequireComponent(typeof(BubbleAnimation))]
	public class NPCConversationCell : MonoBehaviour, IHasLayout
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002DE2")]
		[SerializeField]
		private TextBase _tfText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002DE3")]
		[SerializeField]
		private RectTransform _rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002DE4")]
		[SerializeField]
		private RectTransform _contentRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002DE5")]
		[SerializeField]
		private BubbleAnimation _bubbleAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002DE6")]
		[SerializeField]
		private RectTransform _backgroundHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002DE7")]
		[SerializeField]
		[Header("Settings")]
		private float _maxDistance = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002DE8")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _minScale = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002DE9")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _maxScale = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4002DEA")]
		[SerializeField]
		private float _minScaleDistance = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002DEB")]
		[SerializeField]
		private float _maxScaleDistance = 3f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4002DEC")]
		[SerializeField]
		private float _stayOnScreenDelay = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002DED")]
		[SerializeField]
		[Header("Bubble sizing")]
		private float _lineSizeX = 50f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4002DEE")]
		[SerializeField]
		private float _lineSizeY = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002DEF")]
		[SerializeField]
		private float _minBoundSizeX = 300f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002DF0")]
		public DialogueMenu.SubtitleDelays subtitleDelays = new DialogueMenu.SubtitleDelays();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002DF1")]
		public SubtitlesRequestInfo CurrentSubtitleInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002DF2")]
		public ConversationSide Side;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4002DF3")]
		private bool IsStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002DF4")]
		public int XPositionDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4002DF5")]
		private bool _initiated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002DF6")]
		protected MenuLayoutTemplate _oldLayout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002DF7")]
		[SerializeField]
		private List<MenuLayoutTemplate> LayoutTemplates = (List<MenuLayoutTemplate>)(object)new List<T>
		{
			(T)new MenuLayoutTemplate
			{
				Platform = RuntimePlatform.WindowsPlayer,
				IsLandscape = true,
				CanvasScaleFactor = 0.25f
			},
			(T)new MenuLayoutTemplate
			{
				Platform = RuntimePlatform.WindowsEditor,
				IsLandscape = true,
				CanvasScaleFactor = 0.25f
			}
		};

		[Cpp2IlInjected.Token(Token = "0x17000704")]
		private bool IsPaused
		{
			[Cpp2IlInjected.Token(Token = "0x60031E3")]
			[Cpp2IlInjected.Address(RVA = "0x1297660", Offset = "0x1296060", VA = "0x181297660")]
			get
			{
				//Discarded unreachable code: IL_0015
				int num = 0;
				UiRoot instance = UiRoot.Instance;
				int num2 = 0;
				return !instance.IsOnTop<HudMenu>((byte)num2 != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000705")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60031E4")]
			[Cpp2IlInjected.Address(RVA = "0xD227E0", Offset = "0xD211E0", VA = "0x180D227E0", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_000c
				return base.gameObject.name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000706")]
		public List<MenuLayoutTemplate> Layouts
		{
			[Cpp2IlInjected.Token(Token = "0x60031E5")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0", Slot = "5")]
			get
			{
				return LayoutTemplates;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031E6")]
		[Cpp2IlInjected.Address(RVA = "0x1296B10", Offset = "0x1295510", VA = "0x181296B10")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0036
			//IL_0022: Expected O, but got I4
			RectTransform rectTransform = _rectTransform;
			float z = Vector3.zero.z;
			BubbleAnimation bubbleAnimation = _bubbleAnimation;
			int num = 0;
			if (bubbleAnimation == (UnityEngine.Object)num)
			{
				BubbleAnimation bubbleAnimation2 = (_bubbleAnimation = GetComponent<BubbleAnimation>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031E7")]
		[Cpp2IlInjected.Address(RVA = "0x1297100", Offset = "0x1295B00", VA = "0x181297100")]
		private void Update()
		{
			//IL_002c: Expected O, but got I4
			//IL_0047: Expected O, but got I4
			//IL_00f8: Expected O, but got I4
			SubtitlesRequestInfo currentSubtitleInfo = CurrentSubtitleInfo;
			if (currentSubtitleInfo != null && (long)currentSubtitleInfo.actor != 0)
			{
				Transform transform = base.transform;
				int num = 0;
				if (transform != (UnityEngine.Object)num)
				{
					int num2 = 0;
					Camera main = Camera.main;
					int num3 = 0;
					if (main != (UnityEngine.Object)num3)
					{
						RefreshSide();
						int num4 = 0;
						Camera main2 = Camera.main;
						IDialogueActor actor = CurrentSubtitleInfo.actor;
						RectTransform rectTransform = _rectTransform;
						int num5 = 0;
						BubbleAnimation bubbleAnimation = _bubbleAnimation;
						RectTransform rectTransform2 = _rectTransform;
						float z = bubbleAnimation.CurrentOffset.z;
						int num6 = 0;
						IDialogueActor actor2 = CurrentSubtitleInfo.actor;
						float num7 = default(float);
						if (!(num7 > _maxDistance))
						{
							RectTransform rectTransform3 = _rectTransform;
							int num8 = 0;
							if (rectTransform3.IsPartiallyVisible())
							{
								float maxScaleDistance = _maxScaleDistance;
								float minScale = _minScale;
								float maxScale = _maxScale;
								maxScaleDistance = num7;
								float num9 = Mathf.Lerp(maxScale, minScale, maxScaleDistance);
								_rectTransform.localScale = (Vector3)num8;
								return;
							}
						}
					}
				}
			}
			RectTransform rectTransform4 = _rectTransform;
			Vector3 zero = Vector3.zero;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031E8")]
		[Cpp2IlInjected.Address(RVA = "0x1296D50", Offset = "0x1295750", VA = "0x181296D50")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_003c
			if (_initiated)
			{
				int num = 0;
				if ((IsStarted ? 1 : 0) != num)
				{
					StopAllCoroutines();
					CurrentSubtitleInfo.Continue();
				}
				else
				{
					IEnumerator routine = Internal_OnSubtitlesRequestInfo();
					Coroutine coroutine = StartCoroutine(routine);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031E9")]
		[Cpp2IlInjected.Address(RVA = "0x12970C0", Offset = "0x1295AC0", VA = "0x1812970C0")]
		private void Start()
		{
			MenuLayoutTemplate oldLayout = _oldLayout;
			MenuLayoutTemplate currentLayout = GetCurrentLayout();
			if (oldLayout != currentLayout)
			{
				OnLayoutChange();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031EA")]
		[Cpp2IlInjected.Address(RVA = "0x1296FC0", Offset = "0x12959C0", VA = "0x181296FC0")]
		internal void SetInfo(SubtitlesRequestInfo info)
		{
			//Discarded unreachable code: IL_004b
			Transform transform = _contentRectTransform.transform;
			int num = 0;
			Vector2 zero = Vector2.zero;
			int num2 = 0;
			CurrentSubtitleInfo = info;
			_initiated = true;
			if (base.gameObject.activeInHierarchy)
			{
				RefreshSide();
				IEnumerator routine = Internal_OnSubtitlesRequestInfo();
				Coroutine coroutine = StartCoroutine(routine);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031EB")]
		[Cpp2IlInjected.Address(RVA = "0x1296CE0", Offset = "0x12956E0", VA = "0x181296CE0")]
		[IteratorStateMachine(typeof(_003CInternal_OnSubtitlesRequestInfo_003Ed__33))]
		private IEnumerator Internal_OnSubtitlesRequestInfo()
		{
			int _003C_003E1__state = default(int);
			_003CInternal_OnSubtitlesRequestInfo_003Ed__33 _003CInternal_OnSubtitlesRequestInfo_003Ed__ = new _003CInternal_OnSubtitlesRequestInfo_003Ed__33(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CInternal_OnSubtitlesRequestInfo_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031EC")]
		[Cpp2IlInjected.Address(RVA = "0x1296F30", Offset = "0x1295930", VA = "0x181296F30")]
		public void RefreshSide()
		{
			//Discarded unreachable code: IL_001d
			ConversationSide side = Side;
			if (side == ConversationSide.Left)
			{
				int num = 0;
			}
			if (side == ConversationSide.Right)
			{
				int num2 = 0;
				RectTransform backgroundHolder = _backgroundHolder;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031ED")]
		[Cpp2IlInjected.Address(RVA = "0x1296DB0", Offset = "0x12957B0", VA = "0x181296DB0")]
		internal void OnLayoutChange()
		{
			//Discarded unreachable code: IL_002f
			//IL_0028: Expected O, but got I4
			bool flag = default(bool);
			while (true)
			{
				MenuLayoutTemplate currentLayout = GetCurrentLayout();
				if (currentLayout != null)
				{
					_oldLayout = currentLayout;
					List<GameObjectTemplate> templates = (List<GameObjectTemplate>)(object)currentLayout.GetTemplates();
					if (flag)
					{
						int num = 0;
						if (this != (UnityEngine.Object)num)
						{
							int num2 = 0;
							break;
						}
						continue;
					}
					break;
				}
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031EE")]
		[Cpp2IlInjected.Address(RVA = "0x1296BF0", Offset = "0x12955F0", VA = "0x181296BF0")]
		internal MenuLayoutTemplate GetCurrentLayout()
		{
			//Discarded unreachable code: IL_0033
			int num = 0;
			RuntimePlatform runtimePlatform = PlatformUtils.GetRuntimePlatform();
			List<MenuLayoutTemplate> layoutTemplates = LayoutTemplates;
			Predicate<MenuLayoutTemplate> predicate = (Predicate<MenuLayoutTemplate>)(object)(Predicate<T>)delegate(MenuLayoutTemplate x)
			{
				//Discarded unreachable code: IL_0029
				int num2 = 0;
				if (!CanvasHelper.InstanceMain.IsLandscape)
				{
				}
				RuntimePlatform runtimePlatform2 = runtimePlatform;
				return x.IsLandscape = x.Platform == runtimePlatform2;
			};
			return (MenuLayoutTemplate)((List<T>)(object)layoutTemplates).Find((Predicate<>)(object)predicate);
		}

		[Cpp2IlInjected.Token(Token = "0x60031EF")]
		[Cpp2IlInjected.Address(RVA = "0x12974B0", Offset = "0x1295EB0", VA = "0x1812974B0")]
		public NPCConversationCell()
		{
		}//Discarded unreachable code: IL_00d4
		//IL_0085: Expected I4, but got I8
		//IL_00ad: Expected I4, but got I8

	}
}
