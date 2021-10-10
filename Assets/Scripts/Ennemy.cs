using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Ennemy : MonoBehaviour
{
    public int Degats = 1;
    public int Prix = 2;

    public static List<Ennemy> ennemy = new List<Ennemy>();

    public void Awake()
    {
        ennemy.Add(this);
    }

    public void Start()
    {
        _maxHealth = Health;
    }

    public void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = GameObject.FindWithTag("Défense").transform.position;
        if (IsDead)
        {
            BoutonTour.Argent += Prix;
            Destroy(gameObject);
        }
        if (IsDead && Prix == 50) SceneManager.LoadScene("Win");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Défense"))
        {
            other.GetComponent<Défense>().Health -= Degats;
            Destroy(gameObject);
            
        }
    }
    public bool IsDead { get; set; }
    public float _health = 1;
    private float _maxHealth;

    public float Health
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

    public Ennemy(int health)
    {
        Health = health;
    }
}
