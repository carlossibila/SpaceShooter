using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyVFX_Type;
    [SerializeField] int hitPoints = 4;
    [SerializeField] int ScoreValue = 10;

    Scoreboard scoreboard;

    private void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();   
    }

    void OnParticleCollision(GameObject other)
    {
        HitDamage();
    }

    void HitDamage()
    {
        hitPoints--;
        if (hitPoints <= 0)
        {
            scoreboard.IncreaseScore(ScoreValue);
            Instantiate(destroyVFX_Type, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
