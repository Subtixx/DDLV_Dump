using System;
using System.Collections;
using System.Linq;
using Cpp2IlInjected;
using Meta;
using Meta.Missions;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200046F")]
	[ExecuteInEditMode]
	public class EventProgressNodes : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400167B")]
		public GameObject McRequestTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400167C")]
		public TextBase TfRequestDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400167D")]
		public RectTransform McProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400167E")]
		[Space]
		public GameObject PivotPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400167F")]
		public RectTransform PivotContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001680")]
		[Space]
		public GameObject ChapterNodePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4001681")]
		public GameObject RequestNodePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4001682")]
		public RectTransform NodeContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4001683")]
		[Space]
		public GameObject LinePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001684")]
		public RectTransform LineContainer;

		[Cpp2IlInjected.Token(Token = "0x6001C96")]
		[Cpp2IlInjected.Address(RVA = "0x1402840", Offset = "0x1401240", VA = "0x181402840")]
		internal EventProgressNodeChapter AddChapterNode()
		{
			//IL_0012: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00bc: Expected O, but got I4
			//IL_00bc: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			int num = 0;
			GameObject chapterNodePrefab = ChapterNodePrefab;
			int num2 = 0;
			if (chapterNodePrefab != (UnityEngine.Object)num2)
			{
				RectTransform nodeContainer = NodeContainer;
				int num3 = 0;
				if (nodeContainer != (UnityEngine.Object)num3)
				{
					GameObject chapterNodePrefab2 = ChapterNodePrefab;
					RectTransform nodeContainer2 = NodeContainer;
					GameObject gameObject = UnityEngine.Object.Instantiate(chapterNodePrefab2, nodeContainer2);
					GameObject pivotPrefab = PivotPrefab;
					int num4 = 0;
					if (pivotPrefab != (UnityEngine.Object)num4)
					{
						RectTransform pivotContainer = PivotContainer;
						int num5 = 0;
						if (pivotContainer != (UnityEngine.Object)num5)
						{
							GameObject pivotPrefab2 = PivotPrefab;
							RectTransform pivotContainer2 = PivotContainer;
							EventProgressPivot component = UnityEngine.Object.Instantiate(pivotPrefab2, pivotContainer2).GetComponent<EventProgressPivot>();
						}
					}
					EventProgressNodeChapter component2 = gameObject.GetComponent<EventProgressNodeChapter>();
					int num6 = 0;
					if (component2 != (UnityEngine.Object)num6)
					{
						int num7 = 0;
						if ((UnityEngine.Object)num != (UnityEngine.Object)num7)
						{
							component2.Pivot = (EventProgressPivot)num;
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C97")]
		[Cpp2IlInjected.Address(RVA = "0x1402DC0", Offset = "0x14017C0", VA = "0x181402DC0")]
		internal EventProgressNodeRequest AddRequestNode()
		{
			//IL_0012: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_0076: Expected O, but got I4
			//IL_00ae: Expected O, but got I4
			//IL_00bc: Expected O, but got I4
			//IL_00bc: Expected O, but got I4
			//IL_00c7: Expected O, but got I4
			int num = 0;
			GameObject requestNodePrefab = RequestNodePrefab;
			int num2 = 0;
			if (requestNodePrefab != (UnityEngine.Object)num2)
			{
				RectTransform nodeContainer = NodeContainer;
				int num3 = 0;
				if (nodeContainer != (UnityEngine.Object)num3)
				{
					GameObject requestNodePrefab2 = RequestNodePrefab;
					RectTransform nodeContainer2 = NodeContainer;
					GameObject gameObject = UnityEngine.Object.Instantiate(requestNodePrefab2, nodeContainer2);
					GameObject pivotPrefab = PivotPrefab;
					int num4 = 0;
					if (pivotPrefab != (UnityEngine.Object)num4)
					{
						RectTransform pivotContainer = PivotContainer;
						int num5 = 0;
						if (pivotContainer != (UnityEngine.Object)num5)
						{
							GameObject pivotPrefab2 = PivotPrefab;
							RectTransform pivotContainer2 = PivotContainer;
							EventProgressPivot component = UnityEngine.Object.Instantiate(pivotPrefab2, pivotContainer2).GetComponent<EventProgressPivot>();
						}
					}
					EventProgressNodeRequest component2 = gameObject.GetComponent<EventProgressNodeRequest>();
					int num6 = 0;
					if (component2 != (UnityEngine.Object)num6)
					{
						int num7 = 0;
						if ((UnityEngine.Object)num != (UnityEngine.Object)num7)
						{
							component2.Pivot = (EventProgressPivot)num;
						}
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C98")]
		[Cpp2IlInjected.Address(RVA = "0x1402CA0", Offset = "0x14016A0", VA = "0x181402CA0")]
		internal EventProgressNodeConnection AddLine()
		{
			//IL_0012: Expected O, but got I4
			//IL_0027: Expected O, but got I4
			int num = 0;
			GameObject linePrefab = LinePrefab;
			int num2 = 0;
			if (linePrefab != (UnityEngine.Object)num2)
			{
				RectTransform lineContainer = LineContainer;
				int num3 = 0;
				if (lineContainer != (UnityEngine.Object)num3)
				{
					GameObject linePrefab2 = LinePrefab;
					RectTransform nodeContainer = NodeContainer;
					EventProgressNodeConnection component = UnityEngine.Object.Instantiate(linePrefab2, nodeContainer).GetComponent<EventProgressNodeConnection>();
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C99")]
		[Cpp2IlInjected.Address(RVA = "0x1402AA0", Offset = "0x14014A0", VA = "0x181402AA0")]
		internal void AddConnections()
		{
			//Discarded unreachable code: IL_0094
			//IL_002b: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			RectTransform nodeContainer = NodeContainer;
			int num = 0;
			if (nodeContainer.childCount - 1 <= 0)
			{
				return;
			}
			int num2 = 0;
			GameObject linePrefab = LinePrefab;
			int num3 = 0;
			if (linePrefab != (UnityEngine.Object)num3)
			{
				RectTransform lineContainer = LineContainer;
				int num4 = 0;
				if (lineContainer != (UnityEngine.Object)num4)
				{
					GameObject linePrefab2 = LinePrefab;
					RectTransform nodeContainer2 = NodeContainer;
					EventProgressNodeConnection component = UnityEngine.Object.Instantiate(linePrefab2, nodeContainer2).GetComponent<EventProgressNodeConnection>();
				}
			}
			EventProgressNodeBase component2 = NodeContainer.GetChild(num).GetComponent<EventProgressNodeBase>();
			RectTransform nodeContainer3 = NodeContainer;
			num++;
			EventProgressNodeBase component3 = nodeContainer3.GetChild(num).GetComponent<EventProgressNodeBase>();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C9A")]
		[Cpp2IlInjected.Address(RVA = "0x14036B0", Offset = "0x14020B0", VA = "0x1814036B0")]
		internal void RefreshProgress()
		{
			//IL_00e4: Expected O, but got I4
			//IL_00f9: Expected I4, but got I8
			RectTransform pivotContainer = PivotContainer;
			int num = 0;
			int childCount = pivotContainer.childCount;
			int num2 = 0;
			int num3 = childCount - 1;
			childCount = num3;
			EventProgressPivot component = PivotContainer.GetChild(num3).GetComponent<EventProgressPivot>();
			while ((component.IsUnlocked ? 1 : 0) == num2)
			{
			}
			EventProgressNodeBase node = component.Node;
			while ((object)node == null)
			{
			}
			int num4 = 0;
			if ((object)node == null)
			{
				while ((object)node == null)
				{
				}
				int num5 = 0;
				while ((object)node == null)
				{
				}
				int num6 = 0;
				int num7 = 0;
				if (_003C_003Ec._003C_003E9__14_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((EventRequestModel x) => x.GetState() == EventRequestModel.State.Completed);
				}
				bool flag = default(bool);
				while (!flag)
				{
				}
			}
			if ((object)component.transform != null)
			{
			}
			RectTransform mcProgress = McProgress;
			RectTransform pivotContainer2 = PivotContainer;
			if ((component.IsUnlocked ? 1 : 0) != num2)
			{
				EventProgressNodeBase node2 = component.Node;
				if ((object)node2 != null)
				{
					int num8 = 0;
					if ((object)node2 != null)
					{
						int num9 = 0;
						Client client = default(Client);
						ProfileWorld world_ = client.profile.world_;
						int num10 = 0;
						if (Enumerable.Any<MissionSlot>(world_.GetValidMissionSlot(MissionSlotClass.TimeLimitedEvent, (Func<, >)num10)))
						{
							ulong num11 = default(ulong);
							McRequestTooltip.SetActive((byte)num11 != 0);
							TfRequestDesc.Text = "PLACEHOLDER";
							if ((object)TfRequestDesc.transform != null)
							{
							}
							if ((object)McRequestTooltip.transform != null)
							{
							}
							Transform transform = node2.transform;
							if ((object)McRequestTooltip.transform.parent != null)
							{
							}
							if ((object)transform != null)
							{
							}
							int num12 = 0;
							Transform transform2 = McRequestTooltip.transform;
						}
						return;
					}
				}
			}
			GameObject mcRequestTooltip = McRequestTooltip;
			int active = 0;
			mcRequestTooltip.SetActive((byte)active != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C9B")]
		[Cpp2IlInjected.Address(RVA = "0x1403DB0", Offset = "0x14027B0", VA = "0x181403DB0")]
		public void ResizeContainer()
		{
			//Discarded unreachable code: IL_0058, IL_005e, IL_0064, IL_0070, IL_0076
			uint num5 = default(uint);
			Rect rect = default(Rect);
			Vector2 vector = default(Vector2);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				if ((object)base.transform != null)
				{
				}
				int num3 = 0;
				if ((object)UiRoot.Instance._menuStack.transform != null)
				{
				}
				int num4 = 0;
				IEnumerator enumerator = NodeContainer.GetEnumerator();
				if (enumerator != null)
				{
					if (num2 < (int)num5)
					{
						num2 += num2;
						num2++;
					}
					int num6 = 0;
					if (enumerator == null)
					{
						break;
					}
				}
				if ((object)rect != null)
				{
				}
				if ((object)vector == null)
				{
					int num7 = 0;
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C9C")]
		[Cpp2IlInjected.Address(RVA = "0x1403020", Offset = "0x1401A20", VA = "0x181403020")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0101, IL_0107, IL_010d, IL_011f, IL_0125, IL_012b, IL_013d, IL_0143, IL_0149, IL_015b
			int num = 0;
			IEnumerator enumerator = NodeContainer.GetEnumerator();
			if (enumerator != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				int num3 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				int num4 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				EventProgressNodeBase eventProgressNodeBase = default(EventProgressNodeBase);
				eventProgressNodeBase.RefreshDisplay();
			}
			int num5 = 0;
			int num6 = 0;
			uint num7 = default(uint);
			if (num5 < (int)num7)
			{
				num5 += num5;
				num5++;
			}
			IEnumerator enumerator2 = default(IEnumerator);
			EventProgressPivot eventProgressPivot = default(EventProgressPivot);
			if (enumerator2 != null)
			{
				uint num8 = default(uint);
				if (num5 < (int)num8)
				{
					num5 += num5;
					num5++;
				}
				num5 += 312;
				num5 += 328;
				int num9 = 0;
				if (num5 == 0)
				{
					throw new InvalidCastException();
				}
				int num10 = 0;
				if (num5 == 0)
				{
					throw new InvalidCastException();
				}
				eventProgressPivot.RefreshDisplay();
			}
			int num11 = 0;
			if ((object)eventProgressPivot != null)
			{
				int num12 = 0;
			}
			uint num13 = default(uint);
			if (num11 < (int)num13)
			{
				num11 += num11;
				num11++;
			}
			IEnumerator enumerator3 = default(IEnumerator);
			EventProgressNodeConnection eventProgressNodeConnection = default(EventProgressNodeConnection);
			if (enumerator3 != null)
			{
				uint num14 = default(uint);
				if (num11 < (int)num14)
				{
					num11 += num11;
					num11++;
				}
				num11 += 312;
				num11 += 328;
				int num15 = 0;
				if (num11 == 0)
				{
					throw new InvalidCastException();
				}
				int num16 = 0;
				if (num11 == 0)
				{
					throw new InvalidCastException();
				}
				eventProgressNodeConnection.RefreshDisplay();
			}
			if ((object)eventProgressNodeConnection == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C9D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public EventProgressNodes()
		{
		}
	}
}
