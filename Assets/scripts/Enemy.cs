using UnityEngine;

public class Enemy : MonoBehaviour , damage
{
    public Color color;
    private SpriteRenderer renderer;

    private Color startColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        startColor = renderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(){
        // renk degisimi
        renderer.color = color;

        Invoke("ReverseColor", 0.5f);
    }

    private void ReverseColor()
    {
        renderer.color = startColor;    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Damage();
            Movement playerScript = other.gameObject.GetComponent<Movement>();
            playerScript.PlayMeeleAnimation();
        }
    }
}
