using UnityEngine;
using System.Collections;

public class PlayerJumper : MonoBehaviour {

    [SerializeField]
    float _jumpPower;
    bool _isJump = false;

    float jumpPower = 0;

    PlayerParameter playerParameter;

    public Vector3 playerPosition { get { return gameObject.transform.position; } }
    RectTransform rectTrans = null;
    Vector2 startPos = Vector2.zero;

    void Start ()
    {
        rectTrans = GetComponent<RectTransform>();
        startPos = rectTrans.anchoredPosition;

         playerParameter = GetComponent<PlayerParameter>();
       // _jumpPower = playerParameter.getJumpPower;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerJump();
        }

        if (_isJump)
        {
            rectTrans.anchoredPosition = new Vector2(rectTrans.anchoredPosition.x, rectTrans.anchoredPosition.y + jumpPower);
            jumpPower -= 0.5f;

            if(rectTrans.anchoredPosition.y < -80)
            {
                _isJump = false;
                rectTrans.anchoredPosition = startPos;
            }
        }
    }

    public void PlayerJump()
    {
        if (_isJump != true)
        {
            jumpPower = _jumpPower;
            //gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
            _isJump = true;
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
