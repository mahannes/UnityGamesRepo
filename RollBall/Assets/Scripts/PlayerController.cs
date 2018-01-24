using Assets.Interfaces;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour, IPlayerController
{

    public float Speed;
    private Rigidbody2D _rb2d;
    private int count = 0;

    public event PropertyChangedEventHandler PropertyChanged;


    // Use this for initialization
    void Start ()
    {
		_rb2d = this.GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update ()
    {
	}

    private void FixedUpdate()
    {
        var moveVertical = Input.GetAxis("Vertical");
        var moveHorizontal = Input.GetAxis("Horizontal");

        _rb2d.AddForce(new Vector2(moveHorizontal, moveVertical) * Speed);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            Count++;
        }
    }

    public int Count
    {
        get
        {
            return count;
        }
        set
        {
            if (count != value)
            {
                count = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Count"));
            }
        }
    }
}
