using UnityEngine;
using UnityEngine.InputSystem;
public class HeartScript : MonoBehaviour
{
    Camera m_Camera;
    [SerializeField] AudioClip Clip;
    [SerializeField] public float SpeedDown = 0.1f;
    public Vector3 _rotor = new Vector3(0,1f,0);
    void Awake()
    {
        m_Camera = Camera.main;
    }

    private void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, SpeedDown * -1);
    }

    void FixedUpdate()
    {
        transform.eulerAngles += _rotor;
    }

    private void OnMouseDown()
    {
        if (!StateLevel.IsGamePause)
            GetHeart();
    }
    public void GetHeart()
    {
        GameObject.FindGameObjectWithTag("OtherSound").GetComponent<AudioSource>().clip = Clip;
        GameObject.FindGameObjectWithTag("OtherSound").GetComponent<AudioSource>().Play();

        StateLevel.NHears += MainScript.SHeartClick;
        Destroy(gameObject);
    }
}
