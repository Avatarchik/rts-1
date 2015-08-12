using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class MapView : View {

	[Inject]
	public IGameDataService GameDataService { get; set; }

	public Terrain terrain;

	private MapCell[,] cells;

	protected override void Start() {
		base.Start();
		Debug.Log (terrain.terrainData.size.x + " " + terrain.terrainData.size.y + " " + terrain.terrainData.size.z);
		cells = GetCellsByTerrain();
	}

	public MapCell[,] GetCellsByTerrain() {
		var cellSize = GameDataService.GetCommonData("CellSize");
		int widthCount = Mathf.RoundToInt(terrain.terrainData.size.x / cellSize);
		int lengthCount = Mathf.RoundToInt(terrain.terrainData.size.z / cellSize);
		var cells = new MapCell[widthCount,lengthCount];
		for (int i = 0; i < widthCount; i++) {
			for (int j = 0; j < lengthCount; j++) {
				var xpos = cellSize*i;
				var ypos = cellSize*j;
				cells[i,j] = new MapCell(new Vector2(xpos, ypos), terrain.SampleHeight(new Vector3(xpos,0,ypos)));
				var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				go.transform.parent = transform;
				go.transform.position = new Vector3(xpos,0,ypos);
				go.name = string.Format("Test ({0},{1})",i,j);
			}
		}
		return cells;
	}

	public void CheckCellOnClick(Vector3 position) {
		Debug.Log (position);
		var worldPos = Camera.main.ScreenToWorldPoint(position);
		Debug.Log (worldPos);
		if ((worldPos.x > terrain.terrainData.size.x || worldPos.x < terrain.terrainData.size.x) || 
		    worldPos.z > terrain.terrainData.size.z ||
		    worldPos.z < terrain.terrainData.size.z) {
			Debug.LogWarning ("Click is out of the terrain");

		} else {
			//Debug.Log (worldPos);

		}
	}

}
