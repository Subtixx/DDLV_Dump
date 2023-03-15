using System;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2IlInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000720")]
	[ParadoxNotion.Design.Category("Movement/Pathfinding")]
	[Name("Seek (Calculated)", 0)]
	public class CalculatedMoveToPosition : ActionTask<NavMeshAgent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002960")]
		public BBParameter<Vector3> targetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002961")]
		public BBParameter<float> speed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002962")]
		public BBParameter<float> keepDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002963")]
		public bool periodicRepath;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4002964")]
		public float periodicRepathInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4002965")]
		public float debugDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4002966")]
		private float elapsed;

		[Cpp2IlInjected.Token(Token = "0x1700047D")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6001F95")]
			[Cpp2IlInjected.Address(RVA = "0x1647260", Offset = "0x1645C60", VA = "0x181647260", Slot = "9")]
			get
			{
				//IL_001f: Expected O, but got I4
				BBParameter<Vector3> bBParameter = targetPosition;
				if (bBParameter != null)
				{
					string text = bBParameter.ToString();
				}
				int num = 0;
				return "Seek (Calculated)" + (string)num;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047E")]
		private bool ShouldDebug
		{
			[Cpp2IlInjected.Token(Token = "0x6001F9C")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700047F")]
		private string DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x6001F9D")]
			[Cpp2IlInjected.Address(RVA = "0x16471E0", Offset = "0x1645BE0", VA = "0x1816471E0")]
			get
			{
				//Discarded unreachable code: IL_001d
				string text = ((UnityEngine.Component)(object)((ActionTask<T>)(object)this).agent).gameObject.name;
				return "SeekCalc." + text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F96")]
		[Cpp2IlInjected.Address(RVA = "0x1646710", Offset = "0x1645110", VA = "0x181646710", Slot = "13")]
		protected override void OnExecute()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F97")]
		[Cpp2IlInjected.Address(RVA = "0x1646AB0", Offset = "0x16454B0", VA = "0x181646AB0", Slot = "14")]
		protected override void OnUpdate()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F98")]
		[Cpp2IlInjected.Address(RVA = "0x1646E90", Offset = "0x1645890", VA = "0x181646E90")]
		private bool SetDestination(Vector3 destination)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F99")]
		[Cpp2IlInjected.Address(RVA = "0x1646930", Offset = "0x1645330", VA = "0x181646930", Slot = "16")]
		protected override void OnStop()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9A")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4F0", Offset = "0x8CBEF0", VA = "0x1808CD4F0", Slot = "17")]
		protected override void OnPause()
		{
			string filter = ((IBindingListView)this).Filter;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9B")]
		[Cpp2IlInjected.Address(RVA = "0x1646DA0", Offset = "0x16457A0", VA = "0x181646DA0")]
		private bool PositionsEqual(Vector3 position1, Vector3 position2)
		{
			//IL_0027: Expected F4, but got O
			float z = position2.z;
			float z2 = position1.z;
			float stoppingDistance = ((NavMeshAgent)(object)((ActionTask<T>)(object)this).agent).stoppingDistance;
			float num = (float)((BBParameter<T>)(object)keepDistance).value;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9E")]
		[Cpp2IlInjected.Address(RVA = "0x1646570", Offset = "0x1644F70", VA = "0x181646570")]
		[Conditional("DEBUG")]
		private void DebugDrawDestinationAndTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9F")]
		[Cpp2IlInjected.Address(RVA = "0x16466D0", Offset = "0x16450D0", VA = "0x1816466D0")]
		[Conditional("DEBUG")]
		private void OSD_Agent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA0")]
		[Cpp2IlInjected.Address(RVA = "0x1646640", Offset = "0x1645040", VA = "0x181646640")]
		[Conditional("DEBUG")]
		private void Log(string message)
		{
			UnityEngine.Debug.Log(DebugName + ": " + message);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA1")]
		[Cpp2IlInjected.Address(RVA = "0x16465B0", Offset = "0x1644FB0", VA = "0x1816465B0")]
		[Conditional("DEBUG")]
		private void LogWarning(string message)
		{
			UnityEngine.Debug.LogWarning(DebugName + ": " + message);
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA2")]
		[Cpp2IlInjected.Address(RVA = "0x1647130", Offset = "0x1645B30", VA = "0x181647130")]
		public CalculatedMoveToPosition()
		{
			BBParameter<> bBParameter = default(BBParameter<>);
			speed = (BBParameter<float>)(object)bBParameter;
			BBParameter<> bBParameter2 = default(BBParameter<>);
			keepDistance = (BBParameter<float>)(object)bBParameter2;
			periodicRepathInterval = 2f;
			debugDuration = 20f;
			((ActionTask<T>)(object)this)._002Ector();
		}
	}
}
