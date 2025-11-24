using UnityEngine;

public class RenderTextureChanger_PK :  MonoBehaviour
{

    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;

    private int currentTarget;



    void Start()
    {
        currentTarget = 1;
        SetTexture(currentTarget);
    }
    public void SetTexture(int num)
    {

        {
        }

        camera1.SetActive(num == 1);
        camera2.SetActive(num == 2);
        camera3.SetActive(num == 3);
        camera4.SetActive(num == 4);

    }

}

