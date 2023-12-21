using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character : MonoBehaviour
{
    public List<Sprite> man;
    public List<Sprite> woman;
    public List<string> attributs;

    public float runSpeed = 0.3f;
    private string gender = "no";

    private Rigidbody2D rigibody;

    private SpriteRenderer spriteRenderer;

    

    void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        rigibody.velocity = new Vector2(Mathf.Abs(Input.GetAxisRaw("Horizontal")) * runSpeed, Input.GetAxisRaw("Vertical") * runSpeed);
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }

    void ChangeOfAge()
    {
        if (attributs.Count == 1)
        {
            if (attributs[0] == "мужской пол")
            {
                spriteRenderer.sprite = man[0];
            }
            else if (attributs[0] == "женский пол")
            {
                spriteRenderer.sprite = woman[0];
            }
            runSpeed = 3;
        }
        if (attributs.Count == 2)
        {
            if (attributs[0] == "мужской пол")
            {
                spriteRenderer.sprite = man[1];
            }
            else if (attributs[0] == "женский пол")
            {
                spriteRenderer.sprite = woman[1];
            }
            runSpeed = 4;
        }
        if (attributs.Count == 3)
        {
            if (attributs[0] == "мужской пол")
            {
                spriteRenderer.sprite = man[2];
            }
            else if (attributs[0] == "женский пол")
            {
                spriteRenderer.sprite = woman[2];
            }
            runSpeed = 6;
        }
        if (attributs.Count == 4)
        {
            if (attributs[0] == "мужской пол")
            {
                spriteRenderer.sprite = man[3];
            }
            else if (attributs[0] == "женский пол")
            {
                spriteRenderer.sprite = woman[3];
            }
            runSpeed = 8;
        }
        if (attributs.Count == 5)
        {
            if (attributs[0] == "мужской пол")
            {
                spriteRenderer.sprite = man[4];
            }
            else if (attributs[0] == "женский пол")
            {
                spriteRenderer.sprite = woman[4];
            }
            runSpeed = 12;
        }
        if (attributs.Count == 6)
        {
            if (attributs[0] == "мужской пол")
            {
                spriteRenderer.sprite = man[5];
            }
            else if (attributs[0] == "женский пол")
            {
                spriteRenderer.sprite = woman[5];
            }
            runSpeed = 8;
        }
        if (attributs.Count == 7)
        {
            if (attributs[0] == "мужской пол")
            {
                spriteRenderer.sprite = man[6];
            }
            else if (attributs[0] == "женский пол")
            {
                spriteRenderer.sprite = woman[6];
            }
            runSpeed = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        attributs.Add(col.name);
        col.gameObject.SetActive(false);
        ChangeOfAge();

    }
}
