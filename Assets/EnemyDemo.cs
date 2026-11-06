using UnityEngine;

public class EnemyDemo : MonoBehaviour
{
    private int HEALTH = 100; // Gives enemy 100 starting health
    private int SPEED = 3; // Gives enemy 3 starting speed

    void TakeDamage(int damage) // Take damage function
    {
        HEALTH -= damage;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Starting stats
        Debug.Log("Enemy Spawned");
        Debug.Log("Health: " + HEALTH);
        Debug.Log("Speed: " + SPEED);

        // Damaged stats
        TakeDamage(50);
        Debug.Log("Damaged Health: " + HEALTH);

        // Creating a character NPC 
        NPC character = new Enemy(); // Assign enemy object
        character.MakeSound();

        character = new Friend(); // Assign friend object
        character.MakeSound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class NPC // Default npc class
{
    public virtual void MakeSound() // Generic sound function
    {
        Debug.Log("Generic NPC Sound");
    }
}

public class Enemy : NPC // Enemy class using polymorphism from parent NPC
{
    public override void MakeSound() // Overridden enemy sound function
    {
        Debug.Log("GRRRRR!");
    }
}

public class Friend : NPC // Friend Class using polymorphism from parent NPC
{
    public override void MakeSound() // Overridden friend sound function
    {
        Debug.Log("Hello Player!");
    }
}


