using System;
using Assets.src.model;
using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using Assets.src.contexts;

namespace Assets.src.mediators { /*
public abstract class ViewModelMediator<T> : EventMediator where T : IMapModel {
    
    public T Model { get; set; }
    
    public override void OnRegister() {
        Model = Activator.CreateInstance<T>();
        
    }
}
 */

    public class MapMediator : EventMediator {

        [Inject]
        public MapView View { get; set; }
	
        [Inject]
        public OnClickSignal OnClick { get; set; }

        [Inject]
        public OnBuildRoadSignal OnBuildRoadSignal { get; set; }

        //[Inject]
        //public IMapModel MapModel { get; set; }

        public void CreateRoad() {
            OnBuildRoadSignal.Dispatch(new Destination(new Vector2(0, 0), new Vector2(5, 5)));
        }

        public override void OnRegister() {
            base.OnRegister();
            //Model.CreateRoad();
            //MapModel.Init(new MapCell[View.mapHeight, View.mapWidth], View.mapWidth, View.mapHeight);
            CreateRoad();
            //OnClick.AddListener(view.CheckCellOnClick);

        }
	
        public override void OnRemove() {
            //OnClick.RemoveListener(view.CheckCellOnClick);
        }
    }
}