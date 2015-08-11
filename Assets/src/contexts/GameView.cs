using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.src.contexts {
    public class GameView : View {
        
        public void CheckRaycast(Vector2 position) {
            Debug.Log(position);
        }

    }
}