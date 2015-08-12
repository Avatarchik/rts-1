using strange.extensions.mediation.impl;

namespace Assets.src.contexts {
    public class GameMediator : EventMediator {

        [Inject]
        public GameView view { get; set; }

        [Inject]
        public OnClickSignal OnClick { get; set; }


        public override void OnRegister() {
            //OnClick.AddListener(view.CheckRaycast);

        }

        public override void OnRemove() {
            //OnClick.RemoveListener(view.CheckRaycast);
        }

        /*
        [Inject]
        public ExampleView view { get; set; }

        public override void OnRegister() {

            //Listen to the view for an event
            view.dispatcher.AddListener(ExampleView.CLICK_EVENT, onViewClicked);

            //Listen to the global event bus for events
            dispatcher.AddListener(ExampleEvent.SCORE_CHANGE, onScoreChange);

            view.init();
        }

        public override void OnRemove() {
            //Clean up listeners when the view is about to be destroyed
            view.dispatcher.RemoveListener(ExampleView.CLICK_EVENT, onViewClicked);
            dispatcher.RemoveListener(ExampleEvent.SCORE_CHANGE, onScoreChange);
            Debug.Log("Mediator OnRemove");
        }

        private void onViewClicked() {
            Debug.Log("View click detected");
            dispatcher.Dispatch(ExampleEvent.REQUEST_WEB_SERVICE);
        }

        private void onScoreChange(IEvent evt) {
            //float score = (float)evt.data;
            string score = (string)evt.data;
            view.updateScore(score);
        }
        */
    }
}