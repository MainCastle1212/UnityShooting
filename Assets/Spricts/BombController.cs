﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour, IDestroyable
{
    [SerializeField] private float Speed = 10;
    [SerializeField] private float ShakeEffectPow = 0.15f;
    [SerializeField] private float ShakeEffectTime = 0.5f;

    private GameObject UI_Manager;
    private void Start()
    {
        UI_Manager = GameObject.Find("UI_Manager");
    }
    void Update()
    {
        transform.Translate(0, -Speed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            KillAllEnemys();
            Destroy();
        }
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
    public void KillAllEnemys()
    {
        var enemys = GameObject.FindGameObjectsWithTag("Enemy");
        var enemysNum = enemys.Length;

        HitEffectCamera.HitEffect(ShakeEffectTime, ShakeEffectPow * (1 + enemysNum / 10));
        UI_Manager.GetComponent<Score>().AddScore(enemysNum);

        foreach (var es in enemys)
        {
            Destroy(es);
        }
    }
}