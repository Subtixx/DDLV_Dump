using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Ftue;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009B6")]
	public class TutorialView : MonoBehaviour, IFtueElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003926")]
		[SerializeField]
		private GameObject _blocker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003927")]
		[SerializeField]
		private GameObject _tutorialPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003928")]
		public TutorialPointer pointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003929")]
		public TutorialHintBox hintBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400392A")]
		public RectTransform hintBoxAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400392B")]
		public Button continueButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400392C")]
		private bool done;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400392D")]
		private Transform currentMenuElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400392E")]
		private IMenuHint currentMenuHint;

		[Cpp2IlInjected.Token(Token = "0x1700085B")]
		public GameObject Blocker
		{
			[Cpp2IlInjected.Token(Token = "0x6003CD1")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _blocker;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700085C")]
		public GameObject TutorialPanel
		{
			[Cpp2IlInjected.Token(Token = "0x6003CD2")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _tutorialPanel;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD3")]
		[Cpp2IlInjected.Address(RVA = "0x17F7050", Offset = "0x17F5A50", VA = "0x1817F7050")]
		private void Awake()
		{
			//Discarded unreachable code: IL_004b
			FtueEventListener.RegisterElement(this);
			Button.ButtonClickedEvent onClick = continueButton.m_OnClick;
			UnityAction call = ContinueButtonClicked;
			onClick.AddListener(call);
			GameObject blocker = _blocker;
			int active = 0;
			blocker.SetActive((byte)active != 0);
			GameObject tutorialPanel = _tutorialPanel;
			int active2 = 0;
			tutorialPanel.SetActive((byte)active2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD4")]
		[Cpp2IlInjected.Address(RVA = "0x17F7AB0", Offset = "0x17F64B0", VA = "0x1817F7AB0")]
		private void OnDestroy()
		{
			FtueEventListener.UnregisterElement(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD5")]
		[Cpp2IlInjected.Address(RVA = "0x17F7C10", Offset = "0x17F6610", VA = "0x1817F7C10", Slot = "4")]
		public bool ShouldActivateFtue(FtueStep step)
		{
			if ((object)typeof(IWorldHint).TypeHandle != null)
			{
				return true;
			}
			return (object)typeof(IWorldHint).TypeHandle != null;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD6")]
		[Cpp2IlInjected.Address(RVA = "0x17F6CB0", Offset = "0x17F56B0", VA = "0x1817F6CB0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CActivateFtue_003Ed__16))]
		public Task ActivateFtue(FtueStep step, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD7")]
		[Cpp2IlInjected.Address(RVA = "0x17F6F20", Offset = "0x17F5920", VA = "0x1817F6F20")]
		[AsyncStateMachine(typeof(_003CActivateWorldFtue_003Ed__17))]
		private Task ActivateWorldFtue(IWorldHint worldHint, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD8")]
		[Cpp2IlInjected.Address(RVA = "0x17F6DE0", Offset = "0x17F57E0", VA = "0x1817F6DE0")]
		[AsyncStateMachine(typeof(_003CActivateMenuFtue_003Ed__18))]
		private Task ActivateMenuFtue(IMenuHint menuHint, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CD9")]
		[Cpp2IlInjected.Address(RVA = "0x17F73E0", Offset = "0x17F5DE0", VA = "0x1817F73E0")]
		[AsyncStateMachine(typeof(_003CFindElementAsync_003Ed__19))]
		private Task FindElementAsync(IMenuHint menuHint, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDA")]
		[Cpp2IlInjected.Address(RVA = "0x17F7510", Offset = "0x17F5F10", VA = "0x1817F7510")]
		private Transform FindElementParent(Transform menuRoot, string menuName, string containerName)
		{
			Transform transform = FindByName(menuRoot, menuName);
			if ((object)transform == null)
			{
				return FindByName(transform, containerName);
			}
			return transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDB")]
		[Cpp2IlInjected.Address(RVA = "0x17F7580", Offset = "0x17F5F80", VA = "0x1817F7580")]
		private Transform FindMenuRoot(IMenuHint menuHint)
		{
			//Discarded unreachable code: IL_004f
			if ((object)typeof(IMenuHint).TypeHandle != null)
			{
				if ((object)typeof(IMenuHint).TypeHandle != null)
				{
					if ((object)typeof(IMenuHint).TypeHandle != null)
					{
						int num = 0;
						if ((long)typeof(IMenuHint).TypeHandle != 1)
						{
							goto IL_003f;
						}
						UiRoot instance = UiRoot.Instance;
					}
					int num2 = 0;
					UiRoot instance2 = UiRoot.Instance;
				}
				int num3 = 0;
				UiRoot instance3 = UiRoot.Instance;
			}
			int num4 = 0;
			goto IL_003f;
			IL_003f:
			return UiRoot.Instance._menuStack.transform;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDC")]
		[Cpp2IlInjected.Address(RVA = "0x17F7160", Offset = "0x17F5B60", VA = "0x1817F7160")]
		private Transform FindByName(Transform parent, string name)
		{
			//Discarded unreachable code: IL_0053
			//IL_000b: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (!(parent == (UnityEngine.Object)num2))
			{
				Queue<Transform> queue = (Queue<Transform>)(object)new Queue<T>();
				((Queue<T>)(object)queue).Enqueue((T)parent);
				Transform transform = (Transform)((Queue<T>)(object)queue).Dequeue();
				if (transform.name == null)
				{
					IEnumerator enumerator = transform.GetEnumerator();
					int num3 = default(int);
					if (enumerator != null)
					{
						if (enumerator == null)
						{
						}
						num3 = 0;
						if (enumerator == null)
						{
							goto IL_004d;
						}
					}
					if (num3 == 0)
					{
					}
				}
			}
			int num4 = 0;
			goto IL_004d;
			IL_004d:
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDD")]
		[Cpp2IlInjected.Address(RVA = "0x17F7640", Offset = "0x17F6040", VA = "0x1817F7640")]
		private TutorialWidgetAnchor GetAnchor(BubblePosition bubblePos)
		{
			while (true)
			{
				if (bubblePos != 0 && bubblePos != 0)
				{
					switch (bubblePos)
					{
					case BubblePosition.Right:
						continue;
					}
					int num = 0;
					/*Error: Unexpected end of block*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDE")]
		[Cpp2IlInjected.Address(RVA = "0x17F7670", Offset = "0x17F6070", VA = "0x1817F7670")]
		private Vector3[] GetVertices(IWorldHint worldHint, Camera camera)
		{
			//IL_002c: Expected O, but got F4
			//IL_004e: Expected O, but got F4
			bool flag = default(bool);
			if (!flag)
			{
				Vector3[] array = new Vector3[2];
				Transform transform = camera.transform;
				Transform transform2 = camera.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				array[1] = (Vector3)z;
				Transform transform3 = camera.transform;
				Transform transform4 = camera.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				array[2] = (Vector3)z2;
				return array;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003CDF")]
		[Cpp2IlInjected.Address(RVA = "0x17F7B10", Offset = "0x17F6510", VA = "0x1817F7B10")]
		[AsyncStateMachine(typeof(_003CRecenterCamera_003Ed__25))]
		private Task RecenterCamera(Vector3 target, float height)
		{
			int num = 0;
			float z = target.z;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CE0")]
		[Cpp2IlInjected.Address(RVA = "0x17F7150", Offset = "0x17F5B50", VA = "0x1817F7150")]
		private void ContinueButtonClicked()
		{
			done = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6003CE1")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public TutorialView()
		{
		}
	}
}
