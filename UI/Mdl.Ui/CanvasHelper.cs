using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000229")]
	[RequireComponent(typeof(Canvas))]
	public class CanvasHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200022A")]
		public delegate void OrientationEventHandler(bool isLandscape);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40009AB")]
		private bool _wasLandscape;

		[Cpp2IlInjected.Token(Token = "0x40009AC")]
		private static List<CanvasHelper> helpers = (List<CanvasHelper>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x40009AD")]
		private static bool screenChangeVarsInitialized;

		[Cpp2IlInjected.Token(Token = "0x40009AE")]
		private static Rect lastSafeArea;

		[Cpp2IlInjected.Token(Token = "0x40009AF")]
		private static ScreenOrientation lastScreenOrientation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40009B0")]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40009B1")]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40009B2")]
		[SerializeField]
		private RectTransform safeAreaTransform;

		[Cpp2IlInjected.Token(Token = "0x170002A1")]
		public bool IsLandscape
		{
			[Cpp2IlInjected.Token(Token = "0x6000DA7")]
			[Cpp2IlInjected.Address(RVA = "0xA6DE40", Offset = "0xA6C840", VA = "0x180A6DE40")]
			get
			{
				int num = 0;
				int width = Screen.width;
				int num2 = 0;
				int height = Screen.height;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		public static CanvasHelper InstanceMain
		{
			[Cpp2IlInjected.Token(Token = "0x6000DA8")]
			[Cpp2IlInjected.Address(RVA = "0xA6DD60", Offset = "0xA6C760", VA = "0x180A6DD60")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event OrientationEventHandler OnOrientationChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000DA5")]
			[Cpp2IlInjected.Address(RVA = "0xA6DCC0", Offset = "0xA6C6C0", VA = "0x180A6DCC0")]
			[CompilerGenerated]
			add
			{
				OrientationEventHandler onOrientationChanged = this.OnOrientationChanged;
				Delegate @delegate = Delegate.Combine(onOrientationChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onOrientationChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000DA6")]
			[Cpp2IlInjected.Address(RVA = "0xA6DE80", Offset = "0xA6C880", VA = "0x180A6DE80")]
			[CompilerGenerated]
			remove
			{
				OrientationEventHandler onOrientationChanged = this.OnOrientationChanged;
				Delegate @delegate = Delegate.Remove(onOrientationChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onOrientationChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D380", Offset = "0xA6BD80", VA = "0x180A6D380")]
		private void Awake()
		{
			//Discarded unreachable code: IL_003c
			if (!((List<T>)(object)helpers).Contains((T)this))
			{
				((List<T>)(object)helpers).Add((T)this);
			}
			Canvas canvas = (this.canvas = GetComponent<Canvas>());
			RectTransform rectTransform = (this.rectTransform = GetComponent<RectTransform>());
			Rect safeArea = Screen.safeArea;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAA")]
		[Cpp2IlInjected.Address(RVA = "0xA6DAD0", Offset = "0xA6C4D0", VA = "0x180A6DAD0")]
		private void Start()
		{
			ApplySafeArea();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAB")]
		[Cpp2IlInjected.Address(RVA = "0xA6DAE0", Offset = "0xA6C4E0", VA = "0x180A6DAE0")]
		private void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0B0", Offset = "0xA6BAB0", VA = "0x180A6D0B0")]
		private void ApplySafeArea(bool applySafeArea = true)
		{
			//Discarded unreachable code: IL_0067
			//IL_0014: Expected O, but got I4
			int num = 0;
			RectTransform rectTransform = safeAreaTransform;
			int num2 = 0;
			int num3 = 0;
			if (!(rectTransform == (UnityEngine.Object)num3))
			{
				if (!applySafeArea)
				{
					int num4 = 0;
					Vector2 zero = Vector2.zero;
					int num5 = 0;
					Vector2 one = Vector2.one;
				}
				Rect safeArea = Screen.safeArea;
				Canvas canvas = this.canvas;
				Canvas canvas2 = this.canvas;
				Canvas canvas3 = this.canvas;
				Canvas canvas4 = this.canvas;
				RectTransform rectTransform2 = safeAreaTransform;
				RectTransform rectTransform3 = safeAreaTransform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D820", Offset = "0xA6C220", VA = "0x180A6D820")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_001c
			if (((List<T>)(object)helpers).Contains((T)this))
			{
				bool flag = ((List<T>)(object)helpers).Remove((T)this);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAE")]
		[Cpp2IlInjected.Address(RVA = "0xA6D930", Offset = "0xA6C330", VA = "0x180A6D930")]
		private static void SafeAreaChanged()
		{
			//Discarded unreachable code: IL_002e
			Rect rect = lastSafeArea;
			Rect safeArea = Screen.safeArea;
			bool flag = default(bool);
			if (!flag)
			{
				Rect safeArea2 = Screen.safeArea;
				int num = 0;
				List<CanvasHelper> list = helpers;
				List<CanvasHelper> list2 = helpers;
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D550", Offset = "0xA6BF50", VA = "0x180A6D550")]
		public static Vector2 GetCanvasSize()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D5F0", Offset = "0xA6BFF0", VA = "0x180A6D5F0")]
		public static Vector2 GetSafeAreaSize()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB1")]
		[Cpp2IlInjected.Address(RVA = "0xA6DBF0", Offset = "0xA6C5F0", VA = "0x180A6DBF0")]
		internal void UseSafeArea(bool hasSafeArea)
		{
			ApplySafeArea(hasSafeArea);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB2")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CanvasHelper()
		{
		}
	}
}
