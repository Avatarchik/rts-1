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
            
            injectionBinder.Bind<OnClickSignal>().ToSingleton();
            injectionBinder.Bind<IInputService>().To<InputService>().ToSingleton();
            mediationBinder.Bind<GameView>().To<GameMediator>();
        }

    }
}