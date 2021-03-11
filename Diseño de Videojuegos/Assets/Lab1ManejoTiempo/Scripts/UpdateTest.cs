 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTest : MonoBehaviour {

    private void OnEnable()
    {
        Debug.Log("Enabled");
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    void Start()
    {
        Debug.Log("Start");
        //CountFiveSeconds();
        //StartFakeUpdate();
    }

    void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    public void CountFiveSeconds()
    {
        StartCoroutine(CountTime(5f));
    }

    public void StartFakeUpdate()
    {
        StartCoroutine(FakeUpdate());
    }

    IEnumerator CountTime(float t)
    {
        yield return new WaitForSeconds(t);
        Debug.Log("5 seconds passed");
    }

    IEnumerator FakeUpdate()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();
            Debug.Log("FakeUpdate");
        }
    }
}