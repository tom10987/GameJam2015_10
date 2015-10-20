using UnityEngine;
using System.Collections;

public class PlayerJumper : MonoBehaviour {

    [SerializeField]
    float _jumpPower;
    bool _isJump = false;

    PlayerParameter playerParameter;

    public Vector3 playerPosition { get { return gameObject.transform.position; } }

    void Start ()
    {
       
        playerParameter = GetComponent<PlayerParameter>();
        _jumpPower = playerParameter.getJumpPower;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerJump();
        }
    }

    public void PlayerJump()
    {
        if (_isJump == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
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
