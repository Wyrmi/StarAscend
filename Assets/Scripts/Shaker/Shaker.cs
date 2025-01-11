using UnityEngine;
using FirstGearGames.SmoothCameraShaker;
public class Shaker : MonoBehaviour
{
    [SerializeField]
    private ShakeData shakeData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player player))
        {
            CameraShakerHandler.Shake(shakeData);
        }
    }
}
