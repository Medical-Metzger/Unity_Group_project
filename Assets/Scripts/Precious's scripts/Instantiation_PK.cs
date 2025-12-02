using UnityEngine;
using UnityEngine.UI;

public class Instantiation_PK : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Capsule;

    public int maxNb = 10000;

    public int index = 0;

    public Slider mySlider;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (index < maxNb)
            {

                Instantiate(Capsule, transform.position, Quaternion.identity);
                index++;

                mySlider.value = (float)index / (float)maxNb;
                Debug.Log(mySlider.value);
                ;
            }
        }

    }
}
