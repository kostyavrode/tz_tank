using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TankHP : MonoBehaviour
{
    public static Action onPlayerDeath;
    public static bool isPlayerAlive;
    [SerializeField] private int hp;
    [SerializeField] private TMP_Text hpText;
    private void Awake()
    {
        isPlayerAlive = true;
    }
    public void ReceiveDamage()
    {
        hp--;
        hpText.text = hp.ToString();
        if(hp<1)
        {
            Destroy(gameObject);
            isPlayerAlive = false;
            onPlayerDeath?.Invoke();
        }
    }
}
