using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.src.contexts {
    public class GameView : View {
        
        public void HandleClick(Vector3 position) {
			var ray = Camera.main.ScreenPointToRay (position);
			var colls = Physics.RaycastAll (ray);
			foreach (var col in colls) {
				var selectableObject = col.collider.gameObject.GetComponent<ISelectableObject>();
				if (selectableObject != null) {
					selectableObject.OnSelect();
				}
			}

        }

    }
}