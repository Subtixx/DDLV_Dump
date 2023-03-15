using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000961")]
	[RequireComponent(typeof(RectTransform))]
	public class SparklesBox : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40037CB")]
		public SparklesDefinition config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40037CC")]
		private RectTransform _rect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40037CD")]
		private ParticleSystem _sparkles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40037CE")]
		private Vector3[] _corners = new Vector3[4];

		[Cpp2IlInjected.Token(Token = "0x6003B1B")]
		[Cpp2IlInjected.Address(RVA = "0x15FE1F0", Offset = "0x15FCBF0", VA = "0x1815FE1F0")]
		private unsafe void Start()
		{
			//Discarded unreachable code: IL_006f
			RectTransform rectTransform = (_rect = GetComponent<RectTransform>());
			ParticleSystem sparklesPrefab = config.sparklesPrefab;
			Transform parent = base.transform;
			ParticleSystem particleSystem = (_sparkles = Object.Instantiate(sparklesPrefab, parent));
			ParticleSystem.MainModule main = _sparkles.main;
			ParticleSystem.MainModule.set_simulationSpace_Injected(ref *(ParticleSystem.MainModule*)main, ParticleSystemSimulationSpace.Custom);
			int num = 0;
			Transform value = Camera.main.transform;
			ParticleSystem.MainModule.set_customSimulationSpace_Injected(ref *(ParticleSystem.MainModule*)main, value);
			UpdateDimensions();
			ParticleSystemManager.Play(_sparkles);
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnEnable()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1D")]
		[Cpp2IlInjected.Address(RVA = "0x15FE6A0", Offset = "0x15FD0A0", VA = "0x1815FE6A0")]
		private void Update()
		{
			UpdateDimensions();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1E")]
		[Cpp2IlInjected.Address(RVA = "0x15FE3B0", Offset = "0x15FCDB0", VA = "0x1815FE3B0")]
		private void UpdateDimensions()
		{
			//Discarded unreachable code: IL_0092
			//IL_0057: Expected O, but got F4
			//IL_007d: Expected O, but got I4
			Vector3[] corners2;
			int num;
			do
			{
				num = 0;
				RectTransform rect = _rect;
				Vector3[] corners = _corners;
				rect.GetWorldCorners(corners);
				corners2 = _corners;
			}
			while (num >= corners2.Length);
			int num2 = 0;
			Camera main = Camera.main;
			Vector3[] corners3 = _corners;
			SparklesDefinition sparklesDefinition = config;
			num++;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			corners2[1] = (Vector3)z;
			int length = _corners.Length;
			ParticleSystem sparkles = _sparkles;
			int num3 = 0;
			sparkles.transform.position = (Vector3)num3;
			ParticleSystem sparkles2 = _sparkles;
			int num4 = 0;
			ParticleSystem.MainModule main2 = sparkles2.main;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B1F")]
		[Cpp2IlInjected.Address(RVA = "0x15FE170", Offset = "0x15FCB70", VA = "0x1815FE170")]
		public void Play()
		{
			//IL_0010: Expected O, but got I4
			ParticleSystem sparkles = _sparkles;
			int num = 0;
			if (sparkles != (Object)num)
			{
				ParticleSystemManager.Play(_sparkles);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B20")]
		[Cpp2IlInjected.Address(RVA = "0x15FE330", Offset = "0x15FCD30", VA = "0x1815FE330")]
		public void Stop()
		{
			//Discarded unreachable code: IL_001f
			//IL_0010: Expected O, but got I4
			ParticleSystem sparkles = _sparkles;
			int num = 0;
			if (sparkles != (Object)num)
			{
				_sparkles.Stop();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B21")]
		[Cpp2IlInjected.Address(RVA = "0x15FE6B0", Offset = "0x15FD0B0", VA = "0x1815FE6B0")]
		public SparklesBox()
		{
		}
	}
}
