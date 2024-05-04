using System.Runtime.CompilerServices;
using UnityEngine;

namespace VRCAudioLink.Editor
{
	public class StringInList : PropertyAttribute
	{
		public delegate string[] GetStringList();

		public string[] List
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public StringInList(params string[] list)
		{
		}
	}
}
