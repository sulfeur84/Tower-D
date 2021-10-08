using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Défense : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        _maxHealth = Health;
    }

    public void Update()
    {
        if(IsDead) Destroy(gameObject);
    }

    public bool IsDead { get; set; }
    public int _health = 4;
    private float _maxHealth;

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            if (_health <= 0) IsDead = true;
            
            GetComponent<Renderer>().material.color = new Color(1, (Health/_maxHealth), 0);
        }
    }

    public Défense(int health)
    {
        Health = health;
    }
}


