using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    EntityStats player_stats;

    public Slider hp_bar;

    private void Start()
    {
        player_stats = GameObject.FindGameObjectWithTag("Player").GetComponent<EntityStats>();
    }

    private void Update()
    {
        PlayerHP();
    }

    void PlayerHP()
    {
        hp_bar.maxValue = player_stats.max_hp;
        hp_bar.value = player_stats.hp;
    }
   
}
