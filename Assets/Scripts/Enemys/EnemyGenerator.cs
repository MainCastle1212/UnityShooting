﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.PlayerLoop;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private EnemyController EnemyPrefab;
    [SerializeField] private float Span = 1;
    [SerializeField] private float Accselarate = 1.02f;
    [SerializeField] [Range(0, 1)] private float MultiEnemy = 0.2f;
    [SerializeField] [Range(0, 1)] private float ResetSpanTime = 0.7f;

    private float SpanBaffa;
    private float speedBaffa;
    private float DiffChangeCount = 0.01f;
    private float speedChangeTest = 0.01f;
    private void Start()
    {
        SpanBaffa = Span;
        speedBaffa = speedChangeTest;
        StartCoroutine(CreateEnemy());
        StartCoroutine(ChangeSpan());
    }

    IEnumerator ChangeSpan()
    {
        while (true)
        {
            Span /= Accselarate;
            if (Span < ResetSpanTime)
            {
                Span = SpanBaffa - DiffChangeCount;
                speedChangeTest = speedBaffa + DiffChangeCount;
                ResetSpanTime += DiffChangeCount;

                DiffChangeCount += 0.01f;
            }
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator CreateEnemy()
    {
        while (true)
        {
            var rnd = Random.Range(-3, 3f);
            var enemys = new List<EnemyController>();

            enemys.Add(Instantiate(EnemyPrefab, new Vector3(rnd, 6, 0), Quaternion.identity));
            if (Random.Range(0, 1f) < MultiEnemy)
            {
                enemys.Add(Instantiate(EnemyPrefab, new Vector3(rnd + 0.8f, 7f, 0), Quaternion.identity));
                enemys.Add(Instantiate(EnemyPrefab, new Vector3(rnd - 0.8f, 7f, 0), Quaternion.identity));
            }
            foreach (var es in enemys)
            {
                es.Speed += speedChangeTest;
            }
            speedChangeTest += 0.05f;
            yield return new WaitForSeconds(Span);
        }
    }

}
