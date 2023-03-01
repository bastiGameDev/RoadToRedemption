
using UnityEngine;

public class TriggerEnterTest : MonoBehaviour
{
   // private ContusionController _contusionController;
    
    [SerializeField] private GameObject fadedCanvas;
    private void OnTriggerEnter(Collider other)
    {
        fadedCanvas.SetActive(true);
        Debug.Log("Цвет был изменён");
        Debug.Log("Сработал триггер!");
    }
}
