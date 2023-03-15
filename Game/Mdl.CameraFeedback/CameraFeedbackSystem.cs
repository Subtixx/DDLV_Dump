using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.CameraFeedback
{
	[Cpp2IlInjected.Token(Token = "0x200093B")]
	[RequireComponent(typeof(Camera))]
	public class CameraFeedbackSystem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200093C")]
		public struct Modification
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003348")]
			public Vector3 position;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4003349")]
			public Quaternion rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400334A")]
			public float fieldOfView;

			[Cpp2IlInjected.Token(Token = "0x6002A84")]
			[Cpp2IlInjected.Address(RVA = "0x13E5540", Offset = "0x13E3F40", VA = "0x1813E5540")]
			public unsafe Modification Inverse()
			{
				//IL_0002: Expected O, but got Ref
				return (Modification)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			}

			[Cpp2IlInjected.Token(Token = "0x6002A85")]
			[Cpp2IlInjected.Address(RVA = "0x13E54F0", Offset = "0x13E3EF0", VA = "0x1813E54F0")]
			public void Clear()
			{
				float z = Vector3.zero.z;
				Quaternion identity = Quaternion.identity;
				fieldOfView = 0f;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003344")]
		private Camera camera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003345")]
		private List<CameraFeedbackExtension> extensions = (List<CameraFeedbackExtension>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003346")]
		private Modification modification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003347")]
		private bool applied;

		[Cpp2IlInjected.Token(Token = "0x6002A7A")]
		[Cpp2IlInjected.Address(RVA = "0x164C8C0", Offset = "0x164B2C0", VA = "0x18164C8C0")]
		private void Awake()
		{
			//IL_0017: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			Camera camera = (this.camera = GetComponent<Camera>());
			int num = 0;
			modification = (Modification)num;
			modification = (Modification)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A7B")]
		[Cpp2IlInjected.Address(RVA = "0x164CB90", Offset = "0x164B590", VA = "0x18164CB90")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0047
			List<CameraFeedbackExtension> list = extensions;
			Action<CameraFeedbackExtension> _003C_003E9__6_ = _003C_003Ec._003C_003E9__6_0;
			if (_003C_003E9__6_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Action<T>)delegate(CameraFeedbackExtension x)
				{
					//Discarded unreachable code: IL_0007
					x.OnReset();
				};
			}
			((List<T>)(object)list).ForEach((Action<>)(object)_003C_003E9__6_);
			int _003C_003E1__state = default(int);
			_003CEndOfFrame_003Ed__8 _003CEndOfFrame_003Ed__ = new _003CEndOfFrame_003Ed__8(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CEndOfFrame_003Ed__._003C_003E4__this = this;
			Coroutine coroutine = StartCoroutine(_003CEndOfFrame_003Ed__);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A7C")]
		[Cpp2IlInjected.Address(RVA = "0x164C990", Offset = "0x164B390", VA = "0x18164C990")]
		private void LateUpdate()
		{
			//Discarded unreachable code: IL_0065
			if (!applied)
			{
				applied = true;
				List<CameraFeedbackExtension> list = extensions;
				Action<CameraFeedbackExtension> action = (Action<CameraFeedbackExtension>)(object)(Action<T>)delegate(CameraFeedbackExtension e)
				{
					//Discarded unreachable code: IL_0007
					e.OnReset();
				};
				((List<T>)(object)list).ForEach((Action<>)(object)action);
				float y = modification.rotation.y;
				Transform transform = base.transform;
				Transform transform2 = base.transform;
				Camera camera = this.camera;
				float fieldOfView = camera.fieldOfView;
				camera.fieldOfView = y;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002A7D")]
		[Cpp2IlInjected.Address(RVA = "0x164C920", Offset = "0x164B320", VA = "0x18164C920")]
		[IteratorStateMachine(typeof(_003CEndOfFrame_003Ed__8))]
		private IEnumerator EndOfFrame()
		{
			int _003C_003E1__state = default(int);
			_003CEndOfFrame_003Ed__8 _003CEndOfFrame_003Ed__ = new _003CEndOfFrame_003Ed__8(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CEndOfFrame_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002A7E")]
		[Cpp2IlInjected.Address(RVA = "0x164C750", Offset = "0x164B150", VA = "0x18164C750")]
		private void Apply(Modification modification)
		{
			//Discarded unreachable code: IL_0034
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			float y = modification.rotation.y;
			Camera camera = this.camera;
			float fieldOfView = camera.fieldOfView;
			camera.fieldOfView = y;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A7F")]
		[Cpp2IlInjected.Address(RVA = "0x164C6C0", Offset = "0x164B0C0", VA = "0x18164C6C0")]
		public void Add(CameraFeedbackExtension extension)
		{
			//Discarded unreachable code: IL_000d
			((List<T>)(object)extensions).Add((T)extension);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A80")]
		[Cpp2IlInjected.Address(RVA = "0x164CD30", Offset = "0x164B730", VA = "0x18164CD30")]
		public void Remove(CameraFeedbackExtension extension)
		{
			//Discarded unreachable code: IL_000e
			bool flag = ((List<T>)(object)extensions).Remove((T)extension);
		}

		[Cpp2IlInjected.Token(Token = "0x6002A81")]
		[Cpp2IlInjected.Address(RVA = "0x16CA470", Offset = "0x16C8E70", VA = "0x1816CA470")]
		public List<T> GetExtensions<T>() where T : CameraFeedbackExtension
		{
			Func<CameraFeedbackExtension, bool> func = default(Func<CameraFeedbackExtension, bool>);
			IEnumerable<CameraFeedbackExtension> enumerable = (IEnumerable<CameraFeedbackExtension>)Enumerable.Where<CameraFeedbackExtension>((IEnumerable<>)extensions, (Func<, >)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002A82")]
		[Cpp2IlInjected.Address(RVA = "0x164CDF0", Offset = "0x164B7F0", VA = "0x18164CDF0")]
		public CameraFeedbackSystem()
		{
		}
	}
}
