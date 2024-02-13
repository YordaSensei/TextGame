using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestScript : MonoBehaviour
{
    public string helloWorld;
    private int X;
    public GameObject Cube;
    public bool isOn;

    public GameObject scene_1, scene_2;
    public GameObject endingScene;
    public GameObject stats;
    public TextMeshProUGUI healthValue, currency;
    public int healthPoints, currencyPoints;

    // Start is called before the first frame update
    void Start()
    {
        scene_1.SetActive(true);
        scene_2.SetActive(false);
        stats.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        CubeOnAndOff();

    }

    void CubeOnAndOff()
    {
        if (isOn)
        {
            Cube.SetActive(true);
        }
        else
        {
            Cube.SetActive(false);
        }
    }

    public void StartButton()
    {
        scene_1.SetActive(false);
        scene_2.SetActive(true);
    }


}