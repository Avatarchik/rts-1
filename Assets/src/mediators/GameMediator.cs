using strange.extensions.mediation.impl;

namespace Assets.src.contexts {
    public class GameMediator : EventMediator {

        [Inject]
        public GameView View { get; set; }

        [Inject]
        public OnClickSignal OnClick { get; set; }


        public override void OnRegister() {
            OnClick.AddListener(View.HandleClick);

        }

        public override void OnRemove() {
            OnClick.RemoveListener(View.HandleClick);
        }
	
    }
}