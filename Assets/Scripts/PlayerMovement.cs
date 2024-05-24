using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpPower = 10; //�W�����v�̃p�����[�^
    private Vector3 jumpVel;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //Player�ɐݒ肵��Rigidbody���擾����
        rb = GetComponent<Rigidbody>();
        jumpVel = new Vector3(0, jumpPower, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //�X�y�[�X�L�[���������u��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�͂�������i�������jumpPower���͂�������j
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
