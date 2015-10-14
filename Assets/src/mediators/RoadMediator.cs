using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.src.mediators {
    public class RoadMediator : EventMediator {
        [Inject]
        public RoadView View { get; set; }

        public override void OnRegister() {
            base.OnRegister();
            Debug.Log(View);

        }
    }
}