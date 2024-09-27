using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    public int Coins = 0;
    Rigidbody rb;
    public TextMeshProUGUI coinsText;
    public AudioClip coinSFX;
    public AudioClip coin2SFX;
    // Update is called once per frame

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        rb.AddForce(transform.up * 1000f * Time.deltaTime, ForceMode.Impulse);
        }
        Vector3 movement = new Vector3();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        rb.AddForce(movement * 30f * Time.deltaTime, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoinItem"))
        {
            Coins = Coins + 1;
            
            Debug.Log("He tocado una moneda");
            
            Debug.Log("Tenemos " + Coins + " Monedas");

            AudioSource.PlayClipAtPoint(coinSFX, transform.position);
        }
        if (other.CompareTag("CoinItem2"))
        {
            Coins += 5;

            Debug.Log("He tocado una moneda Especial");

            Debug.Log("Tenemos " + Coins + " Monedas");
            
            AudioSource.PlayClipAtPoint(coin2SFX, transform.position);
        }
        if (other.tag.Contains("CoinItem"))
        {
            coinsText.text = Coins.ToString();
            other.gameObject.SetActive(false);
            
        }
    }
}
