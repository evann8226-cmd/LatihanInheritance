siswa siswaObj = new siswa("Evan", "Evan@gmail.com", "12345", "siswa", "XPG2");
guru guruObj = new guru("kuyang", "kuyang@gmail.com", "12345", "guru", "coding");


class user
{
    public string Nama;
    public string Email;
    public string Pasword;
    public string Role;

    public user(string name, string email, string pasword,string role)
    {
        Nama = name;
        Email = email;
        Pasword = pasword;
        Role = role;

    }
    
    public void TampilanInfo()
    {
        Console.WriteLine("Menampilkan info user.....");
        Console.WriteLine($"Nama:  {Nama}");
        Console.WriteLine($"Role:  {Role}");
    }

}


class siswa : user
{
    public string ClasName;

    public siswa(string name, string email, string pasword, string role, string classname) : base(name, email, pasword, role)
    {
        ClasName = classname;
    }

    public void SubmitTugas()
    {
        Console.WriteLine($"Siswa {Nama} sudah mengumpulkan tugas");
    }
} 

class guru : user
{
    public string Mapel;

    public guru(string name, string email, string pasword, string role, string mapel) : base(name, email, pasword, role)
    {
        Mapel = mapel;
    }

    public void Nilai()
    {
        Console.WriteLine($"guru {Nama} sudah memberi nilai");
    }
}