using UnityEngine;
using System.Collections;

public class MapCell {

	public Vector2 position;
	
	//public float height;

	public bool IsAvailable { get; set; }

	public MapCell(Vector2 position, float height) {
		this.position = position;
	}
}
