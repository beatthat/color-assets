using BeatThat.Properties;
using UnityEngine;
using UnityEngine.UI;

namespace BeatThat.ColorAssets
{
	/// <summary>
	/// Store a ColorBlock as an asset makes it easier to manage global/consistent selection colors.
	/// </summary>
	public class ColorBlockAsset : ScriptableObject
	{
		[SerializeField]
		private ColorBlock m_colors = ColorBlock.defaultColorBlock;
		public ColorBlock colors { get { return m_colors; } }
	}
}
