using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DesignandCode
{
    public abstract class Contact
    {
        private string name;
        private string surname;
        private int tlf;
        private string DNI;
        private Adress adress;

    }

    public struct Adress
    {
        public string street;
        public int number;
        public string other;
        public string city;
        public string country;
        public string state;
        public int zip;
    }

    public class Users : Contact
    {
        public string email;
        private string password;

        public bool Validate(string email, string password)
        {
            return email != null && password != null;
        }
    }
}
