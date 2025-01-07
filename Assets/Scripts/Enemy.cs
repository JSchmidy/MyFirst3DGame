using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public float speed;
    public Vector3 moveOffset;
    private Vector3 targetPos;
    private Vector3 startPos;

    [SerializeField]
    private TMP_Text heartsText;
    [SerializeField]
    private FloatSO heartsSO;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        targetPos = startPos;

        heartsText.text = heartsSO.Hearts + "";
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        
        if(transform.position == targetPos)
        {
            if(targetPos == startPos)
            {
                targetPos = startPos + moveOffset;
            }
            else
            {
                targetPos = startPos;
            }
        }
    }
    private void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().transform.position = new Vector3(0, 0, 0);
            heartsSO.Hearts -= 1;
            heartsText.text = heartsSO.Hearts + "";
        }
    }
}