using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerDeath_SFX : MonoBehaviour
{
    public AudioSource deathSource;
    public PlayerStats playerStats;
    // Start is called before the first frame update

    private void Start()
    {
        playerStats = FindObjectOfType<PlayerStats>();
    }
    // Update is called once per frame
    void Update()
    {
        if (playerStats.health <= 0)
        {
            deathSource.Play();
        }
       
    }
}
