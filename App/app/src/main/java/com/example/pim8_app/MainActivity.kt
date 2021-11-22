package com.example.pim8_app

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.Spinner

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val buttonTelTipo = findViewById<Button>(R.id.button_tel_tipo)
        buttonTelTipo.setOnClickListener {
            val intent = Intent(this, TelefonesTipos::class.java)
            startActivity(intent)
        }

        val buttonTel = findViewById<Button>(R.id.button_tel)
        buttonTel.setOnClickListener {
            val intent = Intent(this, Telefones::class.java)
            startActivity(intent)
        }

        val buttonAddress = findViewById<Button>(R.id.button_address)
        buttonAddress.setOnClickListener {
            val intent = Intent(this, Enderecos::class.java)
            startActivity(intent)
        }

        val buttonPeople = findViewById<Button>(R.id.button_people)
        buttonPeople.setOnClickListener {
            val intent = Intent(this, Pessoas::class.java)
            startActivity(intent)
        }


    }


}