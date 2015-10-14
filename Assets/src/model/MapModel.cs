using System;
using Assets.src.contexts;
using Assets.src.mediators;
using UnityEngine;
using System.Collections;

namespace Assets.src.model {
    public class MapModel : IMapModel {
    
        [Inject]
        public MapMediator Mediator { get; set; }

        [Inject]
        public OnBuildRoadSignal OnBuildRoadSignal { get; set; }

        public void CreateRoad() {
            OnBuildRoadSignal.Dispatch(new Destination(new Vector2(0,0), new Vector2(5,5)));
        }

        public void Init(MapCell[,] mapCells, int width, int height) {
            
        }

        public Action<RoadModel> OnRoadCreated { get; set; }
    }
}