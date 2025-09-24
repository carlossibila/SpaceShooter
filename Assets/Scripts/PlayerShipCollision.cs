using UnityEngine;

public class PlayerShipCollision : MonoBehaviour
{
    [SerializeField] GameObject destroyVFX;

    GameSceneManager gameSceneManager;

    void Start()
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        gameSceneManager.ReloadLevel();
        Instantiate(destroyVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
