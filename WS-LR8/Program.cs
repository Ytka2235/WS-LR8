internal class Program
{
    private static void Main(string[] args)
    {
        Users users = new Users();
        users.AddUser("qwe","qwe");
        users.AddUser("Игорь","12232132");
        users.AddUser("ytka","123jh8");
        users.AddUser("lololo","909GYos");
        users.AddUser("1234578","kjsa89o");
        users.AddUser("ghost","lm832");
        for (int i = 0;i<users.GetLenght();i++) { users.WriteUser(i); }
    }
}

class password : MyArray<string>
{ }
class login : MyArray<string>
{ }

class Users
{
    password passwords;
    login logins;
    public Users()
    {
        passwords = new password();
        logins = new login();
    }

    public void WriteUser(int id)
    {
        if(logins.GetLenght()>id) Console.WriteLine($"логин: {logins.GetItem(id)}  пароль: {passwords.GetItem(id)}");
    }

    public void AddUser(string login,string password)
    {
        logins.Add(login);
        passwords.Add(password);
    }

    public int GetLenght()
    {
        return logins.GetLenght();
    }
}


class MyArray<T>
{
    T[] array;
    public MyArray() { array = new T[0]; }
    public MyArray(params T[] array)
    {
        this.array = array;
    }

    public void Add(T t)
    {
        T[] array = new T[this.array.Length + 1];
        for (int i = 0; i < this.array.Length; i++) array[i] = this.array[i];
        array[this.array.Length] = t;
        this.array = array;
    }

    public void Del(int id)
    {
        if (this.array.Length > id)
        {
            T[] array = new T[this.array.Length - 1];
            for (int i = 0; i < id; i++) array[i] = this.array[i];
            for (int i = id; i < this.array.Length - 1; i++) array[i] = this.array[i + 1];

            this.array = array;
        }
    }
    public T GetItem(int i)
    {
        return this.array[i];
    }
    public int GetLenght()
    {
        return this.array.Length;
    }

}