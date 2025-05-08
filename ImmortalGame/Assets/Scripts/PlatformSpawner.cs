using System;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    //TODO: Raycast2D para comprobar si el mouse está tocando una plataforma para poder spawnear
    
    public GameObject platformPrefab;
    public float spawnHeight = 0f;
    public float distanceBetweenPlatforms = 0.1f;
    
    private Vector3 lastSpawnPosition;
    private bool IsSpawning = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detectar si el botón izquierdo del mouse ha sido presionado¿
        {
            IsSpawning = true;
            lastSpawnPosition = GetMouseWorldPosition();
            SpawnPlatform(lastSpawnPosition);
        }

        if (Input.GetMouseButtonUp(0))
        {
            IsSpawning = false;
        }

        if (IsSpawning)
        {
            Vector3 mousePos = GetMouseWorldPosition();
            float distance = Vector3.Distance(mousePos, lastSpawnPosition);
            Debug.Log($"distance {distance}");

            if (distance >= distanceBetweenPlatforms)
            {
                lastSpawnPosition = mousePos;
                SpawnPlatform(lastSpawnPosition);
            }
        }
    }

    Vector3 GetMouseWorldPosition()
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return new Vector3(mousePosition.x, mousePosition.y, spawnHeight); // Ajustá Z o Y según tu escena
        }

        void SpawnPlatform(Vector3 position)
        {
            Instantiate(platformPrefab, position, Quaternion.identity);
        }
    }

    