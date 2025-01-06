using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Collectible : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float rotationSpeed;
    public GameObject onCollectEffect;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy the collectible
        Destroy(gameObject);

        //Which object do we want to instantiate? The onCollectEffect.
        //What position should we instantiate it at? My current position(transform.position).
        //What rotation should it have when it’s instantiated? My current rotation(transform.rotation).

        // transform.position and transform.rotation refer to the collectible’s position and rotation since this script is attached to the collectible object. 

        Instantiate(onCollectEffect, transform.position, transform.rotation);


    }

}
