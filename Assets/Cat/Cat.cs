using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField] public float Speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Speed, 0, 0);
    }
    public void ChangeSpeed()
    {
        gameObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity * -1;
        Vector3 rotate = gameObject.transform.eulerAngles;
        rotate.y = rotate.y * -1;
        gameObject.transform.rotation = Quaternion.Euler(rotate);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Heart")
            other.gameObject.GetComponent<HeartScript>().GetHeart();
    }
}
