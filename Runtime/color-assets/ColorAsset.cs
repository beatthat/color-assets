using UnityEngine;
using System;
using UnityEngine.Serialization;

namespace BeatThat
{
	/// <summary>
	/// Store a Color as an asset as a way to manage globally consistent colors.
	/// </summary>
	public class ColorAsset : ScriptableObject, IHasColor
	{
		[FormerlySerializedAs("Color")][SerializeField] private Color m_value;
		[Obsolete("use value")]public Color color { get { return m_value; } }
		public Color value { get { return m_value; } set { m_value = value; } }
		public object valueObj { get { return this.value; } }
	}
}