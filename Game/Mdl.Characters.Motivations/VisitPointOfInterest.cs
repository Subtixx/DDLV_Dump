using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Environments;
using Mdl.Environments.PointsOfInterest;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Characters.Motivations
{
	[Cpp2IlInjected.Token(Token = "0x20008FB")]
	public class VisitPointOfInterest : Motivation<VisitPointOfInterestConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003211")]
		private bool forcedPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4003212")]
		private float speed = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003213")]
		private float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4003214")]
		private int remainingPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003215")]
		private bool setAnimOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003216")]
		private Task visitPointTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003217")]
		private CancellationTokenSource ctSource;

		[Cpp2IlInjected.Token(Token = "0x170005F4")]
		public Type PointType
		{
			[Cpp2IlInjected.Token(Token = "0x600294D")]
			[Cpp2IlInjected.Address(RVA = "0xD4A5A0", Offset = "0xD48FA0", VA = "0x180D4A5A0")]
			get
			{
				IMotivation subMotivation = ((IMotivation)this).SubMotivation;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170005F5")]
		public IPointOfInterest CurrentPoint
		{
			[Cpp2IlInjected.Token(Token = "0x600294E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentPoint_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600294F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CCurrentPoint_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002950")]
		[Cpp2IlInjected.Address(RVA = "0xD4A550", Offset = "0xD48F50", VA = "0x180D4A550")]
		public VisitPointOfInterest(VisitPointOfInterestConfig config)
		{
			((Motivation<C>)(object)this)._002Ector((C)(object)config);
		}

		[Cpp2IlInjected.Token(Token = "0x6002951")]
		[Cpp2IlInjected.Address(RVA = "0xD491C0", Offset = "0xD47BC0", VA = "0x180D491C0", Slot = "13")]
		public override string GetInfo(GameObject agent)
		{
			string text = default(string);
			string text2 = default(string);
			uint num2 = default(uint);
			object[] array2;
			string text3 = default(string);
			string text4 = default(string);
			Type type = default(Type);
			while (true)
			{
				if (CurrentPoint == null)
				{
					string[] array = new string[(object)agent];
					string info = ((Motivation<C>)(object)this).GetInfo(agent);
					if (info != null && info == null)
					{
						continue;
					}
					array[0] = info;
					if (" - " != null && " - " == null)
					{
						continue;
					}
					array[1] = " - ";
					if (text != null && text == null)
					{
						continue;
					}
					array[2] = text;
					if (" - " == null || " - " != null)
					{
						array[3] = " - ";
						if (text2 == null || text2 != null)
						{
							array[4] = text2;
							return string.Concat(array);
						}
					}
					continue;
				}
				int num = 0;
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				array2 = new object[9];
				string info2 = ((Motivation<C>)(object)this).GetInfo(agent);
				if (info2 != null && info2 == null)
				{
					continue;
				}
				array2[0] = info2;
				if (text3 != null && text3 == null)
				{
					continue;
				}
				array2[1] = text3;
				if (text4 != null && text4 == null)
				{
					continue;
				}
				array2[2] = text4;
				int num3 = 0;
				string newLine = System.Environment.NewLine;
				if (newLine != null && newLine == null)
				{
					continue;
				}
				array2[3] = newLine;
				IPointOfInterest pointOfInterest = CurrentPoint;
				if ((object)type != null && (object)type == null)
				{
					continue;
				}
				array2[4] = type;
				int num4 = 0;
				string newLine2 = System.Environment.NewLine;
				if (newLine2 != null && newLine2 == null)
				{
					continue;
				}
				array2[5] = newLine2;
				IPointOfInterest pointOfInterest2 = CurrentPoint;
				if (newLine2 != null && newLine2 == null)
				{
					continue;
				}
				array2[6] = newLine2;
				int num5 = 0;
				string newLine3 = System.Environment.NewLine;
				if (newLine3 == null || newLine3 != null)
				{
					array2[7] = newLine3;
					if ("Arrived" == null || newLine3 != null)
					{
						break;
					}
				}
			}
			array2[8] = "Arrived";
			string text5 = string.Format("{0} - {1} - {2}{3}Point : {4}{5}Duration : {6}{7}Status : {8}", array2);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002952")]
		[Cpp2IlInjected.Address(RVA = "0xD491A0", Offset = "0xD47BA0", VA = "0x180D491A0")]
		public void ForcePoint(IPointOfInterest point)
		{
			CurrentPoint = point;
			forcedPoint = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002953")]
		[Cpp2IlInjected.Address(RVA = "0xD48CD0", Offset = "0xD476D0", VA = "0x180D48CD0", Slot = "14")]
		public override bool CanBeInterrupted(GameObject interruptee, GameObject interruptor)
		{
			IPointOfInterest pointOfInterest;
			do
			{
				pointOfInterest = CurrentPoint;
			}
			while (pointOfInterest == null);
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return pointOfInterest.Destroyed;
		}

		[Cpp2IlInjected.Token(Token = "0x6002954")]
		[Cpp2IlInjected.Address(RVA = "0xD49AC0", Offset = "0xD484C0", VA = "0x180D49AC0")]
		private IPointOfInterest PickPointOfInterest(IEnumerable<IPointOfInterest> points, IPointOfInterest excludePoint, GameObject agent)
		{
			//Discarded unreachable code: IL_0084, IL_008a, IL_0090, IL_0096, IL_009c, IL_00a2, IL_00a8, IL_00ae, IL_00b4, IL_00ba, IL_00c0, IL_00c6, IL_00cc, IL_00d2
			//IL_002d: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			int num7 = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			int num12 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (points == null)
				{
					break;
				}
				List<IPointOfInterest> list = (List<IPointOfInterest>)(object)new List<T>();
				int num4 = 0;
				int num5 = 0;
				int num6 = remainingPoints;
				if (num6 != 0)
				{
					if (!((object)num6.GetType()).Equals((object)num7))
					{
						continue;
					}
					while (!flag)
					{
					}
					while (!flag)
					{
					}
					int num8 = 0;
					while (num <= num4)
					{
					}
				}
				num3++;
				int num9 = 0;
				if (num6 != 0)
				{
				}
				if (num3 != 0)
				{
				}
				if (flag2)
				{
					int num10 = 0;
					if (num9 <= num9)
					{
						int num11 = 0;
					}
					num12++;
				}
				if (num12 + 1 == 0)
				{
				}
				break;
			}
			int num13 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002955")]
		[Cpp2IlInjected.Address(RVA = "0xD49940", Offset = "0xD48340", VA = "0x180D49940")]
		public static bool IsWithinRange(IPointOfInterest point, GameObject agent, VisitPointOfInterestConfig config, float minDistance, float maxDistance)
		{
			Transform transform = agent.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			int num3 = 0;
			float num4 = default(float);
			if (!(num4 >= minDistance))
			{
				int num5 = 0;
				num3 += num3;
				num5 += 328;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002956")]
		[Cpp2IlInjected.Address(RVA = "0xD4A210", Offset = "0xD48C10", VA = "0x180D4A210")]
		private void VisitNextPoint(GameObject agent)
		{
			//Discarded unreachable code: IL_0052, IL_0058, IL_005e, IL_0064
			int num = 0;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			Mdl.Environments.Environment componentInChildren = gameObject.GetComponentInChildren<Mdl.Environments.Environment>();
			IPointOfInterest pointOfInterest = CurrentPoint;
			IPointOfInterest[] _003CPointsOfInterest_003Ek__BackingField = componentInChildren.PointsOfInterest;
			IPointOfInterest point = this.PickPointOfInterest((IEnumerable<>)(object)_003CPointsOfInterest_003Ek__BackingField, pointOfInterest, agent);
			VisitPoint(agent, point);
		}

		[Cpp2IlInjected.Token(Token = "0x6002957")]
		[Cpp2IlInjected.Address(RVA = "0xD4A3B0", Offset = "0xD48DB0", VA = "0x180D4A3B0")]
		private void VisitPoint(GameObject agent, IPointOfInterest point)
		{
			if (point == null)
			{
			}
			CancellationTokenSource cancellationTokenSource = (ctSource = new CancellationTokenSource());
			CancellationTokenSource cancellationTokenSource2 = ctSource;
			float num = speed;
			CancellationToken token = cancellationTokenSource2.Token;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			visitPointTask = (Task)token;
			CurrentPoint = point;
			token = (CancellationToken)((object)token + (object)token);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002958")]
		[Cpp2IlInjected.Address(RVA = "0xD48DB0", Offset = "0xD477B0", VA = "0x180D48DB0", Slot = "15")]
		protected override void DoBegin(GameObject agent)
		{
			//IL_000b: Expected F4, but got I4
			//IL_0038: Expected I4, but got O
			while (true)
			{
				float minInclusive = UnityEngine.Random.Range(0f, 100f);
				INpc component = agent.GetComponent<INpc>();
				if (component != null)
				{
					speed = minInclusive;
				}
				float num = (duration = UnityEngine.Random.Range(minInclusive, 100f));
				remainingPoints = (int)component;
				setAnimOverride = false;
				if (component == null)
				{
					int num2 = UnityEngine.Random.Range(0, 100);
					setAnimOverride = (byte)num2 != 0;
				}
				if (forcedPoint)
				{
					continue;
				}
				if (CurrentPoint != null)
				{
					if ((object)typeof(IPointOfInterest).TypeHandle != null)
					{
						IPointOfInterest point = CurrentPoint;
						VisitPoint(agent, point);
					}
					if (setAnimOverride)
					{
						SetAnimOverride(agent, 1f);
					}
					return;
				}
				if (false)
				{
					break;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002959")]
		[Cpp2IlInjected.Address(RVA = "0xD4A140", Offset = "0xD48B40", VA = "0x180D4A140")]
		private void SetAnimOverride(GameObject agent, float weight)
		{
			//Discarded unreachable code: IL_0024
			//IL_0010: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			Animator componentInChildren = agent.GetComponentInChildren<Animator>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num)
			{
				int layerIndex = componentInChildren.GetLayerIndex((string)num);
				componentInChildren.SetLayerWeight(layerIndex, weight);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600295A")]
		[Cpp2IlInjected.Address(RVA = "0xD49070", Offset = "0xD47A70", VA = "0x180D49070", Slot = "16")]
		protected override void DoFinish(GameObject agent)
		{
			//Discarded unreachable code: IL_004d
			//IL_0025: Expected O, but got I8
			//IL_0035: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_004c: Expected F4, but got I4
			CancellationTokenSource cancellationTokenSource = ctSource;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				ctSource.Dispose();
				ctSource = (CancellationTokenSource)0;
			}
			Animator componentInChildren = agent.GetComponentInChildren<Animator>();
			int num = 0;
			if (componentInChildren != (UnityEngine.Object)num)
			{
				int layerIndex = componentInChildren.GetLayerIndex((string)num);
				int num2 = 0;
				componentInChildren.SetLayerWeight(layerIndex, num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600295B")]
		[Cpp2IlInjected.Address(RVA = "0xCC8B20", Offset = "0xCC7520", VA = "0x180CC8B20", Slot = "17")]
		protected override void DoPause(GameObject agent)
		{
			IMotivation subMotivation = ((IMotivation)this).SubMotivation;
		}

		[Cpp2IlInjected.Token(Token = "0x600295C")]
		[Cpp2IlInjected.Address(RVA = "0xD48FB0", Offset = "0xD479B0", VA = "0x180D48FB0", Slot = "18")]
		protected override bool DoExecute(float elapsed, GameObject agent)
		{
			Task task = visitPointTask;
			if (task != null)
			{
				if (task.IsCompleted && remainingPoints > 0)
				{
					VisitNextPoint(agent);
					return true;
				}
				if (!visitPointTask.IsCompleted)
				{
					return !visitPointTask.IsCanceled;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}
	}
}
