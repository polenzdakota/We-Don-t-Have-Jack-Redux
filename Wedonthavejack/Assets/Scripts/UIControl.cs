using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {
	public GameObject actionList;
	public GameObject actionButton;

	public void ButtonPress(string strAction) {
		Vector3 iniVec = new Vector3 (0, 0, 0);
		Quaternion iniQuat = new Quaternion (0, 0, 0, 0);
		GameObject newButton = Instantiate (actionButton, iniVec, iniQuat) as GameObject;
		newButton.transform.SetParent (actionList.transform);
		newButton.GetComponentInChildren<Text>().text = strAction;
	}
}
