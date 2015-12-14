using UnityEngine;
using System.Collections;

/// <summary>
/// Class that handles transitions between levels and music.
/// </summary>
public class TransitionAndMusic {

	/// <summary>
	/// Saves the attribute.
	/// </summary>
	/// <param name="key">Key.</param>
	/// <param name="value">Value.</param>
	public static void SaveAttribute(string key, float value) {
		PlayerPrefs.SetFloat (key, value);
	}

	/// <summary>
	/// Gets the attrubute.
	/// </summary>
	/// <returns>The attrubute.</returns>
	/// <param name="key">Key.</param>
	public static float GetAttrubute(string key) {
		return PlayerPrefs.GetFloat (key);
	}

	/// <summary>
	/// Loads the level.
	/// </summary>
	/// <param name="toLevel">To level.</param>
	public static void LoadLevel(string toLevel) {
		Application.LoadLevel (toLevel);
	}
}
