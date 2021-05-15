using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIControlador : MonoBehaviour
{
    Player player;
    Text distanceText;

    GameObject Resultado;
    Text DistanciaFinalTexto;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();

        DistanciaFinalTexto = GameObject.Find("DistanciaFinalTexto").GetComponent<Text>();
        Resultado = GameObject.Find("Resultado");
        Resultado.SetActive(false);
    }




    void Start()
    {
        
    }




    void Update()
    {
        int distance = Mathf.FloorToInt(player.distance);
        distanceText.text = distance + "m";

        if (player.isDead)
        {
            Resultado.SetActive(true);
            DistanciaFinalTexto.text = distance + " m";
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
