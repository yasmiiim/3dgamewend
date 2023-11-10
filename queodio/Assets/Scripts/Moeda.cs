using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moeda : MonoBehaviour
{
    public static int pontuacao;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pontuacao = pontuacao + 1;
            Debug.Log("Pontuacao: " + pontuacao);
            Destroy(gameObject);
           

         
        }

    }
}
