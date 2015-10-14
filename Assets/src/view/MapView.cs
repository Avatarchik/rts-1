using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class MapView : View {


	[Inject]
	public IGameDataService GameDataService { get; set; }

	public Transform terrain;

	private MapCell[,] cells;

	public int mapWidth;

	public int mapHeight;

	protected override void Start() {
		base.Start();
		//Debug.Log (terrain.terrainData.size.x + " " + terrain.terrainData.size.y + " " + terrain.terrainData.size.z);
		cells = GetCellsByTerrain();
	}

	public MapCell[,] GetCellsByTerrain() {
		mapWidth = Mathf.RoundToInt(terrain.localScale.x);
		mapHeight = Mathf.RoundToInt(terrain.localScale.z);
		float cellSize = GameDataService.GetCommonData ("CellSize");
		var cells = new MapCell[mapWidth,mapHeight];
		for (int i = 0; i < mapWidth; i++) {
			for (int j = 0; j < mapHeight; j++) {
				var xpos = cellSize*i;
				var ypos = cellSize*j;

				//Test gameobject
				var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				go.GetComponent<Collider>().enabled = false;
				var pos = new Vector3(xpos+cellSize/2,0,ypos+cellSize/2);
				go.transform.parent = transform;
				go.transform.position = pos;
				go.transform.localScale = Vector3.one*0.2f;
				go.name = string.Format("Test ({0},{1})",i,j);
				var cellView = go.AddComponent<CellView>();


				//Init model
				cells[i,j] = new MapCell(new Vector2(xpos, ypos), 0);
				var colls = Physics.OverlapSphere(pos, cellSize);
				//One collision will be the ground	
				cells[i,j].IsAvailable = colls.Length <= 1;

				cellView.model = cells[i,j];


			}
		}
		return cells;
	}	
}
