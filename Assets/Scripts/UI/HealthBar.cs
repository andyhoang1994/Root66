using UnityEngine;
using UnityEngine.UI;

namespace Root66.PlayerSystems
{
    public class HealthBar : MonoBehaviour
    {
        public Image healthBarImage;
        public Player player;

        public void UpdateHealthBar()
        {
            healthBarImage.fillAmount = Mathf.Clamp(player.health / player.MaxHealth, 0, 1f);
        }
    }
}