package com.example.pim8_app

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class Enderecos : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_enderecos)

        val buttonNew = findViewById<Button>(R.id.button_new)
        buttonNew.setOnClickListener {
            goToForm()
        }
        val buttonEdit = findViewById<Button>(R.id.button_edit)
        buttonEdit.setOnClickListener {
            goToForm()
        }

    }

    fun goToForm() {
        val intent = Intent(this, EnderecosForm::class.java)
        startActivity(intent)
    }
}