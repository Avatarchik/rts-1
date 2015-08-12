using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using Assets.src.contexts;

public class MapMediator : EventMediator {

	[Inject]
	public MapView view { get; set; }
	
	[Inject]
	public OnClickSignal OnClick { get; set; }
	
	
	public override void OnRegister() {
		OnClick.AddListener(view.CheckCellOnClick);
		
	}
	
	public override void OnRemove() {
		OnClick.RemoveListener(view.CheckCellOnClick);
	}
}
