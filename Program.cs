using System;
using System.Collections.Generic;

// 1. Class & Object: Class Motor
public class Motor
{
    // Encapsulation & Data Hiding: Properti private
    private string _merk;
    private string _model;
    private string _platNomor;
    private bool _isBersih;

    // Public Properties untuk mengakses data
    public string Merk
    {
        get { return _merk; }
        private set { _merk = value; } // Set bisa private jika ingin kontrol lebih
    }

    public string Model
    {
        get { return _model; }
        private set { _model = value; }
    }

    public string PlatNomor
    {
        get { return _platNomor; }
        private set { _platNomor = value; }
    }

    public bool IsBersih
    {
        get { return _isBersih; }
        set { _isBersih = value; } // Setter publik karena status kebersihan bisa berubah
    }

    // 2. Constructor
    public Motor(string merk, string model, string platNomor)
    {
        Merk = merk;
        Model = model;
        PlatNomor = platNomor;
        IsBersih = false; // Motor awalnya kotor
        Console.WriteLine($"Motor {Merk} {Model} dengan plat nomor {PlatNomor} telah didaftarkan.");
    }

    public void TampilkanStatus()
    {
        Console.WriteLine($"\n--- Detail Motor ---");
        Console.WriteLine($"Merk: {Merk}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Plat Nomor: {PlatNomor}");
        Console.WriteLine($"Status Kebersihan: {(IsBersih ? "Bersih" : "Kotor")}");
    }
}
