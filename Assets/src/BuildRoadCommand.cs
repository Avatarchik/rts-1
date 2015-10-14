using Assets.src.contexts;
using Assets.src.mediators;
using UnityEngine;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class BuildRoadCommand : Command {

    [Inject]
    public Destination RoadDestination { get; set; }

    //[Inject]
    //public MapMediator View { get; set; }

    public override void Execute() {
        GameContext.instance.BindRoad();
        //Debug.Log(View);
        Debug.Log("Build Road from " + RoadDestination.From + " To " + RoadDestination.To);
        //GameObject.Instantiate(Resources.Load("Road"));
    }
}