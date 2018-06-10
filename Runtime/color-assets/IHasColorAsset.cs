using BeatThat.Properties;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BeatThat
{
	public interface IHasColorAsset  {

		ColorAsset colorAsset { get; }

		void OnColorAssetUpdated (ColorAsset colorAsset);
	}
}
