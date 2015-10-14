using UnityEngine;
using System.Collections;
using UnityEditor;

//View only for test
public class CellView : MonoBehaviour {

	public MapCell model;

	void OnDrawGizmos() {
		if (model != null)
			Handles.Label (transform.position, model.IsAvailable.ToString());
	}
}
