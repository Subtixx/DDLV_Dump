using System;
using System.Collections;
using Cpp2IlInjected;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000959")]
	public class PlayerTaskQueueView : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400379E")]
		[SerializeField]
		private RectTransform _tasksContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400379F")]
		public PlayerTaskView taskPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40037A0")]
		private PlayerNavigation _playerNavigation;

		[Cpp2IlInjected.Token(Token = "0x6003ADE")]
		[Cpp2IlInjected.Address(RVA = "0xE109D0", Offset = "0xE0F3D0", VA = "0x180E109D0")]
		private void Start()
		{
			//Discarded unreachable code: IL_009c, IL_00ae
			int num = 0;
			PlayerNavigation playerNavigation = (_playerNavigation = SystemRoot.Instance.GetSystem<PlayerNavigation>());
			PlayerNavigation playerNavigation2 = _playerNavigation;
			PlayerNavigation.TaskQueued value = AddTask;
			playerNavigation2.OnTaskQueued += value;
			PlayerNavigation playerNavigation3 = _playerNavigation;
			PlayerNavigation.TaskCancelled value2 = RemoveTask;
			playerNavigation3.OnTaskCancelled += value2;
			PlayerNavigation playerNavigation4 = _playerNavigation;
			PlayerNavigation.TaskCompleted value3 = RemoveTask;
			playerNavigation4.OnTaskCompleted += value3;
			IEnumerator enumerator = _tasksContainer.GetEnumerator();
			GameObject gameObject = default(GameObject);
			if (enumerator != null)
			{
				int num2 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			if ((object)gameObject == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003ADF")]
		[Cpp2IlInjected.Address(RVA = "0xE106E0", Offset = "0xE0F0E0", VA = "0x180E106E0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0056
			PlayerNavigation playerNavigation = _playerNavigation;
			PlayerNavigation.TaskQueued value = AddTask;
			playerNavigation.OnTaskQueued -= value;
			PlayerNavigation playerNavigation2 = _playerNavigation;
			PlayerNavigation.TaskCancelled value2 = RemoveTask;
			playerNavigation2.OnTaskCancelled -= value2;
			PlayerNavigation playerNavigation3 = _playerNavigation;
			PlayerNavigation.TaskCompleted value3 = RemoveTask;
			playerNavigation3.OnTaskCompleted -= value3;
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE0")]
		[Cpp2IlInjected.Address(RVA = "0xE104A0", Offset = "0xE0EEA0", VA = "0x180E104A0")]
		private void AddTask(PlayerTask task, int index)
		{
			//Discarded unreachable code: IL_00a4
			int childCount = _tasksContainer.childCount;
			PlayerTaskView original = taskPrefab;
			childCount -= index;
			RectTransform tasksContainer = _tasksContainer;
			PlayerTaskView playerTaskView = UnityEngine.Object.Instantiate(original, tasksContainer);
			Transform transform = playerTaskView.transform;
			float z = Vector3.one.z;
			playerTaskView._icon.SetNativeSize();
			if (_tasksContainer.childCount == 1)
			{
				playerTaskView.PlayAnimation();
			}
			playerTaskView.transform.SetSiblingIndex(childCount);
			Button.ButtonClickedEvent onClick = playerTaskView._button.m_OnClick;
			UnityAction call = delegate
			{
				//Discarded unreachable code: IL_0016
				PlayerTaskQueueView playerTaskQueueView = this;
				PlayerTask task2 = task;
				playerTaskQueueView.CancelTask(task2);
			};
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE1")]
		[Cpp2IlInjected.Address(RVA = "0xE10810", Offset = "0xE0F210", VA = "0x180E10810")]
		private void RemoveTask(PlayerTask task, int index)
		{
			//Discarded unreachable code: IL_0080
			if (_tasksContainer.childCount > 1)
			{
				RectTransform tasksContainer = _tasksContainer;
				int index2 = 0;
				int childCount = tasksContainer.childCount;
				tasksContainer.GetChild(index2).GetComponent<PlayerTaskView>().PlayAnimation();
			}
			int childCount2 = _tasksContainer.childCount;
			RectTransform tasksContainer2 = _tasksContainer;
			childCount2 -= index;
			int index3 = childCount2 - 1;
			TweenMax.KillAllByCancelationToken(tasksContainer2.GetChild(index3).GetComponent<PlayerTaskView>());
			RectTransform tasksContainer3 = _tasksContainer;
			int index4 = childCount2 - 1;
			UnityEngine.Object.Destroy(tasksContainer3.GetChild(index4).gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE2")]
		[Cpp2IlInjected.Address(RVA = "0xE106C0", Offset = "0xE0F0C0", VA = "0x180E106C0")]
		private void CancelTask(PlayerTask task)
		{
			//Discarded unreachable code: IL_000d
			_playerNavigation.CancelQueuedTask(task);
		}

		[Cpp2IlInjected.Token(Token = "0x6003AE3")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PlayerTaskQueueView()
		{
		}
	}
}
