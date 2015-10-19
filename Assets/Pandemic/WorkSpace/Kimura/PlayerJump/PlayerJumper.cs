using UnityEngine;
using System.Collections;

public class PlayerJumper : MonoBehaviour {

    [SerializeField]
    float _jumpForce = 400.0f;
    bool _isJump = false;

	void Start ()
    {
	
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerJump();
        }
        }

        void PlayerJump()
    {
        if (_isJump == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _isJump = false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            _isJump = true;
        }
    }

}
