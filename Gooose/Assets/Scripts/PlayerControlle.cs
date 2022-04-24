using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngineInternal;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControlle : MonoBehaviour
{
    private bool hasKey;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float speed;
    [SerializeField] private Transform[] points = new Transform[2];

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (transform.position.x >= points[0].position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (transform.position.x <= points[1].position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Lock" && hasKey == true)
        {
            SceneManager.LoadScene(0);
            Debug.Log("Вы прошли уровень!");
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Key"))
        {
            hasKey = true;
            Destroy(col.gameObject);
        }
    }
}


