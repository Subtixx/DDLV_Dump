using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mdl.Activities;
using Mdl.Navigation;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007CA")]
	public class MultipleChoiceTaskHandler : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002DC5")]
		[SerializeField]
		private List<TaskButtonHolder> _buttonsPrefabList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002DC6")]
		[SerializeField]
		private GameObject _targetObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002DC7")]
		[SerializeField]
		private TaskButtonHolder _buttonHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002DC8")]
		[SerializeField]
		private TaskInfo _mcTaskInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002DC9")]
		private WaterStateDisplay _waterState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002DCA")]
		public Action<int> SelectedTask;

		[Cpp2IlInjected.Token(Token = "0x60031BE")]
		[Cpp2IlInjected.Address(RVA = "0x12967E0", Offset = "0x12951E0", VA = "0x1812967E0")]
		public void Show()
		{
			//Discarded unreachable code: IL_003c
			base.gameObject.SetActive(value: true);
			Transform transform = base.gameObject.transform;
			float z = Vector3.zero.z;
			Transform transform2 = base.gameObject.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
		}

		[Cpp2IlInjected.Token(Token = "0x60031BF")]
		[Cpp2IlInjected.Address(RVA = "0x12960B0", Offset = "0x1294AB0", VA = "0x1812960B0")]
		internal void Init(List<PlayerTaskDefinition> playerTasks, GameObject target)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60031C0")]
		[Cpp2IlInjected.Address(RVA = "0x1296630", Offset = "0x1295030", VA = "0x181296630")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0039, IL_003f, IL_0045
			//IL_0018: Expected O, but got I4
			int num = 0;
			StopAllCoroutines();
			TaskButtonHolder buttonHolder = _buttonHolder;
			int num2 = 0;
			if (buttonHolder != (UnityEngine.Object)num2)
			{
				List<NotificationButton> buttons = _buttonHolder.Buttons;
				bool flag = default(bool);
				if (flag)
				{
					Button button = default(Button);
					button.m_OnClick.RemoveAllListeners();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031C1")]
		[Cpp2IlInjected.Address(RVA = "0x12967B0", Offset = "0x12951B0", VA = "0x1812967B0")]
		private void SetTarget(GameObject target)
		{
			_targetObject = target;
			Update();
		}

		[Cpp2IlInjected.Token(Token = "0x60031C2")]
		[Cpp2IlInjected.Address(RVA = "0x1296060", Offset = "0x1294A60", VA = "0x181296060")]
		private void Finalize(PlayerTaskDefinition task, int index)
		{
			//IL_0012: Expected O, but got I4
			((Action<T>)(object)SelectedTask)?.Invoke((T)index);
		}

		[Cpp2IlInjected.Token(Token = "0x60031C3")]
		[Cpp2IlInjected.Address(RVA = "0x12968F0", Offset = "0x12952F0", VA = "0x1812968F0")]
		private void Update()
		{
			//Discarded unreachable code: IL_005a
			//IL_0010: Expected O, but got I4
			//IL_0059: Expected O, but got I4
			GameObject targetObject = _targetObject;
			int num = 0;
			if (!(targetObject == (UnityEngine.Object)num))
			{
				Collider component = _targetObject.GetComponent<Collider>();
				int num2 = 0;
				Camera main = Camera.main;
				int num3 = 0;
				Camera main2 = Camera.main;
				int num4 = 0;
				Camera main3 = Camera.main;
				Transform transform = _targetObject.transform;
				int num5 = 0;
				base.transform.position = (Vector3)num5;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60031C4")]
		[Cpp2IlInjected.Address(RVA = "0x1295FE0", Offset = "0x12949E0", VA = "0x181295FE0")]
		internal void ClosingCoroutine()
		{
			//Discarded unreachable code: IL_0019
			int _003C_003E1__state = default(int);
			_003CClose_003Ed__13 _003CClose_003Ed__ = new _003CClose_003Ed__13(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CClose_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CClose_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x60031C5")]
		[Cpp2IlInjected.Address(RVA = "0x1295F70", Offset = "0x1294970", VA = "0x181295F70")]
		[IteratorStateMachine(typeof(_003CClose_003Ed__13))]
		private IEnumerator Close()
		{
			int _003C_003E1__state = default(int);
			_003CClose_003Ed__13 _003CClose_003Ed__ = new _003CClose_003Ed__13(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CClose_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60031C6")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public MultipleChoiceTaskHandler()
		{
		}
	}
}
