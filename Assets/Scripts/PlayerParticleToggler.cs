using FirstGearGames.SmoothCameraShaker;
using UnityEngine;

public class PlayerParticleToggler : MonoBehaviour
{
    [SerializeField]
    private GameObject playerWallParticle;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            playerWallParticle.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            playerWallParticle.SetActive(false);
        }
    }
}
