using System.Collections;
using UnityEngine;

public class shakegun : MonoBehaviour
{
    public bool start = false;
    public AnimationCurve curve;
    public float dueation = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {

            start = false;
            StartCoroutine(Zoomin());
        }

        IEnumerator Zoomin()
        {
            Vector3 startPosittion = transform.position;
            float elapsedTime = 0f;
            while (elapsedTime < dueation)
            {
                elapsedTime += Time.deltaTime;
                float strength = curve.Evaluate(elapsedTime / dueation);
                transform.position = startPosittion + Random.insideUnitSphere *strength;

                yield return null;

            }

            transform.position = startPosittion; 


        }


    }
}
    

        
