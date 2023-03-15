using Cpp2IlInjected;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class SmoothFollow : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private Transform target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private float distance = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private float height = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private float rotationDamping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private float heightDamping;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void Start()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2330", Offset = "0x3DC0D30", VA = "0x183DC2330")]
		private void LateUpdate()
		{
			//Discarded unreachable code: IL_00ce
			//IL_0066: Expected F4, but got I4
			//IL_009c: Expected O, but got I4
			Transform transform = target;
			if ((bool)transform)
			{
				Transform transform2 = target;
				Vector3 eulerAngles = transform.eulerAngles;
				Transform transform3 = target;
				Vector3 position = transform.position;
				Transform transform4 = base.transform;
				Transform transform5 = base.transform;
				int num = 0;
				float deltaTime = Time.deltaTime;
				int num2 = 0;
				deltaTime = Time.deltaTime;
				float num3 = default(float);
				deltaTime = num3;
				int num4 = 0;
				float x = default(float);
				Quaternion quaternion = Quaternion.Euler(x, num4, deltaTime);
				Transform transform6 = base.transform;
				Transform transform7 = target;
				Transform transform8 = base.transform;
				int num5 = 0;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Vector3 forward = Vector3.forward;
				transform8.position = (Vector3)num5;
				Transform transform9 = base.transform;
				Transform transform10 = base.transform;
				Transform transform11 = base.transform;
				Transform transform12 = base.transform;
				Transform transform13 = target;
				transform12.LookAt(transform13);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2710", Offset = "0x3DC1110", VA = "0x183DC2710")]
		public SmoothFollow()
		{
		}
	}
}
