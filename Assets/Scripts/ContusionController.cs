using System;
using System.Threading.Tasks;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.UI;


public class ContusionController : MonoBehaviour
{
    [SerializeField] private GameObject fadedCanvas;
    [SerializeField] private AudioSource contusionSound;

    private async void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            contusionSound.Play();
            
            fadedCanvas.SetActive(true);
           
            await Task.Delay(14000);
            
            fadedCanvas.SetActive(false);
            
        }
    }

    private void ContusionStart()
    {
        fadedCanvas.SetActive(true);
        Debug.Log("Цвет был изменён");
    }
}
