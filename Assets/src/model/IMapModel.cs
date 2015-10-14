using System;

namespace Assets.src.model {

    public interface IMapModel {
        void Init(MapCell[,] mapCells, int width, int height);
        Action<RoadModel> OnRoadCreated { get; set; }
    }
}