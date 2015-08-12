using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.context.impl;

namespace Assets.src.contexts {
    public class GameContext : MVCSContext {

        private RootContext rootContext;

        public GameContext(MonoBehaviour view) : base(view) {
            rootContext = view as RootContext;
            rootContext.AddService(injectionBinder.GetInstance<IInputService>());
        }


        override public IContext Start() {
            base.Start();
            
            return this;
        }

        protected override void mapBindings() {
            
			//signals
            injectionBinder.Bind<OnClickSignal>().ToSingleton();
			//services
            injectionBinder.Bind<IInputService>().To<InputService>().ToSingleton();
			injectionBinder.Bind<IGameDataService>().To<GameDataService>().ToSingleton();
            //mediators
			mediationBinder.Bind<GameView>().To<GameMediator>();
			mediationBinder.Bind<MapView>().To<MapMediator>();
        }

    }
}