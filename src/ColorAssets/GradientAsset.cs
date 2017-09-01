using UnityEngine;

namespace BeatThat
{
	/// <summary>
	/// Store a Gradient as an asset makes it easier to manage global/consistent color transitions.
	/// </summary>
	public class GradientAsset : ScriptableObject
	{
		[SerializeField] private Gradient m_gradient;
		public Gradient gradient { get { return m_gradient; } }
	}
}