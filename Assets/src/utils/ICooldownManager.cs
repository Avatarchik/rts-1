using System;

namespace ru.pragmatix.orbix.world.managers {
    public interface ICooldownManager {
        int GetUniqueId();
        ICooldownItem AddCooldown(float duration, Action onTick, Action onEnd, float elapsedTime = 0, float tickInterval = 1);
        ICooldownItem GetById(int id);
        void RemoveCooldown(ICooldownItem item);
        void Clear();
    }
}