using System;

namespace ru.pragmatix.orbix.world.managers {
    public interface ICooldownItem {
        int Id { get; }
        float Duration { get; }
        float ElapsedTime { get; }

        Action OnTick { get; }
        Action OnEnd { get; }
        float TickInterval { get; }

        float GetPCT();
        float GetTimeLeft();
        void AddDuration(float delta);
        float GetDuration();
    }
}