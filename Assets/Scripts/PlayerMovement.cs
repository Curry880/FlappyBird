using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpPower = 10; //ジャンプのパラメータ
    private Vector3 jumpVel;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //Playerに設定したRigidbodyを取得する
        rb = GetComponent<Rigidbody>();
        jumpVel = new Vector3(0, jumpPower, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーを押した瞬間
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //力を加える（上向きにjumpPower分力を加える）
            //rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
            rb.velocity = jumpVel;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
            //Debug.Log("GameOver");
            GameManager.instance.GameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            //Debug.Log("AddScore");
            ScoreManager.instance.AddScore(100);
        }
    }
}
