using UnityEngine;
using UnityEngine.Serialization;

public class TrampolineSpawner : MonoBehaviour
{
    //TODO:Buscar como instanciar un gameobject
    //Como instanciarlo con el boton del mouse sobre el puntero
    //Como estirar el gameobject


    public GameObject trampolineSpawn;
    public Camera camera;
    public float distance = 10f;
    public LayerMask collisionLayer;
    [FormerlySerializedAs("puntoDeSpawn")] public Transform spawnPoint;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse Detectado");
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            Vector3 instancePoint = ray.origin + ray.direction * distance;

            Instantiate(trampolineSpawn, instancePoint, Quaternion.identity);
            Debug.Log("spawneado sobre:" + instancePoint);
        }
        else
        {
            Debug.Log("No se puede realizar el trampoline spawn");
        }
    }
}