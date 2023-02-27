using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTextPhone : MonoBehaviour
{
    public GameObject InfoTextObject;

    void Start()
    {
        InfoTextObject.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("phone"))
        {
            InfoTextObject.SetActive(true);
            StartCoroutine(End());

        }

        IEnumerator End()
        {
            yield return new WaitForSeconds(6);
            InfoTextObject.SetActive(false);

        }
    }
}