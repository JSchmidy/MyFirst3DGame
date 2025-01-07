using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BlueCoin : MonoBehaviour
{
    public float rotateSpeed = 180.0f;

    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private FloatSO scoreSO;

    void Start()
    {
        scoreText.text = scoreSO.Value + "";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreSO.Value += 3;
            scoreText.text = scoreSO.Value + "";
            Destroy(gameObject);
        }
    }
}
