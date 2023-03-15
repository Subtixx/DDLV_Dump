using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007B3")]
	public class InteractionInfo : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002D32")]
		[SerializeField]
		private GameObject _buttonItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4002D33")]
		[SerializeField]
		private Transform _buttonContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4002D34")]
		private Action<int> OnButtonClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4002D35")]
		private Func<(bool changed, IEnumerable<string> list)> updateFunc;

		[Cpp2IlInjected.Token(Token = "0x600313D")]
		[Cpp2IlInjected.Address(RVA = "0xD24FA0", Offset = "0xD239A0", VA = "0x180D24FA0", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_0029
			IInfoGizmoArgs infoGizmoArgs = default(IInfoGizmoArgs);
			if ((object)this != null && infoGizmoArgs != null && infoGizmoArgs != null)
			{
				updateFunc = (Func<(bool changed, IEnumerable<string> list)>)(object)infoGizmoArgs;
			}
			if ((long)this > 1 && (object)this != null && (object)this != null)
			{
				OnButtonClick = (Action<int>)(object)this;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600313E")]
		[Cpp2IlInjected.Address(RVA = "0xD25190", Offset = "0xD23B90", VA = "0x180D25190")]
		public void OnClick()
		{
			//IL_0014: Expected O, but got I4
			Action<int> onButtonClick = OnButtonClick;
			if (onButtonClick != null)
			{
				int num = 0;
				onButtonClick((T)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600313F")]
		[Cpp2IlInjected.Address(RVA = "0xD251E0", Offset = "0xD23BE0", VA = "0x180D251E0", Slot = "13")]
		protected override void Update()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003140")]
		[Cpp2IlInjected.Address(RVA = "0x87D270", Offset = "0x87BC70", VA = "0x18087D270")]
		public InteractionInfo()
		{
		}
	}
}
