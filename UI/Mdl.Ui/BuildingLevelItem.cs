using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200029F")]
	[RequiredAllNotNull]
	public class BuildingLevelItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000BD0")]
		[SerializeField]
		private List<TextBase> _stats = (List<TextBase>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000BD1")]
		[SerializeField]
		private Image _mcBackground;

		[Cpp2IlInjected.Token(Token = "0x6001074")]
		[Cpp2IlInjected.Address(RVA = "0xA68D80", Offset = "0xA67780", VA = "0x180A68D80")]
		internal void RefreshDisplay(UpgradeData upgradeData, UpgradeData prevUpgradeData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001075")]
		[Cpp2IlInjected.Address(RVA = "0xA693B0", Offset = "0xA67DB0", VA = "0x180A693B0")]
		public BuildingLevelItem()
		{
		}
	}
}
