using UnityEngine;
using System.Collections;
using UnityEditor;

/// <summary>
/// Auto snap script for the editor.
/// Taken from Unity3d Forums
/// </summary>
public class AutoSnap : EditorWindow {
	private Vector3 prevPos;
	private bool doSnap = true;
	private float snapValue = 1;

	[MenuItem("Edit/Auto Snap %_1")]

	/// <summary>
	/// Init this instance.
	/// </summary>
	static void Init() {
		var window = (AutoSnap)EditorWindow.GetWindow( typeof( AutoSnap ) );
		window.maxSize = new Vector2 (200, 100);
	}

	/// <summary>
	/// Raises the GUI event.
	/// </summary>
	public void OnGUI() {
		doSnap = EditorGUILayout.Toggle ("Auto Snap", doSnap);
		snapValue = EditorGUILayout.FloatField ("Snap Value", snapValue);
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	public void Update() {
		if (doSnap
			&& !EditorApplication.isPlaying
			&& Selection.transforms.Length > 0
			&& Selection.transforms [0].position != prevPos) {

			Snap ();
			prevPos = Selection.transforms[0].position;
		}
	}

	/// <summary>
	/// Raises the enable event. Makes it so AutoSnap tab does not
	/// need to be open snap to grid.
	/// </summary>
	void OnEnable() {
		EditorApplication.update += Update;
	}

	/// <summary>
	/// Snap this instance.
	/// </summary>
	private void Snap() {
		foreach (var transform in Selection.transforms) {
			var t = transform.transform.position;
			t.x = Round(t.x);
			t.y = Round(t.y);
			t.z = Round(t.z);
			transform.transform.position = t;
		}
	}

	/// <summary>
	/// Round the specified input.
	/// </summary>
	/// <param name="input">Input.</param>
	private float Round(float input) {
		return snapValue * Mathf.Round ((input / snapValue));
	}
}
