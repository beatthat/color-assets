using UnityEngine;
using System;
using UnityEngine.Serialization;

namespace BeatThat
{
	/// <summary>
	/// Store a Color as an asset makes it easier to manage global/consistent color transitions.
	/// </summary>
	public class ColorAsset : ScriptableObject, IHasColor
	{
		[FormerlySerializedAs("Color")][SerializeField] private Color m_value;
		[Obsolete("use value")]public Color color { get { return m_value; } }
		public Color value { get { return m_value; } set { m_value = value; } }
	}
}